namespace DevExpress.XtraLayout.Demos {
    partial class BaseTutorialControl {
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcTitle = new DevExpress.XtraLayout.LayoutControl();
            this.snapModeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.showPropertyGridCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.showAdornerLayerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.quickCustomizationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.allowItemSkinningCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.highlightFocusedItemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.sbCustomize = new DevExpress.XtraEditors.SimpleButton();
            this.cbFiles = new DevExpress.XtraEditors.ComboBoxEdit();
            this.allowExpandAnimationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tabTransitionAnimationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.lcMainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.quickCustomizationLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.showAdornerLayerLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.allowItemSkinningLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.highlightFocusedItemCheckEditLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcCustomizeButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.allowExpandAnimationLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.showPropertyGridLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.snapModeLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.allowExpandAnimationLCI1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcItemCombo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).BeginInit();
            this.lcTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowItemSkinningCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTransitionAnimationCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowItemSkinningLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEditLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcItemCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(468, 0);
            this.panelControl1.MaximumSize = new System.Drawing.Size(10, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(10, 396);
            this.panelControl1.TabIndex = 3;
            // 
            // navigationPane1
            // 
            this.navigationPane1.AllowResize = false;
            this.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(478, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(236, 396);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(236, 396);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.lcTitle);
            this.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(186, 336);
            // 
            // lcTitle
            // 
            this.lcTitle.AllowCustomization = false;
            this.lcTitle.Controls.Add(this.snapModeCheckEdit);
            this.lcTitle.Controls.Add(this.showPropertyGridCheckEdit);
            this.lcTitle.Controls.Add(this.showAdornerLayerCheckEdit);
            this.lcTitle.Controls.Add(this.quickCustomizationCheckEdit);
            this.lcTitle.Controls.Add(this.allowItemSkinningCheckEdit);
            this.lcTitle.Controls.Add(this.highlightFocusedItemCheckEdit);
            this.lcTitle.Controls.Add(this.sbCustomize);
            this.lcTitle.Controls.Add(this.cbFiles);
            this.lcTitle.Controls.Add(this.allowExpandAnimationCheckEdit);
            this.lcTitle.Controls.Add(this.tabTransitionAnimationCheckEdit);
            this.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTitle.Location = new System.Drawing.Point(0, 0);
            this.lcTitle.Name = "lcTitle";
            this.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1299, 548, 715, 579);
            this.lcTitle.OptionsView.AllowItemSkinning = false;
            this.lcTitle.OptionsView.UseParentAutoScaleFactor = true;
            this.lcTitle.OptionsView.UseSkinIndents = false;
            this.lcTitle.Root = this.lcMainGroup;
            this.lcTitle.Size = new System.Drawing.Size(186, 336);
            this.lcTitle.TabIndex = 1;
            // 
            // snapModeCheckEdit
            // 
            this.snapModeCheckEdit.EditValue = true;
            this.snapModeCheckEdit.Location = new System.Drawing.Point(2, 233);
            this.snapModeCheckEdit.Name = "snapModeCheckEdit";
            this.snapModeCheckEdit.Properties.Caption = "Snap Customization Form";
            this.snapModeCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.snapModeCheckEdit.StyleController = this.lcTitle;
            this.snapModeCheckEdit.TabIndex = 14;
            this.snapModeCheckEdit.CheckedChanged += new System.EventHandler(this.snapModeCheckEdit_CheckedChanged);
            // 
            // showPropertyGridCheckEdit
            // 
            this.showPropertyGridCheckEdit.EditValue = true;
            this.showPropertyGridCheckEdit.Location = new System.Drawing.Point(2, 206);
            this.showPropertyGridCheckEdit.Name = "showPropertyGridCheckEdit";
            this.showPropertyGridCheckEdit.Properties.Caption = "Show PropertyGrid";
            this.showPropertyGridCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.showPropertyGridCheckEdit.StyleController = this.lcTitle;
            this.showPropertyGridCheckEdit.TabIndex = 13;
            this.showPropertyGridCheckEdit.CheckedChanged += new System.EventHandler(this.showPropertyGridCheckEdit_CheckedChanged);
            // 
            // showAdornerLayerCheckEdit
            // 
            this.showAdornerLayerCheckEdit.Location = new System.Drawing.Point(2, 125);
            this.showAdornerLayerCheckEdit.Name = "showAdornerLayerCheckEdit";
            this.showAdornerLayerCheckEdit.Properties.Caption = "Show Adorner Layer";
            this.showAdornerLayerCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.showAdornerLayerCheckEdit.StyleController = this.lcTitle;
            this.showAdornerLayerCheckEdit.TabIndex = 12;
            this.showAdornerLayerCheckEdit.CheckedChanged += new System.EventHandler(this.checkEdit6_CheckedChanged);
            // 
            // quickCustomizationCheckEdit
            // 
            this.quickCustomizationCheckEdit.Location = new System.Drawing.Point(2, 44);
            this.quickCustomizationCheckEdit.Margin = new System.Windows.Forms.Padding(0);
            this.quickCustomizationCheckEdit.Name = "quickCustomizationCheckEdit";
            this.quickCustomizationCheckEdit.Properties.Caption = "Quick Customization Mode";
            this.quickCustomizationCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.quickCustomizationCheckEdit.StyleController = this.lcTitle;
            this.quickCustomizationCheckEdit.TabIndex = 11;
            this.quickCustomizationCheckEdit.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // allowItemSkinningCheckEdit
            // 
            this.allowItemSkinningCheckEdit.EditValue = true;
            this.allowItemSkinningCheckEdit.Location = new System.Drawing.Point(2, 71);
            this.allowItemSkinningCheckEdit.Name = "allowItemSkinningCheckEdit";
            this.allowItemSkinningCheckEdit.Properties.Caption = "Allow Item Skinning";
            this.allowItemSkinningCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.allowItemSkinningCheckEdit.StyleController = this.lcTitle;
            this.allowItemSkinningCheckEdit.TabIndex = 9;
            this.allowItemSkinningCheckEdit.CheckedChanged += new System.EventHandler(this.allowItemSkinningCheckEdit_CheckedChanged);
            // 
            // highlightFocusedItemCheckEdit
            // 
            this.highlightFocusedItemCheckEdit.Location = new System.Drawing.Point(2, 98);
            this.highlightFocusedItemCheckEdit.Name = "highlightFocusedItemCheckEdit";
            this.highlightFocusedItemCheckEdit.Properties.Caption = "Highlight Focused Item";
            this.highlightFocusedItemCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.highlightFocusedItemCheckEdit.StyleController = this.lcTitle;
            this.highlightFocusedItemCheckEdit.TabIndex = 8;
            this.highlightFocusedItemCheckEdit.CheckedChanged += new System.EventHandler(this.highlightFocusedItemCheckEdit_CheckedChanged);
            // 
            // sbCustomize
            // 
            this.sbCustomize.Location = new System.Drawing.Point(1, 257);
            this.sbCustomize.Name = "sbCustomize";
            this.sbCustomize.Size = new System.Drawing.Size(184, 22);
            this.sbCustomize.StyleController = this.lcTitle;
            this.sbCustomize.TabIndex = 6;
            this.sbCustomize.Text = "Customize Layout";
            this.sbCustomize.Click += new System.EventHandler(this.sbCustomize_Click);
            // 
            // cbFiles
            // 
            this.cbFiles.EditValue = "";
            this.cbFiles.Location = new System.Drawing.Point(1, 19);
            this.cbFiles.Name = "cbFiles";
            this.cbFiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Load Layout", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Load Layout", null, null, false)});
            this.cbFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFiles.Size = new System.Drawing.Size(184, 20);
            this.cbFiles.StyleController = this.lcTitle;
            this.cbFiles.TabIndex = 3;
            this.cbFiles.EditValueChanged += new System.EventHandler(this.cbFiles_EditValueChanged);
            // 
            // allowExpandAnimationCheckEdit
            // 
            this.allowExpandAnimationCheckEdit.EditValue = true;
            this.allowExpandAnimationCheckEdit.Location = new System.Drawing.Point(2, 152);
            this.allowExpandAnimationCheckEdit.Name = "allowExpandAnimationCheckEdit";
            this.allowExpandAnimationCheckEdit.Properties.Caption = "Allow Group Expand Animation";
            this.allowExpandAnimationCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.allowExpandAnimationCheckEdit.StyleController = this.lcTitle;
            this.allowExpandAnimationCheckEdit.TabIndex = 12;
            this.allowExpandAnimationCheckEdit.CheckedChanged += new System.EventHandler(this.allowExpandAnimationCheckEdit_CheckedChanged);
            // 
            // tabTransitionAnimationCheckEdit
            // 
            this.tabTransitionAnimationCheckEdit.EditValue = true;
            this.tabTransitionAnimationCheckEdit.Location = new System.Drawing.Point(2, 179);
            this.tabTransitionAnimationCheckEdit.Name = "tabTransitionAnimationCheckEdit";
            this.tabTransitionAnimationCheckEdit.Properties.Caption = "Allow Tab Transition Animation";
            this.tabTransitionAnimationCheckEdit.Size = new System.Drawing.Size(182, 19);
            this.tabTransitionAnimationCheckEdit.StyleController = this.lcTitle;
            this.tabTransitionAnimationCheckEdit.TabIndex = 12;
            this.tabTransitionAnimationCheckEdit.CheckedChanged += new System.EventHandler(this.tabTransitionAnimation_CheckedChanged);
            // 
            // lcMainGroup
            // 
            this.lcMainGroup.CustomizationFormText = "Select xml file and restore layout";
            this.lcMainGroup.GroupBordersVisible = false;
            this.lcMainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.lcItemCombo});
            this.lcMainGroup.Location = new System.Drawing.Point(0, 0);
            this.lcMainGroup.Name = "Root";
            this.lcMainGroup.OptionsItemText.TextToControlDistance = 5;
            this.lcMainGroup.Size = new System.Drawing.Size(186, 336);
            this.lcMainGroup.Text = "Select xml file and restore layout";
            this.lcMainGroup.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Paint options";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.quickCustomizationLCI,
            this.showAdornerLayerLCI,
            this.allowItemSkinningLCI,
            this.highlightFocusedItemCheckEditLCI,
            this.lcCustomizeButton,
            this.emptySpaceItem1,
            this.allowExpandAnimationLCI,
            this.showPropertyGridLCI,
            this.snapModeLCI,
            this.allowExpandAnimationLCI1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(186, 296);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Paint options";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // quickCustomizationLCI
            // 
            this.quickCustomizationLCI.Control = this.quickCustomizationCheckEdit;
            this.quickCustomizationLCI.CustomizationFormText = "quickCustomizationLCI";
            this.quickCustomizationLCI.Location = new System.Drawing.Point(0, 0);
            this.quickCustomizationLCI.Name = "quickCustomizationLCI";
            this.quickCustomizationLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.quickCustomizationLCI.Size = new System.Drawing.Size(186, 27);
            this.quickCustomizationLCI.TextSize = new System.Drawing.Size(0, 0);
            this.quickCustomizationLCI.TextVisible = false;
            // 
            // showAdornerLayerLCI
            // 
            this.showAdornerLayerLCI.Control = this.showAdornerLayerCheckEdit;
            this.showAdornerLayerLCI.Location = new System.Drawing.Point(0, 81);
            this.showAdornerLayerLCI.Name = "showAdornerLayerLCI";
            this.showAdornerLayerLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.showAdornerLayerLCI.Size = new System.Drawing.Size(186, 27);
            this.showAdornerLayerLCI.TextSize = new System.Drawing.Size(0, 0);
            this.showAdornerLayerLCI.TextVisible = false;
            // 
            // allowItemSkinningLCI
            // 
            this.allowItemSkinningLCI.Control = this.allowItemSkinningCheckEdit;
            this.allowItemSkinningLCI.CustomizationFormText = "allowItemSkinningLCI";
            this.allowItemSkinningLCI.Location = new System.Drawing.Point(0, 27);
            this.allowItemSkinningLCI.Name = "allowItemSkinningLCI";
            this.allowItemSkinningLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.allowItemSkinningLCI.Size = new System.Drawing.Size(186, 27);
            this.allowItemSkinningLCI.TextSize = new System.Drawing.Size(0, 0);
            this.allowItemSkinningLCI.TextVisible = false;
            // 
            // highlightFocusedItemCheckEditLCI
            // 
            this.highlightFocusedItemCheckEditLCI.Control = this.highlightFocusedItemCheckEdit;
            this.highlightFocusedItemCheckEditLCI.CustomizationFormText = "highlightFocusedItemCheckEditLCI";
            this.highlightFocusedItemCheckEditLCI.Location = new System.Drawing.Point(0, 54);
            this.highlightFocusedItemCheckEditLCI.Name = "highlightFocusedItemCheckEditLCI";
            this.highlightFocusedItemCheckEditLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.highlightFocusedItemCheckEditLCI.Size = new System.Drawing.Size(186, 27);
            this.highlightFocusedItemCheckEditLCI.TextSize = new System.Drawing.Size(0, 0);
            this.highlightFocusedItemCheckEditLCI.TextVisible = false;
            // 
            // lcCustomizeButton
            // 
            this.lcCustomizeButton.Control = this.sbCustomize;
            this.lcCustomizeButton.CustomizationFormText = "lcCustomizeButton";
            this.lcCustomizeButton.Location = new System.Drawing.Point(0, 216);
            this.lcCustomizeButton.Name = "lcCustomizeButton";
            this.lcCustomizeButton.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.lcCustomizeButton.Size = new System.Drawing.Size(186, 24);
            this.lcCustomizeButton.TextSize = new System.Drawing.Size(0, 0);
            this.lcCustomizeButton.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 240);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(186, 56);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // allowExpandAnimationLCI
            // 
            this.allowExpandAnimationLCI.Control = this.allowExpandAnimationCheckEdit;
            this.allowExpandAnimationLCI.CustomizationFormText = "showAdornerLayerLCI";
            this.allowExpandAnimationLCI.Location = new System.Drawing.Point(0, 108);
            this.allowExpandAnimationLCI.Name = "allowExpandAnimationLCI";
            this.allowExpandAnimationLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.allowExpandAnimationLCI.Size = new System.Drawing.Size(186, 27);
            this.allowExpandAnimationLCI.Text = "showAdornerLayerLCI";
            this.allowExpandAnimationLCI.TextSize = new System.Drawing.Size(0, 0);
            this.allowExpandAnimationLCI.TextVisible = false;
            this.allowExpandAnimationLCI.CustomDraw += new System.EventHandler<DevExpress.XtraLayout.ItemCustomDrawEventArgs>(this.snapModeLCI_CustomDraw);
            // 
            // showPropertyGridLCI
            // 
            this.showPropertyGridLCI.Control = this.showPropertyGridCheckEdit;
            this.showPropertyGridLCI.Location = new System.Drawing.Point(0, 162);
            this.showPropertyGridLCI.Name = "showPropertyGridLCI";
            this.showPropertyGridLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.showPropertyGridLCI.Size = new System.Drawing.Size(186, 27);
            this.showPropertyGridLCI.TextSize = new System.Drawing.Size(0, 0);
            this.showPropertyGridLCI.TextVisible = false;
            // 
            // snapModeLCI
            // 
            this.snapModeLCI.Control = this.snapModeCheckEdit;
            this.snapModeLCI.Location = new System.Drawing.Point(0, 189);
            this.snapModeLCI.Name = "snapModeLCI";
            this.snapModeLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.snapModeLCI.Size = new System.Drawing.Size(186, 27);
            this.snapModeLCI.TextSize = new System.Drawing.Size(0, 0);
            this.snapModeLCI.TextVisible = false;
            this.snapModeLCI.CustomDraw += new System.EventHandler<DevExpress.XtraLayout.ItemCustomDrawEventArgs>(this.snapModeLCI_CustomDraw);
            // 
            // allowExpandAnimationLCI1
            // 
            this.allowExpandAnimationLCI1.Control = this.tabTransitionAnimationCheckEdit;
            this.allowExpandAnimationLCI1.CustomizationFormText = "showAdornerLayerLCI";
            this.allowExpandAnimationLCI1.Location = new System.Drawing.Point(0, 135);
            this.allowExpandAnimationLCI1.Name = "allowExpandAnimationLCI1";
            this.allowExpandAnimationLCI1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4);
            this.allowExpandAnimationLCI1.Size = new System.Drawing.Size(186, 27);
            this.allowExpandAnimationLCI1.Text = "showAdornerLayerLCI";
            this.allowExpandAnimationLCI1.TextSize = new System.Drawing.Size(0, 0);
            this.allowExpandAnimationLCI1.TextVisible = false;
            this.allowExpandAnimationLCI1.CustomDraw += new System.EventHandler<DevExpress.XtraLayout.ItemCustomDrawEventArgs>(this.snapModeLCI_CustomDraw);
            // 
            // lcItemCombo
            // 
            this.lcItemCombo.Control = this.cbFiles;
            this.lcItemCombo.CustomizationFormText = "Xml files:";
            this.lcItemCombo.Location = new System.Drawing.Point(0, 0);
            this.lcItemCombo.Name = "lcItemCombo";
            this.lcItemCombo.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.lcItemCombo.Size = new System.Drawing.Size(186, 40);
            this.lcItemCombo.Text = "Xml files:";
            this.lcItemCombo.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcItemCombo.TextSize = new System.Drawing.Size(42, 13);
            // 
            // BaseTutorialControl
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "BaseTutorialControl";
            this.Size = new System.Drawing.Size(714, 396);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).EndInit();
            this.lcTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapModeCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowItemSkinningCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTransitionAnimationCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickCustomizationLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showAdornerLayerLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowItemSkinningLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highlightFocusedItemCheckEditLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPropertyGridLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapModeLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowExpandAnimationLCI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcItemCombo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup lcMainGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cbFiles;
        private DevExpress.XtraLayout.LayoutControl lcTitle;
        private DevExpress.XtraEditors.SimpleButton sbCustomize;
        private DevExpress.XtraEditors.CheckEdit highlightFocusedItemCheckEdit;
        private DevExpress.XtraEditors.CheckEdit allowItemSkinningCheckEdit;
        private System.ComponentModel.IContainer components = null;
        private XtraEditors.CheckEdit quickCustomizationCheckEdit;
        private XtraEditors.CheckEdit showAdornerLayerCheckEdit;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem quickCustomizationLCI;
        private LayoutControlItem showAdornerLayerLCI;
        private LayoutControlItem allowItemSkinningLCI;
        private LayoutControlItem highlightFocusedItemCheckEditLCI;
        private LayoutControlItem lcCustomizeButton;
        private LayoutControlItem lcItemCombo;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.PanelControl panelControl1;
        private EmptySpaceItem emptySpaceItem1;
        private XtraEditors.CheckEdit allowExpandAnimationCheckEdit;
        private LayoutControlItem allowExpandAnimationLCI;
        private XtraEditors.CheckEdit showPropertyGridCheckEdit;
        private LayoutControlItem showPropertyGridLCI;
        private XtraEditors.CheckEdit snapModeCheckEdit;
        private LayoutControlItem snapModeLCI;
        private XtraEditors.CheckEdit tabTransitionAnimationCheckEdit;
        private LayoutControlItem allowExpandAnimationLCI1;
    }
}
