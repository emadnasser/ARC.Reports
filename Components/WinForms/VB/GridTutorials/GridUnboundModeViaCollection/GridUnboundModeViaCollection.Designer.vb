Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Partial Class GridUnboundModeViaCollection
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
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(4, 4)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(580, 258)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
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
			Me.gridColumn1.VisibleIndex = 1
			Me.gridColumn1.Width = 181
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Category"
			Me.gridColumn2.FieldName = "Category"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 2
			Me.gridColumn2.Width = 150
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Unit Price"
			Me.gridColumn3.DisplayFormat.FormatString = "c"
			Me.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.gridColumn3.FieldName = "UnitPrice"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 3
			Me.gridColumn3.Width = 125
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Discontinued"
			Me.gridColumn4.FieldName = "Discontinued"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 4
			Me.gridColumn4.Width = 126
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "ID"
			Me.gridColumn5.FieldName = "ID"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.OptionsColumn.ReadOnly = True
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 0
			Me.gridColumn5.Width = 58
			' 
			' GridUnboundModeViaCollection
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "GridUnboundModeViaCollection"
			Me.Size = New System.Drawing.Size(588, 266)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.GridUnboundModeViaCollection_Load);
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
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private components As System.ComponentModel.Container = Nothing

	End Class
End Namespace
