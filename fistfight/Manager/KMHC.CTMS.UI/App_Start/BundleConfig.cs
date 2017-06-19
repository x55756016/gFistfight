
using System.Web;
using System.Web.Optimization;

namespace Project.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/sb-admin").Include(
                "~/Content/sb-admin.css"));//angular管理后台样式

            bundles.Add(new ScriptBundle("~/Script/bootstrap_control").Include(
                "~/Scripts/bootstrap-datepicker*"
                , "~/Scripts/bootstrap-multiselect.js"
                , "~/AppScripts/common/common.js"
                , "~/Scripts/paging.js"
                , "~/Scripts/webuploader.js"
                   , "~/Scripts/bootstrap-typeahead.js"
                , "~/AppScripts/common/pager.js"));

            bundles.Add(new ScriptBundle("~/Script/angular").Include(
                        "~/Scripts/angular.js"
                        , "~/Scripts/angular-route.js"
                        , "~/Scripts/angular-resource.js"
                        , "~/Scripts/angular-animate.js"
                        , "~/AppScripts/common/navi-controllers.js"
                        , "~/AppScripts/common/services.js"
                        , "~/AppScripts/common/utility.js"
                        , "~/AppScripts/common/area.js"
                        , "~/AppScripts/common/AppRoute.js"
                        , "~/AppScripts/Home/dug.js"
                        , "~/AppScripts/ModuleJS/tm_pm_userinfo.js"
                        , "~/AppScripts/ModuleJS/xy_sp_chapter.js"
                        , "~/AppScripts/ModuleJS/xy_sp_equipment.js"
                        , "~/AppScripts/ModuleJS/xy_sp_map.js"
                        , "~/AppScripts/ModuleJS/xy_sp_outfit.js"
                        , "~/AppScripts/ModuleJS/xy_sp_outfitequipment.js"
                        , "~/AppScripts/ModuleJS/xy_sp_skill.js"
                        , "~/AppScripts/ModuleJS/xy_sp_spirit.js"
                        , "~/AppScripts/ModuleJS/xy_sp_spiritequipment.js"
                        , "~/AppScripts/ModuleJS/xy_sp_spiritskill.js"
                        , "~/AppScripts/ModuleJS/xy_sp_task.js"
                        , "~/AppScripts/ModuleJS/xy_sp_taskoption.js"
                        , "~/AppScripts/ModuleJS/xy_sp_taskspirit.js"
                        , "~/AppScripts/ModuleJS/xy_sp_userinfo.js"
                        , "~/AppScripts/ModuleJS/xy_sp_userspirit.js"
                        ));
        }
    }
}