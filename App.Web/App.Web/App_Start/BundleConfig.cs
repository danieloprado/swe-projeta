﻿using System.Web.Optimization;

namespace App.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/app")
                .IncludeDirectory("~/Scripts", "*.js", true);

            //BundleTable.EnableOptimizations = true;
        }
    }
}
