using System;

namespace THEgame.Models
{
    public class Vbase : IDBase
    {
        public string VName = "";
        public const int count = 40;
        public int GetCount() {
            return count;
        }
        public string GetName() {
            var a = VName;
            return a;
        }
        public string SetName(string param)
        {
            var a = VName = param;
            return a;
        }
    }

}
