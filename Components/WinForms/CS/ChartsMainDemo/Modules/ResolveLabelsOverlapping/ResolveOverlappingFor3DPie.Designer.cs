namespace DevExpress.XtraCharts.Demos.ResolveLabelsOverlapping {
    partial class ResolveOverlappingFor3dPieDemo {
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("China", new object[] {
            ((object)(1350D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("India", new object[] {
            ((object)(1220D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("USA", new object[] {
            ((object)(316.67D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Indonesia", new object[] {
            ((object)(251.16D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Brazil", new object[] {
            ((object)(201.01D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Pakistan", new object[] {
            ((object)(193.24D))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("Nigeria", new object[] {
            ((object)(174.51D))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Bangladesh", new object[] {
            ((object)(163.65D))}, 7);
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("Russia", new object[] {
            ((object)(142.5D))}, 8);
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("Japan", new object[] {
            ((object)(127.25D))}, 9);
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("Mexico", new object[] {
            ((object)(116.22D))}, 10);
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("Phillippines", new object[] {
            ((object)(105.72D))}, 11);
            DevExpress.XtraCharts.SeriesPoint seriesPoint13 = new DevExpress.XtraCharts.SeriesPoint("Ethiopia", new object[] {
            ((object)(93.88D))}, 12);
            DevExpress.XtraCharts.SeriesPoint seriesPoint14 = new DevExpress.XtraCharts.SeriesPoint("Vietnam", new object[] {
            ((object)(92.48D))}, 13);
            DevExpress.XtraCharts.SeriesPoint seriesPoint15 = new DevExpress.XtraCharts.SeriesPoint("Egypt", new object[] {
            ((object)(85.29D))}, 14);
            DevExpress.XtraCharts.SeriesPoint seriesPoint16 = new DevExpress.XtraCharts.SeriesPoint("Others", new object[] {
            ((object)(2466.42D))}, 15);
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel2 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditResolveOverlapping = new DevExpress.XtraEditors.CheckEdit();
            this.labelIndent = new DevExpress.XtraEditors.LabelControl();
            this.spinIndent = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditResolveOverlapping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIndent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultAngles.Location = new System.Drawing.Point(562, 8);
            this.btnDefaultAngles.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelIndent);
            this.panel.Controls.Add(this.spinIndent);
            this.panel.Controls.Add(this.checkEditResolveOverlapping);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditResolveOverlapping, 0);
            this.panel.Controls.SetChildIndex(this.spinIndent, 0);
            this.panel.Controls.SetChildIndex(this.labelIndent, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(429, 8);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 5;
            simpleDiagram3D1.RotationAngleX = -50;
            simpleDiagram3D1.RotationAngleY = 170;
            simpleDiagram3D1.RotationAngleZ = -25;
            simpleDiagram3D1.RotationType = DevExpress.XtraCharts.RotationType.UseAngles;
            simpleDiagram3D1.RuntimeRotation = true;
            this.chart.Diagram = simpleDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            pie3DSeriesLabel1.ColumnIndent = 30;
            pie3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            pie3DSeriesLabel1.TextPattern = "{A}";
            series1.Label = pie3DSeriesLabel1;
            series1.LegendTextPattern = "{VP:P0}  {A}";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11,
            seriesPoint12,
            seriesPoint13,
            seriesPoint14,
            seriesPoint15,
            seriesPoint16});
            series1.View = pie3DSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pie3DSeriesLabel2.TextPattern = "{VP:G2}";
            this.chart.SeriesTemplate.Label = pie3DSeriesLabel2;
            this.chart.SeriesTemplate.View = pie3DSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            chartTitle1.Indent = 10;
            chartTitle1.Text = "Population by Country";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.nationmaster.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // checkEditResolveOverlapping
            // 
            this.checkEditResolveOverlapping.Location = new System.Drawing.Point(12, 9);
            this.checkEditResolveOverlapping.Name = "checkEditResolveOverlapping";
            this.checkEditResolveOverlapping.Properties.Caption = "Resolve Overlapping";
            this.checkEditResolveOverlapping.Size = new System.Drawing.Size(122, 19);
            this.checkEditResolveOverlapping.TabIndex = 53;
            this.checkEditResolveOverlapping.CheckedChanged += new System.EventHandler(this.checkEditResolveOverlapping_CheckedChanged);
            // 
            // labelIndent
            // 
            this.labelIndent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIndent.Location = new System.Drawing.Point(150, 11);
            this.labelIndent.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.labelIndent.Name = "labelIndent";
            this.labelIndent.Size = new System.Drawing.Size(36, 13);
            this.labelIndent.TabIndex = 54;
            this.labelIndent.Text = "Indent:";
            // 
            // spinIndent
            // 
            this.spinIndent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinIndent.Location = new System.Drawing.Point(189, 9);
            this.spinIndent.Name = "spinIndent";
            this.spinIndent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinIndent.Properties.IsFloatValue = false;
            this.spinIndent.Properties.Mask.EditMask = "N00";
            this.spinIndent.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinIndent.Properties.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.spinIndent.Properties.ValidateOnEnterKey = true;
            this.spinIndent.Size = new System.Drawing.Size(58, 20);
            this.spinIndent.TabIndex = 55;
            this.spinIndent.EditValueChanged += new System.EventHandler(this.spinIndent_EditValueChanged);
            // 
            // ResolveOverlappingFor3dPieDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ResolveOverlappingFor3dPieDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditResolveOverlapping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIndent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.CheckEdit checkEditResolveOverlapping;
        protected DevExpress.XtraEditors.LabelControl labelIndent;
        protected DevExpress.XtraEditors.SpinEdit spinIndent;
    }
}
