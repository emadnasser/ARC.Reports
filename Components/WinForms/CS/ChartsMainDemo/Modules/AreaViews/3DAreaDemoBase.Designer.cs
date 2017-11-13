namespace DevExpress.XtraCharts.Demos.AreaViews {
	partial class Area3dDemoBase {
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
            this.comboTransparencies = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditPerspective = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelTransparency = new DevExpress.XtraEditors.LabelControl();
            this.labelPerspective = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDefaultAngles
            // 
            this.btnDefaultAngles.Location = new System.Drawing.Point(203, 8);
            this.btnDefaultAngles.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnDefaultAngles.TabIndex = 5;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.labelPerspective);
            this.panel.Controls.Add(this.labelTransparency);
            this.panel.Controls.Add(this.comboBoxEditPerspective);
            this.panel.Controls.Add(this.comboTransparencies);
            this.panel.Controls.SetChildIndex(this.btnDefaultAngles, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboTransparencies, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditPerspective, 0);
            this.panel.Controls.SetChildIndex(this.labelTransparency, 0);
            this.panel.Controls.SetChildIndex(this.labelPerspective, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 6;
            // 
            // comboTransparencies
            // 
            this.comboTransparencies.Location = new System.Drawing.Point(105, 9);
            this.comboTransparencies.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboTransparencies.Name = "comboTransparencies";
            this.comboTransparencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTransparencies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboTransparencies.Size = new System.Drawing.Size(78, 20);
            this.comboTransparencies.TabIndex = 2;
            this.comboTransparencies.SelectedIndexChanged += new System.EventHandler(this.comboTransparencies_SelectedIndexChanged);
            // 
            // comboBoxEditPerspective
            // 
            this.comboBoxEditPerspective.EditValue = "";
            this.comboBoxEditPerspective.Location = new System.Drawing.Point(105, 37);
            this.comboBoxEditPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.comboBoxEditPerspective.Name = "comboBoxEditPerspective";
            this.comboBoxEditPerspective.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPerspective.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditPerspective.Size = new System.Drawing.Size(78, 20);
            this.comboBoxEditPerspective.TabIndex = 4;
            this.comboBoxEditPerspective.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditPerspective_SelectedIndexChanged);
            // 
            // labelTransparency
            // 
            this.labelTransparency.Location = new System.Drawing.Point(12, 12);
            this.labelTransparency.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelTransparency.Name = "labelTransparency";
            this.labelTransparency.Size = new System.Drawing.Size(70, 13);
            this.labelTransparency.TabIndex = 1;
            this.labelTransparency.Text = "Transparency:";
            // 
            // labelPerspective
            // 
            this.labelPerspective.Location = new System.Drawing.Point(12, 40);
            this.labelPerspective.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelPerspective.Name = "labelPerspective";
            this.labelPerspective.Size = new System.Drawing.Size(90, 13);
            this.labelPerspective.TabIndex = 3;
            this.labelPerspective.Text = "Perspective Angle:";
            // 
            // Area3dDemoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Area3dDemoBase";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboTransparencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPerspective.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.ComboBoxEdit comboTransparencies;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPerspective;
        private DevExpress.XtraEditors.LabelControl labelPerspective;
        private DevExpress.XtraEditors.LabelControl labelTransparency;

	}
}
