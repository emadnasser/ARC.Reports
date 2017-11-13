namespace DevExpress.XtraCharts.Demos.AreaViews {
	partial class FullStackedArea3dDemo {
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
            DevExpress.XtraCharts.FullStackedArea3DSeriesView fullStackedArea3DSeriesView1 = new DevExpress.XtraCharts.FullStackedArea3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedArea3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueAsPercent.Properties)).BeginInit();
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
            // panel
            // 
            this.panel.Controls.Add(this.checkValueAsPercent);
            this.panel.Controls.SetChildIndex(this.comboTransparencies, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkValueAsPercent, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(584, 37);
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram3D1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram3D1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram3D1.AxisY.Label.TextPattern = "{V:P0}";
            xyDiagram3D1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram3D1.AxisY.WholeRange.SideMarginsValue = 0D;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
    "1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 5D;
            xyDiagram3D1.ZoomPercent = 130;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Company";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Year";
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            fullStackedArea3DSeriesView1.AreaWidth = 1D;
            this.chart.SeriesTemplate.View = fullStackedArea3DSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Market Share Over Time";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // checkValueAsPercent
            // 
            this.checkValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkValueAsPercent.Location = new System.Drawing.Point(584, 9);
            this.checkValueAsPercent.Margin = new System.Windows.Forms.Padding(0);
            this.checkValueAsPercent.Name = "checkValueAsPercent";
            this.checkValueAsPercent.Properties.Caption = "Value As Percent";
            this.checkValueAsPercent.Size = new System.Drawing.Size(104, 19);
            this.checkValueAsPercent.TabIndex = 3;
            this.checkValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // FullStackedArea3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "FullStackedArea3dDemo";
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
            ((System.ComponentModel.ISupportInitialize)(fullStackedArea3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueAsPercent.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;

	}
}
