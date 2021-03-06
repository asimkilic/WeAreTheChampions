using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlayerService : IServiceBase<Player>, IEntityServiceBase<Player>
    {
        IDataResult<List<Player>> GetPlayersByTeamId(int teamId);
        IDataResult<List<Player>> GetAllPlayersWithAssociatedProperties();
    }
}
