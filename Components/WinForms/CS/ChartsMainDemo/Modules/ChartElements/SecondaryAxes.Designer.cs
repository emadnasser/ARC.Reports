namespace DevExpress.XtraCharts.Demos.ChartElements {
	partial class SecondaryAxesDemo {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(40D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(30D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(25D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(22.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(21.25D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(1700D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(900D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(500D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(300D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(200D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("F", new object[] {
            ((object)(150D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("G", new object[] {
            ((object)(125D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lbChartType = new DevExpress.XtraEditors.LabelControl();
            this.cbChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSeriesAxisX = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbSeriesAxisY = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbSeriesTwoAxisX = new DevExpress.XtraEditors.LabelControl();
            this.lbSeriesTwoAxisY = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesAxisX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesAxisY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbSeriesTwoAxisY);
            this.panel.Controls.Add(this.lbSeriesTwoAxisX);
            this.panel.Controls.Add(this.cbSeriesAxisY);
            this.panel.Controls.Add(this.cbSeriesAxisX);
            this.panel.Controls.Add(this.lbChartType);
            this.panel.Controls.Add(this.cbChartType);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.cbChartType, 0);
            this.panel.Controls.SetChildIndex(this.lbChartType, 0);
            this.panel.Controls.SetChildIndex(this.cbSeriesAxisX, 0);
            this.panel.Controls.SetChildIndex(this.cbSeriesAxisY, 0);
            this.panel.Controls.SetChildIndex(this.lbSeriesTwoAxisX, 0);
            this.panel.Controls.SetChildIndex(this.lbSeriesTwoAxisY, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 5;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A}";
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Axis X";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "Axis Y";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Margins.Bottom = 10;
            this.chart.Legend.Margins.Left = 10;
            this.chart.Legend.Margins.Right = 10;
            this.chart.Legend.Margins.Top = 10;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel1.TextPattern = "{A}: {V}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5});
            series1.View = lineSeriesView1;
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel2.TextPattern = "{A}: {V}";
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11,
            seriesPoint12});
            lineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square;
            series2.View = lineSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            // 
            // lbChartType
            // 
            this.lbChartType.Location = new System.Drawing.Point(12, 12);
            this.lbChartType.Name = "lbChartType";
            this.lbChartType.Size = new System.Drawing.Size(58, 13);
            this.lbChartType.TabIndex = 19;
            this.lbChartType.Text = "Chart Type:";
            // 
            // cbChartType
            // 
            this.cbChartType.EditValue = "";
            this.cbChartType.Location = new System.Drawing.Point(74, 9);
            this.cbChartType.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbChartType.Name = "cbChartType";
            this.cbChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbChartType.Size = new System.Drawing.Size(50, 20);
            this.cbChartType.TabIndex = 18;
            this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);
            // 
            // cbSeriesAxisX
            // 
            this.cbSeriesAxisX.EditValue = "";
            this.cbSeriesAxisX.Location = new System.Drawing.Point(214, 9);
            this.cbSeriesAxisX.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbSeriesAxisX.Name = "cbSeriesAxisX";
            this.cbSeriesAxisX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeriesAxisX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSeriesAxisX.Size = new System.Drawing.Size(105, 20);
            this.cbSeriesAxisX.TabIndex = 20;
            this.cbSeriesAxisX.SelectedIndexChanged += new System.EventHandler(this.cbSeriesAxisX_SelectedIndexChanged);
            // 
            // cbSeriesAxisY
            // 
            this.cbSeriesAxisY.EditValue = "";
            this.cbSeriesAxisY.Location = new System.Drawing.Point(409, 9);
            this.cbSeriesAxisY.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbSeriesAxisY.Name = "cbSeriesAxisY";
            this.cbSeriesAxisY.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSeriesAxisY.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSeriesAxisY.Size = new System.Drawing.Size(105, 20);
            this.cbSeriesAxisY.TabIndex = 21;
            this.cbSeriesAxisY.SelectedIndexChanged += new System.EventHandler(this.cbSeriesAxisY_SelectedIndexChanged);
            // 
            // lbSeriesTwoAxisX
            // 
            this.lbSeriesTwoAxisX.Location = new System.Drawing.Point(137, 12);
            this.lbSeriesTwoAxisX.Name = "lbSeriesTwoAxisX";
            this.lbSeriesTwoAxisX.Size = new System.Drawing.Size(74, 13);
            this.lbSeriesTwoAxisX.TabIndex = 22;
            this.lbSeriesTwoAxisX.Text = "Series 2 Axis X:";
            // 
            // lbSeriesTwoAxisY
            // 
            this.lbSeriesTwoAxisY.Location = new System.Drawing.Point(332, 12);
            this.lbSeriesTwoAxisY.Name = "lbSeriesTwoAxisY";
            this.lbSeriesTwoAxisY.Size = new System.Drawing.Size(74, 13);
            this.lbSeriesTwoAxisY.TabIndex = 23;
            this.lbSeriesTwoAxisY.Text = "Series 2 Axis Y:";
            // 
            // SecondaryAxesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SecondaryAxesDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesAxisX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSeriesAxisY.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lbChartType;
        private DevExpress.XtraEditors.ComboBoxEdit cbChartType;
        private DevExpress.XtraEditors.ComboBoxEdit cbSeriesAxisY;
        private DevExpress.XtraEditors.ComboBoxEdit cbSeriesAxisX;
        private DevExpress.XtraEditors.LabelControl lbSeriesTwoAxisY;
        private DevExpress.XtraEditors.LabelControl lbSeriesTwoAxisX;
	}
}
