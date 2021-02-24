﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace THEgame.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public string RaceDis { get; set; }
        public int CurLocationId { get; set; }
        public int CharLevel { get; set; }
    }
}
