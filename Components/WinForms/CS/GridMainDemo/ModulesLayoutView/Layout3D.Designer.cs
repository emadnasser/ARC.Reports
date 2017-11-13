using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
    public partial class Layout3D : TutorialControl {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout3D));
            this.bottomCardFading = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cardsCount = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.flatFactor = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.endAlpha = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.rollAngle = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.endSizeScale = new DevExpress.XtraEditors.ZoomTrackBarControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colCaption = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutViewField_colCaption = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colYear = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colYear = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPlotoutLine = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_colPlotoutLine = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colRunTime = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colRunTime = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colColor = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colColor = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colPhoto = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewTemplateCard = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCardFading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCardFading.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatFactor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAlpha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSizeScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSizeScale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlotoutLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewTemplateCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomCardFading
            // 
            resources.ApplyResources(this.bottomCardFading, "bottomCardFading");
            this.bottomCardFading.Name = "bottomCardFading";
            this.bottomCardFading.Properties.Maximum = 100;
            this.bottomCardFading.Properties.Middle = 5;
            this.bottomCardFading.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.bottomCardFading.StyleController = this.layoutControl2;
            this.bottomCardFading.EditValueChanged += new System.EventHandler(this.zoomTrackBarControl1_EditValueChanged);
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.comboBoxEdit1);
            this.layoutControl2.Controls.Add(this.cardsCount);
            this.layoutControl2.Controls.Add(this.bottomCardFading);
            this.layoutControl2.Controls.Add(this.flatFactor);
            this.layoutControl2.Controls.Add(this.endAlpha);
            this.layoutControl2.Controls.Add(this.rollAngle);
            this.layoutControl2.Controls.Add(this.endSizeScale);
            resources.ApplyResources(this.layoutControl2, "layoutControl2");
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 450, 350);
            this.layoutControl2.Root = this.layoutControlGroup2;
            // 
            // comboBoxEdit1
            // 
            resources.ApplyResources(this.comboBoxEdit1, "comboBoxEdit1");
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("comboBoxEdit1.Properties.Buttons"))))});
            this.comboBoxEdit1.Properties.DropDownRows = 10;
            this.comboBoxEdit1.StyleController = this.layoutControl2;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // cardsCount
            // 
            resources.ApplyResources(this.cardsCount, "cardsCount");
            this.cardsCount.Name = "cardsCount";
            this.cardsCount.Properties.Maximum = 20;
            this.cardsCount.Properties.Middle = 5;
            this.cardsCount.Properties.Minimum = 5;
            this.cardsCount.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.cardsCount.StyleController = this.layoutControl2;
            this.cardsCount.Value = 15;
            this.cardsCount.EditValueChanged += new System.EventHandler(this.cardsCount_EditValueChanged);
            // 
            // flatFactor
            // 
            resources.ApplyResources(this.flatFactor, "flatFactor");
            this.flatFactor.Name = "flatFactor";
            this.flatFactor.Properties.Maximum = 360;
            this.flatFactor.Properties.Middle = 5;
            this.flatFactor.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.flatFactor.StyleController = this.layoutControl2;
            this.flatFactor.Value = 65;
            this.flatFactor.EditValueChanged += new System.EventHandler(this.flatFactor_EditValueChanged);
            // 
            // endAlpha
            // 
            resources.ApplyResources(this.endAlpha, "endAlpha");
            this.endAlpha.Name = "endAlpha";
            this.endAlpha.Properties.Maximum = 100;
            this.endAlpha.Properties.Middle = 5;
            this.endAlpha.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.endAlpha.StyleController = this.layoutControl2;
            this.endAlpha.EditValueChanged += new System.EventHandler(this.endAlpha_EditValueChanged);
            // 
            // rollAngle
            // 
            resources.ApplyResources(this.rollAngle, "rollAngle");
            this.rollAngle.Name = "rollAngle";
            this.rollAngle.Properties.Maximum = 360;
            this.rollAngle.Properties.Middle = 5;
            this.rollAngle.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.rollAngle.StyleController = this.layoutControl2;
            this.rollAngle.Value = 180;
            this.rollAngle.EditValueChanged += new System.EventHandler(this.rollAngle_EditValueChanged);
            // 
            // endSizeScale
            // 
            resources.ApplyResources(this.endSizeScale, "endSizeScale");
            this.endSizeScale.Name = "endSizeScale";
            this.endSizeScale.Properties.Maximum = 100;
            this.endSizeScale.Properties.Middle = 5;
            this.endSizeScale.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.endSizeScale.StyleController = this.layoutControl2;
            this.endSizeScale.Value = 20;
            this.endSizeScale.EditValueChanged += new System.EventHandler(this.endSizeScale_EditValueChanged);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(211, 445);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.flatFactor;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rollAngle;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.endSizeScale;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.endAlpha;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.bottomCardFading;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cardsCount;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(191, 38);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(118, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.comboBoxEdit1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 238);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(191, 40);
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(118, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 278);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(191, 147);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 228);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(191, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemMemoEdit2});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.CardCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutView1.Appearance.CardCaption.Font")));
            this.layoutView1.Appearance.CardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.CardCaption.Options.UseTextOptions = true;
            this.layoutView1.Appearance.CardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutView1.Appearance.CardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.layoutView1.Appearance.FocusedCardCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutView1.Appearance.FocusedCardCaption.Font")));
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseTextOptions = true;
            this.layoutView1.Appearance.FocusedCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutView1.Appearance.FocusedCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.layoutView1.Appearance.HideSelectionCardCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutView1.Appearance.HideSelectionCardCaption.Font")));
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseTextOptions = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutView1.Appearance.HideSelectionCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.layoutView1.Appearance.SelectedCardCaption.Font = ((System.Drawing.Font)(resources.GetObject("layoutView1.Appearance.SelectedCardCaption.Font")));
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseTextOptions = true;
            this.layoutView1.Appearance.SelectedCardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutView1.Appearance.SelectedCardCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            resources.ApplyResources(this.layoutView1, "layoutView1");
            this.layoutView1.CardMinSize = new System.Drawing.Size(344, 224);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colCaption,
            this.colYear,
            this.colPlotoutLine,
            this.colRunTime,
            this.colColor,
            this.colPhoto});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colCaption});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsCarouselMode.PitchAngle = 1.13F;
            this.layoutView1.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize;
            this.layoutView1.OptionsView.AllowHotTrackFields = false;
            this.layoutView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ShowCardLines = false;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewTemplateCard;
            // 
            // colCaption
            // 
            resources.ApplyResources(this.colCaption, "colCaption");
            this.colCaption.ColumnEdit = this.repositoryItemTextEdit1;
            this.colCaption.FieldName = "Title";
            this.colCaption.LayoutViewField = this.layoutViewField_colCaption;
            this.colCaption.Name = "colCaption";
            this.colCaption.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCaption.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // layoutViewField_colCaption
            // 
            this.layoutViewField_colCaption.EditorPreferredWidth = 25;
            this.layoutViewField_colCaption.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCaption.Name = "layoutViewField_colCaption";
            this.layoutViewField_colCaption.Size = new System.Drawing.Size(368, 110);
            this.layoutViewField_colCaption.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colCaption.TextVisible = false;
            // 
            // colYear
            // 
            resources.ApplyResources(this.colYear, "colYear");
            this.colYear.FieldName = "ReleaseDate";
            this.colYear.LayoutViewField = this.layoutViewField_colYear;
            this.colYear.Name = "colYear";
            this.colYear.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colYear.OptionsFilter.AllowFilter = false;
            // 
            // layoutViewField_colYear
            // 
            this.layoutViewField_colYear.EditorPreferredWidth = 166;
            this.layoutViewField_colYear.Location = new System.Drawing.Point(130, 0);
            this.layoutViewField_colYear.Name = "layoutViewField_colYear";
            this.layoutViewField_colYear.Size = new System.Drawing.Size(208, 27);
            this.layoutViewField_colYear.TextSize = new System.Drawing.Size(26, 13);
            // 
            // colPlotoutLine
            // 
            resources.ApplyResources(this.colPlotoutLine, "colPlotoutLine");
            this.colPlotoutLine.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colPlotoutLine.FieldName = "Plot";
            this.colPlotoutLine.LayoutViewField = this.layoutViewField_colPlotoutLine;
            this.colPlotoutLine.Name = "colPlotoutLine";
            this.colPlotoutLine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPlotoutLine.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // layoutViewField_colPlotoutLine
            // 
            this.layoutViewField_colPlotoutLine.EditorPreferredWidth = 197;
            this.layoutViewField_colPlotoutLine.Location = new System.Drawing.Point(130, 54);
            this.layoutViewField_colPlotoutLine.Name = "layoutViewField_colPlotoutLine";
            this.layoutViewField_colPlotoutLine.Size = new System.Drawing.Size(208, 29);
            this.layoutViewField_colPlotoutLine.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPlotoutLine.TextVisible = false;
            // 
            // colRunTime
            // 
            resources.ApplyResources(this.colRunTime, "colRunTime");
            this.colRunTime.FieldName = "RunTime";
            this.colRunTime.LayoutViewField = this.layoutViewField_colRunTime;
            this.colRunTime.Name = "colRunTime";
            this.colRunTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRunTime.OptionsFilter.AllowFilter = false;
            // 
            // layoutViewField_colRunTime
            // 
            this.layoutViewField_colRunTime.EditorPreferredWidth = 64;
            this.layoutViewField_colRunTime.Location = new System.Drawing.Point(130, 27);
            this.layoutViewField_colRunTime.Name = "layoutViewField_colRunTime";
            this.layoutViewField_colRunTime.Size = new System.Drawing.Size(125, 27);
            this.layoutViewField_colRunTime.TextSize = new System.Drawing.Size(43, 13);
            // 
            // colColor
            // 
            resources.ApplyResources(this.colColor, "colColor");
            this.colColor.FieldName = "IsColor";
            this.colColor.LayoutViewField = this.layoutViewField_colColor;
            this.colColor.Name = "colColor";
            this.colColor.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colColor.OptionsFilter.AllowFilter = false;
            // 
            // layoutViewField_colColor
            // 
            this.layoutViewField_colColor.EditorPreferredWidth = 38;
            this.layoutViewField_colColor.Location = new System.Drawing.Point(255, 27);
            this.layoutViewField_colColor.Name = "layoutViewField_colColor";
            this.layoutViewField_colColor.Size = new System.Drawing.Size(83, 27);
            this.layoutViewField_colColor.TextSize = new System.Drawing.Size(29, 13);
            // 
            // colPhoto
            // 
            resources.ApplyResources(this.colPhoto, "colPhoto");
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // layoutViewField_colPhoto
            // 
            this.layoutViewField_colPhoto.EditorPreferredWidth = 119;
            this.layoutViewField_colPhoto.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto";
            this.layoutViewField_colPhoto.Size = new System.Drawing.Size(130, 83);
            this.layoutViewField_colPhoto.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colPhoto.TextVisible = false;
            // 
            // layoutViewTemplateCard
            // 
            resources.ApplyResources(this.layoutViewTemplateCard, "layoutViewTemplateCard");
            this.layoutViewTemplateCard.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewTemplateCard.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colPhoto,
            this.layoutViewField_colPlotoutLine,
            this.layoutViewField_colRunTime,
            this.layoutViewField_colColor,
            this.layoutViewField_colYear});
            this.layoutViewTemplateCard.Name = "layoutViewTemplateCard";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            resources.ApplyResources(this.repositoryItemHyperLinkEdit1, "repositoryItemHyperLinkEdit1");
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            resources.ApplyResources(this.navigationPane1, "navigationPane1");
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(261, 505);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 0;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl2);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.ImageUri.Uri = "New";
            this.navigationPage1.Name = "navigationPage1";
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // Layout3D
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "Layout3D";
            this.Load += new System.EventHandler(this.Layout3D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomCardFading.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCardFading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatFactor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAlpha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSizeScale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSizeScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPlotoutLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewTemplateCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCaption;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCaption;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colYear;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPlotoutLine;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colRunTime;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colColor;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;

        #endregion

        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewTemplateCard;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colYear;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPlotoutLine;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRunTime;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colColor;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhoto;
        private DevExpress.XtraEditors.ZoomTrackBarControl endAlpha;
        private DevExpress.XtraEditors.ZoomTrackBarControl endSizeScale;
        private DevExpress.XtraEditors.ZoomTrackBarControl rollAngle;
        private DevExpress.XtraEditors.ZoomTrackBarControl flatFactor;
        private DevExpress.XtraEditors.ZoomTrackBarControl cardsCount;
        private DevExpress.XtraEditors.ZoomTrackBarControl bottomCardFading;
        private DevExpress.XtraEditors.ImageComboBoxEdit comboBoxEdit1;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraEditors.PanelControl panelControl1;


    }
}
