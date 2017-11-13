namespace DevExpress.XtraCharts.Demos.PointLineViews {
	partial class Line3dDemo {
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
            DevExpress.XtraCharts.Line3DSeriesLabel line3DSeriesLabel1 = new DevExpress.XtraCharts.Line3DSeriesLabel();
            DevExpress.XtraCharts.Line3DSeriesView line3DSeriesView1 = new DevExpress.XtraCharts.Line3DSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Line3DSeriesLabel line3DSeriesLabel2 = new DevExpress.XtraCharts.Line3DSeriesLabel();
            DevExpress.XtraCharts.Line3DSeriesView line3DSeriesView2 = new DevExpress.XtraCharts.Line3DSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Line3DSeriesLabel line3DSeriesLabel3 = new DevExpress.XtraCharts.Line3DSeriesLabel();
            DevExpress.XtraCharts.Line3DSeriesView line3DSeriesView3 = new DevExpress.XtraCharts.Line3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.comboBoxEditPerspective = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelPerspective = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(203, 8);
            this.btnDefaultAngles.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnDefaultAngles.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelPerspective);
            this.panel.Controls.Add(this.comboBoxEditPerspective);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.labelPerspective, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.TabIndex = 2;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram3D1.AxisX.Label.TextPattern = "{A:yyyy}";
            xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram3D1.AxisY.NumericScaleOptions.GridSpacing = 50D;
            xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" +
    "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" +
    "1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.SeriesDistance = 0D;
            xyDiagram3D1.VerticalScrollPercent = 6D;
            xyDiagram3D1.ZoomPercent = 130;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            line3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            line3DSeriesLabel1.TextPattern = "{V:F2}";
            series1.Label = line3DSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Russia";
            series1.ValueDataMembersSerializable = "Russia";
            line3DSeriesView1.LineWidth = 2D;
            series1.View = line3DSeriesView1;
            series2.ArgumentDataMember = "Date";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            line3DSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            line3DSeriesLabel2.TextPattern = "{V:F2}";
            series2.Label = line3DSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "South Africa";
            series2.ValueDataMembersSerializable = "South Africa";
            line3DSeriesView2.LineWidth = 2D;
            series2.View = line3DSeriesView2;
            series3.ArgumentDataMember = "Date";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            line3DSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            line3DSeriesLabel3.TextPattern = "{V:F2}";
            series3.Label = line3DSeriesLabel3;
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series3.Name = "Poland";
            series3.ValueDataMembersSerializable = "Poland";
            line3DSeriesView3.LineWidth = 2D;
            series3.View = line3DSeriesView3;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Coal Production, in Millions of Tonnes";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // comboBoxEditPerspective
            // 
            this.comboBoxEditPerspective.EditValue = "";
            this.comboBoxEditPerspective.Location = new System.Drawing.Point(105, 9);
            this.comboBoxEditPerspective.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.comboBoxEditPerspective.Name = "comboBoxEditPerspective";
            this.comboBoxEditPerspective.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPerspective.Size = new System.Drawing.Size(78, 20);
            this.comboBoxEditPerspective.TabIndex = 0;
            this.comboBoxEditPerspective.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPerspective_SelectedIndexChanged);
            // 
            // labelPerspective
            // 
            this.labelPerspective.Location = new System.Drawing.Point(12, 12);
            this.labelPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPerspective.Name = "labelPerspective";
            this.labelPerspective.Size = new System.Drawing.Size(90, 13);
            this.labelPerspective.TabIndex = 13;
            this.labelPerspective.Text = "Perspective Angle:";
            // 
            // Line3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "Line3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(line3DSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelPerspective;

	}
}
