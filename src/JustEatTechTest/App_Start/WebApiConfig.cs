using System.Web.Http;
using JustEatTechTest.Web.Plumbing;
using StructureMap;

namespace JustEatTechTest.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            // create IoC container and set dependency resolver
            IContainer container = StructureMapHelper.BootstrapContainer();
            StructureMapResolver structureMapResolver = new StructureMapResolver(container);
            config.DependencyResolver = structureMapResolver;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
