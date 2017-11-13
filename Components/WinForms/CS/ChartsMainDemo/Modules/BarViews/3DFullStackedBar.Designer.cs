namespace DevExpress.XtraCharts.Demos.BarViews {
	partial class FullStackedBar3dDemo {
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
            DevExpress.XtraCharts.FullStackedBar3DSeriesView fullStackedBar3DSeriesView1 = new DevExpress.XtraCharts.FullStackedBar3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.checkEditValueAsPercent = new DevExpress.XtraEditors.CheckEdit();
            this.labelPerspective = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditPerspective = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxBar3DModel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3DModel = new DevExpress.XtraEditors.LabelControl();
            this.checkEditShowFacet = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBar3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBar3DModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowFacet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(200, 8);
            this.btnDefaultAngles.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditShowFacet);
            this.panel.Controls.Add(this.comboBoxBar3DModel);
            this.panel.Controls.Add(this.label3DModel);
            this.panel.Controls.Add(this.labelPerspective);
            this.panel.Controls.Add(this.comboBoxEditPerspective);
            this.panel.Controls.Add(this.checkEditValueAsPercent);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.checkEditValueAsPercent, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.labelPerspective, 0);
            this.panel.Controls.SetChildIndex(this.label3DModel, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxBar3DModel, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowFacet, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.TabIndex = 3;
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            xyDiagram3D1.AxisY.Label.TextPattern = "{V:P0}";
            xyDiagram3D1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram3D1.AxisY.WholeRange.SideMarginsValue = 0D;
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
    "1";
            xyDiagram3D1.RuntimeRotation = true;
            xyDiagram3D1.RuntimeScrolling = true;
            xyDiagram3D1.RuntimeZooming = true;
            xyDiagram3D1.VerticalScrollPercent = 6D;
            xyDiagram3D1.ZoomPercent = 130;
            this.chart.Diagram = xyDiagram3D1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 74);
            this.chart.Name = "chart";
            this.chart.SeriesDataMember = "ProductCategory";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.ArgumentDataMember = "Region";
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.ValueDataMembersSerializable = "Sales";
            this.chart.SeriesTemplate.View = fullStackedBar3DSeriesView1;
            this.chart.Size = new System.Drawing.Size(700, 426);
            this.chart.TabIndex = 1;
            chartTitle1.Text = "DevAV Sales Mix by Region";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // checkEditValueAsPercent
            // 
            this.checkEditValueAsPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditValueAsPercent.Location = new System.Drawing.Point(491, 37);
            this.checkEditValueAsPercent.Margin = new System.Windows.Forms.Padding(0);
            this.checkEditValueAsPercent.Name = "checkEditValueAsPercent";
            this.checkEditValueAsPercent.Properties.Caption = "Value As Percent";
            this.checkEditValueAsPercent.Size = new System.Drawing.Size(105, 19);
            this.checkEditValueAsPercent.TabIndex = 2;
            this.checkEditValueAsPercent.CheckedChanged += new System.EventHandler(this.checkEditValueAsPercent_CheckedChanged);
            // 
            // labelPerspective
            // 
            this.labelPerspective.Location = new System.Drawing.Point(12, 12);
            this.labelPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPerspective.Name = "labelPerspective";
            this.labelPerspective.Size = new System.Drawing.Size(90, 13);
            this.labelPerspective.TabIndex = 56;
            this.labelPerspective.Text = "Perspective Angle:";
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
            this.checkEditShowFacet.TabIndex = 59;
            this.checkEditShowFacet.CheckedChanged += new System.EventHandler(this.checkEditShowFacet_CheckedChanged);
            // 
            // FullStackedBar3dDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "FullStackedBar3dDemo";
            this.Controls.SetChildIndex(this.panelRoot, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditValueAsPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBar3DModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowFacet.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelPerspective;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPerspective;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxBar3DModel;
        private DevExpress.XtraEditors.LabelControl label3DModel;
        private DevExpress.XtraEditors.CheckEdit checkEditShowFacet;

	}
}
