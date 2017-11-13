namespace DevExpress.XtraGrid.Demos {
    partial class Grid100000Records {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid100000Records));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colclnBool = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bindingSource1;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.XtraGrid.Demos.Grid100000Records.Record);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclnId,
            this.colclnText,
            this.colclnDate,
            this.colclnCurrency,
            this.colclnBool});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3")),
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary4"))), resources.GetString("gridView1.GroupSummary5"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary6"))), resources.GetString("gridView1.GroupSummary7"))});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.BestFitMaxRowCount = 20;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridView1_CalcPreviewText);
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            // 
            // colclnId
            // 
            resources.ApplyResources(this.colclnId, "colclnId");
            this.colclnId.FieldName = "Id";
            this.colclnId.Name = "colclnId";
            this.colclnId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colclnId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colclnId.Summary"))), resources.GetString("colclnId.Summary1"), resources.GetString("colclnId.Summary2"))});
            // 
            // colclnText
            // 
            resources.ApplyResources(this.colclnText, "colclnText");
            this.colclnText.FieldName = "Text";
            this.colclnText.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colclnText.Name = "colclnText";
            // 
            // colclnDate
            // 
            resources.ApplyResources(this.colclnDate, "colclnDate");
            this.colclnDate.FieldName = "Date";
            this.colclnDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colclnDate.Name = "colclnDate";
            // 
            // colclnCurrency
            // 
            resources.ApplyResources(this.colclnCurrency, "colclnCurrency");
            this.colclnCurrency.DisplayFormat.FormatString = "c";
            this.colclnCurrency.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colclnCurrency.FieldName = "Currency";
            this.colclnCurrency.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.colclnCurrency.Name = "colclnCurrency";
            this.colclnCurrency.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colclnCurrency.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colclnCurrency.Summary"))), resources.GetString("colclnCurrency.Summary1"), resources.GetString("colclnCurrency.Summary2"))});
            // 
            // colclnBool
            // 
            resources.ApplyResources(this.colclnBool, "colclnBool");
            this.colclnBool.FieldName = "Bool";
            this.colclnBool.Name = "colclnBool";
            // 
            // Grid100000Records
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Grid100000Records";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colclnId;
        private DevExpress.XtraGrid.Columns.GridColumn colclnText;
        private DevExpress.XtraGrid.Columns.GridColumn colclnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colclnCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colclnBool;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
