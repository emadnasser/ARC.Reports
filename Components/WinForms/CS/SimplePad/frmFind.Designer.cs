namespace DevExpress.XtraBars.Demos.SimplePad {
    partial class frmFind {

        #region Designer generated code
        private void InitializeComponent() {
            this.chWholeword = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new DevExpress.XtraEditors.TextEdit();
            this.chCase = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chWholeword
            // 
            this.chWholeword.Location = new System.Drawing.Point(8, 32);
            this.chWholeword.Name = "chWholeword";
            this.chWholeword.Properties.Caption = "Match whole word only";
            this.chWholeword.Size = new System.Drawing.Size(164, 19);
            this.chWholeword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find what:";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(248, 4);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(92, 24);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFind
            // 
            this.txtFind.EditValue = "";
            this.txtFind.Location = new System.Drawing.Point(80, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(156, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // chCase
            // 
            this.chCase.Location = new System.Drawing.Point(8, 56);
            this.chCase.Name = "chCase";
            this.chCase.Properties.Caption = "Match case";
            this.chCase.Size = new System.Drawing.Size(164, 19);
            this.chCase.TabIndex = 2;
            // 
            // frmFind
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(349, 82);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.chCase);
            this.Controls.Add(this.chWholeword);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit chWholeword;
        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraEditors.SimpleButton btnFindNext;
        private DevExpress.XtraEditors.CheckEdit chCase;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl label1;

    }
}
