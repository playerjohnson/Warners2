using Autofac;
using Warners.Common.Serialization;
using Warners.Common.Services.Cache;
using Warners.Common.Services.Model;
using Warners.Common.Services.Session;
using Warners.Data.Respository;

namespace Warners.Infrastucture.DependencyInjection.Modules
{
    public class ServiceModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<CacheService>().As<ICacheService>();
            builder.RegisterType<SessionService>().As<ISessionService>();
            builder.RegisterType<JsonSerializer>().As<ISerializer>();
            builder.RegisterType<QAFModelService>().As<IQAFModelService>();
            builder.RegisterType<Respository>().As<IRespository>();
        }
    }
}