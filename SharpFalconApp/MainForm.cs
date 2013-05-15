using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpFalcon.HDL;

namespace SharpFalconApp
{
    public partial class MainForm : Form
    {
        DeviceManager mgr;
        HapticDevice dev;
        DeviceLoopOperation op;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mgr = DeviceManager.Instance;
            if (mgr.Count == 0)
            {
                MessageBox.Show("Diese Anwendung funktioniert nur, wenn Sie einen Novint Falcon an Ihren Computer angeschlossen haben. Stellen Sie sicher das dem so ist und die benötigten Treiber installiert sind! Starten Sie dann die Anwendung erneut", "Falcon nicht gefunden", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                dev = mgr[0];
                UpdateDeviceDisplay();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mgr.Dispose();
            mgr = null;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            UpdateDeviceDisplay();
        }

        private void UpdateDeviceDisplay()
        {
            Vector3d pos = dev.Position;
            txtModel.Text = dev.Model;
            txtPosition.Text = String.Format("X:{0:G6}, Y:{1:G6}, Z:{2:G6}", pos.X, pos.Y, pos.Z);
            txtStatus.Text = mgr.Status.ToString();
            if (dev.IsButtonPressed)
            {
                StringBuilder strB = new StringBuilder("Pressed: ");
                DeviceButtonState btns = dev.ButtonState;
                txtButtons.Text = "Pressed: " + btns.ToString();
            }
            else
            {
                txtButtons.Text = "Nothing pressed";
            }
        }

        private bool TestOperation(HapticDevice device)
        {
            device.Force.Update();
            return true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (mgr.IsRunning)
            {
                mgr.Stop();
            }
            else
            {
                mgr.Start();
            }

            if (op != null)
            {
                dev.UnregisterDeviceLoopOperation(op);
                op = null;
            }
            else
            {
                op = dev.RegisterDeviceLoopOperation(TestOperation, false);
            }

            bool running = mgr.IsRunning;
            UpdateDeviceDisplay();
            updateTimer.Enabled = running;
            btnStartStop.Text = running ? "Stop" : "Start";
        }

        private void tbForceX_Scroll(object sender, EventArgs e)
        {
            dev.Force.X = ((double)tbForceX.Value)/10;
        }

        private void tbForceY_Scroll(object sender, EventArgs e)
        {
            dev.Force.Y = ((double)tbForceY.Value) / 10;
        }

        private void tbForceZ_Scroll(object sender, EventArgs e)
        {
            dev.Force.Z = ((double)tbForceZ.Value) / 10;
        }
    }
}
