using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.DemoBase.DemoTesting;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Printing.Native;

namespace ReportWpfDemo.Tests {
    public class ReportsCheckAllDemosFixture : CheckAllDemosFixture {
        //protected override void CreateSetCurrentDemoActions(ModuleDescription moduleID, bool checkMemoryLeaks) {
        //    base.CreateSetCurrentDemoActions(moduleID, checkMemoryLeaks);
        //    if(moduleID != null) {
        //        AddConditionAction(DocumentPagesReadyConditionFactory.Create(this), TestDemoModule);
        //    }
        //}

        //void TestDemoModule() {
        //    ReportModuleViewModelBase reportModuleViewModel = (ReportModuleViewModelBase)DemoBaseTesting.CurrentDemoModule.DataContext;
        //    XtraReportPreviewModel activeModel = reportModuleViewModel.ReportPreviewModel;
        //    Assert.AreNotEqual(activeModel.PageContent.GetType(), typeof(PageWithRedCross), string.Format("Exception is raised with displaying a red cross on {0} demo module", DemoBaseTesting.CurrentDemoModule.GetType().Name));
        //}
    }
}
