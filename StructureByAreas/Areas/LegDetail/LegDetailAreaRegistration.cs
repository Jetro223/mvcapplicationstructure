using System.Web.Mvc;

namespace StructureByAreas.Areas.LegDetail
{
    public class LegDetailAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LegDetail";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LegDetail_default",
                "LegDetail/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}