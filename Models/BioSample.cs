using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class BioSample
    {
        public int BioSampleId { get; set; }
        public bool? PreviouslySampled { get; set; }
        public string? Desc { get; set; }
        public int? Bag { get; set; }
        public string? ResearcherInitials { get; set; }
        public string? Date { get; set; }
        public int SampleId { get; set; }

    }
}
