Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DemoBase.DemoTesting
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.Native

Namespace ReportWpfDemo.Tests
    Public Class ReportsCheckAllDemosFixture
        Inherits CheckAllDemosFixture

        'protected override void CreateSetCurrentDemoActions(ModuleDescription moduleID, bool checkMemoryLeaks) {
        '    base.CreateSetCurrentDemoActions(moduleID, checkMemoryLeaks);
        '    if(moduleID != null) {
        '        AddConditionAction(DocumentPagesReadyConditionFactory.Create(this), TestDemoModule);
        '    }
        '}

        'void TestDemoModule() {
        '    ReportModuleViewModelBase reportModuleViewModel = (ReportModuleViewModelBase)DemoBaseTesting.CurrentDemoModule.DataContext;
        '    XtraReportPreviewModel activeModel = reportModuleViewModel.ReportPreviewModel;
        '    Assert.AreNotEqual(activeModel.PageContent.GetType(), typeof(PageWithRedCross), string.Format("Exception is raised with displaying a red cross on {0} demo module", DemoBaseTesting.CurrentDemoModule.GetType().Name));
        '}
    End Class
End Namespace
