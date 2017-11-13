namespace DevExpress.XtraCharts.Demos.BarViews {
	partial class StackedBarDemo {
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
            DevExpress.XtraCharts.StackedBarSeriesLabel stackedBarSeriesLabel1 = new DevExpress.XtraCharts.StackedBarSeriesLabel();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.cbLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTextOrientation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelTextOrientation = new DevExpress.XtraEditors.LabelControl();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            this.labelIndent = new DevExpress.XtraEditors.LabelControl();
            this.spnLabelIndent = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLabelIndent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelIndent);
            this.panel.Controls.Add(this.spnLabelIndent);
            this.panel.Controls.Add(this.cbLabelPosition);
            this.panel.Controls.Add(this.cbTextOrientation);
            this.panel.Controls.Add(this.labelTextOrientation);
            this.panel.Controls.Add(this.labelPosition);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelPosition, 0);
            this.panel.Controls.SetChildIndex(this.labelTextOrientation, 0);
            this.panel.Controls.SetChildIndex(this.cbTextOrientation, 0);
            this.panel.Controls.SetChildIndex(this.cbLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.spnLabelIndent, 0);
            this.panel.Controls.SetChildIndex(this.labelIndent, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 3;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.CrosshairOptions.GroupHeaderPattern = "Country: {A}";
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Title.Text = "Countries";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0.65D;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,,}";
            xyDiagram1.AxisY.Title.Text = "Millions";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Age";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Country";
            this.chart.SeriesTemplate.CrosshairLabelPattern = "Age: {S}\nPopulation: {V:0,,.0}M";
            stackedBarSeriesLabel1.TextPattern = "{V:0,,.0}";
            this.chart.SeriesTemplate.Label = stackedBarSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Population";
            stackedBarSeriesView1.BarWidth = 0.7D;
            this.chart.SeriesTemplate.View = stackedBarSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Male Age Structure";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.cia.gov";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // cbLabelPosition
            // 
            this.cbLabelPosition.EditValue = "Center";
            this.cbLabelPosition.Location = new System.Drawing.Point(84, 9);
            this.cbLabelPosition.Name = "cbLabelPosition";
            this.cbLabelPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLabelPosition.Properties.Items.AddRange(new object[] {
            "Top Inside",
            "Center",
            "Bottom Inside"});
            this.cbLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLabelPosition.Size = new System.Drawing.Size(100, 20);
            this.cbLabelPosition.TabIndex = 0;
            this.cbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cbLabelPosition_SelectedIndexChanged);
            // 
            // cbTextOrientation
            // 
            this.cbTextOrientation.EditValue = "Horizontal";
            this.cbTextOrientation.Location = new System.Drawing.Point(84, 37);
            this.cbTextOrientation.Name = "cbTextOrientation";
            this.cbTextOrientation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTextOrientation.Properties.Items.AddRange(new object[] {
            "Horizontal",
            "Top To Bottom",
            "Bottom To Top"});
            this.cbTextOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTextOrientation.Size = new System.Drawing.Size(100, 20);
            this.cbTextOrientation.TabIndex = 2;
            this.cbTextOrientation.SelectedIndexChanged += new System.EventHandler(this.cbTextOrientation_SelectedIndexChanged);
            // 
            // labelTextOrientation
            // 
            this.labelTextOrientation.Location = new System.Drawing.Point(12, 40);
            this.labelTextOrientation.Name = "labelTextOrientation";
            this.labelTextOrientation.Size = new System.Drawing.Size(58, 13);
            this.labelTextOrientation.TabIndex = 16;
            this.labelTextOrientation.Text = "Orientation:";
            // 
            // labelPosition
            // 
            this.labelPosition.Location = new System.Drawing.Point(12, 12);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 15;
            this.labelPosition.Text = "Label Position:";
            // 
            // labelIndent
            // 
            this.labelIndent.Location = new System.Drawing.Point(200, 12);
            this.labelIndent.Margin = new System.Windows.Forms.Padding(0);
            this.labelIndent.Name = "labelIndent";
            this.labelIndent.Size = new System.Drawing.Size(64, 13);
            this.labelIndent.TabIndex = 26;
            this.labelIndent.Text = "Label Indent:";
            // 
            // spnLabelIndent
            // 
            this.spnLabelIndent.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spnLabelIndent.Location = new System.Drawing.Point(267, 9);
            this.spnLabelIndent.Name = "spnLabelIndent";
            this.spnLabelIndent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnLabelIndent.Properties.IsFloatValue = false;
            this.spnLabelIndent.Properties.Mask.EditMask = "N00";
            this.spnLabelIndent.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.spnLabelIndent.Properties.ValidateOnEnterKey = true;
            this.spnLabelIndent.Size = new System.Drawing.Size(60, 20);
            this.spnLabelIndent.TabIndex = 1;
            this.spnLabelIndent.EditValueChanged += new System.EventHandler(this.spnLabelIndent_EditValueChanged);
            // 
            // StackedBarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "StackedBarDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTextOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnLabelIndent.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ComboBoxEdit cbLabelPosition;
        private DevExpress.XtraEditors.ComboBoxEdit cbTextOrientation;
        private DevExpress.XtraEditors.LabelControl labelTextOrientation;
        private DevExpress.XtraEditors.LabelControl labelPosition;
        private DevExpress.XtraEditors.LabelControl labelIndent;
        private DevExpress.XtraEditors.SpinEdit spnLabelIndent;

	}
}
