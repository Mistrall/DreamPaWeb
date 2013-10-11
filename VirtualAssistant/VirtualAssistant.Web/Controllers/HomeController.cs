using System.Web.Mvc;
using VirtualAssistant.Web.Helpers;

namespace VirtualAssistant.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message =  "Your description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Pricing()
		{
			return View();
		}

		public ActionResult SetLanguagePreference(string locale)
		{
			CookieHelper.SetCookie("DreamPaLang", "Locale", locale);
			//After setting locale cookie we are redirecting back to calling url
			return Redirect(Request.UrlReferrer.ToString());
		}
	}
}
