Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridUnboundMasterView
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
			Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8})
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.Name = "gridView3"
			Me.gridView3.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Product Name"
			Me.gridColumn4.FieldName = "ProductName"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 0
			Me.gridColumn4.Width = 232
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Unit Price"
			Me.gridColumn5.DisplayFormat.FormatString = "c"
			Me.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn5.FieldName = "UnitPrice"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 1
			Me.gridColumn5.Width = 101
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Units In Stock"
			Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn6.FieldName = "UnitsInStock"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 2
			Me.gridColumn6.Width = 101
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridColumn7
			' 
			Me.gridColumn7.Caption = "Units On Order"
			Me.gridColumn7.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn7.FieldName = "UnitsOnOrder"
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.Visible = True
			Me.gridColumn7.VisibleIndex = 3
			Me.gridColumn7.Width = 101
			' 
			' gridColumn8
			' 
			Me.gridColumn8.Caption = "Reorder Level"
			Me.gridColumn8.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn8.FieldName = "ReorderLevel"
			Me.gridColumn8.Name = "gridColumn8"
			Me.gridColumn8.Visible = True
			Me.gridColumn8.VisibleIndex = 4
			Me.gridColumn8.Width = 105
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.gridView3
			gridLevelNode1.RelationName = "Products"
			gridLevelNode2.LevelTemplate = Me.gridView2
			gridLevelNode2.RelationName = "Customers"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2})
			Me.gridControl1.Location = New System.Drawing.Point(8, 8)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(571, 419)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2, Me.gridView1, Me.gridView3})
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Contact Name"
			Me.gridColumn1.FieldName = "ContactName"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 213
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Address"
			Me.gridColumn2.FieldName = "Address"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 236
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Has Discount"
			Me.gridColumn3.FieldName = "HasDiscount"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 191
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableDetailToolTip = True
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(596, 466)
			Me.xtraTabControl1.TabIndex = 5
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.Text = "xtraTabControl1"
'			Me.xtraTabControl1.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(Me.xtraTabControl1_SelectedPageChanged);
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gridControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Padding = New System.Windows.Forms.Padding(8)
			Me.xtraTabPage1.Size = New System.Drawing.Size(587, 435)
			Me.xtraTabPage1.Tag = "IRelationList"
			Me.xtraTabPage1.Text = "IRelationList"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Padding = New System.Windows.Forms.Padding(8)
			Me.xtraTabPage2.Size = New System.Drawing.Size(587, 435)
			Me.xtraTabPage2.Tag = "NestedCollections"
			Me.xtraTabPage2.Text = "Nested Collections"
			' 
			' GridUnboundMasterView
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "GridUnboundMasterView"
			Me.Size = New System.Drawing.Size(596, 466)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridUnboundMasterView_Load);
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
