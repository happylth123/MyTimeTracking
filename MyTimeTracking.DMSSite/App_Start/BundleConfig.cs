using System.Web;
using System.Web.Optimization;

namespace MyTimeTracking.DMSSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Can not remove /content/cores/ otherwise Icon is disappeared
            bundles.Add(new StyleBundle("~/Content/cores/globalStyles").Include(
                    "~/Content/cores/font-awesome.min.css",
                    "~/Content/cores/simple-line-icons.min.css",
                    "~/Content/cores/bootstrap.min.css",
                    "~/Content/cores/uniform.default.css"));

            bundles.Add(new StyleBundle("~/Scripts/datatables/plugins/bootstrap/listCategoryPlugin").Include(
                "~/Scripts/select2/select2.css",
                "~/Scripts/datatables/plugins/bootstrap/dataTables.bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
        }
    }
}
