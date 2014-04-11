using System.Web.Optimization;

namespace MyAngularSite
{
    /// <summary>
    /// Class BundleConfig.
    /// </summary>
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/dependencies.js")
                .Include("~/components/jquery/dist/jquery.min.js")
                .Include("~/components/angular/angular.min.js")
                .Include("~/components/angular-route/angular-route.min.js")
                .Include("~/components/angular-resource/angular-resource.min.js")
                .Include("~/components/angular-cookies/angular-cookies.min.js")
                .Include("~/components/underscore/underscore.js")
                .Include("~/components/angular-bootstrap/ui-bootstrap.min.js")
            );

            bundles.Add(new ScriptBundle("~/bundles/ng-app.js")
                .IncludeDirectory("~/app/", "*.utility.js", true)
                .Include("~/app/app.module.js")
                .IncludeDirectory("~/app/", "*.config.js", true)
                .IncludeDirectory("~/app/", "*.run.js", true)
                .IncludeDirectory("~/app/", "*.service.js", true)
                .IncludeDirectory("~/app/", "*.controller.js", true)
                .IncludeDirectory("~/app/", "*.directive.js", true)
                .IncludeDirectory("~/app/", "*.filter.js", true)
            );


#if (DEBUG)
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}