namespace DevExpress.XtraCharts.Demos.PointLineViews {
	partial class StepLineDemo {
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
            DevExpress.XtraCharts.StepLineSeriesView stepLineSeriesView1 = new DevExpress.XtraCharts.StepLineSeriesView();
            DevExpress.XtraCharts.XYSeriesUnwrapAnimation xySeriesUnwrapAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwrapAnimation();
            DevExpress.XtraCharts.XYMarkerSlideAnimation xyMarkerSlideAnimation1 = new DevExpress.XtraCharts.XYMarkerSlideAnimation();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.StepLineSeriesView stepLineSeriesView2 = new DevExpress.XtraCharts.StepLineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.TabIndex = 5;
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.TabIndex = 0;
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.TabIndex = 2;
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.TabIndex = 1;
            // 
            // labelAngle
            // 
            this.labelAngle.TabIndex = 2;
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 6;
            // 
            // chart
            // 
            this.chart.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month;
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Continuous;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Label.TextPattern = "{A:y}";
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "08/05/2017 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "07/27/2017 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 1000000000D;
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 1000000000D;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "$ per Gallon";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.CrosshairLabelPattern = "{A:MMMM}: ${V:0.000}";
            pointSeriesLabel1.LineLength = 15;
            series1.Label = pointSeriesLabel1;
            series1.LegendTextPattern = "{A: MMM}: ${V:0.000}";
            series1.Name = "Fuel";
            series1.ValueDataMembersSerializable = "Price";
            stepLineSeriesView1.ColorEach = true;
            stepLineSeriesView1.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square;
            stepLineSeriesView1.LineMarkerOptions.Size = 20;
            stepLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            xySeriesUnwrapAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000");
            stepLineSeriesView1.SeriesAnimation = xySeriesUnwrapAnimation1;
            xyMarkerSlideAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.8000000");
            xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromTopCenter;
            xyMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000");
            xyMarkerSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            stepLineSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1;
            series1.View = stepLineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.TextPattern = "{V:y}";
            this.chart.SeriesTemplate.Label = pointSeriesLabel2;
            this.chart.SeriesTemplate.View = stepLineSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "U.S. No 2 Diesel Ultra Low Sulfur  Retail Price";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "From www.eia.gov";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // StepLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "StepLineDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
	}
}
