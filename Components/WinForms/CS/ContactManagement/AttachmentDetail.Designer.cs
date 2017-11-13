namespace ContactManagement {
    partial class AttachmentDetail {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttachmentName = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID:";
            // 
            // txtOID
            // 
            this.txtOID.Location = new System.Drawing.Point(96, 8);
            this.txtOID.Name = "txtOID";
            this.txtOID.ReadOnly = true;
            this.txtOID.Size = new System.Drawing.Size(128, 20);
            this.txtOID.TabIndex = 5;
            this.txtOID.Text = "txtOID";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // txtAttachmentName
            // 
            this.txtAttachmentName.Location = new System.Drawing.Point(96, 32);
            this.txtAttachmentName.Name = "txtAttachmentName";
            this.txtAttachmentName.Size = new System.Drawing.Size(328, 20);
            this.txtAttachmentName.TabIndex = 0;
            // 
            // txtDocument
            // 
            this.txtDocument.AcceptsTab = true;
            this.txtDocument.Location = new System.Drawing.Point(8, 56);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(416, 336);
            this.txtDocument.TabIndex = 1;
            this.txtDocument.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(272, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 20);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(352, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 20);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(192, 400);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(70, 20);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "&Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AttachmentDetail
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(433, 429);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAttachmentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AttachmentDetail";
            this.Text = "Attachment Detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Attachment theAttachment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAttachmentName;
        private System.Windows.Forms.RichTextBox txtDocument;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLoad;
        private System.ComponentModel.Container components = null;

    }
}
