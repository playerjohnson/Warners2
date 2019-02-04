using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;

namespace Warners.Infrastucture.DependencyInjection
{
    public class DependencyInjectionConfig
    {
        public static void RegisterModules()
        {
            var builder = new ContainerBuilder();
            builder.RegisterFilterProvider();
            builder.RegisterControllers(controllerAssemblies: typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(assemblies: typeof(MvcApplication).Assembly);

            var container = builder.Build();
            DependencyResolver.SetResolver(resolver: new AutofacDependencyResolver(container));
        }
    }
}