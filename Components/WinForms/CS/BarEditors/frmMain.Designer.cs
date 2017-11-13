namespace DevExpress.XtraBars.Demos.BarEditors {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lastOrder = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.iClearFilter = new DevExpress.XtraBars.BarButtonItem();
            this.iRecords = new DevExpress.XtraBars.BarStaticItem();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mFilter = new DevExpress.XtraBars.BarSubItem();
            this.discontinued = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.categories = new DevExpress.XtraBars.BarEditItem();
            this.repositoryImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.iFilter = new DevExpress.XtraBars.BarStaticItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.iPaintStyle = new DevExpress.XtraBars.BarSubItem();
            this.ipsDefault = new DevExpress.XtraBars.BarButtonItem();
            this.ipsWXP = new DevExpress.XtraBars.BarButtonItem();
            this.ipsOXP = new DevExpress.XtraBars.BarButtonItem();
            this.ipsO2K = new DevExpress.XtraBars.BarButtonItem();
            this.ipsO3 = new DevExpress.XtraBars.BarButtonItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsOnOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastOrder
            // 
            this.lastOrder.Caption = "Last Order Date < ";
            this.lastOrder.CategoryGuid = new System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a");
            this.lastOrder.Edit = this.repositoryItemDateEdit1;
            this.lastOrder.EditValue = "";
            this.lastOrder.Id = 8;
            this.lastOrder.Name = "lastOrder";
            this.lastOrder.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.lastOrder.EditValueChanged += new System.EventHandler(this.lastOrder_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AllowFocused = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.repositoryItemDateEdit1.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(692, 55);
            this.barDockControl4.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 55);
            this.barDockControl3.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 296);
            this.barDockControl2.Size = new System.Drawing.Size(692, 25);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(692, 55);
            // 
            // iClearFilter
            // 
            this.iClearFilter.Caption = "Clear Filter";
            this.iClearFilter.CategoryGuid = new System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a");
            this.iClearFilter.Id = 9;
            this.iClearFilter.ImageIndex = 2;
            this.iClearFilter.Name = "iClearFilter";
            this.iClearFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iClearFilter_ItemClick);
            // 
            // iRecords
            // 
            this.iRecords.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.iRecords.Caption = "Records: ";
            this.iRecords.CategoryGuid = new System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888");
            this.iRecords.Id = 6;
            this.iRecords.Name = "iRecords";
            this.iRecords.RightIndent = 3;
            this.iRecords.TextAlignment = System.Drawing.StringAlignment.Near;
            this.iRecords.Width = 80;
            // 
            // mFile
            // 
            this.mFile.Caption = "&File";
            this.mFile.CategoryGuid = new System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a");
            this.mFile.Id = 1;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit)});
            this.mFile.Name = "mFile";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.CategoryGuid = new System.Guid("2ce5e5b3-891d-4ed7-b3ba-c54e77a23318");
            this.iExit.Id = 4;
            this.iExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Built-in Menus", new System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a")),
            new DevExpress.XtraBars.BarManagerCategory("File", new System.Guid("2ce5e5b3-891d-4ed7-b3ba-c54e77a23318")),
            new DevExpress.XtraBars.BarManagerCategory("Filter", new System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a")),
            new DevExpress.XtraBars.BarManagerCategory("Status", new System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888")),
            new DevExpress.XtraBars.BarManagerCategory("PaintStyles", new System.Guid("d0173875-bf7b-4740-b252-5047db62606c"))});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList2;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.mFilter,
            this.iExit,
            this.discontinued,
            this.iRecords,
            this.iFilter,
            this.lastOrder,
            this.iClearFilter,
            this.categories,
            this.iAbout,
            this.iPaintStyle,
            this.ipsWXP,
            this.ipsOXP,
            this.ipsO2K,
            this.ipsO3,
            this.ipsDefault});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 16;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryImageComboBox1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(30, 142);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mFilter),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main";
            // 
            // mFilter
            // 
            this.mFilter.Caption = "F&ilter";
            this.mFilter.CategoryGuid = new System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a");
            this.mFilter.Id = 2;
            this.mFilter.ImageIndex = 1;
            this.mFilter.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.discontinued, "", false, true, true, 104),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.lastOrder, "", false, true, true, 104),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.categories, "", false, true, true, 104)});
            this.mFilter.Name = "mFilter";
            this.mFilter.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // discontinued
            // 
            this.discontinued.Caption = "Discontinued: ";
            this.discontinued.CategoryGuid = new System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a");
            this.discontinued.Edit = this.repositoryItemCheckEdit1;
            this.discontinued.Id = 5;
            this.discontinued.Name = "discontinued";
            this.discontinued.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.discontinued.EditValueChanged += new System.EventHandler(this.discontinued_EditValueChanged);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowFocused = false;
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // categories
            // 
            this.categories.Caption = "Categories:";
            this.categories.CategoryGuid = new System.Guid("db1c445d-a939-4427-90b2-c7daba2f0f9a");
            this.categories.Edit = this.repositoryImageComboBox1;
            this.categories.Id = 10;
            this.categories.Name = "categories";
            this.categories.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.categories.EditValueChanged += new System.EventHandler(this.categories_EditValueChanged);
            // 
            // repositoryImageComboBox1
            // 
            this.repositoryImageComboBox1.AllowFocused = false;
            this.repositoryImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryImageComboBox1.Name = "repositoryImageComboBox1";
            this.repositoryImageComboBox1.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.CategoryGuid = new System.Guid("01b4aa47-f56a-49b3-845b-a6dde012966a");
            this.iAbout.Id = 10;
            this.iAbout.ImageIndex = 0;
            this.iAbout.Name = "iAbout";
            this.iAbout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Filter";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(50, 143);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.discontinued),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.lastOrder, "", false, true, true, 100),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.categories, "", false, true, true, 113),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClearFilter, true)});
            this.bar2.Text = "Filter";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.FloatLocation = new System.Drawing.Point(51, 454);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iRecords),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFilter)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.DrawSizeGrip = true;
            this.bar3.OptionsBar.RotateWhenVertical = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status";
            // 
            // iFilter
            // 
            this.iFilter.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.iFilter.Caption = "Filter";
            this.iFilter.CategoryGuid = new System.Guid("c50efb7e-86d5-43db-8f6a-468d77d38888");
            this.iFilter.Id = 7;
            this.iFilter.Name = "iFilter";
            this.iFilter.TextAlignment = System.Drawing.StringAlignment.Near;
            this.iFilter.Width = 455;
            // 
            // bar4
            // 
            this.bar4.BarName = "PaintStyle";
            this.bar4.DockCol = 1;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaintStyle)});
            this.bar4.Offset = 741;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.RotateWhenVertical = false;
            this.bar4.Text = "PaintStyle";
            // 
            // iPaintStyle
            // 
            this.iPaintStyle.Caption = "Paint Style";
            this.iPaintStyle.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.iPaintStyle.Id = 10;
            this.iPaintStyle.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ipsDefault),
            new DevExpress.XtraBars.LinkPersistInfo(this.ipsWXP),
            new DevExpress.XtraBars.LinkPersistInfo(this.ipsOXP),
            new DevExpress.XtraBars.LinkPersistInfo(this.ipsO2K),
            new DevExpress.XtraBars.LinkPersistInfo(this.ipsO3)});
            this.iPaintStyle.Name = "iPaintStyle";
            this.iPaintStyle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // ipsDefault
            // 
            this.ipsDefault.Caption = "Default";
            this.ipsDefault.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.ipsDefault.Description = "Default";
            this.ipsDefault.Id = 15;
            this.ipsDefault.Name = "ipsDefault";
            this.ipsDefault.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            // 
            // ipsWXP
            // 
            this.ipsWXP.Caption = "Windows XP";
            this.ipsWXP.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.ipsWXP.Description = "WindowsXP";
            this.ipsWXP.Id = 11;
            this.ipsWXP.ImageIndex = 5;
            this.ipsWXP.Name = "ipsWXP";
            this.ipsWXP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            // 
            // ipsOXP
            // 
            this.ipsOXP.Caption = "Office XP";
            this.ipsOXP.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.ipsOXP.Description = "OfficeXP";
            this.ipsOXP.Id = 12;
            this.ipsOXP.ImageIndex = 3;
            this.ipsOXP.Name = "ipsOXP";
            this.ipsOXP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            // 
            // ipsO2K
            // 
            this.ipsO2K.Caption = "Office 2000";
            this.ipsO2K.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.ipsO2K.Description = "Office2000";
            this.ipsO2K.Id = 13;
            this.ipsO2K.ImageIndex = 4;
            this.ipsO2K.Name = "ipsO2K";
            this.ipsO2K.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            // 
            // ipsO3
            // 
            this.ipsO3.Caption = "Office 2003";
            this.ipsO3.CategoryGuid = new System.Guid("d0173875-bf7b-4740-b252-5047db62606c");
            this.ipsO3.Description = "Office2003";
            this.ipsO3.Id = 14;
            this.ipsO3.ImageIndex = 6;
            this.ipsO3.Name = "ipsO3";
            this.ipsO3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(4, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(684, 233);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName,
            this.colCategoryID,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder,
            this.colReorderLevel,
            this.colDiscontinued,
            this.colLastOrder});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductID
            // 
            this.colProductID.Caption = "ID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            this.colProductID.Width = 60;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 172;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "Category";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 2;
            this.colCategoryID.Width = 105;
            // 
            // colQuantityPerUnit
            // 
            this.colQuantityPerUnit.Caption = "Quantity Per Unit";
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            this.colQuantityPerUnit.Visible = true;
            this.colQuantityPerUnit.VisibleIndex = 4;
            this.colQuantityPerUnit.Width = 109;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.DisplayFormat.FormatString = "c";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 6;
            this.colUnitPrice.Width = 61;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.Caption = "Units In Stock";
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Width = 83;
            // 
            // colUnitsOnOrder
            // 
            this.colUnitsOnOrder.Caption = "Units On Order";
            this.colUnitsOnOrder.FieldName = "UnitsOnOrder";
            this.colUnitsOnOrder.Name = "colUnitsOnOrder";
            this.colUnitsOnOrder.Width = 88;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.Caption = "Reorder Level";
            this.colReorderLevel.FieldName = "ReorderLevel";
            this.colReorderLevel.Name = "colReorderLevel";
            this.colReorderLevel.Width = 86;
            // 
            // colDiscontinued
            // 
            this.colDiscontinued.Caption = "Discontinued";
            this.colDiscontinued.FieldName = "Discontinued";
            this.colDiscontinued.Name = "colDiscontinued";
            this.colDiscontinued.Visible = true;
            this.colDiscontinued.VisibleIndex = 5;
            this.colDiscontinued.Width = 73;
            // 
            // colLastOrder
            // 
            this.colLastOrder.Caption = "Last Order";
            this.colLastOrder.FieldName = "LastOrder";
            this.colLastOrder.Name = "colLastOrder";
            this.colLastOrder.Visible = true;
            this.colLastOrder.VisibleIndex = 3;
            this.colLastOrder.Width = 65;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 55);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(4);
            this.panelControl1.Size = new System.Drawing.Size(692, 241);
            this.panelControl1.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(692, 321);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarEditors (C# Demo)";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarSubItem mFilter;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraBars.BarEditItem discontinued;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarStaticItem iRecords;
        private DevExpress.XtraBars.BarStaticItem iFilter;
        private DevExpress.XtraBars.BarEditItem lastOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem iClearFilter;
        private DevExpress.XtraBars.BarEditItem categories;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryImageComboBox1;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarSubItem iPaintStyle;
        private DevExpress.XtraBars.BarButtonItem ipsWXP;
        private DevExpress.XtraBars.BarButtonItem ipsOXP;
        private DevExpress.XtraBars.BarButtonItem ipsO2K;
        private DevExpress.XtraBars.BarButtonItem ipsO3;
        private DevExpress.XtraBars.BarButtonItem ipsDefault;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsOnOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinued;
        private DevExpress.XtraGrid.Columns.GridColumn colLastOrder;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.ComponentModel.IContainer components;

    }
}
