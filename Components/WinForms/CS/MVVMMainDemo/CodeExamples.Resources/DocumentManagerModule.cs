using System;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class DocumentManagerModule : TutorialControl {
        public DocumentManagerModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void ribbonControl_Merge(object sender, XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitializeNavigation() {
            // We want the DocmentManager's TabbedView to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(tabbedView));
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
