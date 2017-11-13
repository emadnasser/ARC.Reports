Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListRegViewer
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeListRegViewer))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colKey = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.treeList2 = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colValue = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.imageCollection3 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeList2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colKey})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoChangeParent = False
			Me.treeList1.OptionsBehavior.AutoNodeHeight = False
			Me.treeList1.OptionsBehavior.AutoSelectAllInEditor = False
			Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ResizeNodes = False
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.OptionsMenu.EnableFooterMenu = False
			Me.treeList1.OptionsPrint.PrintHorzLines = False
			Me.treeList1.OptionsPrint.PrintVertLines = False
			Me.treeList1.OptionsPrint.UsePrintStyles = True
			Me.treeList1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList1.OptionsView.FocusRectStyle = DrawFocusRectStyle.None
			Me.treeList1.OptionsView.ShowHorzLines = False
			Me.treeList1.OptionsView.ShowIndicator = False
			Me.treeList1.OptionsView.ShowVertLines = False
			Me.treeList1.SelectImageList = Me.imageCollection1
			Me.treeList1.Size = New System.Drawing.Size(248, 284)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.GetPreviewText += New DevExpress.XtraTreeList.GetPreviewTextEventHandler(Me.treeList1_GetPreviewText)
'			Me.treeList1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.treeList1_KeyDown)
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged)
'			Me.treeList1.BeforeExpand += New DevExpress.XtraTreeList.BeforeExpandEventHandler(Me.treeList1_BeforeExpand)
'			Me.treeList1.GetSelectImage += New DevExpress.XtraTreeList.GetSelectImageEventHandler(Me.treeList1_GetSelectImage)
			' 
			' colKey
			' 
			Me.colKey.AllNodesSummary = True
			Me.colKey.Caption = "Registry Keys"
			Me.colKey.FieldName = "Key"
			Me.colKey.MinWidth = 33
			Me.colKey.Name = "colKey"
			Me.colKey.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count
			Me.colKey.SummaryFooterStrFormat = "Count keys = {0}"
			Me.colKey.Visible = True
			Me.colKey.VisibleIndex = 0
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "Info.png")
			Me.imageCollection1.Images.SetKeyName(1, "Folder_Closed.png")
			Me.imageCollection1.Images.SetKeyName(2, "Folder_Opened.png")
			' 
			' treeList2
			' 
			Me.treeList2.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colValue, Me.colType})
			Me.treeList2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList2.Location = New System.Drawing.Point(251, 0)
			Me.treeList2.Name = "treeList2"
			Me.treeList2.OptionsBehavior.AutoChangeParent = False
			Me.treeList2.OptionsBehavior.AutoNodeHeight = False
			Me.treeList2.OptionsBehavior.AutoSelectAllInEditor = False
			Me.treeList2.OptionsBehavior.CloseEditorOnLostFocus = False
			Me.treeList2.OptionsBehavior.Editable = False
			Me.treeList2.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList2.OptionsBehavior.ResizeNodes = False
			Me.treeList2.OptionsBehavior.SmartMouseHover = False
			Me.treeList2.OptionsMenu.EnableFooterMenu = False
			Me.treeList2.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.treeList2.OptionsView.AutoCalcPreviewLineCount = True
            Me.treeList2.OptionsView.FocusRectStyle = DrawFocusRectStyle.None
			Me.treeList2.OptionsView.ShowIndentAsRowStyle = True
			Me.treeList2.OptionsView.ShowIndicator = False
			Me.treeList2.OptionsView.ShowRoot = False
			Me.treeList2.SelectImageList = Me.imageCollection2
			Me.treeList2.Size = New System.Drawing.Size(419, 284)
			Me.treeList2.TabIndex = 1
'			Me.treeList2.HideCustomizationForm += New System.EventHandler(Me.treeList2_HideCustomizationForm)
'			Me.treeList2.GetNodeDisplayValue += New DevExpress.XtraTreeList.GetNodeDisplayValueEventHandler(Me.treeList2_GetNodeDisplayValue)
'			Me.treeList2.GetSelectImage += New DevExpress.XtraTreeList.GetSelectImageEventHandler(Me.treeList2_GetSelectImage)
'			Me.treeList2.ShowCustomizationForm += New System.EventHandler(Me.treeList2_ShowCustomizationForm)
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.MinWidth = 33
			Me.colName.Name = "colName"
			Me.colName.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count
			Me.colName.SummaryFooterStrFormat = "Count Values = {0}"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colValue
			' 
			Me.colValue.Caption = "Value"
			Me.colValue.FieldName = "Value"
			Me.colValue.Name = "colValue"
			Me.colValue.OptionsColumn.AllowEdit = False
			Me.colValue.OptionsColumn.AllowSort = False
			Me.colValue.Visible = True
			Me.colValue.VisibleIndex = 1
			' 
			' colType
			' 
			Me.colType.Caption = "Type"
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "ab_16x16.png")
			Me.imageCollection2.Images.SetKeyName(1, "123_16x16.png")
			Me.imageCollection2.Images.SetKeyName(2, "101_16x16.png")
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(248, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(3, 284)
			Me.splitter1.TabIndex = 2
			Me.splitter1.TabStop = False
			' 
			' imageCollection3
			' 
			Me.imageCollection3.ImageStream = (CType(resources.GetObject("imageCollection3.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection3.Images.SetKeyName(0, "DisplayStyle_16x16.png")
			Me.imageCollection3.Images.SetKeyName(1, "FullCollapse_16x16.png")
			Me.imageCollection3.Images.SetKeyName(2, "ShowFirstFooter_16x16.png")
			Me.imageCollection3.Images.SetKeyName(3, "ShowSecondFooter_16x16.png")
			Me.imageCollection3.Images.SetKeyName(4, "ShowPreview_16x16.png")
			Me.imageCollection3.Images.SetKeyName(5, "ColumnSelector_16x16.png")
			' 
			' barManager1
			' 
			Me.barManager1.AllowCustomization = False
			Me.barManager1.AllowQuickCustomization = False
			Me.barManager1.AllowShowToolbarsPopup = False
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barStaticItem1})
			Me.barManager1.MaxItemId = 1
			Me.barManager1.StatusBar = Me.bar1
			' 
			' bar1
			' 
			Me.bar1.BarName = "Static"
			Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1)})
			Me.bar1.OptionsBar.AllowQuickCustomization = False
			Me.bar1.OptionsBar.DrawDragBorder = False
			Me.bar1.OptionsBar.UseWholeRow = True
			Me.bar1.Text = "Static"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
			Me.barStaticItem1.Id = 0
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			Me.barStaticItem1.Width = 32
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(670, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 284)
			Me.barDockControlBottom.Size = New System.Drawing.Size(670, 25)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 284)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(670, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 284)
			' 
			' TreeListRegViewer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList2)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "TreeListRegViewer"
			Me.Size = New System.Drawing.Size(670, 309)
'			Me.Load += New System.EventHandler(Me.TreeListRegViewer_Load)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeList2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private WithEvents treeList2 As DevExpress.XtraTreeList.TreeList
		Private splitter1 As System.Windows.Forms.Splitter
		Private colKey As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colValue As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colType As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private imageCollection3 As DevExpress.Utils.ImageCollection
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private components As System.ComponentModel.IContainer
		Private imageCollection1 As DevExpress.Utils.ImageCollection
	End Class
End Namespace
