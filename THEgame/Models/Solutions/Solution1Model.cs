using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace THEgame.Models.Solutions
{
    public class Solution1Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Temp { get; set; }
    }
}
