using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BirdHorseStats.Models;

namespace BirdHorseStats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Survival()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Survival(SurvivalModel survival)
        {
            if (ModelState.IsValid)
            {
                SurvivalSubmit.SaveSubmission(survival);
                return View("Summary", survival);
            }
            else
            {
                return View();
            }
        }

        public ViewResult RunTest()
        {
            //TODO: Train the model

            //TODO: Run the test

            //TODO: Set the results of the test

            // View the results
            return View(SurvivalSubmit.Submission);
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
