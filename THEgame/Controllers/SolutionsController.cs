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

        public SolutionsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Solution0(Solution0Model model)
        {
            model.Imodel =  new IndexModel();
            model.Imodel.modelA = new SolutionAModel();            

            soler = new SolutionDL();
            Dbase db = soler.GetDBase();
            model.Imodel.modelA.BufferedString = db.GetName();

            model.RandNumber = soler.GetInt(0, 100);
            return View(model);
        }
    }
}
