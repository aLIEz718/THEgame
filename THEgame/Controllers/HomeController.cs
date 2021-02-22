using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using THEgame.Models;

namespace THEgame.Controllers
{
    [Authorize]
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
            model.HeaderText = "Lamp Oil, Rope, Bombs You Want It It's Yours My Friend As Long As You Have Enough Rubies";
            
            ViewData["Title"] = "weedSoldiers";            
            return View(model);
        }

        public IActionResult IndexLeft(SolutionVModel model)
        {
            return PartialView(model);
        }
        public IActionResult IndexRight(SolutionAModel model)
        {
            return PartialView(model);
        }
        
        public IActionResult Rules()
        {
                return View();
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
            return model.modelV;
        }
    }
}
