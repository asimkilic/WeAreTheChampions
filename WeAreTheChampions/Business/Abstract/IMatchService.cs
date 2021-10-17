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
   public interface IMatchService:IServiceBase<Match>,IEntityServiceBase<Match>
    {
        IDataResult<List<MatchesListDto>> GetAllWithAssociatedProperties();
        IDataResult<List<MatchesListDto>> GetAllWithAssociatedPropertiesWithoutPlayed();

    }
}
