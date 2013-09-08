using System.Web.Mvc;

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
			ViewBag.Message = "Your description page.";

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
	}
}
