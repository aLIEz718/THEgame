﻿using System;
using System.Collections.Generic;
using THEgame.Models;
using THEgame.Models.Solutions;
using Microsoft.EntityFrameworkCore;
using THEgame.ViewModels;

namespace THEgame
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<Solution1Model> Locations { get; set; }
        public DbSet<ChatModel> Chat { get; set; }
        public DbSet<PartyModel> Party { get; set; }
        public DbSet<CharacterModel> Character { get; set; }
        
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}