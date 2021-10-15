using Autofac;
using Business.Abstract;
using Business.Concrete;
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

            //int concreteSuffixCount = "Manager".Length; // 7
            //int abstactSuffixCount = "Service".Length; //7

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Business)))
            //  .Where(x => x.Namespace.Contains("Concrete") || x.Namespace.Contains("Abstract")) //concrete ve abstract içindeki interface ve classları aldık
            //  .As(x => x.GetInterfaces().FirstOrDefault(i => i.Name.Substring(0, (i.Name.Length - abstactSuffixCount)) == "I" + x.Name.Substring(0, (x.Name.Length - concreteSuffixCount)))); 
            //// adının sonundaki Service kısmını atıyoruz elimizde IColor kısmı kalıyor bunu class'ların başına I koyup sonundaki Manager kısmını sildiğimizde eşleşiyorsa alıyoruz
           
            

        }
    }
}
