using System.Web.Mvc;
using VirtualAssistant.Web.Helpers;

namespace VirtualAssistant.Web.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			ViewBag.Message = "";

			return View();
		}

		public ViewResult About()
		{
			ViewBag.Message =  "Your description page.";

			return View();
		}

		public ViewResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ViewResult Pricing()
		{
			return View();
		}

		public ViewResult Home()
		{
			return View();
		}

		public RedirectResult SetLanguagePreference(string locale)
		{
			CookieHelper.SetCookie("DreamPaLang", "Locale", locale);
			return Redirect(Request.UrlReferrer.ToString());
		}
	}
}
