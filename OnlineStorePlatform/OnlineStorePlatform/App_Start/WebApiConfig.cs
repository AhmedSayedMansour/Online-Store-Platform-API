﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace OnlineStorePlatform
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
			
			//return only JSON or only XML
			//config.Formatters.Remove(config.Formatters.XmlFormatter);
			//config.Formatters.Remove(config.Formatters.JsonFormatter);
		}
    }
}
