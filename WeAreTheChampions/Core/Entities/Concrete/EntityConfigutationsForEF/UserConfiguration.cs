using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.EntityConfigutationsForEF
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.PasswordHash).IsRequired();
            Property(x => x.PasswordSalt).IsRequired();
            Property(x => x.Status).IsRequired();
        }
    }
}
