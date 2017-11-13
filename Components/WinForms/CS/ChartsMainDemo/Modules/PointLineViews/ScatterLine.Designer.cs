namespace DevExpress.XtraCharts.Demos.PointLineViews {
    partial class ScatterLineDemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView1 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.XYSeriesBlowUpAnimation xySeriesBlowUpAnimation1 = new DevExpress.XtraCharts.XYSeriesBlowUpAnimation();
            DevExpress.XtraCharts.XYMarkerSlideAnimation xyMarkerSlideAnimation1 = new DevExpress.XtraCharts.XYMarkerSlideAnimation();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView2 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.XYSeriesBlowUpAnimation xySeriesBlowUpAnimation2 = new DevExpress.XtraCharts.XYSeriesBlowUpAnimation();
            DevExpress.XtraCharts.XYMarkerSlideAnimation xyMarkerSlideAnimation2 = new DevExpress.XtraCharts.XYMarkerSlideAnimation();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.ScatterLineSeriesView scatterLineSeriesView3 = new DevExpress.XtraCharts.ScatterLineSeriesView();
            DevExpress.XtraCharts.XYSeriesBlowUpAnimation xySeriesBlowUpAnimation3 = new DevExpress.XtraCharts.XYSeriesBlowUpAnimation();
            DevExpress.XtraCharts.XYMarkerSlideAnimation xyMarkerSlideAnimation3 = new DevExpress.XtraCharts.XYMarkerSlideAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lbThickness = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditFunctionType = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.TabIndex = 3;
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.TabIndex = 0;
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.Visible = false;
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.TabIndex = 1;
            // 
            // labelAngle
            // 
            this.labelAngle.Visible = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBoxEditFunctionType);
            this.panel.Controls.Add(this.lbThickness);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            this.panel.Controls.SetChildIndex(this.lbThickness, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditFunctionType, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Tickmarks.CrossAxis = true;
            xyDiagram1.AxisX.Title.Text = "Arguments";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Tickmarks.CrossAxis = true;
            xyDiagram1.AxisY.Title.Text = "Values";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.LabelsResolveOverlappingMinIndent = 3;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            pointSeriesLabel1.TextPattern = "{V:F1}";
            series1.Label = pointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Archimedean Spiral";
            scatterLineSeriesView1.LineMarkerOptions.Size = 8;
            scatterLineSeriesView1.SeriesAnimation = xySeriesBlowUpAnimation1;
            xyMarkerSlideAnimation1.BeginTime = System.TimeSpan.Parse("00:00:01.2000000");
            xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner;
            scatterLineSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1;
            series1.View = scatterLineSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            pointSeriesLabel2.TextPattern = "{V:F1}";
            series2.Label = pointSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Cardioid";
            scatterLineSeriesView2.LineMarkerOptions.Size = 8;
            scatterLineSeriesView2.SeriesAnimation = xySeriesBlowUpAnimation2;
            xyMarkerSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:01.2000000");
            xyMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner;
            scatterLineSeriesView2.SeriesPointAnimation = xyMarkerSlideAnimation2;
            series2.View = scatterLineSeriesView2;
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            pointSeriesLabel3.TextPattern = "{V:F1}";
            series3.Label = pointSeriesLabel3;
            series3.Name = "Cartesian Folium";
            scatterLineSeriesView3.LineMarkerOptions.Size = 8;
            scatterLineSeriesView3.SeriesAnimation = xySeriesBlowUpAnimation3;
            xyMarkerSlideAnimation3.BeginTime = System.TimeSpan.Parse("00:00:01.2000000");
            xyMarkerSlideAnimation3.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner;
            scatterLineSeriesView3.SeriesPointAnimation = xyMarkerSlideAnimation3;
            series3.View = scatterLineSeriesView3;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            chartTitle1.Text = "Function in Cartesian Coordinates";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lbThickness
            // 
            this.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbThickness.Location = new System.Drawing.Point(193, 9);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(50, 20);
            this.lbThickness.TabIndex = 59;
            this.lbThickness.Text = "Function:";
            // 
            // comboBoxEditFunctionType
            // 
            this.comboBoxEditFunctionType.EditValue = "";
            this.comboBoxEditFunctionType.Location = new System.Drawing.Point(241, 9);
            this.comboBoxEditFunctionType.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType";
            this.comboBoxEditFunctionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFunctionType.Properties.Items.AddRange(new object[] {
            "Archimedean Spiral",
            "Cardioid",
            "Cartesian Folium"});
            this.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFunctionType.Size = new System.Drawing.Size(147, 20);
            this.comboBoxEditFunctionType.TabIndex = 2;
            this.comboBoxEditFunctionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditFunctionType_SelectedIndexChanged);
            // 
            // ScatterLineDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ScatterLineDemo";
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
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(scatterLineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.LabelControl lbThickness;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditFunctionType;
    }
}
