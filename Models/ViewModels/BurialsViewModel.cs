using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Models.ViewModels
{
    public class BurialsViewModel
    {
        public List<Burial> Burials { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public BurialFilterModel BurialFilterModel { get; set; }
    }
}
