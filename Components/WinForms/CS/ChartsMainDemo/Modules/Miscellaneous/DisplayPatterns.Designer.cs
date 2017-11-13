namespace DevExpress.XtraCharts.Demos.Miscellaneous {
	partial class DisplayPatternsDemo {
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dS21 = new DevExpress.XtraCharts.Demos.DS2();
            this.labelSeriesLabels = new DevExpress.XtraEditors.LabelControl();
            this.cbSeriesLabels = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelLegend = new DevExpress.XtraEditors.LabelControl();
            this.cbLegendTextPattern = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbAxisYLabelsPattern = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbAxisXLabelsPattern = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLegendTextPattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAxisYLabelsPattern.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAxisXLabelsPattern.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.cbAxisYLabelsPattern);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.cbAxisXLabelsPattern);
            this.panel.Controls.Add(this.labelLegend);
            this.panel.Controls.Add(this.cbLegendTextPattern);
            this.panel.Controls.Add(this.labelSeriesLabels);
            this.panel.Controls.Add(this.cbSeriesLabels);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbSeriesLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelSeriesLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbLegendTextPattern, 0);
            this.panel.Controls.SetChildIndex(this.labelLegend, 0);
            this.panel.Controls.SetChildIndex(this.cbAxisXLabelsPattern, 0);
            this.panel.Controls.SetChildIndex(this.labelControl2, 0);
            this.panel.Controls.SetChildIndex(this.cbAxisYLabelsPattern, 0);
            this.panel.Controls.SetChildIndex(this.labelControl1, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataAdapter = this.oleDbDataAdapter1;
            this.chart.DataBindings = null;
            this.chart.DataSource = this.dS21.Countries;
            xyDiagram1.AxisX.Label.TextPattern = "{A}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.TextPattern = "{V:#,0}";
            xyDiagram1.AxisY.Title.Text = "Millions of Square Kilometers";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.RefreshDataOnRepaint = true;
            series1.ArgumentDataMember = "Country";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("Area", "System.Single", DevExpress.XtraCharts.DataFilterCondition.GreaterThan, 5000F)});
            sideBySideBarSeriesLabel1.TextPattern = "{V:## ##0.0}";
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Area of Countries";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.ValueDataMembersSerializable = "Area";
            sideBySideBarSeriesView1.ColorEach = true;
            series1.View = sideBySideBarSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.TextPattern = "{VP:G2}";
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Indent = 10;
            chartTitle1.Text = "Area of Countries";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.nationmaster.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Countries", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("OfficialName", "OfficialName"),
                        new System.Data.Common.DataColumnMapping("Area", "Area")})});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT Country, OfficialName, Area FROM Countries";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // dS21
            // 
            this.dS21.DataSetName = "DS2";
            this.dS21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelSeriesLabels
            // 
            this.labelSeriesLabels.Location = new System.Drawing.Point(12, 12);
            this.labelSeriesLabels.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelSeriesLabels.Name = "labelSeriesLabels";
            this.labelSeriesLabels.Size = new System.Drawing.Size(66, 13);
            this.labelSeriesLabels.TabIndex = 60;
            this.labelSeriesLabels.Text = "Series Labels:";
            // 
            // cbSeriesLabels
            // 
            this.cbSeriesLabels.EditValue = "{V:## ##0.0}";
            this.cbSeriesLabels.Location = new System.Drawing.Point(81, 9);
            this.cbSeriesLabels.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbSeriesLabels.Name = "cbSeriesLabels";
            this.cbSeriesLabels.Properties.AutoComplete = false;
            this.cbSeriesLabels.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeriesLabels.Properties.Items.AddRange(new object[] {
            "{V:## ##0.0}",
            "{A}",
            "{V}",
            "{A}: {V}",
            "{S}"});
            this.cbSeriesLabels.Size = new System.Drawing.Size(141, 20);
            this.cbSeriesLabels.TabIndex = 0;
            this.cbSeriesLabels.EditValueChanged += new System.EventHandler(this.comboBoxSeriesLabels_EditValueChanged);
            // 
            // labelLegend
            // 
            this.labelLegend.Location = new System.Drawing.Point(12, 40);
            this.labelLegend.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(39, 13);
            this.labelLegend.TabIndex = 62;
            this.labelLegend.Text = "Legend:";
            // 
            // cbLegendTextPattern
            // 
            this.cbLegendTextPattern.EditValue = "{A}";
            this.cbLegendTextPattern.Location = new System.Drawing.Point(81, 37);
            this.cbLegendTextPattern.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbLegendTextPattern.Name = "cbLegendTextPattern";
            this.cbLegendTextPattern.Properties.AutoComplete = false;
            this.cbLegendTextPattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLegendTextPattern.Properties.Items.AddRange(new object[] {
            "{A}",
            "{V}",
            "{A}: {V}",
            "{S}"});
            this.cbLegendTextPattern.Size = new System.Drawing.Size(141, 20);
            this.cbLegendTextPattern.TabIndex = 1;
            this.cbLegendTextPattern.EditValueChanged += new System.EventHandler(this.cbLegendTextPattern_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(245, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "AxisY Labels:";
            // 
            // cbAxisYLabelsPattern
            // 
            this.cbAxisYLabelsPattern.EditValue = "{V:#,0}";
            this.cbAxisYLabelsPattern.Location = new System.Drawing.Point(311, 37);
            this.cbAxisYLabelsPattern.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbAxisYLabelsPattern.Name = "cbAxisYLabelsPattern";
            this.cbAxisYLabelsPattern.Properties.AutoComplete = false;
            this.cbAxisYLabelsPattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAxisYLabelsPattern.Properties.Items.AddRange(new object[] {
            "{V:#,0}",
            "{V}",
            "{V:0,.#} ths"});
            this.cbAxisYLabelsPattern.Size = new System.Drawing.Size(141, 20);
            this.cbAxisYLabelsPattern.TabIndex = 64;
            this.cbAxisYLabelsPattern.EditValueChanged += new System.EventHandler(this.cbAxisYLabelsPattern_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(245, 12);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "AxisX Labels:";
            // 
            // cbAxisXLabelsPattern
            // 
            this.cbAxisXLabelsPattern.EditValue = "{A}";
            this.cbAxisXLabelsPattern.Location = new System.Drawing.Point(311, 9);
            this.cbAxisXLabelsPattern.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.cbAxisXLabelsPattern.Name = "cbAxisXLabelsPattern";
            this.cbAxisXLabelsPattern.Properties.AutoComplete = false;
            this.cbAxisXLabelsPattern.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAxisXLabelsPattern.Properties.Items.AddRange(new object[] {
            "{A}",
            "Country: {A}"});
            this.cbAxisXLabelsPattern.Size = new System.Drawing.Size(141, 20);
            this.cbAxisXLabelsPattern.TabIndex = 63;
            this.cbAxisXLabelsPattern.EditValueChanged += new System.EventHandler(this.cbAxisXLabelsPattern_EditValueChanged);
            // 
            // DisplayPatternsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "DisplayPatternsDemo";
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
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLegendTextPattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAxisYLabelsPattern.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAxisXLabelsPattern.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelSeriesLabels;
        private DevExpress.XtraEditors.ComboBoxEdit cbSeriesLabels;
        private DevExpress.XtraEditors.LabelControl labelLegend;
        private DevExpress.XtraEditors.ComboBoxEdit cbLegendTextPattern;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.ComboBoxEdit cbAxisYLabelsPattern;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.ComboBoxEdit cbAxisXLabelsPattern;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private DS2 dS21;

	}
}
