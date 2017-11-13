namespace DevExpress.XtraCharts.Demos.SwiftPlotView {
    partial class RealtimeChartDemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram2 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView3 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.RegressionLine regressionLine3 = new DevExpress.XtraCharts.RegressionLine();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView4 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            DevExpress.XtraCharts.RegressionLine regressionLine4 = new DevExpress.XtraCharts.RegressionLine();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPauseResume = new DevExpress.XtraEditors.SimpleButton();
            this.lblWindowSize = new DevExpress.XtraEditors.LabelControl();
            this.spnTimeInterval = new DevExpress.XtraEditors.SpinEdit();
            this.chRegression = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnTimeInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRegression.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chRegression);
            this.panel.Controls.Add(this.spnTimeInterval);
            this.panel.Controls.Add(this.btnPauseResume);
            this.panel.Controls.Add(this.lblWindowSize);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.lblWindowSize, 0);
            this.panel.Controls.SetChildIndex(this.btnPauseResume, 0);
            this.panel.Controls.SetChildIndex(this.spnTimeInterval, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.chRegression, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(603, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            swiftPlotDiagram2.AxisX.GridLines.Visible = true;
            swiftPlotDiagram2.AxisX.Label.TextPattern = "{A:mm:ss}";
            swiftPlotDiagram2.AxisX.Title.Text = "Time";
            swiftPlotDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram2.AxisY.Interlaced = true;
            swiftPlotDiagram2.AxisY.Title.Text = "Values";
            swiftPlotDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            swiftPlotDiagram2.Margins.Right = 15;
            this.chart.Diagram = swiftPlotDiagram2;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series3.Name = "Process 1";
            regressionLine3.Name = "Regression Line";
            swiftPlotSeriesView3.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine3});
            series3.View = swiftPlotSeriesView3;
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series4.Name = "Process 2";
            regressionLine4.Name = "Regression Line";
            swiftPlotSeriesView4.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine4});
            series4.View = swiftPlotSeriesView4;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(12, 8);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(84, 22);
            this.btnPauseResume.TabIndex = 2;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // lblWindowSize
            // 
            this.lblWindowSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWindowSize.Location = new System.Drawing.Point(110, 12);
            this.lblWindowSize.Name = "lblWindowSize";
            this.lblWindowSize.Size = new System.Drawing.Size(115, 13);
            this.lblWindowSize.TabIndex = 10;
            this.lblWindowSize.Text = "Time interval (seconds):";
            // 
            // spnTimeInterval
            // 
            this.spnTimeInterval.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnTimeInterval.Location = new System.Drawing.Point(231, 9);
            this.spnTimeInterval.Name = "spnTimeInterval";
            this.spnTimeInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnTimeInterval.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spnTimeInterval.Properties.IsFloatValue = false;
            this.spnTimeInterval.Properties.Mask.EditMask = "N00";
            this.spnTimeInterval.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnTimeInterval.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spnTimeInterval.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.spnTimeInterval.Size = new System.Drawing.Size(56, 20);
            this.spnTimeInterval.TabIndex = 11;
            // 
            // chRegression
            // 
            this.chRegression.EditValue = true;
            this.chRegression.Location = new System.Drawing.Point(304, 9);
            this.chRegression.Name = "chRegression";
            this.chRegression.Properties.Caption = "Show regression lines";
            this.chRegression.Size = new System.Drawing.Size(125, 19);
            this.chRegression.TabIndex = 13;
            this.chRegression.CheckedChanged += new System.EventHandler(this.chRegression_CheckedChanged);
            // 
            // RealtimeChartDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "RealtimeChartDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnTimeInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRegression.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.SimpleButton btnPauseResume;
        private DevExpress.XtraEditors.LabelControl lblWindowSize;
        private DevExpress.XtraEditors.SpinEdit spnTimeInterval;
        private DevExpress.XtraEditors.CheckEdit chRegression;
    }
}
