namespace DevExpress.XtraCharts.Demos.CustomDraw {
    partial class PolarDiagramCustomPaintDemo {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.PolarDiagram polarDiagram1 = new DevExpress.XtraCharts.PolarDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel1 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView1 = new DevExpress.XtraCharts.PolarPointSeriesView();
            DevExpress.XtraCharts.PolarPointSeriesView polarPointSeriesView2 = new DevExpress.XtraCharts.PolarPointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Size = new System.Drawing.Size(700, 38);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(609, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            this.panelRoot.Visible = false;
            // 
            // chart
            // 
            this.chart.CacheToMemory = true;
            this.chart.DataBindings = null;
            polarDiagram1.AxisX.Interlaced = true;
            polarDiagram1.AxisY.Visible = false;
            polarDiagram1.AxisY.VisualRange.Auto = false;
            polarDiagram1.AxisY.VisualRange.MaxValueSerializable = "20";
            polarDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            polarDiagram1.AxisY.WholeRange.Auto = false;
            polarDiagram1.AxisY.WholeRange.MaxValueSerializable = "20";
            polarDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            this.chart.Diagram = polarDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.MaxHorizontalPercentage = 30D;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            radarPointSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 6F);
            radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            series1.Label = radarPointSeriesLabel1;
            series1.Name = "Random Series";
            series1.View = polarPointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            this.chart.SeriesTemplate.View = polarPointSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Hit the Target";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chart_CustomPaint);
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PolarDiagramCustomPaintDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "PolarDiagramCustomPaintDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(polarDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(polarPointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private System.Windows.Forms.Timer timer;

    }
}
