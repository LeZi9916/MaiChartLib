using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface ITouch : INote
{
    SensorType Sensor { get; set; }
    bool SFX { get; set; }
    new bool isEx { get; }
    new bool isBreak { get; }
}
