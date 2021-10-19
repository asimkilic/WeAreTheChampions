using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTeamColorDal : EfEntityRepositoryBase<TeamColor, ChampionsContext>, ITeamColorDal
    {

        public List<TeamColorDto> GetAllDetailsWithAssociatedProperties(Expression<Func<TeamColor, bool>> filter = null)
        {
            using (ChampionsContext context = new ChampionsContext())
            {
                return filter == null ? context.TeamColors.Include(x => x.Color).Include(x => x.Team)
                    .Select(x => new TeamColorDto
                    {

                        ColorId = x.ColorId,
                        ColorName = x.Color.ColorName,
                        TeamId = x.TeamId,
                        TeamName = x.Team.TeamName,
                        Red = x.Color.Red,
                        Green = x.Color.Green,
                        Blue = x.Color.Blue
                    }).ToList() : context.TeamColors.Include(x => x.Color).Include(x => x.Team).Where(filter)
                    .Select(x => new TeamColorDto
                    {
                        ColorId = x.ColorId,
                        ColorName = x.Color.ColorName,
                        TeamId = x.TeamId,
                        TeamName = x.Team.TeamName,
                        Red = x.Color.Red,
                        Green = x.Color.Green,
                        Blue = x.Color.Blue
                    }).ToList();

            }

        }
    }
}
