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
    public interface ISolutionDL
    {
        public int GetInt(int start, int end);
        public Dbase GetDBase();
    }
}
