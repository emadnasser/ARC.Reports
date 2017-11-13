namespace DevExpress.XtraBars.Demos.SimplePad {
    partial class frmMain {

        #region Designer generated code
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.iWeb = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iCenter = new DevExpress.XtraBars.BarButtonItem();
            this.iSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.iCopy = new DevExpress.XtraBars.BarButtonItem();
            this.iEdit = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.iCut = new DevExpress.XtraBars.BarButtonItem();
            this.iPaste = new DevExpress.XtraBars.BarButtonItem();
            this.iClear = new DevExpress.XtraBars.BarButtonItem();
            this.iFont = new DevExpress.XtraBars.BarButtonItem();
            this.iBullets = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iPrint = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.mEdit = new DevExpress.XtraBars.BarSubItem();
            this.iUndo = new DevExpress.XtraBars.BarButtonItem();
            this.iFind = new DevExpress.XtraBars.BarButtonItem();
            this.iReplace = new DevExpress.XtraBars.BarButtonItem();
            this.mFormat = new DevExpress.XtraBars.BarSubItem();
            this.iFontColor = new DevExpress.XtraBars.BarButtonItem();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.iProtected = new DevExpress.XtraBars.BarButtonItem();
            this.iToolBars = new DevExpress.XtraBars.BarToolbarsListItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.iBold = new DevExpress.XtraBars.BarButtonItem();
            this.iItalic = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderline = new DevExpress.XtraBars.BarButtonItem();
            this.iAlignLeft = new DevExpress.XtraBars.BarButtonItem();
            this.iAlignRight = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.sPosition = new DevExpress.XtraBars.BarStaticItem();
            this.sModifier = new DevExpress.XtraBars.BarStaticItem();
            this.sDocName = new DevExpress.XtraBars.BarStaticItem();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.iPaintStyle = new DevExpress.XtraBars.BarSubItem();
            this.ipsDefault = new DevExpress.XtraBars.BarButtonItem();
            this.ipsWXP = new DevExpress.XtraBars.BarButtonItem();
            this.ipsOXP = new DevExpress.XtraBars.BarButtonItem();
            this.ipsO2K = new DevExpress.XtraBars.BarButtonItem();
            this.ipsO3 = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.rtPad = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // mHelp
            //
            this.mHelp.Caption = "&Help";
            this.mHelp.CategoryGuid = new System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9");
            this.mHelp.Id = 23;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iWeb),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout, true)});
            this.mHelp.Name = "mHelp";
            //
            // iWeb
            //
            this.iWeb.Caption = "&DevExpress on the Web";
            this.iWeb.CategoryGuid = new System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b");
            this.iWeb.Description = "Opens the web page.";
            this.iWeb.Hint = "DevExpress on the Web";
            this.iWeb.Id = 21;
            this.iWeb.ImageIndex = 21;
            this.iWeb.Name = "iWeb";
            this.iWeb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iWeb_ItemClick);
            //
            // iAbout
            //
            this.iAbout.Caption = "&About";
            this.iAbout.CategoryGuid = new System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b");
            this.iAbout.Description = "Displays the description of this program.";
            this.iAbout.Id = 22;
            this.iAbout.Name = "iAbout";
            this.iAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAbout_ItemClick);
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
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            //
            // iCenter
            //
            this.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iCenter.Caption = "&Center";
            this.iCenter.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iCenter.Description = "Centers the selected text.";
            this.iCenter.GroupIndex = 1;
            this.iCenter.Hint = "Center";
            this.iCenter.Id = 28;
            this.iCenter.ImageIndex = 19;
            this.iCenter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.iCenter.Name = "iCenter";
            this.iCenter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAlign_ItemClick);
            //
            // iSelectAll
            //
            this.iSelectAll.Caption = "Select A&ll";
            this.iSelectAll.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iSelectAll.Description = "Selects all text in the active document.";
            this.iSelectAll.Id = 13;
            this.iSelectAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.iSelectAll.Name = "iSelectAll";
            this.iSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSelectAll_ItemClick);
            //
            // iCopy
            //
            this.iCopy.Caption = "&Copy";
            this.iCopy.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iCopy.Description = "Copies the selection to the Clipboard.";
            this.iCopy.Hint = "Copy";
            this.iCopy.Id = 10;
            this.iCopy.ImageIndex = 1;
            this.iCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.iCopy.Name = "iCopy";
            this.iCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCopy_ItemClick);
            //
            // iEdit
            //
            this.iEdit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iEdit.Caption = "&Edit...";
            this.iEdit.CategoryGuid = new System.Guid("78945463-36c5-4beb-a57f-d50b6a74e9b9");
            this.iEdit.DropDownControl = this.popupMenu1;
            this.iEdit.Hint = "Edit Menu";
            this.iEdit.Id = 31;
            this.iEdit.ImageIndex = 22;
            this.iEdit.Name = "iEdit";
            //
            // popupMenu1
            //
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iCut),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClear),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFont, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBullets)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.MenuBarWidth = 20;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.PaintMenuBar += new DevExpress.XtraBars.BarCustomDrawEventHandler(this.item_PaintMenuBar);
            //
            // iCut
            //
            this.iCut.Caption = "Cu&t";
            this.iCut.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iCut.Description = "Removes the selection from the active document and places it on the Clipboard.";
            this.iCut.Hint = "Cut";
            this.iCut.Id = 9;
            this.iCut.ImageIndex = 2;
            this.iCut.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.iCut.Name = "iCut";
            this.iCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iCut_ItemClick);
            //
            // iPaste
            //
            this.iPaste.Caption = "&Paste";
            this.iPaste.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" +
    "lection. This command is available only if you have cut or copied a text.";
            this.iPaste.Hint = "Paste";
            this.iPaste.Id = 11;
            this.iPaste.ImageIndex = 8;
            this.iPaste.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.iPaste.Name = "iPaste";
            this.iPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iPaste_ItemClick);
            //
            // iClear
            //
            this.iClear.Caption = "Cle&ar";
            this.iClear.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" +
    "ailable only if a text is selected. ";
            this.iClear.Hint = "Clear";
            this.iClear.Id = 12;
            this.iClear.ImageIndex = 13;
            this.iClear.Name = "iClear";
            this.iClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iClear_ItemClick);
            //
            // iFont
            //
            this.iFont.Caption = "&Font...";
            this.iFont.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iFont.Description = "Changes the font and character spacing formats of the selected text.";
            this.iFont.Hint = "Font Dialog";
            this.iFont.Id = 17;
            this.iFont.ImageIndex = 4;
            this.iFont.Name = "iFont";
            this.iFont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFont_ItemClick);
            //
            // iBullets
            //
            this.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iBullets.Caption = "&Bullets";
            this.iBullets.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs.";
            this.iBullets.Hint = "Bullets";
            this.iBullets.Id = 18;
            this.iBullets.ImageIndex = 0;
            this.iBullets.Name = "iBullets";
            this.iBullets.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iBullets_ItemClick);
            //
            // barManager1
            //
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4,
            this.bar5,
            this.bar7});
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("File", new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")),
            new DevExpress.XtraBars.BarManagerCategory("Edit", new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")),
            new DevExpress.XtraBars.BarManagerCategory("Format", new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")),
            new DevExpress.XtraBars.BarManagerCategory("Help", new System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")),
            new DevExpress.XtraBars.BarManagerCategory("Popup", new System.Guid("78945463-36c5-4beb-a57f-d50b6a74e9b9")),
            new DevExpress.XtraBars.BarManagerCategory("Status", new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d")),
            new DevExpress.XtraBars.BarManagerCategory("Built-in Menus", new System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9")),
            new DevExpress.XtraBars.BarManagerCategory("ToolBars", new System.Guid("3856091a-e0f6-4a7c-80e9-103dece20d5b")),
            new DevExpress.XtraBars.BarManagerCategory("PaintStyle", new System.Guid("7102d69f-976b-49fe-978d-97325e115e10"))});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.iNew,
            this.iOpen,
            this.iClose,
            this.iSave,
            this.iSaveAs,
            this.iPrint,
            this.iExit,
            this.mFile,
            this.iUndo,
            this.iCut,
            this.iCopy,
            this.iPaste,
            this.iClear,
            this.iSelectAll,
            this.iFind,
            this.iReplace,
            this.mEdit,
            this.iFont,
            this.iBullets,
            this.iProtected,
            this.mFormat,
            this.iWeb,
            this.iAbout,
            this.mHelp,
            this.iBold,
            this.iItalic,
            this.iUnderline,
            this.iAlignLeft,
            this.iCenter,
            this.iAlignRight,
            this.iFontColor,
            this.iEdit,
            this.sPosition,
            this.sModifier,
            this.sDocName,
            this.iToolBars,
            this.iPaintStyle,
            this.ipsWXP,
            this.ipsOXP,
            this.ipsO2K,
            this.ipsO3,
            this.ipsDefault});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 90;
            this.barManager1.StatusBar = this.bar5;
            this.barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager1_ItemClick);
            //
            // bar1
            //
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.mFormat),
            new DevExpress.XtraBars.LinkPersistInfo(this.iToolBars),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHelp)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            //
            // mFile
            //
            this.mFile.Caption = "&File";
            this.mFile.CategoryGuid = new System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9");
            this.mFile.Id = 7;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iSaveAs, "", false, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iPrint, "", true, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit, true)});
            this.mFile.MenuBarWidth = 20;
            this.mFile.Name = "mFile";
            this.mFile.PaintMenuBar += new DevExpress.XtraBars.BarCustomDrawEventHandler(this.item_PaintMenuBar);
            //
            // iNew
            //
            this.iNew.Caption = "&New";
            this.iNew.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iNew.Description = "Creates a new, blank file.";
            this.iNew.Hint = "New Blank Document";
            this.iNew.Id = 0;
            this.iNew.ImageIndex = 6;
            this.iNew.Name = "iNew";
            this.iNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iNew_ItemClick);
            //
            // iOpen
            //
            this.iOpen.Caption = "&Open...";
            this.iOpen.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iOpen.Description = "Opens a file.";
            this.iOpen.Hint = "Open";
            this.iOpen.Id = 1;
            this.iOpen.ImageIndex = 7;
            this.iOpen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.iOpen.Name = "iOpen";
            this.iOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iOpen_ItemClick);
            //
            // iClose
            //
            this.iClose.Caption = "&Close";
            this.iClose.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iClose.Description = "Closes the active document.";
            this.iClose.Hint = "Close Document";
            this.iClose.Id = 2;
            this.iClose.ImageIndex = 12;
            this.iClose.Name = "iClose";
            this.iClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iClose_ItemClick);
            //
            // iSave
            //
            this.iSave.Caption = "&Save";
            this.iSave.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iSave.Description = "Saves the active document with its current file name.";
            this.iSave.Hint = "Save";
            this.iSave.Id = 3;
            this.iSave.ImageIndex = 10;
            this.iSave.Name = "iSave";
            this.iSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSave_ItemClick);
            //
            // iSaveAs
            //
            this.iSaveAs.Caption = "Save &As...";
            this.iSaveAs.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iSaveAs.Description = "Saves the active document with a different file name.";
            this.iSaveAs.Id = 4;
            this.iSaveAs.Name = "iSaveAs";
            this.iSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSaveAs_ItemClick);
            //
            // iPrint
            //
            this.iPrint.Caption = "&Print";
            this.iPrint.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iPrint.Description = "Prints the active document.";
            this.iPrint.Hint = "Print";
            this.iPrint.Id = 5;
            this.iPrint.ImageIndex = 9;
            this.iPrint.Name = "iPrint";
            this.iPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iPrint_ItemClick);
            //
            // iExit
            //
            this.iExit.Caption = "E&xit";
            this.iExit.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iExit.Description = "Closes this program after prompting you to save unsaved document.";
            this.iExit.Id = 6;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            //
            // mEdit
            //
            this.mEdit.Caption = "&Edit";
            this.mEdit.CategoryGuid = new System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9");
            this.mEdit.Id = 16;
            this.mEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCut, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaste),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iClear, "", true, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSelectAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFind, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iReplace)});
            this.mEdit.Name = "mEdit";
            //
            // iUndo
            //
            this.iUndo.Caption = "&Undo";
            this.iUndo.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iUndo.Description = "Reverses the last command or deletes the last entry you typed.";
            this.iUndo.Hint = "Undo";
            this.iUndo.Id = 8;
            this.iUndo.ImageIndex = 11;
            this.iUndo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.iUndo.Name = "iUndo";
            this.iUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iUndo_ItemClick);
            //
            // iFind
            //
            this.iFind.Caption = "&Find...";
            this.iFind.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iFind.Description = "Searches for the specified text.";
            this.iFind.Hint = "Find";
            this.iFind.Id = 14;
            this.iFind.ImageIndex = 3;
            this.iFind.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.iFind.Name = "iFind";
            this.iFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFind_ItemClick);
            //
            // iReplace
            //
            this.iReplace.Caption = "R&eplace...";
            this.iReplace.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iReplace.Description = "Searches for and replaces the specified text.";
            this.iReplace.Hint = "Replace";
            this.iReplace.Id = 15;
            this.iReplace.ImageIndex = 14;
            this.iReplace.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.iReplace.Name = "iReplace";
            this.iReplace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iReplace_ItemClick);
            //
            // mFormat
            //
            this.mFormat.Caption = "F&ormat";
            this.mFormat.CategoryGuid = new System.Guid("02ed6c1c-df85-47f8-9572-b20022d647f9");
            this.mFormat.Id = 20;
            this.mFormat.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iFont),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iFontColor, "", false, false, true, 0),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBullets, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, this.iProtected, "", false, false, true, 0)});
            this.mFormat.Name = "mFormat";
            //
            // iFontColor
            //
            this.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iFontColor.Caption = "Font C&olor";
            this.iFontColor.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iFontColor.Description = "Formats the selected text with the color you click.";
            this.iFontColor.DropDownControl = this.popupControlContainer1;
            this.iFontColor.Hint = "Font Color";
            this.iFontColor.Id = 30;
            this.iFontColor.ImageIndex = 5;
            this.iFontColor.Name = "iFontColor";
            this.iFontColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFontColor_ItemClick);
            //
            // popupControlContainer1
            //
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Location = new System.Drawing.Point(396, 304);
            this.popupControlContainer1.Manager = this.barManager1;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(44, 40);
            this.popupControlContainer1.TabIndex = 6;
            this.popupControlContainer1.Visible = false;
            //
            // iProtected
            //
            this.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iProtected.Caption = "P&rotected";
            this.iProtected.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iProtected.Description = "Protectes the selected text.";
            this.iProtected.Id = 19;
            this.iProtected.Name = "iProtected";
            this.iProtected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iProtected_ItemClick);
            //
            // iToolBars
            //
            this.iToolBars.Caption = "&ToolBars";
            this.iToolBars.CategoryGuid = new System.Guid("3856091a-e0f6-4a7c-80e9-103dece20d5b");
            this.iToolBars.Id = 38;
            this.iToolBars.Name = "iToolBars";
            //
            // bar2
            //
            this.bar2.BarName = "Standard";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.iPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCut, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.iUndo, true)});
            this.bar2.Text = "Standard";
            //
            // bar3
            //
            this.bar3.BarName = "Format";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 2;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(34, 212);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iBold),
            new DevExpress.XtraBars.LinkPersistInfo(this.iItalic),
            new DevExpress.XtraBars.LinkPersistInfo(this.iUnderline),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAlignLeft, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.iCenter),
            new DevExpress.XtraBars.LinkPersistInfo(this.iAlignRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.iBullets, true)});
            this.bar3.Text = "Format";
            //
            // iBold
            //
            this.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iBold.Caption = "&Bold";
            this.iBold.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " +
    "button removes bold formatting.";
            this.iBold.Hint = "Bold";
            this.iBold.Id = 24;
            this.iBold.ImageIndex = 15;
            this.iBold.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.iBold.Name = "iBold";
            this.iBold.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFontStyle_ItemClick);
            //
            // iItalic
            //
            this.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iItalic.Caption = "&Italic";
            this.iItalic.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" +
    "ing button removes italic formatting.";
            this.iItalic.Hint = "Italic";
            this.iItalic.Id = 25;
            this.iItalic.ImageIndex = 16;
            this.iItalic.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.iItalic.Name = "iItalic";
            this.iItalic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFontStyle_ItemClick);
            //
            // iUnderline
            //
            this.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iUnderline.Caption = "&Underline";
            this.iUnderline.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" +
    "cking button removes underlining.";
            this.iUnderline.Hint = "Underline";
            this.iUnderline.Id = 26;
            this.iUnderline.ImageIndex = 17;
            this.iUnderline.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.iUnderline.Name = "iUnderline";
            this.iUnderline.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iFontStyle_ItemClick);
            //
            // iAlignLeft
            //
            this.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iAlignLeft.Caption = "Align &Left";
            this.iAlignLeft.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iAlignLeft.Description = "Aligns the selected text to the left.";
            this.iAlignLeft.GroupIndex = 1;
            this.iAlignLeft.Hint = "Align Left";
            this.iAlignLeft.Id = 27;
            this.iAlignLeft.ImageIndex = 18;
            this.iAlignLeft.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.iAlignLeft.Name = "iAlignLeft";
            this.iAlignLeft.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAlign_ItemClick);
            //
            // iAlignRight
            //
            this.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iAlignRight.Caption = "Align &Right";
            this.iAlignRight.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iAlignRight.Description = "Aligns the selected text to the right.";
            this.iAlignRight.GroupIndex = 1;
            this.iAlignRight.Hint = "Align Right";
            this.iAlignRight.Id = 29;
            this.iAlignRight.ImageIndex = 20;
            this.iAlignRight.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.iAlignRight.Name = "iAlignRight";
            this.iAlignRight.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iAlign_ItemClick);
            //
            // bar4
            //
            this.bar4.BarName = "Font";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Right;
            this.bar4.FloatLocation = new System.Drawing.Point(493, 252);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iFont),
            new DevExpress.XtraBars.LinkPersistInfo(this.iFontColor),
            new DevExpress.XtraBars.LinkPersistInfo(this.iEdit, true)});
            this.bar4.Text = "Font";
            //
            // bar5
            //
            this.bar5.BarName = "StatusBar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.FloatLocation = new System.Drawing.Point(86, 499);
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sPosition),
            new DevExpress.XtraBars.LinkPersistInfo(this.sModifier),
            new DevExpress.XtraBars.LinkPersistInfo(this.sDocName)});
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.DrawSizeGrip = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "StatusBar";
            //
            // sPosition
            //
            this.sPosition.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.sPosition.Caption = "Position";
            this.sPosition.CategoryGuid = new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d");
            this.sPosition.Id = 32;
            this.sPosition.Name = "sPosition";
            this.sPosition.RightIndent = 2;
            this.sPosition.TextAlignment = System.Drawing.StringAlignment.Center;
            this.sPosition.Width = 145;
            //
            // sModifier
            //
            this.sModifier.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.sModifier.Caption = "Modifier";
            this.sModifier.CategoryGuid = new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d");
            this.sModifier.Id = 33;
            this.sModifier.Name = "sModifier";
            this.sModifier.RightIndent = 2;
            this.sModifier.TextAlignment = System.Drawing.StringAlignment.Center;
            this.sModifier.Width = 60;
            //
            // sDocName
            //
            this.sDocName.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.sDocName.Caption = "Name";
            this.sDocName.CategoryGuid = new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d");
            this.sDocName.Id = 34;
            this.sDocName.Name = "sDocName";
            this.sDocName.TextAlignment = System.Drawing.StringAlignment.Near;
            this.sDocName.Width = 245;
            //
            // bar7
            //
            this.bar7.BarName = "PaintStyle";
            this.bar7.DockCol = 1;
            this.bar7.DockRow = 1;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaintStyle)});
            this.bar7.Offset = 226;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.RotateWhenVertical = false;
            this.bar7.Text = "PaintStyle";
            //
            // iPaintStyle
            //
            this.iPaintStyle.Caption = "Paint Style";
            this.iPaintStyle.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.iPaintStyle.Id = 55;
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
            this.ipsDefault.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.ipsDefault.Description = "Default";
            this.ipsDefault.Id = 74;
            this.ipsDefault.Name = "ipsDefault";
            this.ipsDefault.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            //
            // ipsWXP
            //
            this.ipsWXP.Caption = "Windows XP";
            this.ipsWXP.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.ipsWXP.Description = "WindowsXP";
            this.ipsWXP.Id = 56;
            this.ipsWXP.ImageIndex = 25;
            this.ipsWXP.Name = "ipsWXP";
            this.ipsWXP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            //
            // ipsOXP
            //
            this.ipsOXP.Caption = "Office XP";
            this.ipsOXP.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.ipsOXP.Description = "OfficeXP";
            this.ipsOXP.Id = 57;
            this.ipsOXP.ImageIndex = 23;
            this.ipsOXP.Name = "ipsOXP";
            this.ipsOXP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            //
            // ipsO2K
            //
            this.ipsO2K.Caption = "Office 2000";
            this.ipsO2K.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.ipsO2K.Description = "Office2000";
            this.ipsO2K.Id = 58;
            this.ipsO2K.ImageIndex = 24;
            this.ipsO2K.Name = "ipsO2K";
            this.ipsO2K.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            //
            // ipsO3
            //
            this.ipsO3.Caption = "Office 2003";
            this.ipsO3.CategoryGuid = new System.Guid("7102d69f-976b-49fe-978d-97325e115e10");
            this.ipsO3.Description = "Office2003";
            this.ipsO3.Id = 69;
            this.ipsO3.ImageIndex = 26;
            this.ipsO3.Name = "ipsO3";
            this.ipsO3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ips_ItemClick);
            //
            // barAndDockingController1
            //
            this.barAndDockingController1.PaintStyleName = "Skin";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            //
            // barDockControl1
            //
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(536, 84);
            //
            // barDockControl2
            //
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 344);
            this.barDockControl2.Size = new System.Drawing.Size(536, 25);
            //
            // barDockControl3
            //
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 84);
            this.barDockControl3.Size = new System.Drawing.Size(0, 260);
            //
            // barDockControl4
            //
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(494, 84);
            this.barDockControl4.Size = new System.Drawing.Size(42, 260);
            //
            // rtPad
            //
            this.rtPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtPad.Location = new System.Drawing.Point(0, 84);
            this.rtPad.Name = "rtPad";
            this.rtPad.Size = new System.Drawing.Size(494, 260);
            this.rtPad.TabIndex = 4;
            this.rtPad.Text = "";
            this.rtPad.TextChanged += new System.EventHandler(this.rtPad_TextChanged);
            this.rtPad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rtPad_MouseUp);
            //
            // pictureBox1
            //
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
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
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            this.imageList2.Images.SetKeyName(16, "");
            this.imageList2.Images.SetKeyName(17, "");
            this.imageList2.Images.SetKeyName(18, "");
            this.imageList2.Images.SetKeyName(19, "");
            this.imageList2.Images.SetKeyName(20, "");
            this.imageList2.Images.SetKeyName(21, "");
            this.imageList2.Images.SetKeyName(22, "");
            this.imageList2.Images.SetKeyName(23, "");
            this.imageList2.Images.SetKeyName(24, "");
            this.imageList2.Images.SetKeyName(25, "");
            this.imageList2.Images.SetKeyName(26, "");
            //
            // frmMain
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(536, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtPad);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplePad (C# Demo)";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private System.Windows.Forms.RichTextBox rtPad;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarSubItem mFormat;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarSubItem mEdit;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iPrint;
        private DevExpress.XtraBars.BarButtonItem iClear;
        private DevExpress.XtraBars.BarButtonItem iPaste;
        private DevExpress.XtraBars.BarButtonItem iFind;
        private DevExpress.XtraBars.BarButtonItem iCut;
        private DevExpress.XtraBars.BarButtonItem iCopy;
        private DevExpress.XtraBars.BarButtonItem iUndo;
        private DevExpress.XtraBars.BarButtonItem iReplace;
        private DevExpress.XtraBars.BarButtonItem iSelectAll;
        private DevExpress.XtraBars.BarButtonItem iBold;
        private DevExpress.XtraBars.BarButtonItem iAlignRight;
        private DevExpress.XtraBars.BarButtonItem iCenter;
        private DevExpress.XtraBars.BarButtonItem iUnderline;
        private DevExpress.XtraBars.BarButtonItem iAlignLeft;
        private DevExpress.XtraBars.BarButtonItem iItalic;
        private DevExpress.XtraBars.BarButtonItem iFont;
        private DevExpress.XtraBars.BarButtonItem iBullets;
        private DevExpress.XtraBars.BarButtonItem iProtected;
        private DevExpress.XtraBars.BarButtonItem iFontColor;
        private DevExpress.XtraBars.BarButtonItem iWeb;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraBars.BarButtonItem iEdit;
        private DevExpress.XtraBars.BarStaticItem sDocName;
        private DevExpress.XtraBars.BarStaticItem sModifier;
        private DevExpress.XtraBars.BarStaticItem sPosition;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.BarToolbarsListItem iToolBars;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarSubItem iPaintStyle;
        private DevExpress.XtraBars.BarButtonItem ipsWXP;
        private DevExpress.XtraBars.BarButtonItem ipsOXP;
        private DevExpress.XtraBars.BarButtonItem ipsO2K;
        private DevExpress.XtraBars.BarButtonItem ipsO3;
        private DevExpress.XtraBars.BarButtonItem ipsDefault;
        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarButtonItem iAbout;
    }
}
