Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListStyles
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeListStyles))
			Me.lsStyles = New DevExpress.XtraEditors.ListBoxControl()
			Me.btnAlphaBlending = New DevExpress.XtraEditors.SimpleButton()
			Me.chbAlphaBlending = New DevExpress.XtraEditors.CheckEdit()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.xtraTreeListBlending1 = New DevExpress.XtraTreeList.Blending.XtraTreeListBlending()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.ceNewStyles = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.splitter2 = New DevExpress.XtraEditors.SplitterControl()
			Me.lbcAppearances = New DevExpress.XtraEditors.ListBoxControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.ceNewStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lsStyles
			' 
			Me.lsStyles.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lsStyles.ItemHeight = 16
			Me.lsStyles.Location = New System.Drawing.Point(2, 54)
			Me.lsStyles.Name = "lsStyles"
			Me.lsStyles.Size = New System.Drawing.Size(163, 329)
			Me.lsStyles.TabIndex = 0
'			Me.lsStyles.SelectedIndexChanged += New System.EventHandler(Me.lsStyles_SelectedIndexChanged)
			' 
			' btnAlphaBlending
			' 
			Me.btnAlphaBlending.Enabled = False
			Me.btnAlphaBlending.Location = New System.Drawing.Point(124, 4)
			Me.btnAlphaBlending.Name = "btnAlphaBlending"
			Me.btnAlphaBlending.Size = New System.Drawing.Size(28, 20)
			Me.btnAlphaBlending.TabIndex = 24
			Me.btnAlphaBlending.Text = "..."
'			Me.btnAlphaBlending.Click += New System.EventHandler(Me.btnAlphaBlending_Click)
			' 
			' chbAlphaBlending
			' 
			Me.chbAlphaBlending.Location = New System.Drawing.Point(4, 4)
			Me.chbAlphaBlending.Name = "chbAlphaBlending"
			Me.chbAlphaBlending.Properties.Caption = "Alpha Blending"
			Me.chbAlphaBlending.Size = New System.Drawing.Size(108, 19)
			Me.chbAlphaBlending.TabIndex = 23
'			Me.chbAlphaBlending.CheckedChanged += New System.EventHandler(Me.chbAlphaBlending_CheckedChanged)
			' 
			' treeList1
			' 
			Me.treeList1.BackgroundImage = (CType(resources.GetObject("treeList1.BackgroundImage"), System.Drawing.Image))
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(182, 0)
			Me.treeList1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
			Me.treeList1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsView.FocusRectStyle = DrawFocusRectStyle.None
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(668, 416)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.ShowCustomizationForm += New System.EventHandler(Me.treeList1_ShowCustomizationForm)
'			Me.treeList1.HideCustomizationForm += New System.EventHandler(Me.treeList1_HideCustomizationForm)
'			Me.treeList1.GetSelectImage += New DevExpress.XtraTreeList.GetSelectImageEventHandler(Me.treeList1_GetSelectImage)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(176, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(6, 416)
			Me.splitter1.TabIndex = 2
			Me.splitter1.TabStop = False
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			' 
			' xtraTreeListBlending1
			' 
			Me.xtraTreeListBlending1.Enabled = False
			Me.xtraTreeListBlending1.TreeListControl = Me.treeList1
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(176, 416)
			Me.xtraTabControl1.TabIndex = 4
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.Text = "xtraTabControl1"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.lsStyles)
			Me.xtraTabPage1.Controls.Add(Me.panel1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(2)
			Me.xtraTabPage1.Size = New System.Drawing.Size(167, 385)
			Me.xtraTabPage1.Text = "Formats"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.Transparent
			Me.panel1.Controls.Add(Me.ceNewStyles)
			Me.panel1.Controls.Add(Me.chbAlphaBlending)
			Me.panel1.Controls.Add(Me.btnAlphaBlending)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(2, 2)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(163, 52)
			Me.panel1.TabIndex = 25
			' 
			' ceNewStyles
			' 
			Me.ceNewStyles.Location = New System.Drawing.Point(4, 28)
			Me.ceNewStyles.Name = "ceNewStyles"
			Me.ceNewStyles.Properties.Caption = "Only New Styles"
			Me.ceNewStyles.Size = New System.Drawing.Size(186, 19)
			Me.ceNewStyles.TabIndex = 25
'			Me.ceNewStyles.CheckedChanged += New System.EventHandler(Me.ceNewStyles_CheckedChanged)
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.propertyGrid1)
			Me.xtraTabPage2.Controls.Add(Me.splitter2)
			Me.xtraTabPage2.Controls.Add(Me.lbcAppearances)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(2)
			Me.xtraTabPage2.Size = New System.Drawing.Size(167, 336)
			Me.xtraTabPage2.Text = "Appearances"
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.Gray
			Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid1.HelpVisible = False
			Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
			Me.propertyGrid1.Location = New System.Drawing.Point(2, 184)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(163, 150)
			Me.propertyGrid1.TabIndex = 25
			Me.propertyGrid1.ToolbarVisible = False
			' 
			' splitter2
			' 
			Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitter2.Location = New System.Drawing.Point(2, 178)
			Me.splitter2.Name = "splitter2"
			Me.splitter2.Size = New System.Drawing.Size(163, 6)
			Me.splitter2.TabIndex = 26
			Me.splitter2.TabStop = False
			' 
			' lbcAppearances
			' 
			Me.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Top
			Me.lbcAppearances.ItemHeight = 16
			Me.lbcAppearances.Location = New System.Drawing.Point(2, 2)
			Me.lbcAppearances.Name = "lbcAppearances"
			Me.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			Me.lbcAppearances.Size = New System.Drawing.Size(163, 176)
			Me.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending
			Me.lbcAppearances.TabIndex = 24
'			Me.lbcAppearances.SelectedIndexChanged += New System.EventHandler(Me.lbcAppearances_SelectedIndexChanged)
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' TreeListStyles
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "TreeListStyles"
			Me.Size = New System.Drawing.Size(850, 416)
'			Me.Load += New System.EventHandler(Me.TreeListStyles_Load)
			CType(Me.lsStyles, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbAlphaBlending.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			CType(Me.ceNewStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.lbcAppearances, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private xapp As DevExpress.XtraTreeList.Design.XAppearances
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents lsStyles As DevExpress.XtraEditors.ListBoxControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private imageList2 As System.Windows.Forms.ImageList
		Private xtraTreeListBlending1 As DevExpress.XtraTreeList.Blending.XtraTreeListBlending
		Friend WithEvents btnAlphaBlending As DevExpress.XtraEditors.SimpleButton
		Friend WithEvents chbAlphaBlending As DevExpress.XtraEditors.CheckEdit
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents ceNewStyles As DevExpress.XtraEditors.CheckEdit
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private splitter2 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents lbcAppearances As DevExpress.XtraEditors.ListBoxControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
