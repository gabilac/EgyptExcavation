using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class Sample
    {
        public int SampleId { get; set; }
        public int? BioSampleId { get; set; }
        public int? TextileId { get; set; }
        public int BurialKey { get; set; }
        public int? Area { get; set; }
        public int? Size { get; set; }
        public int? Foci { get; set; }
        public int? C14sample { get; set; }
        public int? Rack { get; set; }
        public int? TubeNo { get; set; }
        public string? Category { get; set; }
        public string? LocationDesc { get; set; }
        public string? Question { get; set; }
        public string? Notes { get; set; }
        public int? ConventionalAgeBp { get; set; }
        public int? CalendarDate14C { get; set; }
        public int? MinCalibratedCalendarDate { get; set; }
        public int? MaxCalibratedCalendarDate { get; set; }
        public string? AvgCalibratedCalendarDate { get; set; }
        public int? SpanCalibratedCalendarDate { get; set; }
    }
}
