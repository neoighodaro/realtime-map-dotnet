using System.Web.Mvc;
using System.Web.Routing;

namespace Gaia
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Map",
                url:  "map",
                defaults: new { controller = "Map", action = "Index" }
            );
        }
    }
}
