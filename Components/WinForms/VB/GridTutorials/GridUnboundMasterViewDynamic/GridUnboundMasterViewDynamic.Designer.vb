Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridUnboundMasterViewDynamic
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
			Dim gridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode5 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn10, Me.gridColumn11, Me.gridColumn12})
			Me.gridView3.DetailHeight = 300
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.Name = "gridView3"
			Me.gridView3.OptionsDetail.EnableDetailToolTip = True
			Me.gridView3.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn10
			' 
			Me.gridColumn10.Caption = "ID"
			Me.gridColumn10.FieldName = "ID"
			Me.gridColumn10.Name = "gridColumn10"
			Me.gridColumn10.Width = 84
			' 
			' gridColumn11
			' 
			Me.gridColumn11.Caption = "First Name"
			Me.gridColumn11.FieldName = "FirstName"
			Me.gridColumn11.Name = "gridColumn11"
			Me.gridColumn11.Visible = True
			Me.gridColumn11.VisibleIndex = 0
			Me.gridColumn11.Width = 277
			' 
			' gridColumn12
			' 
			Me.gridColumn12.Caption = "Last Name"
			Me.gridColumn12.FieldName = "LastName"
			Me.gridColumn12.Name = "gridColumn12"
			Me.gridColumn12.Visible = True
			Me.gridColumn12.VisibleIndex = 1
			Me.gridColumn12.Width = 279
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.gridView3
			gridLevelNode2.LevelTemplate = Me.gridView5
			gridLevelNode2.RelationName = "Daughters"
			gridLevelNode3.LevelTemplate = Me.gridView4
			gridLevelNode3.RelationName = "Sons"
			gridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode2, gridLevelNode3})
			gridLevelNode1.RelationName = "Employees"
			gridLevelNode4.LevelTemplate = Me.cardView1
			gridLevelNode4.RelationName = "Products"
			gridLevelNode5.LevelTemplate = Me.gridView2
			gridLevelNode5.RelationName = "Customers"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode4, gridLevelNode5})
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(582, 587)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.cardView1, Me.gridView2, Me.gridView1, Me.gridView5, Me.gridView4, Me.gridView3})
			' 
			' cardView1
			' 
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8})
			Me.cardView1.DetailHeight = 150
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Product Name"
			Me.gridColumn4.FieldName = "ProductName"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 0
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
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Units In Stock"
			Me.gridColumn6.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn6.FieldName = "UnitsInStock"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 2
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
			' 
			' gridColumn8
			' 
			Me.gridColumn8.Caption = "Reorder Level"
			Me.gridColumn8.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn8.FieldName = "ReorderLevel"
			Me.gridColumn8.Name = "gridColumn8"
			Me.gridColumn8.Visible = True
			Me.gridColumn8.VisibleIndex = 4
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
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
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn9})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableDetailToolTip = True
'			Me.gridView1.MasterRowGetRelationName += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(Me.gridView1_MasterRowGetRelationName);
'			Me.gridView1.MasterRowEmpty += New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(Me.gridView1_MasterRowEmpty);
'			Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(Me.gridView1_MasterRowGetChildList);
'			Me.gridView1.MasterRowGetRelationCount += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(Me.gridView1_MasterRowGetRelationCount);
'			Me.gridView1.MasterRowGetLevelDefaultView += New DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(Me.gridView1_MasterRowGetLevelDefaultView);
			' 
			' gridColumn9
			' 
			Me.gridColumn9.Caption = "Name"
			Me.gridColumn9.FieldName = "Name"
			Me.gridColumn9.Name = "gridColumn9"
			Me.gridColumn9.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.gridColumn9.Visible = True
			Me.gridColumn9.VisibleIndex = 0
			' 
			' gridView5
			' 
			Me.gridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn15, Me.gridColumn16})
			Me.gridView5.GridControl = Me.gridControl1
			Me.gridView5.Name = "gridView5"
			Me.gridView5.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn15
			' 
			Me.gridColumn15.Caption = "Name"
			Me.gridColumn15.FieldName = "Name"
			Me.gridColumn15.Name = "gridColumn15"
			Me.gridColumn15.Visible = True
			Me.gridColumn15.VisibleIndex = 0
			' 
			' gridColumn16
			' 
			Me.gridColumn16.Caption = "Age"
			Me.gridColumn16.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn16.FieldName = "Age"
			Me.gridColumn16.Name = "gridColumn16"
			Me.gridColumn16.Visible = True
			Me.gridColumn16.VisibleIndex = 1
			' 
			' gridView4
			' 
			Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn13, Me.gridColumn14})
			Me.gridView4.GridControl = Me.gridControl1
			Me.gridView4.Name = "gridView4"
			Me.gridView4.OptionsView.ShowGroupPanel = False
			' 
			' gridColumn13
			' 
			Me.gridColumn13.Caption = "Name"
			Me.gridColumn13.FieldName = "Name"
			Me.gridColumn13.Name = "gridColumn13"
			Me.gridColumn13.Visible = True
			Me.gridColumn13.VisibleIndex = 0
			' 
			' gridColumn14
			' 
			Me.gridColumn14.Caption = "Age"
			Me.gridColumn14.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn14.FieldName = "Age"
			Me.gridColumn14.Name = "gridColumn14"
			Me.gridColumn14.Visible = True
			Me.gridColumn14.VisibleIndex = 1
			' 
			' GridUnboundMasterViewDynamic
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridUnboundMasterViewDynamic"
			Me.Size = New System.Drawing.Size(590, 595)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridUnboundMasterViewDynamic_Load);
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView5 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
		Private components As System.ComponentModel.Container = Nothing
	End Class
End Namespace
