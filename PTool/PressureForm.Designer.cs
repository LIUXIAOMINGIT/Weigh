namespace PTool
{
    partial class PressureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PressureForm));
            this.tlpParameter = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDeviceNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceSerialPort = new System.Windows.Forms.ComboBox();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picCloseWindow = new System.Windows.Forms.PictureBox();
            this.picConnectState = new System.Windows.Forms.PictureBox();
            this.mCalibration = new PTool.Calibration();
            this.tlpParameter.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectState)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpParameter
            // 
            this.tlpParameter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlpParameter.ColumnCount = 3;
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpParameter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpParameter.Controls.Add(this.label2, 0, 0);
            this.tlpParameter.Controls.Add(this.tbDeviceNumber, 1, 0);
            this.tlpParameter.Controls.Add(this.label1, 0, 1);
            this.tlpParameter.Controls.Add(this.BalanceSerialPort, 1, 1);
            this.tlpParameter.Controls.Add(this.picConnectState, 2, 1);
            this.tlpParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpParameter.Location = new System.Drawing.Point(0, 35);
            this.tlpParameter.Margin = new System.Windows.Forms.Padding(0);
            this.tlpParameter.Name = "tlpParameter";
            this.tlpParameter.RowCount = 2;
            this.tlpParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpParameter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpParameter.Size = new System.Drawing.Size(459, 67);
            this.tlpParameter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "设备编号";
            // 
            // tbDeviceNumber
            // 
            this.tbDeviceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDeviceNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbDeviceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbDeviceNumber.ForeColor = System.Drawing.Color.White;
            this.tbDeviceNumber.Location = new System.Drawing.Point(94, 3);
            this.tbDeviceNumber.MaxLength = 10;
            this.tbDeviceNumber.Name = "tbDeviceNumber";
            this.tbDeviceNumber.Size = new System.Drawing.Size(269, 26);
            this.tbDeviceNumber.TabIndex = 1;
            this.tbDeviceNumber.WordWrap = false;
            this.tbDeviceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeviceNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口";
            // 
            // BalanceSerialPort
            // 
            this.BalanceSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceSerialPort.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BalanceSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BalanceSerialPort.ForeColor = System.Drawing.Color.White;
            this.BalanceSerialPort.FormattingEnabled = true;
            this.BalanceSerialPort.Location = new System.Drawing.Point(94, 36);
            this.BalanceSerialPort.Name = "BalanceSerialPort";
            this.BalanceSerialPort.Size = new System.Drawing.Size(269, 28);
            this.BalanceSerialPort.TabIndex = 2;
            this.BalanceSerialPort.SelectedIndexChanged += new System.EventHandler(this.BalanceSerialPort_SelectedIndexChanged);
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 5;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpTitle.Controls.Add(this.picLogo, 0, 0);
            this.tlpTitle.Controls.Add(this.lbTitle, 1, 0);
            this.tlpTitle.Controls.Add(this.picCloseWindow, 4, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(0, 0);
            this.tlpTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(459, 35);
            this.tlpTitle.TabIndex = 0;
            this.tlpTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpTitle_MouseDown);
            this.tlpTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpTitle_MouseMove);
            this.tlpTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpTitle_MouseUp);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(53, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(72, 18);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "校准工具";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpTitle, 0, 0);
            this.tlpMain.Controls.Add(this.tlpParameter, 0, 1);
            this.tlpMain.Controls.Add(this.mCalibration, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tlpMain.Size = new System.Drawing.Size(459, 447);
            this.tlpMain.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::HangBalance.Properties.Resources.PLogo;
            this.picLogo.Location = new System.Drawing.Point(9, 9);
            this.picLogo.Margin = new System.Windows.Forms.Padding(9);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(32, 13);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picCloseWindow
            // 
            this.picCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCloseWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCloseWindow.Image = global::HangBalance.Properties.Resources.close;
            this.picCloseWindow.Location = new System.Drawing.Point(425, 11);
            this.picCloseWindow.Margin = new System.Windows.Forms.Padding(11);
            this.picCloseWindow.Name = "picCloseWindow";
            this.picCloseWindow.Size = new System.Drawing.Size(23, 13);
            this.picCloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCloseWindow.TabIndex = 3;
            this.picCloseWindow.TabStop = false;
            this.picCloseWindow.Click += new System.EventHandler(this.picCloseWindow_Click);
            // 
            // picConnectState
            // 
            this.picConnectState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picConnectState.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picConnectState.ErrorImage = global::HangBalance.Properties.Resources.error;
            this.picConnectState.Image = global::HangBalance.Properties.Resources.error2;
            this.picConnectState.Location = new System.Drawing.Point(375, 42);
            this.picConnectState.Margin = new System.Windows.Forms.Padding(9);
            this.picConnectState.Name = "picConnectState";
            this.picConnectState.Size = new System.Drawing.Size(30, 16);
            this.picConnectState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnectState.TabIndex = 0;
            this.picConnectState.TabStop = false;
            // 
            // mCalibration
            // 
            this.mCalibration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(113)))), ((int)(((byte)(185)))));
            this.mCalibration.Location = new System.Drawing.Point(3, 105);
            this.mCalibration.Name = "mCalibration";
            this.mCalibration.Size = new System.Drawing.Size(453, 339);
            this.mCalibration.TabIndex = 2;
            // 
            // PressureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 447);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PressureForm";
            this.Text = "压力测试工具";
            this.Load += new System.EventHandler(this.PressureForm_Load);
            this.tlpParameter.ResumeLayout(false);
            this.tlpParameter.PerformLayout();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpParameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDeviceNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BalanceSerialPort;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picCloseWindow;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox picConnectState;
        private Calibration mCalibration;
    }
}