using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
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
        IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedProperties();
        IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedPropertiesByColorId(int colorId);
        IDataResult<List<TeamColorDto>> GetAllDetailsWithAssociatedPropertiesByTeamId(int teamId);
        IResult DeleteByColorIdTeamId(int colorId, int teamId);
        IResult DeleteByColorId(int colorId);

    }
}
