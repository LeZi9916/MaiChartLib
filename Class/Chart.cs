using MaiChartLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaiChartLib.Class
{
    public struct Bpm
    {
        public required double Time { get; set; }
        public required double Value { get; set; }
    }
    internal class Chart
    {
        public required string Designer { get; set; }
        public required string Level { get; set; }
        public required Bpm[] BpmInfo { get; set; }
        public required INote[] Notes { get; set; }
    }
}
