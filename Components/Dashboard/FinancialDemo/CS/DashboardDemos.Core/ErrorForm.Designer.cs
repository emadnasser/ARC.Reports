namespace DashboardDemos.Core {
    partial class ErrorForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelErrorCaption = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditErrorDetails = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditErrorDetails.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButton1.Location = new System.Drawing.Point(192, 314);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 32);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "OK";
            // 
            // labelErrorCaption
            // 
            this.labelErrorCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelErrorCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelErrorCaption.Location = new System.Drawing.Point(52, 11);
            this.labelErrorCaption.Name = "labelErrorCaption";
            this.labelErrorCaption.Size = new System.Drawing.Size(380, 29);
            this.labelErrorCaption.TabIndex = 2;
            this.labelErrorCaption.Text = "Unable to connect to {0} SQL Server instance:";
            // 
            // labelControl3
            // 
            this.labelControl3.AllowHtmlString = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl3.Location = new System.Drawing.Point(57, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(380, 91);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = resources.GetString("labelControl3.Text");
            this.labelControl3.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.labelControl3_HyperlinkClick);
            // 
            // textEditErrorDetails
            // 
            this.textEditErrorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditErrorDetails.Location = new System.Drawing.Point(52, 49);
            this.textEditErrorDetails.Margin = new System.Windows.Forms.Padding(6);
            this.textEditErrorDetails.Name = "textEditErrorDetails";
            this.textEditErrorDetails.Properties.ReadOnly = true;
            this.textEditErrorDetails.Size = new System.Drawing.Size(385, 141);
            this.textEditErrorDetails.TabIndex = 3;
            this.textEditErrorDetails.UseOptimizedRendering = true;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 370);
            this.Controls.Add(this.textEditErrorDetails);
            this.Controls.Add(this.labelErrorCaption);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.textEditErrorDetails.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelErrorCaption;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit textEditErrorDetails;
    }
}
