using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    partial class PrintTitlesModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintTitlesModule));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.btnManyPages = new DevExpress.XtraEditors.SimpleButton();
            this.btnWholePage = new DevExpress.XtraEditors.SimpleButton();
            this.btnPageSetup = new DevExpress.XtraEditors.SimpleButton();
            this.spreadsheetPreview1 = new DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.ReadOnly = true;
            this.spreadsheetControl1.Size = new System.Drawing.Size(719, 428);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.ContentChanged += new System.EventHandler(this.spreadsheetControl1_ContentChanged);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.btnManyPages);
            this.panel.Controls.Add(this.btnWholePage);
            this.panel.Controls.Add(this.btnPageSetup);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(719, 29);
            this.panel.TabIndex = 6;
            // 
            // btnManyPages
            // 
            this.btnManyPages.Image = ((System.Drawing.Image)(resources.GetObject("btnManyPages.Image")));
            this.btnManyPages.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnManyPages.Location = new System.Drawing.Point(162, 3);
            this.btnManyPages.Name = "btnManyPages";
            this.btnManyPages.Size = new System.Drawing.Size(23, 23);
            this.btnManyPages.TabIndex = 2;
            this.btnManyPages.ToolTip = "View Many Pages";
            this.btnManyPages.Click += new System.EventHandler(this.btnManyPages_Click);
            // 
            // btnWholePage
            // 
            this.btnWholePage.Image = ((System.Drawing.Image)(resources.GetObject("btnWholePage.Image")));
            this.btnWholePage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnWholePage.Location = new System.Drawing.Point(133, 3);
            this.btnWholePage.Name = "btnWholePage";
            this.btnWholePage.Size = new System.Drawing.Size(23, 23);
            this.btnWholePage.TabIndex = 1;
            this.btnWholePage.ToolTip = "View Whole Page";
            this.btnWholePage.Click += new System.EventHandler(this.btnWholePage_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPageSetup.Location = new System.Drawing.Point(3, 3);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(124, 23);
            this.btnPageSetup.TabIndex = 0;
            this.btnPageSetup.Text = "Page Setup";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // spreadsheetPreview1
            // 
            this.spreadsheetPreview1.CanShowBorders = true;
            this.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetPreview1.Location = new System.Drawing.Point(0, 29);
            this.spreadsheetPreview1.Name = "spreadsheetPreview1";
            this.spreadsheetPreview1.PreviewZoom = DevExpress.XtraSpreadsheet.Demos.SpreadhsheetPreviewZoom.Default;
            this.spreadsheetPreview1.Size = new System.Drawing.Size(719, 399);
            this.spreadsheetPreview1.TabIndex = 7;
            this.spreadsheetPreview1.Workbook = null;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(725, 456);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.spreadsheetPreview1);
            this.xtraTabPage2.Controls.Add(this.panel);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(719, 428);
            this.xtraTabPage2.Text = "Preview";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.spreadsheetControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(719, 428);
            this.xtraTabPage1.Text = "Content";
            // 
            // PrintTitlesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "PrintTitlesModule";
            this.Size = new System.Drawing.Size(725, 456);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.PanelControl panel;
        private SimpleButton btnPageSetup;
        private SpreadsheetPreview spreadsheetPreview1;
        private SimpleButton btnWholePage;
        private SimpleButton btnManyPages;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraTab.XtraTabPage xtraTabPage2;
        private XtraTab.XtraTabPage xtraTabPage1;
    }
}
