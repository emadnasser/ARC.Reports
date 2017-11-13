using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class MenuController: DemoController {
        public override string Name { get { return "Menu"; } }

        public ActionResult Index() {
            return DataBinding();
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            base.OnActionExecuted(filterContext);
            if((Utils.CurrentDemo == null || Utils.IsBogusDemo) && filterContext.ActionDescriptor.ActionName.StartsWith("ResponsiveLayout")) {
                DevExpressHelper.Theme = "Moderno";
                Utils.ResetThemeParameters();
            }
        }
    }
}
