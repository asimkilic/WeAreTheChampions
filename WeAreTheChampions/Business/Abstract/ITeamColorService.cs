using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamColorService : IServiceBase<TeamColor>
    {
        IDataResult<List<TeamColor>> GetByTeamId(int teamId);
        IDataResult<List<TeamColor>> GetByColorId(int colorId);


    }
}
