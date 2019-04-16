
using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStore
{
    public class GameStoreDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        private const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=GameStoreDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
