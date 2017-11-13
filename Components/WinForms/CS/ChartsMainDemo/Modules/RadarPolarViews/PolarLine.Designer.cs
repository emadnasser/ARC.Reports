namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	partial class PolarLineDemo {
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel1 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.PolarLineSeriesView polarLineSeriesView1 = new DevExpress.XtraCharts.PolarLineSeriesView();
            DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation circularSeriesUnwindFromCenterAnimation1 = new DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation();
            DevExpress.XtraCharts.CircularMarkerWidenAnimation circularMarkerWidenAnimation1 = new DevExpress.XtraCharts.CircularMarkerWidenAnimation();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditShowMarkers = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditFunctionType
            // 
            this.comboBoxEditFunctionType.TabIndex = 2;
            // 
            // comboBoxEditMarkerKind
            // 
            // 
            // comboBoxEditMarkerSize
            // 
            // 
            // comboBoxEditDiagramStyle
            // 
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditShowMarkers);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditFunctionType, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(602, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 6;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            radarPointSeriesLabel1.TextPattern = "{V:N2}";
            series1.Label = radarPointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Function";
            polarLineSeriesView1.LineMarkerOptions.Size = 8;
            polarLineSeriesView1.SeriesAnimation = circularSeriesUnwindFromCenterAnimation1;
            circularMarkerWidenAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.6000000");
            polarLineSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation1;
            series1.View = polarLineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.TextPattern = "{V:y}";
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Function in Polar Coordinates";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditShowMarkers.Location = new System.Drawing.Point(602, 9);
            this.checkEditShowMarkers.Margin = new System.Windows.Forms.Padding(0);
            this.checkEditShowMarkers.Name = "checkEditShowMarkers";
            this.checkEditShowMarkers.Properties.Caption = "Show markers";
            this.checkEditShowMarkers.Size = new System.Drawing.Size(88, 19);
            this.checkEditShowMarkers.TabIndex = 5;
            this.checkEditShowMarkers.CheckedChanged += new System.EventHandler(this.checkEditShowMarkers_CheckedChanged);
            // 
            // PolarLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "PolarLineDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.CheckEdit checkEditShowMarkers;

	}
}
