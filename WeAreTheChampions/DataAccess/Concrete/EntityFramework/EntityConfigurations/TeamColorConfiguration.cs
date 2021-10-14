using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.EntityConfigurations
{
    public class TeamColorConfiguration : EntityTypeConfiguration<TeamColor>
    {
        public TeamColorConfiguration()
        {
            // Primary Keys
            HasKey(x => new { x.ColorId, x.TeamId });

            // Relationships
            HasRequired(x => x.Color).WithMany(x => x.TeamColors).HasForeignKey(x => x.ColorId);
            HasRequired(x => x.Team).WithMany(x => x.TeamColors).HasForeignKey(x => x.TeamId);
        }
    }
}
