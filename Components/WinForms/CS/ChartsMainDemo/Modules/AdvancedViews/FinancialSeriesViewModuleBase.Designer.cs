namespace DevExpress.XtraCharts.Demos.AdvancedViews {
	partial class FinancialSeriesViewDemoBase {
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
            this.comboBoxEditReductionLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEditLabelLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelLabelLevel = new DevExpress.XtraEditors.LabelControl();
            this.labelReductionLevel = new DevExpress.XtraEditors.LabelControl();
            this.checkEditWorkdaysOnly = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditReductionLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWorkdaysOnly.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkEditWorkdaysOnly);
            this.panel.Controls.Add(this.labelReductionLevel);
            this.panel.Controls.Add(this.labelLabelLevel);
            this.panel.Controls.Add(this.comboBoxEditLabelLevel);
            this.panel.Controls.Add(this.comboBoxEditReductionLevel);
            this.panel.Size = new System.Drawing.Size(700, 38);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditReductionLevel, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditLabelLevel, 0);
            this.panel.Controls.SetChildIndex(this.labelLabelLevel, 0);
            this.panel.Controls.SetChildIndex(this.labelReductionLevel, 0);
            this.panel.Controls.SetChildIndex(this.checkEditWorkdaysOnly, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Location = new System.Drawing.Point(606, 9);
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 19);
            this.checkEditShowLabels.TabIndex = 11;
            // 
            // panelRoot
            // 
            this.panelRoot.Size = new System.Drawing.Size(700, 46);
            // 
            // comboBoxEditReductionLevel
            // 
            this.comboBoxEditReductionLevel.EditValue = "";
            this.comboBoxEditReductionLevel.Location = new System.Drawing.Point(245, 9);
            this.comboBoxEditReductionLevel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.comboBoxEditReductionLevel.Name = "comboBoxEditReductionLevel";
            this.comboBoxEditReductionLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditReductionLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditReductionLevel.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditReductionLevel.TabIndex = 4;
            this.comboBoxEditReductionLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditReductionLevel_SelectedIndexChanged);
            // 
            // comboBoxEditLabelLevel
            // 
            this.comboBoxEditLabelLevel.EditValue = "";
            this.comboBoxEditLabelLevel.Location = new System.Drawing.Point(72, 9);
            this.comboBoxEditLabelLevel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditLabelLevel.Name = "comboBoxEditLabelLevel";
            this.comboBoxEditLabelLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditLabelLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditLabelLevel.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditLabelLevel.TabIndex = 2;
            this.comboBoxEditLabelLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditLabelLevel_SelectedIndexChanged);
            // 
            // labelLabelLevel
            // 
            this.labelLabelLevel.Location = new System.Drawing.Point(12, 12);
            this.labelLabelLevel.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelLabelLevel.Name = "labelLabelLevel";
            this.labelLabelLevel.Size = new System.Drawing.Size(57, 13);
            this.labelLabelLevel.TabIndex = 1;
            this.labelLabelLevel.Text = "Label Level:";
            // 
            // labelReductionLevel
            // 
            this.labelReductionLevel.Location = new System.Drawing.Point(162, 12);
            this.labelReductionLevel.Margin = new System.Windows.Forms.Padding(0, 10, 3, 10);
            this.labelReductionLevel.Name = "labelReductionLevel";
            this.labelReductionLevel.Size = new System.Drawing.Size(80, 13);
            this.labelReductionLevel.TabIndex = 3;
            this.labelReductionLevel.Text = "Reduction Level:";
            // 
            // checkEditWorkdaysOnly
            // 
            this.checkEditWorkdaysOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditWorkdaysOnly.Location = new System.Drawing.Point(501, 9);
            this.checkEditWorkdaysOnly.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.checkEditWorkdaysOnly.Name = "checkEditWorkdaysOnly";
            this.checkEditWorkdaysOnly.Properties.Caption = "Workdays Only";
            this.checkEditWorkdaysOnly.Size = new System.Drawing.Size(95, 19);
            this.checkEditWorkdaysOnly.TabIndex = 10;
            this.checkEditWorkdaysOnly.CheckedChanged += new System.EventHandler(this.checkEditWorkdaysOnly_CheckedChanged);
            // 
            // FinancialSeriesViewDemoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FinancialSeriesViewDemoBase";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditReductionLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditLabelLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWorkdaysOnly.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl labelReductionLevel;
        private DevExpress.XtraEditors.LabelControl labelLabelLevel;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditReductionLevel;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditLabelLevel;
        protected DevExpress.XtraEditors.CheckEdit checkEditWorkdaysOnly;

	}
}
