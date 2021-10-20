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
    public class EfPlayerDal : EfEntityRepositoryBase<Player, ChampionsContext>, IPlayerDal
    {

        public List<Player> GetAllPlayersWithAssociatedProperties()
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                return context.Players.Include(x => x.Team).OrderBy(x => x.TeamId).ToList();
            }


        }

    }
}
