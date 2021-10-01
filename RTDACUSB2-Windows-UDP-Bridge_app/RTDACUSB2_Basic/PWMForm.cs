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
    public partial class PWMForm : Form
    {
        private RTDACUSB2_0103 brd;

        private bool PrescalerEdited = false;
        private bool WidthEdited = false;

        public PWMForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();
            ChanNo.Value = 0;
            if (brd.PWM(0).Mode == PWMClass.PWMMode.PWM8BitMode)
            {
                Mode.SetSelected(0, true);
                //Mode.SetSelected(1, false);
                PWMScroll.Maximum = 255;
                PWMScroll.Value = (int)(brd.PWM(0).Width & 0x0FF);
                WidthTB.Text = ((int)(brd.PWM(0).Width & 0x0FF)).ToString();
            }
            else
            {
                //Mode.SetSelected(0, false);
                Mode.SetSelected(1, true);
                PWMScroll.Maximum = 4095;
                PWMScroll.Value = (int)(brd.PWM(0).Width & 0xFFF);
                WidthTB.Text = ((int)(brd.PWM(0).Width & 0xFFF)).ToString();
            }
            PrescalerTB.Text = brd.PWM(0).Prescaler.ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void PrescalerTB_Enter(object sender, EventArgs e) { PrescalerEdited = true; }
        private void PrescalerTB_Leave(object sender, EventArgs e) { PrescalerEdited = false; }
        private void WidthTB_Enter(object sender, EventArgs e)     { WidthEdited = true; }
        private void WidthTB_Leave(object sender, EventArgs e)     { WidthEdited = false; }

        private void PWMTimer_Tick(object sender, EventArgs e)
        {
            int Idx = (int)ChanNo.Value;
            brd.ReadUSBFrame();
            if (brd.PWM(Idx).Mode == PWMClass.PWMMode.PWM8BitMode)
            { 
                if (!Mode.GetSelected(0)) Mode.SetSelected(0, true);
                PWMScroll.Maximum = 255;
            }
            else
            { 
                if (!Mode.GetSelected(1)) Mode.SetSelected(1, true);
                PWMScroll.Maximum = 4095;
            }

            if (!PrescalerEdited) PrescalerTB.Text = brd.PWM(Idx).Prescaler.ToString();
            
            if (!WidthEdited) WidthTB.Text = brd.PWM(Idx).Width.ToString();
            PWMScroll.Value = (int)brd.PWM(Idx).Width;

        }

        private void PWMScroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            WidthTB.Text = PWMScroll.Value.ToString();
            brd.PWM((int)ChanNo.Value).Width = (uint)PWMScroll.Value;
            brd.SendUSBFrame();
        }

        private void PrescalerTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                brd.ReadUSBFrame();
                brd.PWM((int)ChanNo.Value).Prescaler = Convert.ToUInt32(PrescalerTB.Text,10);
                brd.SendUSBFrame();
            }
        }

        private void WidthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                brd.ReadUSBFrame();
                brd.PWM((int)ChanNo.Value).Width = Convert.ToUInt32(WidthTB.Text, 10);
                brd.SendUSBFrame();
            }
        }

        private void Mode_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Mode.GetSelected(0)) // 8-bit mode
            {
                PWMScroll.Value = (int)(255.0 * (float)(PWMScroll.Value & 0xFFF) / 4095.0);
                PWMScroll.Maximum = 255;
                brd.PWM((int)ChanNo.Value).Mode = PWMClass.PWMMode.PWM8BitMode;
            }
            if (Mode.GetSelected(1)) // 12-bit mode
            {
                PWMScroll.Maximum = 4095;
                PWMScroll.Value = (int)(4095.0 * (float)(PWMScroll.Value & 0xFF) / 255.0);
                brd.PWM((int)ChanNo.Value).Mode = PWMClass.PWMMode.PWM12BitMode;
            }
            brd.PWM((int)ChanNo.Value).Width = (uint)PWMScroll.Value;
            brd.SendUSBFrame();

            WidthTB.Text = PWMScroll.Value.ToString();
        }



        
    }
}
