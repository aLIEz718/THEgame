using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using THEgame.Models;

namespace THEgame.DeepLogic.Solutions
{
    public class SolutionDL : ISolutionDL
    {
        public IDBase dBase = new Dbase();
        public SolutionDL() {
            dBase.SetName("Андрюха");
        }
        public Dbase GetDBase() {
            return (Dbase)dBase;
        }
        public int GetInt(int start, int end) 
        {
            Random rnd = new Random();
            return rnd.Next(start, end);
        }
    }
}
