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
    public partial class FreqMForm : Form
    {
        private RTDACUSB2_0103 brd;

        private bool TimerEdited = false;

        public FreqMForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame(); 
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void EnableBlock_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (EnableBlock.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).Enable = FreqMClass.EnableState.Off;
            if (EnableBlock.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).Enable = FreqMClass.EnableState.On;
            brd.SendUSBFrame();
        }

        private void Mode_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Mode.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).Mode = FreqMClass.ModeState.Single;
            if (Mode.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).Mode = FreqMClass.ModeState.Continous;
            brd.SendUSBFrame();
        }

        private void InfiniteFlag_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InfiniteFlag.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).InfiniteFlag = FreqMClass.InfiniteFlagState.Off;
            if (InfiniteFlag.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).InfiniteFlag = FreqMClass.InfiniteFlagState.On;
            brd.SendUSBFrame();
        }

        private void SwStart_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (SwStart.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).SwStart = FreqMClass.SwStartState.Off;
            if (SwStart.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).SwStart = FreqMClass.SwStartState.On;
            brd.SendUSBFrame();
        }

        private void InvertStart_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertStart.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).StartInv = FreqMClass.StartInvState.Off;
            if (InvertStart.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).StartInv = FreqMClass.StartInvState.On;
            brd.SendUSBFrame();
        }

        private void SwGate_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (SwGate.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).SwGate = FreqMClass.SwGateState.Off;
            if (SwGate.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).SwGate = FreqMClass.SwGateState.On;
            brd.SendUSBFrame();
        }

        private void SwHwGateStart_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (SwHwGateStart.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).SwHwGateStart = FreqMClass.SwHwGateStartState.Software;
            if (SwHwGateStart.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).SwHwGateStart = FreqMClass.SwHwGateStartState.Hardware;
            brd.SendUSBFrame();
        }

        private void InvertGate_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertGate.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).GateInv = FreqMClass.GateInvState.Off;
            if (InvertGate.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).GateInv = FreqMClass.GateInvState.On;
            brd.SendUSBFrame();
        }

        private void GateMode_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (GateMode.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).GateMode = FreqMClass.GateModeState.Input;
            if (GateMode.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).GateMode = FreqMClass.GateModeState.TimeAndInput;
            brd.SendUSBFrame();
        }

        private void InvertInput_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertInput.GetSelected(0)) // Off
                brd.FreqM((int)ChanNo.Value).InputInv = FreqMClass.InputInvState.Off;
            if (InvertInput.GetSelected(1)) // On
                brd.FreqM((int)ChanNo.Value).InputInv = FreqMClass.InputInvState.On;
            brd.SendUSBFrame();
        }

        private void TimerScroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            brd.FreqM((int)ChanNo.Value).Timer = (uint)TimerScroll.Value;
            brd.SendUSBFrame();
        }

        private void TimerTB_Enter(object sender, EventArgs e) { TimerEdited = true; }
        private void TimerTB_Leave(object sender, EventArgs e) { TimerEdited = false; }

        private void TimerTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                brd.ReadUSBFrame();
                brd.FreqM((int)ChanNo.Value).Timer = Convert.ToUInt32(TimerTB.Text, 10);
                brd.SendUSBFrame();
            }
        }

        private void FreqMTimer_Tick(object sender, EventArgs e)
        {
            int Idx = (int)ChanNo.Value;
            brd.ReadUSBFrame();
            if (brd.FreqM(Idx).Enable == FreqMClass.EnableState.Off)
            {
                if (!EnableBlock.GetSelected(0)) EnableBlock.SetSelected(0, true);
            }
            else
            {
                if (!EnableBlock.GetSelected(1)) EnableBlock.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).Mode == FreqMClass.ModeState.Single)
            {
                if (!Mode.GetSelected(0)) Mode.SetSelected(0, true);
            }
            else
            {
                if (!Mode.GetSelected(1)) Mode.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).InfiniteFlag == FreqMClass.InfiniteFlagState.Off)
            {
                if (!InfiniteFlag.GetSelected(0)) InfiniteFlag.SetSelected(0, true);
            }
            else
            {
                if (!InfiniteFlag.GetSelected(1)) InfiniteFlag.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).SwStart == FreqMClass.SwStartState.Off)
            {
                if (!SwStart.GetSelected(0)) SwStart.SetSelected(0, true);
            }
            else
            {
                if (!SwStart.GetSelected(1)) SwStart.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).StartInv == FreqMClass.StartInvState.Off)
            {
                if (!InvertStart.GetSelected(0)) InvertStart.SetSelected(0, true);
            }
            else
            {
                if (!InvertStart.GetSelected(1)) InvertStart.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).SwGate == FreqMClass.SwGateState.Off)
            {
                if (!SwGate.GetSelected(0)) SwGate.SetSelected(0, true);
            }
            else
            {
                if (!SwGate.GetSelected(1)) SwGate.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).SwHwGateStart == FreqMClass.SwHwGateStartState.Software)
            {
                if (!SwHwGateStart.GetSelected(0)) SwHwGateStart.SetSelected(0, true);
            }
            else
            {
                if (!SwHwGateStart.GetSelected(1)) SwHwGateStart.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).GateInv == FreqMClass.GateInvState.Off)
            {
                if (!InvertGate.GetSelected(0)) InvertGate.SetSelected(0, true);
            }
            else
            {
                if (!InvertGate.GetSelected(1)) InvertGate.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).GateMode == FreqMClass.GateModeState.Input)
            {
                if (!GateMode.GetSelected(0)) GateMode.SetSelected(0, true);
            }
            else
            {
                if (!GateMode.GetSelected(1)) GateMode.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).InputInv == FreqMClass.InputInvState.Off)
            {
                if (!InvertInput.GetSelected(0)) InvertInput.SetSelected(0, true);
            }
            else
            {
                if (!InvertInput.GetSelected(1)) InvertInput.SetSelected(1, true);
            }
            if (brd.FreqM(Idx).Ready == FreqMClass.ReadyState.Off)
            {
                ReadyTB.Text = "Off";
            }
            else
            {
                ReadyTB.Text = "Ready to read";
            }
            if (!TimerEdited) TimerTB.Text = brd.FreqM(Idx).Timer.ToString();
            TimerScroll.Value = (int)Math.Min( brd.FreqM(Idx).Timer, TimerScroll.Maximum);
            Result.Text = brd.FreqM(Idx).Result.ToString();
        }

    }
}
