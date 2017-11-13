namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	partial class NestedDoughnutDemo {
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
            DevExpress.XtraCharts.NestedDoughnutSeriesLabel nestedDoughnutSeriesLabel1 = new DevExpress.XtraCharts.NestedDoughnutSeriesLabel();
            DevExpress.XtraCharts.NestedDoughnutSeriesView nestedDoughnutSeriesView1 = new DevExpress.XtraCharts.NestedDoughnutSeriesView();
            DevExpress.XtraCharts.PieWidenAnimation pieWidenAnimation1 = new DevExpress.XtraCharts.PieWidenAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.labelHoleRadius = new DevExpress.XtraEditors.LabelControl();
            this.labelIndent = new DevExpress.XtraEditors.LabelControl();
            this.cbInnerIndent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblGroup = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.spinHoleRadius = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nestedDoughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nestedDoughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInnerIndent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHoleRadius.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblGroup);
            this.panel.Controls.Add(this.radioGroup);
            this.panel.Controls.Add(this.cbInnerIndent);
            this.panel.Controls.Add(this.labelIndent);
            this.panel.Controls.Add(this.labelHoleRadius);
            this.panel.Controls.Add(this.spinHoleRadius);
            this.panel.Controls.SetChildIndex(this.spinHoleRadius, 0);
            this.panel.Controls.SetChildIndex(this.labelHoleRadius, 0);
            this.panel.Controls.SetChildIndex(this.labelIndent, 0);
            this.panel.Controls.SetChildIndex(this.cbInnerIndent, 0);
            this.panel.Controls.SetChildIndex(this.radioGroup, 0);
            this.panel.Controls.SetChildIndex(this.lblGroup, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 5;
            this.checkEditShowLabels.Visible = false;
            // 
            // chart
            // 
            this.chart.AutoLayout = false;
            this.chart.DataBindings = null;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "CountryGenderKey";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Age";
            this.chart.SeriesTemplate.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "United States"),
            new DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "Brazil"),
            new DevExpress.XtraCharts.DataFilter("Name", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "Russia")});
            this.chart.SeriesTemplate.DataFiltersConjunctionMode = DevExpress.XtraCharts.ConjunctionTypes.Or;
            nestedDoughnutSeriesLabel1.TextPattern = "{V:G2}";
            this.chart.SeriesTemplate.Label = nestedDoughnutSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.SeriesTemplate.LegendTextPattern = "{A}";
            this.chart.SeriesTemplate.ShowInLegend = false;
            this.chart.SeriesTemplate.ToolTipHintDataMember = "Gender";
            this.chart.SeriesTemplate.ToolTipPointPattern = "{HINT} : {VP:##.##%}";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Population";
            pieWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.3000000");
            nestedDoughnutSeriesView1.Animation = pieWidenAnimation1;
            this.chart.SeriesTemplate.View = nestedDoughnutSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            this.chart.TabStop = false;
            chartTitle1.Text = "Population: Age Structure";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle2.Text = "From www.cia.gov";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            chartTitle3.Font = new System.Drawing.Font("Tahoma", 12F);
            chartTitle3.Text = "Data estimate for end-2016";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2,
            chartTitle3});
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // labelHoleRadius
            // 
            this.labelHoleRadius.Location = new System.Drawing.Point(12, 12);
            this.labelHoleRadius.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelHoleRadius.Name = "labelHoleRadius";
            this.labelHoleRadius.Size = new System.Drawing.Size(82, 13);
            this.labelHoleRadius.TabIndex = 17;
            this.labelHoleRadius.Text = "Hole Radius (%):";
            // 
            // labelIndent
            // 
            this.labelIndent.Location = new System.Drawing.Point(214, 12);
            this.labelIndent.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelIndent.Name = "labelIndent";
            this.labelIndent.Size = new System.Drawing.Size(65, 13);
            this.labelIndent.TabIndex = 17;
            this.labelIndent.Text = "Inner Indent:";
            // 
            // cbInnerIndent
            // 
            this.cbInnerIndent.Location = new System.Drawing.Point(282, 9);
            this.cbInnerIndent.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.cbInnerIndent.Name = "cbInnerIndent";
            this.cbInnerIndent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbInnerIndent.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30"});
            this.cbInnerIndent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbInnerIndent.Size = new System.Drawing.Size(94, 20);
            this.cbInnerIndent.TabIndex = 18;
            this.cbInnerIndent.EditValueChanged += new System.EventHandler(this.comboInnerIndent_EditValueChanged);
            // 
            // lblGroup
            // 
            this.lblGroup.Location = new System.Drawing.Point(12, 40);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(80, 13);
            this.lblGroup.TabIndex = 19;
            this.lblGroup.Text = "Group Series by:";
            // 
            // radioGroup
            // 
            this.radioGroup.Location = new System.Drawing.Point(100, 36);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Gender"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Age")});
            this.radioGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioGroup.Size = new System.Drawing.Size(123, 22);
            this.radioGroup.TabIndex = 20;
            this.radioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup_SelectedIndexChanged);
            // 
            // spinHoleRadius
            // 
            this.spinHoleRadius.EditValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.spinHoleRadius.Location = new System.Drawing.Point(100, 9);
            this.spinHoleRadius.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
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
            this.spinHoleRadius.Size = new System.Drawing.Size(94, 20);
            this.spinHoleRadius.TabIndex = 2;
            this.spinHoleRadius.EditValueChanged += new System.EventHandler(this.spinHoleRadius_EditValueChanged);
            // 
            // NestedDoughnutDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "NestedDoughnutDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(nestedDoughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nestedDoughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInnerIndent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinHoleRadius.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelHoleRadius;
        private XtraEditors.LabelControl labelIndent;
        private XtraEditors.ComboBoxEdit cbInnerIndent;
        private XtraEditors.LabelControl lblGroup;
        private XtraEditors.RadioGroup radioGroup;
        private XtraEditors.SpinEdit spinHoleRadius;
	}
}
