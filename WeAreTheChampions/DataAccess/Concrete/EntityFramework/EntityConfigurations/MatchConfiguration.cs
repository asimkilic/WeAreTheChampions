using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.EntityConfigurations
{
    public class MatchConfiguration : EntityTypeConfiguration<Match>
    {
        public MatchConfiguration()
        {
            Property(x => x.MatchTime).IsRequired();
            HasRequired(x => x.HomeTeam).WithMany(x => x.HomeMatches).HasForeignKey(x => x.HomeTeamId).WillCascadeOnDelete(false);
            HasRequired(x => x.AwayTeam).WithMany(x => x.AwayMatches).HasForeignKey(x => x.AwayTeamId).WillCascadeOnDelete(false);

        }
    }
}