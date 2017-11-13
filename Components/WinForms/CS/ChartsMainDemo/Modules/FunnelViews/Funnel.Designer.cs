namespace DevExpress.XtraCharts.Demos.FunnelViews {
    partial class FunnelDemo {
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram2 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FunnelSeriesLabel funnelSeriesLabel2 = new DevExpress.XtraCharts.FunnelSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Visited a Website", new object[] {
            ((object)(9152D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", new object[] {
            ((object)(6870D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Contacted to Support", new object[] {
            ((object)(5121D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("Subscribed", new object[] {
            ((object)(2224D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("Renewed", new object[] {
            ((object)(1670D))});
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView2 = new DevExpress.XtraCharts.FunnelSeriesView();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            this.cbLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditHeightToWidthRatioAuto = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditAlignToCenter = new DevExpress.XtraEditors.CheckEdit();
            this.cbHeightToWidthRatio = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelHeightToWidthRatio = new DevExpress.XtraEditors.LabelControl();
            this.labelPointDistance = new DevExpress.XtraEditors.LabelControl();
            this.spinPointDistance = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHeightToWidthRatioAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAlignToCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeightToWidthRatio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPointDistance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spinPointDistance);
            this.panel.Controls.Add(this.labelPointDistance);
            this.panel.Controls.Add(this.labelHeightToWidthRatio);
            this.panel.Controls.Add(this.cbHeightToWidthRatio);
            this.panel.Controls.Add(this.checkEditAlignToCenter);
            this.panel.Controls.Add(this.checkEditHeightToWidthRatioAuto);
            this.panel.Controls.Add(this.checkEditValueAsPercent);
            this.panel.Controls.Add(this.cbLabelPosition);
            this.panel.Controls.Add(this.labelPosition);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelPosition, 0);
            this.panel.Controls.SetChildIndex(this.cbLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.checkEditValueAsPercent, 0);
            this.panel.Controls.SetChildIndex(this.checkEditHeightToWidthRatioAuto, 0);
            this.panel.Controls.SetChildIndex(this.checkEditAlignToCenter, 0);
            this.panel.Controls.SetChildIndex(this.cbHeightToWidthRatio, 0);
            this.panel.Controls.SetChildIndex(this.labelHeightToWidthRatio, 0);
            this.panel.Controls.SetChildIndex(this.labelPointDistance, 0);
            this.panel.Controls.SetChildIndex(this.spinPointDistance, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(584, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 9;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            simpleDiagram2.Margins.Bottom = 10;
            simpleDiagram2.Margins.Left = 10;
            simpleDiagram2.Margins.Right = 10;
            simpleDiagram2.Margins.Top = 10;
            this.chart.Diagram = simpleDiagram2;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            funnelSeriesLabel2.TextPattern = "{A}: {VP:P0}";
            series2.Label = funnelSeriesLabel2;
            series2.LegendTextPattern = "{A}: {VP:P0}";
            series2.Name = "Series 1";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10});
            series2.View = funnelSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chart.SeriesTemplate.View = pointSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle2.Text = "Website Visitor Trend";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPosition.Location = new System.Drawing.Point(409, 12);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Label Position:";
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
            this.cbLabelPosition.TabIndex = 7;
            this.cbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbLabelPosition_SelectedIndexChanged);
            // 
            // checkEditValueAsPercent
            // 
            this.checkEditValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditValueAsPercent.Location = new System.Drawing.Point(584, 9);
            this.checkEditValueAsPercent.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.checkEditValueAsPercent.Name = "checkEditValueAsPercent";
            this.checkEditValueAsPercent.Properties.Caption = "Value as Percent";
            this.checkEditValueAsPercent.Size = new System.Drawing.Size(105, 19);
            this.checkEditValueAsPercent.TabIndex = 8;
            this.checkEditValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // checkEditHeightToWidthRatioAuto
            // 
            this.checkEditHeightToWidthRatioAuto.Location = new System.Drawing.Point(156, 37);
            this.checkEditHeightToWidthRatioAuto.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.checkEditHeightToWidthRatioAuto.Name = "checkEditHeightToWidthRatioAuto";
            this.checkEditHeightToWidthRatioAuto.Properties.Caption = "Auto";
            this.checkEditHeightToWidthRatioAuto.Size = new System.Drawing.Size(49, 19);
            this.checkEditHeightToWidthRatioAuto.TabIndex = 5;
            this.checkEditHeightToWidthRatioAuto.CheckedChanged += new System.EventHandler(this.checkEditHeightToWidthRatioAuto_CheckedChanged);
            // 
            // checkEditAlignToCenter
            // 
            this.checkEditAlignToCenter.Location = new System.Drawing.Point(156, 9);
            this.checkEditAlignToCenter.Name = "checkEditAlignToCenter";
            this.checkEditAlignToCenter.Properties.Caption = "Align to Center";
            this.checkEditAlignToCenter.Size = new System.Drawing.Size(99, 19);
            this.checkEditAlignToCenter.TabIndex = 4;
            this.checkEditAlignToCenter.CheckedChanged += new System.EventHandler(this.checkEditAlignToCenter_CheckedChanged);
            // 
            // cbHeightToWidthRatio
            // 
            this.cbHeightToWidthRatio.Location = new System.Drawing.Point(88, 37);
            this.cbHeightToWidthRatio.Margin = new System.Windows.Forms.Padding(0, 0, 5, 10);
            this.cbHeightToWidthRatio.Name = "cbHeightToWidthRatio";
            this.cbHeightToWidthRatio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbHeightToWidthRatio.Size = new System.Drawing.Size(50, 20);
            this.cbHeightToWidthRatio.TabIndex = 3;
            this.cbHeightToWidthRatio.SelectedIndexChanged += new System.EventHandler(this.cbHeightToWidthRatio_SelectedIndexChanged);
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
            // labelPointDistance
            // 
            this.labelPointDistance.Location = new System.Drawing.Point(12, 12);
            this.labelPointDistance.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelPointDistance.Name = "labelPointDistance";
            this.labelPointDistance.Size = new System.Drawing.Size(72, 13);
            this.labelPointDistance.TabIndex = 0;
            this.labelPointDistance.Text = "Point Distance:";
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
            this.spinPointDistance.Size = new System.Drawing.Size(50, 20);
            this.spinPointDistance.TabIndex = 1;
            this.spinPointDistance.EditValueChanged += new System.EventHandler(this.spinPointDistance_EditValueChanged);
            // 
            // FunnelDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "FunnelDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHeightToWidthRatioAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAlignToCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHeightToWidthRatio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinPointDistance.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.LabelControl labelPosition;
        private DevExpress.XtraEditors.ComboBoxEdit cbLabelPosition;
        private DevExpress.XtraEditors.CheckEdit checkEditValueAsPercent;
        private DevExpress.XtraEditors.CheckEdit checkEditHeightToWidthRatioAuto;
        private DevExpress.XtraEditors.CheckEdit checkEditAlignToCenter;
        private DevExpress.XtraEditors.ComboBoxEdit cbHeightToWidthRatio;
        private DevExpress.XtraEditors.LabelControl labelHeightToWidthRatio;
        private DevExpress.XtraEditors.LabelControl labelPointDistance;
        protected DevExpress.XtraEditors.SpinEdit spinPointDistance;

    }
}
