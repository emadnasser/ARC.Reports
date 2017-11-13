namespace DevExpress.XtraCharts.Demos.AreaViews {
	partial class AreaDemo {
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
            DevExpress.XtraCharts.CrosshairFreePosition crosshairFreePosition1 = new DevExpress.XtraCharts.CrosshairFreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.comboTransparencies = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditLabelAngle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditMarkerKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditMarkerSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditShowMarkers = new DevExpress.XtraEditors.CheckEdit();
            this.labelMarkerKind = new DevExpress.XtraEditors.LabelControl();
            this.labelMarkerSize = new DevExpress.XtraEditors.LabelControl();
            this.labelAngle = new DevExpress.XtraEditors.LabelControl();
            this.labelTransparency = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelTransparency);
            this.panel.Controls.Add(this.labelAngle);
            this.panel.Controls.Add(this.labelMarkerSize);
            this.panel.Controls.Add(this.labelMarkerKind);
            this.panel.Controls.Add(this.checkEditShowMarkers);
            this.panel.Controls.Add(this.comboBoxEditLabelAngle);
            this.panel.Controls.Add(this.comboBoxEditMarkerKind);
            this.panel.Controls.Add(this.comboBoxEditMarkerSize);
            this.panel.Controls.Add(this.comboTransparencies);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboTransparencies, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowMarkers, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelTransparency, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 6;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            crosshairFreePosition1.DockCorner = DevExpress.XtraCharts.DockCorner.RightTop;
            crosshairFreePosition1.DockTargetName = "Default Pane";
            this.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1;
            this.chart.CrosshairOptions.GroupHeaderPattern = "Year: {A:yyyy}";
            this.chart.DataBindings = null;
            xyDiagram1.AxisX.Label.MaxWidth = 70;
            xyDiagram1.AxisX.Title.Text = "Corporation";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 75D;
            xyDiagram1.AxisY.Title.Text = "Thousands US$";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Company";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Year";
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S}: ${V:0.0}K";
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Costs";
            this.chart.SeriesTemplate.View = areaSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 12;
            this.chart.TabStop = false;
            chartTitle1.Text = "Outside Vendor Costs";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // comboTransparencies
            // 
            this.comboTransparencies.Location = new System.Drawing.Point(266, 37);
            this.comboTransparencies.Margin = new System.Windows.Forms.Padding(3, 10, 10, 0);
            this.comboTransparencies.Name = "comboTransparencies";
            this.comboTransparencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransparencies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboTransparencies.Size = new System.Drawing.Size(60, 20);
            this.comboTransparencies.TabIndex = 3;
            this.comboTransparencies.SelectedIndexChanged += new System.EventHandler(this.comboTransparencies_SelectedIndexChanged);
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.EditValue = "";
            this.comboBoxEditLabelAngle.Location = new System.Drawing.Point(266, 9);
            this.comboBoxEditLabelAngle.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.comboBoxEditLabelAngle.Name = "comboBoxEditLabelAngle";
            this.comboBoxEditLabelAngle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLabelAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditLabelAngle.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEditLabelAngle.TabIndex = 2;
            this.comboBoxEditLabelAngle.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLabelAngle_SelectedIndexChanged);
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.EditValue = "";
            this.comboBoxEditMarkerKind.Location = new System.Drawing.Point(75, 9);
            this.comboBoxEditMarkerKind.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind";
            this.comboBoxEditMarkerKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerKind.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditMarkerKind.TabIndex = 0;
            this.comboBoxEditMarkerKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerKind_SelectedIndexChanged);
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.EditValue = "";
            this.comboBoxEditMarkerSize.Location = new System.Drawing.Point(75, 37);
            this.comboBoxEditMarkerSize.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize";
            this.comboBoxEditMarkerSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerSize.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEditMarkerSize.TabIndex = 1;
            this.comboBoxEditMarkerSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerSize_SelectedIndexChanged);
            // 
            // checkEditShowMarkers
            // 
            this.checkEditShowMarkers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditShowMarkers.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowMarkers.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.checkEditShowMarkers.Name = "checkEditShowMarkers";
            this.checkEditShowMarkers.Properties.Caption = "Show Markers";
            this.checkEditShowMarkers.Size = new System.Drawing.Size(90, 19);
            this.checkEditShowMarkers.TabIndex = 5;
            this.checkEditShowMarkers.CheckedChanged += new System.EventHandler(this.checkEditShowMarkers_CheckedChanged);
            // 
            // labelMarkerKind
            // 
            this.labelMarkerKind.Location = new System.Drawing.Point(12, 12);
            this.labelMarkerKind.Margin = new System.Windows.Forms.Padding(10, 0, 3, 10);
            this.labelMarkerKind.Name = "labelMarkerKind";
            this.labelMarkerKind.Size = new System.Drawing.Size(60, 13);
            this.labelMarkerKind.TabIndex = 1;
            this.labelMarkerKind.Text = "Marker Kind:";
            // 
            // labelMarkerSize
            // 
            this.labelMarkerSize.Location = new System.Drawing.Point(12, 40);
            this.labelMarkerSize.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.labelMarkerSize.Name = "labelMarkerSize";
            this.labelMarkerSize.Size = new System.Drawing.Size(59, 13);
            this.labelMarkerSize.TabIndex = 3;
            this.labelMarkerSize.Text = "Marker Size:";
            // 
            // labelAngle
            // 
            this.labelAngle.Location = new System.Drawing.Point(193, 12);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(59, 13);
            this.labelAngle.TabIndex = 5;
            this.labelAngle.Text = "Label Angle:";
            // 
            // labelTransparency
            // 
            this.labelTransparency.Location = new System.Drawing.Point(193, 40);
            this.labelTransparency.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(70, 13);
            this.labelTransparency.TabIndex = 7;
            this.labelTransparency.Text = "Transparency:";
            // 
            // AreaDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "AreaDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowMarkers.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.IContainer components = null;
		MarkerKindItemCollection itemCollection;
        private DevExpress.XtraEditors.LabelControl labelAngle;
        private DevExpress.XtraEditors.LabelControl labelMarkerSize;
        private DevExpress.XtraEditors.LabelControl labelMarkerKind;
        private DevExpress.XtraEditors.LabelControl labelTransparency;
        private DevExpress.XtraEditors.ComboBoxEdit comboTransparencies;

	}
}
