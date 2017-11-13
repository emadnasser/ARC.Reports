using System;
using DevExpress.XtraScheduler;
using DevExpress.Web;
using System.Globalization;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services.Implementation;

public partial class Reporting_DateFormatting : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        DateFormattingReport report = new DateFormattingReport();
        report.SchedulerAdapter = ReportsDataSource1.SchedulerStorageAdapter;
        report.SchedulerAdapter.TimeInterval = new TimeInterval(SchedulerDemoUtils.BaseDate, SchedulerDemoUtils.BaseDate.AddMonths(1));
        ReportViewer.Report = report;

        InitializeControlValues();
        UpdateFormatServices((SchedulerStorageBasePrintAdapter)report.SchedulerAdapter);
    }
    void InitializeControlValues() {
        if(!IsPostBack) {
            PopulateFormatCombo(cbHorzAptStart);
            PopulateFormatCombo(cbHorzAptStart);
            PopulateFormatCombo(cbHorzAptEnd);
            PopulateFormatCombo(cbVertAptStart);
            PopulateFormatCombo(cbVertAptEnd);
            PopulateFormatCombo(cbHeaderCaptions);
        }
    }
    void PopulateFormatCombo(ASPxComboBox comboBox) {
        comboBox.ValueType = typeof(string);
        comboBox.Items.Add("Default");
        comboBox.Items.AddRange(DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns());
        comboBox.SelectedIndex = 0;
    }
    void UpdateFormatServices(SchedulerStorageBasePrintAdapter adapter) {
        adapter.RemoveService(typeof(IHeaderCaptionService));
        IHeaderCaptionService customHeaderCaptionService = new CustomHeaderCaptionService(cbHeaderCaptions.Text);
        adapter.AddService(typeof(IHeaderCaptionService), customHeaderCaptionService);

        adapter.RemoveService(typeof(IAppointmentFormatStringService));
        CustomAppointmentFormatStringService customAptFormatService = new CustomAppointmentFormatStringService();
        customAptFormatService.HorizontalAppointmentStart = cbHorzAptStart.Text;
        customAptFormatService.HorizontalAppointmentEnd = cbHorzAptEnd.Text;
        customAptFormatService.VerticalAppointmentStart = cbVertAptStart.Text;
        customAptFormatService.VerticalAppointmentEnd = cbVertAptEnd.Text;
        adapter.AddService(typeof(IAppointmentFormatStringService), customAptFormatService);
    }
}
public class CustomHeaderCaptionService : HeaderCaptionServiceWrapper {
    string format;
    public CustomHeaderCaptionService(string format)
        : base(new HeaderCaptionService()) {
        this.format = format;
    }
    protected virtual string CreateFormat(string format) {
        if(format == "Default")
            return string.Empty;
        return String.Format("{{0:{0}}}", format);
    }
    public override string GetDayColumnHeaderCaption(DayHeader header) {
        return CreateFormat(format);
    }
}
public class CustomAppointmentFormatStringService : AppointmentFormatStringServiceWrapper {
    string horizontalAppointmentStart;
    string horizontalAppointmentEnd;
    string verticalAppointmentStart;
    string verticalAppointmentEnd;

    public CustomAppointmentFormatStringService()
        : base(new AppointmentFormatStringService()) {
    }
    public string HorizontalAppointmentStart { get { return horizontalAppointmentStart; } set { horizontalAppointmentStart = value; } }
    public string HorizontalAppointmentEnd { get { return horizontalAppointmentEnd; } set { horizontalAppointmentEnd = value; } }
    public string VerticalAppointmentStart { get { return verticalAppointmentStart; } set { verticalAppointmentStart = value; } }
    public string VerticalAppointmentEnd { get { return verticalAppointmentEnd; } set { verticalAppointmentEnd = value; } }

    protected virtual string CreateFormat(string format) {
        if(format == "Default")
            return string.Empty;
        return String.Format("{{0:{0}}} ", format);
    }
    public override string GetHorizontalAppointmentStartFormat(IAppointmentViewInfo aptViewInfo) {
        return CreateFormat(horizontalAppointmentStart);
    }
    public override string GetHorizontalAppointmentEndFormat(IAppointmentViewInfo aptViewInfo) {
        return CreateFormat(horizontalAppointmentEnd);
    }
    public override string GetVerticalAppointmentStartFormat(IAppointmentViewInfo aptViewInfo) {
        return CreateFormat(verticalAppointmentStart);
    }
    public override string GetVerticalAppointmentEndFormat(IAppointmentViewInfo aptViewInfo) {
        return CreateFormat(verticalAppointmentEnd);
    }
    public override string GetContinueItemStartFormat(IAppointmentViewInfo aptViewInfo) {
        return base.GetContinueItemStartFormat(aptViewInfo);
    }
    public override string GetContinueItemEndFormat(IAppointmentViewInfo aptViewInfo) {
        return base.GetContinueItemEndFormat(aptViewInfo);
    }
}

