using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyAngularSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // ignores
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // mvc [Route] attribute support
            routes.MapMvcAttributeRoutes();

            // default route goes to our home/index which is our angularjs page
            routes.MapRoute(
                name: "AngularJS",
                url: "{*any}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
