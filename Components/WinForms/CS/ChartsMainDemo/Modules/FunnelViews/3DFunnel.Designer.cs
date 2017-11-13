namespace DevExpress.XtraCharts.Demos.FunnelViews {
    partial class Funnel3dDemo {
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
            DevExpress.XtraCharts.FunnelDiagram3D funnelDiagram3D1 = new DevExpress.XtraCharts.FunnelDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Funnel3DSeriesLabel funnel3DSeriesLabel1 = new DevExpress.XtraCharts.Funnel3DSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Visited a Website", new object[] {
            ((object)(9152D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", new object[] {
            ((object)(6870D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Contacted to Support", new object[] {
            ((object)(5121D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Subscribed", new object[] {
            ((object)(2224D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Renewed", new object[] {
            ((object)(1670D))});
            DevExpress.XtraCharts.Funnel3DSeriesView funnel3DSeriesView1 = new DevExpress.XtraCharts.Funnel3DSeriesView();
            DevExpress.XtraCharts.Funnel3DSeriesView funnel3DSeriesView2 = new DevExpress.XtraCharts.Funnel3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.spinPointDistance = new DevExpress.XtraEditors.SpinEdit();
            this.labelPointDistance = new DevExpress.XtraEditors.LabelControl();
            this.labelHeightToWidthRatio = new DevExpress.XtraEditors.LabelControl();
            this.cbHeightToWidthRatio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            this.spinHoleRadius = new DevExpress.XtraEditors.SpinEdit();
            this.labelHoleRadius = new DevExpress.XtraEditors.LabelControl();
            this.cbLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPointDistance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeightToWidthRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHoleRadius.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(156, 36);
            this.btnDefaultAngles.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbLabelPosition);
            this.panel.Controls.Add(this.labelPosition);
            this.panel.Controls.Add(this.spinHoleRadius);
            this.panel.Controls.Add(this.labelHoleRadius);
            this.panel.Controls.Add(this.checkEditValueAsPercent);
            this.panel.Controls.Add(this.spinPointDistance);
            this.panel.Controls.Add(this.labelPointDistance);
            this.panel.Controls.Add(this.labelHeightToWidthRatio);
            this.panel.Controls.Add(this.cbHeightToWidthRatio);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.cbHeightToWidthRatio, 0);
            this.panel.Controls.SetChildIndex(this.labelHeightToWidthRatio, 0);
            this.panel.Controls.SetChildIndex(this.labelPointDistance, 0);
            this.panel.Controls.SetChildIndex(this.spinPointDistance, 0);
            this.panel.Controls.SetChildIndex(this.checkEditValueAsPercent, 0);
            this.panel.Controls.SetChildIndex(this.labelHoleRadius, 0);
            this.panel.Controls.SetChildIndex(this.spinHoleRadius, 0);
            this.panel.Controls.SetChildIndex(this.labelPosition, 0);
            this.panel.Controls.SetChildIndex(this.cbLabelPosition, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(584, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 10;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            funnelDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.866025403784439;0.5;0;0;-0.5;0.866025403784439;0;0;0;0;1";
            funnelDiagram3D1.RuntimeRotation = true;
            funnelDiagram3D1.RuntimeScrolling = true;
            funnelDiagram3D1.RuntimeZooming = true;
            this.chart.Diagram = funnelDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            funnel3DSeriesLabel1.LineLength = 40;
            funnel3DSeriesLabel1.TextPattern = "{A}: {VP:P0}";
            series1.Label = funnel3DSeriesLabel1;
            series1.LegendTextPattern = "{A}: {VP:P0}";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5});
            funnel3DSeriesView1.PointDistance = 10;
            series1.View = funnel3DSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.View = funnel3DSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "Website Visitor Trend";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // spinPointDistance
            // 
            this.spinPointDistance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinPointDistance.Location = new System.Drawing.Point(88, 9);
            this.spinPointDistance.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.spinPointDistance.Name = "spinPointDistance";
            this.spinPointDistance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinPointDistance.Properties.IsFloatValue = false;
            this.spinPointDistance.Properties.Mask.EditMask = "N00";
            this.spinPointDistance.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinPointDistance.Properties.ValidateOnEnterKey = true;
            this.spinPointDistance.Size = new System.Drawing.Size(46, 20);
            this.spinPointDistance.TabIndex = 1;
            this.spinPointDistance.EditValueChanged += new System.EventHandler(this.spinPointDistance_EditValueChanged);
            // 
            // labelPointDistance
            // 
            this.labelPointDistance.Location = new System.Drawing.Point(12, 12);
            this.labelPointDistance.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelPointDistance.Name = "labelPointDistance";
            this.labelPointDistance.Size = new System.Drawing.Size(72, 13);
            this.labelPointDistance.TabIndex = 0;
            this.labelPointDistance.Text = "Point Distance:";
            // 
            // labelHeightToWidthRatio
            // 
            this.labelHeightToWidthRatio.Location = new System.Drawing.Point(12, 40);
            this.labelHeightToWidthRatio.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelHeightToWidthRatio.Name = "labelHeightToWidthRatio";
            this.labelHeightToWidthRatio.Size = new System.Drawing.Size(73, 13);
            this.labelHeightToWidthRatio.TabIndex = 2;
            this.labelHeightToWidthRatio.Text = "Height / Width:";
            // 
            // cbHeightToWidthRatio
            // 
            this.cbHeightToWidthRatio.Location = new System.Drawing.Point(88, 37);
            this.cbHeightToWidthRatio.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.cbHeightToWidthRatio.Name = "cbHeightToWidthRatio";
            this.cbHeightToWidthRatio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbHeightToWidthRatio.Size = new System.Drawing.Size(46, 20);
            this.cbHeightToWidthRatio.TabIndex = 3;
            this.cbHeightToWidthRatio.SelectedIndexChanged += new System.EventHandler(this.cbHeightToWidthRatio_SelectedIndexChanged);
            // 
            // checkEditValueAsPercent
            // 
            this.checkEditValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditValueAsPercent.Location = new System.Drawing.Point(584, 9);
            this.checkEditValueAsPercent.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.checkEditValueAsPercent.Name = "checkEditValueAsPercent";
            this.checkEditValueAsPercent.Properties.Caption = "Value as Percent";
            this.checkEditValueAsPercent.Size = new System.Drawing.Size(105, 19);
            this.checkEditValueAsPercent.TabIndex = 9;
            this.checkEditValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // spinHoleRadius
            // 
            this.spinHoleRadius.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinHoleRadius.Location = new System.Drawing.Point(238, 9);
            this.spinHoleRadius.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.spinHoleRadius.Name = "spinHoleRadius";
            this.spinHoleRadius.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinHoleRadius.Properties.IsFloatValue = false;
            this.spinHoleRadius.Properties.Mask.EditMask = "N00";
            this.spinHoleRadius.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinHoleRadius.Properties.ValidateOnEnterKey = true;
            this.spinHoleRadius.Size = new System.Drawing.Size(46, 20);
            this.spinHoleRadius.TabIndex = 5;
            this.spinHoleRadius.EditValueChanged += new System.EventHandler(this.spinHoleRadius_EditValueChanged);
            // 
            // labelHoleRadius
            // 
            this.labelHoleRadius.Location = new System.Drawing.Point(156, 12);
            this.labelHoleRadius.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelHoleRadius.Name = "labelHoleRadius";
            this.labelHoleRadius.Size = new System.Drawing.Size(79, 13);
            this.labelHoleRadius.TabIndex = 4;
            this.labelHoleRadius.Text = "Hole Radius(%):";
            // 
            // cbLabelPosition
            // 
            this.cbLabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLabelPosition.Location = new System.Drawing.Point(481, 9);
            this.cbLabelPosition.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbLabelPosition.Name = "cbLabelPosition";
            this.cbLabelPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLabelPosition.Properties.Items.AddRange(new object[] {
            "LeftColumn",
            "Left",
            "Center",
            "Right",
            "RightColumn"});
            this.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLabelPosition.Size = new System.Drawing.Size(83, 20);
            this.cbLabelPosition.TabIndex = 8;
            this.cbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbLabelPosition_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPosition.Location = new System.Drawing.Point(409, 12);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "Label Position:";
            // 
            // Funnel3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "Funnel3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(funnelDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnel3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPointDistance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeightToWidthRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHoleRadius.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        protected DevExpress.XtraEditors.SpinEdit spinPointDistance;
        private DevExpress.XtraEditors.LabelControl labelPointDistance;
        private DevExpress.XtraEditors.LabelControl labelHeightToWidthRatio;
        private DevExpress.XtraEditors.ComboBoxEdit cbHeightToWidthRatio;
        private DevExpress.XtraEditors.CheckEdit checkEditValueAsPercent;
        protected DevExpress.XtraEditors.SpinEdit spinHoleRadius;
        private DevExpress.XtraEditors.LabelControl labelHoleRadius;
        private DevExpress.XtraEditors.ComboBoxEdit cbLabelPosition;
        private DevExpress.XtraEditors.LabelControl labelPosition;

    }
}
