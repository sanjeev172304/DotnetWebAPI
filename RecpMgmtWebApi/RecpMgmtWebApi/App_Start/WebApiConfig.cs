﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace RecpMgmtWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			// Enabl cors
			var corsAttr = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(corsAttr);

			// Web API configuration and services
			// Configure Web API to use only bearer token authentication.
			config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes(); config.Routes.MapHttpRoute(
				 name: "AlternateApi",
				 routeTemplate: "api/{controller}/{action}/{id}",
				 defaults: new { id = RouteParameter.Optional }
			 );

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Formatters.Remove(config.Formatters.XmlFormatter);
		}
    }
}
