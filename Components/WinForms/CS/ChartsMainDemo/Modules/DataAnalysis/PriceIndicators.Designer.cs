namespace DevExpress.XtraCharts.Demos.DataAnalysis {
    partial class PriceIndicatorsDemo {
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
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.MedianPrice medianPrice1 = new DevExpress.XtraCharts.MedianPrice();
            DevExpress.XtraCharts.TypicalPrice typicalPrice1 = new DevExpress.XtraCharts.TypicalPrice();
            DevExpress.XtraCharts.WeightedClose weightedClose1 = new DevExpress.XtraCharts.WeightedClose();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblIndicator = new DevExpress.XtraEditors.LabelControl();
            this.cbePriceIndicator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbDashStyle = new DevExpress.XtraEditors.LabelControl();
            this.cbDashStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clreColor = new DevExpress.XtraEditors.ColorEdit();
            this.lbColor = new DevExpress.XtraEditors.LabelControl();
            this.lbThickness = new DevExpress.XtraEditors.LabelControl();
            this.speThickness = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(medianPrice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(typicalPrice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(weightedClose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbePriceIndicator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDashStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clreColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speThickness.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lbDashStyle);
            this.panel.Controls.Add(this.cbDashStyle);
            this.panel.Controls.Add(this.clreColor);
            this.panel.Controls.Add(this.lbColor);
            this.panel.Controls.Add(this.lbThickness);
            this.panel.Controls.Add(this.speThickness);
            this.panel.Controls.Add(this.cbePriceIndicator);
            this.panel.Controls.Add(this.lblIndicator);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.lblIndicator, 0);
            this.panel.Controls.SetChildIndex(this.cbePriceIndicator, 0);
            this.panel.Controls.SetChildIndex(this.speThickness, 0);
            this.panel.Controls.SetChildIndex(this.lbThickness, 0);
            this.panel.Controls.SetChildIndex(this.lbColor, 0);
            this.panel.Controls.SetChildIndex(this.clreColor, 0);
            this.panel.Controls.SetChildIndex(this.cbDashStyle, 0);
            this.panel.Controls.SetChildIndex(this.lbDashStyle, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(-55, -20);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOptions.Holidays.AddRange(new DevExpress.XtraCharts.KnownDate[] {
            new DevExpress.XtraCharts.KnownDate("Christmas Day", new System.DateTime(2007, 12, 25, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("New Year\'s Day", new System.DateTime(2008, 1, 1, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Martin Luther King Day", new System.DateTime(2008, 1, 21, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Presidents\' Day", new System.DateTime(2008, 2, 18, 0, 0, 0, 0)),
            new DevExpress.XtraCharts.KnownDate("Good Friday", new System.DateTime(2008, 3, 21, 0, 0, 0, 0))});
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Apple Inc.";
            series1.ValueDataMembersSerializable = "Low;High;Open;Close";
            medianPrice1.LineStyle.Thickness = 2;
            medianPrice1.Name = "Median Price";
            medianPrice1.ShowInLegend = true;
            typicalPrice1.LineStyle.Thickness = 2;
            typicalPrice1.Name = "Typical Price";
            typicalPrice1.ShowInLegend = true;
            weightedClose1.LineStyle.Thickness = 2;
            weightedClose1.Name = "Weighted Close";
            weightedClose1.ShowInLegend = true;
            stockSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            medianPrice1,
            typicalPrice1,
            weightedClose1});
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.View = stockSeriesView2;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 3;
            chartTitle1.Text = "Stock Prices";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // lblIndicator
            // 
            this.lblIndicator.Location = new System.Drawing.Point(12, 12);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(73, 13);
            this.lblIndicator.TabIndex = 7;
            this.lblIndicator.Text = "Price Indicator:";
            // 
            // cbePriceIndicator
            // 
            this.cbePriceIndicator.EditValue = "";
            this.cbePriceIndicator.Location = new System.Drawing.Point(91, 9);
            this.cbePriceIndicator.Name = "cbePriceIndicator";
            this.cbePriceIndicator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbePriceIndicator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbePriceIndicator.Size = new System.Drawing.Size(110, 20);
            this.cbePriceIndicator.TabIndex = 8;
            this.cbePriceIndicator.SelectedIndexChanged += new System.EventHandler(this.cbePriceIndicator_SelectedIndexChanged);
            // 
            // lbDashStyle
            // 
            this.lbDashStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDashStyle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbDashStyle.Location = new System.Drawing.Point(533, 8);
            this.lbDashStyle.Name = "lbDashStyle";
            this.lbDashStyle.Size = new System.Drawing.Size(56, 20);
            this.lbDashStyle.TabIndex = 25;
            this.lbDashStyle.Text = "Dash Style:";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDashStyle.Location = new System.Drawing.Point(595, 9);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDashStyle.Properties.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbDashStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDashStyle.Size = new System.Drawing.Size(90, 20);
            this.cbDashStyle.TabIndex = 21;
            this.cbDashStyle.SelectedIndexChanged += new System.EventHandler(this.cbDashStyle_SelectedIndexChanged);
            // 
            // clreColor
            // 
            this.clreColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clreColor.EditValue = System.Drawing.Color.Empty;
            this.clreColor.EnterMoveNextControl = true;
            this.clreColor.Location = new System.Drawing.Point(399, 9);
            this.clreColor.Name = "clreColor";
            this.clreColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clreColor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.clreColor.Size = new System.Drawing.Size(110, 20);
            this.clreColor.TabIndex = 20;
            this.clreColor.EditValueChanged += new System.EventHandler(this.clreColor_EditValueChanged);
            // 
            // lbColor
            // 
            this.lbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbColor.Location = new System.Drawing.Point(361, 8);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(32, 20);
            this.lbColor.TabIndex = 24;
            this.lbColor.Text = "Color:";
            // 
            // lbThickness
            // 
            this.lbThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThickness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbThickness.Location = new System.Drawing.Point(221, 8);
            this.lbThickness.Name = "lbThickness";
            this.lbThickness.Size = new System.Drawing.Size(50, 20);
            this.lbThickness.TabIndex = 23;
            this.lbThickness.Text = "Thickness:";
            // 
            // speThickness
            // 
            this.speThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.speThickness.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speThickness.Location = new System.Drawing.Point(277, 9);
            this.speThickness.Name = "speThickness";
            this.speThickness.Properties.Appearance.Options.UseTextOptions = true;
            this.speThickness.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.speThickness.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speThickness.Properties.IsFloatValue = false;
            this.speThickness.Properties.Mask.EditMask = "N00";
            this.speThickness.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speThickness.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speThickness.Properties.ValidateOnEnterKey = true;
            this.speThickness.Size = new System.Drawing.Size(60, 20);
            this.speThickness.TabIndex = 22;
            this.speThickness.EditValueChanged += new System.EventHandler(this.speThickness_EditValueChanged);
            // 
            // PriceIndicatorsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "PriceIndicatorsDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(medianPrice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(typicalPrice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(weightedClose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbePriceIndicator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDashStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clreColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speThickness.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartControl chart;
        private DevExpress.XtraEditors.ComboBoxEdit cbePriceIndicator;
        private DevExpress.XtraEditors.LabelControl lblIndicator;
        private XtraEditors.LabelControl lbDashStyle;
        private XtraEditors.ComboBoxEdit cbDashStyle;
        private XtraEditors.ColorEdit clreColor;
        private XtraEditors.LabelControl lbColor;
        private XtraEditors.LabelControl lbThickness;
        private XtraEditors.SpinEdit speThickness;
    }
}
