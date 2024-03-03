using MaiChartLib.Enum;
using MaiChartLib.Interfaces;

namespace MaiChartLib.Note;

internal class SlidePath :ISlidePath
{
    public int Length { get; set; }
    public double StartInterval { get; set; }
    public int EndPoint { get; set; }
    public int? FlexionPoint { get; set; }
    public NoteType Type { get; init; }
    public SlideType sType { get; set; }
    public bool IsHanabi { get => false; set => throw new NotSupportedException(""); }
    public bool IsBreak { get; set; }
    public double HSpeed { get => -1; set => throw new NotSupportedException(""); }
    public int StartPoint { get; set; }
    public static INote ToNote(string s) => throw new NotSupportedException("");
}