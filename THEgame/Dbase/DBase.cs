using System;

namespace THEgame.Models
{
    public class Dbase : IDBase
    {
        public string AdminName = "";
        public string GetName() {
            var a = AdminName;
            return a;
        }
        public string SetName(string param)
        {
            var a = AdminName = param;
            return a;
        }
    }

}
