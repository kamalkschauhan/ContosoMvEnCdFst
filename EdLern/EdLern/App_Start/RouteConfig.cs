using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EdLern
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Students",
                url: "Students/{action}",
                defaults: new { controller = "Students", action = "Index" }
            );

            //routes.MapRoute(
            //    "Students",
            //    "Students/Details/{id}",
            //    new { controller = "Students", action = "Details", id = UrlParameter. }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
