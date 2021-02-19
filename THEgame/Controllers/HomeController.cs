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
        #region Dependency
        public IDBase dBase { get; set; }
        #endregion

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(IndexModel model)
        {

            model.modelV = solutionV(model);
            model.modelA = solutionA(model);
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
        public IActionResult Admin(AdminModel model)
        {
            return View(model);
        }
        public SolutionAModel solutionA(IndexModel model)
        {
            model.modelA = new SolutionAModel();
            dBase = new Dbase();
            dBase.SetName("Вован");           
            model.modelA.BufferedString = dBase.GetName();
            return model.modelA;            
        }
        public SolutionVModel solutionV(IndexModel model)
        {
            model.modelV = new SolutionVModel();
            model.modelV.numbers = new List<int>() { 36, 11, 20 };
            model.modelV.a = 0;            
            model.modelV.c = 0;
            for (int i = 0; i < 3; i++) {
                if (model.modelV.numbers[i] > model.modelV.a)
                {
                    model.modelV.a = model.modelV.numbers[i];
                }
            }
            model.modelV.b = model.modelV.a;
            for (int i = 0; i < 3; i++)
            {
                if (model.modelV.numbers[i] < model.modelV.b)
                {
                    model.modelV.b = model.modelV.numbers[i];
                }
            }
            model.modelV.c = model.modelV.a - model.modelV.b;
            return model.modelV;
        }
    }
}
