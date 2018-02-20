using System.Web.Mvc;

namespace StructureByFeatures.Features.LegDetailMessages
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