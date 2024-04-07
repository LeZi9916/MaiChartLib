using MaiChartLib.Enum;
using MaiChartLib.Interfaces;

namespace MaiChartLib.Notes;

internal class Slide : IHold
{
    public double Length { get; set; }
    public double WaitTime { get; set; }
    public int StartPoint { get; set; }
    public int EndPoint { get; set; }
    /// <summary>
    /// 转折点
    /// </summary>
    public int? FlexionPoint { get; set; }
    public double Time { get; set; }
    public NoteType Type { get => NoteType.Slide;}
    public SlideType SlideType { get; set; }
    public bool IsEx { get => false; set => throw new NotSupportedException(""); }
    public bool IsBreak { get; set; }
    public double HSpeed { get => 1; set => throw new NotSupportedException(""); }    
    public static INote? ToNote(string s) => throw new NotSupportedException("");
}