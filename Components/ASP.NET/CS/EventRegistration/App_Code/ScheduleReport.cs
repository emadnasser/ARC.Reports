using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler;
using System.ComponentModel;
using System.Drawing;

/// <summary>
/// Summary description for ScheduleReport
/// </summary>
public class ScheduleReport : XtraReport
{
    private TopMarginBand topMarginBand1;
    private DetailBand detailBand1;
    private GroupHeaderBand GroupHeader1;
    private PageHeaderBand PageHeader;
    private XRLabel xrLabelDay;
    private BottomMarginBand bottomMarginBand1;
    private XRControlStyle xrControlStyle1;
    private System.Data.DataSet dataSet1;
    private System.Data.DataTable dataTable1;
    private FormattingRule formattingRule1;
    private FormattingRule formattingRule2;
    private System.Data.DataColumn dataColumn1;
    private System.Data.DataColumn dataColumn2;
    private System.Data.DataColumn dataColumn3;
    private System.Data.DataColumn dataColumn4;
    private System.Data.DataColumn dataColumn5;
    private System.Data.DataColumn dataColumn6;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell1;
    private XRPanel xrPanel1;
    private GroupFooterBand GroupFooter1;
    private XRTableCell xrTableCell2;

	public ScheduleReport(List<Session> sessions)
	{
        InitializeComponent();
        InitDataSource(sessions);
	}
    void InitDataSource(List<Session> sessions) {
        foreach(Session session in sessions) {
            SessionPrintAdapter adapter = new SessionPrintAdapter(session);
            dataSet1.Tables["reportAppointments"].Rows.Add(adapter.Day, adapter.Time, adapter.Subject, adapter.Location, adapter.StartTime, adapter.Important);
        }
    }

    private void InitializeComponent() {
        this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
        this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
        this.formattingRule2 = new DevExpress.XtraReports.UI.FormattingRule();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.dataTable1 = new System.Data.DataTable();
        this.dataColumn1 = new System.Data.DataColumn();
        this.dataColumn2 = new System.Data.DataColumn();
        this.dataColumn3 = new System.Data.DataColumn();
        this.dataColumn4 = new System.Data.DataColumn();
        this.dataColumn5 = new System.Data.DataColumn();
        this.dataColumn6 = new System.Data.DataColumn();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrLabelDay = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.dataSet1 = new System.Data.DataSet();
        this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
        this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // topMarginBand1
        // 
        this.topMarginBand1.HeightF = 24F;
        this.topMarginBand1.Name = "topMarginBand1";
        // 
        // detailBand1
        // 
        this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.detailBand1.HeightF = 30.00002F;
        this.detailBand1.Name = "detailBand1";
        this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("StartTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        // 
        // xrTable1
        // 
        this.xrTable1.FormattingRules.Add(this.formattingRule1);
        this.xrTable1.FormattingRules.Add(this.formattingRule2);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(53.84301F, 1.000015F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(772.625F, 24F);
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // formattingRule1
        // 
        this.formattingRule1.Condition = "[Important] == 1";
        // 
        // 
        // 
        this.formattingRule1.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
        this.formattingRule1.Name = "formattingRule1";
        // 
        // formattingRule2
        // 
        this.formattingRule2.Condition = "[Important] == 2";
        // 
        // 
        // 
        this.formattingRule2.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
        this.formattingRule2.Name = "formattingRule2";
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 0.96000000000000008D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.dataTable1, "Time")});
        this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrTableCell1.StylePriority.UseFont = false;
        this.xrTableCell1.StylePriority.UsePadding = false;
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "xrTableCell1";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell1.Weight = 1.5730536282386878D;
        // 
        // dataTable1
        // 
        this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
        this.dataTable1.TableName = "reportAppointments";
        // 
        // dataColumn1
        // 
        this.dataColumn1.ColumnName = "Day";
        // 
        // dataColumn2
        // 
        this.dataColumn2.ColumnName = "Time";
        // 
        // dataColumn3
        // 
        this.dataColumn3.ColumnName = "Subject";
        // 
        // dataColumn4
        // 
        this.dataColumn4.ColumnName = "Locatoin";
        // 
        // dataColumn5
        // 
        this.dataColumn5.ColumnMapping = System.Data.MappingType.Hidden;
        this.dataColumn5.ColumnName = "StartTime";
        this.dataColumn5.DataType = typeof(System.DateTime);
        // 
        // dataColumn6
        // 
        this.dataColumn6.ColumnMapping = System.Data.MappingType.Hidden;
        this.dataColumn6.ColumnName = "Important";
        this.dataColumn6.DataType = typeof(int);
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.dataTable1, "Subject")});
        this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.xrTableCell2.StylePriority.UseFont = false;
        this.xrTableCell2.StylePriority.UsePadding = false;
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "xrTableCell2";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell2.Weight = 4.1472430771744557D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.dataTable1, "Locatoin")});
        this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.xrTableCell3.StylePriority.UseFont = false;
        this.xrTableCell3.StylePriority.UsePadding = false;
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        this.xrTableCell3.Text = "xrTableCell3";
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell3.Weight = 0.7444024566640064D;
        // 
        // bottomMarginBand1
        // 
        this.bottomMarginBand1.HeightF = 59.29171F;
        this.bottomMarginBand1.Name = "bottomMarginBand1";
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.BackColor = System.Drawing.Color.Silver;
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabelDay});
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Day", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        this.GroupHeader1.HeightF = 80.70831F;
        this.GroupHeader1.Name = "GroupHeader1";
        this.GroupHeader1.StylePriority.UseBackColor = false;
        // 
        // xrLabelDay
        // 
        this.xrLabelDay.BackColor = System.Drawing.Color.Transparent;
        this.xrLabelDay.CanShrink = true;
        this.xrLabelDay.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.dataTable1, "Day")});
        this.xrLabelDay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.xrLabelDay.LocationFloat = new DevExpress.Utils.PointFloat(53.84301F, 34.375F);
        this.xrLabelDay.Name = "xrLabelDay";
        this.xrLabelDay.SizeF = new System.Drawing.SizeF(200.4166F, 35.29167F);
        this.xrLabelDay.StylePriority.UseBackColor = false;
        this.xrLabelDay.StylePriority.UseFont = false;
        this.xrLabelDay.Text = "xrLabelDay";
        // 
        // PageHeader
        // 
        this.PageHeader.HeightF = 109.7917F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrControlStyle1
        // 
        this.xrControlStyle1.Name = "xrControlStyle1";
        this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        // 
        // dataSet1
        // 
        this.dataSet1.DataSetName = "NewDataSet";
        this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
        // 
        // xrPanel1
        // 
        this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrPanel1.Name = "xrPanel1";
        this.xrPanel1.SizeF = new System.Drawing.SizeF(5.104168F, 2F);
        // 
        // GroupFooter1
        // 
        this.GroupFooter1.HeightF = 40.625F;
        this.GroupFooter1.Name = "GroupFooter1";
        // 
        // ScheduleReport
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.bottomMarginBand1,
            this.topMarginBand1,
            this.detailBand1,
            this.GroupHeader1,
            this.PageHeader,
            this.GroupFooter1});
        this.DataMember = "reportAppointments";
        this.DataSource = this.dataSet1;
        this.FormattingRules.Add(this.formattingRule1);
        this.FormattingRules.Add(this.formattingRule2);
        this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1,
            this.formattingRule2});
        this.Margins = new System.Drawing.Printing.Margins(0, 0, 24, 59);
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
        this.Version = "11.2";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
}

public class SessionPrintAdapter {
    public Session Session { get; protected set; }

    public string Day { get { return StartTime.ToShortDateString(); } }
    public string Time { get { return string.Format("{0} - {1}", StartTime.ToShortTimeString(), Session.EndTime.ToShortTimeString()); } }
    public DateTime StartTime { get { return Session.StartTime; } }
    public string Subject { get { return Session.Subject; } }
    public string Location { get { return Session.Location.ToString(); } }
    public int Important { get { return Session.Interest; } }
    public SessionPrintAdapter(Session curSession) {
        Session = curSession;
    }
}
