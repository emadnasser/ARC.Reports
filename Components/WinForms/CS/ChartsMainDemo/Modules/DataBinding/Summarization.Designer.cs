namespace DevExpress.XtraCharts.Demos.DataBinding {
	partial class SummarizationDemo {
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.BarGrowUpAnimation barGrowUpAnimation1 = new DevExpress.XtraCharts.BarGrowUpAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummarizationDemo));
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.labelFunction = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dS41 = new DevExpress.XtraCharts.Demos.DS4();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS41)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelFunction);
            this.panel.Controls.Add(this.comboBoxFunction);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxFunction, 0);
            this.panel.Controls.SetChildIndex(this.labelFunction, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.DataAdapter = this.oleDbDataAdapter1;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Title.Text = "Categories";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "Volume (USD)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "CategoryName";
            sideBySideBarSeriesLabel1.LineLength = 20;
            sideBySideBarSeriesLabel1.TextPattern = "{V:N0}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Quantity";
            series1.SummaryFunction = "SUM([Sum])";
            barGrowUpAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.3000000");
            sideBySideBarSeriesView1.Animation = barGrowUpAnimation1;
            sideBySideBarSeriesView1.ColorEach = true;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Sum", "Sum")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // labelFunction
            // 
            this.labelFunction.Location = new System.Drawing.Point(12, 12);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(90, 13);
            this.labelFunction.TabIndex = 56;
            this.labelFunction.Text = "Summary function:";
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.Location = new System.Drawing.Point(105, 9);
            this.comboBoxFunction.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxFunction.Properties.Items.AddRange(new object[] {
            "SUM",
            "MIN",
            "MAX",
            "AVERAGE",
            "COUNT",
            "STDDEV (Custom)"});
            this.comboBoxFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxFunction.Size = new System.Drawing.Size(120, 20);
            this.comboBoxFunction.TabIndex = 0;
            this.comboBoxFunction.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // dS41
            // 
            this.dS41.DataSetName = "DS4";
            this.dS41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SummarizationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SummarizationDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS41)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DS4 dS41;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        internal System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private DevExpress.XtraEditors.LabelControl labelFunction;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxFunction;

	}
}
