using MaiChartLib.Enum;
using MaiChartLib.Interfaces;

namespace MaiChartLib.Note;

internal class Slide : Tap,ISlide
{
    public new NoteType Type { get => NoteType.Star; }
    public SlidePath[]? Path { get; set; }
}