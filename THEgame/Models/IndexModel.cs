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
        public int Glory { get; set; }
        public int Knowledge { get; set; }
        public int Power { get; set; }
        public int Rich { get; set; }
        public int Craft { get; set; }
        public int Humanism { get; set; }
        public int Authority { get; set; }
        public int Destruction { get; set; }
        public int ChildOfNature { get; set; }
        public int TotalPoints { get; set; }
    }
}
