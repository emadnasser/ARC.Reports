Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.MDIDemo
	Partial Public Class frmMain
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.iPicture = New DevExpress.XtraBars.BarStaticItem()
            Me.mHelp = New DevExpress.XtraBars.BarSubItem()
            Me.iWeb = New DevExpress.XtraBars.BarButtonItem()
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.imageList1 = New System.Windows.Forms.ImageList()
            Me.iHorizontalFlip = New DevExpress.XtraBars.BarButtonItem()
            Me.iSelectAll = New DevExpress.XtraBars.BarButtonItem()
            Me.iCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer()
            Me.alignmentControl1 = New DevExpress.Tutorials.Controls.AlignmentControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.mFile = New DevExpress.XtraBars.BarSubItem()
            Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.iClose = New DevExpress.XtraBars.BarButtonItem()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.mEdit = New DevExpress.XtraBars.BarSubItem()
            Me.mWindow = New DevExpress.XtraBars.BarSubItem()
            Me.biTabbedMDI = New DevExpress.XtraBars.BarButtonItem()
            Me.iCascade = New DevExpress.XtraBars.BarButtonItem()
            Me.iTileHorizontal = New DevExpress.XtraBars.BarButtonItem()
            Me.iTileVertical = New DevExpress.XtraBars.BarButtonItem()
            Me.BarMdiChildrenListItem = New DevExpress.XtraBars.BarMdiChildrenListItem()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.iVerticalFlip = New DevExpress.XtraBars.BarButtonItem()
            Me.iRotateBy90 = New DevExpress.XtraBars.BarButtonItem()
            Me.iPictureAlignment = New DevExpress.XtraBars.BarButtonItem()
            Me.sizeMode = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.bar4 = New DevExpress.XtraBars.Bar()
            Me.iCut = New DevExpress.XtraBars.BarButtonItem()
            Me.iPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.colorEdit = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
            Me.iFont = New DevExpress.XtraBars.BarButtonItem()
            Me.bar5 = New DevExpress.XtraBars.Bar()
            Me.iDocName = New DevExpress.XtraBars.BarStaticItem()
            Me.bar6 = New DevExpress.XtraBars.Bar()
            Me.iPaintStyle = New DevExpress.XtraBars.BarSubItem()
            Me.ipsDefault = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsWXP = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsOXP = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsO2K = New DevExpress.XtraBars.BarButtonItem()
            Me.ipsO2003 = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
            Me.popupMenu2 = New DevExpress.XtraBars.PopupMenu()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu()
            Me.imageList2 = New System.Windows.Forms.ImageList()
            Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'iPicture
            '
            Me.iPicture.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.iPicture.CategoryGuid = New System.Guid("2827f321-90e1-4a0d-9bfa-bef5134ad8db")
            Me.iPicture.Id = 22
            Me.iPicture.Name = "iPicture"
            Me.iPicture.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            Me.iPicture.TextAlignment = System.Drawing.StringAlignment.Near
            '
            'mHelp
            '
            Me.mHelp.Caption = "&Help"
            Me.mHelp.CategoryGuid = New System.Guid("e1421a93-0d6d-407d-95c2-a10747db3dd9")
            Me.mHelp.Id = 1
            Me.mHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iWeb), New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout, True)})
            Me.mHelp.Name = "mHelp"
            '
            'iWeb
            '
            Me.iWeb.Caption = "&Developer Express on the Web"
            Me.iWeb.CategoryGuid = New System.Guid("f105c191-7872-4980-8ab3-8cfec30fe301")
            Me.iWeb.Id = 13
            Me.iWeb.ImageIndex = 8
            Me.iWeb.Name = "iWeb"
            '
            'iAbout
            '
            Me.iAbout.Caption = "&About"
            Me.iAbout.CategoryGuid = New System.Guid("f105c191-7872-4980-8ab3-8cfec30fe301")
            Me.iAbout.Id = 14
            Me.iAbout.Name = "iAbout"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            Me.imageList1.Images.SetKeyName(2, "")
            Me.imageList1.Images.SetKeyName(3, "")
            Me.imageList1.Images.SetKeyName(4, "")
            Me.imageList1.Images.SetKeyName(5, "")
            Me.imageList1.Images.SetKeyName(6, "")
            Me.imageList1.Images.SetKeyName(7, "")
            Me.imageList1.Images.SetKeyName(8, "")
            Me.imageList1.Images.SetKeyName(9, "")
            Me.imageList1.Images.SetKeyName(10, "")
            Me.imageList1.Images.SetKeyName(11, "")
            Me.imageList1.Images.SetKeyName(12, "")
            Me.imageList1.Images.SetKeyName(13, "")
            Me.imageList1.Images.SetKeyName(14, "")
            Me.imageList1.Images.SetKeyName(15, "")
            Me.imageList1.Images.SetKeyName(16, "")
            Me.imageList1.Images.SetKeyName(17, "")
            Me.imageList1.Images.SetKeyName(18, "")
            '
            'iHorizontalFlip
            '
            Me.iHorizontalFlip.Caption = "&Horizontal Flip"
            Me.iHorizontalFlip.CategoryGuid = New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")
            Me.iHorizontalFlip.Hint = "Horizontal Flip"
            Me.iHorizontalFlip.Id = 5
            Me.iHorizontalFlip.ImageIndex = 2
            Me.iHorizontalFlip.Name = "iHorizontalFlip"
            '
            'iSelectAll
            '
            Me.iSelectAll.Caption = "Select &All"
            Me.iSelectAll.CategoryGuid = New System.Guid("2484205c-8785-4d92-a79d-d9d652073711")
            Me.iSelectAll.Id = 18
            Me.iSelectAll.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A))
            Me.iSelectAll.Name = "iSelectAll"
            '
            'iCopy
            '
            Me.iCopy.Caption = "&Copy"
            Me.iCopy.CategoryGuid = New System.Guid("2484205c-8785-4d92-a79d-d9d652073711")
            Me.iCopy.Hint = "Copy"
            Me.iCopy.Id = 16
            Me.iCopy.ImageIndex = 10
            Me.iCopy.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
            Me.iCopy.Name = "iCopy"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.alignmentControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(10, 215)
            Me.popupControlContainer1.Manager = Me.barManager1
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Padding = New System.Windows.Forms.Padding(4)
            Me.popupControlContainer1.Size = New System.Drawing.Size(142, 121)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            '
            'alignmentControl1
            '
            Me.alignmentControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.alignmentControl1.Appearance.Options.UseBackColor = True
            Me.alignmentControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.alignmentControl1.Location = New System.Drawing.Point(4, 4)
            Me.alignmentControl1.Name = "alignmentControl1"
            Me.alignmentControl1.Size = New System.Drawing.Size(134, 113)
            Me.alignmentControl1.TabIndex = 0
            '
            'barManager1
            '
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar2, Me.bar3, Me.bar4, Me.bar5, Me.bar6})
            Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("8fbf2483-3ab6-45dc-9a54-0a6db013e021")), New DevExpress.XtraBars.BarManagerCategory("Built-in Menus", New System.Guid("e1421a93-0d6d-407d-95c2-a10747db3dd9")), New DevExpress.XtraBars.BarManagerCategory("Image", New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")), New DevExpress.XtraBars.BarManagerCategory("Window", New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")), New DevExpress.XtraBars.BarManagerCategory("Help", New System.Guid("f105c191-7872-4980-8ab3-8cfec30fe301")), New DevExpress.XtraBars.BarManagerCategory("Edit", New System.Guid("2484205c-8785-4d92-a79d-d9d652073711")), New DevExpress.XtraBars.BarManagerCategory("Format", New System.Guid("2647ec04-72de-46d9-a06c-477510ca4f71")), New DevExpress.XtraBars.BarManagerCategory("Status", New System.Guid("2827f321-90e1-4a0d-9bfa-bef5134ad8db")), New DevExpress.XtraBars.BarManagerCategory("PaintStyles", New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f"))})
            Me.barManager1.DockControls.Add(Me.barDockControl1)
            Me.barManager1.DockControls.Add(Me.barDockControl2)
            Me.barManager1.DockControls.Add(Me.barDockControl3)
            Me.barManager1.DockControls.Add(Me.barDockControl4)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageList1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mFile, Me.mHelp, Me.iOpen, Me.iClose, Me.iExit, Me.iHorizontalFlip, Me.iVerticalFlip, Me.iRotateBy90, Me.iPictureAlignment, Me.biTabbedMDI, Me.iCascade, Me.iTileHorizontal, Me.iTileVertical, Me.mWindow, Me.iWeb, Me.iAbout, Me.iCut, Me.iCopy, Me.iPaste, Me.iSelectAll, Me.mEdit, Me.iFont, Me.iDocName, Me.iPicture, Me.BarMdiChildrenListItem, Me.colorEdit, Me.sizeMode, Me.iPaintStyle, Me.ipsWXP, Me.ipsOXP, Me.ipsO2K, Me.ipsO2003, Me.ipsDefault})
            Me.barManager1.MainMenu = Me.bar1
            Me.barManager1.MaxItemId = 31
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemColorEdit1, Me.repositoryItemImageComboBox1})
            Me.barManager1.StatusBar = Me.bar5
            '
            'bar1
            '
            Me.bar1.BarName = "Main Menu"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(32, 148)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mFile), New DevExpress.XtraBars.LinkPersistInfo(Me.mEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.mWindow), New DevExpress.XtraBars.LinkPersistInfo(Me.mHelp)})
            Me.bar1.OptionsBar.AllowQuickCustomization = False
            Me.bar1.OptionsBar.DrawDragBorder = False
            Me.bar1.OptionsBar.MultiLine = True
            Me.bar1.OptionsBar.UseWholeRow = True
            Me.bar1.Text = "Main Menu"
            '
            'mFile
            '
            Me.mFile.Caption = "&File"
            Me.mFile.CategoryGuid = New System.Guid("e1421a93-0d6d-407d-95c2-a10747db3dd9")
            Me.mFile.Id = 0
            Me.mFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit, True)})
            Me.mFile.Name = "mFile"
            '
            'iOpen
            '
            Me.iOpen.Caption = "&Open..."
            Me.iOpen.CategoryGuid = New System.Guid("8fbf2483-3ab6-45dc-9a54-0a6db013e021")
            Me.iOpen.Hint = "Open"
            Me.iOpen.Id = 2
            Me.iOpen.ImageIndex = 0
            Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.iOpen.Name = "iOpen"
            '
            'iClose
            '
            Me.iClose.Caption = "&Close"
            Me.iClose.CategoryGuid = New System.Guid("8fbf2483-3ab6-45dc-9a54-0a6db013e021")
            Me.iClose.Hint = "Close"
            Me.iClose.Id = 3
            Me.iClose.ImageIndex = 1
            Me.iClose.Name = "iClose"
            '
            'iExit
            '
            Me.iExit.Caption = "E&xit"
            Me.iExit.CategoryGuid = New System.Guid("8fbf2483-3ab6-45dc-9a54-0a6db013e021")
            Me.iExit.Id = 4
            Me.iExit.Name = "iExit"
            '
            'mEdit
            '
            Me.mEdit.Caption = "&Edit"
            Me.mEdit.CategoryGuid = New System.Guid("e1421a93-0d6d-407d-95c2-a10747db3dd9")
            Me.mEdit.Id = 19
            Me.mEdit.Name = "mEdit"
            '
            'mWindow
            '
            Me.mWindow.Caption = "&Window"
            Me.mWindow.CategoryGuid = New System.Guid("e1421a93-0d6d-407d-95c2-a10747db3dd9")
            Me.mWindow.Id = 12
            Me.mWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biTabbedMDI), New DevExpress.XtraBars.LinkPersistInfo(Me.iCascade, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iTileHorizontal), New DevExpress.XtraBars.LinkPersistInfo(Me.iTileVertical), New DevExpress.XtraBars.LinkPersistInfo(Me.BarMdiChildrenListItem, True)})
            Me.mWindow.Name = "mWindow"
            '
            'biTabbedMDI
            '
            Me.biTabbedMDI.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biTabbedMDI.Caption = "Use TabbedMDI"
            Me.biTabbedMDI.CategoryGuid = New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")
            Me.biTabbedMDI.Down = True
            Me.biTabbedMDI.Id = 66
            Me.biTabbedMDI.Name = "biTabbedMDI"
            '
            'iCascade
            '
            Me.iCascade.Caption = "&Cascade"
            Me.iCascade.CategoryGuid = New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")
            Me.iCascade.Id = 9
            Me.iCascade.ImageIndex = 5
            Me.iCascade.Name = "iCascade"
            '
            'iTileHorizontal
            '
            Me.iTileHorizontal.Caption = "Tile &Horizontal"
            Me.iTileHorizontal.CategoryGuid = New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")
            Me.iTileHorizontal.Id = 10
            Me.iTileHorizontal.ImageIndex = 7
            Me.iTileHorizontal.Name = "iTileHorizontal"
            '
            'iTileVertical
            '
            Me.iTileVertical.Caption = "Tile &Vertical"
            Me.iTileVertical.CategoryGuid = New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")
            Me.iTileVertical.Id = 11
            Me.iTileVertical.ImageIndex = 6
            Me.iTileVertical.Name = "iTileVertical"
            '
            'BarMdiChildrenListItem
            '
            Me.BarMdiChildrenListItem.Caption = "Windows"
            Me.BarMdiChildrenListItem.CategoryGuid = New System.Guid("8a7c73f0-86d6-47e0-bc21-cc6a93939e04")
            Me.BarMdiChildrenListItem.Id = 23
            Me.BarMdiChildrenListItem.Name = "BarMdiChildrenListItem"
            '
            'bar2
            '
            Me.bar2.BarName = "File"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 1
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.FloatLocation = New System.Drawing.Point(143, 152)
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iClose)})
            Me.bar2.Text = "File"
            '
            'bar3
            '
            Me.bar3.BarName = "Image"
            Me.bar3.DockCol = 1
            Me.bar3.DockRow = 1
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar3.FloatLocation = New System.Drawing.Point(57, 226)
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iHorizontalFlip), New DevExpress.XtraBars.LinkPersistInfo(Me.iVerticalFlip), New DevExpress.XtraBars.LinkPersistInfo(Me.iRotateBy90), New DevExpress.XtraBars.LinkPersistInfo(Me.iPictureAlignment, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.sizeMode, "", False, True, True, 91)})
            Me.bar3.Offset = 74
            Me.bar3.Text = "Image"
            '
            'iVerticalFlip
            '
            Me.iVerticalFlip.Caption = "&Vertical Flip"
            Me.iVerticalFlip.CategoryGuid = New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")
            Me.iVerticalFlip.Hint = "Vertical Flip"
            Me.iVerticalFlip.Id = 6
            Me.iVerticalFlip.ImageIndex = 3
            Me.iVerticalFlip.Name = "iVerticalFlip"
            '
            'iRotateBy90
            '
            Me.iRotateBy90.Caption = "&Rotate by 90"
            Me.iRotateBy90.CategoryGuid = New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")
            Me.iRotateBy90.Hint = "Rotate by 90"
            Me.iRotateBy90.Id = 7
            Me.iRotateBy90.ImageIndex = 4
            Me.iRotateBy90.Name = "iRotateBy90"
            '
            'iPictureAlignment
            '
            Me.iPictureAlignment.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.iPictureAlignment.Caption = "Picture Alignment"
            Me.iPictureAlignment.CategoryGuid = New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")
            Me.iPictureAlignment.DropDownControl = Me.popupControlContainer1
            Me.iPictureAlignment.Id = 8
            Me.iPictureAlignment.Name = "iPictureAlignment"
            '
            'sizeMode
            '
            Me.sizeMode.Caption = "Size Mode:"
            Me.sizeMode.CategoryGuid = New System.Guid("fe2c529e-0920-415c-bb9e-16f91547b76f")
            Me.sizeMode.Edit = Me.repositoryItemImageComboBox1
            Me.sizeMode.Id = 25
            Me.sizeMode.Name = "sizeMode"
            Me.sizeMode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AllowFocused = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'bar4
            '
            Me.bar4.BarName = "Edit"
            Me.bar4.DockCol = 0
            Me.bar4.DockRow = 2
            Me.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar4.FloatLocation = New System.Drawing.Point(47, 222)
            Me.bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iCut), New DevExpress.XtraBars.LinkPersistInfo(Me.iCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.colorEdit, "", True, True, True, 111), New DevExpress.XtraBars.LinkPersistInfo(Me.iFont)})
            Me.bar4.Text = "Edit"
            '
            'iCut
            '
            Me.iCut.Caption = "Cu&t"
            Me.iCut.CategoryGuid = New System.Guid("2484205c-8785-4d92-a79d-d9d652073711")
            Me.iCut.Hint = "Cut"
            Me.iCut.Id = 15
            Me.iCut.ImageIndex = 9
            Me.iCut.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X))
            Me.iCut.Name = "iCut"
            '
            'iPaste
            '
            Me.iPaste.Caption = "&Paste"
            Me.iPaste.CategoryGuid = New System.Guid("2484205c-8785-4d92-a79d-d9d652073711")
            Me.iPaste.Hint = "Paste"
            Me.iPaste.Id = 17
            Me.iPaste.ImageIndex = 11
            Me.iPaste.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V))
            Me.iPaste.Name = "iPaste"
            '
            'colorEdit
            '
            Me.colorEdit.Caption = "Font Color:"
            Me.colorEdit.CategoryGuid = New System.Guid("2647ec04-72de-46d9-a06c-477510ca4f71")
            Me.colorEdit.Edit = Me.repositoryItemColorEdit1
            Me.colorEdit.Id = 24
            Me.colorEdit.Name = "colorEdit"
            Me.colorEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.colorEdit.Width = 20
            '
            'repositoryItemColorEdit1
            '
            Me.repositoryItemColorEdit1.AllowFocused = False
            Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
            '
            'iFont
            '
            Me.iFont.Caption = "Font..."
            Me.iFont.CategoryGuid = New System.Guid("2647ec04-72de-46d9-a06c-477510ca4f71")
            Me.iFont.Hint = "Font Dialog"
            Me.iFont.Id = 20
            Me.iFont.ImageIndex = 12
            Me.iFont.Name = "iFont"
            Me.iFont.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bar5
            '
            Me.bar5.BarName = "StatusBar"
            Me.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar5.DockCol = 0
            Me.bar5.DockRow = 0
            Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar5.FloatLocation = New System.Drawing.Point(59, 506)
            Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iDocName), New DevExpress.XtraBars.LinkPersistInfo(Me.iPicture)})
            Me.bar5.OptionsBar.AllowQuickCustomization = False
            Me.bar5.OptionsBar.DrawDragBorder = False
            Me.bar5.OptionsBar.DrawSizeGrip = True
            Me.bar5.OptionsBar.RotateWhenVertical = False
            Me.bar5.OptionsBar.UseWholeRow = True
            Me.bar5.Text = "StatusBar"
            '
            'iDocName
            '
            Me.iDocName.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
            Me.iDocName.CategoryGuid = New System.Guid("2827f321-90e1-4a0d-9bfa-bef5134ad8db")
            Me.iDocName.Id = 21
            Me.iDocName.Name = "iDocName"
            Me.iDocName.TextAlignment = System.Drawing.StringAlignment.Near
            Me.iDocName.Width = 522
            '
            'bar6
            '
            Me.bar6.BarName = "PaintStyle"
            Me.bar6.DockCol = 2
            Me.bar6.DockRow = 1
            Me.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iPaintStyle)})
            Me.bar6.Offset = 515
            Me.bar6.OptionsBar.AllowQuickCustomization = False
            Me.bar6.OptionsBar.RotateWhenVertical = False
            Me.bar6.Text = "PaintStyle"
            '
            'iPaintStyle
            '
            Me.iPaintStyle.Caption = "Paint Style"
            Me.iPaintStyle.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.iPaintStyle.Id = 25
            Me.iPaintStyle.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ipsDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsWXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsOXP), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO2K), New DevExpress.XtraBars.LinkPersistInfo(Me.ipsO2003)})
            Me.iPaintStyle.Name = "iPaintStyle"
            Me.iPaintStyle.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'ipsDefault
            '
            Me.ipsDefault.Caption = "Default"
            Me.ipsDefault.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.ipsDefault.Description = "Default"
            Me.ipsDefault.Id = 30
            Me.ipsDefault.Name = "ipsDefault"
            '
            'ipsWXP
            '
            Me.ipsWXP.Caption = "Windows XP"
            Me.ipsWXP.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.ipsWXP.Description = "WindowsXP"
            Me.ipsWXP.Id = 26
            Me.ipsWXP.ImageIndex = 17
            Me.ipsWXP.Name = "ipsWXP"
            '
            'ipsOXP
            '
            Me.ipsOXP.Caption = "Office XP"
            Me.ipsOXP.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.ipsOXP.Description = "OfficeXP"
            Me.ipsOXP.Id = 27
            Me.ipsOXP.ImageIndex = 15
            Me.ipsOXP.Name = "ipsOXP"
            '
            'ipsO2K
            '
            Me.ipsO2K.Caption = "Office 2000"
            Me.ipsO2K.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.ipsO2K.Description = "Office2000"
            Me.ipsO2K.Id = 28
            Me.ipsO2K.ImageIndex = 16
            Me.ipsO2K.Name = "ipsO2K"
            '
            'ipsO2003
            '
            Me.ipsO2003.Caption = "Office 2003"
            Me.ipsO2003.CategoryGuid = New System.Guid("cd6a5e26-77b5-4eca-9cc6-fbd0918eb85f")
            Me.ipsO2003.Description = "Office2003"
            Me.ipsO2003.Id = 29
            Me.ipsO2003.ImageIndex = 18
            Me.ipsO2003.Name = "ipsO2003"
            '
            'barDockControl1
            '
            Me.barDockControl1.CausesValidation = False
            Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControl1.Location = New System.Drawing.Point(0, 0)
            Me.barDockControl1.Size = New System.Drawing.Size(584, 79)
            '
            'barDockControl2
            '
            Me.barDockControl2.CausesValidation = False
            Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControl2.Location = New System.Drawing.Point(0, 344)
            Me.barDockControl2.Size = New System.Drawing.Size(584, 29)
            '
            'barDockControl3
            '
            Me.barDockControl3.CausesValidation = False
            Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControl3.Location = New System.Drawing.Point(0, 79)
            Me.barDockControl3.Size = New System.Drawing.Size(0, 265)
            '
            'barDockControl4
            '
            Me.barDockControl4.CausesValidation = False
            Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControl4.Location = New System.Drawing.Point(584, 79)
            Me.barDockControl4.Size = New System.Drawing.Size(0, 265)
            '
            'popupMenu2
            '
            Me.popupMenu2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iHorizontalFlip), New DevExpress.XtraBars.LinkPersistInfo(Me.iVerticalFlip), New DevExpress.XtraBars.LinkPersistInfo(Me.iRotateBy90)})
            Me.popupMenu2.Manager = Me.barManager1
            Me.popupMenu2.Name = "popupMenu2"
            '
            'popupMenu1
            '
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iCut), New DevExpress.XtraBars.LinkPersistInfo(Me.iCopy), New DevExpress.XtraBars.LinkPersistInfo(Me.iPaste), New DevExpress.XtraBars.LinkPersistInfo(Me.iSelectAll, True)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            Me.imageList2.Images.SetKeyName(5, "")
            Me.imageList2.Images.SetKeyName(6, "")
            Me.imageList2.Images.SetKeyName(7, "")
            Me.imageList2.Images.SetKeyName(8, "")
            Me.imageList2.Images.SetKeyName(9, "")
            Me.imageList2.Images.SetKeyName(10, "")
            Me.imageList2.Images.SetKeyName(11, "")
            Me.imageList2.Images.SetKeyName(12, "")
            Me.imageList2.Images.SetKeyName(13, "")
            Me.imageList2.Images.SetKeyName(14, "")
            Me.imageList2.Images.SetKeyName(15, "")
            Me.imageList2.Images.SetKeyName(16, "")
            Me.imageList2.Images.SetKeyName(17, "")
            Me.imageList2.Images.SetKeyName(18, "")
            '
            'xtraTabbedMdiManager1
            '
            Me.xtraTabbedMdiManager1.MdiParent = Nothing
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
            Me.ClientSize = New System.Drawing.Size(584, 373)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.barDockControl3)
            Me.Controls.Add(Me.barDockControl4)
            Me.Controls.Add(Me.barDockControl2)
            Me.Controls.Add(Me.barDockControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MDIDemo (VB Demo)"
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemColorEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private mFile As DevExpress.XtraBars.BarSubItem
		Private mHelp As DevExpress.XtraBars.BarSubItem
		Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents iHorizontalFlip As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iVerticalFlip As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iRotateBy90 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private iPictureAlignment As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCascade As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iTileHorizontal As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iTileVertical As DevExpress.XtraBars.BarButtonItem
		Private mWindow As DevExpress.XtraBars.BarSubItem
		Private WithEvents iWeb As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCut As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iCopy As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iPaste As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iSelectAll As DevExpress.XtraBars.BarButtonItem
		Private mEdit As DevExpress.XtraBars.BarSubItem
		Private WithEvents iFont As DevExpress.XtraBars.BarButtonItem
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private iDocName As DevExpress.XtraBars.BarStaticItem
		Private iPicture As DevExpress.XtraBars.BarStaticItem
		Private popupMenu2 As DevExpress.XtraBars.PopupMenu
		Private BarMdiChildrenListItem As DevExpress.XtraBars.BarMdiChildrenListItem
		Private WithEvents colorEdit As DevExpress.XtraBars.BarEditItem
		Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
		Private WithEvents sizeMode As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private bar1 As DevExpress.XtraBars.Bar
		Private bar2 As DevExpress.XtraBars.Bar
		Private bar3 As DevExpress.XtraBars.Bar
		Private bar4 As DevExpress.XtraBars.Bar
		Private bar5 As DevExpress.XtraBars.Bar
		Private bar6 As DevExpress.XtraBars.Bar
		Private iPaintStyle As DevExpress.XtraBars.BarSubItem
		Private WithEvents ipsWXP As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsOXP As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsO2K As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsO2003 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents ipsDefault As DevExpress.XtraBars.BarButtonItem
		Private imageList2 As System.Windows.Forms.ImageList
		Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private WithEvents biTabbedMDI As DevExpress.XtraBars.BarButtonItem
		Private WithEvents alignmentControl1 As DevExpress.Tutorials.Controls.AlignmentControl
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
