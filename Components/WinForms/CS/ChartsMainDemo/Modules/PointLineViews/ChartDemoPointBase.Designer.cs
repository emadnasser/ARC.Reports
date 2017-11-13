namespace DevExpress.XtraCharts.Demos.PointLineViews {
	partial class PointDemoBase {
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
            this.comboBoxEditLabelAngle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditMarkerSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelAngle = new DevExpress.XtraEditors.LabelControl();
            this.labelMarkerKind = new DevExpress.XtraEditors.LabelControl();
            this.labelMarkerSize = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelMarkerSize);
            this.panel.Controls.Add(this.labelMarkerKind);
            this.panel.Controls.Add(this.labelAngle);
            this.panel.Controls.Add(this.comboBoxEditLabelAngle);
            this.panel.Controls.Add(this.comboBoxEditMarkerKind);
            this.panel.Controls.Add(this.comboBoxEditMarkerSize);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelAngle, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.labelMarkerSize, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 57;
            // 
            // comboBoxEditMarkerKind
            // 
            this.comboBoxEditMarkerKind.EditValue = "";
            this.comboBoxEditMarkerKind.Location = new System.Drawing.Point(75, 9);
            this.comboBoxEditMarkerKind.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind";
            this.comboBoxEditMarkerKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerKind.Size = new System.Drawing.Size(100, 20);
            this.comboBoxEditMarkerKind.TabIndex = 51;
            this.comboBoxEditMarkerKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerKind_SelectedIndexChanged);
            // 
            // comboBoxEditLabelAngle
            // 
            this.comboBoxEditLabelAngle.EditValue = "";
            this.comboBoxEditLabelAngle.Location = new System.Drawing.Point(257, 9);
            this.comboBoxEditLabelAngle.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditLabelAngle.Name = "comboBoxEditLabelAngle";
            this.comboBoxEditLabelAngle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLabelAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditLabelAngle.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEditLabelAngle.TabIndex = 53;
            this.comboBoxEditLabelAngle.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLabelAngle_SelectedIndexChanged);
            // 
            // comboBoxEditMarkerSize
            // 
            this.comboBoxEditMarkerSize.EditValue = "";
            this.comboBoxEditMarkerSize.Location = new System.Drawing.Point(75, 37);
            this.comboBoxEditMarkerSize.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.comboBoxEditMarkerSize.Name = "comboBoxEditMarkerSize";
            this.comboBoxEditMarkerSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditMarkerSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditMarkerSize.Size = new System.Drawing.Size(60, 20);
            this.comboBoxEditMarkerSize.TabIndex = 55;
            this.comboBoxEditMarkerSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditMarkerSize_SelectedIndexChanged);
            // 
            // labelAngle
            // 
            this.labelAngle.Location = new System.Drawing.Point(195, 12);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(59, 13);
            this.labelAngle.TabIndex = 52;
            this.labelAngle.Text = "Label Angle:";
            // 
            // labelMarkerKind
            // 
            this.labelMarkerKind.Location = new System.Drawing.Point(12, 12);
            this.labelMarkerKind.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelMarkerKind.Name = "labelMarkerKind";
            this.labelMarkerKind.Size = new System.Drawing.Size(60, 13);
            this.labelMarkerKind.TabIndex = 50;
            this.labelMarkerKind.Text = "Marker Kind:";
            // 
            // labelMarkerSize
            // 
            this.labelMarkerSize.Location = new System.Drawing.Point(12, 40);
            this.labelMarkerSize.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelMarkerSize.Name = "labelMarkerSize";
            this.labelMarkerSize.Size = new System.Drawing.Size(59, 13);
            this.labelMarkerSize.TabIndex = 54;
            this.labelMarkerSize.Text = "Marker Size:";
            // 
            // PointDemoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PointDemoBase";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditMarkerKind;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLabelAngle;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditMarkerSize;
        protected DevExpress.XtraEditors.LabelControl labelMarkerKind;
        protected DevExpress.XtraEditors.LabelControl labelAngle;
        protected DevExpress.XtraEditors.LabelControl labelMarkerSize;
	}
}
