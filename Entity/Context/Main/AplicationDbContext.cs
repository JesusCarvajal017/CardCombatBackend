using Entity.Model.Card;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Context.Main
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Player> Player { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<MazoPlayer> MazoPlayer { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Move> Move { get; set; }
        public DbSet<Round> Round { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}