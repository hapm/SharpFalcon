namespace SharpFalconApp
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblForceX = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbForceX = new System.Windows.Forms.TrackBar();
            this.tbForceZ = new System.Windows.Forms.TrackBar();
            this.tbForceY = new System.Windows.Forms.TrackBar();
            this.txtButtons = new System.Windows.Forms.TextBox();
            this.lblForceY = new System.Windows.Forms.Label();
            this.lblForceZ = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForceX
            // 
            this.lblForceX.AutoSize = true;
            this.lblForceX.Location = new System.Drawing.Point(14, 105);
            this.lblForceX.Margin = new System.Windows.Forms.Padding(14, 5, 3, 0);
            this.lblForceX.Name = "lblForceX";
            this.lblForceX.Size = new System.Drawing.Size(14, 13);
            this.lblForceX.TabIndex = 0;
            this.lblForceX.Text = "X";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.54808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.45192F));
            this.tableLayoutPanel1.Controls.Add(this.tbForceX, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbForceZ, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbForceY, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtButtons, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblForceX, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblForceY, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblForceZ, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPosition, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblModel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPosition, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnStartStop, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbForceX
            // 
            this.tbForceX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForceX.Location = new System.Drawing.Point(74, 103);
            this.tbForceX.Maximum = 100;
            this.tbForceX.Minimum = -100;
            this.tbForceX.Name = "tbForceX";
            this.tbForceX.Size = new System.Drawing.Size(329, 24);
            this.tbForceX.TabIndex = 12;
            this.tbForceX.Scroll += new System.EventHandler(this.tbForceX_Scroll);
            // 
            // tbForceZ
            // 
            this.tbForceZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForceZ.Location = new System.Drawing.Point(74, 163);
            this.tbForceZ.Maximum = 100;
            this.tbForceZ.Minimum = -100;
            this.tbForceZ.Name = "tbForceZ";
            this.tbForceZ.Size = new System.Drawing.Size(329, 24);
            this.tbForceZ.TabIndex = 11;
            this.tbForceZ.Scroll += new System.EventHandler(this.tbForceZ_Scroll);
            // 
            // tbForceY
            // 
            this.tbForceY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbForceY.Location = new System.Drawing.Point(74, 133);
            this.tbForceY.Maximum = 100;
            this.tbForceY.Minimum = -100;
            this.tbForceY.Name = "tbForceY";
            this.tbForceY.Size = new System.Drawing.Size(329, 24);
            this.tbForceY.TabIndex = 10;
            this.tbForceY.Scroll += new System.EventHandler(this.tbForceY_Scroll);
            // 
            // txtButtons
            // 
            this.txtButtons.Location = new System.Drawing.Point(74, 78);
            this.txtButtons.Name = "txtButtons";
            this.txtButtons.ReadOnly = true;
            this.txtButtons.Size = new System.Drawing.Size(328, 20);
            this.txtButtons.TabIndex = 8;
            // 
            // lblForceY
            // 
            this.lblForceY.AutoSize = true;
            this.lblForceY.Location = new System.Drawing.Point(14, 135);
            this.lblForceY.Margin = new System.Windows.Forms.Padding(14, 5, 3, 0);
            this.lblForceY.Name = "lblForceY";
            this.lblForceY.Size = new System.Drawing.Size(14, 13);
            this.lblForceY.TabIndex = 4;
            this.lblForceY.Text = "Y";
            // 
            // lblForceZ
            // 
            this.lblForceZ.AutoSize = true;
            this.lblForceZ.Location = new System.Drawing.Point(14, 165);
            this.lblForceZ.Margin = new System.Windows.Forms.Padding(14, 5, 3, 0);
            this.lblForceZ.Name = "lblForceZ";
            this.lblForceZ.Size = new System.Drawing.Size(14, 13);
            this.lblForceZ.TabIndex = 5;
            this.lblForceZ.Text = "Z";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(74, 53);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(328, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 57);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(74, 3);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(328, 20);
            this.txtModel.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosition.Location = new System.Drawing.Point(3, 32);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 18);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(3, 7);
            this.lblModel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(74, 28);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(328, 20);
            this.txtPosition.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buttons";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(3, 204);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(65, 19);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 200;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "FalconTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForceY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButtons;
        private System.Windows.Forms.Label lblForceX;
        private System.Windows.Forms.Label lblForceY;
        private System.Windows.Forms.Label lblForceZ;
        private System.Windows.Forms.TrackBar tbForceY;
        private System.Windows.Forms.TrackBar tbForceX;
        private System.Windows.Forms.TrackBar tbForceZ;
    }
}

