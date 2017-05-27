﻿using System.Web;
using System.Web.Optimization;

namespace Shop.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/js/bootstrap.js", "~/js/site.js"));
			bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/css/bootstrap.css", "~/css/site.css"));
		}
	}
}