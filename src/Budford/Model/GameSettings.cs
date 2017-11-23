﻿using System.Collections.Generic;

namespace Budford.Model
{
    public class GameSettings
    {
        public string PreferedVersion  = "Latest";

        public EmulationStateType EmulationState = EmulationStateType.NotSet;
        public EmulationStateType OfficialEmulationState = EmulationStateType.NotSet;
        public HashSet<GraphicsPack> graphicsPacks  = new HashSet<GraphicsPack>();

        // CEMU Options
        public byte FullScreen  = 1;
        public byte EnableVSync  = 0;
        public UpscaleFilterType UpscaleFilter  = UpscaleFilterType.Bicubic;
        public FullScreenScalingType FullScreenScaling  = FullScreenScalingType.KeepAspectRatio;
        public GpuBufferCacheAccuracyType GpuBufferCacheAccuracy  = GpuBufferCacheAccuracyType.Medium;

        // CPU
        public CpuModeType CpuMode  = CpuModeType.SingleCoreCompiler;
        public CpuTimerType CpuTimer  = CpuTimerType.HostBasedTimer;



        public byte DebugGX2ApiOffset;
        public byte DebugUnsupportedAPICallsOffset ;
        public byte DebugThreadSynchronisationAPIOffset ;
        public byte DebugAudioAPIOffset ;
        public byte DebugInputAPIOffset ;

        public byte EnableDebugOffset;

        public byte Volume = 0x1E;


        // CEMU Hook
        public CpuAffinityType CpuAffinity  = CpuAffinityType.AllLogicalCores;

        public byte RenderUpsideDown ;
        public byte DisableAudio ;
        public byte EnableBoTWCrashWorkaround ;
        public byte FullSyncAtGX2DrawDone ;
        public byte SeparateGamePadView ;
        public byte AccaccurateShaderMul  = 1;
        public byte DisableGPUFence ;
        public byte EmulateSinglePrecision ;

        public enum GpuBufferCacheAccuracyType : byte
        {
            Low = 2,
            Medium = 1,
            High = 0
        }

        public enum FullScreenScalingType : byte
        {
            KeepAspectRatio = 0,
            Stretch = 1
        }

        public enum UpscaleFilterType : byte
        {
            Bilinear = 0,
            Bicubic = 1
        }

        public enum CpuModeType : byte
        {
            SingleCoreInterpreter = 0,
            SingleCoreCompiler = 1
        }

        public enum CpuTimerType : byte
        {
            CycleBasedTimer = 0,
            HostBasedTimer = 1
        }

        public enum CpuAffinityType : byte
        {
            AllLogicalCores = 0,
            FirstLogicalCodePerPhysicaCore = 1,
            LastLogicalCodePerPhysicaCore = 2
        }

        public enum EmulationStateType : byte
        {
            NotSet = 0,
            Perfect = 1,
            Playable = 2,
            Runs = 3,
            Loads = 4,
            Unplayable = 5
        }

      
    }
}