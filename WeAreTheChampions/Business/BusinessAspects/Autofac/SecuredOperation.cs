using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
       

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
         

        }
        // admin,match.admin,match.update
        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = new string[] {"admin","color.admin" }; //TODO: when user login take its claims 
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception("AuthorizationDenied");
        }
    }
}
