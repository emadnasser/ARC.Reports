using System;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class WindowedModule : TutorialControl {
        public WindowedModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void InitializeNavigation() {
            // We want the default WindowedDocumentManagerService based on RibbonForm to be a navigation provider
            mvvmContext.RegisterService(WindowedDocumentManagerService.CreateRibbonFormService(this));
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<ExpensesDbContextViewModel>();
            fluentAPI.BindCommand(biAccounts, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(biCategories, (x, m) => x.Show(m), x => x.Modules[1]);
            fluentAPI.BindCommand(biTransactions, (x, m) => x.Show(m), x => x.Modules[2]);
            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
    }
}
