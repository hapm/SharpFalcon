using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpFalcon.HDL.Native;

namespace SharpFalcon.HDL
{
    public class DeviceForce
    {
        private HapticDevice device;
        private double[] force;

        internal DeviceForce(HapticDevice dev)
        {
            this.device = dev;
            force = new double[3];
        }

        public double X
        {
            get { return force[0]; }
            set
            {
                force[0] = value;
            }
        }

        public double Y
        {
            get { return force[1]; }
            set
            {
                force[1] = value;
            }
        }

        public double Z
        {
            get { return force[2]; }
            set
            {
                force[2] = value;
            }
        }

        public void Update()
        {
            NativeMethods.hdlSetToolForce(force);
        }
    }
}
