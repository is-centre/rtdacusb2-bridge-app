using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CyUSB;


namespace RTDACUSB2_Basic
{
    public partial class ReadForm : Form
    {
        private TextBox[] TBoxArr;
        private uint BufferLength;

        //public ReadForm()
        //{
        //    InitializeComponent();
        //}
        public ReadForm(uint BufferLength)
        {
            TBoxArr = new TextBox[BufferLength];
            for (uint i = 0; i < BufferLength; i++)
            {
                TBoxArr[i] = new TextBox();
            }
            this.BufferLength = BufferLength;
            InitializeComponent();
            CyUSBDevice MyDevice = RTDACReference.RTDACDev as CyUSBDevice;

        }

        private void CloseReadForm_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void ReadForm_Load(object sender, EventArgs e)
        {
            Label dsrLabel;
            Size TextSize = TextRenderer.MeasureText("XXXXX", this.Font);
            Rectangle ScreenSize = Screen.AllScreens[0].Bounds;

            this.Size = new Size((int)(17.5*1.2*TextSize.Width),
                                 19 * 2*TextSize.Height + 2*CloseReadForm.Size.Height);

            for (int i = 0; i < 16; i++)
            {
                dsrLabel = new Label();
                dsrLabel.Text = "+ " + (i).ToString();
                dsrLabel.Size = TextSize;
                dsrLabel.Location = new Point((int)((1.0+i)*1.2*TextSize.Width), TextSize.Height);
                dsrLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(dsrLabel);
                dsrLabel = new Label();
                dsrLabel.Text = "+ " + (i).ToString();
                dsrLabel.Size = TextSize;
                dsrLabel.Location = new Point(0, (int)((1.35+i)*2*TextSize.Height));
                dsrLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(dsrLabel);
            }
            
            for(int i=0;i<16;i++)
            {
                for(int j=0;j<16;j++)
                {
                  TBoxArr[16*j+i].Text = "" + (16*j+i).ToString();
                  TBoxArr[16 * j + i].Size = TextSize;
                  TBoxArr[16 * j + i].Location = new Point((int)((1.0 + i) * 1.2*TextSize.Width),
                                                           (int)((1.25 + j) * 2 * TextSize.Height));
                  TBoxArr[16*j+i].ReadOnly = true;
                  TBoxArr[16*j+i].TextAlign = HorizontalAlignment.Center;

                  // Dodaj kontrolke do kolekcji
                  this.Controls.Add(TBoxArr[16*j+i]);
                }
            }

            CloseReadForm.Location = new Point((int)(TBoxArr[255].Location.X + TBoxArr[255].Size.Width - CloseReadForm.Width),
                                               (int)(this.Height - 3.0 * CloseReadForm.Height));
            DecHex.Location = new Point((int)(TBoxArr[255].Location.X + TBoxArr[255].Size.Width - (int)(2.3*CloseReadForm.Width)),
                                             (int)(this.Height - 3.0 * CloseReadForm.Height));

        }

        private void ReadTimer_Tick(object sender, EventArgs e)
        {
            byte[] buff = new byte[512];
            int len;
            buff[0] = 0xFF;
            buff[1] = 0x8F;
            buff[2] = 0x00;
            buff[3] = 0x00;
            len = 4;
            RTDACReference.eptFPGAOut.XferData(ref buff, ref len);
            len = 504;
            RTDACReference.eptFPGAIn.XferData(ref buff, ref len);

            for(int i=0;i<BufferLength;i++)
            {
                len = 256 * (int)(buff[2 * i + 1]) + (int)(buff[2 * i]);
                if (DecHex.Text == "Dec")
                    TBoxArr[i].Text = String.Format("{0:D}", len);
                else
                    TBoxArr[i].Text = String.Format("{0:X4}", len);
            }
        }

        private void DecHex_Click(object sender, EventArgs e)
        {
            if (DecHex.Text == "Dec")
                DecHex.Text = "Hex";
            else
                DecHex.Text = "Dec";
        }

    }
}
