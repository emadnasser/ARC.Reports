using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    partial class HeaderFooterModule {
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
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.btnPageSetup = new DevExpress.XtraEditors.SimpleButton();
            this.spreadsheetPreview1 = new DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Location = new System.Drawing.Point(24, 74);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(509, 303);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Visible = false;
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.btnPageSetup);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(725, 26);
            this.panel.TabIndex = 6;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPageSetup.Location = new System.Drawing.Point(0, 0);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(124, 23);
            this.btnPageSetup.TabIndex = 0;
            this.btnPageSetup.Text = "Headers/Footers";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // spreadsheetPreview1
            // 
            this.spreadsheetPreview1.CanShowBorders = true;
            this.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetPreview1.Location = new System.Drawing.Point(0, 26);
            this.spreadsheetPreview1.Name = "spreadsheetPreview1";
            this.spreadsheetPreview1.Size = new System.Drawing.Size(725, 430);
            this.spreadsheetPreview1.TabIndex = 7;
            this.spreadsheetPreview1.Workbook = null;
            // 
            // HeaderFooterModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetPreview1);
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.panel);
            this.Name = "HeaderFooterModule";
            this.Size = new System.Drawing.Size(725, 456);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.PanelControl panel;
        private SimpleButton btnPageSetup;
        private SpreadsheetPreview spreadsheetPreview1;
    }
}
