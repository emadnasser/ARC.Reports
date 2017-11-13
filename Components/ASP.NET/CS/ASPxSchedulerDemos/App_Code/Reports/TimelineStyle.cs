using System;
using DevExpress.XtraScheduler;

public class TimelineStyleReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    #region Fields
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders timelineScaleHeaders1;
    private DevExpress.XtraScheduler.Reporting.TimelineCells timelineCells1;
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    private DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo timeIntervalInfo1;
    private DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders verticalResourceHeaders1;
    private DevExpress.XtraScheduler.Reporting.ReportTimelineView reportTimelineView1;

    string firstTimeScale;
    string secondTimeScale;
    #endregion
    #region Properties
    public int TimeIntervalCount { get { return reportTimelineView1.VisibleIntervalCount; } set { this.reportTimelineView1.VisibleIntervalCount = value; } }
    public int ResourceCount { get { return reportTimelineView1.VisibleResourceCount; } set { this.reportTimelineView1.VisibleResourceCount = value; } }
    public TimeScaleCollection Scales {
        get { return reportTimelineView1.Scales; }
    }
    public string FirstLevelTimeScale {
        get {
            return firstTimeScale;
        }
        set {
            if(firstTimeScale == value)
                return;
            firstTimeScale = value;
            UpdateTimeScales();
        }
    }
    public string SecondLevelTimeScale {
        get {
            return secondTimeScale;
        }
        set {
            if(secondTimeScale == value)
                return;
            secondTimeScale = value;
            UpdateTimeScales();
        }
    }

    #endregion
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public TimelineStyleReport() {
        InitializeComponent();
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.verticalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
        this.timelineCells1 = new DevExpress.XtraScheduler.Reporting.TimelineCells();
        this.timelineScaleHeaders1 = new DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders();
        this.reportTimelineView1 = new DevExpress.XtraScheduler.Reporting.ReportTimelineView();
        this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
        this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo();
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
            this.timelineScaleHeaders1});
        this.Detail.Height = 846;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // verticalResourceHeaders1
        // 
        this.verticalResourceHeaders1.Corners.Top = 42;
        this.verticalResourceHeaders1.Location = new System.Drawing.Point(2, 157);
        this.verticalResourceHeaders1.Name = "verticalResourceHeaders1";
        this.verticalResourceHeaders1.Size = new System.Drawing.Size(25, 675);
        this.verticalResourceHeaders1.TimeCells = this.timelineCells1;
        this.verticalResourceHeaders1.View = this.reportTimelineView1;
        // 
        // timelineCells1
        // 
        this.timelineCells1.HorizontalHeaders = this.timelineScaleHeaders1;
        this.timelineCells1.Location = new System.Drawing.Point(27, 199);
        this.timelineCells1.Name = "timelineCells1";
        this.timelineCells1.Size = new System.Drawing.Size(620, 633);
        this.timelineCells1.View = this.reportTimelineView1;
        // 
        // timelineScaleHeaders1
        // 
        this.timelineScaleHeaders1.Location = new System.Drawing.Point(27, 157);
        this.timelineScaleHeaders1.Name = "timelineScaleHeaders1";
        this.timelineScaleHeaders1.Size = new System.Drawing.Size(620, 42);
        this.timelineScaleHeaders1.View = this.reportTimelineView1;
        // 
        // reportTimelineView1
        // 
        this.reportTimelineView1.VisibleIntervalCount = 5;
        this.reportTimelineView1.VisibleResourceCount = 2;
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
        // TimelineStyleReport
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

    private void UpdateTimeScales() {
        TimeScaleCollection scales = reportTimelineView1.Scales;
        scales.BeginUpdate();
        try {
            foreach(TimeScale item in scales)
                item.Enabled = (item.DisplayName == firstTimeScale) || (item.DisplayName == secondTimeScale);
        } finally {
            scales.EndUpdate();
        }
    }

}
