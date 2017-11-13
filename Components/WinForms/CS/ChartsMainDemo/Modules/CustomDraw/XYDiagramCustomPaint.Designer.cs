namespace DevExpress.XtraCharts.Demos.CustomDraw {
    partial class XYDiagramCustomPaintDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.simpleButtonRandom = new DevExpress.XtraEditors.SimpleButton();
            this.cheAutoMode = new DevExpress.XtraEditors.CheckEdit();
            this.lbSelectedPoints = new DevExpress.XtraEditors.ListBoxControl();
            this.labelSelectedPoints = new DevExpress.XtraEditors.LabelControl();
            this.panelSelectedPoints = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSelectedPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSelectedPoints)).BeginInit();
            this.panelSelectedPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.simpleButtonRandom);
            this.panel.Controls.Add(this.cheAutoMode);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.cheAutoMode, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.simpleButtonRandom, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.CacheToMemory = true;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Arguments";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.MinorCount = 4;
            xyDiagram1.AxisY.Title.Text = "Values";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            pointSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 6F);
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            pointSeriesLabel1.TextPattern = "{V:F2}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Random Series";
            series1.View = pointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(547, 454);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Random Points Generator";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chart_CustomPaint);
            this.chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart_MouseDown);
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            this.chart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart_MouseUp);
            // 
            // simpleButtonRandom
            // 
            this.simpleButtonRandom.Location = new System.Drawing.Point(12, 8);
            this.simpleButtonRandom.Name = "simpleButtonRandom";
            this.simpleButtonRandom.Size = new System.Drawing.Size(85, 22);
            this.simpleButtonRandom.TabIndex = 2;
            this.simpleButtonRandom.Text = "Create Points";
            this.simpleButtonRandom.Click += new System.EventHandler(this.simpleButtonRandom_Click);
            // 
            // cheAutoMode
            // 
            this.cheAutoMode.Location = new System.Drawing.Point(120, 9);
            this.cheAutoMode.Name = "cheAutoMode";
            this.cheAutoMode.Properties.Caption = "Auto Mode";
            this.cheAutoMode.Size = new System.Drawing.Size(75, 19);
            this.cheAutoMode.TabIndex = 3;
            this.cheAutoMode.CheckedChanged += new System.EventHandler(this.cheAutoMode_CheckedChanged);
            // 
            // lbSelectedPoints
            // 
            this.lbSelectedPoints.Appearance.Font = new System.Drawing.Font("Courier New", 9F);
            this.lbSelectedPoints.Appearance.Options.UseFont = true;
            this.lbSelectedPoints.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSelectedPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelectedPoints.Location = new System.Drawing.Point(2, 20);
            this.lbSelectedPoints.Name = "lbSelectedPoints";
            this.lbSelectedPoints.Size = new System.Drawing.Size(145, 432);
            this.lbSelectedPoints.TabIndex = 1;
            // 
            // labelSelectedPoints
            // 
            this.labelSelectedPoints.Appearance.Options.UseTextOptions = true;
            this.labelSelectedPoints.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelSelectedPoints.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelSelectedPoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSelectedPoints.Location = new System.Drawing.Point(2, 2);
            this.labelSelectedPoints.Name = "labelSelectedPoints";
            this.labelSelectedPoints.Size = new System.Drawing.Size(145, 18);
            this.labelSelectedPoints.TabIndex = 0;
            this.labelSelectedPoints.Text = "The cluster\'s points ";
            // 
            // panelSelectedPoints
            // 
            this.panelSelectedPoints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSelectedPoints.Controls.Add(this.lbSelectedPoints);
            this.panelSelectedPoints.Controls.Add(this.labelSelectedPoints);
            this.panelSelectedPoints.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSelectedPoints.Location = new System.Drawing.Point(551, 46);
            this.panelSelectedPoints.Name = "panelSelectedPoints";
            this.panelSelectedPoints.Size = new System.Drawing.Size(149, 454);
            this.panelSelectedPoints.TabIndex = 3;
            // 
            // XYDiagramCustomPaintDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSelectedPoints);
            this.Controls.Add(this.chart);
            this.Name = "XYDiagramCustomPaintDemo";
            this.Controls.SetChildIndex(this.chart, 0);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.panelSelectedPoints, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSelectedPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSelectedPoints)).EndInit();
            this.panelSelectedPoints.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRandom;
        private DevExpress.XtraEditors.CheckEdit cheAutoMode;
        private DevExpress.XtraEditors.ListBoxControl lbSelectedPoints;
        private DevExpress.XtraEditors.LabelControl labelSelectedPoints;
        private DevExpress.XtraEditors.PanelControl panelSelectedPoints;

    }
}
