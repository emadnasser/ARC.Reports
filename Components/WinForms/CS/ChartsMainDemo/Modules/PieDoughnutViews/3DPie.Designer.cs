namespace DevExpress.XtraCharts.Demos.PieDoughnutViews {
	partial class Pie3dDemo {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D7 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel7 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint49 = new DevExpress.XtraCharts.SeriesPoint("Russia", new object[] {
            ((object)(17.0752D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint50 = new DevExpress.XtraCharts.SeriesPoint("Canada", new object[] {
            ((object)(9.98467D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint51 = new DevExpress.XtraCharts.SeriesPoint("USA", new object[] {
            ((object)(9.63142D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint52 = new DevExpress.XtraCharts.SeriesPoint("China", new object[] {
            ((object)(9.59696D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint53 = new DevExpress.XtraCharts.SeriesPoint("Brazil", new object[] {
            ((object)(8.511965D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint54 = new DevExpress.XtraCharts.SeriesPoint("Australia", new object[] {
            ((object)(7.68685D))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint55 = new DevExpress.XtraCharts.SeriesPoint("India", new object[] {
            ((object)(3.28759D))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint56 = new DevExpress.XtraCharts.SeriesPoint("Others", new object[] {
            ((object)(81.2D))}, 7);
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView7 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle13 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle14 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            this.cbExplodeMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLabelPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDistance = new DevExpress.XtraEditors.SpinEdit();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExplodeMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(271, 36);
            this.btnDefaultAngles.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.labelPosition);
            this.panel.Controls.Add(this.txtDistance);
            this.panel.Controls.Add(this.cbExplodeMode);
            this.panel.Controls.Add(this.cbLabelPosition);
            this.panel.Controls.Add(this.checkEditValueAsPercent);
            this.panel.Margin = new System.Windows.Forms.Padding(7);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditValueAsPercent, 0);
            this.panel.Controls.SetChildIndex(this.cbLabelPosition, 0);
            this.panel.Controls.SetChildIndex(this.cbExplodeMode, 0);
            this.panel.Controls.SetChildIndex(this.txtDistance, 0);
            this.panel.Controls.SetChildIndex(this.labelPosition, 0);
            this.panel.Controls.SetChildIndex(this.label1, 0);
            this.panel.Controls.SetChildIndex(this.labelControl1, 0);
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
            simpleDiagram3D7.LabelsResolveOverlappingMinIndent = 3;
            simpleDiagram3D7.RotationMatrixSerializable = "0.965925826289068;0.258819045102521;0;0;-0.212012149896655;0.791240115236224;-0.5" +
    "73576436351046;0;-0.148452505549685;0.554032293222323;0.819152044288992;0;0;0;0;" +
    "1";
            simpleDiagram3D7.RuntimeRotation = true;
            simpleDiagram3D7.RuntimeScrolling = true;
            simpleDiagram3D7.RuntimeZooming = true;
            this.chart.Diagram = simpleDiagram3D7;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            pie3DSeriesLabel7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            pie3DSeriesLabel7.TextPattern = "{A}: {VP:P2}";
            series7.Label = pie3DSeriesLabel7;
            series7.LegendTextPattern = "{A}";
            series7.Name = "Series 1";
            series7.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint49,
            seriesPoint50,
            seriesPoint51,
            seriesPoint52,
            seriesPoint53,
            seriesPoint54,
            seriesPoint55,
            seriesPoint56});
            series7.View = pie3DSeriesView7;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7};
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle13.Indent = 10;
            chartTitle13.Text = "Area of Countries";
            chartTitle14.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle14.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle14.Font = new System.Drawing.Font("Tahoma", 8F);
            chartTitle14.Text = "From www.nationmaster.com";
            chartTitle14.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle13,
            chartTitle14});
            // 
            // checkEditValueAsPercent
            // 
            this.checkEditValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditValueAsPercent.Location = new System.Drawing.Point(584, 9);
            this.checkEditValueAsPercent.Margin = new System.Windows.Forms.Padding(0);
            this.checkEditValueAsPercent.Name = "checkEditValueAsPercent";
            this.checkEditValueAsPercent.Properties.Caption = "Value As Percent";
            this.checkEditValueAsPercent.Size = new System.Drawing.Size(105, 19);
            this.checkEditValueAsPercent.TabIndex = 4;
            this.checkEditValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
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
            // cbLabelPosition
            // 
            this.cbLabelPosition.Location = new System.Drawing.Point(95, 9);
            this.cbLabelPosition.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
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
            this.cbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // txtDistance
            // 
            this.txtDistance.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDistance.Location = new System.Drawing.Point(331, 9);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDistance.Properties.IsFloatValue = false;
            this.txtDistance.Properties.Mask.EditMask = "N00";
            this.txtDistance.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtDistance.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDistance.Properties.ValidateOnEnterKey = true;
            this.txtDistance.Size = new System.Drawing.Size(68, 20);
            this.txtDistance.TabIndex = 2;
            this.txtDistance.EditValueChanged += new System.EventHandler(this.txtDistance_EditValueChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.Location = new System.Drawing.Point(12, 12);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(69, 13);
            this.labelPosition.TabIndex = 13;
            this.labelPosition.Text = "Label Position:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Exploded Points:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(220, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Explode Distance (%):";
            // 
            // Pie3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "Pie3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbExplodeMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLabelPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistance.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ComboBoxEdit cbExplodeMode;
        private DevExpress.XtraEditors.ComboBoxEdit cbLabelPosition;
        private DevExpress.XtraEditors.SpinEdit txtDistance;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl labelPosition;

	}
}
