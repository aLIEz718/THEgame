using System;
using System.Collections.Generic;
using THEgame.Models;
using Microsoft.EntityFrameworkCore;

namespace THEgame
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}