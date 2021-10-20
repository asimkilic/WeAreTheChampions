using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.KLCCache
{
    public class KLCCacheManager
    {
        public static string NameSurname;
        // public static string[] Roles;
        public static void SetNameSurname(User user)
        {
            NameSurname = $"{user.FirstName} {user.LastName}, Hoşgeldiniz";
        }
    }
}
