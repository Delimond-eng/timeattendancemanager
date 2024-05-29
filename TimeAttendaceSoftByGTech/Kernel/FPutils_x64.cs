using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TimeAttendaceSoftByGTech.Kernel
{
    class FPutils_x64
    {
        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_OpenDevice();

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_CloseDevice();

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_DetectFinger(ref int pdwFpstatus);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_CaptureImage(byte[] pbyImageData, ref int pdwWidth, ref int pdwHeight);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_SetTimeout(int dwSecond);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_GetTimeout(ref int pdwSecond);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_SetCollectTimes(int dwTimes);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_GetCollectTimes(ref int pdwTimes);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_InstallMessageHandler(FPMsg.FpMessageHandler msgHandler);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_FpEnroll(byte[] pbyFpTemplate);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_GetQuality(byte[] pbyFpTemplate);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_MatchTemplate(byte[] pbyFpTemplate1, byte[] pbyFpTemplate2, int dwSecurityLevel);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_GetDeviceInfo(byte[] pbyDeviceInfo);

        [DllImport(@"FPModule_SDK_x64.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int FPModule_GetSDKVersion(byte[] pbySDKVersion);
    }
}
