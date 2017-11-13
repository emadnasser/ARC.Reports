using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraScheduler.Reporting;

public class AutoHeightMonth : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport, IAutoHeightReport {
    #region Fields
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraScheduler.Reporting.ReportMonthView reportMonthView1;
    private DevExpress.XtraScheduler.Reporting.HorizontalWeek horizontalWeek;
    private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
    #endregion

    public AutoHeightMonth() {
        InitializeComponent();
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// 
    protected override void Dispose(bool disposing) {
        if(disposing) {
            if(components != null) {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
        this.reportMonthView1 = new DevExpress.XtraScheduler.Reporting.ReportMonthView();
        this.horizontalWeek = new DevExpress.XtraScheduler.Reporting.HorizontalWeek();
        ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.horizontalResourceHeaders1,
            this.horizontalWeek});
        this.Detail.HeightF = 142F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // horizontalResourceHeaders1
        // 
        this.horizontalResourceHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(1.999982F, 0F);
        this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
        this.horizontalResourceHeaders1.SizeF = new System.Drawing.SizeF(648F, 26F);
        this.horizontalResourceHeaders1.View = this.reportMonthView1;
        // 
        // reportMonthView1
        // 
        this.reportMonthView1.VisibleWeekCount = 2;
        // 
        // horizontalWeek
        // 
        this.horizontalWeek.HorizontalHeaders = this.horizontalResourceHeaders1;
        this.horizontalWeek.LocationFloat = new DevExpress.Utils.PointFloat(1.999982F, 26.00002F);
        this.horizontalWeek.Name = "horizontalWeek";
        this.horizontalWeek.SizeF = new System.Drawing.SizeF(648F, 110F);
        this.horizontalWeek.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
        this.horizontalWeek.View = this.reportMonthView1;
        // 
        // AutoHeightMonth
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
        this.Version = "10.1";
        this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportMonthView1});
        ((System.ComponentModel.ISupportInitialize)(this.reportMonthView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
    #endregion

    #region IAutoHeightReport Members
    public bool CellsCanShrink { get { return horizontalWeek.CanShrink; } set { horizontalWeek.CanShrink = value; } }
    public bool CellsCanGrow { get { return horizontalWeek.CanGrow; } set { horizontalWeek.CanGrow = value; } }
    public float CellsHeight { get { return horizontalWeek.HeightF; } set { horizontalWeek.HeightF = value; } }
    #endregion
}

public interface IAutoHeightReport {
    bool CellsCanShrink { get; set; }
    bool CellsCanGrow { get; set; }
    float CellsHeight { get; set; }
}

