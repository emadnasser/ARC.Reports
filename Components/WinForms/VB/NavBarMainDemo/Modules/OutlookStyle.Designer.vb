Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class OutlookStyle
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OutlookStyle))
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.imageList2 = New ImageList(Me.components)
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.imageList1 = New ImageList(Me.components)
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Read"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemImageComboBox2
			Me.gridColumn2.FieldName = "Read"
			Me.gridColumn2.ImageIndex = 1
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowEdit = False
			Me.gridColumn2.OptionsColumn.AllowFocus = False
			Me.gridColumn2.OptionsColumn.AllowMove = False
			Me.gridColumn2.OptionsColumn.AllowSize = False
			Me.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True
			Me.gridColumn2.OptionsColumn.FixedWidth = True
			Me.gridColumn2.OptionsColumn.ShowCaption = False
			Me.gridColumn2.OptionsColumn.ShowInCustomizationForm = False
			Me.gridColumn2.ToolTip = "Icon"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 0
			Me.gridColumn2.Width = 44
			' 
			' repositoryItemImageComboBox2
			' 
			Me.repositoryItemImageComboBox2.AutoHeight = False
			Me.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", 0, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", 1, 2)})
			Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
			Me.repositoryItemImageComboBox2.SmallImages = Me.imageList2
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), ImageListStreamer))
			Me.imageList2.TransparentColor = Color.Magenta
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			Me.imageList2.Images.SetKeyName(2, "")
			Me.imageList2.Images.SetKeyName(3, "")
			Me.imageList2.Images.SetKeyName(4, "")
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Priority"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemImageComboBox1
			Me.gridColumn1.FieldName = "Priority"
			Me.gridColumn1.ImageIndex = 0
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.OptionsColumn.AllowFocus = False
			Me.gridColumn1.OptionsColumn.AllowSize = False
			Me.gridColumn1.OptionsColumn.FixedWidth = True
			Me.gridColumn1.OptionsColumn.ShowCaption = False
			Me.gridColumn1.ToolTip = "Importance"
			Me.gridColumn1.Width = 44
			' 
			' repositoryItemImageComboBox1
			' 
			Me.repositoryItemImageComboBox1.AutoHeight = False
			Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 1)})
			Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
			Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3})
			Me.gridControl1.Size = New Size(570, 344)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Appearance.GroupRow.ForeColor = Color.FromArgb((CInt((CByte(55)))), (CInt((CByte(104)))), (CInt((CByte(185)))))
			Me.gridView1.Appearance.GroupRow.Options.UseForeColor = True
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.GroupFormat = "[#image]{1} {2}"
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Subject", Nothing, "({0} items)")})
			Me.gridView1.Images = Me.imageList1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
			Me.gridView1.OptionsView.ShowGroupedColumns = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.OptionsView.ShowIndicator = False
			Me.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn6, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn2, DevExpress.Data.ColumnSortOrder.Descending)})
'			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow)
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell)
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Attachment"
			Me.gridColumn3.ColumnEdit = Me.repositoryItemImageComboBox3
			Me.gridColumn3.FieldName = "Attachment"
			Me.gridColumn3.ImageIndex = 2
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.OptionsColumn.AllowEdit = False
			Me.gridColumn3.OptionsColumn.AllowFocus = False
			Me.gridColumn3.OptionsColumn.AllowSize = False
			Me.gridColumn3.OptionsColumn.FixedWidth = True
			Me.gridColumn3.OptionsColumn.ShowCaption = False
			Me.gridColumn3.ToolTip = "Attachment"
			Me.gridColumn3.Width = 44
			' 
			' repositoryItemImageComboBox3
			' 
			Me.repositoryItemImageComboBox3.AutoHeight = False
			Me.repositoryItemImageComboBox3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Attachment", 0, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 1, -1)})
			Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
			Me.repositoryItemImageComboBox3.SmallImages = Me.imageList2
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Subject"
			Me.gridColumn4.FieldName = "Subject"
			Me.gridColumn4.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.OptionsColumn.AllowFocus = False
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 1
			Me.gridColumn4.Width = 378
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "From"
			Me.gridColumn5.FieldName = "From"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.OptionsColumn.AllowFocus = False
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 2
			Me.gridColumn5.Width = 113
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Received"
			Me.gridColumn6.ColumnEdit = Me.repositoryItemDateEdit1
			Me.gridColumn6.FieldName = "Received"
			Me.gridColumn6.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.OptionsColumn.AllowFocus = False
			Me.gridColumn6.Width = 169
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "g"
			Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			Me.repositoryItemDateEdit1.Mask.EditMask = "g"
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			' 
			' OutlookStyle
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "OutlookStyle"
			Me.Size = New Size(570, 344)
			CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private imageList1 As ImageList
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageList2 As ImageList
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
