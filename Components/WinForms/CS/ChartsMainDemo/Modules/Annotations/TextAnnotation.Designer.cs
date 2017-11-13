namespace DevExpress.XtraCharts.Demos.Annotations {
    partial class TextAnnotationDemo {
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
            this.meeMaxText = new DevExpress.XtraEditors.MemoExEdit();
            this.lblMaxText = new DevExpress.XtraEditors.LabelControl();
            this.meeMinText = new DevExpress.XtraEditors.MemoExEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).BeginInit();
            this.panelRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meeMaxText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeMinText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.meeMinText);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.meeMaxText);
            this.panel.Controls.Add(this.lblMaxText);
            this.panel.Controls.SetChildIndex(this.checkEditShowLabels, 0);
            this.panel.Controls.SetChildIndex(this.lblMaxText, 0);
            this.panel.Controls.SetChildIndex(this.meeMaxText, 0);
            this.panel.Controls.SetChildIndex(this.labelControl1, 0);
            this.panel.Controls.SetChildIndex(this.meeMinText, 0);
            // 
            // checkEditShowLabels
            // 
            // 
            // meeMaxText
            // 
            this.meeMaxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meeMaxText.EditValue = "This is a <b><size=+3>maximum</size></b> point.";
            this.meeMaxText.Location = new System.Drawing.Point(486, 9);
            this.meeMaxText.MinimumSize = new System.Drawing.Size(50, 0);
            this.meeMaxText.Name = "meeMaxText";
            this.meeMaxText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.meeMaxText.Properties.PopupFormSize = new System.Drawing.Size(480, 150);
            this.meeMaxText.Properties.ShowIcon = false;
            this.meeMaxText.Size = new System.Drawing.Size(73, 20);
            this.meeMaxText.TabIndex = 10;
            this.meeMaxText.TextChanged += new System.EventHandler(this.meeMaxText_TextChanged);
            // 
            // lblMaxText
            // 
            this.lblMaxText.Location = new System.Drawing.Point(347, 12);
            this.lblMaxText.Name = "lblMaxText";
            this.lblMaxText.Size = new System.Drawing.Size(133, 13);
            this.lblMaxText.TabIndex = 9;
            this.lblMaxText.Text = "Maximum Value Annotation:";
            // 
            // meeMinText
            // 
            this.meeMinText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meeMinText.EditValue = "This is a <b><size=+3>minimum</size></b> point";
            this.meeMinText.Location = new System.Drawing.Point(486, 37);
            this.meeMinText.MinimumSize = new System.Drawing.Size(50, 0);
            this.meeMinText.Name = "meeMinText";
            this.meeMinText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.meeMinText.Properties.PopupFormSize = new System.Drawing.Size(480, 150);
            this.meeMinText.Properties.ShowIcon = false;
            this.meeMinText.Size = new System.Drawing.Size(73, 20);
            this.meeMinText.TabIndex = 12;
            this.meeMinText.TextChanged += new System.EventHandler(this.meeMinText_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(347, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Minimum Value Annotation:";
            // 
            // TextAnnotationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TextAnnotationDemo";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowLabels.Properties)).EndInit();
            this.panelRoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meeMaxText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeMinText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.MemoExEdit meeMaxText;
        private XtraEditors.LabelControl lblMaxText;
        private XtraEditors.MemoExEdit meeMinText;
        private XtraEditors.LabelControl labelControl1;
    }
}
