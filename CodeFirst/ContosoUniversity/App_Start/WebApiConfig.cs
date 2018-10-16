using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CurrencyConverterAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ApiWithActionAndParameters",
                routeTemplate: "api/{controller}/{action}/{amount}/{fromCurrency}/{toCurrency}",
                defaults: new { action = "get", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ApiWithAction",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { action = "get" }
            );

            config.Routes.MapHttpRoute(
                name: "Api",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "Converted",
            //    routeTemplate: "api/{controller}/{action}/{name}",
            //    defaults: null
            //);
        }
    }
}
