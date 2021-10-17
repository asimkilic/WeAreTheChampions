using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IMatchService:IServiceBase<Match>,IEntityServiceBase<Match>
    {
        IDataResult<List<Match>> GetAllWithAssociatedProperties();
    }
}
