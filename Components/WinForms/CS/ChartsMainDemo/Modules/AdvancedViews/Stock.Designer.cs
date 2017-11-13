namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	partial class StockDemo {
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
            DevExpress.XtraCharts.ElasticEasingFunction elasticEasingFunction1 = new DevExpress.XtraCharts.ElasticEasingFunction();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.comboBoxEditStockType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelStockType = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditReductionLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWorkdaysOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStockType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditReductionLevel
            // 
            this.comboBoxEditReductionLevel.TabIndex = 1;
            // 
            // comboBoxEditLabelLevel
            // 
            this.comboBoxEditLabelLevel.TabIndex = 0;
            // 
            // checkEditWorkdaysOnly
            // 
            this.checkEditWorkdaysOnly.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelStockType);
            this.panel.Controls.Add(this.comboBoxEditStockType);
            this.panel.Size = new System.Drawing.Size(697, 38);
            this.panel.Controls.SetChildIndex(this.checkEditWorkdaysOnly, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditReductionLevel, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelLevel, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditStockType, 0);
            this.panel.Controls.SetChildIndex(this.labelStockType, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 4;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(697, 46);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A:d}";
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Title.Text = "Date";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 2D;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Title.Text = "US Dollars";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "855";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "665";
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "855";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "665";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.CrosshairLabelPattern = "High: {HV}\nLow: {LV}\nOpen: {OV}\nClose: {CV}";
            stockSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped;
            stockSeriesLabel1.TextPattern = "{CV:F2}";
            series1.Label = stockSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Google Inc.";
            financialSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromBottom;
            elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out;
            financialSlideAnimation1.EasingFunction = elasticEasingFunction1;
            stockSeriesView1.Animation = financialSlideAnimation1;
            stockSeriesView1.Color = System.Drawing.Color.Black;
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(697, 454);
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
            // 
            // comboBoxEditStockType
            // 
            this.comboBoxEditStockType.EditValue = "";
            this.comboBoxEditStockType.Location = new System.Drawing.Point(403, 9);
            this.comboBoxEditStockType.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.comboBoxEditStockType.Name = "comboBoxEditStockType";
            this.comboBoxEditStockType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditStockType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditStockType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditStockType.TabIndex = 2;
            this.comboBoxEditStockType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditStockType_SelectedIndexChanged);
            // 
            // labelStockType
            // 
            this.labelStockType.Location = new System.Drawing.Point(343, 12);
            this.labelStockType.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelStockType.Name = "labelStockType";
            this.labelStockType.Size = new System.Drawing.Size(57, 13);
            this.labelStockType.TabIndex = 15;
            this.labelStockType.Text = "Stock Type:";
            // 
            // StockDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "StockDemo";
            this.Size = new System.Drawing.Size(697, 500);
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditReductionLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWorkdaysOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStockType.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelStockType;

	}
}
