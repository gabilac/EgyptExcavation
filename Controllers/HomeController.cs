using EgyptExcavation.Models;
using EgyptExcavation.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EgyptExcavation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EgyptDbContext context;

        public HomeController(ILogger<HomeController> logger, EgyptDbContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public int pageSize = 8;

        // Controller methods for navbar links
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Burials(int pageNum = 1)
        {
            // declare and instantiate BurialsViewModel
            BurialsViewModel viewmodel = new BurialsViewModel
            {
                Burials = context.Burials
                    .OrderBy(b => b.YearFound)
                    .Skip((pageNum -1) * pageSize)
                    .Take(pageSize)
                    .ToList(),

                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = (
                    context.Burials.Count())
                }
            };
            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult Burials(BurialFilterModel filtermodel, int pageNum = 1)
        {
            // declare and instantiate filterlogic 
            var filterLogic = new BurialFilterLogic();

            // apply filterlogic to filtermodel to get filtered burials
            var filteredBurials = filterLogic.GetBurials(filtermodel).ToList();

            // declare and instantiate BurialsViewModel
            BurialsViewModel viewmodel = new BurialsViewModel
            {
                Burials = filteredBurials
                    .OrderBy(b => b.YearFound)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(),

                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = (
                    filteredBurials.Count())
                },

                BurialFilterModel = new BurialFilterModel { }
            };

            return View(viewmodel);
        }


        public IActionResult BurialRecord(int burialid = 3)
        {
            var targetBurial = context.Burials.Where(b => b.BurialKey == burialid).SingleOrDefault();
            var targetSquare = context.Squares.Where(s => s.SquareId == targetBurial.SquareId).SingleOrDefault();
            var targetSamples = context.Samples.Where(s => s.BurialKey == targetBurial.BurialKey).ToList();

            BurialViewModel viewmodel = new BurialViewModel
            {
                Burial = targetBurial,

                Square = targetSquare,

                Samples = targetSamples
            };

            return View(viewmodel);
        }

        public IActionResult TextileRecord(int textileid = 3)
        {
            var targetTextile = context.Textiles.Where(t => t.SampleId == textileid).SingleOrDefault();

            return View(targetTextile);
        }



        //  CODE KEYS
        //-------------------------------------
        public IActionResult Legend()
        {
            return View();
        }



        //  RECORD CREATION (Gets)
        //-------------------------------------

        [HttpGet]
        public IActionResult CreateBurial()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateSample()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTextile()
        {
            return View();
        }


        //  RECORD CREATION (Posts)
        //-------------------------------------

        [HttpPost]
        public IActionResult CreateBurial(Burial burial)
        {
            context.Burials.Add(burial);
            context.SaveChanges();
            return View("Burials");
        }

        [HttpPost]
        public IActionResult CreateSample(Sample sample)
        {
            context.Samples.Add(sample);
            context.SaveChanges();
            return View("Burials");
        }

        [HttpPost]
        public IActionResult CreateTextile(Textile textile)
        {
            context.Textiles.Add(textile);
            context.SaveChanges();
            return View("Burials");
        }

        public IActionResult DeleteBurialRecord(int BurialId)
        {
            Burial selectedBurial = context.Burials.Where(b => b.BurialKey == BurialId).FirstOrDefault();

            context.Remove(selectedBurial);
            context.SaveChanges();

            return View("Burials");
        }


        //  UPLOADS (get)
        //-------------------------------------
        [HttpGet]
        public IActionResult UploadPhotos()
        {
            return View(context.Burials.Select(b => b.BurialKey).ToList());
        }

        [HttpGet]
        public IActionResult UploadFieldNotes()
        {
            return View(context.Burials.Select(b => b.BurialKey));
        }

        [HttpGet]
        public IActionResult UploadBoneBooks()
        {
            return View(context.Burials.Select(b => b.BurialKey));
        }



        //  UPLOADS (post)
        //-------------------------------------
        [HttpPost]
        public IActionResult UploadPhotos(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFieldNotes(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadBoneBooks(int id)
        {
            return View();
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
