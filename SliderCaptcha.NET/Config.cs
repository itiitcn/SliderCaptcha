using System;

namespace SliderCaptcha.NET
{
    public class Config
    {
        /// <summary>
        /// 矩形宽
        /// </summary>
        public static int l = 42;
        /// <summary>
        /// 圆形半径
        /// </summary>
        public static int r = 9;
        /// <summary>
        /// 圆形直径
        /// </summary>
        public static int d = r * 2;
        /// <summary>
        /// 计算圆形与矩形交接三角形边
        /// </summary>
        public static int a = (int)(r * Math.Sin(Math.PI * (50 / 180f)));
        public static int b = (int)(r * Math.Cos(Math.PI * (50 / 180f)));
        public static int c = r - a;
        /// <summary>
        /// 滑块边框
        /// </summary>
        public static int blod = 2;
        /// <summary>
        /// 水印
        /// </summary>
        public static string watermarkText = "SC.NET";
        /// <summary>
        /// 是否显示水印
        /// </summary>
        public static bool showWatermark = true;

    }
}
