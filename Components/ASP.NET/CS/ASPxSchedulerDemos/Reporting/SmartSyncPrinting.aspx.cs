using System;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

public partial class Reporting_SmartSyncPrinting : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        SchedulerPrintAdapter adapter = ReportsDataSource1.SchedulerStorageAdapter;
        adapter.TimeInterval = new TimeInterval(SchedulerDemoUtils.BaseDate.AddDays(17), TimeSpan.FromDays(4));
        adapter.EnableSmartSync = true;
        adapter.ValidateResources += new ResourcesValidationEventHandler(SchedulerPrintAdapter_ValidateResources);

        SmartSyncPrintingReport report = new SmartSyncPrintingReport();
        report.SchedulerAdapter = adapter;
        ReportViewer.Report = report;

        InitializeControlValues(adapter);

        ApplyOptions(adapter);

    }
    void InitializeControlValues(SchedulerPrintAdapter adapter) {
        if(!IsPostBack) {
            this.rbGroupType.Value = Convert.ToInt32(adapter.SmartSyncOptions.GroupType);
        }
    }
    void ApplyOptions(SchedulerPrintAdapter adapter) {
        adapter.SmartSyncOptions.GroupType = (SchedulerGroupType)rbGroupType.Value;
    }
    void SchedulerPrintAdapter_ValidateResources(object sender, ResourcesValidationEventArgs e) {
        if(e.Resources.Count == 0)
            return;

        Resource r1 = e.Resources[0];
        Resource r2 = e.Resources[2];
        e.Resources.BeginUpdate();
        try {
            e.Resources.Clear();
            e.Resources.Add(r1);
            e.Resources.Add(r2);
        } finally {
            e.Resources.EndUpdate();

        }

    }

}
