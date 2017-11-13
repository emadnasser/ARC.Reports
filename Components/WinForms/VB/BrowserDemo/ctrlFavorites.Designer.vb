Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.BrowserDemo
	Public Partial Class ctrlFavorites
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlFavorites))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.iAdd = New DevExpress.XtraBars.BarButtonItem()
			Me.iEdit = New DevExpress.XtraBars.BarButtonItem()
			Me.iDelete = New DevExpress.XtraBars.BarButtonItem()
			Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.listBox1 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControl1)
			Me.barManager1.DockControls.Add(Me.barDockControl2)
			Me.barManager1.DockControls.Add(Me.barDockControl3)
			Me.barManager1.DockControls.Add(Me.barDockControl4)
			Me.barManager1.Form = Me
			Me.barManager1.Images = Me.imageList1
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.iAdd, Me.iEdit, Me.iDelete, Me.iOpen})
			Me.barManager1.MaxItemId = 4
			' 
			' bar1
			' 
			Me.bar1.BarName = "Edit"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatLocation = New System.Drawing.Point(43, 86)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.iEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.iDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen, True)})
			Me.bar1.Text = "Edit"
			' 
			' iAdd
			' 
			Me.iAdd.Caption = "&Add"
			Me.iAdd.Hint = "Add Favorite"
			Me.iAdd.Id = 0
			Me.iAdd.ImageIndex = 0
			Me.iAdd.Name = "iAdd"
'			Me.iAdd.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.iAdd_ItemClick);
			' 
			' iEdit
			' 
			Me.iEdit.Caption = "&Edit"
			Me.iEdit.Hint = "Edit Favorite"
			Me.iEdit.Id = 1
			Me.iEdit.ImageIndex = 1
			Me.iEdit.Name = "iEdit"
'			Me.iEdit.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.iEdit_ItemClick);
			' 
			' iDelete
			' 
			Me.iDelete.Caption = "&Delete"
			Me.iDelete.Hint = "Delete Favorite"
			Me.iDelete.Id = 2
			Me.iDelete.ImageIndex = 2
			Me.iDelete.Name = "iDelete"
'			Me.iDelete.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.iDelete_ItemClick);
			' 
			' iOpen
			' 
			Me.iOpen.Caption = "&Open"
			Me.iOpen.Hint = "Open Favorite"
			Me.iOpen.Id = 3
			Me.iOpen.ImageIndex = 3
			Me.iOpen.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
			Me.iOpen.Name = "iOpen"
'			Me.iOpen.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.iOpen_ItemClick);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.ItemHeight = 15
			Me.listBox1.Location = New System.Drawing.Point(0, 26)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(196, 222)
			Me.listBox1.TabIndex = 4
'			Me.listBox1.DoubleClick += New System.EventHandler(Me.listBox1_DoubleClick);
'			Me.listBox1.SelectedIndexChanged += New System.EventHandler(Me.listBox1_SelectedIndexChanged);
			' 
			' ctrlFavorites
			' 
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.barDockControl3)
			Me.Controls.Add(Me.barDockControl4)
			Me.Controls.Add(Me.barDockControl2)
			Me.Controls.Add(Me.barDockControl1)
			Me.Name = "ctrlFavorites"
			Me.Size = New System.Drawing.Size(196, 248)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Friend barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private WithEvents iAdd As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iEdit As DevExpress.XtraBars.BarButtonItem
		Private WithEvents iDelete As DevExpress.XtraBars.BarButtonItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents listBox1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
