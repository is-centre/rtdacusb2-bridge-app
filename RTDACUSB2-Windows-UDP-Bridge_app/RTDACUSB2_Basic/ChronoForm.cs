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
    public partial class ChronoForm : Form
    {
        private RTDACUSB2_0103 brd;

        private bool PrescalerEdited = false;

        public ChronoForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrescalerTB_Enter(object sender, EventArgs e) { PrescalerEdited = true; }
        private void PrescalerTB_Leave(object sender, EventArgs e) { PrescalerEdited = false; }

        private void EnableBlock_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (EnableBlock.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).Enable = ChronoClass.EnableState.Off;
            if (EnableBlock.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).Enable = ChronoClass.EnableState.On;
            brd.SendUSBFrame();
        }

        private void EnableGate_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (EnableGate.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).EnableGate = ChronoClass.EnableGateState.Off;
            if (EnableGate.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).EnableGate = ChronoClass.EnableGateState.On;
            brd.SendUSBFrame();
        }

        private void InvertStartStop_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertStartStop.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).InvertStartStop = ChronoClass.InvertStartStopState.Off;
            if (InvertStartStop.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).InvertStartStop = ChronoClass.InvertStartStopState.On;
            brd.SendUSBFrame();
        }

        private void InvertStop_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertStop.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).InvertStop = ChronoClass.InvertStopState.Off;
            if (InvertStop.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).InvertStop = ChronoClass.InvertStopState.On;
            brd.SendUSBFrame();
        }

        private void InvertGate_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (InvertGate.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).InvertGate = ChronoClass.InvertGateState.Off;
            if (InvertGate.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).InvertGate = ChronoClass.InvertGateState.On;
            brd.SendUSBFrame();
        }

        private void Next_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Next.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).Next = ChronoClass.NextState.Off;
            if (Next.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).Next = ChronoClass.NextState.On;
            brd.SendUSBFrame();
        }

        private void Arm_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (Arm.GetSelected(0)) // Off
                brd.Chrono((int)ChanNo.Value).Arm = ChronoClass.ArmState.Off;
            if (Arm.GetSelected(1)) // On
                brd.Chrono((int)ChanNo.Value).Arm = ChronoClass.ArmState.On;
            brd.SendUSBFrame();
        }

        private void CountingMode_MouseDown(object sender, MouseEventArgs e)
        {
            brd.ReadUSBFrame();
            if (CountingMode.GetSelected(0)) // StartStop is H
                brd.Chrono((int)ChanNo.Value).TriggerMode = ChronoClass.TriggerModeState.StartStop_IsH;
            if (CountingMode.GetSelected(1)) // StartStop riging edges
                brd.Chrono((int)ChanNo.Value).TriggerMode = ChronoClass.TriggerModeState.StartStop_RigingEdges;
            if (CountingMode.GetSelected(2)) // StartStop and Stop rising edges
                brd.Chrono((int)ChanNo.Value).TriggerMode = ChronoClass.TriggerModeState.StartStop_Stop_RisingEdges;
            brd.SendUSBFrame();
        }

        private void PrescalerScroll_Scroll(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            brd.Chrono((int)ChanNo.Value).Divider = (uint)PrescalerScroll.Value;
            brd.SendUSBFrame();
        }

        private void PrescalerTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                brd.ReadUSBFrame();
                brd.Chrono((int)ChanNo.Value).Divider = Convert.ToUInt32(PrescalerTB.Text, 10);
                brd.SendUSBFrame();
            }
        }

        private void ChronoTimer_Tick(object sender, EventArgs e)
        {
            int Idx = (int)ChanNo.Value;
            brd.ReadUSBFrame();
            if (brd.Chrono(Idx).Enable == ChronoClass.EnableState.Off)
            {
                if (!EnableBlock.GetSelected(0)) EnableBlock.SetSelected(0, true);
            }
            else
            {
                if (!EnableBlock.GetSelected(1)) EnableBlock.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).EnableGate == ChronoClass.EnableGateState.Off)
            {
                if (!EnableGate.GetSelected(0)) EnableGate.SetSelected(0, true);
            }
            else
            {
                if (!EnableGate.GetSelected(1)) EnableGate.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).InvertStartStop == ChronoClass.InvertStartStopState.Off)
            {
                if (!InvertStartStop.GetSelected(0)) InvertStartStop.SetSelected(0, true);
            }
            else
            {
                if (!InvertStartStop.GetSelected(1)) InvertStartStop.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).InvertStop == ChronoClass.InvertStopState.Off)
            {
                if (!InvertStop.GetSelected(0)) InvertStop.SetSelected(0, true);
            }
            else
            {
                if (!InvertStop.GetSelected(1)) InvertStop.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).InvertGate == ChronoClass.InvertGateState.Off)
            {
                if (!InvertGate.GetSelected(0)) InvertGate.SetSelected(0, true);
            }
            else
            {
                if (!InvertGate.GetSelected(1)) InvertGate.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).Next == ChronoClass.NextState.Off)
            {
                if (!Next.GetSelected(0)) Next.SetSelected(0, true);
            }
            else
            {
                if (!Next.GetSelected(1)) Next.SetSelected(1, true);
            }
            if (brd.Chrono(Idx).Arm == ChronoClass.ArmState.Off)
            {
                if (!Arm.GetSelected(0)) Arm.SetSelected(0, true);
            }
            else
            {
                if (!Arm.GetSelected(1)) Arm.SetSelected(1, true);
            }
            switch (brd.Chrono(Idx).TriggerMode)
            {
                case ChronoClass.TriggerModeState.StartStop_IsH :
                    if (!CountingMode.GetSelected(0)) CountingMode.SetSelected(0, true);
                    break;
                case ChronoClass.TriggerModeState.StartStop_RigingEdges:
                    if (!CountingMode.GetSelected(1)) CountingMode.SetSelected(1, true);
                    break;
                case ChronoClass.TriggerModeState.StartStop_Stop_RisingEdges:
                    if (!CountingMode.GetSelected(2)) CountingMode.SetSelected(2, true);
                    break;
            }
            switch (brd.Chrono(Idx).BlockStatus)
            {
                case ChronoClass.BlockStatusState.Disabled:
                    BlockStatus.Text = "Disabled"; break;
                case ChronoClass.BlockStatusState.ReadyToArm:
                    BlockStatus.Text = "ReadyToArm"; break;
                case ChronoClass.BlockStatusState.Armed:
                    BlockStatus.Text = "Armed"; break;
                case ChronoClass.BlockStatusState.Counting:
                    BlockStatus.Text = "Counting"; break;
                case ChronoClass.BlockStatusState.CntTerminated:
                    BlockStatus.Text = "CntTerminated"; break;
                default:
                    BlockStatus.Text = "Unknown"; break;
            }
            if( ! PrescalerEdited ) PrescalerTB.Text = brd.Chrono(Idx).Divider.ToString();
            PrescalerScroll.Value = (int)brd.Chrono(Idx).Divider;
            Counter.Text = brd.Chrono(Idx).Counter.ToString();
            Result.Text = brd.Chrono(Idx).Result.ToString();
        }




    }
}
