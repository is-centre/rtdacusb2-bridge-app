using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RTDACUSB2_0103NS;
using RTDACUSB2NS;
using RTDACBoardNS;

namespace RTDACUSB2_Basic
{
    public partial class DAForm : Form
    {
        private RTDACUSB2_0103 brd;

        public DAForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();
            DA0Value.Text = ((int)(brd.DA(0).DAValue & 0x3FFF)).ToString();
            DA1Value.Text = ((int)(brd.DA(1).DAValue & 0x3FFF)).ToString();
            DA2Value.Text = ((int)(brd.DA(2).DAValue & 0x3FFF)).ToString();
            DA3Value.Text = ((int)(brd.DA(3).DAValue & 0x3FFF)).ToString();
            DA0Scroll.Value = ((int)(brd.DA(0).DAValue & 0x3FFF));
            DA1Scroll.Value = ((int)(brd.DA(1).DAValue & 0x3FFF));
            DA2Scroll.Value = ((int)(brd.DA(2).DAValue & 0x3FFF));
            DA3Scroll.Value = ((int)(brd.DA(3).DAValue & 0x3FFF));
            DA0Voltage.Text = brd.DA(0).DAVoltage.ToString();
            DA1Voltage.Text = brd.DA(1).DAVoltage.ToString();
            DA2Voltage.Text = brd.DA(2).DAVoltage.ToString();
            DA3Voltage.Text = brd.DA(3).DAVoltage.ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void DATimer_Tick(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            DA0Value.Text = ((int)(brd.DA(0).DAValue & 0x3FFF)).ToString();
            DA1Value.Text = ((int)(brd.DA(1).DAValue & 0x3FFF)).ToString();
            DA2Value.Text = ((int)(brd.DA(2).DAValue & 0x3FFF)).ToString();
            DA3Value.Text = ((int)(brd.DA(3).DAValue & 0x3FFF)).ToString();
            DA0Scroll.Value = ((int)(brd.DA(0).DAValue & 0x3FFF));
            DA1Scroll.Value = ((int)(brd.DA(1).DAValue & 0x3FFF));
            DA2Scroll.Value = ((int)(brd.DA(2).DAValue & 0x3FFF));
            DA3Scroll.Value = ((int)(brd.DA(3).DAValue & 0x3FFF));
            DA0Voltage.Text = brd.DA(0).DAVoltage.ToString();
            DA1Voltage.Text = brd.DA(1).DAVoltage.ToString();
            DA2Voltage.Text = brd.DA(2).DAVoltage.ToString();
            DA3Voltage.Text = brd.DA(3).DAVoltage.ToString();
        }

        private void DA0Scroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            DA0Value.Text = DA0Scroll.Value.ToString();
            brd.DA(0).DAValue = (uint)DA0Scroll.Value;
            DA0Voltage.Text = brd.DA(0).DAVoltage.ToString();
            brd.SendUSBFrame();
        }

        private void DA1Scroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            DA1Value.Text = DA1Scroll.Value.ToString();
            brd.DA(1).DAValue = (uint)DA1Scroll.Value;
            DA1Voltage.Text = brd.DA(1).DAVoltage.ToString();
            brd.SendUSBFrame();
        }

        private void DA2Scroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            DA2Value.Text = DA2Scroll.Value.ToString();
            brd.DA(2).DAValue = (uint)DA2Scroll.Value;
            DA2Voltage.Text = brd.DA(2).DAVoltage.ToString();
            brd.SendUSBFrame();
        }

        private void DA3Scroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            DA3Value.Text = DA3Scroll.Value.ToString();
            brd.DA(3).DAValue = (uint)DA3Scroll.Value;
            DA3Voltage.Text = brd.DA(3).DAVoltage.ToString();
            brd.SendUSBFrame();
        }

        
    }
}
