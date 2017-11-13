namespace XtraReportsDemos.SideBySideReports {
    partial class EmployeeComparisonReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeComparisonReport));
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings1 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            DevExpress.XtraReports.Parameters.DynamicListLookUpSettings dynamicListLookUpSettings2 = new DevExpress.XtraReports.Parameters.DynamicListLookUpSettings();
            this.dsEmployee1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.rightSideParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.leftSideParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbCaption = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dsEmployee1
            // 
            this.dsEmployee1.ConnectionName = "NWindConnectionString";
            this.dsEmployee1.Name = "dsEmployee1";
            customSqlQuery1.Name = "SimpleEmployees";
            customSqlQuery1.Sql = "SELECT EmployeeID, FirstName || \' \' || LastName AS FullName FROM Employees";
            this.dsEmployee1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.dsEmployee1.ResultSchemaSerializable = resources.GetString("dsEmployee1.ResultSchemaSerializable");
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport2,
            this.xrSubreport1});
            this.Detail.HeightF = 375F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrSubreport2
            // 
            this.xrSubreport2.LocationFloat = new DevExpress.Utils.PointFloat(332F, 0F);
            this.xrSubreport2.Name = "xrSubreport2";
            this.xrSubreport2.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", this.rightSideParameter));
            this.xrSubreport2.ReportSource = new XtraReportsDemos.SideBySideReports.EmployeeOrdersReport();
            this.xrSubreport2.SizeF = new System.Drawing.SizeF(318F, 375F);
            // 
            // rightSideParameter
            // 
            this.rightSideParameter.Description = "Right Side:";
            dynamicListLookUpSettings1.DataAdapter = null;
            dynamicListLookUpSettings1.DataMember = "SimpleEmployees";
            dynamicListLookUpSettings1.DataSource = this.dsEmployee1;
            dynamicListLookUpSettings1.DisplayMember = "FullName";
            dynamicListLookUpSettings1.FilterString = "[EmployeeID] <> ?leftSideParameter";
            dynamicListLookUpSettings1.ValueMember = "EmployeeID";
            this.rightSideParameter.LookUpSettings = dynamicListLookUpSettings1;
            this.rightSideParameter.Name = "rightSideParameter";
            this.rightSideParameter.Type = typeof(long);
            this.rightSideParameter.ValueInfo = "9";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", this.leftSideParameter));
            this.xrSubreport1.ReportSource = new XtraReportsDemos.SideBySideReports.EmployeeOrdersReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(318F, 375F);
            // 
            // leftSideParameter
            // 
            this.leftSideParameter.Description = "Left Side:";
            dynamicListLookUpSettings2.DataAdapter = null;
            dynamicListLookUpSettings2.DataMember = "SimpleEmployees";
            dynamicListLookUpSettings2.DataSource = this.dsEmployee1;
            dynamicListLookUpSettings2.DisplayMember = "FullName";
            dynamicListLookUpSettings2.FilterString = null;
            dynamicListLookUpSettings2.ValueMember = "EmployeeID";
            this.leftSideParameter.LookUpSettings = dynamicListLookUpSettings2;
            this.leftSideParameter.Name = "leftSideParameter";
            this.leftSideParameter.Type = typeof(long);
            this.leftSideParameter.ValueInfo = "5";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbCaption});
            this.ReportHeader.HeightF = 75F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbCaption
            // 
            this.lbCaption.BackColor = System.Drawing.Color.Transparent;
            this.lbCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCaption.BorderWidth = 2F;
            this.lbCaption.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.lbCaption.ForeColor = System.Drawing.Color.Black;
            this.lbCaption.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCaption.SizeF = new System.Drawing.SizeF(650F, 50F);
            this.lbCaption.Text = "Employee Comparison";
            this.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox4.Image")));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(249F, 22F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // EmployeeComparisonReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 75);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.leftSideParameter,
            this.rightSideParameter});
            this.RequestParameters = false;
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        public DevExpress.XtraReports.UI.XRSubreport xrSubreport2;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        internal DevExpress.XtraReports.UI.XRPictureBox xrPictureBox4;
        private DevExpress.XtraReports.UI.XRLabel lbCaption;
		private DevExpress.XtraReports.Parameters.Parameter leftSideParameter;
		private DevExpress.XtraReports.Parameters.Parameter rightSideParameter;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.DataAccess.Sql.SqlDataSource dsEmployee1;
    }
}
