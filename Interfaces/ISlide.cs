using MaiChartLib.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiChartLib.Interfaces
{
    internal interface ISlide : INote
    {
        SlidePath[]? Path { get; set; }
    }
}
