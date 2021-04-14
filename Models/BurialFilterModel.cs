using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EgyptExcavation.Models
{
    public class BurialFilterModel
    {
        public string? BurialCompositeId { get; set; }

        public int? YearFoundFrom { get; set; }
        public int? YearFoundTo { get; set; }

        public string? BodyColGender { get; set; }

        public decimal? EstimatedAgeFrom { get; set; }
        public decimal? EstimatedAgeTo { get; set; }

        public string? HairColor { get; set; }

        public decimal? DepthFrom { get; set; }
        public decimal? DepthTo { get; set; }

        public decimal? LengthofRemainsFrom { get; set; }
        public decimal? LengthofRemainsTo { get; set; }

        public string? HeadDirection { get; set; }

        public bool? HairTaken { get; set; }

        public bool? SoftTissueTaken { get; set; }

        public bool? BoneTaken { get; set; }

        public bool? ToothTaken { get; set; }

        public bool? TextileTaken { get; set; }

        public bool? ArtifactFound { get; set; }


        public string? Notes { get; set; }
    }
}

