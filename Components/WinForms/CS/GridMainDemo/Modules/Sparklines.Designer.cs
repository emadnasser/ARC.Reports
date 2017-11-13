namespace DevExpress.XtraGrid.Demos {
    partial class Sparklines {
        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sparklines));
            DevExpress.Sparkline.LineSparklineView lineSparklineView1 = new DevExpress.Sparkline.LineSparklineView();
            this.dsContacts1 = new DevExpress.XtraGrid.Demos.dsContacts();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowAvr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Payments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSparklineEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ceColor = new DevExpress.XtraEditors.ColorPickEdit();
            this.ceMax = new DevExpress.XtraEditors.ColorPickEdit();
            this.ceEnd = new DevExpress.XtraEditors.ColorPickEdit();
            this.ceMin = new DevExpress.XtraEditors.ColorPickEdit();
            this.ceStart = new DevExpress.XtraEditors.ColorPickEdit();
            this.cheHighlightEndPoint = new DevExpress.XtraEditors.CheckEdit();
            this.cheHighlightStartPoint = new DevExpress.XtraEditors.CheckEdit();
            this.cheHighlightMinPoint = new DevExpress.XtraEditors.CheckEdit();
            this.cheHighlightMaxPoint = new DevExpress.XtraEditors.CheckEdit();
            this.cbeView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblView = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelView = new System.Windows.Forms.Label();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightEndPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightStartPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightMinPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightMaxPoint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsContacts1
            // 
            this.dsContacts1.DataSetName = "dsContacts";
            this.dsContacts1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsContacts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.dsContacts1.CustomersPayment;
            resources.ApplyResources(this.gridControl, "gridControl");
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSparklineEdit1});
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCustomerName,
            this.colYear,
            this.colRowSum,
            this.colRowAvr,
            this.Payments});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.HorzScrollStep = 25;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsPrint.AutoWidth = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colYear, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView_CustomUnboundColumnData);
            this.gridView.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            // 
            // colCustomerName
            // 
            resources.ApplyResources(this.colCustomerName, "colCustomerName");
            this.colCustomerName.FieldName = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.OptionsColumn.AllowFocus = false;
            this.colCustomerName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCustomerName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colCustomerName.Summary"))))});
            // 
            // colYear
            // 
            this.colYear.AppearanceCell.BackColor = ((System.Drawing.Color)(resources.GetObject("colYear.AppearanceCell.BackColor")));
            this.colYear.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colYear.AppearanceCell.Font")));
            this.colYear.AppearanceCell.ForeColor = ((System.Drawing.Color)(resources.GetObject("colYear.AppearanceCell.ForeColor")));
            this.colYear.AppearanceCell.Options.UseBackColor = true;
            this.colYear.AppearanceCell.Options.UseFont = true;
            this.colYear.AppearanceCell.Options.UseForeColor = true;
            resources.ApplyResources(this.colYear, "colYear");
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.AllowEdit = false;
            this.colYear.OptionsColumn.AllowFocus = false;
            this.colYear.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colYear.OptionsColumn.AllowMove = false;
            this.colYear.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // colRowSum
            // 
            resources.ApplyResources(this.colRowSum, "colRowSum");
            this.colRowSum.DisplayFormat.FormatString = "c";
            this.colRowSum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRowSum.FieldName = "RowSum";
            this.colRowSum.Name = "colRowSum";
            this.colRowSum.OptionsColumn.AllowEdit = false;
            this.colRowSum.OptionsColumn.AllowFocus = false;
            this.colRowSum.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colRowSum.Summary"))), resources.GetString("colRowSum.Summary1"), resources.GetString("colRowSum.Summary2"))});
            // 
            // colRowAvr
            // 
            resources.ApplyResources(this.colRowAvr, "colRowAvr");
            this.colRowAvr.DisplayFormat.FormatString = "c";
            this.colRowAvr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRowAvr.FieldName = "RowAvr";
            this.colRowAvr.Name = "colRowAvr";
            this.colRowAvr.OptionsColumn.AllowEdit = false;
            this.colRowAvr.OptionsColumn.AllowFocus = false;
            this.colRowAvr.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colRowAvr.Summary"))), resources.GetString("colRowAvr.Summary1"), resources.GetString("colRowAvr.Summary2"))});
            // 
            // Payments
            // 
            resources.ApplyResources(this.Payments, "Payments");
            this.Payments.ColumnEdit = this.repositoryItemSparklineEdit1;
            this.Payments.FieldName = "colSparkline";
            this.Payments.Image = ((System.Drawing.Image)(resources.GetObject("Payments.Image")));
            this.Payments.MaxWidth = 300;
            this.Payments.MinWidth = 50;
            this.Payments.Name = "Payments";
            this.Payments.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            // 
            // repositoryItemSparklineEdit1
            // 
            this.repositoryItemSparklineEdit1.Name = "repositoryItemSparklineEdit1";
            lineSparklineView1.HighlightMaxPoint = true;
            lineSparklineView1.HighlightMinPoint = true;
            this.repositoryItemSparklineEdit1.View = lineSparklineView1;
            // 
            // xtraScrollableControl1
            // 
            resources.ApplyResources(this.xtraScrollableControl1, "xtraScrollableControl1");
            this.xtraScrollableControl1.Controls.Add(this.ceColor);
            this.xtraScrollableControl1.Controls.Add(this.ceMax);
            this.xtraScrollableControl1.Controls.Add(this.ceEnd);
            this.xtraScrollableControl1.Controls.Add(this.ceMin);
            this.xtraScrollableControl1.Controls.Add(this.ceStart);
            this.xtraScrollableControl1.Controls.Add(this.cheHighlightEndPoint);
            this.xtraScrollableControl1.Controls.Add(this.cheHighlightStartPoint);
            this.xtraScrollableControl1.Controls.Add(this.cheHighlightMinPoint);
            this.xtraScrollableControl1.Controls.Add(this.cheHighlightMaxPoint);
            this.xtraScrollableControl1.Controls.Add(this.cbeView);
            this.xtraScrollableControl1.Controls.Add(this.lblView);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            // 
            // ceColor
            // 
            resources.ApplyResources(this.ceColor, "ceColor");
            this.ceColor.Name = "ceColor";
            this.ceColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ceColor.Properties.Buttons"))))});
            this.ceColor.EditValueChanged += new System.EventHandler(this.ceColor_EditValueChanged);
            // 
            // ceMax
            // 
            resources.ApplyResources(this.ceMax, "ceMax");
            this.ceMax.Name = "ceMax";
            this.ceMax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ceMax.Properties.Buttons"))))});
            this.ceMax.EditValueChanged += new System.EventHandler(this.ceMax_EditValueChanged);
            // 
            // ceEnd
            // 
            resources.ApplyResources(this.ceEnd, "ceEnd");
            this.ceEnd.Name = "ceEnd";
            this.ceEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ceEnd.Properties.Buttons"))))});
            this.ceEnd.EditValueChanged += new System.EventHandler(this.ceEnd_EditValueChanged);
            // 
            // ceMin
            // 
            resources.ApplyResources(this.ceMin, "ceMin");
            this.ceMin.Name = "ceMin";
            this.ceMin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ceMin.Properties.Buttons"))))});
            this.ceMin.EditValueChanged += new System.EventHandler(this.ceMin_EditValueChanged);
            // 
            // ceStart
            // 
            resources.ApplyResources(this.ceStart, "ceStart");
            this.ceStart.Name = "ceStart";
            this.ceStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("ceStart.Properties.Buttons"))))});
            this.ceStart.EditValueChanged += new System.EventHandler(this.ceStart_EditValueChanged);
            // 
            // cheHighlightEndPoint
            // 
            resources.ApplyResources(this.cheHighlightEndPoint, "cheHighlightEndPoint");
            this.cheHighlightEndPoint.Name = "cheHighlightEndPoint";
            this.cheHighlightEndPoint.Properties.AutoWidth = true;
            this.cheHighlightEndPoint.Properties.Caption = resources.GetString("cheHighlightEndPoint.Properties.Caption");
            this.cheHighlightEndPoint.CheckedChanged += new System.EventHandler(this.cheHighlightEndPoint_CheckedChanged);
            // 
            // cheHighlightStartPoint
            // 
            resources.ApplyResources(this.cheHighlightStartPoint, "cheHighlightStartPoint");
            this.cheHighlightStartPoint.Name = "cheHighlightStartPoint";
            this.cheHighlightStartPoint.Properties.AutoWidth = true;
            this.cheHighlightStartPoint.Properties.Caption = resources.GetString("cheHighlightStartPoint.Properties.Caption");
            this.cheHighlightStartPoint.CheckedChanged += new System.EventHandler(this.cheHighlightStartPoint_CheckedChanged);
            // 
            // cheHighlightMinPoint
            // 
            resources.ApplyResources(this.cheHighlightMinPoint, "cheHighlightMinPoint");
            this.cheHighlightMinPoint.Name = "cheHighlightMinPoint";
            this.cheHighlightMinPoint.Properties.AutoWidth = true;
            this.cheHighlightMinPoint.Properties.Caption = resources.GetString("cheHighlightMinPoint.Properties.Caption");
            this.cheHighlightMinPoint.CheckedChanged += new System.EventHandler(this.cheHighlightMinPoint_CheckedChanged);
            // 
            // cheHighlightMaxPoint
            // 
            resources.ApplyResources(this.cheHighlightMaxPoint, "cheHighlightMaxPoint");
            this.cheHighlightMaxPoint.Name = "cheHighlightMaxPoint";
            this.cheHighlightMaxPoint.Properties.AutoWidth = true;
            this.cheHighlightMaxPoint.Properties.Caption = resources.GetString("cheHighlightMaxPoint.Properties.Caption");
            this.cheHighlightMaxPoint.CheckedChanged += new System.EventHandler(this.cheHighlightMaxPoint_CheckedChanged);
            // 
            // cbeView
            // 
            resources.ApplyResources(this.cbeView, "cbeView");
            this.cbeView.Name = "cbeView";
            this.cbeView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbeView.Properties.Buttons"))))});
            this.cbeView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeView.SelectedIndexChanged += new System.EventHandler(this.cbeView_SelectedIndexChanged);
            // 
            // lblView
            // 
            resources.ApplyResources(this.lblView, "lblView");
            this.lblView.Name = "lblView";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // labelView
            // 
            resources.ApplyResources(this.labelView, "labelView");
            this.labelView.Name = "labelView";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraScrollableControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // Sparklines
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Sparklines";
            this.Load += new System.EventHandler(this.Sparklines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsContacts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSparklineEdit1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightEndPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightStartPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightMinPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheHighlightMaxPoint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Demos.dsContacts dsContacts1;
        private GridControl gridControl;
        private XtraEditors.Repository.RepositoryItemSparklineEdit repositoryItemSparklineEdit1;
        private Views.Grid.GridView gridView;
        private Columns.GridColumn colID;
        private Columns.GridColumn colCustomerName;
        private Columns.GridColumn colYear;
        private Columns.GridColumn Payments;
        private Columns.GridColumn colRowSum;
        private Columns.GridColumn colRowAvr;
        private XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Label lblView;
        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.ComboBoxEdit cbeView;
        private System.Windows.Forms.Label labelView;
        private XtraEditors.CheckEdit cheHighlightEndPoint;
        private XtraEditors.CheckEdit cheHighlightStartPoint;
        private XtraEditors.CheckEdit cheHighlightMinPoint;
        private XtraEditors.CheckEdit cheHighlightMaxPoint;
        private XtraEditors.PanelControl panel1;
        private XtraEditors.PanelControl panelControl2;
        private XtraEditors.ColorPickEdit ceMax;
        private XtraEditors.ColorPickEdit ceEnd;
        private XtraEditors.ColorPickEdit ceMin;
        private XtraEditors.ColorPickEdit ceStart;
        private XtraEditors.ColorPickEdit ceColor;
    }
}
