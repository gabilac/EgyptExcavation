using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models.ViewModels
{
    public class BurialViewModel
    {
        public Burial Burial { get; set; }

        public Square Square { get; set; }

        public List<Sample> Samples { get; set; }

        public double CalcPlotSize(Burial burial)
        {
            if (burial.WtoHead != null &&
                burial.WtoFeet != null &&
                burial.StoHead != null &&
                burial.StoFeet != null)
            {
                var w2h = (double)burial.WtoHead;
                var w2f = (double)burial.WtoFeet;
                var s2h = (double)burial.StoHead;
                var s2f = (double)burial.StoFeet;
                var calcPlotSize = (double)Math.Sqrt(Math.Pow((w2h - w2f), 2) + (Math.Pow((s2h - s2f), 2)));
                return (calcPlotSize);
            }
            else
            {
                return (0);
            }
        }
    }
}
