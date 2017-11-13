namespace DevExpress.XtraCharts.Demos.AreaViews {
	partial class FullStackedAreaDemo {
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
            DevExpress.XtraCharts.FullStackedAreaSeriesView fullStackedAreaSeriesView1 = new DevExpress.XtraCharts.FullStackedAreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueAsPercent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkValueAsPercent);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkValueAsPercent, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 2;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A:yyyy}";
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Title.Text = "Country";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Label.TextPattern = "{V:P0}";
            xyDiagram1.AxisY.Title.Text = "Percent";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "1";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.VisualRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "1";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Company";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Year";
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: {V}";
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            this.chart.SeriesTemplate.View = fullStackedAreaSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Market Share Over Time";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // checkValueAsPercent
            // 
            this.checkValueAsPercent.Location = new System.Drawing.Point(12, 9);
            this.checkValueAsPercent.Margin = new System.Windows.Forms.Padding(0);
            this.checkValueAsPercent.Name = "checkValueAsPercent";
            this.checkValueAsPercent.Properties.Caption = "Value As Percent";
            this.checkValueAsPercent.Size = new System.Drawing.Size(104, 19);
            this.checkValueAsPercent.TabIndex = 1;
            this.checkValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // FullStackedAreaDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "FullStackedAreaDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkValueAsPercent.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;

	}
}
