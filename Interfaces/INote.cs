using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface INote
{
    int StartPoint { get; set; }
    NoteType Type { get; }
    bool IsBreak { get; set; }
    bool IsHanabi { get; set; }
    double HSpeed { get; set; }

    abstract static INote[]? ToNote(string noteStr);
}
internal interface INote<T> : INote where T : INote
{
    abstract static T[]? Parse(string noteStr);
}
