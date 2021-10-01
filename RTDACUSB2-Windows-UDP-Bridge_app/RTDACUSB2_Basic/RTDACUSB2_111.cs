using System;
using System.Collections.Generic;
using System.Text;
using CyUSB;
using RTDACBoardNS;
using RTDACUSB2NS;

namespace RTDACUSB2_111NS
{
    class RTDACUSB2_111 : RTDACUSB2
    {
        public RTDACUSB2_111(string BoardName, string BoardVersion, uint BufferLength,
                          uint NoOfDigitalIO, uint NoOfPWM, uint NoOfEncoder,
                          uint NoOfEncoderI, uint NoOfTimer, uint NoOfCounter,
                          uint NoOfTmrCnt, uint NoOfChrono, uint NoOfFreqM )
            : base(BoardName, BoardVersion, BufferLength, NoOfDigitalIO, NoOfPWM, NoOfEncoder, 
                          NoOfEncoderI, NoOfTimer, NoOfCounter,
                          NoOfTmrCnt, NoOfChrono, NoOfFreqM )
        {
        }

        public override int ReadUSBFrame()
        {
            char[] AuxChar = new char[6];
            int i;

            base.ReadUSBFrame();

            pLogicVersion = pUIntBuffer[0];

            AuxChar[0] = System.Convert.ToChar((pUIntBuffer[3] >> 8) & 0xFF);
            AuxChar[1] = System.Convert.ToChar((pUIntBuffer[3] >> 0) & 0xFF);
            AuxChar[2] = System.Convert.ToChar((pUIntBuffer[2] >> 8) & 0xFF);
            AuxChar[3] = System.Convert.ToChar((pUIntBuffer[2] >> 0) & 0xFF);
            AuxChar[4] = System.Convert.ToChar((pUIntBuffer[1] >> 8) & 0xFF);
            AuxChar[5] = System.Convert.ToChar((pUIntBuffer[1] >> 0) & 0xFF);
            pApplicationName = System.Convert.ToString(AuxChar[0]) +
                               System.Convert.ToString(AuxChar[1]) +
                               System.Convert.ToString(AuxChar[2]) +
                               System.Convert.ToString(AuxChar[3]) +
                               System.Convert.ToString(AuxChar[4]) +
                               System.Convert.ToString(AuxChar[5]);
            pSynthesisDate = String.Format("{0:X4}", (((UInt32)pUIntBuffer[5]) << 16) + pUIntBuffer[4]);

            Configuration.NoOfPWM =           (pUIntBuffer[6] >>  0) & 0x000F;
            Configuration.NoOfEncoder =       (pUIntBuffer[6] >>  4) & 0x000F;
            Configuration.NoOfEncoderI =      (pUIntBuffer[6] >>  8) & 0x000F;
            Configuration.NoOfTimer =         (pUIntBuffer[6] >> 12) & 0x000F;
            Configuration.NoOfCounter =       (pUIntBuffer[7] >>  0) & 0x000F;
            Configuration.NoOfTmrCnt =        (pUIntBuffer[7] >>  4) & 0x000F;
            Configuration.NoOfGeneratorImpr = (pUIntBuffer[7] >>  8) & 0x000F;
            Configuration.NoOfFreqM =         (pUIntBuffer[7] >> 12) & 0x000F;
            Configuration.NoOfChrono =        (pUIntBuffer[8] >>  0) & 0x000F;

            DigitalIO.CN1PinMode = (((UInt32)(pUIntBuffer[11])) << 16) | (UInt32)pUIntBuffer[10];
            DigitalIO.CN1Direction = (((UInt32)(pUIntBuffer[13])) << 16) | (UInt32)pUIntBuffer[12];
            DigitalIO.CN1Output = (((UInt32)(pUIntBuffer[15])) << 16) | (UInt32)pUIntBuffer[14];
            DigitalIO.CN1Input = (((UInt32)(pUIntBuffer[17])) << 16) | (UInt32)pUIntBuffer[16];

            for (i = 0; i < NoOfPWM; i++)
            {
                PWM(i).Prescaler = pUIntBuffer[20 + 3*i];
                PWM(i).Mode = PWMClass.ToPWMMode(pUIntBuffer[21 + 3 * i] & 0x0001);
                PWM(i).Width = pUIntBuffer[22 + 3*i] & 0x0FFF;
            }

            for (i = 0; i < NoOfEncoderI; i++)
            {
                EncoderI(i).Reset = EncoderIClass.ToReset(((pUIntBuffer[50] >> i) & 0x0001));
                EncoderI(i).IdxActive = EncoderIClass.ToIdxActive(((pUIntBuffer[51] >> i) & 0x0001));
                EncoderI(i).IdxInvert = EncoderIClass.ToIdxInvert(((pUIntBuffer[52] >> i) & 0x0001));
                EncoderI(i).Counter = (((UInt32)pUIntBuffer[54 + 2 * i]) << 16) | (UInt32)pUIntBuffer[53 + 2 * i];
            }

            for (i = 0; i < NoOfTmrCnt; i++)
            {
                TmrCnt(i).Reset = TmrCntClass.ToReset((pUIntBuffer[70] >> i) & 0x0001);
                TmrCnt(i).Mode = TmrCntClass.ToMode((pUIntBuffer[71] >> i) & 0x0001);
                TmrCnt(i).Counter = (((UInt32)pUIntBuffer[73 + 2 * i]) << 16) | (UInt32)pUIntBuffer[72 + 2 * i];
            }

            for (i = 0; i < NoOfFreqM; i++)
            {
                FreqM(i).Enable = FreqMClass.ToEnable((pUIntBuffer[80] >> i) & 0x0001);
                FreqM(i).Mode = FreqMClass.ToMode((pUIntBuffer[81] >> i) & 0x0001);
                FreqM(i).InfiniteFlag = FreqMClass.ToInfiniteFlag((pUIntBuffer[82] >> i) & 0x0001);
                FreqM(i).SwStart = FreqMClass.ToSwStart((pUIntBuffer[83] >> i) & 0x0001);
                FreqM(i).StartInv = FreqMClass.ToStartInv((pUIntBuffer[84] >> i) & 0x0001);
                FreqM(i).SwGate = FreqMClass.ToSwGate((pUIntBuffer[85] >> i) & 0x0001);
                FreqM(i).SwHwGateStart = FreqMClass.ToSwHwGateStart((pUIntBuffer[86] >> i) & 0x0001);
                FreqM(i).GateInv = FreqMClass.ToGateInv((pUIntBuffer[87] >> i) & 0x0001);
                FreqM(i).GateMode = FreqMClass.ToGateMode((pUIntBuffer[88] >> i) & 0x0001);
                FreqM(i).InputInv = FreqMClass.ToInputInv((pUIntBuffer[89] >> i) & 0x0001);
                FreqM(i).Ready = FreqMClass.ToReady((pUIntBuffer[106] >> i) & 0x0001);
                FreqM(i).Timer = (((UInt32)pUIntBuffer[91 + 2 * i]) << 16) | (UInt32)pUIntBuffer[90 + 2 * i];
                FreqM(i).Result = (((UInt32)pUIntBuffer[108 + 2 * i]) << 16) | (UInt32)pUIntBuffer[107 + 2 * i];
            }

            for (i = 0; i < NoOfChrono; i++)
            {
                Chrono(i).Enable = ChronoClass.ToEnable((pUIntBuffer[130+i] >>  0) & 0x0001);
                Chrono(i).TriggerMode = ChronoClass.ToTriggerMode((pUIntBuffer[130+i] >>  1) & 0x0003);
                Chrono(i).EnableGate = ChronoClass.ToEnableGate((pUIntBuffer[130+i] >>  4) & 0x0001);
                Chrono(i).InvertStartStop = ChronoClass.ToInvertStartStop((pUIntBuffer[130+i] >>  6) & 0x0001);
                Chrono(i).InvertStop = ChronoClass.ToInvertStop((pUIntBuffer[130+i] >>  7) & 0x0001);
                Chrono(i).InvertGate = ChronoClass.ToInvertGate((pUIntBuffer[130+i] >>  8) & 0x0001);
                Chrono(i).Next = ChronoClass.ToNext((pUIntBuffer[130 + i] >> 10) & 0x0001);
                Chrono(i).Arm = ChronoClass.ToArm((pUIntBuffer[130 + i] >> 11) & 0x0001);
                Chrono(i).BlockStatus = ChronoClass.ToBlockStatus((pUIntBuffer[130 + i] >> 13) & 0x0007);
                Chrono(i).Divider = (((UInt32)pUIntBuffer[139 + 2 * i]) << 16) | (UInt32)pUIntBuffer[138 + 2 * i];
                Chrono(i).Counter = (((UInt32)pUIntBuffer[155 + 2 * i]) << 16) | (UInt32)pUIntBuffer[154 + 2 * i];
                Chrono(i).Result = (((UInt32)pUIntBuffer[171 + 2 * i]) << 16) | (UInt32)pUIntBuffer[170 + 2 * i];
            }

            AD(0).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[190] >> 0) & 0x0007);
            AD(1).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[190] >> 4) & 0x0007);
            AD(2).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[190] >> 8) & 0x0007);
            AD(3).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[190] >> 12) & 0x0007);
            AD(4).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[191] >> 0) & 0x0007);
            AD(5).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[191] >> 4) & 0x0007);
            AD(6).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[191] >> 8) & 0x0007);
            AD(7).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[191] >> 12) & 0x0007);
            AD(8).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[192] >> 0) & 0x0007);
            AD(9).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[192] >> 4) & 0x0007);
            AD(10).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[192] >> 8) & 0x0007);
            AD(11).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[192] >> 12) & 0x0007);
            AD(12).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[193] >> 0) & 0x0007);
            AD(13).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[193] >> 4) & 0x0007);
            AD(14).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[193] >> 8) & 0x0007);
            AD(15).ADGain = ADClass.ToGain(((UInt32)pUIntBuffer[193] >> 12) & 0x0007); 
            for (i = 0; i < ADClass.NoOf; i++)
            {
                AD(i).ADValue = (UInt32)pUIntBuffer[194 + i] & 0x0FFF;
                AD(i).ADBusy = ADClass.ToBusy(((UInt32)pUIntBuffer[194 + i] >> 12) & 0x0001);
            }
ADStart = (int)((UInt32)pUIntBuffer[215] & 0x0001);
ADReady = (int)(((UInt32)pUIntBuffer[215] >> 1) & 0x0001);
           
            for (i = 0; i < DAClass.NoOf; i++)
            {
                DA(i).DAValue = (UInt32)pUIntBuffer[210 + i] & 0x3FFF;
            }

            return 0; 
        }

        public override int SendUSBFrame()
        {
            int i;

            pUIntBuffer[10] = DigitalIO.CN1PinMode & 0x7FFF;
            pUIntBuffer[11] = (DigitalIO.CN1PinMode >> 15) & 0x07FF;
            pUIntBuffer[12] = DigitalIO.CN1Direction & 0x7FFF;
            pUIntBuffer[13] = (DigitalIO.CN1Direction >> 15) & 0x07FF;
            pUIntBuffer[14] = DigitalIO.CN1Output & 0x7FFF;
            pUIntBuffer[15] = (DigitalIO.CN1Output >> 15) & 0x07FF;

            for (i = 0; i < Configuration.NoOfPWM; i++)
            {
                pUIntBuffer[20 + 3 * i] = PWM(i).Prescaler & 0x7FFF;
                pUIntBuffer[21 + 3 * i] = (PWMClass.PWMModeToUint(PWM(i).Mode) << 1) +
                                          ((PWM(i).Prescaler>>15) & 1);
                pUIntBuffer[22 + 3 * i] = PWM(i).Width & 0x0FFF;
            }

            pUIntBuffer[50] = pUIntBuffer[51] = pUIntBuffer[52] = 0;
            for (i = 0; i < Configuration.NoOfEncoderI; i++)
            {
                pUIntBuffer[50] += (uint)(1 << i) * EncoderIClass.ResetToUInt(EncoderI(i).Reset);
                pUIntBuffer[51] += (uint)(1 << i) * EncoderIClass.IdxActiveToUInt(EncoderI(i).IdxActive);
                pUIntBuffer[52] += (uint)(1 << i) * EncoderIClass.IdxInvertToUInt(EncoderI(i).IdxInvert);
            }

            pUIntBuffer[70] = pUIntBuffer[71] = 0;
            for (i = 0; i < Configuration.NoOfTmrCnt; i++)
            {
                pUIntBuffer[70] += (uint)(1<<i) * TmrCntClass.ResetToUInt(TmrCnt(i).Reset);
                pUIntBuffer[71] += (uint)(1<<i) * TmrCntClass.ModeToUInt(TmrCnt(i).Mode);
            }

            pUIntBuffer[80] = pUIntBuffer[81] = pUIntBuffer[82] = pUIntBuffer[83] = 0;
            pUIntBuffer[84] = pUIntBuffer[85] = pUIntBuffer[86] = pUIntBuffer[87] = 0;
            pUIntBuffer[88] = pUIntBuffer[89] = 0;
            for (i = 0; i < NoOfFreqM; i++)
            {
                pUIntBuffer[80] += (uint)(1 << i) * FreqMClass.EnableToUInt(FreqM(i).Enable);
                pUIntBuffer[81] += (uint)(1 << i) * FreqMClass.ModeToUInt(FreqM(i).Mode);
                pUIntBuffer[82] += (uint)(1 << i) * FreqMClass.InfiniteFlagToUInt(FreqM(i).InfiniteFlag);
                pUIntBuffer[83] += (uint)(1 << i) * FreqMClass.SwStartToUInt(FreqM(i).SwStart);
                pUIntBuffer[84] += (uint)(1 << i) * FreqMClass.StartInvToUInt(FreqM(i).StartInv);
                pUIntBuffer[85] += (uint)(1 << i) * FreqMClass.SwGateToUInt(FreqM(i).SwGate);
                pUIntBuffer[86] += (uint)(1 << i) * FreqMClass.SwHwGateStartToUInt(FreqM(i).SwHwGateStart);
                pUIntBuffer[87] += (uint)(1 << i) * FreqMClass.GateInvToUInt(FreqM(i).GateInv);
                pUIntBuffer[88] += (uint)(1 << i) * FreqMClass.GateModeToUInt(FreqM(i).GateMode);
                pUIntBuffer[89] += (uint)(1 << i) * FreqMClass.InputInvToUInt(FreqM(i).InputInv);
                pUIntBuffer[90 + 2 * i] = FreqM(i).Timer & 0x7FFF;
                pUIntBuffer[91 + 2 * i] = (FreqM(i).Timer >> 15) & 0x7FFF;
            }

            for (i = 0; i < Configuration.NoOfChrono; i++)
            {
                pUIntBuffer[130 + i] = 2048 * ChronoClass.ArmToUInt(Chrono(i).Arm) +
                                       1024 * ChronoClass.NextToUInt(Chrono(i).Next) +
                                        256 * ChronoClass.InvertGateToUInt(Chrono(i).InvertGate) +
                                        128 * ChronoClass.InvertStopToUInt(Chrono(i).InvertStop) +
                                         64 * ChronoClass.InvertStartStopToUInt(Chrono(i).InvertStartStop) +
                                         16 * ChronoClass.EnableGateToUInt(Chrono(i).EnableGate) +
                                          2 * ChronoClass.TriggerModeToUInt(Chrono(i).TriggerMode) +
                                          1 * ChronoClass.EnableToUInt(Chrono(i).Enable);
                pUIntBuffer[138 + 2 * i] = Chrono(i).Divider & 0x7FFF;
                pUIntBuffer[139 + 2 * i] = (Chrono(i).Divider >> 15) & 0x7FFF;
            }

            for (i = 0; i < DAClass.NoOf; i++)
            {
                pUIntBuffer[210 + i] = DA(i).DAValue & 0x3FFF;
            }

            pUIntBuffer[190] = pUIntBuffer[191] = pUIntBuffer[192] = pUIntBuffer[193] = 0;
            pUIntBuffer[190] += ((ADClass.GainToUInt(AD(0).ADGain) & 0x0007) << 0);
            pUIntBuffer[190] += ((ADClass.GainToUInt(AD(1).ADGain) & 0x0007) << 4);
            pUIntBuffer[190] += ((ADClass.GainToUInt(AD(2).ADGain) & 0x0007) << 8);
            pUIntBuffer[190] += ((ADClass.GainToUInt(AD(3).ADGain) & 0x0007) << 12);
            pUIntBuffer[191] += ((ADClass.GainToUInt(AD(4).ADGain) & 0x0007) << 0);
            pUIntBuffer[191] += ((ADClass.GainToUInt(AD(5).ADGain) & 0x0007) << 4);
            pUIntBuffer[191] += ((ADClass.GainToUInt(AD(6).ADGain) & 0x0007) << 8);
            pUIntBuffer[191] += ((ADClass.GainToUInt(AD(7).ADGain) & 0x0007) << 12);
            pUIntBuffer[192] += ((ADClass.GainToUInt(AD(8).ADGain) & 0x0007) << 0);
            pUIntBuffer[192] += ((ADClass.GainToUInt(AD(9).ADGain) & 0x0007) << 4);
            pUIntBuffer[192] += ((ADClass.GainToUInt(AD(10).ADGain) & 0x0007) << 8);
            pUIntBuffer[192] += ((ADClass.GainToUInt(AD(11).ADGain) & 0x0007) << 12);
            pUIntBuffer[193] += ((ADClass.GainToUInt(AD(12).ADGain) & 0x0007) << 0);
            pUIntBuffer[193] += ((ADClass.GainToUInt(AD(13).ADGain) & 0x0007) << 4);
            pUIntBuffer[193] += ((ADClass.GainToUInt(AD(14).ADGain) & 0x0007) << 8);
            pUIntBuffer[193] += ((ADClass.GainToUInt(AD(15).ADGain) & 0x0007) << 12);

if( ADStart > 0 )
    pUIntBuffer[215] = 1;
else
    pUIntBuffer[215] = 0;

            base.SendUSBFrame();
            return 0;
        }

    }

}
