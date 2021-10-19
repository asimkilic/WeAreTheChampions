using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();

            builder.RegisterType<PlayerManager>().As<IPlayerService>().SingleInstance();
            builder.RegisterType<EfPlayerDal>().As<IPlayerDal>().SingleInstance();

            builder.RegisterType<MatchManager>().As<IMatchService>().SingleInstance();
            builder.RegisterType<EfMatchDal>().As<IMatchDal>().SingleInstance();

            builder.RegisterType<TeamColorManager>().As<ITeamColorService>().SingleInstance();
            builder.RegisterType<EfTeamColorDal>().As<ITeamColorDal>().SingleInstance();

            builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            builder.RegisterType<EfTeamDal>().As<ITeamDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            int concreteSuffixCount = "Manager".Length; // 7  we need to know suffix such as 'Manager' in 'ColorManager' thus we can get the exact name of class to find its service interface
            int abstactSuffixCount = "Service".Length; //7   we need to know suffix such as 'Service' in 'IColorService' thus we can get the exact name of interface to find its manager class
           

            //REF : https://www.youtube.com/watch?v=mCUNrRtVVWY
            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Business)))
            //  .Where(x => x.Namespace.Contains("Concrete") || x.Namespace.Contains("Abstract")) //we got  interfaces from concrete and abstract folders 
            //  .As(x => x.GetInterfaces().FirstOrDefault(i => i.Name.Substring(0, (i.Name.Length - abstactSuffixCount)) == "I" + x.Name.Substring(0, (x.Name.Length - concreteSuffixCount))));
          // We discard the 'Service' part at the end of the name, we have the 'IColor' part, and if we put I at the beginning of the classes and delete the Manager part at the end, we get it if it matches


           // REF : https://github.com/engindemirog/NetCoreBackend/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs
           // For all classes we run here first and check if they have Aspects 
           var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()  // Get the interfaces which are implemented 
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()  // Call AspectInterceptorSelector for them
                }).SingleInstance();

        }
    }
}
