using System;
using System.Globalization;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VirtualAssistant.Web.App_Start;

namespace VirtualAssistant.Web
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			WebApiConfig.Register(GlobalConfiguration.Configuration);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			AuthConfig.RegisterAuth();
		}

		protected void Application_AcquireRequestState(object sender, EventArgs e)
		{
			var languageCookie = Context.Request.Cookies["lang"];
			var userLanguages = Context.Request.UserLanguages;

			// Set the Culture based on a route, a cookie or the browser settings,
			// or default value if something went wrong
			var cultureInfo = new CultureInfo(
				languageCookie != null
					? languageCookie.Value
					: userLanguages != null
						  ? userLanguages[0]
						  : "en"
				);

			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		}
	}
}