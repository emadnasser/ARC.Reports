Imports Microsoft.VisualBasic
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CustomInplaceEditors
		Inherits SpreadsheetRibbonTutorialControlBase
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("CustomInplaceEditors_template.xlsx"), DocumentFormat.Xlsx)
		End Sub

		Protected Friend Overrides Sub SubscribeEvents()
			MyBase.SubscribeEvents()
			AddHandler spreadsheetControl1.DocumentLoaded, AddressOf spreadsheetControl1_DocumentLoaded
			AddHandler spreadsheetControl1.CustomCellEdit, AddressOf spreadsheetControl1_CustomCellEdit
		End Sub
		Private Sub spreadsheetControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
			BindCustomEditors()
		End Sub
		Private Sub BindCustomEditors()
			Dim sheet As Worksheet = spreadsheetControl1.Document.Worksheets("Sales report")

			Dim dateEditRange As Range = sheet("Table[Order Date]")
			sheet.CustomCellInplaceEditors.Add(dateEditRange, CustomCellInplaceEditorType.DateEdit)

			Dim comboBoxRange As Range = sheet("Table[Category]")
			sheet.CustomCellInplaceEditors.Add(comboBoxRange, CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(sheet("J3:J9")))

			Dim checkBoxRange As Range = sheet("Table[Discount]")
			sheet.CustomCellInplaceEditors.Add(checkBoxRange, CustomCellInplaceEditorType.CheckBox)

			Dim customRange As Range = sheet("Table[Qty]")
			sheet.CustomCellInplaceEditors.Add(customRange, CustomCellInplaceEditorType.Custom, "MySpinEdit")
		End Sub

		Private Sub spreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs)
			If e.ValueObject.IsText AndAlso e.ValueObject.TextValue = "MySpinEdit" Then
				Dim editor As New RepositoryItemSpinEdit()
				editor.AutoHeight = False
				editor.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
				editor.MinValue = 1
				editor.MaxValue = 1000
				editor.IsFloatValue = False
				e.RepositoryItem = editor
			End If
		End Sub
	End Class
End Namespace
