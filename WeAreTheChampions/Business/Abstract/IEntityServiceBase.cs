using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEntityServiceBase<T>
    {
        IResult DeleteById(int entityId);
        IDataResult<T> GetById(int entityId);

    }
}
