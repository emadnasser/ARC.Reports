using System;
using DevExpress.XtraScheduler;



public class DateFormattingReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport {
    #region Fields
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders horizontalDateHeaders1;
    private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
    private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
    private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
    #endregion
    private DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo formatTimeIntervalInfo1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public DateFormattingReport() {
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
        this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
        this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
        this.horizontalDateHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalDateHeaders();
        this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
        this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
        this.formatTimeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.FormatTimeIntervalInfo();
        ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.calendarControl1,
            this.horizontalDateHeaders1,
            this.dayViewTimeCells1,
            this.dayViewTimeRuler1,
            this.formatTimeIntervalInfo1});
        this.Detail.Height = 205;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // calendarControl1
        // 
        this.calendarControl1.Location = new System.Drawing.Point(292, 0);
        this.calendarControl1.Name = "calendarControl1";
        this.calendarControl1.Size = new System.Drawing.Size(350, 142);
        this.calendarControl1.TimeCells = this.dayViewTimeCells1;
        this.calendarControl1.View = this.reportDayView1;
        // 
        // dayViewTimeCells1
        // 
        this.dayViewTimeCells1.HorizontalHeaders = this.horizontalDateHeaders1;
        this.dayViewTimeCells1.Location = new System.Drawing.Point(54, 173);
        this.dayViewTimeCells1.Name = "dayViewTimeCells1";
        this.dayViewTimeCells1.Size = new System.Drawing.Size(595, 30);
        this.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
        this.dayViewTimeCells1.View = this.reportDayView1;
        // 
        // horizontalDateHeaders1
        // 
        this.horizontalDateHeaders1.Location = new System.Drawing.Point(54, 148);
        this.horizontalDateHeaders1.Name = "horizontalDateHeaders1";
        this.horizontalDateHeaders1.Size = new System.Drawing.Size(595, 25);
        this.horizontalDateHeaders1.View = this.reportDayView1;
        // 
        // reportDayView1
        // 
        this.reportDayView1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.None;
        this.reportDayView1.VisibleDayCount = 2;
        // 
        // dayViewTimeRuler1
        // 
        this.dayViewTimeRuler1.Corners.Top = 25;
        this.dayViewTimeRuler1.Location = new System.Drawing.Point(4, 148);
        this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
        this.dayViewTimeRuler1.Size = new System.Drawing.Size(50, 55);
        this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
        this.dayViewTimeRuler1.View = this.reportDayView1;
        // 
        // formatTimeIntervalInfo1
        // 
        this.formatTimeIntervalInfo1.Location = new System.Drawing.Point(0, 8);
        this.formatTimeIntervalInfo1.Name = "formatTimeIntervalInfo1";
        this.formatTimeIntervalInfo1.Size = new System.Drawing.Size(300, 125);
        this.formatTimeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
        // 
        // DateFormattingReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
        this.Version = "9.2";
        this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
        ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

}
