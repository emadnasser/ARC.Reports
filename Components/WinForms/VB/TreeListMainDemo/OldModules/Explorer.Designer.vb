Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListExplorer
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TreeListExplorer))
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colFullName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colSize = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colAttributes = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colCheck = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList3 = New System.Windows.Forms.ImageList(Me.components)
			Me.xtraTreeListBlending1 = New DevExpress.XtraTreeList.Blending.XtraTreeListBlending()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(243)))), (CInt((CByte(243)))), (CInt((CByte(243)))))
			Me.treeList1.Appearance.Empty.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.treeList1.Appearance.Empty.Options.UseBackColor = True
			Me.treeList1.Appearance.Empty.Options.UseForeColor = True
			Me.treeList1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(223)))), (CInt((CByte(223)))), (CInt((CByte(223)))))
			Me.treeList1.Appearance.EvenRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.EvenRow.Options.UseBackColor = True
			Me.treeList1.Appearance.EvenRow.Options.UseForeColor = True
			Me.treeList1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(225)))))
			Me.treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.FocusedCell.Options.UseBackColor = True
			Me.treeList1.Appearance.FocusedCell.Options.UseForeColor = True
			Me.treeList1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(128)))))
			Me.treeList1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.treeList1.Appearance.FocusedRow.Options.UseBackColor = True
			Me.treeList1.Appearance.FocusedRow.Options.UseForeColor = True
			Me.treeList1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(210)))), (CInt((CByte(210)))))
			Me.treeList1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(210)))), (CInt((CByte(210)))), (CInt((CByte(210)))))
			Me.treeList1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.treeList1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.FooterPanel.Options.UseBackColor = True
			Me.treeList1.Appearance.FooterPanel.Options.UseBorderColor = True
			Me.treeList1.Appearance.FooterPanel.Options.UseFont = True
			Me.treeList1.Appearance.FooterPanel.Options.UseForeColor = True
			Me.treeList1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(202)))), (CInt((CByte(202)))), (CInt((CByte(202)))))
			Me.treeList1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(202)))), (CInt((CByte(202)))), (CInt((CByte(202)))))
			Me.treeList1.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.GroupButton.Options.UseBackColor = True
			Me.treeList1.Appearance.GroupButton.Options.UseBorderColor = True
			Me.treeList1.Appearance.GroupButton.Options.UseForeColor = True
			Me.treeList1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(202)))), (CInt((CByte(202)))), (CInt((CByte(202)))))
			Me.treeList1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(202)))), (CInt((CByte(202)))), (CInt((CByte(202)))))
			Me.treeList1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.GroupFooter.Options.UseBackColor = True
			Me.treeList1.Appearance.GroupFooter.Options.UseBorderColor = True
			Me.treeList1.Appearance.GroupFooter.Options.UseForeColor = True
			Me.treeList1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			Me.treeList1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
			Me.treeList1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.treeList1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.HeaderPanel.Options.UseBackColor = True
			Me.treeList1.Appearance.HeaderPanel.Options.UseBorderColor = True
			Me.treeList1.Appearance.HeaderPanel.Options.UseFont = True
			Me.treeList1.Appearance.HeaderPanel.Options.UseForeColor = True
			Me.treeList1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.treeList1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(208)))), (CInt((CByte(200)))))
			Me.treeList1.Appearance.HideSelectionRow.Options.UseBackColor = True
			Me.treeList1.Appearance.HideSelectionRow.Options.UseForeColor = True
			Me.treeList1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			Me.treeList1.Appearance.HorzLine.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.treeList1.Appearance.HorzLine.Options.UseBackColor = True
			Me.treeList1.Appearance.HorzLine.Options.UseForeColor = True
			Me.treeList1.Appearance.Preview.BackColor = System.Drawing.Color.LavenderBlush
			Me.treeList1.Appearance.Preview.ForeColor = System.Drawing.Color.MediumBlue
			Me.treeList1.Appearance.Preview.Options.UseBackColor = True
			Me.treeList1.Appearance.Preview.Options.UseForeColor = True
			Me.treeList1.Appearance.Preview.Options.UseTextOptions = True
			Me.treeList1.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.treeList1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(243)))), (CInt((CByte(243)))), (CInt((CByte(243)))))
			Me.treeList1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.treeList1.Appearance.Row.Options.UseBackColor = True
			Me.treeList1.Appearance.Row.Options.UseForeColor = True
			Me.treeList1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(10)))), (CInt((CByte(10)))), (CInt((CByte(138)))))
			Me.treeList1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.treeList1.Appearance.SelectedRow.Options.UseBackColor = True
			Me.treeList1.Appearance.SelectedRow.Options.UseForeColor = True
			Me.treeList1.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.treeList1.Appearance.TreeLine.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.treeList1.Appearance.TreeLine.Options.UseBackColor = True
			Me.treeList1.Appearance.TreeLine.Options.UseForeColor = True
			Me.treeList1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(192)))), (CInt((CByte(192)))))
			Me.treeList1.Appearance.VertLine.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(128)))), (CInt((CByte(128)))))
			Me.treeList1.Appearance.VertLine.Options.UseBackColor = True
			Me.treeList1.Appearance.VertLine.Options.UseForeColor = True
			Me.treeList1.Appearance.VertLine.Options.UseTextOptions = True
			Me.treeList1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.treeList1.BackgroundImage = (CType(resources.GetObject("treeList1.BackgroundImage"), System.Drawing.Image))
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colFullName, Me.colName, Me.colType, Me.colSize, Me.colAttributes, Me.colCheck})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.AutoChangeParent = False
			Me.treeList1.OptionsBehavior.AutoNodeHeight = False
			Me.treeList1.OptionsBehavior.AutoSelectAllInEditor = False
			Me.treeList1.OptionsBehavior.CloseEditorOnLostFocus = False
			Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsDragAndDrop.ExpandNodeOnDrag = False
			Me.treeList1.OptionsBehavior.KeepSelectedOnClick = False
			Me.treeList1.OptionsBehavior.ResizeNodes = False
			Me.treeList1.OptionsBehavior.SmartMouseHover = False
			Me.treeList1.OptionsMenu.EnableFooterMenu = False
			Me.treeList1.OptionsView.AutoCalcPreviewLineCount = True
			Me.treeList1.OptionsView.EnableAppearanceEvenRow = True
			Me.treeList1.OptionsView.ShowHorzLines = False
			Me.treeList1.OptionsView.ShowIndicator = False
			Me.treeList1.OptionsView.ShowVertLines = False
			Me.treeList1.SelectImageList = Me.imageList1
			Me.treeList1.Size = New System.Drawing.Size(420, 378)
			Me.treeList1.StateImageList = Me.imageList2
			Me.treeList1.TabIndex = 0
'			Me.treeList1.GetStateImage += New DevExpress.XtraTreeList.GetStateImageEventHandler(Me.treeList1_GetStateImage)
'			Me.treeList1.GetPreviewText += New DevExpress.XtraTreeList.GetPreviewTextEventHandler(Me.treeList1_GetPreviewText)
'			Me.treeList1.CompareNodeValues += New DevExpress.XtraTreeList.CompareNodeValuesEventHandler(Me.treeList1_CompareNodeValues)
'			Me.treeList1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.treeList1_MouseDown)
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged)
'			Me.treeList1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.treeList1_KeyDown)
'			Me.treeList1.BeforeExpand += New DevExpress.XtraTreeList.BeforeExpandEventHandler(Me.treeList1_BeforeExpand)
'			Me.treeList1.GetSelectImage += New DevExpress.XtraTreeList.GetSelectImageEventHandler(Me.treeList1_GetSelectImage)
			' 
			' colFullName
			' 
			Me.colFullName.Caption = "Name"
			Me.colFullName.FieldName = "FullName"
			Me.colFullName.Name = "colFullName"
			' 
			' colName
			' 
			Me.colName.AllNodesSummary = True
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.MinWidth = 43
			Me.colName.Name = "colName"
			Me.colName.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count
			Me.colName.SummaryFooterStrFormat = "Files and Folders ({0})"
			Me.colName.VisibleIndex = 0
			Me.colName.Width = 250
			' 
			' colType
			' 
			Me.colType.Caption = "Type"
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			Me.colType.VisibleIndex = 1
			' 
			' colSize
			' 
			Me.colSize.AppearanceCell.Options.UseTextOptions = True
			Me.colSize.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			Me.colSize.Caption = "Size(Bytes)"
			Me.colSize.FieldName = "Size"
			Me.colSize.Name = "colSize"
			Me.colSize.VisibleIndex = 2
			' 
			' colAttributes
			' 
			Me.colAttributes.Caption = "Attributes"
			Me.colAttributes.FieldName = "Attributes"
			Me.colAttributes.Name = "colAttributes"
			' 
			' colCheck
			' 
			Me.colCheck.Caption = "Check"
			Me.colCheck.FieldName = "Check"
			Me.colCheck.Name = "colCheck"
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
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			' 
			' imageList3
			' 
			Me.imageList3.ImageStream = (CType(resources.GetObject("imageList3.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList3.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList3.Images.SetKeyName(0, "")
			Me.imageList3.Images.SetKeyName(1, "")
			Me.imageList3.Images.SetKeyName(2, "")
			Me.imageList3.Images.SetKeyName(3, "")
			Me.imageList3.Images.SetKeyName(4, "")
			Me.imageList3.Images.SetKeyName(5, "")
			Me.imageList3.Images.SetKeyName(6, "")
			Me.imageList3.Images.SetKeyName(7, "")
			Me.imageList3.Images.SetKeyName(8, "")
			' 
			' xtraTreeListBlending1
			' 
			Me.xtraTreeListBlending1.Enabled = False
			Me.xtraTreeListBlending1.TreeListControl = Me.treeList1
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
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barStaticItem1, Me.barStaticItem2})
			Me.barManager1.MaxItemId = 2
			Me.barManager1.StatusBar = Me.bar1
			' 
			' bar1
			' 
			Me.bar1.BarName = "Static"
			Me.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem2)})
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
			Me.barStaticItem1.RightIndent = 5
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			Me.barStaticItem1.Width = 32
			' 
			' barStaticItem2
			' 
			Me.barStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
			Me.barStaticItem2.Id = 1
			Me.barStaticItem2.Name = "barStaticItem2"
			Me.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			Me.barStaticItem2.Width = 100
			' 
			' TreeListExplorer
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "TreeListExplorer"
			Me.Size = New System.Drawing.Size(420, 401)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private colType As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colFullName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colSize As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colAttributes As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private colCheck As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private imageList3 As System.Windows.Forms.ImageList
		Private xtraTreeListBlending1 As DevExpress.XtraTreeList.Blending.XtraTreeListBlending
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private barStaticItem2 As DevExpress.XtraBars.BarStaticItem
		Private bar1 As DevExpress.XtraBars.Bar
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
