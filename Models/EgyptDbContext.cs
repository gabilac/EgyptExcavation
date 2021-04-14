using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models
{
    public class EgyptDbContext : DbContext
    {
        public EgyptDbContext()
        {
        }

        public EgyptDbContext(DbContextOptions<EgyptDbContext> options) : base(options)
        {
        }

        public virtual DbSet<BioSample> BioSamples { get; set; }
        public virtual DbSet<Burial> Burials { get; set; }
        public virtual DbSet<Sample> Samples { get; set; }
        public virtual DbSet<Square> Squares { get; set; }
        public virtual DbSet<Textile> Textiles { get; set; }
    }
}
