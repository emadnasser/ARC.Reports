using System;
using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetTutorialControl {
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
            this.fitToPageCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.spreadsheetTutorialPanel = new DevExpress.XtraEditors.PanelControl();
            this.spreadsheetPreview1 = new DevExpress.Docs.Demos.SpreadsheetPreview();
            ((System.ComponentModel.ISupportInitialize)(this.fitToPageCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetTutorialPanel)).BeginInit();
            this.spreadsheetTutorialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fitToPageCheckEdit
            // 
            this.fitToPageCheckEdit.Location = new System.Drawing.Point(3, 5);
            this.fitToPageCheckEdit.Name = "fitToPageCheckEdit";
            this.fitToPageCheckEdit.Properties.Caption = "Fit To Page";
            this.fitToPageCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.fitToPageCheckEdit.TabIndex = 30;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(424, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save As...";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // spreadsheetTutorialPanel
            // 
            this.spreadsheetTutorialPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetTutorialPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spreadsheetTutorialPanel.Controls.Add(this.spreadsheetPreview1);
            this.spreadsheetTutorialPanel.Controls.Add(this.saveButton);
            this.spreadsheetTutorialPanel.Controls.Add(this.fitToPageCheckEdit);
            this.spreadsheetTutorialPanel.Location = new System.Drawing.Point(0, 90);
            this.spreadsheetTutorialPanel.Name = "spreadsheetTutorialPanel";
            this.spreadsheetTutorialPanel.Size = new System.Drawing.Size(500, 410);
            this.spreadsheetTutorialPanel.TabIndex = 33;
            // 
            // spreadsheetPreview1
            // 
            this.spreadsheetPreview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetPreview1.CanShowBorders = false;
            this.spreadsheetPreview1.Location = new System.Drawing.Point(0, 32);
            this.spreadsheetPreview1.Name = "spreadsheetPreview1";
            this.spreadsheetPreview1.Size = new System.Drawing.Size(500, 378);
            this.spreadsheetPreview1.TabIndex = 33;
            this.spreadsheetPreview1.Workbook = null;
            // 
            // SpreadsheetTutorialControl
            // 
            this.Controls.Add(this.spreadsheetTutorialPanel);
            this.Name = "SpreadsheetTutorialControl";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.fitToPageCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetTutorialPanel)).EndInit();
            this.spreadsheetTutorialPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        CheckEdit fitToPageCheckEdit;
        SimpleButton saveButton;
        private SpreadsheetPreview spreadsheetPreview1;
    }
}
