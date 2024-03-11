using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface INote
{
    int StartPoint { get; set; }
    NoteType Type { get; }
    bool IsBreak { get; set; }
    bool IsHanabi { get; set; }
    double HSpeed { get; set; }
    
}
