using MaiChartLib.Enum;
using MaiChartLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiChartLib.Notes
{
    internal class Hold : IHold,INote<Hold>
    {
        public long Length { get; set; }
        public int StartPoint { get; set; }
        public NoteType Type { get; set; }
        public bool IsBreak {  get; set; }
        public bool IsHanabi { get; set; }
        public double HSpeed { get; set; }
        public static Tap[]? Parse(string s)
        {

        }
        public static INote[]? ToNote(string s)
        {
            return null;
        }
    }
}
