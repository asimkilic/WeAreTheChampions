using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Enums;


namespace DataAccess.Concrete
{
    public class Match:IEntity
    {
        public int Id { get; set; }
        public DateTime MatchTime { get; set; }
        public byte? Score1 { get; set; }
        public byte? Score2 { get; set; }
        public ResultEnum? ResultId { get; set; }

        public int Team1Id { get; set; }
        public virtual Team Team1 { get; set; }
        public int Team2Id { get; set; }
        public virtual Team Team2 { get; set; }

     
    }
}
