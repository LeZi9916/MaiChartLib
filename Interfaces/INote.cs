using MaiChartLib.Enum;

namespace MaiChartLib.Interfaces;
internal interface INote
{
    /// <summary>
    /// 键位
    /// </summary>
    int StartPoint { get; set; }
    /// <summary>
    /// 时间点
    /// </summary>
    double Time { get; set; }
    /// <summary>
    /// Note类型
    /// </summary>
    NoteType Type { get; }
    /// <summary>
    /// 是否为Break
    /// </summary>
    bool IsBreak { get; set; }
    /// <summary>
    /// 是否为Ex Note
    /// </summary>
    bool IsEx { get; set; }
    /// <summary>
    /// 变速值
    /// </summary>
    double HSpeed { get; set; }
    
}
