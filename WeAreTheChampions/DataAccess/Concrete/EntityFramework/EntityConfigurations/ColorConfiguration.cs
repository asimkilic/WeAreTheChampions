using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.EntityConfigurations
{
    public class ColorConfiguration : EntityTypeConfiguration<Color>
    {
        public ColorConfiguration()
        {
            Property(x => x.Blue).IsRequired();
            Property(x => x.Green).IsRequired();
            Property(x => x.Red).IsRequired();
            HasIndex(x => new { x.Red, x.Green, x.Blue }).IsUnique();
           

        }
    }
}
