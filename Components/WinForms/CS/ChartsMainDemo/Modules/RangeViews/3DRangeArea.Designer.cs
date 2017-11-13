namespace DevExpress.XtraCharts.Demos.RangeViews {
    partial class RangeArea3dDemo {
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RangeArea3DSeriesLabel rangeArea3DSeriesLabel1 = new DevExpress.XtraCharts.RangeArea3DSeriesLabel();
            DevExpress.XtraCharts.RangeArea3DSeriesView rangeArea3DSeriesView1 = new DevExpress.XtraCharts.RangeArea3DSeriesView();
            DevExpress.XtraCharts.OverlappedRangeBarSeriesView overlappedRangeBarSeriesView1 = new DevExpress.XtraCharts.OverlappedRangeBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelLabelKind = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxLabelKind = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(rangeArea3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(rangeArea3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedRangeBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLabelKind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBoxLabelKind);
            this.panel.Controls.Add(this.labelLabelKind);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelLabelKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxLabelKind, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(607, 9);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.GridSpacing = 2D;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            xyDiagram3D1.AxisX.Label.TextPattern = "{A:MMMM}";
            xyDiagram3D1.AxisY.Label.TextPattern = "${V}";
            xyDiagram3D1.AxisY.VisualRange.Auto = false;
            xyDiagram3D1.AxisY.VisualRange.MaxValueSerializable = "70";
            xyDiagram3D1.AxisY.VisualRange.MinValueSerializable = "30";
            xyDiagram3D1.AxisY.WholeRange.Auto = false;
            xyDiagram3D1.AxisY.WholeRange.MaxValueSerializable = "70";
            xyDiagram3D1.AxisY.WholeRange.MinValueSerializable = "30";
            xyDiagram3D1.HorizontalScrollPercent = -2D;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" +
    "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" +
    "1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 4D;
            xyDiagram3D1.ZoomPercent = 160;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            rangeArea3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            rangeArea3DSeriesLabel1.TextPattern = "{V:F2}";
            series1.Label = rangeArea3DSeriesLabel1;
            series1.Name = "OK WTI";
            series1.ValueDataMembersSerializable = "Min;Max";
            series1.View = rangeArea3DSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.View = overlappedRangeBarSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Crude Oil Prices in 2015";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.eia.gov";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // labelLabelKind
            // 
            this.labelLabelKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLabelKind.Location = new System.Drawing.Point(432, 12);
            this.labelLabelKind.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelLabelKind.Name = "labelLabelKind";
            this.labelLabelKind.Size = new System.Drawing.Size(52, 13);
            this.labelLabelKind.TabIndex = 65;
            this.labelLabelKind.Text = "Label Kind:";
            // 
            // comboBoxLabelKind
            // 
            this.comboBoxLabelKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLabelKind.EditValue = "Two Labels";
            this.comboBoxLabelKind.Location = new System.Drawing.Point(487, 9);
            this.comboBoxLabelKind.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxLabelKind.Name = "comboBoxLabelKind";
            this.comboBoxLabelKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxLabelKind.Properties.Items.AddRange(new object[] {
            "One Label",
            "Two Labels",
            "Max Value Label",
            "Min Value Label"});
            this.comboBoxLabelKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxLabelKind.Size = new System.Drawing.Size(100, 20);
            this.comboBoxLabelKind.TabIndex = 66;
            this.comboBoxLabelKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxLabelKind_SelectedIndexChanged);
            // 
            // RangeArea3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "RangeArea3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(rangeArea3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(rangeArea3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(overlappedRangeBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxLabelKind.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.LabelControl labelLabelKind;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxLabelKind;

	}
}
