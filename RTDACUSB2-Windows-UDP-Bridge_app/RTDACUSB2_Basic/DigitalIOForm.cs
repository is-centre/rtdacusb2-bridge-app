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
    public partial class DigitalIOForm : Form
    {
        private Button[] ModeButtonArr;
        private Button[] DirButtonArr;
        private Button[] OutputButtonArr;
        private TextBox[] InputTextBoxArr;

        string[] GPIODsrp = { "GPIO0/ENC0A/Fr0G/Ch0G", "GPIO1/ENC0B/Fr0St/Ch0St", "GPIO2/ENC0I/Fr0I/Ch0StSt", 
                              "GPIO3/ENC1A/Fr1G/Ch1G", "GPIO4/ENC1B/Fr1St/Ch1St", "GPIO5/ENC1I/Fr1I/Ch1StSt", 
                              "GPIO6/ENC2A/Fr2G/Ch2G", "GPIO7/ENC2B/Fr2St/Ch2St", "GPIO8/ENC2I/Fr2I/Ch2StSt", 
                              "GPIO9/ENC3A/Fr3G/Ch3G", "GPIO10/ENC3B/Fr3St/Ch3St", "GPIO11/ENC3I/Fr3I/Ch3StSt", 
                              "GPIO12/ENC4A/Fr4G/Ch4G", "GPIO13/ENC4B/Fr4St/Ch4St", "GPIO14/ENC4I/Fr4I/Ch4StSt",
                              "GPIO15/ENC5A/Fr5G/Ch5G", "GPIO16/ENC5B/Fr5St/Ch5St", "GPIO17/ENC5I/Fr5I/Ch5StSt", 
                              "GPIO18/ENC6A/Fr6G/Ch6G", "GPIO19/ENC6B/Fr6St/Ch6St", "GPIO20/ENC6I/Fr6I/Ch6StSt", 
                              "GPIO21/ENC7A/Fr7G/Ch7G", "GPIO22/ENC7B/Fr7St/Ch7St", "GPIO23/ENC7I/Fr7I/Ch7StSt", 
                              "GPIO24/CNT0",  "GPIO25/CNT1" };
        string[] FunctionDsrp = { "GPIO0/ENC0A/Fr0G/Ch0G", "GPIO1/ENC0B/Fr0St/Ch0St", "PWM0/ENC0I/Fr0I/Ch0StSt", 
                                  "GPIO3/ENC1A/Fr1G/Ch1G", "GPIO4/ENC1B/Fr1St/Ch1St", "PWM1/ENC1I/Fr1I/Ch1StSt", 
                                  "GPIO6/ENC2A/Fr2G/Ch2G", "GPIO7/ENC2B/Fr2St/Ch2St", "PWM2/ENC2I/Fr2I/Ch2StSt", 
                                  "GPIO9/ENC3A/Fr3G/Ch3G", "GPIO10/ENC3B/Fr3St/Ch3St", "PWM3/ENC3I/Fr3I/Ch3StSt", 
                                  "GPIO12/ENC4A/Fr4G/Ch4G", "GPIO13/ENC4B/Fr4St/Ch4St", "PWM4/ENC4I/Fr4I/Ch4StSt",
                                  "GPIO15/ENC5A/Fr5G/Ch5G", "GPIO16/ENC5B/Fr5St/Ch5St", "PWM5/ENC5I/Fr5I/Ch5StSt", 
                                  "GPIO18/ENC6A/Fr6G/Ch6G", "GPIO19/ENC6B/Fr6St/Ch6St", "PWM6/ENC6I/Fr6I/Ch6StSt", 
                                  "GPIO21/ENC7A/Fr7G/Ch7G", "GPIO22/ENC7B/Fr7St/Ch7St", "PWM7/ENC7I/Fr7I/Ch7StSt", 
                                  "GPIO24/CNT0",  "GPIO25/CNT1" };


        private RTDACUSB2_0103 brd;

        public DigitalIOForm(String SerialNumber)
        {
            InitializeComponent();
            Text += " / " + SerialNumber;

            ModeButtonArr = new Button[26];
            DirButtonArr = new Button[26];
            OutputButtonArr = new Button[26];
            InputTextBoxArr = new TextBox[26];
            for (uint i = 0; i < 26; i++)
            {
                ModeButtonArr[i] = new Button();
                DirButtonArr[i] = new Button();
                OutputButtonArr[i] = new Button();
                InputTextBoxArr[i] = new TextBox();
            }

            brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber(Convert.ToInt32(SerialNumber));
            brd.ReadUSBFrame();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DigitalIOForm_Load(object sender, EventArgs e)
        {
            Label dsrLabel;
            String[] Dsrp = {"Mode", "Direction", "Output", "Input" };

            Size TextSize = TextRenderer.MeasureText("XX Function XX", this.Font);
            Rectangle ScreenSize = Screen.AllScreens[0].Bounds;

            this.Size = new Size((int)(7.5 * 1.2 * TextSize.Width),
                                 (int)(27 * 1.7 * TextSize.Height) + 2 * Close.Size.Height);
            Close.Location = new Point((int)((6.2) * 1.2 * TextSize.Width),
                                       (int)((1.25) * 1.7 * TextSize.Height));

            for (int i = 0; i < 4; i++)
            {
                dsrLabel = new Label();
                dsrLabel.Text = Dsrp[i];
                if (i == 0)
                {
                    dsrLabel.Size = new Size( 2*TextSize.Width, TextSize.Height);
                    dsrLabel.Location = new Point((int)((1.0 + i) * 1.2 * TextSize.Width), (int)(0.7 * TextSize.Height));
                }
                else
                {
                    dsrLabel.Size = TextSize;
                    dsrLabel.Location = new Point((int)((2.0 + i) * 1.2 * TextSize.Width), (int)(0.7 * TextSize.Height));
                }
                dsrLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(dsrLabel);
            }
            for (int i = 0; i < 26; i++)
            {
                dsrLabel = new Label();
                dsrLabel.Text = "CN1 " + (i + 1).ToString();
                dsrLabel.Size = TextSize;
                dsrLabel.Location = new Point(0, (int)((1.35 + i) * 1.7 * TextSize.Height));
                dsrLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(dsrLabel);

                ModeButtonArr[i].Text = "Mode";
                ModeButtonArr[i].Size = new Size(2*TextSize.Width, (int)(1.7 * TextSize.Height));
                ModeButtonArr[i].Location = new Point((int)((1.0) * 1.2 * TextSize.Width),
                                          (int)((1.25 + i) * 1.7 * TextSize.Height));
                //                DirButtonArr[i].TextAlign = HorizontalAlignment.Center;
                // Dodaj kontrolke do kolekcji
                this.ModeButtonArr[i].Click += new System.EventHandler(this.ModeButton_Click);
                this.Controls.Add(ModeButtonArr[i]);

                DirButtonArr[i].Text = "Direction";
                DirButtonArr[i].Size = new Size(TextSize.Width, (int)(1.7 * TextSize.Height));
                DirButtonArr[i].Location = new Point((int)((3.0) * 1.2 * TextSize.Width),
                                          (int)((1.25 + i) * 1.7 * TextSize.Height));
                //                DirButtonArr[i].TextAlign = HorizontalAlignment.Center;
                // Dodaj kontrolke do kolekcji
                this.DirButtonArr[i].Click += new System.EventHandler(this.DirButton_Click);
                this.Controls.Add(DirButtonArr[i]);

                OutputButtonArr[i].Text = "Output";
                OutputButtonArr[i].Size = new Size(TextSize.Width, (int)(1.7 * TextSize.Height));
                OutputButtonArr[i].Location = new Point((int)((4.0) * 1.2 * TextSize.Width),
                                          (int)((1.25 + i) * 1.7 * TextSize.Height));
                this.OutputButtonArr[i].Click += new System.EventHandler(this.OutputButton_Click);
                this.Controls.Add(OutputButtonArr[i]);

                InputTextBoxArr[i].Text = "Input";
                InputTextBoxArr[i].Enabled = false;
                InputTextBoxArr[i].TextAlign = HorizontalAlignment.Center;
                InputTextBoxArr[i].Size = new Size(TextSize.Width, (int)(1.7 * TextSize.Height));
                InputTextBoxArr[i].Location = new Point((int)((5.0) * 1.2 * TextSize.Width),
                                          (int)((1.25 + i) * 1.7 * TextSize.Height));
                this.Controls.Add(InputTextBoxArr[i]);
            }

        }

        private void DirButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                if((Button)sender == DirButtonArr[i] )
                {
                    brd.ReadUSBFrame();
                    if (brd.DigitalIO.GetCN1Direction(i) == DigitalIOClass.DigitalIODirection.Input)
                        brd.DigitalIO.SetCN1Direction(i, DigitalIOClass.DigitalIODirection.Output);
                    else
                        brd.DigitalIO.SetCN1Direction(i, DigitalIOClass.DigitalIODirection.Input);
                    brd.SendUSBFrame();
//                    brd.ReadUSBFrame();
                }
            }
        }
        private void OutputButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                if ((Button)sender == OutputButtonArr[i])
                {
                    brd.ReadUSBFrame();
                    if (brd.DigitalIO.GetCN1Output(i) == DigitalIOClass.DigitalIOState.Low)
                        brd.DigitalIO.SetCN1Output(i, DigitalIOClass.DigitalIOState.High);
                    else
                        brd.DigitalIO.SetCN1Output(i, DigitalIOClass.DigitalIOState.Low);
                    brd.SendUSBFrame();
//                    brd.ReadUSBFrame();
                }
            }
        }
        private void ModeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                if ((Button)sender == ModeButtonArr[i])
                {
                    brd.ReadUSBFrame();
                    if (brd.DigitalIO.GetCN1PinMode(i) == DigitalIOClass.DigitalIOMode.GPIO)
                        brd.DigitalIO.SetCN1PinMode(i, DigitalIOClass.DigitalIOMode.Function);
                    else
                        brd.DigitalIO.SetCN1PinMode(i, DigitalIOClass.DigitalIOMode.GPIO);
                    brd.SendUSBFrame();
//                    brd.ReadUSBFrame();
                }
            }
        }

        private void DigitalIOTimer_Tick(object sender, EventArgs e)
        {
            brd.ReadUSBFrame();
            for (int i = 0; i < 26; i++)
            {
                if (brd.DigitalIO.GetCN1PinMode(i) == DigitalIOClass.DigitalIOMode.Function)
                    ModeButtonArr[i].Text = FunctionDsrp[i]; // "Function";
                if (brd.DigitalIO.GetCN1PinMode(i) == DigitalIOClass.DigitalIOMode.GPIO)
                    ModeButtonArr[i].Text = GPIODsrp[i]; // "GPIO";
                if (brd.DigitalIO.GetCN1Direction(i) == DigitalIOClass.DigitalIODirection.Input)
                    DirButtonArr[i].Text = "Input";
                if (brd.DigitalIO.GetCN1Direction(i) == DigitalIOClass.DigitalIODirection.Output)
                    DirButtonArr[i].Text = "Output";
                if (brd.DigitalIO.GetCN1Output(i) == DigitalIOClass.DigitalIOState.Low)
                    OutputButtonArr[i].Text = "Low";
                if (brd.DigitalIO.GetCN1Output(i) == DigitalIOClass.DigitalIOState.High)
                    OutputButtonArr[i].Text = "High";
                if (brd.DigitalIO.GetCN1Input(i) == DigitalIOClass.DigitalIOState.Low)
                    InputTextBoxArr[i].Text = "Low";
                if (brd.DigitalIO.GetCN1Input(i) == DigitalIOClass.DigitalIOState.High)
                    InputTextBoxArr[i].Text = "High";
                
            }

        }

    }
}
