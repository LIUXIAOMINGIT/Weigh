using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using ClosedXML.Excel;
using CCWin;
using ApplicationClient;
using Misc = ComunicationProtocol.Misc;
using SerialDevice;

namespace PTool
{
    public partial class PressureForm : Form
    {
        private bool moving = false;
        private Point oldMousePosition;

        private HangingBalance m_DetectBalance = new HangingBalance();
        public PressureForm()
        {
            InitializeComponent();
        }

        private void PressureForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
            BalanceSerialPort.Items.AddRange(SerialPort.GetPortNames());
            m_DetectBalance.DeviceDataRecerived += OnDetectBalanceDataReceived;
        }

        private void LoadConfig()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string strDeviceNo = ConfigurationManager.AppSettings.Get("DeviceNo");
                tbDeviceNumber.Text = strDeviceNo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件参数配置错误，请先检查该文件后再重新启动程序!" + ex.Message);
            }
        }

        private void OnDetectBalanceDataReceived(object sender, EventArgs e)
        {
            HangingBalanceEventArgs args = e as HangingBalanceEventArgs;
           // args.PortName
            
        }

        private void SaveLastToolingNo()
        {
            //Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //cfa.AppSettings.Settings["Tool1"].Value = tbToolingNo.Text;
            //cfa.AppSettings.Settings["Tool2"].Value = tbToolingNo2.Text;
            //cfa.Save();
        }

        private void BalanceSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (m_DetectBalance == null)
                m_DetectBalance = new HangingBalance();

            string name = m_DetectBalance.FreshCom(BalanceSerialPort.Items[BalanceSerialPort.SelectedIndex].ToString());
            if (string.IsNullOrEmpty(name))
            {
                picConnectState.Image = global::HangBalance.Properties.Resources.error2;
                mCalibration.EnableCalibrate(false);
            }
            else
            {
                picConnectState.Image = global::HangBalance.Properties.Resources.ok2;
                mCalibration.SetPortName(name);
                mCalibration.EnableCalibrate(true);
            }
        }

        #region 鼠标移动窗口
        private void tlpTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                return;
            }
            oldMousePosition = e.Location;
            moving = true;
        }

        private void tlpTitle_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void tlpTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && moving)
            {
                Point newPosition = new Point(e.Location.X - oldMousePosition.X, e.Location.Y - oldMousePosition.Y);
                this.Location += new Size(newPosition);
            }
        }
        #endregion

        private void picCloseWindow_Click(object sender, EventArgs e)
        {
            SaveDeviceNumber();
            mCalibration.Close();
            this.Close();
        }

        /// <summary>
        /// 只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDeviceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b')
            {
                e.Handled = false;
                return;
            }
            if (e.KeyChar > '9' || e.KeyChar < '0')
                e.Handled = true;
            else
                e.Handled = false;
        }

        /// <summary>
        /// 保存设备编号
        /// </summary>
        private void SaveDeviceNumber()
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["DeviceNo"].Value = tbDeviceNumber.Text;
            cfa.Save();
        }


    }


}
