using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class Burial
    {
        [Key]
        public int BurialKey { get; set; }
        public string? BurialCompositeId { get; set; }
        public string? BurialNo { get; set; }
        public int? SquareId { get; set; }
        public string? Quadrant { get; set; }
        public string? BurialType { get; set; }
        public int? WtoHead { get; set; }
        public int? WtoFeet { get; set; }
        public int? StoHead { get; set; }
        public int? StoFeet { get; set; }
        public int? YearExcavated { get; set; }
        public string? MonthExcavated { get; set; }
        public int? DayExcavated { get; set; }
        public string? Notes { get; set; }
        public decimal? LengthofRemains { get; set; }
        public string? Category { get; set; }
        public int? SampleNo { get; set; }
        public int? PreservationIndex { get; set; }
        public string? PreservationNotes { get; set; }
        public decimal? Depth { get; set; }
        public string? HairColor { get; set; }
        public string? Sex { get; set; }
        public string? SexMethod { get; set; }
        public string? AgeRange { get; set; }
        public string? AgeMethod { get; set; }
        public string? AgeCategory { get; set; }
        public string? HeadDirection { get; set; }
        public string? BurialWrapping { get; set; }
        public bool? HairTaken { get; set; }
        public bool? SoftTissueTaken { get; set; }
        public bool? BoneTaken { get; set; }
        public bool? ToothTaken { get; set; }
        public bool? TextileTaken { get; set; }
        public string? SampleDesc { get; set; }
        public bool? ArtifactFound { get; set; }
        public string? ArtifactDesc { get; set; }
        public decimal? EstimatedAge { get; set; }
        public decimal? EstimatedHeight { get; set; }
        public int? ToothAttrition { get; set; }
        public string? ToothEruption { get; set; }
        public string? PathologyAnomolies { get; set; }
        public string? EpiphysealUnion { get; set; }
        public int? YearFound { get; set; }
        public string? MonthFound { get; set; }
        public int? DayFound { get; set; }
        public string? GeGender { get; set; }
        public decimal? GeFunctionTotal { get; set; }
        public string? BodyColGender { get; set; }
        public string? BasilarSuture { get; set; }
        public int? VentralArc { get; set; }
        public int? SubPubicAngle { get; set; }
        public int? SciaticNotch { get; set; }
        public int? PubicBone { get; set; }
        public int? PrearSulcus { get; set; }
        public int? MedialIpramus { get; set; }
        public int? DorsalPitting { get; set; }
        public int? ForemanMagnum { get; set; }
        public decimal? FemurHead { get; set; }
        public decimal? HumerusHead { get; set; }
        public string? Osteophytosis { get; set; }
        public int? PubicSymphysis { get; set; }
        public decimal? FemurLength { get; set; }
        public decimal? HumerusLength { get; set; }
        public decimal? TibiaLength { get; set; }
        public int? Robust { get; set; }
        public int? SupraOrbitalRidges { get; set; }
        public decimal? OrbitEdge { get; set; }
        public decimal? ParietalBossing { get; set; }
        public int? Gonian { get; set; }
        public int? NuchalCrest { get; set; }
        public int? ZygomaticCrest { get; set; }
        public string? CranialSuture { get; set; }
        public decimal? MaxCranialBreadth { get; set; }
        public decimal? MaxCranialLength { get; set; }
        public decimal? BasionBregmaHeight { get; set; }
        public decimal? BasionNasion { get; set; }
        public decimal? BasionProsthionLength { get; set; }
        public decimal? BizygomaticDiameter { get; set; }
        public decimal? NasionProsthion { get; set; }
        public decimal? MaxNasalBreadth { get; set; }
        public decimal? InterOrbitalBreadth { get; set; }
        public int? SkullYear { get; set; }
        public string? SkullMonth { get; set; }
        public int? SkullDay { get; set; }
        public string? FieldBook { get; set; }
        public string? FieldBookPage { get; set; }
        public string? DeexpertInitials { get; set; }
        public string? DecheckerInitials { get; set; }
        public bool? Byusample { get; set; }
        public int? BodyAnalysis { get; set; }
        public bool? SkullMagazine { get; set; }
        public bool? PostcraniaMagazine { get; set; }
        public string? RackShelf { get; set; }
        public bool? ToConfirm { get; set; }
        public bool? SkullTrauma { get; set; }
        public bool? PostcraniaTrauma { get; set; }
        public bool? CribraOrbitala { get; set; }
        public bool? PoroticHypertosis { get; set; }
        public string? PhLocation { get; set; }
        public bool? MetopicSuture { get; set; }
        public bool? ButtonOsteoma { get; set; }
        public string? OsteologyUnknown { get; set; }
        public bool? TmjOa { get; set; }
        public bool? LinearHypoplasiaEnamel { get; set; }
        public int? HillArea { get; set; }
        public int? TombNo { get; set; }
        public bool? SampleTaken { get; set; }
        public string? Goods { get; set; }
        public string? Cluster { get; set; }
        public string? FaceBundle { get; set; }
        public string? OsteologyNotes { get; set; }
        public bool? PhotoTaken { get; set; }
        public string? Shaft { get; set; }
        public string? SharedShaft { get; set; }
        public bool? BurialMaterials { get; set; }
        public string? ExcavationRecorder { get; set; }

    }
}
