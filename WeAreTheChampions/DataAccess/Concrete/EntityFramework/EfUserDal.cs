using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ChampionsContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ChampionsContext())
            {
                return context.Users
                    .Where(x => x.Id == user.Id)
                    .FirstOrDefault()
                    .UserOperationClaims
                    .Select(x => x.OperationClaim)
                    .ToList();

            }
        }
    }
}
