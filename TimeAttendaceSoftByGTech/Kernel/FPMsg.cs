using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TimeAttendaceSoftByGTech.Kernel
{
    class FPMsg
    {
        /* 消息类型定义 */
        public enum FP_MSG_TYPE_T
        {
            FP_MSG_PRESS_FINGER,                // 录入指纹 提示按手指
            FP_MSG_RISE_FINGER,                 // 录入指纹 提示抬手指
            FP_MSG_ENROLL_TIME,                 // 录入指纹 次数提示
            FP_MSG_CAPTURED_IMAGE,              // 录入指纹 图像反馈               
        };

        //* 消息处理函数定义 */
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void FpMessageHandler(FP_MSG_TYPE_T enMsgType, IntPtr pMsgData);
    }
}
