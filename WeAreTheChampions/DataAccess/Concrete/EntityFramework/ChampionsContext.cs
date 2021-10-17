using Core.Entities.Concrete;
using Core.Entities.Concrete.EntityConfigutationsForEF;
using DataAccess.Concrete.EntityFramework.EntityConfigurations;
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
        public ChampionsContext() : base("name=ChampionsContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new MatchConfiguration());
            modelBuilder.Configurations.Add(new ColorConfiguration());
            modelBuilder.Configurations.Add(new TeamColorConfiguration());

            modelBuilder.Configurations.Add(new OperationClaimConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserOperationClaimConfiguration());

        }
        public DbSet<TeamColor> TeamColors { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }


        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
