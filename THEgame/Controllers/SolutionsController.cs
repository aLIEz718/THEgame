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
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace THEgame.Controllers
{
    [Authorize]
    public class SolutionsController : Controller
    {
        #region Dependency
        public IDBase dBase { get; set; }
        public ISolutionDL soler { get; set; }
        #endregion
        private UserContext db;
        public SolutionsController(UserContext context)
        {
            db = context;
        }
        public async Task<IActionResult> SolutionAsync()
        { 
            return View();             
        }
            public async Task<IActionResult> Solution0Async(Solution0Model model)
        {
            model.Imodel = new IndexModel();
            model.Imodel.modelA = new SolutionAModel();

            soler = new SolutionDL();
            Dbase dba = soler.GetDBase();
            model.Imodel.modelA.BufferedString = dba.GetName();

            model.RandNumber = soler.GetInt(0, 100);

            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Name == User.Identity.Name);
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            return View(model);
        }
        public async Task<ViewResult> LocationDbChangesAsync(int number) {
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Name == User.Identity.Name);

            Solution1Model model = await db.Locations.FirstOrDefaultAsync(l => l.Id == number);
            if (user != null)
            {
                var entityuser = db.Users.Where(u => u.Id == user.Id).FirstOrDefault();
                entityuser.CurLocationId = model.Id;
                entityuser.SpeedPenalty = 10;
                await db.SaveChangesAsync();
                var query = (from c in db.Users
                             where c.CurLocationId == number
                             select c);
                ViewBag.Users = query.ToList();
                ViewData["UserLocation"] = "Solution" + user.CurLocationId;

                var chatquery = (from c in db.Chat
                                 where c.LocId == user.CurLocationId
                                 select c);
                ViewBag.Chat = chatquery.ToList();
                ViewData["LocationType"] = model.Type;
                ViewData["Title"] = model.Name;
                model.Name = "";
                model.Temp = model.Temp < 0 ? user.SpeedPenalty - (model.Temp / 100) * 2 * user.SpeedPenalty : user.SpeedPenalty + (model.Temp / 100) * 2 * user.SpeedPenalty;
                return View(model);
            }
            ViewData["UserLocation"] = "Solution" + user.CurLocationId;
            ViewData["LocationType"] = model.Type;
            ViewData["Title"] = model.Name;
            model.Name = "";
            model.Temp = model.Temp < 0 ? user.SpeedPenalty - (model.Temp/100)* 2 * user.SpeedPenalty : user.SpeedPenalty + (model.Temp / 100) * 2 * user.SpeedPenalty;
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Solution1Async()
        {
            await LocationDbChangesAsync(1);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Solution2Async()
        {
            await LocationDbChangesAsync(2);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Solution3Async()
        {
            await LocationDbChangesAsync(3);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Solution4Async()
        {
            await LocationDbChangesAsync(4);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Solution5Async()
        {
            await LocationDbChangesAsync(5);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Solution1Model model)
        {
            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Name == User.Identity.Name);
            if (user != null)
            {
                var message = model.Name;
                if(model.Name != null) { 
                db.Chat.Add(new ChatModel() { LocId = user.CurLocationId, Message = message.ToString(), CreatorId = user.Id, CreateDate = DateTime.Now, UserName = user.Name});
                    await db.SaveChangesAsync();

                    return RedirectToAction("Solution" + user.CurLocationId, "Solutions", model);
                }
                return RedirectToAction("Solution" + user.CurLocationId, "Solutions", model);
            }
            return RedirectToAction("Solution" + user.CurLocationId, "Solutions", model);
        }
        [HttpPost]
        public async Task<IActionResult> PartyRequest(int requestuserid)
        {

            UserModel user = await db.Users.FirstOrDefaultAsync(u => u.Name == User.Identity.Name);
            PartyModel party = await db.Party.FirstOrDefaultAsync(u => u.Id == user.PartyId);
            if (requestuserid == user.Id)
            {
                return Content(JsonConvert.SerializeObject(party));
            }
            if (user != null)
            {
                if (party == null)
                {
                    var entityparty = new PartyModel();
                    entityparty.UserId0 = user.Id;
                    entityparty.UserId1 = requestuserid;
                    user.PartyId = entityparty.Id;
                    db.Party.Add(entityparty);
                    await db.SaveChangesAsync();
                    return Content(JsonConvert.SerializeObject(entityparty));
                }
                else if (party.UserId2 != 0)
                {
                    party.UserId3 = requestuserid;
                }
                else
                {
                    party.UserId2 = requestuserid;
                }
                user.PartyId = party.Id;
                await db.SaveChangesAsync();
            }
            return Content(JsonConvert.SerializeObject(party));
        }
    }
}
