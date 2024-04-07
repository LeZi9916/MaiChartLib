using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiChartLib.Class
{
    internal class ChartFile
    {
        /// <summary>
        /// 谱面文件夹
        /// </summary>
        public required string Root { get; init; }
        /// <summary>
        /// 曲目艺术家
        /// </summary>
        public required string Artist { get; set; }
        /// <summary>
        /// 谱面文件偏移
        /// </summary>
        public double Offset { get; set; } = 0;
    }
}
