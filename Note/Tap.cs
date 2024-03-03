using MaiChartLib.Enum;
using MaiChartLib.Interfaces;
using MaiChartLib.SyntaxModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiChartLib.Note
{
    internal class Tap : INote ,INote<Tap>
    {
        public int StartPoint { get; set; }
        public NoteType Type { get; set; }
        public bool isBreak { get; set; }
        public bool isEx { get; set; }
        public double HSpeed { get; set; }

        public static Tap? Parse(string noteStr)
        {
            if (string.IsNullOrEmpty(noteStr))
                return null;
            var result = SyntaxChecker.IsNote(noteStr);
            if (result is null)
                return null;

            return null;
        }
        public static INote? ToNote(string noteStr) => Parse(noteStr);
    }
}
