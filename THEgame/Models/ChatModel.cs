using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace THEgame.Models
{
    public class ChatModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LocId { get; set; }
        public string Message { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserName { get; set; }
    }
}
