using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Tools
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Chat tool
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-3.3.1.min.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/jquery.signalR-2.2.2.min.js"
                       ));
            
            bundles.Add(new ScriptBundle("~/bundles/AdminJs").Include(
                       "~/Areas/Chat/assets/libs/jquery/jquery.min.js",
                       "~/Areas/Chat/assets/libs/bootstrap/js/bootstrap.bundle.min.js",
                       "~/Areas/Chat/assets/libs/metismenu/metisMenu.min.js",
                        "~/Areas/Chat/assets/libs/simplebar/simplebar.min.js",
                       "~/Areas/Chat/assets/libs/node-waves/waves.min.js",
                       "~/Areas/Chat/assets/js/pages/dashboard.init.js",
                       "~/Areas/Chat/assets/js/app.js",
                       "~/Areas/Chat/assets/libs/select2/js/select2.min.js",
                        "~/Areas/Chat/assets/js/pages/form-advanced.init.js",
                       "~/Areas/Chat/assets/libs/datatables.net/js/jquery.dataTables.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-buttons/js/dataTables.buttons.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-buttons-bs4/js/buttons.bootstrap4.min.js",
                        "~/Areas/Chat/assets/libs/pdfmake/build/pdfmake.min.js",
                       "~/Areas/Chat/assets/libs/pdfmake/build/vfs_fonts.js",
                       "~/Areas/Chat/assets/libs/datatables.net-buttons/js/buttons.html5.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-buttons/js/buttons.print.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-buttons/js/buttons.colVis.min.js",
                        "~/Areas/Chat/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js",
                       "~/Areas/Chat/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js",
                       "~/Areas/Chat/assets/js/pages/datatables.init.js"
                       ));

            bundles.Add(new StyleBundle("~/bundles/AdminCss").Include(
                        "~/Areas/Chat/assets/libs/select2/css/select2.min.css",
                        "~/Areas/Chat/assets/css/bootstrap.min.css",
                        "~/Areas/Chat/assets/css/icons.min.css",
                         "~/Areas/Chat/assets/css/style.css",
                        "~/Areas/Chat/assets/css/app.min.css",
                        "~/Areas/Chat/assets/libs/datatables.net-bs4/css/dataTables.bootstrap4.min.css",
                         "~/Areas/Chat/assets/libs/select2/css/select2.min.css",
                        "~/Areas/Chat/assets/css/bootstrap.min.css",
                        "~/Areas/Chat/assets/css/icons.min.css",
                         "~/Areas/Chat/assets/libs/datatables.net-buttons-bs4/css/buttons.bootstrap4.min.css",
                        "~/Areas/Chat/assets/libs/datatables.net-responsive-bs4/css/responsive.bootstrap4.min.css",
                        "~/Areas/Chat/assets/libs/datatables.net-responsive-bs4/css/responsive.bootstrap4.min.css"
                        ));

            bundles.UseCdn = true;   //enable CDN support
            #endregion            

            //#region Visitor chat area
            //bundles.Add(new StyleBundle("~/bundles/customersCss").IncludeDirectory("~/Customers/Css/min", "*.css"));
            //bundles.Add(new ScriptBundle("~/bundles/customersScripts").IncludeDirectory(
            //   "~/Customers/Scripts/min/", "*.js"));
            //#endregion
        }
    }
}