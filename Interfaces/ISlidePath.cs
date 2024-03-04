
using MaiChartLib.Enum;
using MaiChartLib.Notes;

namespace MaiChartLib.Interfaces;
internal interface ISlidePath : INote
{
    int Length { get; set; }
    double StartInterval { get; set; }
    int EndPoint { get; set; }
    int? FlexionPoint { get; set; }
    SlideType sType { get; set; }
    new bool IsHanabi { get; }
    new double HSpeed { get; }
}
