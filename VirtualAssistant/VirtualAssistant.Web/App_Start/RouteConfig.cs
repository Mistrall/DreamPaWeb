﻿using System.Web.Mvc;
using System.Web.Routing;

namespace VirtualAssistant.Web.App_Start
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}", 
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional},
				namespaces:new []{"VirtualAssistant.Web"});

			//routes.MapRoute(
			//	name: "Default",
			//	url: "{controller}/{action}/{id}",
			//	defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			//);
		}
	}
}