namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class DocumentThemesModule {
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentThemesModule));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.fromCompanyLabel = new DevExpress.XtraEditors.LabelControl();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.spreadsheetBarController1 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController();
            this.spreadsheetCommandBarButtonItem65 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem66 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem67 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem68 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            this.spreadsheetCommandBarButtonItem69 = new DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.AllowDrop = true;
            resources.ApplyResources(this.spreadsheetControl1, "spreadsheetControl1");
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            // 
            // comboBoxEdit1
            // 
            resources.ApplyResources(this.comboBoxEdit1, "comboBoxEdit1");
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxEdit1.Properties.Buttons"))))});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            resources.GetString("comboBoxEdit1.Properties.Items"),
            resources.GetString("comboBoxEdit1.Properties.Items1"),
            resources.GetString("comboBoxEdit1.Properties.Items2"),
            resources.GetString("comboBoxEdit1.Properties.Items3"),
            resources.GetString("comboBoxEdit1.Properties.Items4")});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // fromCompanyLabel
            // 
            resources.ApplyResources(this.fromCompanyLabel, "fromCompanyLabel");
            this.fromCompanyLabel.Name = "fromCompanyLabel";
            // 
            // panel
            // 
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel.Controls.Add(this.fromCompanyLabel);
            this.panel.Controls.Add(this.comboBoxEdit1);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // spreadsheetBarController1
            // 
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem65);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem66);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem67);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem68);
            this.spreadsheetBarController1.BarItems.Add(this.spreadsheetCommandBarButtonItem69);
            this.spreadsheetBarController1.Control = this.spreadsheetControl1;
            // 
            // spreadsheetCommandBarButtonItem65
            // 
            this.spreadsheetCommandBarButtonItem65.CommandName = "FunctionsInsertSum";
            this.spreadsheetCommandBarButtonItem65.Id = -1;
            this.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65";
            // 
            // spreadsheetCommandBarButtonItem66
            // 
            this.spreadsheetCommandBarButtonItem66.CommandName = "FunctionsInsertAverage";
            this.spreadsheetCommandBarButtonItem66.Id = -1;
            this.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66";
            // 
            // spreadsheetCommandBarButtonItem67
            // 
            this.spreadsheetCommandBarButtonItem67.CommandName = "FunctionsInsertCountNumbers";
            this.spreadsheetCommandBarButtonItem67.Id = -1;
            this.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67";
            // 
            // spreadsheetCommandBarButtonItem68
            // 
            this.spreadsheetCommandBarButtonItem68.CommandName = "FunctionsInsertMax";
            this.spreadsheetCommandBarButtonItem68.Id = -1;
            this.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68";
            // 
            // spreadsheetCommandBarButtonItem69
            // 
            this.spreadsheetCommandBarButtonItem69.CommandName = "FunctionsInsertMin";
            this.spreadsheetCommandBarButtonItem69.Id = -1;
            this.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69";
            // 
            // DocumentThemesModule
            // 
            this.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("DocumentThemesModule.Appearance.Font")));
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.spreadsheetControl1);
            this.Controls.Add(this.panel);
            this.Name = "DocumentThemesModule";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetBarController1)).EndInit();
            this.ResumeLayout(false);

        }

        private XtraEditors.ComboBoxEdit comboBoxEdit1;
        private XtraEditors.LabelControl fromCompanyLabel;
        private XtraEditors.PanelControl panel;
        private UI.SpreadsheetBarController spreadsheetBarController1;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem65;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem66;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem67;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem68;
        private UI.SpreadsheetCommandBarButtonItem spreadsheetCommandBarButtonItem69;
    }
}
