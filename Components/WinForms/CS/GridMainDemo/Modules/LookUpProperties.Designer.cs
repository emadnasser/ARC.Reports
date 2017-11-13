namespace DevExpress.XtraGrid.Demos {
    partial class LookUpProperties {
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpProperties));
            this.lblSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.lbValue = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceAutoComplete = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowPopupFooter = new DevExpress.XtraEditors.CheckEdit();
            this.cePopupSizeable = new DevExpress.XtraEditors.CheckEdit();
            this.ceImmediatePopup = new DevExpress.XtraEditors.CheckEdit();
            this.icbTextEditStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ceEnableAppearanceEvenRow = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowVerticalLines = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowHorzLines = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowIndicator = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowColumnHeaders = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowAutoFilterRow = new DevExpress.XtraEditors.CheckEdit();
            this.ceEnableAppearanceOddRow = new DevExpress.XtraEditors.CheckEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoComplete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPopupFooter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceImmediatePopup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTextEditStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAppearanceEvenRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowVerticalLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowHorzLines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowIndicator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnHeaders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAutoFilterRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAppearanceOddRow.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            resources.ApplyResources(this.lblSelect, "lblSelect");
            this.lblSelect.Name = "lblSelect";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbDisplay
            // 
            resources.ApplyResources(this.lbDisplay, "lbDisplay");
            this.lbDisplay.Name = "lbDisplay";
            // 
            // lbValue
            // 
            resources.ApplyResources(this.lbValue, "lbValue");
            this.lbValue.Name = "lbValue";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ceAutoComplete);
            this.groupControl1.Controls.Add(this.ceShowPopupFooter);
            this.groupControl1.Controls.Add(this.cePopupSizeable);
            this.groupControl1.Controls.Add(this.ceImmediatePopup);
            this.groupControl1.Controls.Add(this.icbTextEditStyle);
            this.groupControl1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // ceAutoComplete
            // 
            resources.ApplyResources(this.ceAutoComplete, "ceAutoComplete");
            this.ceAutoComplete.Name = "ceAutoComplete";
            this.ceAutoComplete.Properties.Caption = resources.GetString("ceAutoComplete.Properties.Caption");
            this.ceAutoComplete.CheckedChanged += new System.EventHandler(this.ceAutoComplete_CheckedChanged);
            // 
            // ceShowPopupFooter
            // 
            resources.ApplyResources(this.ceShowPopupFooter, "ceShowPopupFooter");
            this.ceShowPopupFooter.Name = "ceShowPopupFooter";
            this.ceShowPopupFooter.Properties.Caption = resources.GetString("ceShowPopupFooter.Properties.Caption");
            this.ceShowPopupFooter.CheckedChanged += new System.EventHandler(this.ceShowPopupFooter_CheckedChanged);
            // 
            // cePopupSizeable
            // 
            resources.ApplyResources(this.cePopupSizeable, "cePopupSizeable");
            this.cePopupSizeable.Name = "cePopupSizeable";
            this.cePopupSizeable.Properties.Caption = resources.GetString("cePopupSizeable.Properties.Caption");
            this.cePopupSizeable.CheckedChanged += new System.EventHandler(this.cePopupSizeable_CheckedChanged);
            // 
            // ceImmediatePopup
            // 
            resources.ApplyResources(this.ceImmediatePopup, "ceImmediatePopup");
            this.ceImmediatePopup.Name = "ceImmediatePopup";
            this.ceImmediatePopup.Properties.Caption = resources.GetString("ceImmediatePopup.Properties.Caption");
            this.ceImmediatePopup.CheckedChanged += new System.EventHandler(this.ceImmediatePopup_CheckedChanged);
            // 
            // icbTextEditStyle
            // 
            resources.ApplyResources(this.icbTextEditStyle, "icbTextEditStyle");
            this.icbTextEditStyle.Name = "icbTextEditStyle";
            this.icbTextEditStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbTextEditStyle.Properties.Buttons"))))});
            this.icbTextEditStyle.SelectedIndexChanged += new System.EventHandler(this.icbTextEditStyle_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ceEnableAppearanceEvenRow);
            this.groupControl2.Controls.Add(this.ceShowVerticalLines);
            this.groupControl2.Controls.Add(this.ceShowHorzLines);
            this.groupControl2.Controls.Add(this.ceShowIndicator);
            this.groupControl2.Controls.Add(this.ceShowColumnHeaders);
            this.groupControl2.Controls.Add(this.ceShowAutoFilterRow);
            this.groupControl2.Controls.Add(this.ceEnableAppearanceOddRow);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            // 
            // ceEnableAppearanceEvenRow
            // 
            resources.ApplyResources(this.ceEnableAppearanceEvenRow, "ceEnableAppearanceEvenRow");
            this.ceEnableAppearanceEvenRow.Name = "ceEnableAppearanceEvenRow";
            this.ceEnableAppearanceEvenRow.Properties.Caption = resources.GetString("ceEnableAppearanceEvenRow.Properties.Caption");
            this.ceEnableAppearanceEvenRow.CheckedChanged += new System.EventHandler(this.ceEnableAppearanceEvenRow_CheckedChanged);
            // 
            // ceShowVerticalLines
            // 
            resources.ApplyResources(this.ceShowVerticalLines, "ceShowVerticalLines");
            this.ceShowVerticalLines.Name = "ceShowVerticalLines";
            this.ceShowVerticalLines.Properties.Caption = resources.GetString("ceShowVerticalLines.Properties.Caption");
            this.ceShowVerticalLines.CheckedChanged += new System.EventHandler(this.ceShowVerticalLines_CheckedChanged);
            // 
            // ceShowHorzLines
            // 
            resources.ApplyResources(this.ceShowHorzLines, "ceShowHorzLines");
            this.ceShowHorzLines.Name = "ceShowHorzLines";
            this.ceShowHorzLines.Properties.Caption = resources.GetString("ceShowHorzLines.Properties.Caption");
            this.ceShowHorzLines.CheckedChanged += new System.EventHandler(this.ceShowHorzLines_CheckedChanged);
            // 
            // ceShowIndicator
            // 
            resources.ApplyResources(this.ceShowIndicator, "ceShowIndicator");
            this.ceShowIndicator.Name = "ceShowIndicator";
            this.ceShowIndicator.Properties.Caption = resources.GetString("ceShowIndicator.Properties.Caption");
            this.ceShowIndicator.CheckedChanged += new System.EventHandler(this.ceShowIndicator_CheckedChanged);
            // 
            // ceShowColumnHeaders
            // 
            resources.ApplyResources(this.ceShowColumnHeaders, "ceShowColumnHeaders");
            this.ceShowColumnHeaders.Name = "ceShowColumnHeaders";
            this.ceShowColumnHeaders.Properties.Caption = resources.GetString("ceShowColumnHeaders.Properties.Caption");
            this.ceShowColumnHeaders.CheckedChanged += new System.EventHandler(this.ceShowColumnHeaders_CheckedChanged);
            // 
            // ceShowAutoFilterRow
            // 
            resources.ApplyResources(this.ceShowAutoFilterRow, "ceShowAutoFilterRow");
            this.ceShowAutoFilterRow.Name = "ceShowAutoFilterRow";
            this.ceShowAutoFilterRow.Properties.Caption = resources.GetString("ceShowAutoFilterRow.Properties.Caption");
            this.ceShowAutoFilterRow.CheckedChanged += new System.EventHandler(this.ceShowAutoFilterRow_CheckedChanged);
            // 
            // ceEnableAppearanceOddRow
            // 
            resources.ApplyResources(this.ceEnableAppearanceOddRow, "ceEnableAppearanceOddRow");
            this.ceEnableAppearanceOddRow.Name = "ceEnableAppearanceOddRow";
            this.ceEnableAppearanceOddRow.Properties.Caption = resources.GetString("ceEnableAppearanceOddRow.Properties.Caption");
            this.ceEnableAppearanceOddRow.CheckedChanged += new System.EventHandler(this.ceEnableAppearanceOddRow_CheckedChanged);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupControl1);
            this.xtraScrollableControl1.Controls.Add(this.groupControl2);
            this.xtraScrollableControl1.Controls.Add(this.lblSelect);
            this.xtraScrollableControl1.Controls.Add(this.label1);
            this.xtraScrollableControl1.Controls.Add(this.lbValue);
            this.xtraScrollableControl1.Controls.Add(this.lbDisplay);
            resources.ApplyResources(this.xtraScrollableControl1, "xtraScrollableControl1");
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            // 
            // LookUpProperties
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "LookUpProperties";
            this.Load += new System.EventHandler(this.LookUpProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoComplete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPopupFooter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePopupSizeable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceImmediatePopup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbTextEditStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAppearanceEvenRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowVerticalLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowHorzLines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowIndicator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumnHeaders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowAutoFilterRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceEnableAppearanceOddRow.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDisplay;
        private System.Windows.Forms.Label lbValue;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.CheckEdit ceImmediatePopup;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbTextEditStyle;
        private DevExpress.XtraEditors.CheckEdit ceShowAutoFilterRow;
        private DevExpress.XtraEditors.CheckEdit cePopupSizeable;
        private DevExpress.XtraEditors.CheckEdit ceShowPopupFooter;
        private DevExpress.XtraEditors.CheckEdit ceShowHorzLines;
        private DevExpress.XtraEditors.CheckEdit ceShowIndicator;
        private DevExpress.XtraEditors.CheckEdit ceShowColumnHeaders;
        private DevExpress.XtraEditors.CheckEdit ceShowVerticalLines;
        private DevExpress.XtraEditors.CheckEdit ceEnableAppearanceEvenRow;
        private DevExpress.XtraEditors.CheckEdit ceEnableAppearanceOddRow;
        private DevExpress.XtraEditors.CheckEdit ceAutoComplete;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}
