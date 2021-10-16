using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.EntityConfigutationsForEF
{
    public class UserOpetaionClaimConfiguration : EntityTypeConfiguration<UserOperationClaim>
    {
        public UserOpetaionClaimConfiguration()
        {
            // Primary Keys
            //  HasKey(x => new { x.UserId, x.OperationClaimId });
            HasRequired(x => x.OperationClaim).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.OperationClaimId);
            HasRequired(x => x.User).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.UserId);

        }
    }
}
