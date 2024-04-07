using MaiChartLib.Enum;

namespace MaiChartLib.Notes;

internal class Star : Tap
{
    public new NoteType Type { get => NoteType.Star; }
    public Slide[]? Slides { get; set; }
}