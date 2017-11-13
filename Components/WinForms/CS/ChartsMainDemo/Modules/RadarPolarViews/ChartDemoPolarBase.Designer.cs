namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
	partial class PolarDemoBase {
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
            this.comboBoxEditFunctionType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelFunction = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditMarkerKind
            // 
            // 
            // comboBoxEditMarkerSize
            // 
            // 
            // comboBoxEditDiagramStyle
            // 
            // 
            // panel
            // 
            this.panel.Controls.Add(this.comboBoxEditFunctionType);
            this.panel.Controls.Add(this.labelFunction);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelFunction, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditFunctionType, 0);
            // 
            // checkEditShowLabels
            // 
            this.checkEditShowLabels.Size = new System.Drawing.Size(82, 18);
            // 
            // comboBoxEditFunctionType
            // 
            this.comboBoxEditFunctionType.EditValue = "";
            this.comboBoxEditFunctionType.Location = new System.Drawing.Point(245, 9);
            this.comboBoxEditFunctionType.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditFunctionType.Name = "comboBoxEditFunctionType";
            this.comboBoxEditFunctionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFunctionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFunctionType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditFunctionType.TabIndex = 4;
            this.comboBoxEditFunctionType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditFunctionType_SelectedIndexChanged);
            // 
            // labelFunction
            // 
            this.labelFunction.Location = new System.Drawing.Point(173, 12);
            this.labelFunction.Margin = new System.Windows.Forms.Padding(7);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(45, 13);
            this.labelFunction.TabIndex = 8;
            this.labelFunction.Text = "Function:";
            // 
            // ChartDemoPolarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChartDemoPolarBase";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFunctionType.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.LabelControl labelFunction;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditFunctionType;
	}
}
