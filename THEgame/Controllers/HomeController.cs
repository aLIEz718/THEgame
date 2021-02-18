using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using THEgame.Models;

namespace THEgame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(IndexModel model)
        {
            model = solutionV(model);
            model.HeaderText = "MOTHER OF GOOOOOOOOOOD";
            ViewData["Title"] = "weedSoldiers";            
            return View(model);
        }

        public IActionResult SolutionV(SolutionVModel model)
        {
            return PartialView(model);
        }
        public IActionResult SolutionA(SolutionAModel model)
        {
            return PartialView(model);
        }
        public IActionResult Rules()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IndexModel solutionA(IndexModel model)
        {
            var a = 30;
            return model;
        }
        public IndexModel solutionV(IndexModel model)
        {           
            return model;
        }
    }
}
