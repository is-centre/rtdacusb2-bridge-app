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
    public partial class EncoderIForm : Form
    {
        private RTDACUSB2_0103 brd;
        public EncoderIForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();
            ChanNo.Minimum = 0;
            ChanNo.Maximum = brd.NoOfEncoderI - 1;
            ChanNo.Value = 0;

            if (brd.EncoderI(0).Reset == EncoderIClass.ResetState.Off)
                Reset.SetSelected(0, true);
            else
                Reset.SetSelected(1, true);
            if (brd.EncoderI(0).IdxActive == EncoderIClass.IdxActiveState.Off)
                IndexActive.SetSelected(0, true);
            else
                IndexActive.SetSelected(1, true);
            if (brd.EncoderI(0).IdxInvert == EncoderIClass.IdxInvertState.Off)
                IndexInvert.SetSelected(0, true);
            else
                IndexInvert.SetSelected(1, true);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void EncoderITimer_Tick(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            Counter.Text = brd.EncoderI((int)ChanNo.Value).Counter.ToString();
            if (brd.EncoderI((int)ChanNo.Value).Reset == EncoderIClass.ResetState.Off)
                { if (!Reset.GetSelected(0)) Reset.SetSelected(0, true); }
            else
                { if (!Reset.GetSelected(1)) Reset.SetSelected(1, true); }
            if (brd.EncoderI((int)ChanNo.Value).IdxActive == EncoderIClass.IdxActiveState.Off)
                { if (!IndexActive.GetSelected(0)) IndexActive.SetSelected(0, true); }
            else
                { if (!IndexActive.GetSelected(1)) IndexActive.SetSelected(1, true); }
            if (brd.EncoderI((int)ChanNo.Value).IdxInvert == EncoderIClass.IdxInvertState.Off)
                { if (!IndexInvert.GetSelected(0)) IndexInvert.SetSelected(0, true); }
            else
                { if (!IndexInvert.GetSelected(1)) IndexInvert.SetSelected(1, true); }
        }

        private void Reset_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Reset.GetSelected(0)) brd.EncoderI((int)ChanNo.Value).Reset = EncoderIClass.ResetState.Off;
            if (Reset.GetSelected(1)) brd.EncoderI((int)ChanNo.Value).Reset = EncoderIClass.ResetState.On;
            brd.SendUSBFrame();
        }

        private void IndexActive_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (IndexActive.GetSelected(0)) brd.EncoderI((int)ChanNo.Value).IdxActive = EncoderIClass.IdxActiveState.Off;
            if (IndexActive.GetSelected(1)) brd.EncoderI((int)ChanNo.Value).IdxActive = EncoderIClass.IdxActiveState.On;
            brd.SendUSBFrame();
        }

        private void IndexInvert_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (IndexInvert.GetSelected(0)) brd.EncoderI((int)ChanNo.Value).IdxInvert = EncoderIClass.IdxInvertState.Off;
            if (IndexInvert.GetSelected(1)) brd.EncoderI((int)ChanNo.Value).IdxInvert = EncoderIClass.IdxInvertState.On;
            brd.SendUSBFrame();
        }

    }
}
