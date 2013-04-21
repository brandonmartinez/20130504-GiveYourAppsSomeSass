using System.Web;
using System.Web.Optimization;

namespace WebAppDemo
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
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new StyleBundle("~/Presentation/css").Include("~/Presentation/site.css"));

			bundles.Add(new StyleBundle("~/Presentation/themes/base/css").Include(
						"~/Presentation/themes/base/jquery.ui.core.css",
						"~/Presentation/themes/base/jquery.ui.resizable.css",
						"~/Presentation/themes/base/jquery.ui.selectable.css",
						"~/Presentation/themes/base/jquery.ui.accordion.css",
						"~/Presentation/themes/base/jquery.ui.autocomplete.css",
						"~/Presentation/themes/base/jquery.ui.button.css",
						"~/Presentation/themes/base/jquery.ui.dialog.css",
						"~/Presentation/themes/base/jquery.ui.slider.css",
						"~/Presentation/themes/base/jquery.ui.tabs.css",
						"~/Presentation/themes/base/jquery.ui.datepicker.css",
						"~/Presentation/themes/base/jquery.ui.progressbar.css",
						"~/Presentation/themes/base/jquery.ui.theme.css"));
		}
	}
}