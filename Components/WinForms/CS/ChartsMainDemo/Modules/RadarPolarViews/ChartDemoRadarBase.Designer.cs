namespace DevExpress.XtraCharts.Demos.RadarPolarViews {
    partial class RadarDemoBase {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBoxEditTextDirection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelTextDirection = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTextDirection.Properties)).BeginInit();
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
            this.panel.Controls.Add(this.comboBoxEditTextDirection);
            this.panel.Controls.Add(this.labelTextDirection);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerSize, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditDiagramStyle, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditMarkerKind, 0);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.labelTextDirection, 0);
            this.panel.Controls.SetChildIndex(this.comboBoxEditTextDirection, 0);
            // 
            // checkEditShowLabels
            // 
            // 
            // comboBoxEditTextDirection
            // 
            this.comboBoxEditTextDirection.EditValue = "";
            this.comboBoxEditTextDirection.Location = new System.Drawing.Point(245, 9);
            this.comboBoxEditTextDirection.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.comboBoxEditTextDirection.Name = "comboBoxEditTextDirection";
            this.comboBoxEditTextDirection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditTextDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditTextDirection.Size = new System.Drawing.Size(80, 20);
            this.comboBoxEditTextDirection.TabIndex = 9;
            this.comboBoxEditTextDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditTextDirection_SelectedIndexChanged);
            // 
            // labelTextDirection
            // 
            this.labelTextDirection.Location = new System.Drawing.Point(173, 12);
            this.labelTextDirection.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.labelTextDirection.Name = "labelTextDirection";
            this.labelTextDirection.Size = new System.Drawing.Size(71, 13);
            this.labelTextDirection.TabIndex = 10;
            this.labelTextDirection.Text = "Text Direction:";
            // 
            // ChartDemoRadarBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ChartDemoRadarBase";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditMarkerSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditDiagramStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditTextDirection.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelTextDirection;
        protected DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTextDirection;
    }
}
