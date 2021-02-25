﻿using System;
using System.Runtime.InteropServices;

namespace HotelRegulator
{
    class Win32
    {
        /// <summary>
        /// 执行动画
        /// </summary>
        /// <param name="whnd">控件句柄</param>
        /// <param name="dwtime">动画时间</param>
        /// <param name="dwflag">动画组合名称</param>
        /// <returns>bool值，动画是否成功</returns>
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);
        /// <summary>
        /// 从左到右显示
        /// </summary>
        public const int AW_HOR_POSITIVE = 0x00000001;
        /// <summary>
        /// 从右到左显示
        /// </summary>
        public const int AW_HOR_NEGATIVE = 0x00000002;
        /// <summary>
        /// 从上到下显示
        /// </summary>
        public const int AW_VER_POSITIVE = 0x00000004;
        /// <summary>
        /// 从下到上显示
        /// </summary>
        public const int AW_VER_NEGATIVE = 0x00000008;
        /// <summary>
        /// 若使用了AW_HIDE标志，则使窗口向内重叠，即收缩窗口；否则使窗口向外扩展，即展开窗口
        /// </summary>
        public const int AW_CENTER = 0x00000010;
        /// <summary>
        /// 隐藏窗口，缺省则显示窗口
        /// </summary>
        public const int AW_HIDE = 0x00010000;
        /// <summary>
        /// 激活窗口。在使用了AW_HIDE标志后不能使用这个标志
        /// </summary>
        public const int AW_ACTIVATE = 0x00020000;
        /// <summary>
        /// 使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略
        /// </summary>
        public const int AW_SLIDE = 0x00040000;
        /// <summary>
        /// 透明度从高到低
        /// </summary>
        public const int AW_BLEND = 0x00080000;
    }
}
