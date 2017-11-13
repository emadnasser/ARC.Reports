namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    partial class ScatterRadarLineDemo {
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
            DevExpress.XtraCharts.RadarDiagram radarDiagram1 = new DevExpress.XtraCharts.RadarDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel1 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.ScatterRadarLineSeriesView scatterRadarLineSeriesView1 = new DevExpress.XtraCharts.ScatterRadarLineSeriesView();
            DevExpress.XtraCharts.CircularSeriesSpinZoomInAnimation circularSeriesSpinZoomInAnimation1 = new DevExpress.XtraCharts.CircularSeriesSpinZoomInAnimation();
            DevExpress.XtraCharts.ExponentialEasingFunction exponentialEasingFunction1 = new DevExpress.XtraCharts.ExponentialEasingFunction();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditShowMarkers = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditFunctionType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelFunction = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.panel.Controls.Add(this.comboBoxEditFunctionType);
            this.panel.Controls.Add(this.labelFunction);
            this.panel.Controls.Add(this.checkEditShowMarkers);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            this.panel.Controls.SetChildIndex(this.labelFunction, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditFunctionType, 0);
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
            radarDiagram1.AxisX.GridLines.MinorVisible = true;
            radarDiagram1.AxisX.Label.TextPattern = "{A:0.##}";
            radarDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            radarDiagram1.AxisX.NumericScaleOptions.GridSpacing = 0.523598D;
            radarDiagram1.AxisX.WholeRange.Auto = false;
            radarDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            radarDiagram1.AxisX.WholeRange.MaxValueSerializable = "6.28";
            radarDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            radarDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            radarDiagram1.AxisY.GridLines.MinorVisible = true;
            radarDiagram1.StartAngleInDegrees = 270D;
            this.chart.Diagram = radarDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            radarPointSeriesLabel1.TextPattern = "{V:N2}";
            series1.Label = radarPointSeriesLabel1;
            series1.Name = "Function";
            series1.ToolTipPointPattern = "{A:F2}: {V:F2}";
            scatterRadarLineSeriesView1.Closed = false;
            scatterRadarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.False;
            exponentialEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out;
            exponentialEasingFunction1.Exponent = 5D;
            circularSeriesSpinZoomInAnimation1.EasingFunction = exponentialEasingFunction1;
            scatterRadarLineSeriesView1.SeriesAnimation = circularSeriesSpinZoomInAnimation1;
            series1.View = scatterRadarLineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
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
            // comboBoxEditFunctionType
            // 
            this.comboBoxEditFunctionType.EditValue = "";
            this.comboBoxEditFunctionType.Location = new System.Drawing.Point(245, 9);
            this.comboBoxEditFunctionType.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType";
            this.comboBoxEditFunctionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFunctionType.Properties.Items.AddRange(new object[] {
            "Archimedean Spiral",
            "Polar Rose",
            "Polar Folium"});
            this.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFunctionType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditFunctionType.TabIndex = 4;
            this.comboBoxEditFunctionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditFunctionType_SelectedIndexChanged);
            // 
            // labelFunction
            // 
            this.labelFunction.Location = new System.Drawing.Point(173, 12);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(7);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(45, 13);
            this.labelFunction.TabIndex = 8;
            this.labelFunction.Text = "Function:";
            // 
            // ScatterRadarLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ScatterRadarLineDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(radarDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterRadarLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.CheckEdit checkEditShowMarkers;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditFunctionType;
        private DevExpress.XtraEditors.LabelControl labelFunction;
	}
}
