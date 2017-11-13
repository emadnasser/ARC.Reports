Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridUnboundColumns
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPurchaseDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCopies = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.bandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1, Me.repositoryItemMemoExEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(692, 358)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView1})
			' 
			' bandedGridView1
			' 
			Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colID, Me.colFirstName, Me.colLastName, Me.colPurchaseDate, Me.colCopies, Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3, Me.bandedGridColumn4})
			Me.bandedGridView1.CustomizationFormBounds = New System.Drawing.Rectangle(857, 426, 214, 190)
			Me.bandedGridView1.GridControl = Me.gridControl1
			Me.bandedGridView1.Name = "bandedGridView1"
'			Me.bandedGridView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.bandedGridView1_CustomUnboundColumnData);
'			Me.bandedGridView1.CustomColumnDisplayText += New DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(Me.bandedGridView1_CustomColumnDisplayText);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Bound Data (From a Table)"
			Me.gridBand1.Columns.Add(Me.colID)
			Me.gridBand1.Columns.Add(Me.colFirstName)
			Me.gridBand1.Columns.Add(Me.colLastName)
			Me.gridBand1.Columns.Add(Me.colPurchaseDate)
			Me.gridBand1.Columns.Add(Me.colCopies)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 293
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Width = 27
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "First Name"
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.OptionsFilter.AllowFilter = False
			Me.colFirstName.Visible = True
			Me.colFirstName.Width = 66
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "Last Name"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.OptionsFilter.AllowFilter = False
			Me.colLastName.Visible = True
			Me.colLastName.Width = 68
			' 
			' colPurchaseDate
			' 
			Me.colPurchaseDate.Caption = "Purchase Date"
			Me.colPurchaseDate.FieldName = "PurchaseDate"
			Me.colPurchaseDate.Name = "colPurchaseDate"
			Me.colPurchaseDate.Visible = True
			Me.colPurchaseDate.Width = 90
			' 
			' colCopies
			' 
			Me.colCopies.Caption = "Copies"
			Me.colCopies.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colCopies.FieldName = "Copies"
			Me.colCopies.Name = "colCopies"
			Me.colCopies.Visible = True
			Me.colCopies.Width = 69
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.IsFloatValue = False
			Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Unbound Data"
			Me.gridBand2.Columns.Add(Me.bandedGridColumn1)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn4)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn3)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn2)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 385
			' 
			' bandedGridColumn1
			' 
			Me.bandedGridColumn1.Caption = "Full Name"
			Me.bandedGridColumn1.Name = "bandedGridColumn1"
			Me.bandedGridColumn1.OptionsColumn.AllowEdit = False
			Me.bandedGridColumn1.OptionsFilter.AllowFilter = False
			Me.bandedGridColumn1.Visible = True
			Me.bandedGridColumn1.Width = 95
            Me.bandedGridColumn1.FieldName = "bandedGridColumn1"
            Me.bandedGridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String

            ' 
			' bandedGridColumn4
			' 
			Me.bandedGridColumn4.Caption = "Last Support Request"
			Me.bandedGridColumn4.FieldName = "bandedGridColumn4"
			Me.bandedGridColumn4.Name = "bandedGridColumn4"
			Me.bandedGridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.DateTime
			Me.bandedGridColumn4.Visible = True
			Me.bandedGridColumn4.Width = 108
			' 
			' bandedGridColumn3
			' 
			Me.bandedGridColumn3.Caption = "Support Requests"
			Me.bandedGridColumn3.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.bandedGridColumn3.FieldName = "bandedGridColumn3"
			Me.bandedGridColumn3.Name = "bandedGridColumn3"
			Me.bandedGridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.bandedGridColumn3.Visible = True
			Me.bandedGridColumn3.Width = 102
			' 
			' bandedGridColumn2
			' 
			Me.bandedGridColumn2.Caption = "Comments"
			Me.bandedGridColumn2.ColumnEdit = Me.repositoryItemMemoExEdit1
			Me.bandedGridColumn2.FieldName = "bandedGridColumn2"
			Me.bandedGridColumn2.Name = "bandedGridColumn2"
			Me.bandedGridColumn2.OptionsFilter.AllowFilter = False
			Me.bandedGridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.bandedGridColumn2.Visible = True
			Me.bandedGridColumn2.Width = 80
			' 
			' repositoryItemMemoExEdit1
			' 
			Me.repositoryItemMemoExEdit1.AutoHeight = False
			Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
			' 
			' GridUnboundColumns
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridUnboundColumns"
			Me.Size = New System.Drawing.Size(700, 366)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridUnboundColumns_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPurchaseDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCopies As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
