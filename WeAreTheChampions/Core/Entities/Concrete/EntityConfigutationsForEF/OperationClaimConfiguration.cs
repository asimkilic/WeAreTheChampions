using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.EntityConfigutationsForEF
{
    public class OperationClaimConfiguration : EntityTypeConfiguration<OperationClaim>
    {
        public OperationClaimConfiguration()
        {
            Property(x => x.Name).IsRequired();

        }
    }
}
