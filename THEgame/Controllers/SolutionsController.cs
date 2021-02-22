using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using THEgame.Models;
using THEgame.Models.Solutions;
//-----------------------
using THEgame.DeepLogic.Solutions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace THEgame.Controllers
{
    [Authorize]
    public class SolutionsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        #region Dependency
        public IDBase dBase { get; set; }
        public ISolutionDL soler { get; set; }
        #endregion
        private UserContext db;
        public SolutionsController(UserContext context)
        {
            db = context;
        }
        
        public async Task<IActionResult> Solution0Async(Solution0Model model)
        {
            model.Imodel =  new IndexModel();
            model.Imodel.modelA = new SolutionAModel();            

            soler = new SolutionDL();
            Dbase dba = soler.GetDBase();
            model.Imodel.modelA.BufferedString = dba.GetName();

            model.RandNumber = soler.GetInt(0, 100);

            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid);
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Solution1Async()
        {
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid);
            
            Solution1Model model = await db.Locations.FirstOrDefaultAsync(l => l.Id == 1);
            if (user != null)
            {
                var entityuser = db.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                entityuser.CurLocationId = model.Id;
                await db.SaveChangesAsync();
                var query = (from c in db.Users
                             where c.CurLocationId == 1
                             select c);
                ViewBag.Users = query.ToList();
                ViewData["UserLocation"] = "Solution" + user.CurLocationId;

                ViewData["Title"] = model.Name;
                return View(model);
            }
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            ViewData["Title"] = model.Name;            
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Solution2Async()
        {
            var cookieid = Int32.Parse(HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "UserId").Value);
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Id == cookieid);

            Solution1Model model = await db.Locations.FirstOrDefaultAsync(l => l.Id == 2);
            if (user != null)
            {
                var entityuser = db.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                entityuser.CurLocationId = model.Id;
                await db.SaveChangesAsync();
                var query = (from c in db.Users
                             where c.CurLocationId == 2
                             select c);
                ViewBag.Users = query.ToList();
                ViewData["UserLocation"] = "Solution" + user.CurLocationId;


                ViewData["Title"] = model.Name;
                return View(model);
            }
            ViewData["Title"] = model.Name;
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            return View(model);
        }
    }
}
