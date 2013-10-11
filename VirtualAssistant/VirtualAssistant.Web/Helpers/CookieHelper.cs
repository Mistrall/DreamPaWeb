using System;
using System.Web;

namespace VirtualAssistant.Web.Helpers
{
	public static class CookieHelper
	{
		public static void SetCookie(string cookieName, string key, string value, int cookieExpireDate = 1)
		{
			var myCookie = new HttpCookie(cookieName);
			myCookie[key] = value;
			myCookie.Expires = DateTime.Now.AddYears(cookieExpireDate);
			HttpContext.Current.Response.Cookies.Add(myCookie);
		}

		public static string GetCookieValue(string cookieName, string key)
		{
			var cookie= HttpContext.Current.Request.Cookies[cookieName];
			if (cookie != null && !String.IsNullOrEmpty(cookie[key]))
				return cookie[key];
			return null;
		}
	}
}