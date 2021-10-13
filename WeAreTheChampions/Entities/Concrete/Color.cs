using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   public class Color:IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}
