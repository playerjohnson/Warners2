using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Warners.App_Start;
using Warners.Infrastucture.DependencyInjection;

namespace Warners
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DependencyInjectionConfig.RegisterModules();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
            AutoMapperConfig.ConfigureMapping();
        }
    }
}
