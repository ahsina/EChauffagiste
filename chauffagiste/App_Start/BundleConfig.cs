using System.Web;
using System.Web.Optimization;

namespace chauffagiste
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.flexisel.js",
                      "~/Scripts/jquery.flexslider.js",
                      "~/Scripts/jquery-ui.min.js",
                      "~/Scripts/memenu.js",
                      "~/Scripts/simpleCart.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/flexslider.css",
                      "~/Content/form.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/memenu.css",
                      "~/Content/style.css"));
        }
    }
}
