Namespace DevExpress.XtraGrid.Demos
	Partial Public Class RTFView
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RTFView))
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.seVIndent = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.seHIndent = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.seCustomHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.colPrice2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemRichTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.seVIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seHIndent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seCustomHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			resources.ApplyResources(Me.gridControl1, "gridControl1")
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemRichTextEdit1, Me.repositoryItemMemoEdit1})
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colType, Me.colNotes})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.RowAutoHeight = True
			Me.gridView1.OptionsView.ShowGroupPanel = False
			' 
			' colType
			' 
			resources.ApplyResources(Me.colType, "colType")
			Me.colType.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.colType.FieldName = "Type"
			Me.colType.Name = "colType"
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' colNotes
			' 
			Me.colNotes.AppearanceHeader.Font = (CType(resources.GetObject("colNotes.AppearanceHeader.Font"), System.Drawing.Font))
			Me.colNotes.AppearanceHeader.Options.UseFont = True
			resources.ApplyResources(Me.colNotes, "colNotes")
			Me.colNotes.ColumnEdit = Me.repositoryItemRichTextEdit1
			Me.colNotes.FieldName = "Notes"
			Me.colNotes.Name = "colNotes"
			Me.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colNotes.OptionsFilter.AllowFilter = False
			' 
			' repositoryItemRichTextEdit1
			' 
			Me.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1"
			Me.repositoryItemRichTextEdit1.ShowCaretInReadOnly = False
			' 
			' xtraTabControl1
			' 
			resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged)
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gridControl1)
			Me.xtraTabPage1.Controls.Add(Me.panelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
			' 
			' panelControl1
			' 
			Me.panelControl1.Appearance.BackColor = (CType(resources.GetObject("panelControl1.Appearance.BackColor"), System.Drawing.Color))
			Me.panelControl1.Appearance.Options.UseBackColor = True
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.seVIndent)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.seHIndent)
			Me.panelControl1.Controls.Add(Me.labelControl3)
			Me.panelControl1.Controls.Add(Me.seCustomHeight)
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' labelControl2
			' 
			resources.ApplyResources(Me.labelControl2, "labelControl2")
			Me.labelControl2.Name = "labelControl2"
			' 
			' seVIndent
			' 
			Me.seVIndent.AllowDrop = True
			resources.ApplyResources(Me.seVIndent, "seVIndent")
			Me.seVIndent.Name = "seVIndent"
			Me.seVIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seVIndent.Properties.IsFloatValue = False
			Me.seVIndent.Properties.Mask.EditMask = resources.GetString("seVIndent.Properties.Mask.EditMask")
			Me.seVIndent.Properties.MaxValue = New Decimal(New Integer() { 50, 0, 0, 0})
'			Me.seVIndent.EditValueChanged += New System.EventHandler(Me.seVIndent_EditValueChanged)
			' 
			' labelControl1
			' 
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.Name = "labelControl1"
			' 
			' seHIndent
			' 
			Me.seHIndent.AllowDrop = True
			resources.ApplyResources(Me.seHIndent, "seHIndent")
			Me.seHIndent.Name = "seHIndent"
			Me.seHIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seHIndent.Properties.IsFloatValue = False
			Me.seHIndent.Properties.Mask.EditMask = resources.GetString("seHIndent.Properties.Mask.EditMask")
			Me.seHIndent.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
'			Me.seHIndent.EditValueChanged += New System.EventHandler(Me.seHIndent_EditValueChanged)
			' 
			' labelControl3
			' 
			resources.ApplyResources(Me.labelControl3, "labelControl3")
			Me.labelControl3.Name = "labelControl3"
			' 
			' seCustomHeight
			' 
			Me.seCustomHeight.AllowDrop = True
			resources.ApplyResources(Me.seCustomHeight, "seCustomHeight")
			Me.seCustomHeight.Name = "seCustomHeight"
			Me.seCustomHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.seCustomHeight.Properties.IsFloatValue = False
			Me.seCustomHeight.Properties.Mask.EditMask = resources.GetString("seCustomHeight.Properties.Mask.EditMask")
			Me.seCustomHeight.Properties.MaxValue = New Decimal(New Integer() { 250, 0, 0, 0})
			Me.seCustomHeight.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, -2147483648})
'			Me.seCustomHeight.EditValueChanged += New System.EventHandler(Me.seCustomHeight_EditValueChanged)
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.gridControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
			' 
			' gridControl2
			' 
			resources.ApplyResources(Me.gridControl2, "gridControl2")
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemRichTextEdit2, Me.repositoryItemTextEdit1})
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colType2, Me.colCategory, Me.colPrice1, Me.colPrice2})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.GroupCount = 1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsView.ShowPreview = True
			Me.gridView2.PreviewFieldName = "Notes"
			Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCategory, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView2.CustomDrawRowPreview += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView2_CustomDrawRowPreview)
'			Me.gridView2.MeasurePreviewHeight += New DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(Me.gridView2_MeasurePreviewHeight)
			' 
			' colName
			' 
			resources.ApplyResources(Me.colName, "colName")
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			' 
			' colType2
			' 
			resources.ApplyResources(Me.colType2, "colType2")
			Me.colType2.FieldName = "Type"
			Me.colType2.Name = "colType2"
			' 
			' colCategory
			' 
			resources.ApplyResources(Me.colCategory, "colCategory")
			Me.colCategory.FieldName = "Category"
			Me.colCategory.Name = "colCategory"
			' 
			' colPrice1
			' 
			resources.ApplyResources(Me.colPrice1, "colPrice1")
			Me.colPrice1.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colPrice1.FieldName = "PricingWithSourceCode"
			Me.colPrice1.Name = "colPrice1"
			' 
			' repositoryItemTextEdit1
			' 
			resources.ApplyResources(Me.repositoryItemTextEdit1, "repositoryItemTextEdit1")
			Me.repositoryItemTextEdit1.Mask.EditMask = resources.GetString("repositoryItemTextEdit1.Mask.EditMask")
			Me.repositoryItemTextEdit1.Mask.MaskType = (CType(resources.GetObject("repositoryItemTextEdit1.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType))
			Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = (CBool(resources.GetObject("repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat")))
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' colPrice2
			' 
			resources.ApplyResources(Me.colPrice2, "colPrice2")
			Me.colPrice2.ColumnEdit = Me.repositoryItemTextEdit1
			Me.colPrice2.FieldName = "PricingWithoutSourceCode"
			Me.colPrice2.Name = "colPrice2"
			' 
			' repositoryItemRichTextEdit2
			' 
			Me.repositoryItemRichTextEdit2.Name = "repositoryItemRichTextEdit2"
			Me.repositoryItemRichTextEdit2.ShowCaretInReadOnly = False
			' 
			' RTFView
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "RTFView"
'			Me.Load += New System.EventHandler(Me.RTFView_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.seVIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seHIndent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seCustomHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemRichTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private colType As DevExpress.XtraGrid.Columns.GridColumn
		Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private gridControl2 As GridControl
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemRichTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seCustomHeight As DevExpress.XtraEditors.SpinEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seVIndent As DevExpress.XtraEditors.SpinEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents seHIndent As DevExpress.XtraEditors.SpinEdit
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colType2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colPrice2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	End Class
End Namespace
