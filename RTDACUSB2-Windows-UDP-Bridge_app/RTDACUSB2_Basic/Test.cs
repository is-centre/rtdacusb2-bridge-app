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
    public partial class Test : Form
    {
        private RTDACUSB2_0103 brd;
        UInt32 Dir = 0;
        UInt32 Mode = 0;
        public Test()
        {
            InitializeComponent();
            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber( -1);
            brd.ReadUSBFrame();
            Dsrp.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void TestDir_Click(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            brd.DigitalIO.CN1Direction = Dir;
            brd.SendUSBFrame();
            brd.ReadUSBFrame();
            Dsrp.Text = Dir.ToString() + "  /  " + brd.DigitalIO.CN1Direction.ToString();
            Dir++;
        }

        private void ModeTest_Click(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            brd.DigitalIO.CN1PinMode = Mode;
            brd.SendUSBFrame();
            brd.ReadUSBFrame();
            Dsrp.Text = Mode.ToString() + "  /  " + brd.DigitalIO.CN1PinMode.ToString();
            Mode++;
        }

        private void Example1_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.NumOfDevices() < 1)
            {
                MessageBox.Show("Can not find any RT-DAC/USB2 device.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String sAux;
            sAux = "Number of detected RT-DAC/USB2 devices: " +
                   String.Format("{0:D}", brd.NumOfDevices() ) + "\n" +
                   "Logic version: " + 
                   String.Format("{0:X}", brd.LogicVersion ) + @" / " + 
                   brd.ApplicationName;
            MessageBox.Show(sAux, "DI/O example",
                         MessageBoxButtons.OK);
        }

        private void Example2_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.OpenBySerialNumber(1) < 0)
            {
                MessageBox.Show("Can not open the device.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.DigitalIO.CN1PinMode = 0;
            brd.DigitalIO.CN1Direction = 0x3FF0000;
            brd.DigitalIO.CN1Output = 0xFFFF;
            if (brd.SendUSBFrame() < 0)
            {
                MessageBox.Show("Can not send data frame.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Wait
            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "DI/O example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            UInt32 Input = brd.DigitalIO.CN1Input;
            Input = (Input >> 16) & 0x3FF;
        }

        private void PWM_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "PWM example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "PWM example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Switch pin mode to allow PWM outputs for PWM0 and PWM1
            brd.DigitalIO.CN1PinMode |= 0x0000024;
            // Set respective pins to be outputs
            brd.DigitalIO.CN1Direction &= 0x0FFFFFDB;

            brd.PWM(0).Mode = PWMClass.PWMMode.PWM8BitMode;
            brd.PWM(1).Mode = PWMClass.PWMMode.PWM12BitMode;

            // The prescaler value of 522 defines the 300Hz frequency
            // The width equal to 64 means 25% duty cycle (64 is 25% of 256)
            brd.PWM(0).Prescaler = 522;
            brd.PWM(0).Width = 64;

            // The prescaler value of 60 defines the 10Hz frequency
            // The width equal to 3072 means 75% duty cycle (3072 is 75% of 4096)
            brd.PWM(1).Prescaler = 60;
            brd.PWM(1).Width = 3072;

            // Start PWM output generation
            if (brd.SendUSBFrame() < 0)
            {
                MessageBox.Show("Can not send data frame.", "PWM example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void TmrCnt_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Tmr/Cnt example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "Tmr/Cnt example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            brd.TmrCnt(0).Mode = TmrCntClass.ModeState.TimerMode; 
            brd.TmrCnt(1).Mode = TmrCntClass.ModeState.CounterMode;

            // Reset both channels
            brd.TmrCnt(0).Reset = brd.TmrCnt(1).Reset = TmrCntClass.ResetState.On;
            if (brd.SendUSBFrame() < 0)
            {
                MessageBox.Show("Can not send data frame.", "Tmr/Cnt example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Start counting
            brd.TmrCnt(0).Reset = brd.TmrCnt(1).Reset = TmrCntClass.ResetState.Off;
            if (brd.SendUSBFrame() < 0)
            {
                MessageBox.Show("Can not send data frame.", "Tmr/Cnt example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // wait ….

            if (brd.ReadUSBFrame() < 0)
            {
                MessageBox.Show("Can not read data frame.", "Tmr/Cnt example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String sAux;
            sAux = "Timer: " +
                   String.Format("{0:D}", brd.TmrCnt(0).Counter) + "\n" +
                   "Counter: " +
                   String.Format("{0:X}", brd.TmrCnt(1).Counter);
            MessageBox.Show(sAux, "Tmr/Cnt example",
                         MessageBoxButtons.OK);

        }

        private void Encoder_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Encoder example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.ReadUSBFrame();

            // Activate index and reset the encoder counter
            brd.EncoderI(2).IdxActive = EncoderIClass.IdxActiveState.On;
            brd.EncoderI(2).IdxInvert = EncoderIClass.IdxInvertState.Off;
            brd.EncoderI(2).Reset = EncoderIClass.ResetState.On;
            brd.SendUSBFrame();

            // Start counting – disable reset signal
            brd.EncoderI(2).Reset = EncoderIClass.ResetState.Off;
            brd.SendUSBFrame();

            // wait ….

            brd.ReadUSBFrame();
            String sAux;
            sAux = "Enc2 counter: " +
                   String.Format("{0:D}", brd.EncoderI(2).Counter);
            MessageBox.Show(sAux, "Encoder example",
                         MessageBoxButtons.OK);
        }

        private void FreqM_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Encoder example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.ReadUSBFrame();

            // Set PWM0 parameters
            brd.PWM(0).Mode = PWMClass.PWMMode.PWM8BitMode;
            brd.PWM(0).Prescaler = 3;
            brd.PWM(0).Width = 64;

            // Set pin mode and direction to allow PWM0 output
            brd.DigitalIO.CN1PinMode |= 0x00000004;
            brd.DigitalIO.CN1Direction &= 0x0FFFFFFB;

            // Setups of the Fr0
            brd.FreqM(0).Enable = FreqMClass.EnableState.On;
            brd.FreqM(0).Mode = FreqMClass.ModeState.Single;
            brd.FreqM(0).InfiniteFlag = FreqMClass.InfiniteFlagState.Off;
            brd.FreqM(0).StartInv = FreqMClass.StartInvState.Off;
            brd.FreqM(0).GateInv = FreqMClass.GateInvState.Off;
            brd.FreqM(0).SwGate = FreqMClass.SwGateState.Off;
            brd.FreqM(0).SwHwGateStart = FreqMClass.SwHwGateStartState.Software; 
            brd.FreqM(0).GateMode = FreqMClass.GateModeState.Input;
            brd.FreqM(0).InputInv = FreqMClass.InputInvState.Off;
            brd.FreqM(0).Timer = 400000;

            // Send setups and generate rising edge of the software START
            brd.FreqM(0).SwStart = FreqMClass.SwStartState.Off;
            brd.SendUSBFrame();
            brd.FreqM(0).SwStart = FreqMClass.SwStartState.On;
            brd.SendUSBFrame();

            // Wait for the rumination of the measurement
            for (; ; )
            {
                brd.ReadUSBFrame();
                if (brd.FreqM(0).Ready == FreqMClass.ReadyState.On) break;
            }
            String sAux;
            sAux = "Result 1: " +
                   String.Format("{0:D}", brd.FreqM(0).Result);
            MessageBox.Show(sAux, "Frequency meter example",
                         MessageBoxButtons.OK);

            // Change PWM frequency and restart the measurement
            brd.PWM(0).Prescaler = 7;

            brd.FreqM(0).SwStart = FreqMClass.SwStartState.Off;
            brd.SendUSBFrame();
            brd.FreqM(0).SwStart = FreqMClass.SwStartState.On;
            brd.SendUSBFrame();

            for (; ; )
            {
                brd.ReadUSBFrame();
                if (brd.FreqM(0).Ready == FreqMClass.ReadyState.On) break;
            }
            sAux = "Result 2: " +
                   String.Format("{0:D}", brd.FreqM(0).Result);
            MessageBox.Show(sAux, "Frequency meter example",
                         MessageBoxButtons.OK);
        }

        private void Chrono_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Encoder example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.ReadUSBFrame();

            // Set pin mode as general-purpose for all signals
            brd.DigitalIO.CN1PinMode = 0;
            // Set direction of the Ch0StSt to be output
            brd.DigitalIO.CN1Direction &= 0x0FFFFFFB;

            // Setups of the Ch0
            brd.Chrono(0).Enable = ChronoClass.EnableState.On;
            brd.Chrono(0).InvertStartStop = ChronoClass.InvertStartStopState.Off;
            brd.Chrono(0).InvertStop = ChronoClass.InvertStopState.Off;
            brd.Chrono(0).InvertGate = ChronoClass.InvertGateState.Off;
            brd.Chrono(0).EnableGate = ChronoClass.EnableGateState.Off;
            brd.Chrono(0).TriggerMode = ChronoClass.TriggerModeState.StartStop_IsH;
            brd.Chrono(0).Arm = ChronoClass.ArmState.On;
            brd.Chrono(0).Next = ChronoClass.NextState.On;
            brd.Chrono(0).Divider = 0;  // Maximum resolution

            // Generate the pulse
            brd.DigitalIO.CN1Output &= 0x0FFFFFFB;  // Set DIO2 to L
            brd.SendUSBFrame();
            brd.DigitalIO.CN1Output |= 0x00000004; // Set DIO2 to H
            brd.SendUSBFrame();
            brd.DigitalIO.CN1Output &= 0x0FFFFFFB; // Set DIO2 to L
            brd.SendUSBFrame();

            brd.ReadUSBFrame();
            String sAux;
            sAux = "Result: " +
                   String.Format("{0:D}", brd.Chrono(0).Result);
            MessageBox.Show(sAux, "Chronometer example",
                         MessageBoxButtons.OK);
        }

        private void AD_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Encoder example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.ReadUSBFrame();

            // Set the gain of the third A/D channel to 1
            brd.AD(2).ADGain = ADClass.GainState.x1;
            brd.SendUSBFrame();

            brd.ReadUSBFrame();
            String sAux;
            sAux = "Input of the third A/D 2 channel: " +
                   String.Format("{0:D}", brd.AD(2).ADValue + "\n" +
                   "Input of the A/D 2 channel in [V]: " +
                   brd.AD(2).ADVoltage.ToString() );
            MessageBox.Show(sAux, "A/D example",
                         MessageBoxButtons.OK);

        }

        private void DA_Click(object sender, EventArgs e)
        {
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            if (brd.Open() < 0)
            {
                MessageBox.Show("Can not open the device.", "Encoder example",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            brd.ReadUSBFrame();

            // Set the levels of the D/A2 and D/A3
            brd.DA(2).DAValue = (uint)(0.75 * 16384);
            brd.DA(3).DAValue = (uint)(0.25 * 16384);
            brd.SendUSBFrame();
        }

    }
}
