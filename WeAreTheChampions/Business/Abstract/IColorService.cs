using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService : IServiceBase<Color>, IEntityServiceBase<Color>
    {
        IResult AddTransactionalTest(Color color);
      
    }
}
