using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class RichEditFindAndReplace {
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
        /// 
        private void InitializeComponent() {
            this.find = new DevExpress.XtraEditors.LabelControl();
            this.findTE = new DevExpress.XtraEditors.TextEdit();
            this.replace = new DevExpress.XtraEditors.LabelControl();
            this.replaceTE = new DevExpress.XtraEditors.TextEdit();
            this.printPreviewControl = new DevExpress.XtraPrinting.Control.PrintControl();
            this.findButton = new DevExpress.XtraEditors.SimpleButton();
            this.replaceButton = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(0, 9);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(24, 13);
            this.find.TabIndex = 35;
            this.find.Text = "Find:";
            // 
            // findTE
            // 
            this.findTE.EditValue = "";
            this.findTE.Location = new System.Drawing.Point(74, 6);
            this.findTE.Name = "findTE";
            this.findTE.Size = new System.Drawing.Size(126, 20);
            this.findTE.TabIndex = 34;
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(0, 38);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(65, 13);
            this.replace.TabIndex = 37;
            this.replace.Text = "Replace with:";
            // 
            // replaceTE
            // 
            this.replaceTE.EditValue = "";
            this.replaceTE.Location = new System.Drawing.Point(74, 35);
            this.replaceTE.Name = "replaceTE";
            this.replaceTE.Size = new System.Drawing.Size(125, 20);
            this.replaceTE.TabIndex = 36;
            // 
            // printPreviewControl
            // 
            this.printPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewControl.IsMetric = false;
            this.printPreviewControl.Location = new System.Drawing.Point(0, 62);
            this.printPreviewControl.Name = "printPreviewControl";
            this.printPreviewControl.Size = new System.Drawing.Size(784, 367);
            this.printPreviewControl.TabIndex = 38;
            this.printPreviewControl.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(205, 4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(85, 24);
            this.findButton.TabIndex = 39;
            this.findButton.Text = "Find All";
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(205, 33);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(85, 24);
            this.replaceButton.TabIndex = 39;
            this.replaceButton.Text = "Replace All";
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(695, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 24);
            this.btnExport.TabIndex = 40;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RichEditFindAndReplace
            // 
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.printPreviewControl);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.replaceTE);
            this.Controls.Add(this.find);
            this.Controls.Add(this.findTE);
            this.Name = "RichEditFindAndReplace";
            ((System.ComponentModel.ISupportInitialize)(this.findTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private LabelControl find;
        private TextEdit findTE;
        private LabelControl replace;
        private TextEdit replaceTE;
        private XtraPrinting.Control.PrintControl printPreviewControl;
        private SimpleButton findButton;
        private SimpleButton replaceButton;
        private SimpleButton btnExport;

    }
}
