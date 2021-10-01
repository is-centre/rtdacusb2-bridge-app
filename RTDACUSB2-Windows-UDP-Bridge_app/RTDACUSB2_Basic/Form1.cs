using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using RTDACUSB2_0103NS;
using RTDACUSB2NS;
using RTDACBoardNS;
using CyUSB;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Diagnostics;

namespace RTDACUSB2_Basic
{
    public partial class BasicForm : Form
    {
        private USBDeviceList usbDevices;
        private int UPTO_ADC = 3, UPTO_DAC = 3; // Including 0, so 3 means 0, 1, 2, 3
        static bool VisibleDescr = true;
        static bool RealTimeCommRunning = false;

        private static IPEndPoint localEPt;
        private static IPEndPoint remoteEPt;

        static UdpClient udp_rt;

        private RTDACUSB2_0103 brd;

        public BasicForm()
        {
            InitializeComponent();

            usbDevices = new USBDeviceList(CyConst.DEVICES_CYUSB); // | CyConst.DEVICES_HID | CyConst.DEVICES_MSC);
            usbDevices.DeviceAttached += new EventHandler(usbDevices_DeviceAttached);
            usbDevices.DeviceRemoved += new EventHandler(usbDevices_DeviceRemoved);

            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.Close, "Close the application");
            toolTip1.SetToolTip(this.button1, "Test no of read and send \noperations per second");

            // Set up board object
            brd = new RTDACUSB2_0103();
        }

        private void Close_Click(object sender, EventArgs e)
        {
//            for (int i = 100; i > 0; i--)
//            {
//                Opacity = (double)(i / 100);
//                System.Threading.Thread.Sleep(10);
//            Application.DoEvents();
//                //Validate();
//            }
            base.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opacity -= 0.1;
            RTDACUSB2_0103 brd = new RTDACUSB2_0103();
            brd.OpenBySerialNumber( -1);
//            brd.ReadUSBFrame();
//            MessageBox.Show(brd.TmrCnt(0).Counter.ToString());

            HPTimer hpt = new HPTimer();
            hpt.Start();
            int NoLoops = 10000;
            for (int i = 0; i < NoLoops; i++) brd.ReadUSBFrame();
            hpt.Stop();
            MessageBox.Show(String.Format("Duration: {0:E}  ({1})\nRead/sec: {2}",
                            hpt.Duration(), NoLoops, (int)(NoLoops / hpt.Duration())));
            hpt.Start();
            for (int i = 0; i < NoLoops; i++) brd.SendUSBFrame();
            hpt.Stop();
            MessageBox.Show(String.Format("Duration: {0:E}  ({1})\nSend/sec: {2}",
                            hpt.Duration(), NoLoops, (int)(NoLoops / hpt.Duration())));
           
        

        }

        private void BasicForm_Load(object sender, EventArgs e)
        {
            RTDACUSB2 board = new RTDACUSB2(256,26,4,0,8,0,0,2, 8, 8);
            //board.BoardName = "sss";
            //MessageBox.Show(board.BoardName,board.BoardVersion);
            //MessageBox.Show(board.ToString());
            RefreshDeviceTree();

        }

        private void ReadBuffer_Click(object sender, EventArgs e)
        {
            ReadForm frm = new ReadForm(256);
            frm.Show();
        }
        private void SendBuffer_Click(object sender, EventArgs e)
        {
            SendForm frm = new SendForm(256);
            frm.Show();
        }

        void usbDevices_DeviceRemoved(object sender, EventArgs e)
        {
            RefreshDeviceTree();
        }


        void usbDevices_DeviceAttached(object sender, EventArgs e)
        {
            RefreshDeviceTree();
        }

        private void RefreshDeviceTree()
        {
            BoardList.Items.Clear();
            DeviceTreeView.Nodes.Clear(); RTDACReference.RTDACDev = null;
            foreach (USBDevice dev in usbDevices)
            {
                DeviceTreeView.Nodes.Add(dev.Tree);
                if (dev.Manufacturer == "InTeCo")
                {
                    RTDACReference.RTDACDev = dev;
                    CyUSBDevice MyDevice = RTDACReference.RTDACDev as CyUSBDevice;
                    for (int e = 1; e < MyDevice.EndPointCount; e++)
                    {
                        if ((MyDevice.EndPoints[e].Address & 0x7F) == 2)
                            RTDACReference.eptFPGAOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                        if ((MyDevice.EndPoints[e].Address & 0x7F) == 4)
                            RTDACReference.eptFPGAIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                    }
                    String sAux;
                    sAux = RTDACReference.RTDACDev.Manufacturer + " / " +
                           RTDACReference.RTDACDev.Product + " / " +
                           String.Format("{0:X4}", RTDACReference.RTDACDev.VendorID) + " / " +
                           String.Format("{0:X4}", RTDACReference.RTDACDev.ProductID) + " / " +
                           RTDACReference.RTDACDev.SerialNumber.ToString();

                    BoardList.Items.Add( sAux );
                    BoardList.SelectedIndex = 0;
                }
            }
            if (RTDACReference.RTDACDev != null)
            {
                Descr.Text = "";
                button1.Enabled = Test.Enabled = SendBuffer.Enabled = ReadBuffer.Enabled = true;
                TmrCntShow.Enabled = DigitalIOShow.Enabled = PWMShow.Enabled = button2.Enabled = true;
                ChronoShow.Enabled = FreqMShow.Enabled = true;
                ADShow.Enabled = DAShow.Enabled = true;
                MainFormTimer.Enabled = false;

                // Enable real-time comm
                btnStartRealTime.Enabled = true;
                txtStatus.Text = "Device ready";

                RTDACUSB2_0103 brd;
                brd = new RTDACUSB2_0103();

                brd.OpenBySerialNumber( -1);
                brd.ReadUSBFrame();
                FPGAVersion.Text = String.Format("{0:X4}", brd.LogicVersion);
                FPGAName.Text = brd.ApplicationName;
                SynthesisDate.Text = brd.SynthesisDate.Substring(0,4) + "-" +
                                     brd.SynthesisDate.Substring(4,2) + "-" +
                                     brd.SynthesisDate.Substring(6,2);
                NoOfPWMEncEncI.Text = String.Format("{0:D}", brd.Configuration.NoOfPWM) + @"/" +
                                      String.Format("{0:D}", brd.Configuration.NoOfEncoder) + @"/" +
                                      String.Format("{0:D}", brd.Configuration.NoOfEncoderI);
                NoOfTmrCntTmcCnt.Text = String.Format("{0:D}", brd.Configuration.NoOfTimer) + @"/" +
                                        String.Format("{0:D}", brd.Configuration.NoOfCounter) + @"/" +
                                        String.Format("{0:D}", brd.Configuration.NoOfTmrCnt);
                NoOfGenFreqMChrono.Text = String.Format("{0:D}", brd.Configuration.NoOfGeneratorImpr) + @"/" +
                                          String.Format("{0:D}", brd.Configuration.NoOfFreqM) + @"/" +
                                          String.Format("{0:D}", brd.Configuration.NoOfChrono);
            }
            else
            {
                Descr.Text = "Can not find any RT-DAC/USB2 device !!!".ToUpper();
                Descr.Font = new Font(Descr.Font, FontStyle.Bold);
                Descr.ForeColor = Color.Red;
                button1.Enabled=Test.Enabled = SendBuffer.Enabled=ReadBuffer.Enabled = false;
                TmrCntShow.Enabled = DigitalIOShow.Enabled = PWMShow.Enabled = button2.Enabled = false;
                
                // Disable real-time comm
                btnStartRealTime.Enabled = false;
                txtStatus.Text = "Device not ready";

                ChronoShow.Enabled = FreqMShow.Enabled = false;
                ADShow.Enabled = DAShow.Enabled = false;
                MainFormTimer.Enabled = true;
                MainFormTimer.Interval = 500;
                FPGAVersion.Text = FPGAName.Text = SynthesisDate.Text = "";
                NoOfPWMEncEncI.Text = NoOfTmrCntTmcCnt.Text = NoOfGenFreqMChrono.Text = "";
            }
        }

        private void BoardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        private void TmrCntShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            TmrCntForm frm = new TmrCntForm(dev.SerialNumber);
            frm.Show();
        }

        private void DigitalIOShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            DigitalIOForm frm = new DigitalIOForm(dev.SerialNumber);
            frm.Show();
        }

        private void PWMShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            PWMForm frm = new PWMForm(dev.SerialNumber);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            EncoderIForm frm = new EncoderIForm(dev.SerialNumber);
            frm.Show();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Test frm = new Test();
            frm.Show();
        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            if( VisibleDescr )
                Descr.Visible = VisibleDescr = false;
            else
                Descr.Visible = VisibleDescr = true;
        }

        private void ChronoShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            ChronoForm frm = new ChronoForm(dev.SerialNumber);
            frm.Show();
        }

        private void FreqMShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            FreqMForm frm = new FreqMForm(dev.SerialNumber);
            frm.Show();
        }

        private void DAShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            DAForm frm = new DAForm(dev.SerialNumber);
            frm.Show();
        }

        private void ADShow_Click(object sender, EventArgs e)
        {
            USBDevice dev = usbDevices[BoardList.SelectedIndex];
            ADForm frm = new ADForm(dev.SerialNumber);
            frm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnStartRealTime_Click(object sender, EventArgs e)
        {
            if (!RealTimeCommRunning)
            {
                btnStartRealTime.Text = "Stop Real-Time Comms";
                txtStatus.Text = "Running real-time communication over UDP...";
                RealTimeCommRunning = true;

                try
                {
                    // Start A/D and D/A
                    USBDevice dev = usbDevices[BoardList.SelectedIndex];
                    brd.OpenBySerialNumber(Convert.ToInt32(dev.SerialNumber));
                    
                    // Initialize the socket
                    InitializeUdpClient();
                }
                catch
                {
                    MessageBox.Show("Cannot open specified serial port.");
                    btnStartRealTime.Text = "Start Real-Time Comms";
                    txtStatus.Text = "Device ready";
                    RealTimeCommRunning = false;
                }
            }
            else
            {
                btnStartRealTime.Text = "Start Real-Time Comms";
                txtStatus.Text = "Device ready";
                RealTimeCommRunning = false;
                udp_rt.Close(); // Order is important, if close before, it fires the event to process bytes and because the socket is already closeds, it does not work
            }

        }
        
        private void InitializeUdpClient()
        {
            try
            {
                udp_rt = new UdpClient();

                string inPort = txtInPort.Text;
                string outPort = txtOutPort.Text;

                localEPt = new IPEndPoint(IPAddress.Any, int.Parse(inPort));
                remoteEPt = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(outPort));

                udp_rt.ExclusiveAddressUse = false;
                udp_rt.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udp_rt.Client.Bind(localEPt);
                udp_rt.BeginReceive(udp_DataReceived, udp_rt);
                RealTimeCommRunning = true;
                btnStartRealTime.Text = "Stop Real-Time Comms";
            }
            catch (Exception e)
            {
                btnStartRealTime.Text = "Start Real-Time Comms";
                RealTimeCommRunning = false;
                MessageBox.Show(e.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // The stuff is synced externally. MATLAB/Simulink will be responsible
        // for this in our case.
        private void udp_DataReceived(IAsyncResult res){

            // Only do something if serial communication is running
            if (RealTimeCommRunning)
            {
               // Let's get the bytes now
               UdpClient client = (UdpClient)res.AsyncState;
               IPEndPoint recvIpEndPt = new IPEndPoint(IPAddress.Any, 0);
               Byte[] recvBytes = client.EndReceive(res, ref recvIpEndPt);
               
               // First, read ADCs
               uint[] ADCValues = new uint[UPTO_ADC + 1];
               brd.ReadUSBFrame();

               for (int i = 0; i <= UPTO_ADC; i++)
               {
                   uint currentIn = brd.AD(i).ADValue;
                   // Convert the result to 0...2048 scale
                   if (currentIn >= 0 && currentIn <= 2047)
                   {
                       currentIn += 2048;
                   }
                   else if (currentIn >= 2048 && currentIn <= 4095)
                   {
                       currentIn -= 2048;
                   }

                   ADCValues[i] = currentIn;
               }
               
               // Once all of them are in, assign to bytes
               Byte[] sendBytes = new Byte[2 * (UPTO_ADC + 1)];
               for (int i = 0; i <= UPTO_ADC; i++)
               {
                   byte[] currentByte = BitConverter.GetBytes((UInt16)ADCValues[i]);
                   sendBytes[i * 2] = currentByte[0];
                   sendBytes[i * 2 + 1] = currentByte[1];
               }
               
               // Now, deal with setting the DACs
               UInt16 currentOut;
               for (int i = 0; i <= UPTO_DAC; i++)
               {
                   currentOut = BitConverter.ToUInt16(recvBytes, 2 * i);
                   brd.DA(i).DAValue = (uint)currentOut;
               }
               // Send USB frame with new outs
               brd.SendUSBFrame();
               
               // Now send the bytes
               client.Send(sendBytes, sendBytes.Length, remoteEPt);

               // Add the event again
               client.BeginReceive(udp_DataReceived, client);

            }
        }
    }

    class HPTimer
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        private long startTime;
        private long stopTime;
        private long frequency;

        public HPTimer()
        {
            startTime = stopTime = 0;
            QueryPerformanceFrequency(out frequency);
        }
        public void Start()
        {
            QueryPerformanceCounter(out startTime);
        }
        public void Stop()
        {
            QueryPerformanceCounter(out stopTime);
        }
        public double Duration()
        {
            return ((double)(stopTime - startTime) / (double)frequency);
        }
    }

    class RTDACReference
    {
        static public USBDevice RTDACDev;
        static public CyBulkEndPoint eptFPGAIn;
        static public CyBulkEndPoint eptFPGAOut;
    }

   
}