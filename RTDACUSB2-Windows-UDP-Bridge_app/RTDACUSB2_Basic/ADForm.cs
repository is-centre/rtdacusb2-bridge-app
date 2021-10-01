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
    public partial class ADForm : Form
    {
        private RTDACUSB2_0103 brd;

        private TextBox[] TBoxArrValue;
        private TextBox[] TBoxArrVoltage;
        private ListBox[] LBoxArrGain;

        public ADForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void ADForm_Load(object sender, EventArgs e)
        {
            TBoxArrValue = new TextBox[16];
            TBoxArrVoltage = new TextBox[16];
            LBoxArrGain = new ListBox[16];

            TBoxArrValue[0] = Value0; TBoxArrValue[1] = Value1;
            TBoxArrValue[2] = Value2; TBoxArrValue[3] = Value3;
            TBoxArrValue[4] = Value4; TBoxArrValue[5] = Value5;
            TBoxArrValue[6] = Value6; TBoxArrValue[7] = Value7;
            TBoxArrValue[8] = Value8; TBoxArrValue[9] = Value9;
            TBoxArrValue[10] = Value10; TBoxArrValue[11] = Value11;
            TBoxArrValue[12] = Value12; TBoxArrValue[13] = Value13;
            TBoxArrValue[14] = Value14; TBoxArrValue[15] = Value15;
            TBoxArrVoltage[0] = Voltage0; TBoxArrVoltage[1] = Voltage1;
            TBoxArrVoltage[2] = Voltage2; TBoxArrVoltage[3] = Voltage3;
            TBoxArrVoltage[4] = Voltage4; TBoxArrVoltage[5] = Voltage5;
            TBoxArrVoltage[6] = Voltage6; TBoxArrVoltage[7] = Voltage7;
            TBoxArrVoltage[8] = Voltage8; TBoxArrVoltage[9] = Voltage9;
            TBoxArrVoltage[10] = Voltage10; TBoxArrVoltage[11] = Voltage11;
            TBoxArrVoltage[12] = Voltage12; TBoxArrVoltage[13] = Voltage13;
            TBoxArrVoltage[14] = Voltage14; TBoxArrVoltage[15] = Voltage15;
            LBoxArrGain[0] = Gain0; LBoxArrGain[1] = Gain1;
            LBoxArrGain[2] = Gain2; LBoxArrGain[3] = Gain3;
            LBoxArrGain[4] = Gain4; LBoxArrGain[5] = Gain5;
            LBoxArrGain[6] = Gain6; LBoxArrGain[7] = Gain7;
            LBoxArrGain[8] = Gain8; LBoxArrGain[9] = Gain9;
            LBoxArrGain[10] = Gain10; LBoxArrGain[11] = Gain11;
            LBoxArrGain[12] = Gain12; LBoxArrGain[13] = Gain13;
            LBoxArrGain[14] = Gain14; LBoxArrGain[15] = Gain15;

            brd.ReadUSBFrame();
            for (int i = 0; i < ADClass.NoOf; i++)
            {
                switch (brd.AD(i).ADGain)
                {
                    case ADClass.GainState.x1: LBoxArrGain[i].SelectedIndex = 0; break;
                    case ADClass.GainState.x2: LBoxArrGain[i].SelectedIndex = 1; break;
                    case ADClass.GainState.x4: LBoxArrGain[i].SelectedIndex = 2; break;
                    case ADClass.GainState.x8: LBoxArrGain[i].SelectedIndex = 3; break;
                    case ADClass.GainState.x16: LBoxArrGain[i].SelectedIndex = 4; break;
                    default: LBoxArrGain[i].SelectedIndex=0; break;
                }
            }
//            if (brd.ADStart > 0)
//                CBADStart.Checked = true;
//            else
//                CBADStart.Checked = false;
        }

        private void ADTimer_Tick(object sender, EventArgs e)
        {
            int i;
//            brd.ReadUSBFrame();
//            for (i = 0; i < ADClass.NoOf; i++)
//            {
//                brd.AD(i).ADGain = ADClass.ToGain((uint)LBoxArrGain[i].SelectedIndex);
//            }
//            brd.SendUSBFrame();
            brd.ReadUSBFrame();
            for (i = 0; i < ADClass.NoOf; i++)
            {
                switch (brd.AD(i).ADGain)
                {
                    case ADClass.GainState.x1: LBoxArrGain[i].SelectedIndex = 0; break;
                    case ADClass.GainState.x2: LBoxArrGain[i].SelectedIndex = 1; break;
                    case ADClass.GainState.x4: LBoxArrGain[i].SelectedIndex = 2; break;
                    case ADClass.GainState.x8: LBoxArrGain[i].SelectedIndex = 3; break;
                    case ADClass.GainState.x16: LBoxArrGain[i].SelectedIndex = 4; break;
                    default: LBoxArrGain[i].SelectedIndex = 0; break;
                }
                TBoxArrValue[i].Text = brd.AD(i).ADValue.ToString();
                TBoxArrVoltage[i].Text = brd.AD(i).ADVoltage.ToString();
            }
//            if (brd.ADStart > 0)
//                CBADStart.Checked = true;
//            else
//                CBADStart.Checked = false;
//            if (brd.ADReady > 0)
//                CBADReady.Checked = true;
//            else
//                CBADReady.Checked = false;
        }

        private void ChangeGainSelection(int Idx)
        {
            brd.ReadUSBFrame();
            brd.AD(Idx).ADGain = ADClass.ToGain((uint)LBoxArrGain[Idx].SelectedIndex);
            brd.SendUSBFrame();
        }


        private void Gain0_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(0);
        }

        private void Gain1_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(1);
        }

        private void Gain2_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(2);
        }

        private void Gain3_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(3);
        }

        private void Gain4_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(4);
        }

        private void Gain5_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(5);
        }

        private void Gain6_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(6);
        }

        private void Gain7_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(7);
        }

        private void Gain8_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(8);
        }

        private void Gain9_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(9);
        }

        private void Gain10_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(10);
        }

        private void Gain11_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(11);
        }

        private void Gain12_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(12);
        }

        private void Gain13_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(13);
        }

        private void Gain14_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(14);
        }

        private void Gain15_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeGainSelection(15);
        }

        private void CBADStart_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void CBADStart_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
