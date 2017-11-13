Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Partial Class SimpleMode
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
			Dim multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Dim multiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.multiEditorRow2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.editorRow7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow5 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.multiEditorRow3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.editorRow6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow6 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow11 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(4, 4)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordWidth = 194
			Me.vGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1})
			Me.vGridControl1.RowHeaderWidth = 194
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow5, Me.categoryRow6})
			Me.vGridControl1.Size = New System.Drawing.Size(383, 445)
			Me.vGridControl1.TabIndex = 8
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.AllowFocused = False
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow1, Me.multiEditorRow1, Me.editorRow2, Me.editorRow3, Me.editorRow5, Me.multiEditorRow2, Me.editorRow7, Me.editorRow8})
			Me.categoryRow4.Name = "categoryRow4"
			Me.categoryRow4.Properties.Caption = "Client"
			' 
			' editorRow1
			' 
			Me.editorRow1.Name = "editorRow1"
			Me.editorRow1.Properties.Caption = "Client ID"
			Me.editorRow1.Properties.FieldName = "ClientID"
			Me.editorRow1.Properties.ImageIndex = 0
			Me.editorRow1.Visible = False
			' 
			' multiEditorRow1
			' 
			Me.multiEditorRow1.Name = "multiEditorRow1"
			multiEditorRowProperties1.Caption = "First Name"
			multiEditorRowProperties1.FieldName = "FirstName"
			multiEditorRowProperties1.ImageIndex = 5
			multiEditorRowProperties1.Width = 22
			multiEditorRowProperties2.Caption = "Last Name"
			multiEditorRowProperties2.FieldName = "LastName"
			multiEditorRowProperties2.Width = 18
			Me.multiEditorRow1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { multiEditorRowProperties1, multiEditorRowProperties2})
			' 
			' editorRow2
			' 
			Me.editorRow2.Name = "editorRow2"
			Me.editorRow2.Properties.Caption = "Company Name"
			Me.editorRow2.Properties.FieldName = "CompanyName"
			' 
			' editorRow3
			' 
			Me.editorRow3.Name = "editorRow3"
			Me.editorRow3.Properties.Caption = "Customer"
			Me.editorRow3.Properties.FieldName = "Customer"
			' 
			' editorRow5
			' 
			Me.editorRow5.Name = "editorRow5"
			Me.editorRow5.Properties.Caption = "Gender"
			Me.editorRow5.Properties.FieldName = "Gender"
			' 
			' multiEditorRow2
			' 
			Me.multiEditorRow2.Name = "multiEditorRow2"
			multiEditorRowProperties3.Caption = "Occupation"
			multiEditorRowProperties3.FieldName = "Occupation"
			multiEditorRowProperties4.Caption = "Risk Level"
			multiEditorRowProperties4.FieldName = "RiskLevel"
			Me.multiEditorRow2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { multiEditorRowProperties3, multiEditorRowProperties4})
			' 
			' editorRow7
			' 
			Me.editorRow7.Height = 45
			Me.editorRow7.Name = "editorRow7"
			Me.editorRow7.Properties.Caption = "Interest (Ctrl+Enter - close editor)"
			Me.editorRow7.Properties.FieldName = "Interest"
			Me.editorRow7.Properties.RowEdit = Me.repositoryItemMemoEdit1
			' 
			' editorRow8
			' 
			Me.editorRow8.Name = "editorRow8"
			Me.editorRow8.Properties.Caption = "Date Open"
			Me.editorRow8.Properties.FieldName = "DateOpen"
			' 
			' categoryRow5
			' 
			Me.categoryRow5.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow4, Me.multiEditorRow3, Me.editorRow6})
			Me.categoryRow5.Name = "categoryRow5"
			Me.categoryRow5.Properties.Caption = "Address"
			Me.categoryRow5.Properties.ImageIndex = 6
			' 
			' editorRow4
			' 
			Me.editorRow4.Name = "editorRow4"
			Me.editorRow4.Properties.Caption = "Address"
			Me.editorRow4.Properties.FieldName = "Address"
			' 
			' multiEditorRow3
			' 
			Me.multiEditorRow3.Name = "multiEditorRow3"
			multiEditorRowProperties5.Caption = "City"
			multiEditorRowProperties5.FieldName = "City"
			multiEditorRowProperties5.Width = 18
			multiEditorRowProperties6.Caption = "State"
			multiEditorRowProperties6.FieldName = "State"
			multiEditorRowProperties6.Width = 18
			multiEditorRowProperties7.Caption = "Zip Code"
			multiEditorRowProperties7.FieldName = "ZipCode"
			multiEditorRowProperties7.Width = 24
			Me.multiEditorRow3.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { multiEditorRowProperties5, multiEditorRowProperties6, multiEditorRowProperties7})
			' 
			' editorRow6
			' 
			Me.editorRow6.Name = "editorRow6"
			Me.editorRow6.Properties.Caption = "Phone"
			Me.editorRow6.Properties.FieldName = "Phone"
			' 
			' categoryRow6
			' 
			Me.categoryRow6.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow9, Me.editorRow10, Me.editorRow11})
			Me.categoryRow6.Name = "categoryRow6"
			Me.categoryRow6.Properties.Caption = "Payment Information"
			' 
			' editorRow9
			' 
			Me.editorRow9.Name = "editorRow9"
			Me.editorRow9.Properties.Caption = "Payment Type"
			Me.editorRow9.Properties.FieldName = "PaymentType"
			' 
			' editorRow10
			' 
			Me.editorRow10.Name = "editorRow10"
			Me.editorRow10.Properties.Caption = "Payment Amount"
			Me.editorRow10.Properties.FieldName = "PaymentAmount"
			Me.editorRow10.Properties.Format.FormatString = "c"
			Me.editorRow10.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' editorRow11
			' 
			Me.editorRow11.Name = "editorRow11"
			Me.editorRow11.Properties.Caption = "Payment Date"
			Me.editorRow11.Properties.FieldName = "PaymentDate"
			' 
			' SimpleMode
			' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "SimpleMode"
			Me.Size = New System.Drawing.Size(391, 453)
			Me.TutorialInfo.AboutFile = Nothing
			Me.TutorialInfo.Description = Nothing
			Me.TutorialInfo.TutorialName = Nothing
			Me.TutorialInfo.WhatsThisCodeFile = Nothing
			Me.TutorialInfo.WhatsThisXMLFile = Nothing
'			Me.Load += New System.EventHandler(Me.SimpleMode_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow5 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private multiEditorRow3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private editorRow6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow6 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow11 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private components As System.ComponentModel.IContainer = Nothing

	End Class
End Namespace
