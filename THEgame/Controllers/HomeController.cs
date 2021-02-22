using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using THEgame.Models;
using THEgame.ViewModels;
using System.Globalization;
namespace THEgame.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        #region Dependency
        public IDBase dBase { get; set; }        
        #endregion
        private UserContext db;
        public HomeController(UserContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            /*IndexModel model = new IndexModel();
            model.modelV = solutionV(model);
            model.modelA = solutionA(model);*/
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid );
            ViewData["Id"] = user.Id;           
            ViewData["Sex"] = user.Sex;
            ViewData["Race"] = user.Race;
            ViewData["RaceDis"] = user.RaceDis;
            IndexModel model = new IndexModel() { Id = user.Id, Sex = user.Sex, Race = user.Race, RaceDis = user.RaceDis };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IndexModel model)
        {
            model.Id = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            if (ModelState.IsValid)
            {
                UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == model.Id);
                if (user != null)
                {
                    // добавляем пользователя в бд
                    var entityuser = db.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                    entityuser.Sex = model.Sex;
                    entityuser.Race = model.Race;
                    entityuser.RaceDis = model.RaceDis;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Ошибка в данных");
            }
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
            return model.modelV = new SolutionVModel();
        }
    }
}
