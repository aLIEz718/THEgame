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
            if (HttpContext.Request.Cookies.ContainsKey("logchecky")) { 
            model.modelV = solutionV(model);
            model.modelA = solutionA(model);
            model.HeaderText = "Lamp Oil, Rope, Bombs You Want It It's Yours My Friend As Long As You Have Enough Rubies";
            
            ViewData["Title"] = "weedSoldiers";            
            return View(model);
            }
            return Redirect("/Account/Login");
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
            if (HttpContext.Request.Cookies.ContainsKey("logchecky"))
            {
                return View();
            }
            return Redirect("/Account/Login");
        }
        public IActionResult Admin(AdminModel model)
        {
            if (HttpContext.Request.Cookies.ContainsKey("logchecky"))
            {
                return View(model);
            }
            return Redirect("/Account/Login");
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
