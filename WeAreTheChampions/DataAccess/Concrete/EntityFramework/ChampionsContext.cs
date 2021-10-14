using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ChampionsContext : DbContext
    {
        public ChampionsContext():base("name=ChampionsContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // #TeamColor
           // modelBuilder.Entity<TeamColor>().HasIndex(t => new { t.TeamId, t.ColorId }).IsUnique();
           
            // #Match
            //modelBuilder.Entity<Match>().Property(m => m.HomeTeam).IsRequired();
            //modelBuilder.Entity<Match>().Property(m => m.Team2Id).IsRequired();
          
            modelBuilder.Entity<Match>().Property(m => m.MatchTime).IsRequired();

            // #Color
            modelBuilder.Entity<Color>().HasIndex(c => new { c.Blue, c.Red, c.Green }).IsUnique();
            //200 200 200
            //200 200 201
            //200 200 200
        }
        public DbSet<TeamColor> TeamColors { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
       // public DbSet<TeamColor> TeamColors { get; set; }
    }
}
