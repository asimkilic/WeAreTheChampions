using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TeamColor : IEntity
    {
        public int TeamId { get; set; }
        public int ColorId { get; set; }

        public virtual Color Color { get; set; }
        public virtual Team Team { get; set; }

       
    }
}
