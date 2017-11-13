namespace DevExpress.XtraGrid.Demos {
    partial class RowHeight {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RowHeight));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colFirstName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitleOfCourtesy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.colBirthDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomePhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colPhoto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbSwitching = new DevExpress.XtraEditors.SimpleButton();
            this.chePicture = new DevExpress.XtraEditors.CheckEdit();
            this.cheMemo = new DevExpress.XtraEditors.CheckEdit();
            this.cheAutoHeight = new DevExpress.XtraEditors.CheckEdit();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoHeight.Properties)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            resources.ApplyResources(this.cardView1, "cardView1");
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName1,
            this.colLastName1,
            this.colTitle1,
            this.colTitleOfCourtesy1,
            this.colBirthDate1,
            this.colHireDate1,
            this.colHomePhone1,
            this.colNotes1,
            this.colPhoto1});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.MaximumCardColumns = 2;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.AutoHorzWidth = true;
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsView.ShowLines = false;
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colFirstName1
            // 
            resources.ApplyResources(this.colFirstName1, "colFirstName1");
            this.colFirstName1.FieldName = "FirstName";
            this.colFirstName1.Name = "colFirstName1";
            // 
            // colLastName1
            // 
            resources.ApplyResources(this.colLastName1, "colLastName1");
            this.colLastName1.FieldName = "LastName";
            this.colLastName1.Name = "colLastName1";
            // 
            // colTitle1
            // 
            resources.ApplyResources(this.colTitle1, "colTitle1");
            this.colTitle1.FieldName = "Title";
            this.colTitle1.Name = "colTitle1";
            // 
            // colTitleOfCourtesy1
            // 
            resources.ApplyResources(this.colTitleOfCourtesy1, "colTitleOfCourtesy1");
            this.colTitleOfCourtesy1.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colTitleOfCourtesy1.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy1.Name = "colTitleOfCourtesy1";
            this.colTitleOfCourtesy1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox1.Buttons"))))});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), resources.GetString("repositoryItemImageComboBox1.Items1"), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), resources.GetString("repositoryItemImageComboBox1.Items4"), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), resources.GetString("repositoryItemImageComboBox1.Items7"), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), resources.GetString("repositoryItemImageComboBox1.Items10"), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), resources.GetString("repositoryItemImageComboBox1.Items13"), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items14"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Doctor.png");
            this.imageCollection1.Images.SetKeyName(1, "Miss.png");
            this.imageCollection1.Images.SetKeyName(2, "Mr.png");
            this.imageCollection1.Images.SetKeyName(3, "Mrs.png");
            this.imageCollection1.Images.SetKeyName(4, "Ms.png");
            // 
            // colBirthDate1
            // 
            resources.ApplyResources(this.colBirthDate1, "colBirthDate1");
            this.colBirthDate1.FieldName = "BirthDate";
            this.colBirthDate1.Name = "colBirthDate1";
            // 
            // colHireDate1
            // 
            resources.ApplyResources(this.colHireDate1, "colHireDate1");
            this.colHireDate1.FieldName = "HireDate";
            this.colHireDate1.Name = "colHireDate1";
            // 
            // colHomePhone1
            // 
            resources.ApplyResources(this.colHomePhone1, "colHomePhone1");
            this.colHomePhone1.FieldName = "HomePhone";
            this.colHomePhone1.Name = "colHomePhone1";
            // 
            // colNotes1
            // 
            this.colNotes1.AppearanceCell.Options.UseTextOptions = true;
            this.colNotes1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            resources.ApplyResources(this.colNotes1, "colNotes1");
            this.colNotes1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNotes1.FieldName = "Notes";
            this.colNotes1.Name = "colNotes1";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colPhoto1
            // 
            resources.ApplyResources(this.colPhoto1, "colPhoto1");
            this.colPhoto1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto1.FieldName = "Photo";
            this.colPhoto1.Name = "colPhoto1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 40;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "Card";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageComboBox1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBirthDate,
            this.colFirstName,
            this.colHireDate,
            this.colHomePhone,
            this.colLastName,
            this.colNotes,
            this.colPhoto,
            this.colTitle,
            this.colTitleOfCourtesy});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBirthDate
            // 
            resources.ApplyResources(this.colBirthDate, "colBirthDate");
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            // 
            // colFirstName
            // 
            resources.ApplyResources(this.colFirstName, "colFirstName");
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            // 
            // colHireDate
            // 
            resources.ApplyResources(this.colHireDate, "colHireDate");
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            // 
            // colHomePhone
            // 
            resources.ApplyResources(this.colHomePhone, "colHomePhone");
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            // 
            // colLastName
            // 
            resources.ApplyResources(this.colLastName, "colLastName");
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            // 
            // colNotes
            // 
            this.colNotes.AppearanceCell.Options.UseTextOptions = true;
            this.colNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            resources.ApplyResources(this.colNotes, "colNotes");
            this.colNotes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsFilter.AllowFilter = false;
            // 
            // colPhoto
            // 
            resources.ApplyResources(this.colPhoto, "colPhoto");
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.FixedWidth = true;
            this.colPhoto.OptionsFilter.AllowFilter = false;
            // 
            // colTitle
            // 
            resources.ApplyResources(this.colTitle, "colTitle");
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            // 
            // colTitleOfCourtesy
            // 
            resources.ApplyResources(this.colTitleOfCourtesy, "colTitleOfCourtesy");
            this.colTitleOfCourtesy.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            this.colTitleOfCourtesy.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // sbSwitching
            // 
            resources.ApplyResources(this.sbSwitching, "sbSwitching");
            this.sbSwitching.Name = "sbSwitching";
            this.sbSwitching.StyleController = this.layoutControl1;
            this.sbSwitching.Click += new System.EventHandler(this.sbSwitching_Click);
            // 
            // chePicture
            // 
            resources.ApplyResources(this.chePicture, "chePicture");
            this.chePicture.Name = "chePicture";
            this.chePicture.Properties.Caption = resources.GetString("chePicture.Properties.Caption");
            this.chePicture.StyleController = this.layoutControl1;
            this.chePicture.CheckedChanged += new System.EventHandler(this.chbPicture_CheckedChanged);
            // 
            // cheMemo
            // 
            resources.ApplyResources(this.cheMemo, "cheMemo");
            this.cheMemo.Name = "cheMemo";
            this.cheMemo.Properties.Caption = resources.GetString("cheMemo.Properties.Caption");
            this.cheMemo.StyleController = this.layoutControl1;
            this.cheMemo.CheckedChanged += new System.EventHandler(this.chbMemo_CheckedChanged);
            // 
            // cheAutoHeight
            // 
            resources.ApplyResources(this.cheAutoHeight, "cheAutoHeight");
            this.cheAutoHeight.Name = "cheAutoHeight";
            this.cheAutoHeight.Properties.Caption = resources.GetString("cheAutoHeight.Properties.Caption");
            this.cheAutoHeight.StyleController = this.layoutControl1;
            this.cheAutoHeight.CheckedChanged += new System.EventHandler(this.chbAutoHeight_CheckedChanged);
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(250, 481);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 0;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Options";
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.Image")));
            this.navigationPage1.ImageUri.Uri = "New";
            this.navigationPage1.Name = "navigationPage1";
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.sbSwitching);
            this.layoutControl1.Controls.Add(this.cheAutoHeight);
            this.layoutControl1.Controls.Add(this.chePicture);
            this.layoutControl1.Controls.Add(this.cheMemo);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1032, 180, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(200, 421);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cheAutoHeight;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(180, 23);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cheMemo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(180, 23);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chePicture;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(180, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 81);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(180, 294);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 23);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(180, 12);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbSwitching;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 375);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(180, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // RowHeight
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "RowHeight";
            this.Load += new System.EventHandler(this.RowHeight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAutoHeight.Properties)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colHireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHomePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colTitleOfCourtesy;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName1;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitleOfCourtesy1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colHireDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colHomePhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto1;
        private DevExpress.XtraEditors.CheckEdit cheAutoHeight;
        private DevExpress.XtraEditors.CheckEdit cheMemo;
        private DevExpress.XtraEditors.CheckEdit chePicture;
        private DevExpress.XtraEditors.SimpleButton sbSwitching;
        private System.ComponentModel.IContainer components;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private XtraBars.Navigation.NavigationPane navigationPane1;
        private XtraBars.Navigation.NavigationPage navigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraEditors.PanelControl panelControl1;
    }
}
