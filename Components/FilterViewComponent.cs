using Microsoft.AspNetCore.Mvc;
using EgyptExcavation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private EgyptDbContext context;

        public FilterViewComponent(EgyptDbContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
