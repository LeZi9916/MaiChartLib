
using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface ISlide : INote
{
    int Length { get; set; }
    double StartInterval { get; set; }
    int EndPoint { get; set; }
    int? FlexionPoint { get; set; }
    new SlideType Type { get; set; }
    new bool isEx { get; }
    new double HSpeed { get; }
}
