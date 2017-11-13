Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridRelations
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
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.CardCaptionFormat = "Order ID: {1}"
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn6, Me.gridColumn7, Me.gridColumn8, Me.gridColumn9})
			Me.cardView1.DetailHeight = 150
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "Order ID"
			Me.gridColumn6.FieldName = "OrderID"
			Me.gridColumn6.Name = "gridColumn6"
			' 
			' gridColumn7
			' 
			Me.gridColumn7.Caption = "Unit Price"
			Me.gridColumn7.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn7.DisplayFormat.FormatString = "c"
			Me.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn7.FieldName = "UnitPrice"
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.Visible = True
			Me.gridColumn7.VisibleIndex = 0
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridColumn8
			' 
			Me.gridColumn8.Caption = "Quantity"
			Me.gridColumn8.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.gridColumn8.FieldName = "Quantity"
			Me.gridColumn8.Name = "gridColumn8"
			Me.gridColumn8.Visible = True
			Me.gridColumn8.VisibleIndex = 1
			' 
			' repositoryItemSpinEdit2
			' 
			Me.repositoryItemSpinEdit2.AutoHeight = False
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.IsFloatValue = False
			Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' gridColumn9
			' 
			Me.gridColumn9.Caption = "Discount"
			Me.gridColumn9.DisplayFormat.FormatString = "p"
			Me.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn9.FieldName = "Discount"
			Me.gridColumn9.Name = "gridColumn9"
			Me.gridColumn9.Visible = True
			Me.gridColumn9.VisibleIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			gridLevelNode1.LevelTemplate = Me.cardView1
			gridLevelNode1.RelationName = "OrderDetails"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(588, 358)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.cardView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Product Name"
			Me.gridColumn1.FieldName = "ProductName"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 204
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Unit Price"
			Me.gridColumn2.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.gridColumn2.DisplayFormat.FormatString = "c"
			Me.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn2.FieldName = "UnitPrice"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 97
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Quantity Per Unit"
			Me.gridColumn3.FieldName = "QuantityPerUnit"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 132
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Units In Stock"
			Me.gridColumn4.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.gridColumn4.FieldName = "UnitsInStock"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			Me.gridColumn4.Width = 103
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "Discontinued"
			Me.gridColumn5.FieldName = "Discontinued"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 4
			Me.gridColumn5.Width = 104
			' 
			' GridRelations
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridRelations"
			Me.Size = New System.Drawing.Size(596, 366)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridRelations_Load);
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
