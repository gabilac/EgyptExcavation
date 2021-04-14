using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class Textile
    {
        public int TextileId { get; set; }
        public int? SampleId { get; set; }
        public string? OriginEstimate { get; set; }
        public string? PhotoDate { get; set; }
        public string? SampledDate { get; set; }
        public string? ScientificDate { get; set; }
        public string? Description { get; set; }
        public string? AnalysisDate { get; set; }
        public string? AnalysisType { get; set; }
        public string? Analyst { get; set; }
        public string? Structure { get; set; }
        public string? Dimension { get; set; }
        public string? Function { get; set; }
        public string? Decoration { get; set; }
        public string? Color { get; set; }
        public string? Component { get; set; }
        public string? Material { get; set; }
        public string? Manipulation { get; set; }
        public string? Ply { get; set; }
        public string? Direction { get; set; }
        public string? Angle { get; set; }
        public string? Count { get; set; }
        public string? Thickness { get; set; }
        public string? Category { get; set; }
        public bool? Copy { get; set; }
    }
}
