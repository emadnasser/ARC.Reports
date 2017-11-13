using System.Web.Mvc;

namespace DevExpress.Web.Demos
{
    public partial class APIController : DemoController
    {
        public ActionResult ClientSideEvents()
        {
            ViewData["ClientSideEvents"] = new string[] { "Init", "SelectionChanged", "DocumentChanged", "BeginSynchronization", "EndSynchronization", "HyperlinkClick" };
            ViewData["ShowEventListPanel"] = true;
            return DemoView("ClientSideEvents");
        }
        public ActionResult ClientSideEventsPartial()
        {
            return PartialView("ClientSideEventsPartial");
        }
    }
}
