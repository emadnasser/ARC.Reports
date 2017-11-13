namespace DevExpress.XtraCharts.Demos.DataAnalysis {
	partial class MovingAverageDemo {
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesLabel stockSeriesLabel1 = new DevExpress.XtraCharts.StockSeriesLabel();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.FinancialSlideAnimation financialSlideAnimation1 = new DevExpress.XtraCharts.FinancialSlideAnimation();
            DevExpress.XtraCharts.SimpleMovingAverage simpleMovingAverage1 = new DevExpress.XtraCharts.SimpleMovingAverage();
            DevExpress.XtraCharts.ExponentialMovingAverage exponentialMovingAverage1 = new DevExpress.XtraCharts.ExponentialMovingAverage();
            DevExpress.XtraCharts.WeightedMovingAverage weightedMovingAverage1 = new DevExpress.XtraCharts.WeightedMovingAverage();
            DevExpress.XtraCharts.TriangularMovingAverage triangularMovingAverage1 = new DevExpress.XtraCharts.TriangularMovingAverage();
            DevExpress.XtraCharts.TripleExponentialMovingAverageTema tripleExponentialMovingAverageTema1 = new DevExpress.XtraCharts.TripleExponentialMovingAverageTema();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.cbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblPointsCount = new DevExpress.XtraEditors.LabelControl();
            this.spnPointsCount = new DevExpress.XtraEditors.SpinEdit();
            this.lblKind = new DevExpress.XtraEditors.LabelControl();
            this.cbKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEnvelopPercent = new DevExpress.XtraEditors.LabelControl();
            this.spnEnvelopPercent = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(exponentialMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(weightedMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(triangularMovingAverage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tripleExponentialMovingAverageTema1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPointsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEnvelopPercent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.spnEnvelopPercent);
            this.panel.Controls.Add(this.lblEnvelopPercent);
            this.panel.Controls.Add(this.cbKind);
            this.panel.Controls.Add(this.lblKind);
            this.panel.Controls.Add(this.spnPointsCount);
            this.panel.Controls.Add(this.lblPointsCount);
            this.panel.Controls.Add(this.cbType);
            this.panel.Controls.Add(this.lblType);
            this.panel.Size = new System.Drawing.Size(697, 66);
            this.panel.Controls.SetChildIndex(this.lblType, 0);
            this.panel.Controls.SetChildIndex(this.cbType, 0);
            this.panel.Controls.SetChildIndex(this.lblPointsCount, 0);
            this.panel.Controls.SetChildIndex(this.spnPointsCount, 0);
            this.panel.Controls.SetChildIndex(this.lblKind, 0);
            this.panel.Controls.SetChildIndex(this.cbKind, 0);
            this.panel.Controls.SetChildIndex(this.lblEnvelopPercent, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.spnEnvelopPercent, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(327, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 4;
            this.checkEditShowLabels.Visible = false;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(697, 74);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 2D;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            series1.ArgumentDataMember = "Date";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            stockSeriesLabel1.TextPattern = "{CV:F2}";
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Google Inc.";
            series1.ValueDataMembersSerializable = "Low;High;Open;Close";
            financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromBottom;
            stockSeriesView1.Animation = financialSlideAnimation1;
            stockSeriesView1.Color = System.Drawing.Color.Black;
            simpleMovingAverage1.EnvelopeColor = System.Drawing.Color.Green;
            simpleMovingAverage1.Name = "Simple Moving Average";
            simpleMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close;
            exponentialMovingAverage1.EnvelopeColor = System.Drawing.Color.Green;
            exponentialMovingAverage1.Name = "Exponential Moving Average";
            exponentialMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close;
            weightedMovingAverage1.EnvelopeColor = System.Drawing.Color.Green;
            weightedMovingAverage1.Name = "Weighted Moving Average";
            weightedMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close;
            triangularMovingAverage1.EnvelopeColor = System.Drawing.Color.Green;
            triangularMovingAverage1.Name = "Triangular Moving Average";
            triangularMovingAverage1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close;
            tripleExponentialMovingAverageTema1.EnvelopeColor = System.Drawing.Color.Green;
            tripleExponentialMovingAverageTema1.Name = "Triangular Moving Average";
            tripleExponentialMovingAverageTema1.ValueLevel = DevExpress.XtraCharts.ValueLevel.Close;
            stockSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            simpleMovingAverage1,
            exponentialMovingAverage1,
            weightedMovingAverage1,
            triangularMovingAverage1,
            tripleExponentialMovingAverageTema1});
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.View = stockSeriesView2;
            this.chart.Size = new System.Drawing.Size(697, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Stock Prices";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.quandl.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(12, 12);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.EditValue = "Simple";
            this.cbType.Location = new System.Drawing.Point(46, 9);
            this.cbType.Name = "cbType";
            this.cbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbType.Properties.Items.AddRange(new object[] {
            "Simple",
            "Exponential",
            "Weighted",
            "Triangular",
            "Triple Exponential (TEMA)"});
            this.cbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbType.Size = new System.Drawing.Size(180, 20);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lblPointsCount
            // 
            this.lblPointsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPointsCount.Location = new System.Drawing.Point(538, 12);
            this.lblPointsCount.Name = "lblPointsCount";
            this.lblPointsCount.Size = new System.Drawing.Size(60, 13);
            this.lblPointsCount.TabIndex = 14;
            this.lblPointsCount.Text = "Days Count:";
            // 
            // spnPointsCount
            // 
            this.spnPointsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spnPointsCount.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnPointsCount.Location = new System.Drawing.Point(632, 9);
            this.spnPointsCount.Name = "spnPointsCount";
            this.spnPointsCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPointsCount.Properties.IsFloatValue = false;
            this.spnPointsCount.Properties.Mask.EditMask = "N00";
            this.spnPointsCount.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spnPointsCount.Properties.MinValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnPointsCount.Properties.ValidateOnEnterKey = true;
            this.spnPointsCount.Size = new System.Drawing.Size(50, 20);
            this.spnPointsCount.TabIndex = 2;
            this.spnPointsCount.EditValueChanged += new System.EventHandler(this.spnPointsCount_EditValueChanged);
            // 
            // lblKind
            // 
            this.lblKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKind.Location = new System.Drawing.Point(12, 40);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(24, 13);
            this.lblKind.TabIndex = 18;
            this.lblKind.Text = "Kind:";
            this.lblKind.Click += new System.EventHandler(this.lblKind_Click);
            // 
            // cbKind
            // 
            this.cbKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKind.EditValue = "Moving Average";
            this.cbKind.Location = new System.Drawing.Point(46, 37);
            this.cbKind.Name = "cbKind";
            this.cbKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKind.Properties.Items.AddRange(new object[] {
            "Moving Average",
            "Envelope",
            "Moving Average And Envelope"});
            this.cbKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbKind.Size = new System.Drawing.Size(180, 20);
            this.cbKind.TabIndex = 1;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // lblEnvelopPercent
            // 
            this.lblEnvelopPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnvelopPercent.Location = new System.Drawing.Point(538, 40);
            this.lblEnvelopPercent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.lblEnvelopPercent.Name = "lblEnvelopPercent";
            this.lblEnvelopPercent.Size = new System.Drawing.Size(88, 13);
            this.lblEnvelopPercent.TabIndex = 21;
            this.lblEnvelopPercent.Text = "Envelope Percent:";
            // 
            // spnEnvelopPercent
            // 
            this.spnEnvelopPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spnEnvelopPercent.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnEnvelopPercent.Location = new System.Drawing.Point(632, 37);
            this.spnEnvelopPercent.Name = "spnEnvelopPercent";
            this.spnEnvelopPercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnEnvelopPercent.Properties.IsFloatValue = false;
            this.spnEnvelopPercent.Properties.Mask.EditMask = "N00";
            this.spnEnvelopPercent.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnEnvelopPercent.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnEnvelopPercent.Properties.ValidateOnEnterKey = true;
            this.spnEnvelopPercent.Size = new System.Drawing.Size(50, 20);
            this.spnEnvelopPercent.TabIndex = 3;
            this.spnEnvelopPercent.EditValueChanged += new System.EventHandler(this.spnEnvelopPercent_EditValueChanged);
            // 
            // MovingAverageDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "MovingAverageDemo";
            this.Size = new System.Drawing.Size(697, 500);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(exponentialMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(weightedMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(triangularMovingAverage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tripleExponentialMovingAverageTema1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPointsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnEnvelopPercent.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.ComboBoxEdit cbType;
        private DevExpress.XtraEditors.LabelControl lblPointsCount;
        private DevExpress.XtraEditors.SpinEdit spnPointsCount;
        private DevExpress.XtraEditors.LabelControl lblKind;
        private DevExpress.XtraEditors.LabelControl lblEnvelopPercent;
        private DevExpress.XtraEditors.ComboBoxEdit cbKind;
        private DevExpress.XtraEditors.SpinEdit spnEnvelopPercent;

	}
}
