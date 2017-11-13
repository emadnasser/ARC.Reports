namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	partial class RadarPolarDemoBase {
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
            this.comboBoxEditMarkerKind = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelMarkerKind = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditMarkerSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelMarkerSize = new DevExpress.XtraEditors.LabelControl();
            this.labelDiagramStyle = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditDiagramStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBoxEditMarkerKind);
            this.panel.Controls.Add(this.labelMarkerKind);
            this.panel.Controls.Add(this.labelMarkerSize);
            this.panel.Controls.Add(this.comboBoxEditDiagramStyle);
            this.panel.Controls.Add(this.comboBoxEditMarkerSize);
            this.panel.Controls.Add(this.labelDiagramStyle);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 18);
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.EditValue = "";
            this.comboBoxEditMarkerKind.Location = new System.Drawing.Point(73, 9);
            this.comboBoxEditMarkerKind.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind";
            this.comboBoxEditMarkerKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerKind.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditMarkerKind.TabIndex = 0;
            this.comboBoxEditMarkerKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerKind_SelectedIndexChanged);
            // 
            // labelMarkerKind
            // 
            this.labelMarkerKind.Location = new System.Drawing.Point(10, 12);
            this.labelMarkerKind.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelMarkerKind.Name = "labelMarkerKind";
            this.labelMarkerKind.Size = new System.Drawing.Size(60, 13);
            this.labelMarkerKind.TabIndex = 1;
            this.labelMarkerKind.Text = "Marker Kind:";
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.EditValue = "";
            this.comboBoxEditMarkerSize.Location = new System.Drawing.Point(73, 37);
            this.comboBoxEditMarkerSize.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize";
            this.comboBoxEditMarkerSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerSize.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditMarkerSize.TabIndex = 1;
            this.comboBoxEditMarkerSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerSize_SelectedIndexChanged);
            // 
            // labelMarkerSize
            // 
            this.labelMarkerSize.Location = new System.Drawing.Point(10, 40);
            this.labelMarkerSize.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelMarkerSize.Name = "labelMarkerSize";
            this.labelMarkerSize.Size = new System.Drawing.Size(59, 13);
            this.labelMarkerSize.TabIndex = 5;
            this.labelMarkerSize.Text = "Marker Size:";
            // 
            // labelDiagramStyle
            // 
            this.labelDiagramStyle.Location = new System.Drawing.Point(173, 40);
            this.labelDiagramStyle.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelDiagramStyle.Name = "labelDiagramStyle";
            this.labelDiagramStyle.Size = new System.Drawing.Size(70, 13);
            this.labelDiagramStyle.TabIndex = 6;
            this.labelDiagramStyle.Text = "Diagram Style:";
            // 
            // comboBoxEditDiagramStyle
            // 
            this.comboBoxEditDiagramStyle.EditValue = "";
            this.comboBoxEditDiagramStyle.Location = new System.Drawing.Point(245, 37);
            this.comboBoxEditDiagramStyle.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.comboBoxEditDiagramStyle.Name = "comboBoxEditDiagramStyle";
            this.comboBoxEditDiagramStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditDiagramStyle.Properties.Items.AddRange(new object[] {
            "Circle",
            "Polygon"});
            this.comboBoxEditDiagramStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditDiagramStyle.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditDiagramStyle.TabIndex = 3;
            this.comboBoxEditDiagramStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditDiagramStyle_SelectedIndexChanged);
            // 
            // ChartDemoRadarPolarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChartDemoRadarPolarBase";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelDiagramStyle;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditMarkerKind;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditMarkerSize;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditDiagramStyle;
	}
}
