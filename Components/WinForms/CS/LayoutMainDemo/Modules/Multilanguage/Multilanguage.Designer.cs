namespace DevExpress.XtraLayout.Demos {
    partial class Multilanguage {
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.showFormButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.layoutModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.localizationModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.dpiModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.sizeModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.selectionGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.localizationGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.localizationModeRadionGroupItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutModeGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutModeRadionGroupItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dpiGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dpiModeRadionGroupItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.sizeModeGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sizeModeRadionGroupItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.showFormButtonItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationModeRadionGroupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeRadionGroupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiModeRadionGroupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeRadionGroupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormButtonItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // showFormButton
            // 
            this.showFormButton.Location = new System.Drawing.Point(616, 263);
            this.showFormButton.Name = "showFormButton";
            this.showFormButton.Size = new System.Drawing.Size(136, 36);
            this.showFormButton.StyleController = this.layoutControl1;
            this.showFormButton.TabIndex = 6;
            this.showFormButton.Text = "Show";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblInfo);
            this.layoutControl1.Controls.Add(this.showFormButton);
            this.layoutControl1.Controls.Add(this.layoutModeRadioGroup);
            this.layoutControl1.Controls.Add(this.localizationModeRadioGroup);
            this.layoutControl1.Controls.Add(this.dpiModeRadioGroup);
            this.layoutControl1.Controls.Add(this.sizeModeRadioGroup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(961, 80, 854, 859);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(935, 540);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblInfo
            // 
            this.lblInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(455, 161);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(467, 19);
            this.lblInfo.StyleController = this.layoutControl1;
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Click the button below to show a form with these options";
            // 
            // layoutModeRadioGroup
            // 
            this.layoutModeRadioGroup.Location = new System.Drawing.Point(241, 127);
            this.layoutModeRadioGroup.Name = "layoutModeRadioGroup";
            this.layoutModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.layoutModeRadioGroup.Properties.Columns = 1;
            this.layoutModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Flow"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Regular")});
            this.layoutModeRadioGroup.Size = new System.Drawing.Size(177, 143);
            this.layoutModeRadioGroup.StyleController = this.layoutControl1;
            this.layoutModeRadioGroup.TabIndex = 10;
            // 
            // localizationModeRadioGroup
            // 
            this.localizationModeRadioGroup.Location = new System.Drawing.Point(36, 127);
            this.localizationModeRadioGroup.Name = "localizationModeRadioGroup";
            this.localizationModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.localizationModeRadioGroup.Properties.Columns = 1;
            this.localizationModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "English version"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "German version")});
            this.localizationModeRadioGroup.Size = new System.Drawing.Size(177, 143);
            this.localizationModeRadioGroup.StyleController = this.layoutControl1;
            this.localizationModeRadioGroup.TabIndex = 11;
            // 
            // dpiModeRadioGroup
            // 
            this.dpiModeRadioGroup.Location = new System.Drawing.Point(241, 317);
            this.dpiModeRadioGroup.Name = "dpiModeRadioGroup";
            this.dpiModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dpiModeRadioGroup.Properties.Columns = 1;
            this.dpiModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Small DPI(75%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Regular DPI(100%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Medium DPI(125%)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Large DPI(150%)")});
            this.dpiModeRadioGroup.Size = new System.Drawing.Size(177, 143);
            this.dpiModeRadioGroup.StyleController = this.layoutControl1;
            this.dpiModeRadioGroup.TabIndex = 12;
            // 
            // sizeModeRadioGroup
            // 
            this.sizeModeRadioGroup.Location = new System.Drawing.Point(36, 317);
            this.sizeModeRadioGroup.Name = "sizeModeRadioGroup";
            this.sizeModeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sizeModeRadioGroup.Properties.Columns = 1;
            this.sizeModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Animated Form"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tablet Landscape"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tablet Portrait")});
            this.sizeModeRadioGroup.Size = new System.Drawing.Size(177, 143);
            this.sizeModeRadioGroup.StyleController = this.layoutControl1;
            this.sizeModeRadioGroup.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.selectionGroup,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.showFormButtonItem,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.layoutControlItem1,
            this.emptySpaceItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(935, 540);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // selectionGroup
            // 
            this.selectionGroup.CustomizationFormText = "selectionGroup";
            this.selectionGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.localizationGroup,
            this.layoutModeGroup,
            this.dpiGroup,
            this.sizeModeGroup});
            this.selectionGroup.Location = new System.Drawing.Point(0, 72);
            this.selectionGroup.Name = "selectionGroup";
            this.selectionGroup.Size = new System.Drawing.Size(434, 404);
            this.selectionGroup.Text = "selectionGroup";
            this.selectionGroup.TextVisible = false;
            // 
            // localizationGroup
            // 
            this.localizationGroup.CustomizationFormText = "Select Localization";
            this.localizationGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.localizationModeRadionGroupItem});
            this.localizationGroup.Location = new System.Drawing.Point(0, 0);
            this.localizationGroup.Name = "localizationGroup";
            this.localizationGroup.Size = new System.Drawing.Size(205, 190);
            this.localizationGroup.Text = "Form Localization";
            // 
            // localizationModeRadionGroupItem
            // 
            this.localizationModeRadionGroupItem.Control = this.localizationModeRadioGroup;
            this.localizationModeRadionGroupItem.CustomizationFormText = "localizationModeRadionGroupItem";
            this.localizationModeRadionGroupItem.Location = new System.Drawing.Point(0, 0);
            this.localizationModeRadionGroupItem.MaxSize = new System.Drawing.Size(181, 147);
            this.localizationModeRadionGroupItem.MinSize = new System.Drawing.Size(181, 147);
            this.localizationModeRadionGroupItem.Name = "localizationModeRadionGroupItem";
            this.localizationModeRadionGroupItem.Size = new System.Drawing.Size(181, 147);
            this.localizationModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.localizationModeRadionGroupItem.Text = "localizationModeRadionGroupItem";
            this.localizationModeRadionGroupItem.TextSize = new System.Drawing.Size(0, 0);
            this.localizationModeRadionGroupItem.TextVisible = false;
            // 
            // layoutModeGroup
            // 
            this.layoutModeGroup.CustomizationFormText = "Select Layout";
            this.layoutModeGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutModeRadionGroupItem});
            this.layoutModeGroup.Location = new System.Drawing.Point(205, 0);
            this.layoutModeGroup.Name = "layoutModeGroup";
            this.layoutModeGroup.Size = new System.Drawing.Size(205, 190);
            this.layoutModeGroup.Text = "LayoutControl’s Layout Mode";
            // 
            // layoutModeRadionGroupItem
            // 
            this.layoutModeRadionGroupItem.Control = this.layoutModeRadioGroup;
            this.layoutModeRadionGroupItem.CustomizationFormText = "layoutModeRadionGroupItem";
            this.layoutModeRadionGroupItem.Location = new System.Drawing.Point(0, 0);
            this.layoutModeRadionGroupItem.MaxSize = new System.Drawing.Size(181, 147);
            this.layoutModeRadionGroupItem.MinSize = new System.Drawing.Size(181, 147);
            this.layoutModeRadionGroupItem.Name = "layoutModeRadionGroupItem";
            this.layoutModeRadionGroupItem.Size = new System.Drawing.Size(181, 147);
            this.layoutModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutModeRadionGroupItem.Text = "layoutModeRadionGroupItem";
            this.layoutModeRadionGroupItem.TextSize = new System.Drawing.Size(0, 0);
            this.layoutModeRadionGroupItem.TextVisible = false;
            // 
            // dpiGroup
            // 
            this.dpiGroup.CustomizationFormText = "Select DPI";
            this.dpiGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.dpiModeRadionGroupItem});
            this.dpiGroup.Location = new System.Drawing.Point(205, 190);
            this.dpiGroup.Name = "dpiGroup";
            this.dpiGroup.Size = new System.Drawing.Size(205, 190);
            this.dpiGroup.Text = "DPI";
            // 
            // dpiModeRadionGroupItem
            // 
            this.dpiModeRadionGroupItem.Control = this.dpiModeRadioGroup;
            this.dpiModeRadionGroupItem.CustomizationFormText = "dpiModeRadionGroupItem";
            this.dpiModeRadionGroupItem.Location = new System.Drawing.Point(0, 0);
            this.dpiModeRadionGroupItem.MaxSize = new System.Drawing.Size(181, 147);
            this.dpiModeRadionGroupItem.MinSize = new System.Drawing.Size(181, 147);
            this.dpiModeRadionGroupItem.Name = "dpiModeRadionGroupItem";
            this.dpiModeRadionGroupItem.Size = new System.Drawing.Size(181, 147);
            this.dpiModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.dpiModeRadionGroupItem.Text = "dpiModeRadionGroupItem";
            this.dpiModeRadionGroupItem.TextSize = new System.Drawing.Size(0, 0);
            this.dpiModeRadionGroupItem.TextVisible = false;
            // 
            // sizeModeGroup
            // 
            this.sizeModeGroup.CustomizationFormText = "Select animation";
            this.sizeModeGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sizeModeRadionGroupItem});
            this.sizeModeGroup.Location = new System.Drawing.Point(0, 190);
            this.sizeModeGroup.Name = "sizeModeGroup";
            this.sizeModeGroup.Size = new System.Drawing.Size(205, 190);
            this.sizeModeGroup.Text = "Form Size";
            // 
            // sizeModeRadionGroupItem
            // 
            this.sizeModeRadionGroupItem.Control = this.sizeModeRadioGroup;
            this.sizeModeRadionGroupItem.CustomizationFormText = "sizeModeRadionGroupItem";
            this.sizeModeRadionGroupItem.Location = new System.Drawing.Point(0, 0);
            this.sizeModeRadionGroupItem.MaxSize = new System.Drawing.Size(181, 147);
            this.sizeModeRadionGroupItem.MinSize = new System.Drawing.Size(181, 147);
            this.sizeModeRadionGroupItem.Name = "sizeModeRadionGroupItem";
            this.sizeModeRadionGroupItem.Size = new System.Drawing.Size(181, 147);
            this.sizeModeRadionGroupItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.sizeModeRadionGroupItem.Text = "sizeModeRadionGroupItem";
            this.sizeModeRadionGroupItem.TextSize = new System.Drawing.Size(0, 0);
            this.sizeModeRadionGroupItem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 476);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(915, 44);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(915, 72);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // showFormButtonItem
            // 
            this.showFormButtonItem.Control = this.showFormButton;
            this.showFormButtonItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.showFormButtonItem.CustomizationFormText = "showFormButtonItem";
            this.showFormButtonItem.Location = new System.Drawing.Point(434, 251);
            this.showFormButtonItem.MaxSize = new System.Drawing.Size(140, 40);
            this.showFormButtonItem.MinSize = new System.Drawing.Size(140, 40);
            this.showFormButtonItem.Name = "showFormButtonItem";
            this.showFormButtonItem.Size = new System.Drawing.Size(481, 40);
            this.showFormButtonItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.showFormButtonItem.Text = "showFormButtonItem";
            this.showFormButtonItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.showFormButtonItem.TextSize = new System.Drawing.Size(0, 0);
            this.showFormButtonItem.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5";
            this.emptySpaceItem5.Location = new System.Drawing.Point(434, 72);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(481, 77);
            this.emptySpaceItem5.Text = "emptySpaceItem5";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem6";
            this.emptySpaceItem6.Location = new System.Drawing.Point(434, 291);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(481, 185);
            this.emptySpaceItem6.Text = "emptySpaceItem6";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblInfo;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(434, 149);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(481, 23);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.CustomizationFormText = "emptySpaceItem8";
            this.emptySpaceItem8.Location = new System.Drawing.Point(434, 172);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(481, 79);
            this.emptySpaceItem8.Text = "emptySpaceItem8";
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Multilanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Multilanguage";
            this.Size = new System.Drawing.Size(935, 540);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localizationModeRadionGroupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutModeRadionGroupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpiModeRadionGroupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeModeRadionGroupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormButtonItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.Container components = null;
        private XtraEditors.SimpleButton showFormButton;
        private LayoutControl layoutControl1;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlGroup dpiGroup;
        private LayoutControlGroup layoutModeGroup;
        private LayoutControlGroup localizationGroup;
        private LayoutControlItem showFormButtonItem;
        private LayoutControlGroup sizeModeGroup;
        private XtraEditors.RadioGroup layoutModeRadioGroup;
        private XtraEditors.RadioGroup localizationModeRadioGroup;
        private XtraEditors.RadioGroup dpiModeRadioGroup;
        private XtraEditors.RadioGroup sizeModeRadioGroup;
        private LayoutControlItem dpiModeRadionGroupItem;
        private LayoutControlItem layoutModeRadionGroupItem;
        private LayoutControlItem localizationModeRadionGroupItem;
        private LayoutControlItem sizeModeRadionGroupItem;
        private LayoutControlGroup selectionGroup;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem2;
        private EmptySpaceItem emptySpaceItem5;
        private EmptySpaceItem emptySpaceItem6;
        private XtraEditors.LabelControl lblInfo;
        private LayoutControlItem layoutControlItem1;
        private EmptySpaceItem emptySpaceItem8;

    }
}
