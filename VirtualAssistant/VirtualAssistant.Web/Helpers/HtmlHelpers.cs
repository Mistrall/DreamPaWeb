﻿using System.Threading;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace VirtualAssistant.Web.Helpers
{
	public static class HtmlHelpers
	{
		public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper, string linkText, string actionName, string controllerName)
		{
			var currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
			var currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

			var builder = new TagBuilder("li")
			{
				InnerHtml = htmlHelper.ActionLink(linkText, actionName, controllerName).ToHtmlString()
			};

			if (controllerName == currentController && actionName == currentAction)
				builder.AddCssClass("active");

			return new MvcHtmlString(builder.ToString());
		}

		public static MvcHtmlString RenderCulture(this HtmlHelper htmlHelper)
		{
			var culture = Thread.CurrentThread.CurrentCulture;

			return new MvcHtmlString(culture.Name);
		}
	}
}