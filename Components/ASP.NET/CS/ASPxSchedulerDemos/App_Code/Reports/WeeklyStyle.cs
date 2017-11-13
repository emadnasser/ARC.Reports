using System;
using DevExpress.XtraScheduler.Reporting;

public class WeeklyStyleReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    #region Fields
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.ReportWeekView reportWeekView1;
    private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
    private DevExpress.XtraScheduler.Reporting.FullWeek fullWeek1;
    #endregion

    #region Properties
    public int ResourceCount {
        get { return reportWeekView1.VisibleResourceCount; }
        set { reportWeekView1.VisibleResourceCount = value; }
    }
    public int ColumnCount {
        get { return reportWeekView1.VisibleWeekDayColumnCount; }
        set {
            if(reportWeekView1.VisibleWeekDayColumnCount == value)
                return;

            reportWeekView1.VisibleWeekDayColumnCount = value;
            OnColumnCountChanged();
        }
    }
    #endregion
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public WeeklyStyleReport() {
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
        this.fullWeek1 = new DevExpress.XtraScheduler.Reporting.FullWeek();
        this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
        this.reportWeekView1 = new DevExpress.XtraScheduler.Reporting.ReportWeekView();
        this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
        this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
        ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.fullWeek1,
            this.horizontalResourceHeaders1,
            this.calendarControl1,
            this.timeIntervalInfo1});
        this.Detail.Height = 846;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // fullWeek1
        //             
        this.fullWeek1.HorizontalHeaders = this.horizontalResourceHeaders1;
        this.fullWeek1.Location = new System.Drawing.Point(4, 200);
        this.fullWeek1.Name = "fullWeek1";
        this.fullWeek1.Size = new System.Drawing.Size(642, 633);
        this.fullWeek1.View = this.reportWeekView1;
        // 
        // horizontalResourceHeaders1
        // 
        this.horizontalResourceHeaders1.Location = new System.Drawing.Point(4, 175);
        this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
        this.horizontalResourceHeaders1.Size = new System.Drawing.Size(642, 25);
        this.horizontalResourceHeaders1.View = this.reportWeekView1;
        // 
        // calendarControl1
        // 
        this.calendarControl1.Location = new System.Drawing.Point(292, 0);
        this.calendarControl1.Name = "calendarControl1";
        this.calendarControl1.Size = new System.Drawing.Size(350, 142);
        this.calendarControl1.TimeCells = this.fullWeek1;
        this.calendarControl1.View = this.reportWeekView1;
        // 
        // timeIntervalInfo1
        // 
        this.timeIntervalInfo1.Location = new System.Drawing.Point(0, 0);
        this.timeIntervalInfo1.Name = "timeIntervalInfo1";
        this.timeIntervalInfo1.PrintContentMode = DevExpress.XtraScheduler.Reporting.PrintContentMode.AllColumns;
        this.timeIntervalInfo1.Size = new System.Drawing.Size(283, 133);
        this.timeIntervalInfo1.TimeCells = this.fullWeek1;
        // 
        // Report
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
        this.Version = "9.2";
        this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportWeekView1});
        ((System.ComponentModel.ISupportInitialize)(this.reportWeekView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
    private void OnColumnCountChanged() {
        if(ColumnCount == 2) {
            this.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.Odd;
            this.calendarControl1.PrintInColumn = PrintInColumnMode.Even;
            this.timeIntervalInfo1.PrintContentMode = PrintContentMode.AllColumns;
        } else {
            this.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.All;
            this.calendarControl1.PrintInColumn = PrintInColumnMode.All;
            this.timeIntervalInfo1.PrintContentMode = PrintContentMode.CurrentColumn;
        }
    }

}
