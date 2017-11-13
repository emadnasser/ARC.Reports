namespace DevExpress.XtraCharts.Demos.AreaViews {
	partial class Area3dDemo {
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Area3DSeriesLabel area3DSeriesLabel1 = new DevExpress.XtraCharts.Area3DSeriesLabel();
            DevExpress.XtraCharts.Area3DSeriesView area3DSeriesView1 = new DevExpress.XtraCharts.Area3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(area3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(area3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTransparencies
            // 
            this.comboTransparencies.TabIndex = 0;
            // 
            // comboBoxEditPerspective
            // 
            this.comboBoxEditPerspective.TabIndex = 1;
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.TabIndex = 2;
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 3;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram3D1.AxisX.GridLines.Visible = true;
            xyDiagram3D1.AxisX.Label.MaxWidth = 70;
            xyDiagram3D1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram3D1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram3D1.AxisY.Label.TextPattern = "${V}K";
            xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram3D1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Hundreds;
            xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram3D1.RotationMatrixSerializable = "0.77646940946579;-0.219846308231354;0.590561509132385;0;0.00596907455474138;0.939" +
    "692616462708;0.341968059539795;0;-0.630126714706421;-0.262002617120743;0.7309548" +
    "85482788;0;0;0;0;1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 7D;
            xyDiagram3D1.ZoomPercent = 135;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Company";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Year";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            area3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = area3DSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Costs";
            this.chart.SeriesTemplate.View = area3DSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 7;
            chartTitle1.Text = "Outside Vendor Costs";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Area3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "Area3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(area3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(area3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.IContainer components = null;

	}
}
