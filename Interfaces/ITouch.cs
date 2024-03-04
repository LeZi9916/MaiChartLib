using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface ITouch : INote
{
    SensorType Sensor { get; set; }
    bool SFX { get; set; }
    new bool IsHanabi { get; }
    new bool IsBreak { get; }
}
