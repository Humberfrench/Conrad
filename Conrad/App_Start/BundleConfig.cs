﻿using System.Web.Optimization;

namespace Conrad
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                                                "~/Scripts/bootstrap.min.js",
                                                "~/Scripts/jquery-2.1.4.min.js"));
            bundles.Add(new StyleBundle("~/Content/Public/css").Include(
                                                "~/Content/bootstrap.min.css",
                                                "~/Content/bootstrap-theme.min.css",
                                                "~/Content/Conrad.css"));
        }
    }
}