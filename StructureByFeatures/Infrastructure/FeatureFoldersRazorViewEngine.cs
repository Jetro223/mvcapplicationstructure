using System.Web.Mvc;

namespace StructureByFeatures.Infrastructure
{
    public class FeatureFoldersRazorViewEngine : RazorViewEngine
    {
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            var x = base.FindView(controllerContext, viewName, masterName, useCache);
            return x;
        }

        public FeatureFoldersRazorViewEngine()
        {
            var featureFolderViewLocationFormats = new[]
            {
                "~/Features/{1}/{0}.cshtml",
                "~/Features/LegDetail/{1}/{0}.cshtml", // jedes Top-Level Feature muss hier adressiert werden
                "~/Features/Shared/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml",
                "~/Views/{0}.cshtml",
            };
            //0 = action, 1 = controller, 2 = area
            ViewLocationFormats = featureFolderViewLocationFormats;
            MasterLocationFormats = featureFolderViewLocationFormats;
            PartialViewLocationFormats = featureFolderViewLocationFormats;
        }

    }
}