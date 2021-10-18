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
        /// <summary>
        /// Returns All Matches with associated properties using MathesListDto. (Filter can use on query)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns only one match with all associated navigation properties
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public Match GetWithHomeAwayDetailsByFilter(Expression<Func<Match, bool>> filter)
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                return context.Matches.Include(x => x.AwayTeam).Include(x => x.HomeTeam).Where(filter).FirstOrDefault();
            }
        }


    }
}
