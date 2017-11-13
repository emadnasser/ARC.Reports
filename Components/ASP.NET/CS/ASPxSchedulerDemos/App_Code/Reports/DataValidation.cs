using System;


public class DataValidationReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders timelineScaleHeaders1;
    private DevExpress.XtraScheduler.Reporting.TimelineCells timelineCells1;
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    private DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo timeIntervalInfo1;
    private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
    private DevExpress.XtraScheduler.Reporting.ReportTimelineView reportTimelineView1;
    private DevExpress.XtraScheduler.Reporting.ResourceInfo resourceInfo1;
    private DevExpress.XtraReports.UI.XRShape xrShape1;


    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public DataValidationReport() {
        InitializeComponent();

    }
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>    
    private void InitializeComponent() {
        DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
        DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
        DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
        DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
        DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
        DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
        DevExpress.XtraScheduler.TimeScaleFixedInterval timeScaleFixedInterval1 = new DevExpress.XtraScheduler.TimeScaleFixedInterval();
        DevExpress.XtraPrinting.Shape.ShapeStar shapeStar1 = new DevExpress.XtraPrinting.Shape.ShapeStar();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
        this.timelineCells1 = new DevExpress.XtraScheduler.Reporting.TimelineCells();
        this.timelineScaleHeaders1 = new DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders();
        this.reportTimelineView1 = new DevExpress.XtraScheduler.Reporting.ReportTimelineView();
        this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
        this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo();
        this.resourceInfo1 = new DevExpress.XtraScheduler.Reporting.ResourceInfo();
        this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
        ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.verticalResourceHeaders1,
            this.timelineCells1,
            this.calendarControl1,
            this.timeIntervalInfo1,
            this.timelineScaleHeaders1,
            this.resourceInfo1,
            this.xrShape1});
        this.Detail.Height = 860;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // verticalResourceHeaders1
        // 
        this.verticalResourceHeaders1.Corners.Top = 75;
        this.verticalResourceHeaders1.Location = new System.Drawing.Point(0, 142);
        this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
        this.verticalResourceHeaders1.Size = new System.Drawing.Size(25, 675);
        this.verticalResourceHeaders1.TimeCells = this.timelineCells1;
        this.verticalResourceHeaders1.View = this.reportTimelineView1;
        // 
        // timelineCells1
        // 
        this.timelineCells1.HorizontalHeaders = this.timelineScaleHeaders1;
        this.timelineCells1.Location = new System.Drawing.Point(25, 217);
        this.timelineCells1.Name = "timelineCells1";
        this.timelineCells1.Size = new System.Drawing.Size(620, 600);
        this.timelineCells1.View = this.reportTimelineView1;
        // 
        // timelineScaleHeaders1
        // 
        this.timelineScaleHeaders1.Location = new System.Drawing.Point(25, 142);
        this.timelineScaleHeaders1.Name = "timelineScaleHeaders1";
        this.timelineScaleHeaders1.Size = new System.Drawing.Size(620, 75);
        this.timelineScaleHeaders1.View = this.reportTimelineView1;
        // 
        // reportTimelineView1
        // 
        timeScaleYear1.Enabled = false;
        timeScaleQuarter1.Enabled = false;
        timeScaleHour1.Enabled = false;
        timeScaleFixedInterval1.Enabled = false;
        this.reportTimelineView1.Scales.Add(timeScaleYear1);
        this.reportTimelineView1.Scales.Add(timeScaleQuarter1);
        this.reportTimelineView1.Scales.Add(timeScaleMonth1);
        this.reportTimelineView1.Scales.Add(timeScaleWeek1);
        this.reportTimelineView1.Scales.Add(timeScaleDay1);
        this.reportTimelineView1.Scales.Add(timeScaleHour1);
        this.reportTimelineView1.Scales.Add(timeScaleFixedInterval1);
        this.reportTimelineView1.VisibleIntervalCount = 5;
        this.reportTimelineView1.VisibleResourceCount = 0;
        // 
        // calendarControl1
        // 
        this.calendarControl1.Location = new System.Drawing.Point(292, 0);
        this.calendarControl1.Name = "calendarControl1";
        this.calendarControl1.Size = new System.Drawing.Size(350, 142);
        this.calendarControl1.TimeCells = this.timelineCells1;
        this.calendarControl1.View = this.reportTimelineView1;
        // 
        // timeIntervalInfo1
        // 
        this.timeIntervalInfo1.Location = new System.Drawing.Point(0, 0);
        this.timeIntervalInfo1.Name = "timeIntervalInfo1";
        this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
        this.timeIntervalInfo1.Size = new System.Drawing.Size(283, 142);
        this.timeIntervalInfo1.TimeCells = this.timelineCells1;
        // 
        // resourceInfo1
        // 
        this.resourceInfo1.Location = new System.Drawing.Point(33, 825);
        this.resourceInfo1.Name = "resourceInfo1";
        this.resourceInfo1.Size = new System.Drawing.Size(608, 25);
        this.resourceInfo1.TimeCells = this.timelineCells1;
        // 
        // xrShape1
        // 
        this.xrShape1.Location = new System.Drawing.Point(8, 830);
        this.xrShape1.Name = "xrShape1";
        shapeStar1.StarPointCount = 5;
        this.xrShape1.Shape = shapeStar1;
        this.xrShape1.Size = new System.Drawing.Size(15, 15);
        // 
        // DataValidationReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
        this.Version = "9.2";
        this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportTimelineView1});
        ((System.ComponentModel.ISupportInitialize)(this.reportTimelineView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }


    #endregion

}
