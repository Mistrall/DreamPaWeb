using System.Web.Optimization;

namespace VirtualAssistant.Web.App_Start
{
	public class BundleConfig
	{
		// For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
						"~/Scripts/jquery-ui-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.unobtrusive*",
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr")
				.Include("~/Scripts/modernizr-*")
				);

			bundles.Add(new StyleBundle("~/css")
				.Include("~/Content/bootstrap/bootstrap.css")
				.Include("~/Content/bootstrap/bootstrap-responsive.css")
				.Include("~/Content/bootstrap/validation-errors.css")
				.Include("~/Content/clean-canvas-custom-fixes/General-theme-fixes.css")
				);

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/css/clean-canvas-theme")
				.Include("~/Content/clean-canvas-bootstrap/bootstrap-overrides.css")
				.Include("~/Content/clean-canvas-bootstrap/theme.css")
				.Include("~/Content/clean-canvas-bootstrap/lib/animate.css"));

			bundles.Add(new ScriptBundle("~/bundles/clean-canvas-js")
				.Include("~/Content/clean-canvas-bootstrap/js/theme.js")
				.Include("~/Content/clean-canvas-bootstrap/js/index-slider.js"));

			bundles.Add(new StyleBundle("~/css/bootstrap-form-helpers")
				.Include("~/Content/bootstrap-form-helpers/bootstrap-formhelpers-countries.flags.css"));
		}
	}
}