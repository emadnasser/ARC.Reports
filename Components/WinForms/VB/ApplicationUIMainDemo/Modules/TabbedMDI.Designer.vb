Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class frmTabbedMDI
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTabbedMDI))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
			Me.bCheckItem = New DevExpress.XtraBars.BarCheckItem()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem3 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem4 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barEditItem5 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barEditItem6 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemImageComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barMdiChildrenListItem1, Me.barEditItem1, Me.bCheckItem, Me.barEditItem2, Me.barEditItem3, Me.barEditItem4, Me.barEditItem5, Me.barCheckItem1, Me.barCheckItem2, Me.barEditItem6})
			Me.barManager1.MaxItemId = 16
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.repositoryItemImageComboBox4, Me.repositoryItemImageComboBox5, Me.repositoryItemCheckEdit1, Me.repositoryItemImageComboBox6})
			' 
			' bar1
			' 
			Me.bar1.BarName = "barWindows"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.FloatLocation = New System.Drawing.Point(42, 179)
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barMdiChildrenListItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barCheckItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barCheckItem2, DevExpress.XtraBars.BarItemPaintStyle.Standard), New DevExpress.XtraBars.LinkPersistInfo(Me.bCheckItem, True)})
			Me.bar1.Text = "Windows"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Add New Form"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' barMdiChildrenListItem1
			' 
			Me.barMdiChildrenListItem1.Caption = "Windows"
			Me.barMdiChildrenListItem1.Id = 1
			Me.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "FloatOnDoubleClick"
			Me.barCheckItem1.Id = 13
			Me.barCheckItem1.Name = "barCheckItem1"
'			Me.barCheckItem1.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCheckItem1_CheckedChanged);
			' 
			' barCheckItem2
			' 
			Me.barCheckItem2.Caption = "FloatOnDrag"
			Me.barCheckItem2.Id = 14
			Me.barCheckItem2.Name = "barCheckItem2"
'			Me.barCheckItem2.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCheckItem2_CheckedChanged);
			' 
			' bCheckItem
			' 
			Me.bCheckItem.Caption = "Colored Tabs"
			Me.bCheckItem.Id = 4
			Me.bCheckItem.Name = "bCheckItem"
'			Me.bCheckItem.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.bCheckItem_CheckedChanged);
			' 
			' bar2
			' 
			Me.bar2.BarName = "barOptions"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 1
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.FloatLocation = New System.Drawing.Point(40, 210)
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem1, "", False, True, True, 85), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem2, "", False, True, True, 87), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem3, "", False, True, True, 85), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem4, "", False, True, True, 81)})
			Me.bar2.Text = "Options"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "Header Location"
			Me.barEditItem1.Edit = Me.repositoryItemImageComboBox1
			Me.barEditItem1.Id = 5
			Me.barEditItem1.Name = "barEditItem1"
			Me.barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem1.EditValueChanged += New System.EventHandler(Me.barEditItem1_EditValueChanged);
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			' 
			' barEditItem2
			' 
			Me.barEditItem2.Caption = "Header Orientation"
			Me.barEditItem2.Edit = Me.repositoryItemImageComboBox2
			Me.barEditItem2.Id = 6
			Me.barEditItem2.Name = "barEditItem2"
			Me.barEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem2.EditValueChanged += New System.EventHandler(Me.barEditItem2_EditValueChanged);
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			' 
			' barEditItem3
			' 
			Me.barEditItem3.Caption = "Page Image Position"
			Me.barEditItem3.Edit = Me.repositoryItemImageComboBox3
			Me.barEditItem3.Id = 7
			Me.barEditItem3.Name = "barEditItem3"
			Me.barEditItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem3.EditValueChanged += New System.EventHandler(Me.barEditItem3_EditValueChanged);
			' 
			' repositoryItemImageComboBox3
			' 
			Me.repositoryItemImageComboBox3.AutoHeight = False
			Me.repositoryItemImageComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
			' 
			' barEditItem4
			' 
			Me.barEditItem4.Caption = "Header AutoFill"
			Me.barEditItem4.Edit = Me.repositoryItemImageComboBox4
			Me.barEditItem4.Id = 8
			Me.barEditItem4.Name = "barEditItem4"
			Me.barEditItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'			Me.barEditItem4.EditValueChanged += New System.EventHandler(Me.barEditItem4_EditValueChanged);
			' 
			' repositoryItemImageComboBox4
			' 
			Me.repositoryItemImageComboBox4.AutoHeight = False
			Me.repositoryItemImageComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4"
			' 
			' bar3
			' 
			Me.bar3.BarName = "ClosePage Buttons"
			Me.bar3.DockCol = 1
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.barEditItem5, "", False, True, True, 180), New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem6)})
			Me.bar3.Offset = 181
			Me.bar3.Text = "ClosePage Buttons"
			' 
			' barEditItem5
			' 
			Me.barEditItem5.Caption = "Close Page Button"
			Me.barEditItem5.Edit = Me.repositoryItemImageComboBox5
			Me.barEditItem5.Id = 10
			Me.barEditItem5.Name = "barEditItem5"
			Me.barEditItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
			Me.barEditItem5.Width = 120
'			Me.barEditItem5.EditValueChanged += New System.EventHandler(Me.barEditItem5_EditValueChanged);
			' 
			' repositoryItemImageComboBox5
			' 
			Me.repositoryItemImageComboBox5.AutoHeight = False
			Me.repositoryItemImageComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5"
			' 
			' barEditItem6
			' 
			Me.barEditItem6.Caption = "Show Pin Tab"
			Me.barEditItem6.Edit = Me.repositoryItemImageComboBox6
			Me.barEditItem6.Id = 15
			Me.barEditItem6.Name = "barEditItem6"
			Me.barEditItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
			Me.barEditItem6.Width = 85
'			Me.barEditItem6.EditValueChanged += New System.EventHandler(Me.barEditItem6_EditValueChanged);
			' 
			' repositoryItemImageComboBox6
			' 
			Me.repositoryItemImageComboBox6.AutoHeight = False
			Me.repositoryItemImageComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox6.Name = "repositoryItemImageComboBox6"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(983, 58)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 310)
			Me.barDockControlBottom.Size = New System.Drawing.Size(983, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 252)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(983, 58)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 252)
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Caption = "Check"
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True
			Me.xtraTabbedMdiManager1.MdiParent = Me
'			Me.xtraTabbedMdiManager1.PageAdded += New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(Me.xtraTabbedMdiManager1_PageAdded);
'			Me.xtraTabbedMdiManager1.PageRemoved += New DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(Me.xtraTabbedMdiManager1_PageRemoved);
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
			' 
			' frmTabbedMDI
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(983, 310)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.IsMdiContainer = True
			Me.Name = "frmTabbedMDI"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TabbedMDI (C# code)"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents bCheckItem As DevExpress.XtraBars.BarCheckItem
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem
		Private bar2 As DevExpress.XtraBars.Bar
		Private WithEvents barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents barEditItem2 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents barEditItem3 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private WithEvents barEditItem4 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private components As System.ComponentModel.IContainer
		Private WithEvents barEditItem5 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private bar3 As DevExpress.XtraBars.Bar
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private WithEvents barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private WithEvents barCheckItem2 As DevExpress.XtraBars.BarCheckItem
		Private WithEvents barEditItem6 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemImageComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

	End Class
End Namespace
