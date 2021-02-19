using System;

namespace THEgame.Models
{
    public class Abase : IDBase
    {
        public string AName = "";
        public string GetName() {
            var a = AName;
            return a;
        }
        public string SetName(string param)
        {
            var a = AName = param;
            return a;
        }
    }

}
