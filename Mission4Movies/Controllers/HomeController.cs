using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4Movies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext MovieEntryContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext NewMovieContext)
        {
            _logger = logger;
            MovieEntryContext = NewMovieContext;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(MovieEntry me)
        {
            //If all the restrictions specified in the model are met, then save it. Otherwise, display the unmet specification.
            if (ModelState.IsValid)
            {
                MovieEntryContext.Add(me);
                MovieEntryContext.SaveChanges();
                return View("MovieForm", me);
            }
            else
            {
                return View(me);
            }
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
