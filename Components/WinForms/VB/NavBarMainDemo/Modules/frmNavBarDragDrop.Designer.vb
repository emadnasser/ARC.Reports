Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarDragDrop
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
			Dim listViewItem1 As New ListViewItem(New String() { "GridControl"}, 19, SystemColors.WindowText, SystemColors.Window, New Font("Microsoft Sans Serif", 8.25F))
			Dim listViewItem2 As New ListViewItem(New String() { "TreeList"}, 22, SystemColors.WindowText, SystemColors.Window, New Font("Microsoft Sans Serif", 8.25F))
			Dim listViewItem3 As New ListViewItem(New String() { "NavBarControl"}, 23, SystemColors.WindowText, SystemColors.Window, New Font("Microsoft Sans Serif", 8.25F))
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmNavBarDragDrop))
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem8 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem9 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem10 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem11 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem13 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem14 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem15 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem20 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem23 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem16 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem21 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem18 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem17 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem19 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem24 = New DevExpress.XtraNavBar.NavBarItem()
			Me.imageList1 = New ImageList(Me.components)
			Me.listView1 = New ListView()
			Me.lbRecycle = New DevExpress.XtraEditors.LabelControl()
			Me.imageList2 = New ImageList(Me.components)
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAllowOuterDrop = New DevExpress.XtraEditors.CheckEdit()
			Me.ceAllowDrop = New DevExpress.XtraEditors.CheckEdit()
			Me.ceAllowDrag = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contentPanel_Renamed.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.ceAllowOuterDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowDrop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceAllowDrag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' contentPanel
			' 
			Me.contentPanel_Renamed.Controls.Add(Me.groupControl3)
			Me.contentPanel_Renamed.Controls.Add(Me.groupControl2)
			Me.contentPanel_Renamed.Controls.Add(Me.groupControl1)
			Me.contentPanel_Renamed.Controls.Add(Me.navBarControl1)
			Me.contentPanel_Renamed.Size = New Size(624, 425)
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.DragDropFlags = (CType(((DevExpress.XtraNavBar.NavBarDragDrop.AllowDrag Or DevExpress.XtraNavBar.NavBarDragDrop.AllowDrop) Or DevExpress.XtraNavBar.NavBarDragDrop.AllowOuterDrop), DevExpress.XtraNavBar.NavBarDragDrop))
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3, Me.navBarGroup4})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem5, Me.navBarItem6, Me.navBarItem8, Me.navBarItem9, Me.navBarItem10, Me.navBarItem11, Me.navBarItem13, Me.navBarItem14, Me.navBarItem15, Me.navBarItem16, Me.navBarItem17, Me.navBarItem18, Me.navBarItem19, Me.navBarItem20, Me.navBarItem21, Me.navBarItem23, Me.navBarItem24})
			Me.navBarControl1.Location = New Point(5, 5)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 172
			Me.navBarControl1.Size = New Size(172, 417)
			Me.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
			Me.navBarControl1.SmallImages = Me.imageList1
			Me.navBarControl1.StoreDefaultPaintStyleName = True
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
'			Me.navBarControl1.NavDragOver += New DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventHandler(Me.navBarControl1_NavDragOver)
'			Me.navBarControl1.NavDragDrop += New DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventHandler(Me.navBarControl1_NavDragDrop)
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Windows Forms"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem8), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem9), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem10), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem11), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem13), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem14), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem15)})
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "Label"
			Me.navBarItem6.Name = "navBarItem6"
			Me.navBarItem6.SmallImageIndex = 5
			' 
			' navBarItem8
			' 
			Me.navBarItem8.Caption = "Button"
			Me.navBarItem8.Name = "navBarItem8"
			Me.navBarItem8.SmallImageIndex = 7
			' 
			' navBarItem9
			' 
			Me.navBarItem9.Caption = "TextBox"
			Me.navBarItem9.Name = "navBarItem9"
			Me.navBarItem9.SmallImageIndex = 8
			' 
			' navBarItem10
			' 
			Me.navBarItem10.Caption = "MainMenu"
			Me.navBarItem10.Name = "navBarItem10"
			Me.navBarItem10.SmallImageIndex = 9
			' 
			' navBarItem11
			' 
			Me.navBarItem11.Caption = "CheckBox"
			Me.navBarItem11.Name = "navBarItem11"
			Me.navBarItem11.SmallImageIndex = 10
			' 
			' navBarItem13
			' 
			Me.navBarItem13.Caption = "GroupBox"
			Me.navBarItem13.Enabled = False
			Me.navBarItem13.Name = "navBarItem13"
			Me.navBarItem13.SmallImageIndex = 12
			' 
			' navBarItem14
			' 
			Me.navBarItem14.Caption = "PictureBox"
			Me.navBarItem14.Enabled = False
			Me.navBarItem14.Name = "navBarItem14"
			Me.navBarItem14.SmallImageIndex = 13
			' 
			' navBarItem15
			' 
			Me.navBarItem15.Caption = "Panel"
			Me.navBarItem15.Name = "navBarItem15"
			Me.navBarItem15.SmallImageIndex = 14
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Components"
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "FileSystemWatcher"
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 0
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "DirectoryEntry"
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 1
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "DirectorySearcher"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 2
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "Timer"
			Me.navBarItem5.Name = "navBarItem5"
			Me.navBarItem5.SmallImageIndex = 4
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.AppearanceHotTracked.Font = New Font("Tahoma", 8.25F, (CType((FontStyle.Bold Or FontStyle.Underline), FontStyle)), GraphicsUnit.Point, (CByte(204)))
			Me.navBarGroup3.AppearanceHotTracked.ForeColor = Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(192)))))
			Me.navBarGroup3.AppearanceHotTracked.Options.UseFont = True
			Me.navBarGroup3.AppearanceHotTracked.Options.UseForeColor = True
			Me.navBarGroup3.Caption = "Xtra Products"
			Me.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem20), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem23), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem16), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem21), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem18), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem17), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem19)})
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' navBarItem20
			' 
			Me.navBarItem20.Caption = "GridControl"
			Me.navBarItem20.Name = "navBarItem20"
			Me.navBarItem20.SmallImageIndex = 19
			' 
			' navBarItem23
			' 
			Me.navBarItem23.Caption = "TreeList"
			Me.navBarItem23.Name = "navBarItem23"
			Me.navBarItem23.SmallImageIndex = 22
			' 
			' navBarItem16
			' 
			Me.navBarItem16.Caption = "BarManager"
			Me.navBarItem16.Name = "navBarItem16"
			Me.navBarItem16.SmallImageIndex = 15
			' 
			' navBarItem21
			' 
			Me.navBarItem21.Caption = "PrintControl"
			Me.navBarItem21.Name = "navBarItem21"
			Me.navBarItem21.SmallImageIndex = 20
			' 
			' navBarItem18
			' 
			Me.navBarItem18.Caption = "ButtonEdit"
			Me.navBarItem18.Name = "navBarItem18"
			Me.navBarItem18.SmallImageIndex = 17
			' 
			' navBarItem17
			' 
			Me.navBarItem17.Caption = "CalcEdit"
			Me.navBarItem17.Name = "navBarItem17"
			Me.navBarItem17.SmallImageIndex = 16
			' 
			' navBarItem19
			' 
			Me.navBarItem19.Caption = "DataNavigator"
			Me.navBarItem19.Name = "navBarItem19"
			Me.navBarItem19.SmallImageIndex = 18
			' 
			' navBarGroup4
			' 
			Me.navBarGroup4.Caption = "Temp"
			Me.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
			Me.navBarGroup4.Name = "navBarGroup4"
			' 
			' navBarItem24
			' 
			Me.navBarItem24.Caption = "NavBarControl"
			Me.navBarItem24.Name = "navBarItem24"
			Me.navBarItem24.SmallImageIndex = 23
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
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
			Me.imageList1.Images.SetKeyName(19, "")
			Me.imageList1.Images.SetKeyName(20, "")
			Me.imageList1.Images.SetKeyName(21, "")
			Me.imageList1.Images.SetKeyName(22, "")
			Me.imageList1.Images.SetKeyName(23, "")
			' 
			' listView1
			' 
			Me.listView1.AllowDrop = True
			Me.listView1.BorderStyle = BorderStyle.None
			Me.listView1.Dock = DockStyle.Fill
			Me.listView1.Items.AddRange(New ListViewItem() { listViewItem1, listViewItem2, listViewItem3})
			Me.listView1.Location = New Point(2, 21)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New Size(408, 97)
			Me.listView1.SmallImageList = Me.imageList1
			Me.listView1.TabIndex = 1
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = View.SmallIcon
'			Me.listView1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.listView1_DragDrop)
'			Me.listView1.DragEnter += New System.Windows.Forms.DragEventHandler(Me.listView1_DragEnter)
'			Me.listView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.listView1_MouseDown)
'			Me.listView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.listView1_MouseMove)
			' 
			' lbRecycle
			' 
			Me.lbRecycle.AllowDrop = True
			Me.lbRecycle.Appearance.ImageIndex = 0
			Me.lbRecycle.Appearance.ImageList = Me.imageList2
			Me.lbRecycle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.lbRecycle.Location = New Point(178, 48)
			Me.lbRecycle.Margin = New Padding(3, 0, 3, 0)
			Me.lbRecycle.Name = "lbRecycle"
			Me.lbRecycle.Size = New Size(63, 34)
			Me.lbRecycle.TabIndex = 4
'			Me.lbRecycle.DragDrop += New System.Windows.Forms.DragEventHandler(Me.lbRecycle_DragDrop)
'			Me.lbRecycle.DragEnter += New System.Windows.Forms.DragEventHandler(Me.lbRecycle_DragEnter)
'			Me.lbRecycle.DragLeave += New System.EventHandler(Me.lbRecycle_DragLeave)
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
			Me.imageList2.TransparentColor = Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.listView1)
			Me.groupControl1.Location = New Point(199, 7)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New Size(412, 120)
			Me.groupControl1.TabIndex = 3
			Me.groupControl1.Text = "Items List:"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.lbRecycle)
			Me.groupControl2.Location = New Point(199, 134)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New Size(411, 120)
			Me.groupControl2.TabIndex = 5
			Me.groupControl2.Text = "Recycle Bin:"
			' 
			' groupControl3
			' 
			Me.groupControl3.Controls.Add(Me.ceAllowOuterDrop)
			Me.groupControl3.Controls.Add(Me.ceAllowDrop)
			Me.groupControl3.Controls.Add(Me.ceAllowDrag)
			Me.groupControl3.Location = New Point(199, 260)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New Size(411, 126)
			Me.groupControl3.TabIndex = 9
			Me.groupControl3.Text = "Drag && Drop Options:"
			' 
			' ceAllowOuterDrop
			' 
			Me.ceAllowOuterDrop.Location = New Point(16, 96)
			Me.ceAllowOuterDrop.Name = "ceAllowOuterDrop"
			Me.ceAllowOuterDrop.Properties.Caption = "Allow Outer Drop"
			Me.ceAllowOuterDrop.Size = New Size(144, 19)
			Me.ceAllowOuterDrop.TabIndex = 2
'			Me.ceAllowOuterDrop.CheckedChanged += New System.EventHandler(Me.ceAllowOuterDrop_CheckedChanged)
			' 
			' ceAllowDrop
			' 
			Me.ceAllowDrop.Location = New Point(16, 64)
			Me.ceAllowDrop.Name = "ceAllowDrop"
			Me.ceAllowDrop.Properties.Caption = "Allow Drop"
			Me.ceAllowDrop.Size = New Size(144, 19)
			Me.ceAllowDrop.TabIndex = 1
'			Me.ceAllowDrop.CheckedChanged += New System.EventHandler(Me.ceAllowDrop_CheckedChanged)
			' 
			' ceAllowDrag
			' 
			Me.ceAllowDrag.Location = New Point(16, 32)
			Me.ceAllowDrag.Name = "ceAllowDrag"
			Me.ceAllowDrag.Properties.Caption = "Allow Drag"
			Me.ceAllowDrag.Size = New Size(144, 19)
			Me.ceAllowDrag.TabIndex = 0
'			Me.ceAllowDrag.CheckedChanged += New System.EventHandler(Me.ceAllowDrag_CheckedChanged)
			' 
			' frmNavBarDragDrop
			' 
			Me.Appearance.Options.UseFont = True
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Name = "frmNavBarDragDrop"
			Me.Size = New Size(624, 425)
			CType(Me.contentPanel_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contentPanel_Renamed.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.ceAllowOuterDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowDrop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceAllowDrag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private imageList1 As ImageList
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem8 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem9 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem10 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem11 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem13 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem14 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem15 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem16 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem17 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem18 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem19 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem20 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem21 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem23 As DevExpress.XtraNavBar.NavBarItem
		Private WithEvents listView1 As ListView
		Private WithEvents lbRecycle As DevExpress.XtraEditors.LabelControl
		Private imageList2 As ImageList
		Private navBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem24 As DevExpress.XtraNavBar.NavBarItem
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private WithEvents ceAllowDrag As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAllowDrop As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAllowOuterDrop As DevExpress.XtraEditors.CheckEdit
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
