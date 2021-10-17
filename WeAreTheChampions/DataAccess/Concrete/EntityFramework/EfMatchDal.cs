using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMatchDal : EfEntityRepositoryBase<Match, ChampionsContext>, IMatchDal
    {
        public List<Match> GetAllWithAssociatedProperties()
        {
            using (ChampionsContext context= new ChampionsContext())
            {
                return context.Matches.Include(x => x.AwayTeam).Include(x=>x.HomeTeam).ToList();
            }
        }
    }
}
