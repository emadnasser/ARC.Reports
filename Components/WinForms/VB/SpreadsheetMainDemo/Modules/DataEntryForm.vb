Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DataEntryFormModule
		Inherits SpreadSheetTutorialControlBase
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = CultureInfo.CurrentCulture
			LoadInvoiceTemplate()
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
			Dim invoice As Worksheet = spreadsheetControl1.Document.Worksheets("Invoice")
			spreadsheetControl1.SelectedCell = invoice("B10")
		End Sub

		Private Sub LoadInvoiceTemplate()
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DevAVInvoicing.xltx"))
			InitializeDateFields()
			BindCustomEditors()
		End Sub

		Private Sub InitializeDateFields()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			Dim invoice As Worksheet = workbook.Worksheets("Invoice")
			invoice("B4").Value = DateTime.Today
			invoice("F18").Value = DateTime.Today.AddDays(14)
		End Sub

		Private Sub BindCustomEditors()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			Dim invoice As Worksheet = workbook.Worksheets("Invoice")

			' Customer (billing address)
			Dim customers As Worksheet = workbook.Worksheets("Customers")
			invoice.CustomCellInplaceEditors.Add(invoice("B10:C10"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(customers("A2:A21")))

			' Customer store (shipping address)
			Dim stores As Worksheet = workbook.Worksheets("Stores")
			invoice.CustomCellInplaceEditors.Add(invoice("G12:I12"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(stores("D5:D204")), True)

			' Sales Rep
			Dim employees As Worksheet = workbook.Worksheets("Employees")
			invoice.CustomCellInplaceEditors.Add(invoice("B18:C18"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(employees("I2:I52")), True)
			' Ship date
			invoice.CustomCellInplaceEditors.Add(invoice("F18:G18"), CustomCellInplaceEditorType.DateEdit)
			' Ship Via
			Dim shipVia() As CellValue = { "Air", "Ground", "Ship" }
			invoice.CustomCellInplaceEditors.Add(invoice("H18:I18"), CustomCellInplaceEditorType.ComboBox, ValueObject.CreateListSource(shipVia))
			' FOB
			invoice.CustomCellInplaceEditors.Add(invoice("J18:K18"), CustomCellInplaceEditorType.Custom, "FOBSpinEdit")
			' Terms
			invoice.CustomCellInplaceEditors.Add(invoice("L18:M18"), CustomCellInplaceEditorType.Custom, "TermsSpinEdit")

			' Quantity
			invoice.CustomCellInplaceEditors.Add(invoice("B22:B25"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
			' Invoice positions
			Dim products As Worksheet = workbook.Worksheets("Products")
			invoice.CustomCellInplaceEditors.Add(invoice("C22:F25"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
			' Discont
			invoice.CustomCellInplaceEditors.Add(invoice("I22:J25"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")

			' Shipping
			invoice.CustomCellInplaceEditors.Add(invoice("K27:M27"), CustomCellInplaceEditorType.Custom, "ShippingSpinEdit")
		End Sub

		Private Sub spreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs) Handles spreadsheetControl1.CustomCellEdit
			If (Not e.ValueObject.IsText) Then
				Return
			End If
			If e.ValueObject.TextValue = "FOBSpinEdit" Then
				e.RepositoryItem = CreateSpinEdit(0, 500, 5)
			ElseIf e.ValueObject.TextValue = "TermsSpinEdit" Then
				e.RepositoryItem = CreateSpinEdit(5, 30, 1)
			ElseIf e.ValueObject.TextValue = "QtySpinEdit" Then
				e.RepositoryItem = CreateSpinEdit(1, 100, 1)
			ElseIf e.ValueObject.TextValue = "DiscountSpinEdit" Then
				e.RepositoryItem = CreateSpinEdit(0, 1000, 10)
			ElseIf e.ValueObject.TextValue = "ShippingSpinEdit" Then
				e.RepositoryItem = CreateSpinEdit(10, 1000, 5)
			End If
		End Sub

		Private Function CreateSpinEdit(ByVal minValue As Integer, ByVal maxValue As Integer, ByVal increment As Integer) As RepositoryItemSpinEdit
			Dim editor As New RepositoryItemSpinEdit()
			editor.AutoHeight = False
			editor.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			editor.MinValue = minValue
			editor.MaxValue = maxValue
			editor.Increment = increment
			editor.IsFloatValue = False
			Return editor
		End Function

		Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spreadsheetControl1.SelectionChanged
			EnableControls()
			ActivateEditor()
		End Sub

		Private Sub EnableControls()
			Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
			If sheet.Name = "Invoice" Then
				Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
				btnRemoveRecord.Enabled = invoiceItems IsNot Nothing AndAlso invoiceItems.Range.RowCount > 1 AndAlso invoiceItems.Range.IsIntersecting(sheet.SelectedCell)
			Else
				btnRemoveRecord.Enabled = False
			End If
		End Sub

		Private Sub ActivateEditor()
			Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
			If sheet.Name = "Invoice" Then
				Dim editors As IList(Of CustomCellInplaceEditor) = sheet.CustomCellInplaceEditors.GetCustomCellInplaceEditors(sheet.Selection)
				If editors.Count = 1 Then
					spreadsheetControl1.OpenCellEditor(DevExpress.XtraSpreadsheet.CellEditorMode.Edit)
				End If
			End If
		End Sub

		Private Sub spreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs) Handles spreadsheetControl1.CellValueChanged
			If e.Action = CellValueChangedAction.UndoRedo OrElse e.OldValue Is e.Cell.Value OrElse e.Cell.GetReferenceA1(ReferenceElement.IncludeSheetName) <> "Invoice!B10" Then
				Return
			End If
			Dim invoice As Worksheet = e.Worksheet
			Dim customerStores As Worksheet = spreadsheetControl1.Document.Worksheets("Stores")
			' Apply filter to customer's stores
			Dim customerId As String = invoice("B11").Value.TextValue
			Dim storesTable As Table = customerStores.Tables(0)
			storesTable.AutoFilter.Clear()
			storesTable.AutoFilter.Columns(1).ApplyFilterCriteria(customerId)
			' Select default store
			Dim range As Range = storesTable.DataRange
			For rowOffset As Integer = 0 To range.RowCount - 1
				If range(rowOffset, 1).Value.TextValue = customerId Then
					invoice("G12").Value = range(rowOffset, 3).Value.TextValue
					Return
				End If
			Next rowOffset
			invoice("G12").Value = CellValue.Empty
		End Sub

		Private Sub btnRemoveRecord_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnRemoveRecord.ItemClick
			Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
			If sheet.Name = "Invoice" Then
				If spreadsheetControl1.IsCellEditorActive Then
					spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel)
				End If
				sheet.Rows.Remove(sheet.SelectedCell.TopRowIndex, 1)
				EnableControls()
				ActivateEditor()
			End If
		End Sub

		Private Sub btnAddRecord_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles btnAddRecord.ItemClick
			Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
			If sheet.Name = "Invoice" Then
				If spreadsheetControl1.IsCellEditorActive Then
					spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel)
				End If
				AddRecord(sheet)
				EnableControls()
				ActivateEditor()
			End If
		End Sub

		' Add record to invoice
		Private Sub AddRecord(ByVal sheet As Worksheet)
			spreadsheetControl1.BeginUpdate()
			Try
				Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
				Dim rowIndex As Integer = invoiceItems.Range.BottomRowIndex
				sheet.Rows.Insert(rowIndex)
				sheet.Rows(rowIndex).Height = sheet.Rows(rowIndex + 1).Height
				Dim range As Range = invoiceItems.Range
				Dim itemRange As Range = sheet.Range.FromLTRB(range.LeftColumnIndex, range.BottomRowIndex, range.RightColumnIndex, range.BottomRowIndex)
				If range.RowCount = 1 Then
					sheet("K24").FormulaInvariant = "=SUM(K22:K23)"
					invoiceItems.Range = sheet.Range.FromLTRB(range.LeftColumnIndex, range.TopRowIndex - 1, range.RightColumnIndex, range.BottomRowIndex).GetRangeWithAbsoluteReference()
					RecreateCustomEditors()
				End If
				MoveUpLastRecord(itemRange)
				InitializeRecord(itemRange)
				spreadsheetControl1.SelectedCell = itemRange(1)
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub

		Private Sub RecreateCustomEditors()
			Dim workbook As IWorkbook = spreadsheetControl1.Document
			Dim invoice As Worksheet = workbook.Worksheets("Invoice")
			Dim products As Worksheet = workbook.Worksheets("Products")

			' Remove custom editors
			invoice.CustomCellInplaceEditors.Remove(invoice("B23:M23"))

			' Quantity
			invoice.CustomCellInplaceEditors.Add(invoice("B22:B23"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
			' Invoice positions
			invoice.CustomCellInplaceEditors.Add(invoice("C22:F23"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
			' Discont
			invoice.CustomCellInplaceEditors.Add(invoice("I22:J23"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")
		End Sub

		' Move last record one row up
		Private Sub MoveUpLastRecord(ByVal itemRange As Range)
			Dim range As Range = itemRange.Offset(-1, 0)
			range.CopyFrom(itemRange, PasteSpecial.All, True)
		End Sub

		' Setup new record values 
		Private Sub InitializeRecord(ByVal itemRange As Range)
			itemRange(0).Value = 1 ' Qty
			itemRange(1).Value = CellValue.Empty ' Product
			itemRange(7).Value = 0 ' Discount
		End Sub

		' Suppress protection warning
		Private Sub spreadsheetControl1_ProtectionWarning(ByVal sender As Object, ByVal e As HandledEventArgs) Handles spreadsheetControl1.ProtectionWarning
			e.Handled = True
		End Sub

		' Load invoice template on empty document created
		Private Sub spreadsheetControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs) Handles spreadsheetControl1.EmptyDocumentCreated
			LoadInvoiceTemplate()
		End Sub

		' Mark data entry fields
		Private Sub spreadsheetControl1_CustomDrawCell(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs) Handles spreadsheetControl1.CustomDrawCell
			Dim cellReference As String = e.Cell.GetReferenceA1()
			If e.Cell.Worksheet.Name <> "Invoice" OrElse (cellReference <> "A10" AndAlso cellReference <> "F12") Then
				Return
			End If
			e.Handled = True
			e.DrawDefault()
			Using font As New Font(e.Font.Name, 14f, FontStyle.Bold)
				Dim text As String = "*"
				Dim size As SizeF = e.Graphics.MeasureString(text, font, Int32.MaxValue, StringFormat.GenericDefault)
				Dim textBounds As New RectangleF(e.Bounds.Right - size.Width - 2, e.Bounds.Bottom - size.Height * 0.7f, size.Width + 2, size.Height)
				e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(Color.Red), textBounds, StringFormat.GenericDefault)
			End Using
		End Sub
	End Class
End Namespace
