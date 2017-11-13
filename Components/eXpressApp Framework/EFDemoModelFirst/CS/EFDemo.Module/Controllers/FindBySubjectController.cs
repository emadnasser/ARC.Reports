using System;

using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace EFDemo.Module.Controllers {
	public partial class FindBySubjectController : ViewController {
        private void FindBySubjectAction_Execute(object sender, ParametrizedActionExecuteEventArgs e) {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            string paramValue = e.ParameterCurrentValue as string;
            object obj = objectSpace.FindObject(((ListView)View).ObjectTypeInfo.Type,
                CriteriaOperator.Parse(string.Format("Contains([Subject], '{0}')", paramValue)));
            if(obj != null) {
                e.ShowViewParameters.CreatedView = Application.CreateDetailView(objectSpace, obj);
            }
        }
        public FindBySubjectController()
			: base() {
			InitializeComponent();
			RegisterActions(components);
		}
	}
}
