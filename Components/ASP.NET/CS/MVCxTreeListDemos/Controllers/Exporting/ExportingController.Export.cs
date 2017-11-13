using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class ExportingController : DemoController {
        public ActionResult Export() {
            TreeListExportDemoOptions options = new TreeListExportDemoOptions() {
                EnableAutoWidth = false,
                ExpandAllNodes = false,
                ShowTreeButtons = false
            };
            Session["TreeListExportOptions"] = options;
            return DemoView("Export", DepartmentsProvider.GetDepartments());
        }
        [HttpPost]
        public ActionResult Export([Bind] TreeListExportDemoOptions options) {
            Session["TreeListExportOptions"] = options;
            foreach(string typeName in TreeListExportDemoHelper.ExportTypes.Keys) {
                if(Request.Params[typeName] != null) {
                    return TreeListExportDemoHelper.ExportTypes[typeName].Method(
                        TreeListExportDemoHelper.CreateExportTreeListSettings(options), 
                        DepartmentsProvider.GetDepartments()
                    );
                }
            }
            return DemoView("Export", DepartmentsProvider.GetDepartments());
        }
        public ActionResult ExportPartial() {
            return PartialView("ExportPartial", DepartmentsProvider.GetDepartments());
        }
    }
}
