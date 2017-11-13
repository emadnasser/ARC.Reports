namespace DevExpress.XtraCharts.Demos.DataAnalysis {

    partial class ErrorBarsDemo {
        System.ComponentModel.IContainer components = null;
        XtraEditors.ComboBoxEdit cbeSeriesView;
        ChartControl chartControl;
        XtraEditors.LabelControl lblSeriesView;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.dataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.cbeSeriesView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSeriesView = new DevExpress.XtraEditors.LabelControl();
            this.lblErrorBarKind = new DevExpress.XtraEditors.LabelControl();
            this.cbeErrorBarsKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEndStyle = new DevExpress.XtraEditors.LabelControl();
            this.cbeEndStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDirection = new DevExpress.XtraEditors.LabelControl();
            this.cbeDirection = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSeriesView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeErrorBarsKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDirection.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbeDirection);
            this.panel.Controls.Add(this.lblDirection);
            this.panel.Controls.Add(this.cbeEndStyle);
            this.panel.Controls.Add(this.lblEndStyle);
            this.panel.Controls.Add(this.cbeErrorBarsKind);
            this.panel.Controls.Add(this.lblErrorBarKind);
            this.panel.Controls.Add(this.lblSeriesView);
            this.panel.Controls.Add(this.cbeSeriesView);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbeSeriesView, 0);
            this.panel.Controls.SetChildIndex(this.lblSeriesView, 0);
            this.panel.Controls.SetChildIndex(this.lblErrorBarKind, 0);
            this.panel.Controls.SetChildIndex(this.cbeErrorBarsKind, 0);
            this.panel.Controls.SetChildIndex(this.lblEndStyle, 0);
            this.panel.Controls.SetChildIndex(this.cbeEndStyle, 0);
            this.panel.Controls.SetChildIndex(this.lblDirection, 0);
            this.panel.Controls.SetChildIndex(this.cbeDirection, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(10000, 1);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "ChartDataSource";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Argument";
            this.dataColumn1.ColumnName = "Argument";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Value";
            this.dataColumn2.DataType = typeof(double);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "PositiveError";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NegativeError";
            this.dataColumn4.DataType = typeof(double);
            // 
            // chartControl
            // 
            this.chartControl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.DataBindings = null;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "65";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(0, 74);
            this.chartControl.Name = "chartControl";
            series1.ArgumentDataMember = "Table1.Argument";
            series1.DataSource = this.dataSet;
            series1.LegendName = "Default Legend";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Table1.Value";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.LegendName = "Default Legend";
            this.chartControl.Size = new System.Drawing.Size(700, 426);
            this.chartControl.TabIndex = 2;
            // 
            // cbeSeriesView
            // 
            this.cbeSeriesView.EditValue = "";
            this.cbeSeriesView.Location = new System.Drawing.Point(88, 9);
            this.cbeSeriesView.Name = "cbeSeriesView";
            this.cbeSeriesView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSeriesView.Properties.DropDownRows = 2;
            this.cbeSeriesView.Properties.Items.AddRange(new object[] {
            "Bar",
            "Point"});
            this.cbeSeriesView.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSeriesView.Size = new System.Drawing.Size(100, 20);
            this.cbeSeriesView.TabIndex = 2;
            this.cbeSeriesView.SelectedIndexChanged += new System.EventHandler(this.cbeSeriesView_SelectedIndexChanged);
            // 
            // lblSeriesView
            // 
            this.lblSeriesView.Location = new System.Drawing.Point(12, 12);
            this.lblSeriesView.Name = "lblSeriesView";
            this.lblSeriesView.Size = new System.Drawing.Size(58, 13);
            this.lblSeriesView.TabIndex = 8;
            this.lblSeriesView.Text = "Series View:";
            // 
            // lblErrorBarKind
            // 
            this.lblErrorBarKind.Location = new System.Drawing.Point(12, 40);
            this.lblErrorBarKind.Name = "lblErrorBarKind";
            this.lblErrorBarKind.Size = new System.Drawing.Size(70, 13);
            this.lblErrorBarKind.TabIndex = 9;
            this.lblErrorBarKind.Text = "Error Bar Kind:";
            // 
            // cbeErrorBarsKind
            // 
            this.cbeErrorBarsKind.Location = new System.Drawing.Point(88, 37);
            this.cbeErrorBarsKind.Name = "cbeErrorBarsKind";
            this.cbeErrorBarsKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeErrorBarsKind.Properties.DropDownRows = 5;
            this.cbeErrorBarsKind.Properties.Items.AddRange(new object[] {
            "Fixed Values",
            "Percentage",
            "Standard Deviation(s)",
            "Standard Error",
            "Data Source"});
            this.cbeErrorBarsKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeErrorBarsKind.Size = new System.Drawing.Size(100, 20);
            this.cbeErrorBarsKind.TabIndex = 10;
            this.cbeErrorBarsKind.SelectedIndexChanged += new System.EventHandler(this.cbeErrorBarsKind_SelectedIndexChanged);
            // 
            // lblEndStyle
            // 
            this.lblEndStyle.Location = new System.Drawing.Point(211, 12);
            this.lblEndStyle.Name = "lblEndStyle";
            this.lblEndStyle.Size = new System.Drawing.Size(49, 13);
            this.lblEndStyle.TabIndex = 11;
            this.lblEndStyle.Text = "End Style:";
            // 
            // cbeEndStyle
            // 
            this.cbeEndStyle.EditValue = "";
            this.cbeEndStyle.Location = new System.Drawing.Point(266, 9);
            this.cbeEndStyle.Name = "cbeEndStyle";
            this.cbeEndStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEndStyle.Properties.DropDownRows = 2;
            this.cbeEndStyle.Properties.Items.AddRange(new object[] {
            "Cap",
            "No Cap"});
            this.cbeEndStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeEndStyle.Size = new System.Drawing.Size(100, 20);
            this.cbeEndStyle.TabIndex = 12;
            this.cbeEndStyle.SelectedIndexChanged += new System.EventHandler(this.cbeEndStyle_SelectedIndexChanged);
            // 
            // lblDirection
            // 
            this.lblDirection.Location = new System.Drawing.Point(211, 40);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(46, 13);
            this.lblDirection.TabIndex = 13;
            this.lblDirection.Text = "Direction:";
            // 
            // cbeDirection
            // 
            this.cbeDirection.EditValue = "";
            this.cbeDirection.Location = new System.Drawing.Point(266, 37);
            this.cbeDirection.Name = "cbeDirection";
            this.cbeDirection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeDirection.Properties.DropDownRows = 3;
            this.cbeDirection.Properties.Items.AddRange(new object[] {
            "Both",
            "Minus",
            "Plus"});
            this.cbeDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeDirection.Size = new System.Drawing.Size(100, 20);
            this.cbeDirection.TabIndex = 14;
            this.cbeDirection.SelectedIndexChanged += new System.EventHandler(this.cbeDirection_SelectedIndexChanged);
            // 
            // ErrorBarsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl);
            this.Name = "ErrorBarsDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chartControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSeriesView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeErrorBarsKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEndStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDirection.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private XtraEditors.ComboBoxEdit cbeErrorBarsKind;
        private XtraEditors.LabelControl lblErrorBarKind;
        private XtraEditors.ComboBoxEdit cbeDirection;
        private XtraEditors.LabelControl lblDirection;
        private XtraEditors.ComboBoxEdit cbeEndStyle;
        private XtraEditors.LabelControl lblEndStyle;
    }

}
