using System.Web.Mvc;

namespace StructureByAreas.Areas.LegDetail.Controllers
{
    public class LegDetailMessagesController : Controller
    {
        public ActionResult LegDetailMessages()
        {
            return View();
        }

        public ActionResult MessageModal()
        {
            return View("_MessageModal");
        }
    }
}