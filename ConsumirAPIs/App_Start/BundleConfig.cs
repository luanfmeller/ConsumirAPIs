using System.Web;
using System.Web.Optimization;

namespace ConsumirAPIs
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                       "~/Scripts/scripts.js"));

            bundles.Add(new ScriptBundle("~/bundles/CorreiosCEPjs").Include(
                       "~/Scripts/app/CorreiosCEP.js"));

            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                       "~/Scripts/demo/chart-area-demo.js",
                       "~/Scripts/demo/chart-bar-demo.js",
                       "~/Scripts/demo/chart-pie-demo.js",
                       "~/Scripts/demo/datatables-demo.js"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                     "~/Content/style.css"));

        }
    }
}
