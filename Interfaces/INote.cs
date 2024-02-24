using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface INote
{
    int StartPoint { get; set; }
    NoteType Type { get; set; }
    bool isBreak { get; set; }
    bool isEx { get; set; }
    double HSpeed { get; set; }

    INote Parse(string noteStr);
}
internal interface INote<T> : INote where T : INote
{
    new T Parse(string noteStr);
}
