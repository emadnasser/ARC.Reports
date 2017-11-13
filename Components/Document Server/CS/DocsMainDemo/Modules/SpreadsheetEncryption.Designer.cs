using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    partial class SpreadsheetEncryption {
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
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.typeLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordEdit = new DevExpress.XtraEditors.TextEdit();
            this.typeEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(5, 8);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(50, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(215, 8);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(28, 13);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Type:";
            // 
            // passwordEdit
            // 
            this.passwordEdit.Location = new System.Drawing.Point(60, 5);
            this.passwordEdit.Name = "passwordEdit";
            this.passwordEdit.Properties.MaxLength = 255;
            this.passwordEdit.Size = new System.Drawing.Size(120, 20);
            this.passwordEdit.TabIndex = 34;
            // 
            // typeEdit
            // 
            this.typeEdit.Location = new System.Drawing.Point(248, 5);
            this.typeEdit.Name = "typeEdit";
            this.typeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeEdit.Size = new System.Drawing.Size(120, 20);
            this.typeEdit.TabIndex = 34;
            // 
            // SpreadsheetEncryption
            // 
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.passwordEdit);
            this.Controls.Add(this.typeEdit);
            this.Name = "SpreadsheetEncryption";
            this.Controls.SetChildIndex(this.typeEdit, 0);
            this.Controls.SetChildIndex(this.passwordEdit, 0);
            this.Controls.SetChildIndex(this.typeLabel, 0);
            this.Controls.SetChildIndex(this.passwordLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.passwordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        LabelControl passwordLabel;
        LabelControl typeLabel;
        TextEdit passwordEdit;
        ComboBoxEdit typeEdit;
    }
}
