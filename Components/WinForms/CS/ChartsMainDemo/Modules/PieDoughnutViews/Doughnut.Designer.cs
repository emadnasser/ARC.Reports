namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	partial class DoughnutDemo {
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Russia", new object[] {
            ((object)(17.0752D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Canada", new object[] {
            ((object)(9.98467D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("USA", new object[] {
            ((object)(9.63142D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("China", new object[] {
            ((object)(9.59696D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Brazil", new object[] {
            ((object)(8.511965D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Australia", new object[] {
            ((object)(7.68685D))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("India", new object[] {
            ((object)(3.28759D))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Others", new object[] {
            ((object)(81.2D))}, 7);
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            this.cbLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbExplodeMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.labelHoleRadius = new DevExpress.XtraEditors.LabelControl();
            this.txtHoleRadius = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExplodeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoleRadius.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelHoleRadius);
            this.panel.Controls.Add(this.txtHoleRadius);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.labelPosition);
            this.panel.Controls.Add(this.cbExplodeMode);
            this.panel.Controls.Add(this.cbLabelPosition);
            this.panel.Controls.Add(this.checkEditValueAsPercent);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditValueAsPercent, 0);
            this.panel.Controls.SetChildIndex(this.cbLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.cbExplodeMode, 0);
            this.panel.Controls.SetChildIndex(this.labelPosition, 0);
            this.panel.Controls.SetChildIndex(this.label1, 0);
            this.panel.Controls.SetChildIndex(this.txtHoleRadius, 0);
            this.panel.Controls.SetChildIndex(this.labelHoleRadius, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(584, 37);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 5;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            doughnutSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel1.ColumnIndent = 20;
            doughnutSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            doughnutSeriesLabel1.LineLength = 30;
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns;
            doughnutSeriesLabel1.TextPattern = "{A}: {VP:P2}";
            series1.Label = doughnutSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            doughnutSeriesView1.Rotation = 90;
            doughnutSeriesView1.RuntimeExploding = true;
            series1.View = doughnutSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pieSeriesLabel1.TextPattern = "{VP:G2}";
            this.chart.SeriesTemplate.Label = pieSeriesLabel1;
            pieSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart.SeriesTemplate.View = pieSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Indent = 10;
            chartTitle1.Text = "Area of Countries";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.nationmaster.com";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            this.chart.PieSeriesPointExploded += new DevExpress.XtraCharts.PieSeriesPointExplodedEventHandler(this.chart_PieSeriesPointExploded);
            // 
            // checkEditValueAsPercent
            // 
            this.checkEditValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditValueAsPercent.Location = new System.Drawing.Point(584, 9);
            this.checkEditValueAsPercent.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.checkEditValueAsPercent.Name = "checkEditValueAsPercent";
            this.checkEditValueAsPercent.Properties.Caption = "Value As Percent";
            this.checkEditValueAsPercent.Size = new System.Drawing.Size(104, 19);
            this.checkEditValueAsPercent.TabIndex = 4;
            this.checkEditValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // cbLabelPosition
            // 
            this.cbLabelPosition.Location = new System.Drawing.Point(95, 9);
            this.cbLabelPosition.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbLabelPosition.Name = "cbLabelPosition";
            this.cbLabelPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLabelPosition.Properties.Items.AddRange(new object[] {
            "Inside",
            "Outside",
            "Two Columns",
            "Radial"});
            this.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLabelPosition.Size = new System.Drawing.Size(104, 20);
            this.cbLabelPosition.TabIndex = 0;
            this.cbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbLabelPosition_SelectedIndexChanged);
            // 
            // cbExplodeMode
            // 
            this.cbExplodeMode.Location = new System.Drawing.Point(95, 37);
            this.cbExplodeMode.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.cbExplodeMode.Name = "cbExplodeMode";
            this.cbExplodeMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbExplodeMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbExplodeMode.Size = new System.Drawing.Size(104, 20);
            this.cbExplodeMode.TabIndex = 1;
            this.cbExplodeMode.SelectedIndexChanged += new System.EventHandler(this.cbExplodeMode_SelectedIndexChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.Location = new System.Drawing.Point(12, 12);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "Label Position:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exploded Points:";
            // 
            // labelHoleRadius
            // 
            this.labelHoleRadius.Location = new System.Drawing.Point(220, 12);
            this.labelHoleRadius.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelHoleRadius.Name = "labelHoleRadius";
            this.labelHoleRadius.Size = new System.Drawing.Size(82, 13);
            this.labelHoleRadius.TabIndex = 17;
            this.labelHoleRadius.Text = "Hole Radius (%):";
            // 
            // txtHoleRadius
            // 
            this.txtHoleRadius.EditValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtHoleRadius.Location = new System.Drawing.Point(305, 9);
            this.txtHoleRadius.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtHoleRadius.Name = "txtHoleRadius";
            this.txtHoleRadius.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHoleRadius.Properties.IsFloatValue = false;
            this.txtHoleRadius.Properties.Mask.EditMask = "N00";
            this.txtHoleRadius.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtHoleRadius.Properties.ValidateOnEnterKey = true;
            this.txtHoleRadius.Size = new System.Drawing.Size(94, 20);
            this.txtHoleRadius.TabIndex = 2;
            this.txtHoleRadius.EditValueChanged += new System.EventHandler(this.txtHoleRadius_EditValueChanged);
            // 
            // DoughnutDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "DoughnutDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExplodeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoleRadius.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ComboBoxEdit cbLabelPosition;
        private DevExpress.XtraEditors.ComboBoxEdit cbExplodeMode;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl labelPosition;
        private DevExpress.XtraEditors.LabelControl labelHoleRadius;
        private DevExpress.XtraEditors.SpinEdit txtHoleRadius;

	}
}