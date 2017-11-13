using Common.Win.General.DashBoard.BusinessObjects;
using Common.Win.General.DashBoard.Helpers;
using Common.Win.General.DashBoard.Templates;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Security;

namespace Common.Win.General.DashBoard.Controllers {
    public partial class DashboardDesignerController : ViewController {
        public DashboardDesignerController() {
            InitializeComponent();
            RegisterActions(components);
            TargetObjectType = typeof(IDashboardDefinition);
        }

        public SimpleAction DashboardEditAction {
            get { return dashboardEdit; }
        }

        protected override void OnActivated() {
            base.OnActivated();
            View.SelectionChanged += (s, e) => UpdateActionState();
            UpdateActionState();
        }

        void UpdateActionState() {
            if (SecuritySystem.Instance is ISecurityComplex) {
                bool isGranted = true;
                foreach (object selectedObject in View.SelectedObjects) {
                    var clientPermissionRequest = new PermissionRequest(View.ObjectSpace, typeof(IDashboardDefinition), "Xml", selectedObject, SecurityOperations.Write);
                    isGranted = SecuritySystem.IsGranted(clientPermissionRequest);
                }
                dashboardEdit.Active["SecurityIsGranted"] = isGranted;
            }
        }

        void dashboardEdit_Execute(object sender, SimpleActionExecuteEventArgs e) {
            using (var form = new DashboardDesignerForm()) {
                new XPObjectSpaceAwareControlInitializer(form, Application);
                form.LoadTemplate(View.CurrentObject as IDashboardDefinition);
                form.ShowDialog();
            }
        }
    }
}
