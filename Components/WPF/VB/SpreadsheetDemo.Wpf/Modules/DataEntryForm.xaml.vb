Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Spreadsheet

Namespace SpreadsheetDemo
    Partial Public Class DataEntryForm
        Inherits SpreadsheetDemoModule

        Public Sub New()
            InitializeComponent()
            SubscribeEvents()
            SetupOptions()
            LoadInvoiceTemplate()
            ribbonControl1.SelectedPage = pageFile
        End Sub

        Private Sub SubscribeEvents()
            AddHandler spreadsheetControl1.Loaded, AddressOf spreadsheetControl1_Loaded
            AddHandler spreadsheetControl1.CustomCellEdit, AddressOf spreadsheetControl1_CustomCellEdit
        End Sub

        Private Sub SetupOptions()
            spreadsheetControl1.Options.Culture = CultureInfo.CurrentCulture
            spreadsheetControl1.Options.RaiseEventsOnModificationsViaAPI = True
            spreadsheetControl1.Options.View.ShowPrintArea = False
        End Sub

        Private Sub LoadInvoiceTemplate()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DevAVInvoicing.xltx"))
            InitializeDateFields()
            BindCustomEditors()
            spreadsheetControl1.CellTemplateSelector = TryCast(spreadsheetControl1.TryFindResource("EntryFieldTemplateSelector"), DataTemplateSelector)
        End Sub

        Private Sub InitializeDateFields()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim invoice As Worksheet = workbook.Worksheets("Invoice")
            invoice("B4").Value = Date.Today
            invoice("F18").Value = Date.Today.AddDays(14)
        End Sub

        Private Sub BindCustomEditors()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim invoice As Worksheet = workbook.Worksheets("Invoice")
            Dim customers As Worksheet = workbook.Worksheets("Customers")
            invoice.CustomCellInplaceEditors.Add(invoice("B10:C10"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(customers("A2:A21")))
            Dim stores As Worksheet = workbook.Worksheets("Stores")
            invoice.CustomCellInplaceEditors.Add(invoice("G12:I12"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(stores("D5:D204")), True)
            Dim employees As Worksheet = workbook.Worksheets("Employees")
            invoice.CustomCellInplaceEditors.Add(invoice("B18:C18"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(employees("I2:I52")), True)
            invoice.CustomCellInplaceEditors.Add(invoice("F18:G18"), CustomCellInplaceEditorType.DateEdit)
            Dim shipVia() As CellValue = { "Air", "Ground", "Ship" }
            invoice.CustomCellInplaceEditors.Add(invoice("H18:I18"), CustomCellInplaceEditorType.ComboBox, ValueObject.CreateListSource(shipVia))
            invoice.CustomCellInplaceEditors.Add(invoice("J18:K18"), CustomCellInplaceEditorType.Custom, "FOBSpinEdit")
            invoice.CustomCellInplaceEditors.Add(invoice("L18:M18"), CustomCellInplaceEditorType.Custom, "TermsSpinEdit")
            invoice.CustomCellInplaceEditors.Add(invoice("B22:B25"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
            Dim products As Worksheet = workbook.Worksheets("Products")
            invoice.CustomCellInplaceEditors.Add(invoice("C22:F25"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
            invoice.CustomCellInplaceEditors.Add(invoice("I22:J25"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")
            invoice.CustomCellInplaceEditors.Add(invoice("K27:M27"), CustomCellInplaceEditorType.Custom, "ShippingSpinEdit")
        End Sub

        Private Sub spreadsheetControl1_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            spreadsheetControl1.Dispatcher.BeginInvoke(New Action(Sub() spreadsheetControl1.SelectedCell = spreadsheetControl1.ActiveWorksheet("B10")), System.Windows.Threading.DispatcherPriority.Render)
        End Sub

        Private Sub spreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As DevExpress.Xpf.Spreadsheet.SpreadsheetCustomCellEditEventArgs)
            If Not e.ValueObject.IsText Then
                Return
            End If
            If e.ValueObject.TextValue = "FOBSpinEdit" Then
                e.EditSettings = CreateSpinEditSettings(0, 500, 5)
            ElseIf e.ValueObject.TextValue = "TermsSpinEdit" Then
                e.EditSettings = CreateSpinEditSettings(5, 30, 1)
            ElseIf e.ValueObject.TextValue = "QtySpinEdit" Then
                e.EditSettings = CreateSpinEditSettings(1, 100, 1)
            ElseIf e.ValueObject.TextValue = "DiscountSpinEdit" Then
                e.EditSettings = CreateSpinEditSettings(0, 1000, 10)
            ElseIf e.ValueObject.TextValue = "ShippingSpinEdit" Then
                e.EditSettings = CreateSpinEditSettings(10, 1000, 5)
            End If
        End Sub

        Private Function CreateSpinEditSettings(ByVal minValue As Integer, ByVal maxValue As Integer, ByVal increment As Integer) As SpinEditSettings
            Dim settings As New SpinEditSettings()
            settings.MinValue = minValue
            settings.MaxValue = maxValue
            settings.Increment = increment
            settings.IsFloatValue = False
            Return settings
        End Function

        Private Sub EnableControls()
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            If sheet.Name = "Invoice" Then
                Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
                btnRemoveRecord.IsEnabled = invoiceItems IsNot Nothing AndAlso invoiceItems.Range.RowCount > 1 AndAlso invoiceItems.Range.IsIntersecting(sheet.SelectedCell)
            Else
                btnRemoveRecord.IsEnabled = False
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

        Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            EnableControls()
            ActivateEditor()
        End Sub

        Private Sub spreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs)
            If e.Action = DevExpress.XtraSpreadsheet.CellValueChangedAction.UndoRedo OrElse e.OldValue = e.Cell.Value OrElse e.Cell.GetReferenceA1(ReferenceElement.IncludeSheetName) <> "Invoice!B10" Then
                Return
            End If
            Dim invoice As Worksheet = e.Worksheet
            Dim customerStores As Worksheet = spreadsheetControl1.Document.Worksheets("Stores")
            Dim customerId As String = invoice("B11").Value.TextValue
            Dim storesTable As Table = customerStores.Tables(0)
            storesTable.AutoFilter.Clear()
            storesTable.AutoFilter.Columns(1).ApplyFilterCriteria(customerId)
            Dim range As Range = storesTable.DataRange
            For rowOffset As Integer = 0 To range.RowCount - 1
                If range(rowOffset, 1).Value.TextValue = customerId Then
                    invoice("G12").Value = range(rowOffset, 3).Value.TextValue
                    Return
                End If
            Next rowOffset
            invoice("G12").Value = CellValue.Empty
        End Sub

        Private Sub btnRemoveRecord_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            If sheet.Name = "Invoice" Then
                If spreadsheetControl1.IsCellEditorActive Then
                    spreadsheetControl1.CloseCellEditor(DevExpress.XtraSpreadsheet.CellEditorEnterValueMode.Cancel)
                End If
                sheet.Rows.Remove(sheet.SelectedCell.TopRowIndex, 1)
                EnableControls()
                ActivateEditor()
            End If
        End Sub

        Private Sub btnAddRecord_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            If sheet.Name = "Invoice" Then
                If spreadsheetControl1.IsCellEditorActive Then
                    spreadsheetControl1.CloseCellEditor(DevExpress.XtraSpreadsheet.CellEditorEnterValueMode.Cancel)
                End If
                AddRecord(sheet)
                EnableControls()
                ActivateEditor()
            End If
        End Sub
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
            invoice.CustomCellInplaceEditors.Remove(invoice("B23:M23"))
            invoice.CustomCellInplaceEditors.Add(invoice("B22:B23"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
            invoice.CustomCellInplaceEditors.Add(invoice("C22:F23"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
            invoice.CustomCellInplaceEditors.Add(invoice("I22:J23"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")
        End Sub
        Private Sub MoveUpLastRecord(ByVal itemRange As Range)
            Dim range As Range = itemRange.Offset(-1, 0)
            range.CopyFrom(itemRange, PasteSpecial.All, True)
        End Sub
        Private Sub InitializeRecord(ByVal itemRange As Range)
            itemRange(0).Value = 1
            itemRange(1).Value = CellValue.Empty
            itemRange(7).Value = 0
        End Sub

        Private Sub spreadsheetControl1_ProtectionWarning(ByVal sender As Object, ByVal e As System.ComponentModel.HandledEventArgs)
            e.Handled = True
        End Sub

        Private Sub spreadsheetControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            LoadInvoiceTemplate()
        End Sub
    End Class

    Public Class EntryFieldTemplateSelector
        Inherits DataTemplateSelector

        Private customTemplateCells As New List(Of String)() From {"B10", "G12"}

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim data As CellData = TryCast(item, CellData)
            Return If(CanApplyCustomTemplate(data.Cell.GetReferenceA1()), GetCellTemplate(data.Cell, CType(container, SpreadsheetControl)), MyBase.SelectTemplate(item, container))
        End Function

        Private Function CanApplyCustomTemplate(ByVal cellPosition As String) As Boolean
            Return customTemplateCells.Contains(cellPosition)
        End Function

        Private Function GetCellTemplate(ByVal cell As DevExpress.Spreadsheet.Cell, ByVal control As SpreadsheetControl) As DataTemplate
            Return TryCast(control.TryFindResource("EntryFieldTemplate"), DataTemplate)
        End Function
    End Class

End Namespace
