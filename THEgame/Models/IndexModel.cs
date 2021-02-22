using System;

namespace THEgame.Models
{
    public class IndexModel
    {
        public string HeaderText { get; set; }
        public SolutionAModel modelA { get; set; }
        public SolutionVModel modelV { get; set; }
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string RaceDis { get; set; }
    }
}
