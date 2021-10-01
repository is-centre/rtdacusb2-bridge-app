using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RTDACBoardNS;
using CyUSB;


namespace RTDACUSB2NS
{
    class RTDACUSB2 : RTDACBoard
    {
        private uint prBufferLength;
        private byte[] pByteBuffer;
        protected uint[] pUIntBuffer;
        private USBDeviceList usbDevices;
        private USBDevice RTDACDev;
        private CyBulkEndPoint eptFPGAIn;
        private CyBulkEndPoint eptFPGAOut;
        private CyBulkEndPoint eptJTAGIn;
        private CyBulkEndPoint eptJTAGOut;

        public RTDACUSB2(uint BufferLength,
                          uint NoOfDigitalIO, uint NoOfPWM, uint NoOfEncoder, 
                          uint NoOfEncoderI, uint NoOfTimer, uint NoOfCounter,
                          uint NoOfTmrCnt, uint NoOfChrono, uint NoOfFreqM )
            : base(NoOfDigitalIO, NoOfPWM, NoOfEncoder, 
                          NoOfEncoderI, NoOfTimer, NoOfCounter,
                          NoOfTmrCnt, NoOfChrono, NoOfFreqM )
        {
            prBufferLength = BufferLength;
            pByteBuffer = new byte[BufferLength + 4];
            pUIntBuffer = new uint[(int)(BufferLength / 2) + 2];
        }

        private void FlushEP(object data)
        {
            CyBulkEndPoint ept = (CyBulkEndPoint)data;
            int len = 510;
            byte[] buffer;
            buffer = new byte[len + 2];
//            while (len >0)
            {
                len = 510;
                ept.XferData(ref buffer, ref len);
                len = 510;
                ept.XferData(ref buffer, ref len);
            }
        }

        public int NumOfDevices( )
        {
            USBDeviceList lusbDevices = new USBDeviceList(CyConst.DEVICES_CYUSB);
            return lusbDevices.Count;
        }

        public int Open()
        {
            return OpenBySerialNumber(-1);
        }

        public int OpenByIdx( int BoardIdx )
        {
            usbDevices = new USBDeviceList(CyConst.DEVICES_CYUSB);

            // No RT-DAC/USB2 devices
            if ((BoardIdx < 0) || (BoardIdx>usbDevices.Count)) return -3;

            USBDevice dev = usbDevices[0];
            RTDACDev = dev;
            CyUSBDevice MyDevice = dev as CyUSBDevice;
            for (int e = 1; e < MyDevice.EndPointCount; e++)
            {
                if ((MyDevice.EndPoints[e].Address & 0x7F) == 2)
                    eptFPGAOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                if ((MyDevice.EndPoints[e].Address & 0x7F) == 4)
                    eptFPGAIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                if ((MyDevice.EndPoints[e].Address & 0x7F) == 6)
                    eptJTAGOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                if ((MyDevice.EndPoints[e].Address & 0x7F) == 8)
                    eptJTAGIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
            }
            return 0;
        }

        public int OpenBySerialNumber(int SerialNumber)
        {
            usbDevices = new USBDeviceList(CyConst.DEVICES_CYUSB);

            // No RT-DAC/USB2 devices
            if (usbDevices.Count < 1) return -2;

            // Open the first (the only one) device 
            if (SerialNumber < 0) 
            {
                USBDevice dev = usbDevices[0];
                RTDACDev = dev;
                CyUSBDevice MyDevice = dev as CyUSBDevice;
                for (int e = 1; e < MyDevice.EndPointCount; e++)
                {
                    if ((MyDevice.EndPoints[e].Address & 0x7F) == 2)
                        eptFPGAOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                    if ((MyDevice.EndPoints[e].Address & 0x7F) == 4)
                        eptFPGAIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                    if ((MyDevice.EndPoints[e].Address & 0x7F) == 6)
                        eptJTAGOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                    if ((MyDevice.EndPoints[e].Address & 0x7F) == 8)
                        eptJTAGIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                }
                return 0;
            }
            // Open RT-DAC/USB2 device with a given number
            else
            {
                foreach (USBDevice dev in usbDevices)
                {
                    if ( (dev.Manufacturer == "InTeCo") && 
                         ( Convert.ToInt32(dev.SerialNumber) == SerialNumber ) )
                    {
                        RTDACDev = dev;
                        CyUSBDevice MyDevice = dev as CyUSBDevice;
                        for (int e = 1; e < MyDevice.EndPointCount; e++)
                        {
                            if ((MyDevice.EndPoints[e].Address & 0x7F) == 2)
                                eptFPGAOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                            if ((MyDevice.EndPoints[e].Address & 0x7F) == 4)
                                eptFPGAIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                            if ((MyDevice.EndPoints[e].Address & 0x7F) == 6)
                                eptJTAGOut = MyDevice.EndPoints[e] as CyBulkEndPoint;
                            if ((MyDevice.EndPoints[e].Address & 0x7F) == 8)
                                eptJTAGIn = MyDevice.EndPoints[e] as CyBulkEndPoint;
                        }
                        return 0;
                    }
                }
                return -12;
            }
        }
        //Thread flushThread = new Thread(FlushEP);
        //flushThread.Start(eptJTAGIn);
        // Loop until worker thread activates.
        //while (!flushThread.IsAlive) ;
        // Put the main thread to sleep for 10 milliseconds to
        // allow the worker thread to do some work:
        //Thread.Sleep(10);

        //flushThread.Abort(); // kill
        ////flushThread.Join();  // wait until killed

        public virtual int ReadUSBFrame()
        {
            int len;
            pByteBuffer[0] = 0xFF;
            pByteBuffer[1] = 0x8F;
            pByteBuffer[2] = 0x00;
            pByteBuffer[3] = 0x00;
            len = 4;
            if ( ! eptFPGAOut.XferData(ref pByteBuffer, ref len))
              return -1;
            len = 504;
            if ( ! eptFPGAIn.XferData(ref pByteBuffer, ref len) )
              return -2;
            for (int i = 0; i < len; i += 2)
                pUIntBuffer[i / 2] = 256 * (uint)pByteBuffer[i + 1] + (uint)pByteBuffer[i];
            return 0; 
        }

        public virtual int SendUSBFrame()
        {
            int len = 504;

            pByteBuffer[0] = 0x0F;
            pByteBuffer[1] = 0x8F;
            for (int i = 1; i < len/2; i++)
            {
                pByteBuffer[2 * i + 0] = (byte)(pUIntBuffer[i] & 0x00FF);
                pByteBuffer[2 * i + 1] = (byte)((pUIntBuffer[i]>>8) & 0x007F);

            }

            if (eptFPGAOut.XferData(ref pByteBuffer, ref len))
                return 0;
            else
              return -1;
        }
        
    }
}
