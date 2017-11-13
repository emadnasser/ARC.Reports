using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class EditorsController : DemoController {
        [HttpGet]
        public ActionResult ListBox() {
            ListBoxDemoHelper.LoadXmlDocument(Server.MapPath("~/App_Data/PhoneModels.xml"));
            ListBoxDemoHelper.ResetFiltration();
            ListBoxDemoHelper.SelectionMode = ListEditSelectionMode.CheckColumn;
            return DemoView("ListBox", ListBoxDemoHelper.GetFeatures());
        }
        [HttpPost]
        public ActionResult ListBox(ListEditSelectionMode selectionMode) {
            ListBoxDemoHelper.ResetFiltration();
            ListBoxDemoHelper.SelectionMode = selectionMode;
            return DemoView("ListBox", ListBoxDemoHelper.GetFeatures());
        }
        public ActionResult ListBoxPartial(string selectedFeatures) {
            if(!string.IsNullOrEmpty(selectedFeatures))
                ListBoxDemoHelper.FilterModels(selectedFeatures.Split(','));
            else 
                ListBoxDemoHelper.ResetFiltration();
            return PartialView("ListBoxPartial", ListBoxDemoHelper.GetModels());
        }
    }
}
