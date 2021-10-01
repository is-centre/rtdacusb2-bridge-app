using System;
using System.Collections.Generic;
using System.Text;

namespace RTDACBoardNS
{
    // Configuration data read from the board
    class ConfigurationClass {
        public uint NoOfPWM, NoOfEncoder, NoOfEncoderI, NoOfTimer,
        NoOfCounter, NoOfTmrCnt, NoOfGeneratorImpr, NoOfFreqM,
        NoOfChrono; }
    class DigitalIOClass {
        public enum DigitalIOMode : uint { GPIO = 0, Function = 1 };
        public enum DigitalIODirection : uint { Input = 1, Output = 0 };
        public enum DigitalIOState : uint { Low = 1, High = 0 };
        private UInt32 prCN1PinMode, prCN1Direction, prCN1Input, prCN1Output;
        public UInt32 CN1PinMode
        {
            get { return prCN1PinMode; }
            set { prCN1PinMode = value; }
        }
        public UInt32 CN1Direction
        {
            get { return prCN1Direction; }
            set { prCN1Direction = value; }
        }
        public UInt32 CN1Output
        {
            get { return prCN1Output; }
            set { prCN1Output = value; }
        }
        public UInt32 CN1Input
        {
            get { return prCN1Input; }
            set { prCN1Input = value; }
        }
        public UInt32 SetCN1PinMode(int Idx, DigitalIOMode Mode)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if (Mode == DigitalIOMode.Function)
                prCN1PinMode = prCN1PinMode | Mask;
            else
                prCN1PinMode = prCN1PinMode & (~Mask);
            return prCN1PinMode;
        }
        public DigitalIOMode GetCN1PinMode(int Idx)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if ((prCN1PinMode & Mask) > 0)
                return DigitalIOMode.Function;
            else
                return DigitalIOMode.GPIO;
        }
        public UInt32 SetCN1Direction(int Idx,  DigitalIODirection Dir)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if (Dir == DigitalIODirection.Input)
                prCN1Direction = prCN1Direction | Mask;
            else
                prCN1Direction = prCN1Direction & (~Mask);
            return prCN1Direction;
        }
        public DigitalIODirection GetCN1Direction(int Idx)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if ((prCN1Direction & Mask) > 0)
                return DigitalIODirection.Input;
            else
                return DigitalIODirection.Output;
        }
        public UInt32 SetCN1Output(int Idx, DigitalIOState Out)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if (Out == DigitalIOState.High)
                prCN1Output = prCN1Output | Mask;
            else
                prCN1Output = prCN1Output & (~Mask);
            return prCN1Output;
        }
        public DigitalIOState GetCN1Output(int Idx)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if ((prCN1Output & Mask) > 0)
                return DigitalIOState.High;
            else
                return DigitalIOState.Low;
        }
        public DigitalIOState GetCN1Input(int Idx)
        {
            if ((Idx < 0) || (Idx >= 26))
                throw new IndexOutOfRangeException("Digital I/O index out of range");
            UInt32 Mask = ((UInt32)1) << Idx;
            if ((prCN1Input & Mask) > 0)
                return DigitalIOState.High;
            else
                return DigitalIOState.Low;
        }
    }
    class PWMClass
    {
        public enum PWMMode : uint { PWM8BitMode = 0, PWM12BitMode = 1 };
        static internal uint NoOf;
        private PWMClass.PWMMode prMode;
        private uint prPrescaler, prWidth;
        public PWMClass.PWMMode Mode
        {
            get { return prMode; } 
            set { prMode = value; }
        }
        public uint Prescaler
        {
            get { return prPrescaler & 0xFFFF; }
            set { prPrescaler = value & 0xFFFF; }
        }
        public uint Width
        {
            get {
                if (prMode == PWMClass.PWMMode.PWM8BitMode)
                    return prWidth & 0x00FF; 
                else
                    return prWidth & 0x0FFF;
            }
            set {
                if (prMode == PWMClass.PWMMode.PWM8BitMode)
                    prWidth = value & 0x00FF; 
                else
                    prWidth = value & 0x0FFF;
            }
        }
        static public PWMMode ToPWMMode(uint Mode)
        {
            if (Mode == 0)
                return PWMClass.PWMMode.PWM8BitMode;
            else
                return PWMClass.PWMMode.PWM12BitMode;
        }
        static public uint PWMModeToUint(PWMMode Mode)
        {
            if (Mode == PWMClass.PWMMode.PWM8BitMode)
                return 0;
            else
                return 1;
        }
    }
    class EncoderClass { static internal uint NoOf; public uint Reset, Counter; }
    class EncoderIClass {
        public enum ResetState : uint { Off = 0, On = 1 };
        public enum IdxActiveState : uint { Off = 0, On = 1 };
        public enum IdxInvertState : uint { Off = 0, On = 1 };
        static internal uint NoOf;
        public ResetState prReset;
        public IdxActiveState prIdxActive; 
        public IdxInvertState prIdxInvert; 
        public uint prCounter;
        public EncoderIClass.ResetState  Reset
        {
            get { return prReset; } 
            set { prReset = value; }
        }
        public EncoderIClass.IdxActiveState  IdxActive
        {
            get { return prIdxActive; } 
            set { prIdxActive = value; }
        }
        public EncoderIClass.IdxInvertState  IdxInvert
        {
            get { return prIdxInvert; } 
            set { prIdxInvert = value; }
        }
        public uint  Counter
        {
            get { return prCounter; } 
            set { prCounter = value; }
        }
        static public ResetState ToReset(uint Reset)
        {
            if (Reset == 0)
                return ResetState.Off;
            else
                return ResetState.On;
        }
        static public uint ResetToUInt(ResetState Reset)
        {
            if (Reset == ResetState.Off)
                return 0;
            else
                return 1;
        }
        static public IdxActiveState ToIdxActive(uint IdxActive)
        {
            if (IdxActive == 0)
                return IdxActiveState.Off;
            else
                return IdxActiveState.On;
        }
        static public uint IdxActiveToUInt(IdxActiveState IdxActive)
        {
            if (IdxActive == IdxActiveState.Off)
                return 0;
            else
                return 1;
        }
        static public IdxInvertState ToIdxInvert(uint IdxInvert)
        {
            if (IdxInvert == 0)
                return IdxInvertState.Off;
            else
                return IdxInvertState.On;
        }
        static public uint IdxInvertToUInt(IdxInvertState IdxInvertState)
        {
            if (IdxInvertState == IdxInvertState.Off)
                return 0;
            else
                return 1;
        }
    }
    class CounterClass { static internal uint NoOf; public uint Reset, Counter; }
    class TimerClass { static internal uint NoOf; public uint Reset, Counter; }
    class TmrCntClass
    {
        public enum ModeState : uint { CounterMode = 0, TimerMode = 1 };
        public enum ResetState : uint { Off = 0, On = 1 };
        static internal uint NoOf;
        private TmrCntClass.ModeState prMode;
        private TmrCntClass.ResetState prReset;
        private uint prCounter;
        public TmrCntClass.ModeState Mode
        {
            get { return prMode; }
            set { prMode = value; }
        }
        public TmrCntClass.ResetState Reset
        {
            get { return prReset; }
            set { prReset = value; }
        }
        public uint Counter
        {
            get { return prCounter; }
            set { prCounter = value; }
        }
        static public ModeState ToMode(uint Mode)
        {
            if (Mode == 0)
                return ModeState.CounterMode;
            else
                return ModeState.TimerMode;
        }
        static public uint ModeToUInt(ModeState Mode)
        {
            if (Mode == ModeState.CounterMode)
                return 0;
            else
                return 1;
        }
        static public ResetState ToReset(uint Reset)
        {
            if (Reset == 0)
                return ResetState.Off;
            else
                return ResetState.On;
        }
        static public uint ResetToUInt(ResetState Reset)
        {
            if (Reset == ResetState.Off)
                return 0;
            else
                return 1;
        }
    }
    class ChronoClass
    {
        public enum EnableState : uint { Off = 0, On = 1 };
        public enum TriggerModeState : uint { StartStop_IsH = 0, StartStop_RigingEdges = 1,
                                              StartStop_Stop_RisingEdges = 2, Unknown = 3};
        public enum EnableGateState : uint { Off = 0, On = 1 };
        public enum InvertStartStopState : uint { Off = 0, On = 1 };
        public enum InvertStopState : uint { Off = 0, On = 1 };
        public enum InvertGateState : uint { Off = 0, On = 1 };
        public enum NextState : uint { Off = 0, On = 1 };
        public enum ArmState : uint { Off = 0, On = 1 };
        public enum BlockStatusState : uint { Disabled = 0, ReadyToArm = 1,
                                              Armed = 2, Counting = 3,
                                              CntTerminated = 4, Unknown = 7 };

        static internal uint NoOf;

        private EnableState prEnable;
        private TriggerModeState prTriggerMode;
        private EnableGateState prEnableGate;
        private InvertStartStopState prInvertStartStop;
        private InvertStopState prInvertStop;
        private InvertGateState prInvertGate;
        private NextState prNext;
        private ArmState prArm;
        private BlockStatusState prBlockState;

        private uint prDivider;
        private uint prCounter;
        private uint prResult;


        public EnableState Enable
        {
            get { return prEnable; }
            set { prEnable = value; }
        }
        public TriggerModeState TriggerMode
        {
            get { return prTriggerMode; }
            set { prTriggerMode = value; }
        }
        public EnableGateState EnableGate
        {
            get { return prEnableGate; }
            set { prEnableGate = value; }
        }
        public InvertStartStopState InvertStartStop
        {
            get { return prInvertStartStop; }
            set { prInvertStartStop = value; }
        }
        public InvertStopState InvertStop
        {
            get { return prInvertStop; }
            set { prInvertStop = value; }
        }
        public InvertGateState InvertGate
        {
            get { return prInvertGate; }
            set { prInvertGate = value; }
        }
        public NextState Next
        {
            get { return prNext; }
            set { prNext = value; }
        }
        public ArmState Arm
        {
            get { return prArm; }
            set { prArm = value; }
        }
        public BlockStatusState BlockStatus
        {
            get { return prBlockState; }
            set { prBlockState = value; }
        }
        public uint Divider
        {
            get { return prDivider; }
            set { prDivider = value; }
        }
        public uint Counter
        {
            get { return prCounter; }
            set { prCounter = value; }
        }
        public uint Result
        {
            get { return prResult; }
            set { prResult = value; }
        }

        static public EnableState ToEnable(uint Enable)
        {
            if (Enable == 0)
                return EnableState.Off;
            else
                return EnableState.On;
        }
        static public uint EnableToUInt(EnableState Enable)
        {
            if (Enable == EnableState.Off)
                return 0;
            else
                return 1;
        }
        static public TriggerModeState ToTriggerMode(uint TriggerMode)
        {
            switch (TriggerMode)
            {
                case 0: return TriggerModeState.StartStop_IsH; 
                case 1: return TriggerModeState.StartStop_RigingEdges; 
                case 2: return TriggerModeState.StartStop_Stop_RisingEdges;
                default: return TriggerModeState.Unknown;
            }
        }
        static public uint TriggerModeToUInt(TriggerModeState TriggerMode)
        {
            switch (TriggerMode)
            {
                case TriggerModeState.StartStop_IsH : return 0; 
                case TriggerModeState.StartStop_RigingEdges: return 1;
                case TriggerModeState.StartStop_Stop_RisingEdges: return 2;
                default: return 3;
            }
        }
        static public EnableGateState ToEnableGate(uint EnableGate)
        {
            if (EnableGate == 0)
                return EnableGateState.Off;
            else
                return EnableGateState.On;
        }
        static public uint EnableGateToUInt(EnableGateState EnableGate)
        {
            if (EnableGate == EnableGateState.Off)
                return 0;
            else
                return 1;
        }
        static public InvertStartStopState ToInvertStartStop(uint InvertStartStop)
        {
            if (InvertStartStop == 0)
                return InvertStartStopState.Off;
            else
                return InvertStartStopState.On;
        }
        static public uint InvertStartStopToUInt(InvertStartStopState InvertStartStop)
        {
            if (InvertStartStop == InvertStartStopState.Off)
                return 0;
            else
                return 1;
        }
        static public InvertStopState ToInvertStop(uint InvertStop)
        {
            if (InvertStop == 0)
                return InvertStopState.Off;
            else
                return InvertStopState.On;
        }
        static public uint InvertStopToUInt(InvertStopState InvertStop)
        {
            if (InvertStop == InvertStopState.Off)
                return 0;
            else
                return 1;
        }
        static public InvertGateState ToInvertGate(uint InvertGate)
        {
            if (InvertGate == 0)
                return InvertGateState.Off;
            else
                return InvertGateState.On;
        }
        static public uint InvertGateToUInt(InvertGateState InvertGate)
        {
            if (InvertGate == InvertGateState.Off)
                return 0;
            else
                return 1;
        }
        static public ArmState ToArm(uint Arm)
        {
            if (Arm == 0)
                return ArmState.Off;
            else
                return ArmState.On;
        }
        static public uint ArmToUInt(ArmState Arm)
        {
            if (Arm == ArmState.Off)
                return 0;
            else
                return 1;
        }
        static public NextState ToNext(uint Next)
        {
            if (Next == 0)
                return NextState.Off;
            else
                return NextState.On;
        }
        static public uint NextToUInt(NextState Next)
        {
            if (Next == NextState.Off)
                return 0;
            else
                return 1;
        }
        static public BlockStatusState ToBlockStatus(uint BlockStatus)
        {
            switch (BlockStatus)
            {
                case 0: return BlockStatusState.Disabled;
                case 1: return BlockStatusState.ReadyToArm;
                case 2: return BlockStatusState.Armed;
                case 3: return BlockStatusState.Counting;
                case 4: return BlockStatusState.CntTerminated;
                default: return BlockStatusState.Unknown;
            }
        }
        static public uint BlockStatusToUInt(BlockStatusState BlockStatus)
        {
            switch (BlockStatus)
            {
                case BlockStatusState.Disabled: return 0;
                case BlockStatusState.ReadyToArm: return 1;
                case BlockStatusState.Armed: return 2;
                case BlockStatusState.Counting: return 3;
                case BlockStatusState.CntTerminated: return 4;
                default: return 7;
            }
        }

 
    }
    class FreqMClass
    {

        public enum EnableState : uint { Off = 0, On = 1 };
        public enum ModeState : uint { Single = 0, Continous = 1 };
        public enum InfiniteFlagState : uint { Off = 0, On = 1 };
        public enum SwStartState : uint { Off = 0, On = 1 };
        public enum StartInvState : uint { Off = 0, On = 1 };
        public enum SwGateState : uint { Off = 0, On = 1 };
        public enum SwHwGateStartState : uint { Software = 0, Hardware = 1 };
        public enum GateInvState : uint { Off = 0, On = 1 };
        public enum GateModeState : uint { Input = 0, TimeAndInput = 1 };
        public enum InputInvState : uint { Off = 0, On = 1 };
        public enum ReadyState : uint { Off = 0, On = 1 };

        static internal uint NoOf;

        private EnableState prEnable;
        private ModeState prMode;
        private InfiniteFlagState prInfiniteFlag;
        private SwStartState prSwStart;
        private StartInvState prStartInv;
        private SwGateState prSwGate;
        private SwHwGateStartState prSwHwGateStart;
        private GateInvState prGateInv;
        private GateModeState prGateMode;
        private InputInvState prInputInv;
        private ReadyState prReady;

        private uint prTimer;
        private uint prCounter;
        private uint prResult;


        public EnableState Enable
        {
            get { return prEnable; }
            set { prEnable = value; }
        }
        public ModeState Mode
        {
            get { return prMode; }
            set { prMode = value; }
        }
        public InfiniteFlagState InfiniteFlag
        {
            get { return prInfiniteFlag; }
            set { prInfiniteFlag = value; }
        }
        public SwStartState SwStart
        {
            get { return prSwStart; }
            set { prSwStart = value; }
        }
        public StartInvState StartInv
        {
            get { return prStartInv; }
            set { prStartInv = value; }
        }
        public SwGateState SwGate
        {
            get { return prSwGate; }
            set { prSwGate = value; }
        }
        public SwHwGateStartState SwHwGateStart
        {
            get { return prSwHwGateStart; }
            set { prSwHwGateStart = value; }
        }
        public GateInvState GateInv
        {
            get { return prGateInv; }
            set { prGateInv = value; }
        }
        public GateModeState GateMode
        {
            get { return prGateMode; }
            set { prGateMode = value; }
        }
        public InputInvState InputInv
        {
            get { return prInputInv; }
            set { prInputInv = value; }
        }
        public ReadyState Ready
        {
            get { return prReady; }
            set { prReady = value; }
        }
        public uint Timer
        {
            get { return prTimer; }
            set { prTimer = value; }
        }
        public uint Counter
        {
            get { return prCounter; }
            set { prCounter = value; }
        }
        public uint Result
        {
            get { return prResult; }
            set { prResult = value; }
        }

        static public EnableState ToEnable(uint Enable)
        {
            if (Enable == 0)
                return EnableState.Off;
            else
                return EnableState.On;
        }
        static public uint EnableToUInt(EnableState Enable)
        {
            if (Enable == EnableState.Off)
                return 0;
            else
                return 1;
        }
        static public ModeState ToMode(uint Mode)
        {
            if (Mode == 0)
                return ModeState.Single;
            else
                return ModeState.Continous;
        }
        static public uint ModeToUInt(ModeState Mode)
        {
            if (Mode == ModeState.Single)
                return 0;
            else
                return 1;
        }
        static public InfiniteFlagState ToInfiniteFlag(uint InfiniteFlag)
        {
            if (InfiniteFlag == 0)
                return InfiniteFlagState.Off;
            else
                return InfiniteFlagState.On;
        }
        static public uint InfiniteFlagToUInt(InfiniteFlagState InfiniteFlag)
        {
            if (InfiniteFlag == InfiniteFlagState.Off)
                return 0;
            else
                return 1;
        }
        static public SwStartState ToSwStart(uint SwStart)
        {
            if (SwStart == 0)
                return SwStartState.Off;
            else
                return SwStartState.On;
        }
        static public uint SwStartToUInt(SwStartState SwStart)
        {
            if (SwStart == SwStartState.Off)
                return 0;
            else
                return 1;
        }
        static public StartInvState ToStartInv(uint StartInv)
        {
            if (StartInv == 0)
                return StartInvState.Off;
            else
                return StartInvState.On;
        }
        static public uint StartInvToUInt(StartInvState StartInv)
        {
            if (StartInv == StartInvState.Off)
                return 0;
            else
                return 1;
        }
        static public SwGateState ToSwGate(uint SwGate)
        {
            if (SwGate == 0)
                return SwGateState.Off;
            else
                return SwGateState.On;
        }
        static public uint SwGateToUInt(SwGateState SwGate)
        {
            if (SwGate == SwGateState.Off)
                return 0;
            else
                return 1;
        }
        static public SwHwGateStartState ToSwHwGateStart(uint SwHwGateStart)
        {
            if (SwHwGateStart == 0)
                return SwHwGateStartState.Software;
            else
                return SwHwGateStartState.Hardware;
        }
        static public uint SwHwGateStartToUInt(SwHwGateStartState SwHwGateStart)
        {
            if (SwHwGateStart == SwHwGateStartState.Software)
                return 0;
            else
                return 1;
        }
        static public GateInvState ToGateInv(uint GateInv)
        {
            if (GateInv == 0)
                return GateInvState.Off;
            else
                return GateInvState.On;
        }
        static public uint GateInvToUInt(GateInvState GateInv)
        {
            if (GateInv == GateInvState.Off)
                return 0;
            else
                return 1;
        }
        static public GateModeState ToGateMode(uint GateMode)
        {
            if (GateMode == 0)
                return GateModeState.TimeAndInput;
            else
                return GateModeState.Input;
        }
        static public uint GateModeToUInt(GateModeState GateMode)
        {
            if (GateMode == GateModeState.TimeAndInput)
                return 0;
            else
                return 1;
        }
        static public InputInvState ToInputInv(uint InputInv)
        {
            if (InputInv == 0)
                return InputInvState.Off;
            else
                return InputInvState.On;
        }
        static public uint InputInvToUInt(InputInvState InputInv)
        {
            if (InputInv == InputInvState.Off)
                return 0;
            else
                return 1;
        }
        static public ReadyState ToReady(uint Ready)
        {
            if (Ready == 0)
                return ReadyState.Off;
            else
                return ReadyState.On;
        }
        static public uint ReadyToUInt(ReadyState Ready)
        {
            if (Ready == ReadyState.Off)
                return 0;
            else
                return 1;
        }


    }
    class DAClass
    {
        const uint prNoOf = 4;
        private uint prDAValue;

        static public uint NoOf
        {
            get { return prNoOf; }
        }
        public uint DAValue
        {
            get { return prDAValue; }
            set { prDAValue = value; }
        }
        public double DAVoltage
        {
            get { return -10.0 + 20.0*prDAValue/16383.0; }
            set {
                double AuxDA;
                AuxDA = 10 + Math.Max(-10, Math.Min(10, value));
                prDAValue = (uint)(16383.0*AuxDA/20.0); 
            }  
        }
    }
    class ADClass
    {
        const uint prNoOf = 16;
        public enum GainState : uint { x1 = 0, x2 = 1, x4 = 2, x8 = 3, x16 = 4 };
        public enum BusyState : uint { Off = 0, On = 1 };

        private uint prADValue;
        private GainState prADGain;
        private BusyState prADBusy;

        static public uint NoOf
        {
            get { return prNoOf; }
        }
        public uint ADValue
        {
            get { return prADValue; }
            set { prADValue = value; }
        }
        public GainState ADGain
        {
            get { return prADGain; }
            set { prADGain = value; }
        }
        public BusyState ADBusy
        {
            get { return prADBusy; }
            set { prADBusy = value; }
        }
        public double ADVoltage
        {
            get{
              double ADResult, AuxGain;
              switch (prADGain)
              {
                case GainState.x1: AuxGain = 1; break;
                case GainState.x2: AuxGain = 2; break;
                case GainState.x4: AuxGain = 4; break;
                case GainState.x8: AuxGain = 8; break;
                case GainState.x16: AuxGain = 16; break;
                default: AuxGain = 1; break;
              }
              ADResult = (double)(prADValue & 0x0FFF);
              if( ADResult >= 2048 ) ADResult = ADResult - 4096;
              return 10.0 * (ADResult / 2048.0 / AuxGain);
           }
        }
        static public BusyState ToBusy(uint Busy)
        {
            if (Busy == 0)
                return BusyState.Off;
            else
                return BusyState.On;
        }
        static public uint BusyToUInt(BusyState Busy)
        {
            if (Busy == BusyState.Off)
                return 0;
            else
                return 1;
        }
        static public GainState ToGain(uint Gain)
        {
            switch (Gain)
            {
                case 0: return GainState.x1;
                case 1: return GainState.x2;
                case 2: return GainState.x4;
                case 3: return GainState.x8;
                case 4: return GainState.x16;
                default: return GainState.x1;
            }
        }
        static public uint GainToUInt(GainState Gain)
        {
            switch (Gain)
            {
                case GainState.x1: return 0; 
                case GainState.x2: return 1; 
                case GainState.x4: return 2; 
                case GainState.x8: return 3; 
                case GainState.x16: return 4; 
                default: return 0; 
            }
        }

    }

    class RTDACBoard
    {
        private string prBoardName;
        private string prBoardVersion;
        private uint prNoOfDigitalIO;

        protected string pApplicationName;
        protected uint pLogicVersion;
        protected string pSynthesisDate;
//        protected string pManufacturer;
//        protected string pProduct;
//        protected uint ProductID, VendorID;

        public ConfigurationClass Configuration = new ConfigurationClass();
        public DigitalIOClass DigitalIO = new DigitalIOClass();

        private PWMClass[] prPWM;
        private TmrCntClass[] prTmrCnt;
        private EncoderIClass[] prEncoderI;
        private ChronoClass[] prChrono;
        private FreqMClass[] prFreqM;
        private DAClass[] prDA;
        private ADClass[] prAD;
//        private int prADStart;
//        private int prADReady;

        public RTDACBoard()
        {
            prBoardName = "";
            prBoardVersion = "";
        }
        public RTDACBoard(uint NoOfDigitalIO, uint NoOfPWM, uint NoOfEncoder, 
                          uint NoOfEncoderI, uint NoOfTimer, uint NoOfCounter, 
                          uint NoOfTmrCnt, uint NoOfChrono, uint NoOfFreqM )
        {
            int i;
            prBoardName = BoardName;
            prBoardVersion = BoardVersion;
            prNoOfDigitalIO = NoOfDigitalIO;
            if (NoOfPWM > 0)
            {
                prPWM = new PWMClass[NoOfPWM];
                PWMClass.NoOf = NoOfPWM;
                for (i = 0; i < NoOfPWM; i++)
                    prPWM[i] = new PWMClass();
            }
            else
                PWMClass.NoOf = 0;
            if (NoOfEncoderI > 0)
            {
                prEncoderI = new EncoderIClass[NoOfEncoderI];
                EncoderIClass.NoOf = NoOfEncoderI;
                for (i = 0; i < NoOfEncoderI; i++)
                    prEncoderI[i] = new EncoderIClass();
            }
            else
                EncoderIClass.NoOf = 0;
            if (NoOfTmrCnt > 0)
            {
                prTmrCnt = new TmrCntClass[NoOfTmrCnt];
                TmrCntClass.NoOf = NoOfTmrCnt;
                for (i = 0; i < NoOfTmrCnt; i++)
                    prTmrCnt[i] = new TmrCntClass();
            }
            else
                TmrCntClass.NoOf = 0;
            if (NoOfChrono > 0)
            {
                prChrono = new ChronoClass[NoOfChrono];
                ChronoClass.NoOf = NoOfChrono;
                for (i = 0; i < NoOfChrono; i++)
                    prChrono[i] = new ChronoClass();
            }
            else
                ChronoClass.NoOf = 0;
            if (NoOfFreqM > 0)
            {
                prFreqM = new FreqMClass[NoOfFreqM];
                FreqMClass.NoOf = NoOfFreqM;
                for (i = 0; i < NoOfFreqM; i++)
                    prFreqM[i] = new FreqMClass();
            }
            else
                FreqMClass.NoOf = 0;

            prDA = new DAClass[DAClass.NoOf];
            for (i = 0; i < DAClass.NoOf; i++)
                prDA[i] = new DAClass();

            prAD = new ADClass[ADClass.NoOf];
            for (i = 0; i < ADClass.NoOf; i++)
                prAD[i] = new ADClass();
        }

        public PWMClass PWM(int Idx)
        {
            if ((Idx < 0) || (Idx >= PWMClass.NoOf))
                throw new IndexOutOfRangeException("PWM index out of range");
            else
                return prPWM[Idx];
        }
        public EncoderIClass EncoderI(int Idx)
        {
            if ((Idx < 0) || (Idx >= EncoderIClass.NoOf))
                throw new IndexOutOfRangeException("EncoderI index out of range");
            else
                return prEncoderI[Idx];
        }
        public TmrCntClass TmrCnt(int Idx)
        {
            if ((Idx < 0) || (Idx >= TmrCntClass.NoOf))
                throw new IndexOutOfRangeException("TmrCnt index out of range");
            else
                return prTmrCnt[Idx];
        }
        public ChronoClass Chrono(int Idx)
        {
            if ((Idx < 0) || (Idx >= ChronoClass.NoOf))
                throw new IndexOutOfRangeException("Chrono index out of range");
            else
                return prChrono[Idx];
        }
        public FreqMClass FreqM(int Idx)
        {
            if ((Idx < 0) || (Idx >= FreqMClass.NoOf))
                throw new IndexOutOfRangeException("FreqM index out of range");
            else
                return prFreqM[Idx];
        }
        public DAClass DA(int Idx)
        {
            if ((Idx < 0) || (Idx >= DAClass.NoOf))
                throw new IndexOutOfRangeException("DA index out of range");
            else
                return prDA[Idx];
        }
        public ADClass AD(int Idx)
        {
            if ((Idx < 0) || (Idx >= ADClass.NoOf))
                throw new IndexOutOfRangeException("AD index out of range");
            else
                return prAD[Idx];
        }
//        public int ADStart
//        {
//            get { return prADStart; }
//            set { prADStart = value; }
//        }
//        public int ADReady
//        {
//            get { return prADReady; }
//            set { prADReady = value; }
//        }

        public string BoardName {     get { return prBoardName; } }
        public string BoardVersion { get { return prBoardVersion; } }
        public string ApplicationName { get { return pApplicationName; } }
        public uint LogicVersion { get { return pLogicVersion; } }
        public string SynthesisDate { get { return pSynthesisDate; } }
        public uint NoOfDigitalIO { get { return prNoOfDigitalIO; } }
        public uint NoOfPWM { get { return PWMClass.NoOf; } }
        public uint NoOfTmrCnt { get { return TmrCntClass.NoOf; } }
        public uint NoOfEncoderI { get { return EncoderIClass.NoOf; } }
        public uint NoOfChrono { get { return ChronoClass.NoOf; } }
        public uint NoOfFreqM { get { return FreqMClass.NoOf; } }
        public uint NoOfDA { get { return DAClass.NoOf; } }
        public uint NoOfAD { get { return ADClass.NoOf; } }
    }
}
