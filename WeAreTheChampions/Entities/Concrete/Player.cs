using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }


    }
}
