namespace DevExpress.XtraCharts.Demos.BarViews {
	partial class ManhattanBarDemo {
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Bar3DSeriesLabel bar3DSeriesLabel1 = new DevExpress.XtraCharts.Bar3DSeriesLabel();
            DevExpress.XtraCharts.ManhattanBarSeriesView manhattanBarSeriesView1 = new DevExpress.XtraCharts.ManhattanBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.comboBoxEditPerspective = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelPerspective = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxBar3DModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3DModel = new DevExpress.XtraEditors.LabelControl();
            this.checkEditShowFacet = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBar3DModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowFacet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(200, 8);
            this.btnDefaultAngles.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnDefaultAngles.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditShowFacet);
            this.panel.Controls.Add(this.comboBoxBar3DModel);
            this.panel.Controls.Add(this.label3DModel);
            this.panel.Controls.Add(this.labelPerspective);
            this.panel.Controls.Add(this.comboBoxEditPerspective);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.labelPerspective, 0);
            this.panel.Controls.SetChildIndex(this.label3DModel, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxBar3DModel, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowFacet, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisY.Label.TextPattern = "${V}M";
            xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram3D1.AxisY.NumericScaleOptions.GridSpacing = 100D;
            xyDiagram3D1.RotationType = DevExpress.XtraCharts.RotationType.UseAngles;
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 6D;
            xyDiagram3D1.ZoomPercent = 130;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "Year";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending;
            this.chart.SeriesTemplate.ArgumentDataMember = "Region";
            bar3DSeriesLabel1.TextPattern = "{V:n2}";
            this.chart.SeriesTemplate.Label = bar3DSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            this.chart.SeriesTemplate.View = manhattanBarSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "DevAV Sales by Regions";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // comboBoxEditPerspective
            // 
            this.comboBoxEditPerspective.EditValue = "";
            this.comboBoxEditPerspective.Location = new System.Drawing.Point(105, 9);
            this.comboBoxEditPerspective.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.comboBoxEditPerspective.Name = "comboBoxEditPerspective";
            this.comboBoxEditPerspective.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPerspective.Size = new System.Drawing.Size(78, 20);
            this.comboBoxEditPerspective.TabIndex = 0;
            this.comboBoxEditPerspective.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPerspective_SelectedIndexChanged);
            // 
            // labelPerspective
            // 
            this.labelPerspective.Location = new System.Drawing.Point(12, 12);
            this.labelPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPerspective.Name = "labelPerspective";
            this.labelPerspective.Size = new System.Drawing.Size(90, 13);
            this.labelPerspective.TabIndex = 13;
            this.labelPerspective.Text = "Perspective Angle:";
            // 
            // comboBoxBar3DModel
            // 
            this.comboBoxBar3DModel.Location = new System.Drawing.Point(105, 37);
            this.comboBoxBar3DModel.Name = "comboBoxBar3DModel";
            this.comboBoxBar3DModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxBar3DModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxBar3DModel.Size = new System.Drawing.Size(78, 20);
            this.comboBoxBar3DModel.TabIndex = 58;
            this.comboBoxBar3DModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxBar3DModel_SelectedIndexChanged);
            // 
            // label3DModel
            // 
            this.label3DModel.Location = new System.Drawing.Point(12, 40);
            this.label3DModel.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.label3DModel.Name = "label3DModel";
            this.label3DModel.Size = new System.Drawing.Size(48, 13);
            this.label3DModel.TabIndex = 57;
            this.label3DModel.Text = "3D Model:";
            // 
            // checkEditShowFacet
            // 
            this.checkEditShowFacet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditShowFacet.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowFacet.Name = "checkEditShowFacet";
            this.checkEditShowFacet.Properties.Caption = "Show Facet";
            this.checkEditShowFacet.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowFacet.TabIndex = 60;
            this.checkEditShowFacet.CheckedChanged += new System.EventHandler(this.checkEditShowFacet_CheckedChanged);
            // 
            // ManhattanBarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ManhattanBarDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bar3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(manhattanBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBar3DModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowFacet.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelPerspective;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxBar3DModel;
        private DevExpress.XtraEditors.LabelControl label3DModel;
        private DevExpress.XtraEditors.CheckEdit checkEditShowFacet;

	}
}
