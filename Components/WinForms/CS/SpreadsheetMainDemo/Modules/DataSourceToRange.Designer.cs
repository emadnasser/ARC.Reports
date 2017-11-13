namespace DevExpress.XtraSpreadsheet.Demos {
    partial class DataSourceToRangeModule {
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceToRangeModule));
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.edOrderId = new DevExpress.XtraEditors.LookUpEdit();
            this.chbDiscount = new DevExpress.XtraEditors.CheckEdit();
            this.lbOrderId = new DevExpress.XtraEditors.LabelControl();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.edProductName = new DevExpress.XtraEditors.LookUpEdit();
            this.lbProduct = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled;
            this.spreadsheetControl1.Options.Behavior.UseSkinColors = false;
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            resources.ApplyResources(this.spreadsheetControl1, "spreadsheetControl1");
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            // 
            // panel
            // 
            this.panel.Controls.Add(this.edOrderId);
            this.panel.Controls.Add(this.chbDiscount);
            this.panel.Controls.Add(this.lbOrderId);
            this.panel.Controls.Add(this.lbProduct);
            this.panel.Controls.Add(this.btnReset);
            this.panel.Controls.Add(this.edProductName);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // edOrderId
            // 
            resources.ApplyResources(this.edOrderId, "edOrderId");
            this.edOrderId.MenuManager = this.ribbonControl1;
            this.edOrderId.Name = "edOrderId";
            this.edOrderId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edOrderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edOrderId.Properties.Buttons"))))});
            this.edOrderId.Properties.NullText = resources.GetString("edOrderId.Properties.NullText");
            this.edOrderId.Properties.PopupFormMinSize = new System.Drawing.Size(140, 0);
            this.edOrderId.Properties.ShowFooter = false;
            this.edOrderId.Properties.ShowHeader = false;
            this.edOrderId.EditValueChanged += new System.EventHandler(this.edOrderId_EditValueChanged);
            // 
            // chbDiscount
            // 
            resources.ApplyResources(this.chbDiscount, "chbDiscount");
            this.chbDiscount.MenuManager = this.ribbonControl1;
            this.chbDiscount.Name = "chbDiscount";
            this.chbDiscount.Properties.Caption = resources.GetString("chbDiscount.Properties.Caption");
            this.chbDiscount.CheckedChanged += new System.EventHandler(this.chbDiscount_CheckedChanged);
            // 
            // lbOrderId
            // 
            resources.ApplyResources(this.lbOrderId, "lbOrderId");
            this.lbOrderId.Name = "lbOrderId";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // edProductName
            // 
            resources.ApplyResources(this.edProductName, "edProductName");
            this.edProductName.MenuManager = this.ribbonControl1;
            this.edProductName.Name = "edProductName";
            this.edProductName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.edProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edProductName.Properties.Buttons"))))});
            this.edProductName.Properties.NullText = resources.GetString("edProductName.Properties.NullText");
            this.edProductName.Properties.ShowFooter = false;
            this.edProductName.Properties.ShowHeader = false;
            this.edProductName.EditValueChanged += new System.EventHandler(this.edProductName_EditValueChanged);
            // 
            // lbProduct
            // 
            resources.ApplyResources(this.lbProduct, "lbProduct");
            this.lbProduct.Name = "lbProduct";
            // 
            // separatorControl1
            // 
            resources.ApplyResources(this.separatorControl1, "separatorControl1");
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.separatorControl1.Name = "separatorControl1";
            // 
            // DataSourceToRangeModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.panel);
            this.Name = "DataSourceToRangeModule";
            resources.ApplyResources(this, "$this");
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.separatorControl1, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private XtraEditors.PanelControl panel;
        private XtraEditors.SeparatorControl separatorControl1;
        private XtraEditors.LookUpEdit edOrderId;
        private XtraEditors.LabelControl lbProduct;
        private XtraEditors.LookUpEdit edProductName;
        private XtraEditors.LabelControl lbOrderId;
        private XtraEditors.SimpleButton btnReset;
        private XtraEditors.CheckEdit chbDiscount;
    }
}
