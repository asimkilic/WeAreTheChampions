using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMatchDal : EfEntityRepositoryBase<Match, ChampionsContext>, IMatchDal
    {
        public List<MatchesListDto> GetAllWithAssociatedProperties(Expression<Func<Match, bool>> filter = null)
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                return filter == null ? context.Matches.Include(x => x.AwayTeam).Include(x => x.HomeTeam)
                     .Select(x => new MatchesListDto
                     {
                         MatchId = x.Id,
                         AwayTeam = x.AwayTeam.TeamName,
                         HomeTeam = x.HomeTeam.TeamName,
                         MatchTime = x.MatchTime,
                         ScoreHome = x.Score1,
                         ScoreAway = x.Score2
                     }).ToList() : context.Matches.Include(x => x.AwayTeam).Include(x => x.HomeTeam).Where(filter)
                     .Select(x => new MatchesListDto
                     {
                         MatchId = x.Id,
                         AwayTeam = x.AwayTeam.TeamName,
                         HomeTeam = x.HomeTeam.TeamName,
                         MatchTime = x.MatchTime,
                         ScoreHome = x.Score1,
                         ScoreAway = x.Score2
                     }).ToList();
            }
        }


    }
}
