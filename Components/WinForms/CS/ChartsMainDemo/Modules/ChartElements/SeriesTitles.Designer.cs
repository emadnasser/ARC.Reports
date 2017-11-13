namespace DevExpress.XtraCharts.Demos.ChartElements {
    partial class SeriesTitlesDemo {
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
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.comboBoxViewType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelViewType = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxViewType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelViewType);
            this.panel.Controls.Add(this.comboBoxViewType);
            this.panel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxViewType, 0);
            this.panel.Controls.SetChildIndex(this.labelViewType, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 3;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.AutoLayout = false;
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.DataBindings = null;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.MaxHorizontalPercentage = 60D;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Region";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "ProductCategory";
            pieSeriesLabel1.TextPattern = "${V:F1}M";
            this.chart.SeriesTemplate.Label = pieSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.SeriesTemplate.LegendTextPattern = "{A}";
            this.chart.SeriesTemplate.ToolTipPointPattern = "{A}: {V}K ({VP:0.0%})";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            seriesTitle1.Font = new System.Drawing.Font("Tahoma", 16F);
            pieSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            this.chart.SeriesTemplate.View = pieSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 454);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "DevAV Sales Mix by Region";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.chart.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chart_CustomDrawSeriesPoint);
            // 
            // comboBoxViewType
            // 
            this.comboBoxViewType.EditValue = "Pie";
            this.comboBoxViewType.Location = new System.Drawing.Point(71, 9);
            this.comboBoxViewType.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.comboBoxViewType.Name = "comboBoxViewType";
            this.comboBoxViewType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxViewType.Properties.Items.AddRange(new object[] {
            "Pie",
            "Pie 3D",
            "Doughnut",
            "Doughnut 3D"});
            this.comboBoxViewType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxViewType.Size = new System.Drawing.Size(90, 20);
            this.comboBoxViewType.TabIndex = 2;
            this.comboBoxViewType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditSeriesDataMember_SelectedIndexChanged);
            // 
            // labelViewType
            // 
            this.labelViewType.Location = new System.Drawing.Point(12, 12);
            this.labelViewType.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelViewType.Name = "labelViewType";
            this.labelViewType.Size = new System.Drawing.Size(53, 13);
            this.labelViewType.TabIndex = 59;
            this.labelViewType.Text = "View Type:";
            // 
            // SeriesTitlesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SeriesTitlesDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxViewType.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private ChartControl chart;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxViewType;
        private DevExpress.XtraEditors.LabelControl labelViewType;

	}
}
