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
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid );
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            var entitychar = db.Character.Where(u => u.UserId == user.Id).FirstOrDefault();
            IndexModel model = new IndexModel() { Id = user.Id, Sex = user.Sex, Race = user.Race, RaceDis = user.RaceDis, TotalPoints = 8 + user.CharLevel };
            if(entitychar != null)
            {
                model.Glory = entitychar.Glory;
                model.Power = entitychar.Power;
                model.Knowledge = entitychar.Knowledge;
                model.Authority = entitychar.Authority;
                model.Rich = entitychar.Rich;
                model.Destruction = entitychar.Destruction;
                model.ChildOfNature = entitychar.ChildOfNature;
                model.Craft = entitychar.Craft;
                model.Humanism = entitychar.Humanism;
                model.TotalPoints = entitychar.TotalPoints;
            }
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
                if (user == null)
                {
                    var entityuser = db.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                    entityuser.Sex = model.Sex;
                    entityuser.Race = model.Race;
                    entityuser.RaceDis = model.RaceDis;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                CharacterModel charatcer = await db.Character.FirstOrDefaultAsync(u => u.UserId == model.Id);
                if (charatcer == null) {
                    var entitychar = new CharacterModel();
                    entitychar.Glory = model.Glory;
                    entitychar.Power = model.Power;
                    entitychar.Knowledge = model.Knowledge;
                    entitychar.Authority = model.Authority;
                    entitychar.Rich = model.Rich;
                    entitychar.Destruction = model.Destruction;
                    entitychar.ChildOfNature = model.ChildOfNature;
                    entitychar.Craft = model.Craft;
                    entitychar.Humanism = model.Humanism;
                    entitychar.TotalPoints = model.TotalPoints;
                    db.Character.Add(entitychar);
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                if (charatcer != null)
                {
                    var entitychar = db.Character.Where(u => u.UserId == user.Id).FirstOrDefault();
                    entitychar.Glory = model.Glory;
                    entitychar.Power = model.Power;
                    entitychar.Knowledge = model.Knowledge;
                    entitychar.Authority = model.Authority;
                    entitychar.Rich = model.Rich;
                    entitychar.Destruction = model.Destruction;
                    entitychar.ChildOfNature = model.ChildOfNature;
                    entitychar.Craft = model.Craft;
                    entitychar.Humanism = model.Humanism;
                    entitychar.TotalPoints = model.TotalPoints;
                    await db.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                model.TotalPoints = 8 + user.CharLevel;
                    model.Sex = user.Sex;
                    model.Race = user.Race;
                    model.RaceDis = user.RaceDis;
                    return View(model);
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
        
        public async Task<IActionResult> RulesAsync()
        {
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid);
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            return View();
        }
        
        public async Task<IActionResult> AdminAsync(AdminModel model)
        {
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid);
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
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
