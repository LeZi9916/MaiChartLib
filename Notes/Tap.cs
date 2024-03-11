using MaiChartLib.Enum;
using MaiChartLib.Exceptions;
using MaiChartLib.Interfaces;
using MaiChartLib.SyntaxModule;
using System;

namespace MaiChartLib.Notes
{
    internal class Tap:INote
    {
        public int StartPoint { get; set; }
        public NoteType Type { get => NoteType.Tap; }
        public bool IsBreak { get; set; }
        public bool IsHanabi { get; set; }
        public double HSpeed { get; set; }
        public static T Init<T>(int point) where T:Tap,new() => new T()
        {
            StartPoint = point,
            IsBreak = false,
            IsHanabi = false
        };
    }
}
