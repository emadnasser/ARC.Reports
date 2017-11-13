Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class PropertiesBase
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertiesBase))
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Build", 3, 3)
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Debugging")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Advanced")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuration Properties", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
            Me.multiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.multiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.multiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.multiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.multiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.multiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.multiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.multiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.multiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
            Me.repositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.tcMain = New DevExpress.XtraTab.XtraTabControl()
            Me.tabPage8 = New DevExpress.XtraTab.XtraTabPage()
            Me.vGridControl4 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.tabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.ImageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowTransmiss_Speed_Count = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowTransmiss_Automatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowMPG = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.rowPicture = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowIcon = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowHyperlink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowDelivery_Date = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.rowIs_In_Stock = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.tabPage5 = New DevExpress.XtraTab.XtraTabPage()
            Me.vGridControl2 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemImageComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.multiEditorRow2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.editorRow7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoryRow5 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.editorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.multiEditorRow3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
            Me.editorRow6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.categoryRow6 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
            Me.editorRow9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow11 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow12 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.editorRow13 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.tabPage7 = New DevExpress.XtraTab.XtraTabPage()
            Me.vGridControl3 = New DevExpress.XtraVerticalGrid.VGridControl()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.splitter2 = New DevExpress.XtraEditors.SplitterControl()
            Me.treeView1 = New System.Windows.Forms.TreeView()
            Me.imageList4 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
            Me.pnlLeft = New DevExpress.XtraEditors.PanelControl()
            Me.pnlMemo = New System.Windows.Forms.Panel()
            Me.label6 = New System.Windows.Forms.Label()
            Me.lbHint = New System.Windows.Forms.Label()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tcMain, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcMain.SuspendLayout()
            Me.tabPage8.SuspendLayout()
            CType(Me.vGridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage1.SuspendLayout()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ImageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage5.SuspendLayout()
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage7.SuspendLayout()
            CType(Me.vGridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLeft.SuspendLayout()
            Me.pnlMemo.SuspendLayout()
            Me.SuspendLayout()
            '
            'multiEditorRowProperties1
            '
            Me.multiEditorRowProperties1.Caption = "MPG City"
            Me.multiEditorRowProperties1.FieldName = "MPG City"
            Me.multiEditorRowProperties1.RowEdit = Me.repositoryItemSpinEdit1
            Me.multiEditorRowProperties1.Width = 17
            '
            'repositoryItemSpinEdit1
            '
            Me.repositoryItemSpinEdit1.AllowFocused = False
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            '
            'multiEditorRowProperties2
            '
            Me.multiEditorRowProperties2.Caption = "MPG Highway"
            Me.multiEditorRowProperties2.FieldName = "MPG Highway"
            Me.multiEditorRowProperties2.RowEdit = Me.repositoryItemSpinEdit1
            Me.multiEditorRowProperties2.Width = 23
            '
            'multiEditorRowProperties3
            '
            Me.multiEditorRowProperties3.Caption = "First Name"
            Me.multiEditorRowProperties3.FieldName = "FirstName"
            Me.multiEditorRowProperties3.Width = 22
            '
            'multiEditorRowProperties4
            '
            Me.multiEditorRowProperties4.Caption = "Last Name"
            Me.multiEditorRowProperties4.FieldName = "LastName"
            Me.multiEditorRowProperties4.Width = 18
            '
            'multiEditorRowProperties5
            '
            Me.multiEditorRowProperties5.Caption = "Occupation"
            Me.multiEditorRowProperties5.FieldName = "Occupation"
            '
            'multiEditorRowProperties6
            '
            Me.multiEditorRowProperties6.Caption = "Risk Level"
            Me.multiEditorRowProperties6.FieldName = "RiskLevel"
            Me.multiEditorRowProperties6.RowEdit = Me.repositoryItemImageComboBox4
            '
            'repositoryItemImageComboBox4
            '
            Me.repositoryItemImageComboBox4.AllowFocused = False
            Me.repositoryItemImageComboBox4.AutoHeight = False
            Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox4.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 6), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 8)})
            Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
            Me.repositoryItemImageComboBox4.SmallImages = Me.imageList1
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
            '
            'multiEditorRowProperties7
            '
            Me.multiEditorRowProperties7.Caption = "City"
            Me.multiEditorRowProperties7.FieldName = "City"
            Me.multiEditorRowProperties7.Width = 18
            '
            'multiEditorRowProperties8
            '
            Me.multiEditorRowProperties8.Caption = "State"
            Me.multiEditorRowProperties8.FieldName = "State"
            Me.multiEditorRowProperties8.RowEdit = Me.repositoryItemComboBox1
            Me.multiEditorRowProperties8.Width = 18
            '
            'repositoryItemComboBox1
            '
            Me.repositoryItemComboBox1.AllowFocused = False
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"CA", "CT", "GA", "IL", "MI", "NJ", "NY", "OH", "OK"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            '
            'multiEditorRowProperties9
            '
            Me.multiEditorRowProperties9.Caption = "Zip Code"
            Me.multiEditorRowProperties9.FieldName = "ZipCode"
            Me.multiEditorRowProperties9.RowEdit = Me.repositoryItemTextEdit5
            Me.multiEditorRowProperties9.Width = 24
            '
            'repositoryItemTextEdit5
            '
            Me.repositoryItemTextEdit5.AllowFocused = False
            Me.repositoryItemTextEdit5.AutoHeight = False
            Me.repositoryItemTextEdit5.Mask.EditMask = "00000"
            Me.repositoryItemTextEdit5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.repositoryItemTextEdit5.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(48)
            Me.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5"
            '
            'tcMain
            '
            Me.tcMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcMain.Location = New System.Drawing.Point(209, 0)
            Me.tcMain.Name = "tcMain"
            Me.tcMain.SelectedTabPage = Me.tabPage8
            Me.tcMain.Size = New System.Drawing.Size(595, 488)
            Me.tcMain.TabIndex = 0
            Me.tcMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPage1, Me.tabPage5, Me.tabPage7, Me.tabPage8})
            '
            'tabPage8
            '
            Me.tabPage8.Controls.Add(Me.vGridControl4)
            Me.tabPage8.Name = "tabPage8"
            Me.tabPage8.Padding = New System.Windows.Forms.Padding(4)
            Me.tabPage8.Size = New System.Drawing.Size(589, 460)
            Me.tabPage8.Text = "Demo Binding"
            '
            'vGridControl4
            '
            Me.vGridControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.vGridControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl4.Location = New System.Drawing.Point(4, 4)
            Me.vGridControl4.Name = "vGridControl4"
            Me.vGridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit4})
            Me.vGridControl4.Size = New System.Drawing.Size(581, 452)
            Me.vGridControl4.TabIndex = 0
            Me.vGridControl4.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
            '
            'repositoryItemTextEdit4
            '
            Me.repositoryItemTextEdit4.AllowFocused = False
            Me.repositoryItemTextEdit4.AutoHeight = False
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            '
            'tabPage1
            '
            Me.tabPage1.Controls.Add(Me.vGridControl1)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(4)
            Me.tabPage1.Size = New System.Drawing.Size(589, 460)
            Me.tabPage1.Text = "Data Binding"
            '
            'vGridControl1
            '
            Me.vGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.ImageList = Me.imageCollection1
            Me.vGridControl1.Location = New System.Drawing.Point(4, 4)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemButtonEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemMemoEdit1, Me.repositoryItemHyperLinkEdit1, Me.repositoryItemRadioGroup1})
            Me.vGridControl1.RowHeaderWidth = 190
            Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowCategory, Me.categoryRow1, Me.categoryRow2, Me.categoryRow3})
            Me.vGridControl1.Size = New System.Drawing.Size(581, 452)
            Me.vGridControl1.TabIndex = 0
            Me.vGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.InsertGalleryImage("notes_16x16.png", "images/content/notes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/notes_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "notes_16x16.png")
            Me.imageCollection1.InsertGalleryImage("image_16x16.png", "images/content/image_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/image_16x16.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "image_16x16.png")
            Me.imageCollection1.InsertGalleryImage("feature_16x16.png", "images/support/feature_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/support/feature_16x16.png"), 2)
            Me.imageCollection1.Images.SetKeyName(2, "feature_16x16.png")
            Me.imageCollection1.InsertGalleryImage("contact_16x16.png", "images/mail/contact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/contact_16x16.png"), 3)
            Me.imageCollection1.Images.SetKeyName(3, "contact_16x16.png")
            Me.imageCollection1.InsertGalleryImage("home_16x16.png", "images/navigation/home_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_16x16.png"), 4)
            Me.imageCollection1.Images.SetKeyName(4, "home_16x16.png")
            '
            'repositoryItemPictureEdit1
            '
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            '
            'repositoryItemImageEdit1
            '
            Me.repositoryItemImageEdit1.AllowFocused = False
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            '
            'repositoryItemMemoExEdit1
            '
            Me.repositoryItemMemoExEdit1.AllowFocused = False
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            '
            'repositoryItemCalcEdit1
            '
            Me.repositoryItemCalcEdit1.AllowFocused = False
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            '
            'repositoryItemButtonEdit1
            '
            Me.repositoryItemButtonEdit1.AllowFocused = False
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AllowFocused = False
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 4)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageList1
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AllowFocused = False
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yes", "Yes", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No", "No", 1)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.ImageCollection3
            '
            'ImageCollection3
            '
            Me.ImageCollection3.ImageStream = CType(resources.GetObject("ImageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.ImageCollection3.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0)
            Me.ImageCollection3.Images.SetKeyName(0, "apply_16x16.png")
            Me.ImageCollection3.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 1)
            Me.ImageCollection3.Images.SetKeyName(1, "cancel_16x16.png")
            '
            'repositoryItemMemoEdit1
            '
            Me.repositoryItemMemoEdit1.AllowFocused = False
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            '
            'repositoryItemHyperLinkEdit1
            '
            Me.repositoryItemHyperLinkEdit1.AutoHeight = False
            Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
            '
            'repositoryItemRadioGroup1
            '
            Me.repositoryItemRadioGroup1.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Yes", "Yes"), New DevExpress.XtraEditors.Controls.RadioGroupItem("No", "No")})
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            '
            'rowID
            '
            Me.rowID.Height = 16
            Me.rowID.Name = "rowID"
            Me.rowID.Properties.Caption = "Record ID"
            Me.rowID.Properties.FieldName = "ID"
            '
            'rowTrademark
            '
            Me.rowTrademark.Name = "rowTrademark"
            Me.rowTrademark.Properties.Caption = "Trademark"
            Me.rowTrademark.Properties.FieldName = "Trademark"
            Me.rowTrademark.Properties.RowEdit = Me.repositoryItemButtonEdit1
            '
            'rowModel
            '
            Me.rowModel.Height = 16
            Me.rowModel.Name = "rowModel"
            Me.rowModel.Properties.Caption = "Model"
            Me.rowModel.Properties.FieldName = "Model"
            Me.rowModel.Properties.ImageIndex = 2
            '
            'rowCategory
            '
            Me.rowCategory.Height = 19
            Me.rowCategory.Name = "rowCategory"
            Me.rowCategory.Properties.Caption = "Category"
            Me.rowCategory.Properties.FieldName = "Category"
            Me.rowCategory.Properties.RowEdit = Me.repositoryItemImageComboBox1
            '
            'categoryRow1
            '
            Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmiss_Speed_Count, Me.rowTransmiss_Automatic, Me.rowMPG})
            Me.categoryRow1.Name = "categoryRow1"
            Me.categoryRow1.Properties.Caption = "Performance Attributes"
            '
            'rowHP
            '
            Me.rowHP.Name = "rowHP"
            Me.rowHP.Properties.Caption = "HP"
            Me.rowHP.Properties.FieldName = "HP"
            '
            'rowLiter
            '
            Me.rowLiter.Name = "rowLiter"
            Me.rowLiter.Properties.Caption = "Capacity"
            Me.rowLiter.Properties.FieldName = "Liter"
            Me.rowLiter.Properties.Format.FormatString = "#.### Liters"
            Me.rowLiter.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            '
            'rowCyl
            '
            Me.rowCyl.Name = "rowCyl"
            Me.rowCyl.Properties.Caption = "Cyl"
            Me.rowCyl.Properties.FieldName = "Cyl"
            Me.rowCyl.Properties.RowEdit = Me.repositoryItemSpinEdit1
            '
            'rowTransmiss_Speed_Count
            '
            Me.rowTransmiss_Speed_Count.Name = "rowTransmiss_Speed_Count"
            Me.rowTransmiss_Speed_Count.Properties.Caption = "# of Gears"
            Me.rowTransmiss_Speed_Count.Properties.FieldName = "Transmiss Speed Count"
            Me.rowTransmiss_Speed_Count.Properties.RowEdit = Me.repositoryItemSpinEdit1
            '
            'rowTransmiss_Automatic
            '
            Me.rowTransmiss_Automatic.Name = "rowTransmiss_Automatic"
            Me.rowTransmiss_Automatic.Properties.Caption = "Automatic Transmission"
            Me.rowTransmiss_Automatic.Properties.FieldName = "Transmiss Automatic"
            Me.rowTransmiss_Automatic.Properties.RowEdit = Me.repositoryItemRadioGroup1
            '
            'rowMPG
            '
            Me.rowMPG.Name = "rowMPG"
            Me.rowMPG.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties1, Me.multiEditorRowProperties2})
            '
            'categoryRow2
            '
            Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPicture, Me.rowDescription, Me.rowHyperlink})
            Me.categoryRow2.Name = "categoryRow2"
            Me.categoryRow2.Properties.Caption = "Notes"
            Me.categoryRow2.Properties.ImageIndex = 0
            '
            'rowPicture
            '
            Me.rowPicture.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIcon})
            Me.rowPicture.Name = "rowPicture"
            Me.rowPicture.Properties.Caption = "Picture"
            Me.rowPicture.Properties.FieldName = "Picture"
            Me.rowPicture.Properties.RowEdit = Me.repositoryItemImageEdit1
            '
            'rowIcon
            '
            Me.rowIcon.Height = 52
            Me.rowIcon.Name = "rowIcon"
            Me.rowIcon.Properties.Caption = "Icon"
            Me.rowIcon.Properties.FieldName = "Icon"
            Me.rowIcon.Properties.ImageIndex = 1
            Me.rowIcon.Properties.RowEdit = Me.repositoryItemPictureEdit1
            '
            'rowDescription
            '
            Me.rowDescription.Name = "rowDescription"
            Me.rowDescription.Properties.Caption = "Description"
            Me.rowDescription.Properties.FieldName = "Description"
            Me.rowDescription.Properties.RowEdit = Me.repositoryItemMemoExEdit1
            '
            'rowHyperlink
            '
            Me.rowHyperlink.Name = "rowHyperlink"
            Me.rowHyperlink.Properties.Caption = "Hyperlink"
            Me.rowHyperlink.Properties.FieldName = "Hyperlink"
            Me.rowHyperlink.Properties.RowEdit = Me.repositoryItemHyperLinkEdit1
            '
            'categoryRow3
            '
            Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPrice, Me.rowDelivery_Date, Me.rowIs_In_Stock})
            Me.categoryRow3.Name = "categoryRow3"
            Me.categoryRow3.Properties.Caption = "Others"
            '
            'rowPrice
            '
            Me.rowPrice.Name = "rowPrice"
            Me.rowPrice.Properties.Caption = "Price"
            Me.rowPrice.Properties.FieldName = "Price"
            Me.rowPrice.Properties.Format.FormatString = "c"
            Me.rowPrice.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.rowPrice.Properties.RowEdit = Me.repositoryItemCalcEdit1
            '
            'rowDelivery_Date
            '
            Me.rowDelivery_Date.Name = "rowDelivery_Date"
            Me.rowDelivery_Date.Properties.Caption = "Delivery Date"
            Me.rowDelivery_Date.Properties.FieldName = "Delivery Date"
            '
            'rowIs_In_Stock
            '
            Me.rowIs_In_Stock.Name = "rowIs_In_Stock"
            Me.rowIs_In_Stock.Properties.Caption = "In Stock?"
            Me.rowIs_In_Stock.Properties.FieldName = "Is In Stock"
            '
            'tabPage5
            '
            Me.tabPage5.Controls.Add(Me.vGridControl2)
            Me.tabPage5.Name = "tabPage5"
            Me.tabPage5.Padding = New System.Windows.Forms.Padding(4)
            Me.tabPage5.Size = New System.Drawing.Size(589, 460)
            Me.tabPage5.Text = "Simple Mode"
            '
            'vGridControl2
            '
            Me.vGridControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.vGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl2.ImageList = Me.imageCollection1
            Me.vGridControl2.Location = New System.Drawing.Point(4, 4)
            Me.vGridControl2.Name = "vGridControl2"
            Me.vGridControl2.RecordWidth = 198
            Me.vGridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4, Me.repositoryItemMemoEdit2, Me.repositoryItemComboBox1, Me.repositoryItemTextEdit5, Me.repositoryItemTextEdit6, Me.repositoryItemImageComboBox5, Me.repositoryItemSpinEdit2, Me.repositoryItemLookUpEdit1})
            Me.vGridControl2.RowHeaderWidth = 194
            Me.vGridControl2.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryRow4, Me.categoryRow5, Me.categoryRow6})
            Me.vGridControl2.Size = New System.Drawing.Size(581, 452)
            Me.vGridControl2.TabIndex = 0
            Me.vGridControl2.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
            '
            'repositoryItemImageComboBox3
            '
            Me.repositoryItemImageComboBox3.AllowFocused = False
            Me.repositoryItemImageComboBox3.AutoHeight = False
            Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Male", "M", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Female", "F", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unknown", "N", -1)})
            Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
            '
            'repositoryItemMemoEdit2
            '
            Me.repositoryItemMemoEdit2.AllowFocused = False
            Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
            '
            'repositoryItemTextEdit6
            '
            Me.repositoryItemTextEdit6.AllowFocused = False
            Me.repositoryItemTextEdit6.AutoHeight = False
            Me.repositoryItemTextEdit6.Mask.EditMask = "(999)000-00-00"
            Me.repositoryItemTextEdit6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
            Me.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6"
            '
            'repositoryItemImageComboBox5
            '
            Me.repositoryItemImageComboBox5.AllowFocused = False
            Me.repositoryItemImageComboBox5.AutoHeight = False
            Me.repositoryItemImageComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox5.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Visa", "VS", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("American Express", "AM", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Master", "MS", 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Cash", "CS", 1)})
            Me.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5"
            Me.repositoryItemImageComboBox5.SmallImages = Me.imageCollection2
            '
            'imageCollection2
            '
            Me.imageCollection2.ImageSize = New System.Drawing.Size(24, 16)
            Me.imageCollection2.ImageStream = CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection2.Images.SetKeyName(0, "amex.png")
            Me.imageCollection2.Images.SetKeyName(1, "cash.png")
            Me.imageCollection2.Images.SetKeyName(2, "master.png")
            Me.imageCollection2.Images.SetKeyName(3, "visa.png")
            '
            'repositoryItemSpinEdit2
            '
            Me.repositoryItemSpinEdit2.AllowFocused = False
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            '
            'repositoryItemLookUpEdit1
            '
            Me.repositoryItemLookUpEdit1.AllowFocused = False
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", 40, "Product"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 120, "Description")})
            Me.repositoryItemLookUpEdit1.DisplayMember = "Name"
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 350
            Me.repositoryItemLookUpEdit1.ValueMember = "ID"
            '
            'categoryRow4
            '
            Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.editorRow1, Me.multiEditorRow1, Me.editorRow2, Me.editorRow3, Me.editorRow5, Me.multiEditorRow2, Me.editorRow7, Me.editorRow8})
            Me.categoryRow4.Name = "categoryRow4"
            Me.categoryRow4.Properties.Caption = "Client"
            Me.categoryRow4.Properties.ImageIndex = 3
            '
            'editorRow1
            '
            Me.editorRow1.Name = "editorRow1"
            Me.editorRow1.Properties.Caption = "Client ID"
            Me.editorRow1.Properties.FieldName = "ClientID"
            '
            'multiEditorRow1
            '
            Me.multiEditorRow1.Name = "multiEditorRow1"
            Me.multiEditorRow1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties3, Me.multiEditorRowProperties4})
            '
            'editorRow2
            '
            Me.editorRow2.Name = "editorRow2"
            Me.editorRow2.Properties.Caption = "Company Name"
            Me.editorRow2.Properties.FieldName = "CompanyName"
            '
            'editorRow3
            '
            Me.editorRow3.Name = "editorRow3"
            Me.editorRow3.Properties.Caption = "Customer"
            Me.editorRow3.Properties.FieldName = "Customer"
            '
            'editorRow5
            '
            Me.editorRow5.Name = "editorRow5"
            Me.editorRow5.Properties.Caption = "Gender"
            Me.editorRow5.Properties.FieldName = "Gender"
            Me.editorRow5.Properties.RowEdit = Me.repositoryItemImageComboBox3
            '
            'multiEditorRow2
            '
            Me.multiEditorRow2.Name = "multiEditorRow2"
            Me.multiEditorRow2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties5, Me.multiEditorRowProperties6})
            '
            'editorRow7
            '
            Me.editorRow7.Height = 45
            Me.editorRow7.Name = "editorRow7"
            Me.editorRow7.Properties.Caption = "Interest (Ctrl+Enter - close editor)"
            Me.editorRow7.Properties.FieldName = "Interest"
            Me.editorRow7.Properties.RowEdit = Me.repositoryItemMemoEdit2
            '
            'editorRow8
            '
            Me.editorRow8.Name = "editorRow8"
            Me.editorRow8.Properties.Caption = "Date Open"
            Me.editorRow8.Properties.FieldName = "DateOpen"
            '
            'categoryRow5
            '
            Me.categoryRow5.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.editorRow4, Me.multiEditorRow3, Me.editorRow6})
            Me.categoryRow5.Name = "categoryRow5"
            Me.categoryRow5.Properties.Caption = "Address"
            '
            'editorRow4
            '
            Me.editorRow4.Name = "editorRow4"
            Me.editorRow4.Properties.Caption = "Address"
            Me.editorRow4.Properties.FieldName = "Address"
            Me.editorRow4.Properties.ImageIndex = 4
            '
            'multiEditorRow3
            '
            Me.multiEditorRow3.Name = "multiEditorRow3"
            Me.multiEditorRow3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.multiEditorRowProperties7, Me.multiEditorRowProperties8, Me.multiEditorRowProperties9})
            '
            'editorRow6
            '
            Me.editorRow6.Name = "editorRow6"
            Me.editorRow6.Properties.Caption = "Phone"
            Me.editorRow6.Properties.FieldName = "Phone"
            Me.editorRow6.Properties.RowEdit = Me.repositoryItemTextEdit6
            '
            'categoryRow6
            '
            Me.categoryRow6.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.editorRow9, Me.editorRow10, Me.editorRow11, Me.editorRow12, Me.editorRow13})
            Me.categoryRow6.Name = "categoryRow6"
            Me.categoryRow6.Properties.Caption = "Payment Information"
            '
            'editorRow9
            '
            Me.editorRow9.Name = "editorRow9"
            Me.editorRow9.Properties.Caption = "Payment Type"
            Me.editorRow9.Properties.FieldName = "PaymentType"
            Me.editorRow9.Properties.RowEdit = Me.repositoryItemImageComboBox5
            '
            'editorRow10
            '
            Me.editorRow10.Name = "editorRow10"
            Me.editorRow10.Properties.Caption = "Payment Amount"
            Me.editorRow10.Properties.FieldName = "PaymentAmount"
            Me.editorRow10.Properties.Format.FormatString = "c"
            Me.editorRow10.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.editorRow10.Properties.RowEdit = Me.repositoryItemSpinEdit2
            '
            'editorRow11
            '
            Me.editorRow11.Name = "editorRow11"
            Me.editorRow11.Properties.Caption = "Payment Date"
            Me.editorRow11.Properties.FieldName = "PaymentDate"
            '
            'editorRow12
            '
            Me.editorRow12.Name = "editorRow12"
            Me.editorRow12.Properties.Caption = "Product"
            Me.editorRow12.Properties.FieldName = "ProductID"
            Me.editorRow12.Properties.RowEdit = Me.repositoryItemLookUpEdit1
            '
            'editorRow13
            '
            Me.editorRow13.Name = "editorRow13"
            Me.editorRow13.Properties.Caption = "Copies"
            Me.editorRow13.Properties.FieldName = "Copies"
            Me.editorRow13.Properties.RowEdit = Me.repositoryItemSpinEdit2
            '
            'tabPage7
            '
            Me.tabPage7.Controls.Add(Me.vGridControl3)
            Me.tabPage7.Controls.Add(Me.splitter2)
            Me.tabPage7.Controls.Add(Me.treeView1)
            Me.tabPage7.Name = "tabPage7"
            Me.tabPage7.Padding = New System.Windows.Forms.Padding(4)
            Me.tabPage7.Size = New System.Drawing.Size(589, 460)
            Me.tabPage7.Text = "Runtime Row Creation"
            '
            'vGridControl3
            '
            Me.vGridControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.vGridControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl3.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
            Me.vGridControl3.Location = New System.Drawing.Point(157, 4)
            Me.vGridControl3.Name = "vGridControl3"
            Me.vGridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit3})
            Me.vGridControl3.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
            Me.vGridControl3.Size = New System.Drawing.Size(428, 452)
            Me.vGridControl3.TabIndex = 0
            Me.vGridControl3.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.ExplorerBar
            '
            'repositoryItemTextEdit3
            '
            Me.repositoryItemTextEdit3.AllowFocused = False
            Me.repositoryItemTextEdit3.AutoHeight = False
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            '
            'splitter2
            '
            Me.splitter2.Location = New System.Drawing.Point(152, 4)
            Me.splitter2.Name = "splitter2"
            Me.splitter2.Size = New System.Drawing.Size(5, 452)
            Me.splitter2.TabIndex = 2
            Me.splitter2.TabStop = False
            '
            'treeView1
            '
            Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeView1.ImageIndex = 0
            Me.treeView1.ImageList = Me.imageList4
            Me.treeView1.Location = New System.Drawing.Point(4, 4)
            Me.treeView1.Name = "treeView1"
            TreeNode1.ImageIndex = 3
            TreeNode1.Name = ""
            TreeNode1.SelectedImageIndex = 3
            TreeNode1.Text = "Build"
            TreeNode2.Name = ""
            TreeNode2.Text = "Debugging"
            TreeNode3.Name = ""
            TreeNode3.Text = "Advanced"
            TreeNode4.ImageIndex = 1
            TreeNode4.Name = ""
            TreeNode4.SelectedImageIndex = 1
            TreeNode4.Text = "Configuration Properties"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
            Me.treeView1.SelectedImageIndex = 0
            Me.treeView1.ShowLines = False
            Me.treeView1.ShowPlusMinus = False
            Me.treeView1.Size = New System.Drawing.Size(148, 452)
            Me.treeView1.TabIndex = 1
            '
            'imageList4
            '
            Me.imageList4.ImageStream = CType(resources.GetObject("imageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList4.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList4.Images.SetKeyName(0, "")
            Me.imageList4.Images.SetKeyName(1, "")
            Me.imageList4.Images.SetKeyName(2, "")
            Me.imageList4.Images.SetKeyName(3, "")
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(204, 0)
            Me.splitter1.MinSize = 200
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(5, 488)
            Me.splitter1.TabIndex = 2
            Me.splitter1.TabStop = False
            '
            'pnlLeft
            '
            Me.pnlLeft.Controls.Add(Me.pnlMemo)
            Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
            Me.pnlLeft.Name = "pnlLeft"
            Me.pnlLeft.Size = New System.Drawing.Size(204, 488)
            Me.pnlLeft.TabIndex = 4
            '
            'pnlMemo
            '
            Me.pnlMemo.Controls.Add(Me.label6)
            Me.pnlMemo.Controls.Add(Me.lbHint)
            Me.pnlMemo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlMemo.Location = New System.Drawing.Point(2, 398)
            Me.pnlMemo.Name = "pnlMemo"
            Me.pnlMemo.Size = New System.Drawing.Size(200, 88)
            Me.pnlMemo.TabIndex = 2
            '
            'label6
            '
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.Location = New System.Drawing.Point(4, 4)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(20, 24)
            Me.label6.TabIndex = 4
            '
            'lbHint
            '
            Me.lbHint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lbHint.Location = New System.Drawing.Point(28, 8)
            Me.lbHint.Name = "lbHint"
            Me.lbHint.Size = New System.Drawing.Size(168, 76)
            Me.lbHint.TabIndex = 3
            '
            'PropertiesBase
            '
            Me.Controls.Add(Me.tcMain)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.pnlLeft)
            Me.Name = "PropertiesBase"
            Me.Size = New System.Drawing.Size(804, 488)
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tcMain, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcMain.ResumeLayout(False)
            Me.tabPage8.ResumeLayout(False)
            CType(Me.vGridControl4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage1.ResumeLayout(False)
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ImageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage5.ResumeLayout(False)
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage7.ResumeLayout(False)
            CType(Me.vGridControl3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLeft.ResumeLayout(False)
            Me.pnlMemo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region
		Private WithEvents tcMain As XtraTabControl
		Private tabPage1 As XtraTabPage
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private components As System.ComponentModel.IContainer
		Private tabPage5 As XtraTabPage
		Private WithEvents vGridControl2 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Protected repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Protected repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private tabPage7 As XtraTabPage
		Private tabPage8 As XtraTabPage
		Private WithEvents vGridControl3 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private WithEvents vGridControl4 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Protected repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private rowID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowModel As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowHP As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowLiter As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCyl As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Speed_Count As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmiss_Automatic As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowMPG As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowIcon As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowPicture As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowHyperlink As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDelivery_Date As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowIs_In_Stock As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Protected imageList2 As System.Windows.Forms.ImageList
		Protected pnlLeft As PanelControl
		Private pnlMemo As System.Windows.Forms.Panel
		Private label6 As System.Windows.Forms.Label
		Private lbHint As System.Windows.Forms.Label
		Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private repositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemImageComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private imageList4 As System.Windows.Forms.ImageList
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private splitter2 As DevExpress.XtraEditors.SplitterControl
        Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow5 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow6 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow11 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow12 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow13 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Protected repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Friend WithEvents multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Friend WithEvents multiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
        Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
        Private WithEvents imageCollection2 As DevExpress.Utils.ImageCollection
        Friend WithEvents ImageCollection3 As DevExpress.Utils.ImageCollection
	End Class
End Namespace
