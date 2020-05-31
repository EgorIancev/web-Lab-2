﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace myshop.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/css/bootstrap.min.css", 
                                                                        "~/Content/css/mdb.min.css",
                                                                          "~/Content/css/style.css",
                                                                          "~/Content/helper.css",
                                                                          "~/Content/style.min.css"
                                                                          ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include("~/Content/js/jquery.min.js",
                                                                    "~/Content/js/popper.min.js",
                                                                         "~/Content/js/bootstrap.min.js",
                                                                            "~/Content/js/mdb.min.js",
                                                                            "~/Scripts/jquery-3.5.0.min.js",
                                                                            "~/Scripts/jquery.unobtrusive-ajax.min.js",
                                                                            "~/Scripts/popper.min.js"
                                                                            ));

        }
    }
}