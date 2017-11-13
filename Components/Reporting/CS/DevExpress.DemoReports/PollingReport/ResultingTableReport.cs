using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.PollingReport {
    public class ResultingTableReport : XtraReport {
        private TopMarginBand topMarginBand1;
        private DetailBand detailBand1;
        private System.ComponentModel.IContainer components;
        private BottomMarginBand bottomMarginBand1;
        private XRTable dtlTable1;
        private XRTableRow detailTableRow;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTable ghTable1;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter paramQuestionID;
        private XRControlStyle questionStyle;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell8;
        private XRControlStyle headerStyle;
        private XRControlStyle detailStyleEven;
        private XRTableCell xrTableCell12;
        internal DevExpress.DataAccess.ObjectBinding.ObjectDataSource ResultingTableReportDS;
        private GroupHeaderBand GroupHeader1;
        private XRLabel xrLabel1;
        private XRControlStyle detailStyleOdd;
        private XRTableCell xrTableCell5;
        private XRShape xrShape1;
        private System.Drawing.Color emptyAnswerTextColor;

        internal List<Color> Colors { get; set; }

        public ResultingTableReport() {
            InitializeComponent();
            emptyAnswerTextColor = detailTableRow.ForeColor;
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.Shape.ShapeRectangle shapeRectangle1 = new DevExpress.XtraPrinting.Shape.ShapeRectangle();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.dtlTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrShape1 = new DevExpress.XtraReports.UI.XRShape();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ghTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.paramQuestionID = new DevExpress.XtraReports.Parameters.Parameter();
            this.questionStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.headerStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detailStyleEven = new DevExpress.XtraReports.UI.XRControlStyle();
            this.detailStyleOdd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.ResultingTableReportDS = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtlTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingTableReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Dpi = 100F;
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.dtlTable1});
            this.detailBand1.Dpi = 100F;
            this.detailBand1.HeightF = 30F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.StylePriority.UseFont = false;
            // 
            // dtlTable1
            // 
            this.dtlTable1.Dpi = 100F;
            this.dtlTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.dtlTable1.Name = "dtlTable1";
            this.dtlTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow});
            this.dtlTable1.SizeF = new System.Drawing.SizeF(325F, 30F);
            this.dtlTable1.StylePriority.UseTextAlignment = false;
            this.dtlTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // detailTableRow
            // 
            this.detailTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.detailTableRow.Dpi = 100F;
            this.detailTableRow.EvenStyleName = "detailStyleEven";
            this.detailTableRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.detailTableRow.Name = "detailTableRow";
            this.detailTableRow.OddStyleName = "detailStyleOdd";
            this.detailTableRow.StylePriority.UseForeColor = false;
            this.detailTableRow.Weight = 1D;
            this.detailTableRow.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.detailTableRow_BeforePrint);
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrShape1});
            this.xrTableCell5.Dpi = 100F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Weight = 0.26494085357768737D;
            // 
            // xrShape1
            // 
            this.xrShape1.Dpi = 100F;
            this.xrShape1.ForeColor = System.Drawing.Color.Transparent;
            this.xrShape1.LocationFloat = new DevExpress.Utils.PointFloat(5F, 2.5F);
            this.xrShape1.Name = "xrShape1";
            this.xrShape1.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrShape1.Shape = shapeRectangle1;
            this.xrShape1.SizeF = new System.Drawing.SizeF(24.99998F, 25F);
            this.xrShape1.StylePriority.UseForeColor = false;
            this.xrShape1.StylePriority.UsePadding = false;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Answer")});
            this.xrTableCell1.Dpi = 100F;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 1.5749258970746736D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AnswerCount")});
            this.xrTableCell2.Dpi = 100F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 0.45996698152369797D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AnswerCount")});
            this.xrTableCell3.Dpi = 100F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:0.0%}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Percentage;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell3.Summary = xrSummary1;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 0.5703587583536065D;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Dpi = 100F;
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ghTable1
            // 
            this.ghTable1.Dpi = 100F;
            this.ghTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.ghTable1.Name = "ghTable1";
            this.ghTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow4});
            this.ghTable1.SizeF = new System.Drawing.SizeF(325F, 63.54F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4});
            this.xrTableRow2.Dpi = 100F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseTextAlignment = false;
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow2.Weight = 1.7039473665263247D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.xrTableCell4.Dpi = 100F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Weight = 3.8269230769230766D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Question")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.SizeF = new System.Drawing.SizeF(325F, 25F);
            this.xrLabel1.StyleName = "questionStyle";
            this.xrLabel1.StylePriority.UsePadding = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell8,
            this.xrTableCell6});
            this.xrTableRow4.Dpi = 100F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StyleName = "headerStyle";
            this.xrTableRow4.StylePriority.UseTextAlignment = false;
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow4.Weight = 1.1052630062961615D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Dpi = 100F;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell12.Weight = 2.2579717305482263D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Dpi = 100F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorderColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Voted";
            this.xrTableCell8.Weight = 0.56449296046847441D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 100F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Percent";
            this.xrTableCell6.Weight = 0.69997138007444848D;
            // 
            // paramQuestionID
            // 
            this.paramQuestionID.Description = "Question ID";
            this.paramQuestionID.Name = "paramQuestionID";
            this.paramQuestionID.Type = typeof(int);
            this.paramQuestionID.ValueInfo = "0";
            this.paramQuestionID.Visible = false;
            // 
            // questionStyle
            // 
            this.questionStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.questionStyle.Name = "questionStyle";
            this.questionStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // headerStyle
            // 
            this.headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.headerStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerStyle.ForeColor = System.Drawing.Color.White;
            this.headerStyle.Name = "headerStyle";
            this.headerStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // detailStyleEven
            // 
            this.detailStyleEven.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailStyleEven.Name = "detailStyleEven";
            // 
            // detailStyleOdd
            // 
            this.detailStyleOdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.detailStyleOdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailStyleOdd.Name = "detailStyleOdd";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ghTable1});
            this.GroupHeader1.Dpi = 100F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("QuestionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 63.54168F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // ResultingTableReportDS
            // 
            this.ResultingTableReportDS.DataMember = "";
            this.ResultingTableReportDS.DataSource = typeof(XtraReportsDemos.PollingReport.ResultingData);
            this.ResultingTableReportDS.Name = "ResultingTableReportDS";
            // 
            // ResultingTableReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ResultingTableReportDS});
            this.DataSource = this.ResultingTableReportDS;
            this.FilterString = "[QuestionID] = ?paramQuestionID";
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramQuestionID});
            this.SnappingMode = ((DevExpress.XtraReports.UI.SnappingMode)((DevExpress.XtraReports.UI.SnappingMode.SnapLines | DevExpress.XtraReports.UI.SnappingMode.SnapToGrid)));
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.questionStyle,
            this.headerStyle,
            this.detailStyleEven,
            this.detailStyleOdd});
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(this.dtlTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingTableReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void detailTableRow_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            int voted = Report.GetCurrentColumnValue<int>("AnswerCount");
            if(Colors == null || Colors.Count == 0) {
                detailTableRow.ForeColor = voted > 0 ? Color.Black : emptyAnswerTextColor;
                xrShape1.FillColor = System.Drawing.Color.Transparent;
            } else if(voted > 0) {
                int colorIndex = Report.CurrentRowIndex % Colors.Count;
                detailTableRow.ForeColor = xrShape1.FillColor = Colors[colorIndex];
            } else {
                detailTableRow.ForeColor = emptyAnswerTextColor;
                xrShape1.FillColor = System.Drawing.Color.Transparent;
            }
        }
    }
}
