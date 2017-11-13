using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MVVM.Demos.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MVVM.Demos.Navigation {
    public partial class NavigationFrameModule : TutorialControl {
        public NavigationFrameModule() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            navigationFrame.SelectedPageChanged += navigationFrame_SelectedPageChanged;
            ribbonControl.Merge += ribbonControl_Merge;
            LoadSourceCode(sourceCode, "InitializeNavigation");
        }
        void navigationFrame_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            if(e.Page == null)
                ribbonControl.UnMergeRibbon();
            else {
                var view = ((NavigationPage)e.Page).Controls[0] as UserControl;
                var childRibbon = view.Controls.OfType<Control>()
                    .FirstOrDefault(c => c is RibbonControl) as RibbonControl;
                ribbonControl.MergeRibbon(childRibbon);
            }
        }
        void ribbonControl_Merge(object sender, XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
        }
        void InitializeNavigation() {
            // We want the NavigationFrame control to be a navigation provider
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
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
