using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EgyptExcavation.Migrations
{
    public partial class Go : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BioSamples",
                columns: table => new
                {
                    BioSampleId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PreviouslySampled = table.Column<bool>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Bag = table.Column<int>(nullable: true),
                    ResearcherInitials = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    SampleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BioSamples", x => x.BioSampleId);
                });

            migrationBuilder.CreateTable(
                name: "Burials",
                columns: table => new
                {
                    BurialKey = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BurialCompositeId = table.Column<string>(nullable: true),
                    BurialNo = table.Column<string>(nullable: true),
                    SquareId = table.Column<int>(nullable: true),
                    Quadrant = table.Column<string>(nullable: true),
                    BurialType = table.Column<string>(nullable: true),
                    WtoHead = table.Column<int>(nullable: true),
                    WtoFeet = table.Column<int>(nullable: true),
                    StoHead = table.Column<int>(nullable: true),
                    StoFeet = table.Column<int>(nullable: true),
                    YearExcavated = table.Column<int>(nullable: true),
                    MonthExcavated = table.Column<string>(nullable: true),
                    DayExcavated = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    LengthofRemains = table.Column<decimal>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    SampleNo = table.Column<int>(nullable: true),
                    PreservationIndex = table.Column<int>(nullable: true),
                    PreservationNotes = table.Column<string>(nullable: true),
                    Depth = table.Column<decimal>(nullable: true),
                    HairColor = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    SexMethod = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    AgeMethod = table.Column<string>(nullable: true),
                    AgeCategory = table.Column<string>(nullable: true),
                    HeadDirection = table.Column<string>(nullable: true),
                    BurialWrapping = table.Column<string>(nullable: true),
                    HairTaken = table.Column<bool>(nullable: true),
                    SoftTissueTaken = table.Column<bool>(nullable: true),
                    BoneTaken = table.Column<bool>(nullable: true),
                    ToothTaken = table.Column<bool>(nullable: true),
                    TextileTaken = table.Column<bool>(nullable: true),
                    SampleDesc = table.Column<string>(nullable: true),
                    ArtifactFound = table.Column<bool>(nullable: true),
                    ArtifactDesc = table.Column<string>(nullable: true),
                    EstimatedAge = table.Column<decimal>(nullable: true),
                    EstimatedHeight = table.Column<decimal>(nullable: true),
                    ToothAttrition = table.Column<int>(nullable: true),
                    ToothEruption = table.Column<string>(nullable: true),
                    PathologyAnomolies = table.Column<string>(nullable: true),
                    EpiphysealUnion = table.Column<string>(nullable: true),
                    YearFound = table.Column<int>(nullable: true),
                    MonthFound = table.Column<string>(nullable: true),
                    DayFound = table.Column<int>(nullable: true),
                    GeGender = table.Column<string>(nullable: true),
                    GeFunctionTotal = table.Column<decimal>(nullable: true),
                    BodyColGender = table.Column<string>(nullable: true),
                    BasilarSuture = table.Column<string>(nullable: true),
                    VentralArc = table.Column<int>(nullable: true),
                    SubPubicAngle = table.Column<int>(nullable: true),
                    SciaticNotch = table.Column<int>(nullable: true),
                    PubicBone = table.Column<int>(nullable: true),
                    PrearSulcus = table.Column<int>(nullable: true),
                    MedialIpramus = table.Column<int>(nullable: true),
                    DorsalPitting = table.Column<int>(nullable: true),
                    ForemanMagnum = table.Column<int>(nullable: true),
                    FemurHead = table.Column<decimal>(nullable: true),
                    HumerusHead = table.Column<decimal>(nullable: true),
                    Osteophytosis = table.Column<string>(nullable: true),
                    PubicSymphysis = table.Column<int>(nullable: true),
                    FemurLength = table.Column<decimal>(nullable: true),
                    HumerusLength = table.Column<decimal>(nullable: true),
                    TibiaLength = table.Column<decimal>(nullable: true),
                    Robust = table.Column<int>(nullable: true),
                    SupraOrbitalRidges = table.Column<int>(nullable: true),
                    OrbitEdge = table.Column<decimal>(nullable: true),
                    ParietalBossing = table.Column<decimal>(nullable: true),
                    Gonian = table.Column<int>(nullable: true),
                    NuchalCrest = table.Column<int>(nullable: true),
                    ZygomaticCrest = table.Column<int>(nullable: true),
                    CranialSuture = table.Column<string>(nullable: true),
                    MaxCranialBreadth = table.Column<decimal>(nullable: true),
                    MaxCranialLength = table.Column<decimal>(nullable: true),
                    BasionBregmaHeight = table.Column<decimal>(nullable: true),
                    BasionNasion = table.Column<decimal>(nullable: true),
                    BasionProsthionLength = table.Column<decimal>(nullable: true),
                    BizygomaticDiameter = table.Column<decimal>(nullable: true),
                    NasionProsthion = table.Column<decimal>(nullable: true),
                    MaxNasalBreadth = table.Column<decimal>(nullable: true),
                    InterOrbitalBreadth = table.Column<decimal>(nullable: true),
                    SkullYear = table.Column<int>(nullable: true),
                    SkullMonth = table.Column<string>(nullable: true),
                    SkullDay = table.Column<int>(nullable: true),
                    FieldBook = table.Column<string>(nullable: true),
                    FieldBookPage = table.Column<string>(nullable: true),
                    DeexpertInitials = table.Column<string>(nullable: true),
                    DecheckerInitials = table.Column<string>(nullable: true),
                    Byusample = table.Column<bool>(nullable: true),
                    BodyAnalysis = table.Column<int>(nullable: true),
                    SkullMagazine = table.Column<bool>(nullable: true),
                    PostcraniaMagazine = table.Column<bool>(nullable: true),
                    RackShelf = table.Column<string>(nullable: true),
                    ToConfirm = table.Column<bool>(nullable: true),
                    SkullTrauma = table.Column<bool>(nullable: true),
                    PostcraniaTrauma = table.Column<bool>(nullable: true),
                    CribraOrbitala = table.Column<bool>(nullable: true),
                    PoroticHypertosis = table.Column<bool>(nullable: true),
                    PhLocation = table.Column<string>(nullable: true),
                    MetopicSuture = table.Column<bool>(nullable: true),
                    ButtonOsteoma = table.Column<bool>(nullable: true),
                    OsteologyUnknown = table.Column<string>(nullable: true),
                    TmjOa = table.Column<bool>(nullable: true),
                    LinearHypoplasiaEnamel = table.Column<bool>(nullable: true),
                    HillArea = table.Column<int>(nullable: true),
                    TombNo = table.Column<int>(nullable: true),
                    SampleTaken = table.Column<bool>(nullable: true),
                    Goods = table.Column<string>(nullable: true),
                    Cluster = table.Column<string>(nullable: true),
                    FaceBundle = table.Column<string>(nullable: true),
                    OsteologyNotes = table.Column<string>(nullable: true),
                    PhotoTaken = table.Column<bool>(nullable: true),
                    Shaft = table.Column<string>(nullable: true),
                    SharedShaft = table.Column<string>(nullable: true),
                    BurialMaterials = table.Column<bool>(nullable: true),
                    ExcavationRecorder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burials", x => x.BurialKey);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    SampleId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BioSampleId = table.Column<int>(nullable: true),
                    TextileId = table.Column<int>(nullable: true),
                    BurialKey = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: true),
                    Size = table.Column<int>(nullable: true),
                    Foci = table.Column<int>(nullable: true),
                    C14sample = table.Column<int>(nullable: true),
                    Rack = table.Column<int>(nullable: true),
                    TubeNo = table.Column<int>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    LocationDesc = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ConventionalAgeBp = table.Column<int>(nullable: true),
                    CalendarDate14C = table.Column<int>(nullable: true),
                    MinCalibratedCalendarDate = table.Column<int>(nullable: true),
                    MaxCalibratedCalendarDate = table.Column<int>(nullable: true),
                    AvgCalibratedCalendarDate = table.Column<string>(nullable: true),
                    SpanCalibratedCalendarDate = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.SampleId);
                });

            migrationBuilder.CreateTable(
                name: "Squares",
                columns: table => new
                {
                    SquareId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NsDistance = table.Column<int>(nullable: true),
                    Ns = table.Column<string>(nullable: true),
                    EwDistance = table.Column<int>(nullable: true),
                    Ew = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squares", x => x.SquareId);
                });

            migrationBuilder.CreateTable(
                name: "Textiles",
                columns: table => new
                {
                    TextileId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SampleId = table.Column<int>(nullable: true),
                    OriginEstimate = table.Column<string>(nullable: true),
                    PhotoDate = table.Column<string>(nullable: true),
                    SampledDate = table.Column<string>(nullable: true),
                    ScientificDate = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AnalysisDate = table.Column<string>(nullable: true),
                    AnalysisType = table.Column<string>(nullable: true),
                    Analyst = table.Column<string>(nullable: true),
                    Structure = table.Column<string>(nullable: true),
                    Dimension = table.Column<string>(nullable: true),
                    Function = table.Column<string>(nullable: true),
                    Decoration = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Component = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    Manipulation = table.Column<string>(nullable: true),
                    Ply = table.Column<string>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    Angle = table.Column<string>(nullable: true),
                    Count = table.Column<string>(nullable: true),
                    Thickness = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Copy = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textiles", x => x.TextileId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BioSamples");

            migrationBuilder.DropTable(
                name: "Burials");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Squares");

            migrationBuilder.DropTable(
                name: "Textiles");
        }
    }
}
