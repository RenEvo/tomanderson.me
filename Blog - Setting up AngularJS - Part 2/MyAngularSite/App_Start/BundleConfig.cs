using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            bundles.Add(new ScriptBundle("~/bundles/dependencies")
            .Include("~/components/jquery/dist/jquery.min.js")
            .Include("~/components/angular/angular.min.js")
            .Include("~/components/angular-route/angular-route.min.js")
            .Include("~/components/angular-resource/angular-resource.min.js")
            .Include("~/components/angular-cookies/angular-cookies.min.js")
            .Include("~/components/underscore/underscore.js")
            .Include("~/components/angular-bootstrap/ui-bootstrap.min.js")
            );

#if (DEBUG)
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}