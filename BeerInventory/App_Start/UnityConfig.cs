using Repository.IRepository;
using Repository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BeerInventory
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IMicrobrasserieRepository, MicrobrasserieRepository>();
            container.RegisterType<IRegionRepository, RegionRepository>();



            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}