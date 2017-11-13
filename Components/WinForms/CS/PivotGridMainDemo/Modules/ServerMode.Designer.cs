namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class ServerMode {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.fieldOrderDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
			this.panelDemo = new DevExpress.XtraEditors.PanelControl();
			this.sccPivot = new DevExpress.XtraEditors.SplitContainerControl();
			this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCategoryID = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCustomerName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCustomerID = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderQuerter = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductID = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSalesPersonName = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldSalesPersonID = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldRevenue = new DevExpress.XtraPivotGrid.PivotGridField();
			this.panelFieldCust = new DevExpress.XtraEditors.PanelControl();
			this.headerPanel = new DevExpress.XtraEditors.PanelControl();
			this.btnGenerateDataSource = new DevExpress.XtraEditors.SimpleButton();
			this.lcTimeTaken = new DevExpress.XtraEditors.LabelControl();
			this.lcTimeTakenCaption = new DevExpress.XtraEditors.LabelControl();
			this.panelNoConnection = new DevExpress.XtraEditors.PanelControl();
			this.lcNoConnection = new DevExpress.XtraEditors.LabelControl();
			this.btnGenerateDatasourceLarge = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.panelDemo)).BeginInit();
			this.panelDemo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sccPivot)).BeginInit();
			this.sccPivot.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelFieldCust)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
			this.headerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelNoConnection)).BeginInit();
			this.panelNoConnection.SuspendLayout();
			this.SuspendLayout();
			// 
			// fieldOrderDateYear
			// 
			this.fieldOrderDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderDateYear.AreaIndex = 0;
			this.fieldOrderDateYear.Caption = "Order Year";
			this.fieldOrderDateYear.DisplayFolder = "Order Date";
			this.fieldOrderDateYear.FieldName = "Order.OrderDate";
			this.fieldOrderDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
			this.fieldOrderDateYear.Name = "fieldOrderDateYear";
			this.fieldOrderDateYear.Options.AllowRunTimeSummaryChange = true;
			this.fieldOrderDateYear.UnboundFieldName = "fieldOrderDateYear";
			// 
			// fieldOrderDateMonth
			// 
			this.fieldOrderDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderDateMonth.AreaIndex = 1;
			this.fieldOrderDateMonth.Caption = "Order Month";
			this.fieldOrderDateMonth.DisplayFolder = "Order Date";
			this.fieldOrderDateMonth.FieldName = "Order.OrderDate";
			this.fieldOrderDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
			this.fieldOrderDateMonth.Name = "fieldOrderDateMonth";
			this.fieldOrderDateMonth.Options.AllowRunTimeSummaryChange = true;
			this.fieldOrderDateMonth.UnboundFieldName = "fieldOrderDateMonth";
			this.fieldOrderDateMonth.Visible = false;
			// 
			// panelDemo
			// 
			this.panelDemo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelDemo.Controls.Add(this.sccPivot);
			this.panelDemo.Controls.Add(this.headerPanel);
			this.panelDemo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDemo.Location = new System.Drawing.Point(0, 0);
			this.panelDemo.Name = "panelDemo";
			this.panelDemo.Size = new System.Drawing.Size(784, 432);
			this.panelDemo.TabIndex = 24;
			// 
			// sccPivot
			// 
			this.sccPivot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sccPivot.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
			this.sccPivot.Location = new System.Drawing.Point(0, 29);
			this.sccPivot.Name = "sccPivot";
			this.sccPivot.Panel1.Controls.Add(this.pivotGridControl);
			this.sccPivot.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.sccPivot.Panel1.Text = "Panel1";
			this.sccPivot.Panel2.Controls.Add(this.panelFieldCust);
			this.sccPivot.Panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.sccPivot.Panel2.Text = "Panel2";
			this.sccPivot.Size = new System.Drawing.Size(784, 403);
			this.sccPivot.SplitterPosition = 218;
			this.sccPivot.TabIndex = 26;
			// 
			// pivotGridControl
			// 
			this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldCategoryID,
            this.fieldCustomerName,
            this.fieldCustomerID,
            this.fieldOrderID,
            this.fieldOrderDateYear,
            this.fieldOrderQuerter,
            this.fieldOrderDateMonth,
            this.fieldOrderDate,
            this.fieldProductName,
            this.fieldProductID,
            this.fieldSalesPersonName,
            this.fieldSalesPersonID,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldRevenue});
			this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
			this.pivotGridControl.Name = "pivotGridControl";
			this.pivotGridControl.OptionsBehavior.UseAsyncMode = true;
			this.pivotGridControl.OptionsCustomization.AllowCustomizationForm = false;
			this.pivotGridControl.OptionsCustomization.AllowFilterInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.AllowSortInCustomizationForm = true;
			this.pivotGridControl.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
			this.pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near;
			this.pivotGridControl.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree;
			this.pivotGridControl.OptionsView.RowTreeWidth = 140;
			this.pivotGridControl.OptionsView.ShowColumnHeaders = false;
			this.pivotGridControl.OptionsView.ShowDataHeaders = false;
			this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
			this.pivotGridControl.OptionsView.ShowRowHeaders = false;
			this.pivotGridControl.Size = new System.Drawing.Size(557, 403);
			this.pivotGridControl.TabIndex = 16;
			this.pivotGridControl.AsyncOperationStarting += new System.EventHandler(this.pivotGridControl_AsyncOperationStarting);
			this.pivotGridControl.AsyncOperationCompleted += new System.EventHandler(this.pivotGridControl_AsyncOperationCompleted);
			// 
			// fieldCategoryName
			// 
			this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldCategoryName.AreaIndex = 1;
			this.fieldCategoryName.Caption = "Category";
			this.fieldCategoryName.DisplayFolder = "Product";
			this.fieldCategoryName.FieldName = "Product.Category.CategoryName";
			this.fieldCategoryName.Name = "fieldCategoryName";
			this.fieldCategoryName.Options.AllowRunTimeSummaryChange = true;
			this.fieldCategoryName.Visible = false;
			// 
			// fieldCategoryID
			// 
			this.fieldCategoryID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldCategoryID.AreaIndex = 0;
			this.fieldCategoryID.Caption = "CategoryID";
			this.fieldCategoryID.DisplayFolder = "Product";
			this.fieldCategoryID.FieldName = "Product.CategoryID";
			this.fieldCategoryID.Name = "fieldCategoryID";
			this.fieldCategoryID.Options.AllowRunTimeSummaryChange = true;
			this.fieldCategoryID.Visible = false;
			// 
			// fieldCustomerName
			// 
			this.fieldCustomerName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldCustomerName.AreaIndex = 0;
			this.fieldCustomerName.Caption = "Customer";
			this.fieldCustomerName.DisplayFolder = "Customer";
			this.fieldCustomerName.FieldName = "Order.Customer.CustomerName";
			this.fieldCustomerName.Name = "fieldCustomerName";
			this.fieldCustomerName.Options.AllowRunTimeSummaryChange = true;
			this.fieldCustomerName.Visible = false;
			// 
			// fieldCustomerID
			// 
			this.fieldCustomerID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldCustomerID.AreaIndex = 0;
			this.fieldCustomerID.Caption = "CustomerID";
			this.fieldCustomerID.DisplayFolder = "Customer";
			this.fieldCustomerID.FieldName = "Order.CustomerID";
			this.fieldCustomerID.Name = "fieldCustomerID";
			this.fieldCustomerID.Options.AllowRunTimeSummaryChange = true;
			this.fieldCustomerID.Visible = false;
			// 
			// fieldOrderID
			// 
			this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderID.AreaIndex = 0;
			this.fieldOrderID.Caption = "OrderID";
			this.fieldOrderID.DisplayFolder = "Order";
			this.fieldOrderID.FieldName = "OrderID";
			this.fieldOrderID.Name = "fieldOrderID";
			this.fieldOrderID.Options.AllowRunTimeSummaryChange = true;
			this.fieldOrderID.Visible = false;
			// 
			// fieldOrderQuerter
			// 
			this.fieldOrderQuerter.AreaIndex = 0;
			this.fieldOrderQuerter.Caption = "Order Querter";
			this.fieldOrderQuerter.DisplayFolder = "Order Date";
			this.fieldOrderQuerter.FieldName = "Order.OrderDate";
			this.fieldOrderQuerter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
			this.fieldOrderQuerter.Name = "fieldOrderQuerter";
			this.fieldOrderQuerter.UnboundFieldName = "fieldOrderQuerter";
			this.fieldOrderQuerter.Visible = false;
			// 
			// fieldOrderDate
			// 
			this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldOrderDate.AreaIndex = 0;
			this.fieldOrderDate.Caption = "Order Date";
			this.fieldOrderDate.DisplayFolder = "Order Date";
			this.fieldOrderDate.FieldName = "Order.OrderDate";
			this.fieldOrderDate.Name = "fieldOrderDate";
			this.fieldOrderDate.Options.AllowRunTimeSummaryChange = true;
			this.fieldOrderDate.Visible = false;
			// 
			// fieldProductName
			// 
			this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductName.AreaIndex = 0;
			this.fieldProductName.Caption = "Product";
			this.fieldProductName.DisplayFolder = "Product";
			this.fieldProductName.FieldName = "Product.ProductName";
			this.fieldProductName.Name = "fieldProductName";
			this.fieldProductName.Options.AllowRunTimeSummaryChange = true;
			// 
			// fieldProductID
			// 
			this.fieldProductID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldProductID.AreaIndex = 0;
			this.fieldProductID.Caption = "ProductID";
			this.fieldProductID.DisplayFolder = "Product";
			this.fieldProductID.FieldName = "ProductID";
			this.fieldProductID.Name = "fieldProductID";
			this.fieldProductID.Options.AllowRunTimeSummaryChange = true;
			this.fieldProductID.Visible = false;
			// 
			// fieldSalesPersonName
			// 
			this.fieldSalesPersonName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldSalesPersonName.AreaIndex = 1;
			this.fieldSalesPersonName.Caption = "Sales Person";
			this.fieldSalesPersonName.DisplayFolder = "Sales Person";
			this.fieldSalesPersonName.FieldName = "Order.SalesPerson.SalesPersonName";
			this.fieldSalesPersonName.Name = "fieldSalesPersonName";
			this.fieldSalesPersonName.Options.AllowRunTimeSummaryChange = true;
			// 
			// fieldSalesPersonID
			// 
			this.fieldSalesPersonID.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldSalesPersonID.AreaIndex = 0;
			this.fieldSalesPersonID.Caption = "SalesPersonID";
			this.fieldSalesPersonID.DisplayFolder = "Sales Person";
			this.fieldSalesPersonID.FieldName = "Order.SalesPersonID";
			this.fieldSalesPersonID.Name = "fieldSalesPersonID";
			this.fieldSalesPersonID.Options.AllowRunTimeSummaryChange = true;
			this.fieldSalesPersonID.Visible = false;
			// 
			// fieldUnitPrice
			// 
			this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldUnitPrice.AreaIndex = 1;
			this.fieldUnitPrice.Caption = "UnitPrice";
			this.fieldUnitPrice.DisplayFolder = "Order";
			this.fieldUnitPrice.FieldName = "UnitPrice";
			this.fieldUnitPrice.Name = "fieldUnitPrice";
			this.fieldUnitPrice.Options.AllowRunTimeSummaryChange = true;
			// 
			// fieldQuantity
			// 
			this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldQuantity.AreaIndex = 0;
			this.fieldQuantity.Caption = "Quantity";
			this.fieldQuantity.DisplayFolder = "Order";
			this.fieldQuantity.FieldName = "Quantity";
			this.fieldQuantity.Name = "fieldQuantity";
			this.fieldQuantity.Options.AllowRunTimeSummaryChange = true;
			// 
			// fieldRevenue
			// 
			this.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldRevenue.AreaIndex = 2;
			this.fieldRevenue.Caption = "Revenue";
			this.fieldRevenue.DisplayFolder = "Order";
			this.fieldRevenue.Name = "fieldRevenue";
			this.fieldRevenue.UnboundExpression = "[UnitPrice]*[Quantity]";
			this.fieldRevenue.UnboundFieldName = "fieldRevenue";
			this.fieldRevenue.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			// 
			// panelFieldCust
			// 
			this.panelFieldCust.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelFieldCust.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelFieldCust.Location = new System.Drawing.Point(4, 0);
			this.panelFieldCust.Name = "panelFieldCust";
			this.panelFieldCust.Size = new System.Drawing.Size(214, 403);
			this.panelFieldCust.TabIndex = 26;
			// 
			// headerPanel
			// 
			this.headerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.headerPanel.Controls.Add(this.btnGenerateDataSource);
			this.headerPanel.Controls.Add(this.lcTimeTaken);
			this.headerPanel.Controls.Add(this.lcTimeTakenCaption);
			this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(784, 29);
			this.headerPanel.TabIndex = 25;
			// 
			// btnGenerateDataSource
			// 
			this.btnGenerateDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateDataSource.Location = new System.Drawing.Point(676, 2);
			this.btnGenerateDataSource.Name = "btnGenerateDataSource";
			this.btnGenerateDataSource.Size = new System.Drawing.Size(105, 23);
			this.btnGenerateDataSource.TabIndex = 9;
			this.btnGenerateDataSource.Text = "Generate Database";
			this.btnGenerateDataSource.Click += new System.EventHandler(this.btnGenerateDataSource_Click);
			// 
			// lcTimeTaken
			// 
			this.lcTimeTaken.Location = new System.Drawing.Point(179, 8);
			this.lcTimeTaken.Name = "lcTimeTaken";
			this.lcTimeTaken.Size = new System.Drawing.Size(0, 13);
			this.lcTimeTaken.TabIndex = 8;
			// 
			// lcTimeTakenCaption
			// 
			this.lcTimeTakenCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.lcTimeTakenCaption.Location = new System.Drawing.Point(4, 8);
			this.lcTimeTakenCaption.Name = "lcTimeTakenCaption";
			this.lcTimeTakenCaption.Size = new System.Drawing.Size(170, 13);
			this.lcTimeTakenCaption.TabIndex = 4;
			this.lcTimeTakenCaption.Text = "Data Recalculation Time (ms):";
			// 
			// panelNoConnection
			// 
			this.panelNoConnection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelNoConnection.Controls.Add(this.lcNoConnection);
			this.panelNoConnection.Controls.Add(this.btnGenerateDatasourceLarge);
			this.panelNoConnection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNoConnection.Location = new System.Drawing.Point(0, 0);
			this.panelNoConnection.Name = "panelNoConnection";
			this.panelNoConnection.Size = new System.Drawing.Size(784, 432);
			this.panelNoConnection.TabIndex = 25;
			// 
			// lcNoConnection
			// 
			this.lcNoConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lcNoConnection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lcNoConnection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.lcNoConnection.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.lcNoConnection.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.lcNoConnection.Location = new System.Drawing.Point(15, 230);
			this.lcNoConnection.Name = "lcNoConnection";
			this.lcNoConnection.Size = new System.Drawing.Size(754, 13);
			this.lcNoConnection.TabIndex = 4;
			this.lcNoConnection.Text = "This demo requires a large database. To create a sample database, click the Creat" +
    "e Database and Start Demo button.";
			// 
			// btnGenerateDatasourceLarge
			// 
			this.btnGenerateDatasourceLarge.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnGenerateDatasourceLarge.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
			this.btnGenerateDatasourceLarge.Location = new System.Drawing.Point(271, 181);
			this.btnGenerateDatasourceLarge.Name = "btnGenerateDatasourceLarge";
			this.btnGenerateDatasourceLarge.Size = new System.Drawing.Size(244, 43);
			this.btnGenerateDatasourceLarge.TabIndex = 25;
			this.btnGenerateDatasourceLarge.Text = "Create Database and Start Demo";
			this.btnGenerateDatasourceLarge.Click += new System.EventHandler(this.btnGenerateDatasourceLarge_Click);
			// 
			// ServerMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelNoConnection);
			this.Controls.Add(this.panelDemo);
			this.Name = "ServerMode";
			this.Load += new System.EventHandler(this.ServerMode_Load);
			((System.ComponentModel.ISupportInitialize)(this.panelDemo)).EndInit();
			this.panelDemo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sccPivot)).EndInit();
			this.sccPivot.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelFieldCust)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelNoConnection)).EndInit();
			this.panelNoConnection.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.PanelControl panelDemo;
        private XtraEditors.PanelControl headerPanel;
        private XtraEditors.LabelControl lcTimeTaken;
        private XtraEditors.PanelControl panelNoConnection;
        private XtraEditors.SplitContainerControl sccPivot;
        private PivotGridControl pivotGridControl;
        private PivotGridField fieldOrderID;
        private PivotGridField fieldProductID;
        private PivotGridField fieldQuantity;
        private PivotGridField fieldUnitPrice;
        private PivotGridField fieldSalesPersonID;
        private PivotGridField fieldCustomerID;
        private PivotGridField fieldOrderDate;
        private PivotGridField fieldOrderDateYear;
        private PivotGridField fieldOrderDateMonth;
        private PivotGridField fieldProductName;
        private PivotGridField fieldCategoryID;
        private PivotGridField fieldSalesPersonName;
        private PivotGridField fieldCustomerName;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldRevenue;
        private XtraEditors.LabelControl lcNoConnection;
        private XtraEditors.SimpleButton btnGenerateDataSource;
        private XtraEditors.SimpleButton btnGenerateDatasourceLarge;
        private PivotGridField fieldOrderQuerter;
        private XtraEditors.LabelControl lcTimeTakenCaption;
		private XtraEditors.PanelControl panelFieldCust;



    }
}
