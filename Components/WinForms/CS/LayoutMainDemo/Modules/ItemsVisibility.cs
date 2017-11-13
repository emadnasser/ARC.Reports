using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout.Utils;
using DevExpress.Utils;

namespace DevExpress.XtraLayout.Demos {
    public partial class ItemsVisibility : TutorialControl {
        private LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit showDesc;
        private DevExpress.XtraEditors.CheckEdit showP1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.CheckEdit showP2;
        private SplitterItem splitterItem2;
        private LayoutControlItem descriptionItem;
        private LayoutControlItem picture2Item;
        private SplitterItem splitterItem1;
        private LayoutControlItem picture1Item;
        private LayoutControl lcTitle;
        private LayoutControlGroup lcMainGroup;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private LayoutControlItem layoutControlItem3;
        private LayoutControlItem layoutControlItem4;
        private XtraEditors.PanelControl panelControl1;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.CheckEdit ceVerticalIsCollapsible;
        private XtraEditors.CheckEdit ceVerticalIsCollapsed;
        private XtraEditors.CheckEdit ceVerticalInverted;
        private LayoutControlGroup layoutControlGroupSplitterItem1;
        private LayoutControlItem layoutControlItem5;
        private LayoutControlItem layoutControlItem6;
        private LayoutControlItem layoutControlItem7;
        private XtraEditors.CheckEdit ceHorizontalInverted;
        private XtraEditors.CheckEdit ceHorizontalIsCollapsed;
        private XtraEditors.CheckEdit ceHorizontalIsCollapsible;
        private LayoutControlGroup layoutControlGroupSplitterItem2;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlItem layoutControlItem9;
        private LayoutControlItem layoutControlItem10;
        private SimpleLabelItem simpleLabelItem1;
        private SimpleLabelItem simpleLabelItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public ItemsVisibility() {
            InitializeComponent();
            UpdateSplitterOptions();
        }

        void UpdateSplitterOptions() {
            ceVerticalInverted.Checked = splitterItem1.Inverted;
            ceVerticalIsCollapsed.Checked = splitterItem1.IsCollapsed;
            ceVerticalIsCollapsible.Checked = splitterItem1.IsCollapsible == DefaultBoolean.True;
            ceHorizontalInverted.Checked = splitterItem2.Inverted;
            ceHorizontalIsCollapsed.Checked = splitterItem2.IsCollapsed;
            ceHorizontalIsCollapsible.Checked = splitterItem2.IsCollapsible == DefaultBoolean.True;
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsVisibility));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.descriptionItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.picture2Item = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.picture1Item = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcTitle = new DevExpress.XtraLayout.LayoutControl();
            this.ceVerticalIsCollapsible = new DevExpress.XtraEditors.CheckEdit();
            this.ceVerticalIsCollapsed = new DevExpress.XtraEditors.CheckEdit();
            this.ceVerticalInverted = new DevExpress.XtraEditors.CheckEdit();
            this.showDesc = new DevExpress.XtraEditors.CheckEdit();
            this.showP2 = new DevExpress.XtraEditors.CheckEdit();
            this.showP1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ceHorizontalInverted = new DevExpress.XtraEditors.CheckEdit();
            this.ceHorizontalIsCollapsed = new DevExpress.XtraEditors.CheckEdit();
            this.ceHorizontalIsCollapsible = new DevExpress.XtraEditors.CheckEdit();
            this.lcMainGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupSplitterItem1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlGroupSplitterItem2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).BeginInit();
            this.lcTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalIsCollapsible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalIsCollapsed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalInverted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showP2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showP1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalInverted.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalIsCollapsed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalIsCollapsible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSplitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSplitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pictureEdit2);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.memoEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(522, 505);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            this.layoutControl1.Changed += new System.EventHandler(this.layoutControl1_Changed);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::DevExpress.XtraLayout.Demos.Properties.Resources.bc11;
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(244, 275);
            this.pictureEdit2.StyleController = this.layoutControl1;
            this.pictureEdit2.TabIndex = 6;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::DevExpress.XtraLayout.Demos.Properties.Resources.bc12;
            this.pictureEdit1.Location = new System.Drawing.Point(265, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(245, 275);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 5;
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(12, 312);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(498, 181);
            this.memoEdit1.StyleController = this.layoutControl1;
            this.memoEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem2,
            this.descriptionItem,
            this.picture2Item,
            this.splitterItem1,
            this.picture1Item});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(522, 505);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Inverted = false;
            this.splitterItem2.IsCollapsible = DevExpress.Utils.DefaultBoolean.True;
            this.splitterItem2.Location = new System.Drawing.Point(0, 279);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(502, 5);
            // 
            // descriptionItem
            // 
            this.descriptionItem.Control = this.memoEdit1;
            this.descriptionItem.CustomizationFormText = "layoutControlItem1";
            this.descriptionItem.Location = new System.Drawing.Point(0, 284);
            this.descriptionItem.Name = "descriptionItem";
            this.descriptionItem.Size = new System.Drawing.Size(502, 201);
            this.descriptionItem.Text = "Description";
            this.descriptionItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.descriptionItem.TextSize = new System.Drawing.Size(53, 13);
            // 
            // picture2Item
            // 
            this.picture2Item.Control = this.pictureEdit1;
            this.picture2Item.CustomizationFormText = "layoutControlItem2";
            this.picture2Item.Location = new System.Drawing.Point(253, 0);
            this.picture2Item.Name = "picture2Item";
            this.picture2Item.Size = new System.Drawing.Size(249, 279);
            this.picture2Item.TextLocation = DevExpress.Utils.Locations.Left;
            this.picture2Item.TextSize = new System.Drawing.Size(0, 0);
            this.picture2Item.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Inverted = false;
            this.splitterItem1.IsCollapsible = DevExpress.Utils.DefaultBoolean.True;
            this.splitterItem1.Location = new System.Drawing.Point(248, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 279);
            // 
            // picture1Item
            // 
            this.picture1Item.Control = this.pictureEdit2;
            this.picture1Item.CustomizationFormText = "layoutControlItem3";
            this.picture1Item.Location = new System.Drawing.Point(0, 0);
            this.picture1Item.Name = "picture1Item";
            this.picture1Item.Size = new System.Drawing.Size(248, 279);
            this.picture1Item.TextLocation = DevExpress.Utils.Locations.Left;
            this.picture1Item.TextSize = new System.Drawing.Size(0, 0);
            this.picture1Item.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(522, 0);
            this.panelControl1.MaximumSize = new System.Drawing.Size(10, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(10, 505);
            this.panelControl1.TabIndex = 5;
            // 
            // navigationPane1
            // 
            this.navigationPane1.AllowResize = false;
            this.navigationPane1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(532, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(236, 505);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(236, 505);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.lcTitle);
            this.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(186, 445);
            // 
            // lcTitle
            // 
            this.lcTitle.AllowCustomization = false;
            this.lcTitle.Controls.Add(this.ceVerticalIsCollapsible);
            this.lcTitle.Controls.Add(this.ceVerticalIsCollapsed);
            this.lcTitle.Controls.Add(this.ceVerticalInverted);
            this.lcTitle.Controls.Add(this.showDesc);
            this.lcTitle.Controls.Add(this.showP2);
            this.lcTitle.Controls.Add(this.showP1);
            this.lcTitle.Controls.Add(this.simpleButton1);
            this.lcTitle.Controls.Add(this.ceHorizontalInverted);
            this.lcTitle.Controls.Add(this.ceHorizontalIsCollapsed);
            this.lcTitle.Controls.Add(this.ceHorizontalIsCollapsible);
            this.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTitle.Location = new System.Drawing.Point(0, 0);
            this.lcTitle.Name = "lcTitle";
            this.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-779, 277, 715, 579);
            this.lcTitle.OptionsView.AllowExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.lcTitle.OptionsView.AllowItemSkinning = false;
            this.lcTitle.OptionsView.UseParentAutoScaleFactor = true;
            this.lcTitle.OptionsView.UseSkinIndents = false;
            this.lcTitle.Root = this.lcMainGroup;
            this.lcTitle.Size = new System.Drawing.Size(186, 445);
            this.lcTitle.TabIndex = 1;
            // 
            // ceVerticalIsCollapsible
            // 
            this.ceVerticalIsCollapsible.Location = new System.Drawing.Point(4, 172);
            this.ceVerticalIsCollapsible.Name = "ceVerticalIsCollapsible";
            this.ceVerticalIsCollapsible.Properties.Caption = "IsCollapsible";
            this.ceVerticalIsCollapsible.Size = new System.Drawing.Size(178, 19);
            this.ceVerticalIsCollapsible.StyleController = this.lcTitle;
            this.ceVerticalIsCollapsible.TabIndex = 13;
            this.ceVerticalIsCollapsible.CheckedChanged += new System.EventHandler(this.ceVerticalIsCollapsible_CheckedChanged);
            // 
            // ceVerticalIsCollapsed
            // 
            this.ceVerticalIsCollapsed.Location = new System.Drawing.Point(4, 145);
            this.ceVerticalIsCollapsed.Name = "ceVerticalIsCollapsed";
            this.ceVerticalIsCollapsed.Properties.Caption = "IsCollapsed";
            this.ceVerticalIsCollapsed.Size = new System.Drawing.Size(178, 19);
            this.ceVerticalIsCollapsed.StyleController = this.lcTitle;
            this.ceVerticalIsCollapsed.TabIndex = 12;
            this.ceVerticalIsCollapsed.CheckedChanged += new System.EventHandler(this.ceVerticalIsCollapsed_CheckedChanged);
            // 
            // ceVerticalInverted
            // 
            this.ceVerticalInverted.Location = new System.Drawing.Point(4, 118);
            this.ceVerticalInverted.Name = "ceVerticalInverted";
            this.ceVerticalInverted.Properties.Caption = "Inverted";
            this.ceVerticalInverted.Size = new System.Drawing.Size(178, 19);
            this.ceVerticalInverted.StyleController = this.lcTitle;
            this.ceVerticalInverted.TabIndex = 11;
            this.ceVerticalInverted.CheckedChanged += new System.EventHandler(this.ceVerticalInverted_CheckedChanged);
            // 
            // showDesc
            // 
            this.showDesc.AutoSizeInLayoutControl = true;
            this.showDesc.EditValue = true;
            this.showDesc.Location = new System.Drawing.Point(4, 4);
            this.showDesc.Name = "showDesc";
            this.showDesc.Properties.Caption = "Show Description";
            this.showDesc.Size = new System.Drawing.Size(104, 19);
            this.showDesc.StyleController = this.lcTitle;
            this.showDesc.TabIndex = 8;
            this.showDesc.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // showP2
            // 
            this.showP2.AutoSizeInLayoutControl = true;
            this.showP2.EditValue = true;
            this.showP2.Location = new System.Drawing.Point(4, 58);
            this.showP2.Name = "showP2";
            this.showP2.Properties.Caption = "Show Picture2";
            this.showP2.Size = new System.Drawing.Size(90, 19);
            this.showP2.StyleController = this.lcTitle;
            this.showP2.TabIndex = 9;
            this.showP2.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // showP1
            // 
            this.showP1.AutoSizeInLayoutControl = true;
            this.showP1.EditValue = true;
            this.showP1.Location = new System.Drawing.Point(4, 31);
            this.showP1.Name = "showP1";
            this.showP1.Properties.Caption = "Show Picture1";
            this.showP1.Size = new System.Drawing.Size(90, 19);
            this.showP1.StyleController = this.lcTitle;
            this.showP1.TabIndex = 7;
            this.showP1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(4, 325);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(178, 22);
            this.simpleButton1.StyleController = this.lcTitle;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Rotate Layout 90 Degrees";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ceHorizontalInverted
            // 
            this.ceHorizontalInverted.Location = new System.Drawing.Point(4, 232);
            this.ceHorizontalInverted.Name = "ceHorizontalInverted";
            this.ceHorizontalInverted.Properties.Caption = "Inverted";
            this.ceHorizontalInverted.Size = new System.Drawing.Size(178, 19);
            this.ceHorizontalInverted.StyleController = this.lcTitle;
            this.ceHorizontalInverted.TabIndex = 11;
            this.ceHorizontalInverted.CheckedChanged += new System.EventHandler(this.ceHorizontalInverted_CheckedChanged);
            // 
            // ceHorizontalIsCollapsed
            // 
            this.ceHorizontalIsCollapsed.Location = new System.Drawing.Point(4, 259);
            this.ceHorizontalIsCollapsed.Name = "ceHorizontalIsCollapsed";
            this.ceHorizontalIsCollapsed.Properties.Caption = "IsCollapsed";
            this.ceHorizontalIsCollapsed.Size = new System.Drawing.Size(178, 19);
            this.ceHorizontalIsCollapsed.StyleController = this.lcTitle;
            this.ceHorizontalIsCollapsed.TabIndex = 12;
            this.ceHorizontalIsCollapsed.CheckedChanged += new System.EventHandler(this.ceHorizontalIsCollapsed_CheckedChanged);
            // 
            // ceHorizontalIsCollapsible
            // 
            this.ceHorizontalIsCollapsible.Location = new System.Drawing.Point(4, 286);
            this.ceHorizontalIsCollapsible.Name = "ceHorizontalIsCollapsible";
            this.ceHorizontalIsCollapsible.Properties.Caption = "IsCollapsible";
            this.ceHorizontalIsCollapsible.Size = new System.Drawing.Size(178, 19);
            this.ceHorizontalIsCollapsible.StyleController = this.lcTitle;
            this.ceHorizontalIsCollapsible.TabIndex = 13;
            this.ceHorizontalIsCollapsible.CheckedChanged += new System.EventHandler(this.ceHorizontalIsCollapsible_CheckedChanged);
            // 
            // lcMainGroup
            // 
            this.lcMainGroup.CustomizationFormText = "Root";
            this.lcMainGroup.GroupBordersVisible = false;
            this.lcMainGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlGroupSplitterItem1,
            this.layoutControlGroupSplitterItem2});
            this.lcMainGroup.Location = new System.Drawing.Point(0, 0);
            this.lcMainGroup.Name = "Root";
            this.lcMainGroup.OptionsItemText.TextToControlDistance = 5;
            this.lcMainGroup.Size = new System.Drawing.Size(186, 445);
            this.lcMainGroup.Text = "Select xml file and restore layout";
            this.lcMainGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 309);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 16, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(186, 136);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.showP2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.showP1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.showDesc;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem4.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroupSplitterItem1
            // 
            this.layoutControlGroupSplitterItem1.ExpandButtonVisible = true;
            this.layoutControlGroupSplitterItem1.GroupBordersVisible = false;
            this.layoutControlGroupSplitterItem1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.simpleLabelItem1});
            this.layoutControlGroupSplitterItem1.Location = new System.Drawing.Point(0, 81);
            this.layoutControlGroupSplitterItem1.Name = "layoutControlGroup2";
            this.layoutControlGroupSplitterItem1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroupSplitterItem1.Size = new System.Drawing.Size(186, 114);
            this.layoutControlGroupSplitterItem1.Text = "Vertical SplitterItem";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceVerticalInverted;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem5.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ceVerticalIsCollapsed;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem6.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.ceVerticalIsCollapsible;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem7.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(134)))));
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseBackColor = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 16, 4);
            this.simpleLabelItem1.Size = new System.Drawing.Size(186, 33);
            this.simpleLabelItem1.Text = "Vertical SplitterItem";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlGroupSplitterItem2
            // 
            this.layoutControlGroupSplitterItem2.ExpandButtonVisible = true;
            this.layoutControlGroupSplitterItem2.GroupBordersVisible = false;
            this.layoutControlGroupSplitterItem2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.simpleLabelItem2});
            this.layoutControlGroupSplitterItem2.Location = new System.Drawing.Point(0, 195);
            this.layoutControlGroupSplitterItem2.Name = "layoutControlGroup4";
            this.layoutControlGroupSplitterItem2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroupSplitterItem2.Size = new System.Drawing.Size(186, 114);
            this.layoutControlGroupSplitterItem2.Text = "Horizontal SplitterItem";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ceHorizontalInverted;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem8.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem8.Text = "layoutControlItem5";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.ceHorizontalIsCollapsed;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem9.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem9.Text = "layoutControlItem6";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.ceHorizontalIsCollapsible;
            this.layoutControlItem10.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem10.Size = new System.Drawing.Size(186, 27);
            this.layoutControlItem10.Text = "layoutControlItem7";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(127)))), ((int)(((byte)(221)))), ((int)(((byte)(134)))));
            this.simpleLabelItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseBackColor = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem2.Name = "simpleLabelItem2";
            this.simpleLabelItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 16, 4);
            this.simpleLabelItem2.Size = new System.Drawing.Size(186, 33);
            this.simpleLabelItem2.Text = "Horizontal SplitterItem";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(131, 13);
            // 
            // ItemsVisibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "ItemsVisibility";
            this.Size = new System.Drawing.Size(768, 505);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).EndInit();
            this.lcTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalIsCollapsible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalIsCollapsed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceVerticalInverted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showP2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showP1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalInverted.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalIsCollapsed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceHorizontalIsCollapsible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMainGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSplitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSplitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            this.ResumeLayout(false);

        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e) {
            UpdateVisibility();
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            UpdateVisibility();
        }
        private void checkEdit3_CheckedChanged(object sender, EventArgs e) {
            UpdateVisibility();
        }
        protected void UpdateVisibility() {
            UpdateVisibility(showDesc.Checked, showP1.Checked, showP2.Checked);
        }
        protected void SetVisibility(LayoutVisibility picture1ItemVisibility, LayoutVisibility picture2ItemVisibility, LayoutVisibility descriptionItemVisibility) {
            picture1Item.Visibility = picture1ItemVisibility;
            picture2Item.Visibility = picture2ItemVisibility;
            descriptionItem.Visibility = descriptionItemVisibility;
            if(picture1ItemVisibility == LayoutVisibility.Always && picture2ItemVisibility == LayoutVisibility.Always)
                splitterItem1.Visibility = LayoutVisibility.Always;
            else
                splitterItem1.Visibility = LayoutVisibility.Never;
            if((picture1ItemVisibility == LayoutVisibility.Always || picture2ItemVisibility == LayoutVisibility.Always) && descriptionItemVisibility == LayoutVisibility.Always)
                splitterItem2.Visibility = LayoutVisibility.Always;
            else
                splitterItem2.Visibility = LayoutVisibility.Never;
        }
        protected void UpdateVisibility(bool showDescription, bool showPicure1, bool showPicture2) {
            SetVisibility(
                LayoutVisibilityConvertor.FromBoolean(showPicure1),
                LayoutVisibilityConvertor.FromBoolean(showPicture2),
                LayoutVisibilityConvertor.FromBoolean(showDescription));
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            layoutControl1.Root.RotateLayout();
            simpleLabelItem1.Text = splitterItem1.IsHorizontal ? "Horizontal SplitterItem" : "Vertical SplitterItem";
            simpleLabelItem2.Text = splitterItem2.IsHorizontal ? "Horizontal SplitterItem" : "Vertical SplitterItem";
        }

        private void ceVerticalInverted_CheckedChanged(object sender, EventArgs e) {
            splitterItem1.Inverted = ceVerticalInverted.Checked;
        }
        private void ceVerticalIsCollapsed_CheckedChanged(object sender, EventArgs e) {
            splitterItem1.IsCollapsed = ceVerticalIsCollapsed.Checked;
        }
        private void ceVerticalIsCollapsible_CheckedChanged(object sender, EventArgs e) {
            splitterItem1.IsCollapsible = ceVerticalIsCollapsible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
       }
        private void ceHorizontalInverted_CheckedChanged(object sender, EventArgs e) {
            splitterItem2.Inverted = ceHorizontalInverted.Checked;
        }
        private void ceHorizontalIsCollapsed_CheckedChanged(object sender, EventArgs e) {
            splitterItem2.IsCollapsed = ceHorizontalIsCollapsed.Checked;

        }
        private void ceHorizontalIsCollapsible_CheckedChanged(object sender, EventArgs e) {
            splitterItem2.IsCollapsible = ceHorizontalIsCollapsible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }

        private void layoutControl1_Changed(object sender, EventArgs e) {
            UpdateSplitterOptions();
        }
    }
}
