Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraTreeList.Demos.Tutorials
	Public Partial Class Editors
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
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
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.treeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			Me.treeListColumn4 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
			Me.treeListColumn5 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.treeListColumn6 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.tabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.splitter1 = New DevExpress.XtraEditors.SplitterControl()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2, Me.treeListColumn3, Me.treeListColumn4, Me.treeListColumn5, Me.treeListColumn6})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(4, 4)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsView.AutoWidth = False
			Me.treeList1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemImageEdit1, Me.repositoryItemMemoExEdit1, Me.repositoryItemSpinEdit1})
			Me.treeList1.Size = New System.Drawing.Size(377, 292)
			Me.treeList1.TabIndex = 6
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Length(cm)"
			Me.treeListColumn1.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.treeListColumn1.FieldName = "Length(cm)"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.VisibleIndex = 1
			Me.treeListColumn1.Width = 77
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AllowFocused = False
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "Common Name"
			Me.treeListColumn2.ColumnEdit = Me.repositoryItemTextEdit1
			Me.treeListColumn2.FieldName = "Common Name"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.VisibleIndex = 0
			Me.treeListColumn2.Width = 132
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AllowFocused = False
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' treeListColumn3
			' 
			Me.treeListColumn3.Caption = "Notes"
			Me.treeListColumn3.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.treeListColumn3.FieldName = "Notes"
			Me.treeListColumn3.Name = "treeListColumn3"
			Me.treeListColumn3.VisibleIndex = 2
			Me.treeListColumn3.Width = 89
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AllowFocused = False
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(250, 150)
            ' 
            ' treeListColumn4
            ' 
            Me.treeListColumn4.Caption = "Picture"
            Me.treeListColumn4.ColumnEdit = Me.repositoryItemImageEdit1
            Me.treeListColumn4.FieldName = "Picture"
            Me.treeListColumn4.Name = "treeListColumn4"
            Me.treeListColumn4.VisibleIndex = 3
            Me.treeListColumn4.Width = 83
            ' 
            ' repositoryItemImageEdit1
            ' 
            Me.repositoryItemImageEdit1.AllowFocused = False
            Me.repositoryItemImageEdit1.AutoHeight = False
            Me.repositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1"
            Me.repositoryItemImageEdit1.PopupFormSize = New System.Drawing.Size(270, 180)
			' 
			' treeListColumn5
			' 
			Me.treeListColumn5.Caption = "Mark"
			Me.treeListColumn5.ColumnEdit = Me.repositoryItemCheckEdit1
			Me.treeListColumn5.FieldName = "Mark"
			Me.treeListColumn5.Name = "treeListColumn5"
			Me.treeListColumn5.VisibleIndex = 4
			Me.treeListColumn5.Width = 73
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' treeListColumn6
			' 
			Me.treeListColumn6.Caption = "RecordDate"
			Me.treeListColumn6.ColumnEdit = Me.repositoryItemDateEdit1
			Me.treeListColumn6.FieldName = "RecordDate"
			Me.treeListColumn6.Name = "treeListColumn6"
			Me.treeListColumn6.VisibleIndex = 5
			Me.treeListColumn6.Width = 107
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AllowFocused = False
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			' 
			' tabControl1
			' 
			Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.tabControl1.Location = New System.Drawing.Point(389, 4)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.Size = New System.Drawing.Size(212, 292)
			Me.tabControl1.TabIndex = 7
'			Me.tabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.tabControl1_SelectedPageChanged);
			' 
			' splitter1
			' 
			Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
			Me.splitter1.Location = New System.Drawing.Point(381, 4)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(8, 292)
			Me.splitter1.TabIndex = 8
			Me.splitter1.TabStop = False
			' 
			' Editors
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.splitter1)
			Me.Controls.Add(Me.tabControl1)
			Me.Name = "Editors"
			Me.Size = New System.Drawing.Size(605, 300)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private repositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private WithEvents tabControl1 As DevExpress.XtraTab.XtraTabControl
		Private splitter1 As DevExpress.XtraEditors.SplitterControl
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn4 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn5 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn6 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
