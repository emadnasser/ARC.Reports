namespace PivotGridOlapBrowser {
    partial class PivotGridBrowser {
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
                connectionDesigner.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.browserTabs = new PivotGridOlapBrowser.Helpers.BrowserTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.browserTabs)).BeginInit();
            this.browserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // browserTabs
            // 
            this.browserTabs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.browserTabs.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.browserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserTabs.HeaderButtons = ((DevExpress.XtraTab.TabButtons)(((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next)
                        | DevExpress.XtraTab.TabButtons.Close)));
            this.browserTabs.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded;
            this.browserTabs.Location = new System.Drawing.Point(8, 8);
            this.browserTabs.Name = "browserTabs";
            this.browserTabs.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.browserTabs.Size = new System.Drawing.Size(727, 399);
            this.browserTabs.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(browserTabs_SelectedPageChanged);
            this.browserTabs.TabIndex = 0;
            // 
            // PivotGridBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browserTabs);
            this.Name = "PivotGridBrowser";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(743, 415);
            ((System.ComponentModel.ISupportInitialize)(this.browserTabs)).EndInit();
            this.browserTabs.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private PivotGridOlapBrowser.Helpers.BrowserTabControl browserTabs;
    }
}
