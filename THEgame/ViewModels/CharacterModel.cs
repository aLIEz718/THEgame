using System.ComponentModel.DataAnnotations;

namespace THEgame.ViewModels
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
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
