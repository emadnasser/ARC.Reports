namespace DevExpress.XtraSpreadsheet.Demos {
    partial class TopTradingPartnersModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.chkExports = new DevExpress.XtraEditors.CheckEdit();
            this.chkAsiaRegion = new DevExpress.XtraEditors.CheckEdit();
            this.chkBalance = new DevExpress.XtraEditors.CheckEdit();
            this.chkImports = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkExports.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsiaRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkImports.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 202);
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(697, 208);
            // 
            // panel
            // 
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.chkExports);
            this.panel.Controls.Add(this.chkAsiaRegion);
            this.panel.Controls.Add(this.chkBalance);
            this.panel.Controls.Add(this.chkImports);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(697, 35);
            this.panel.TabIndex = 55;
            // 
            // chkExports
            // 
            this.chkExports.EditValue = true;
            this.chkExports.Location = new System.Drawing.Point(98, 8);
            this.chkExports.Name = "chkExports";
            this.chkExports.Properties.AutoWidth = true;
            this.chkExports.Properties.Caption = "Exports";
            this.chkExports.Size = new System.Drawing.Size(59, 19);
            this.chkExports.TabIndex = 1;
            this.chkExports.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkAsiaRegion
            // 
            this.chkAsiaRegion.EditValue = true;
            this.chkAsiaRegion.Location = new System.Drawing.Point(298, 8);
            this.chkAsiaRegion.Name = "chkAsiaRegion";
            this.chkAsiaRegion.Properties.AutoWidth = true;
            this.chkAsiaRegion.Properties.Caption = "Asia Region";
            this.chkAsiaRegion.Size = new System.Drawing.Size(78, 19);
            this.chkAsiaRegion.TabIndex = 3;
            this.chkAsiaRegion.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkBalance
            // 
            this.chkBalance.EditValue = true;
            this.chkBalance.Location = new System.Drawing.Point(198, 8);
            this.chkBalance.Name = "chkBalance";
            this.chkBalance.Properties.AutoWidth = true;
            this.chkBalance.Properties.Caption = "Balance";
            this.chkBalance.Size = new System.Drawing.Size(59, 19);
            this.chkBalance.TabIndex = 2;
            this.chkBalance.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // chkImports
            // 
            this.chkImports.EditValue = true;
            this.chkImports.Location = new System.Drawing.Point(0, 8);
            this.chkImports.Name = "chkImports";
            this.chkImports.Properties.AutoWidth = true;
            this.chkImports.Properties.Caption = "Imports";
            this.chkImports.Size = new System.Drawing.Size(59, 19);
            this.chkImports.TabIndex = 0;
            this.chkImports.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // TopTradingPartnersModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "TopTradingPartnersModule";
            this.Size = new System.Drawing.Size(697, 410);
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkExports.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsiaRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkImports.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.PanelControl panel;
        protected XtraEditors.CheckEdit chkImports;
        protected XtraEditors.CheckEdit chkBalance;
        protected XtraEditors.CheckEdit chkAsiaRegion;
        protected XtraEditors.CheckEdit chkExports;
    }
}
