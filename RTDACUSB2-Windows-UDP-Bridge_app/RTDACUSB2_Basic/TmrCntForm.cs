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
    public partial class TmrCntForm : Form
    {
        private RTDACUSB2_0103 brd;
        public TmrCntForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;
            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();
            ChanNo.Minimum = 0;
            ChanNo.Maximum = brd.NoOfTmrCnt - 1;
            ChanNo.Value = 0;

            if (brd.TmrCnt(0).Mode == TmrCntClass.ModeState.CounterMode)
                Mode.SetSelected(0,true);
            else
                Mode.SetSelected(1,true);
            if (brd.TmrCnt(0).Reset == TmrCntClass.ResetState.Off)
                Reset.SetSelected(0, true);
            else
                Reset.SetSelected(1, true);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void TmrCntTimer_Tick(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            
            Counter.Text = brd.TmrCnt((int)ChanNo.Value).Counter.ToString();
            if (brd.TmrCnt((int)ChanNo.Value).Mode == TmrCntClass.ModeState.CounterMode)
                { if (!Mode.GetSelected(0)) Mode.SetSelected(0, true); }
            else
                { if (!Mode.GetSelected(1)) Mode.SetSelected(1, true); }
            if (brd.TmrCnt((int)ChanNo.Value).Reset == TmrCntClass.ResetState.Off)
                { if (!Reset.GetSelected(0)) Reset.SetSelected(0, true); }
            else
                { if (!Reset.GetSelected(1)) Reset.SetSelected(1, true); }
        }


        private void Reset_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Reset.GetSelected(0)) brd.TmrCnt((int)ChanNo.Value).Reset = TmrCntClass.ResetState.Off;
            if (Reset.GetSelected(1)) brd.TmrCnt((int)ChanNo.Value).Reset = TmrCntClass.ResetState.On;
            brd.SendUSBFrame();
        }

        private void Mode_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Mode.GetSelected(0)) brd.TmrCnt((int)ChanNo.Value).Mode = TmrCntClass.ModeState.CounterMode;
            if (Mode.GetSelected(1)) brd.TmrCnt((int)ChanNo.Value).Mode = TmrCntClass.ModeState.TimerMode;
            brd.SendUSBFrame();
        }

     }
}
