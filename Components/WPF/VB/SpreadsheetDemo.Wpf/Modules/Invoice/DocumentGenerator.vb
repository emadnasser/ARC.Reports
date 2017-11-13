Imports System
Imports System.Data
Imports System.Collections.Generic
Imports DevExpress.Spreadsheet
Imports System.Text
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraSpreadsheet.Demos
    #Region "InvoiceInMemoryData"
    Friend Class InvoiceInMemoryData
        Public ProductName As String
        Public Price As Double
        Public Quantity As Double
        Public Discount As Double
        Public Sub New(ByVal q As Double)
            ProductName = String.Empty
            Price = 0
            Quantity = q
            Discount = 0
        End Sub

        Public Sub New(ByVal productName As String, ByVal price As Double)
            Me.ProductName = productName
            Me.Price = price
            Quantity = 0
            Discount = 0
        End Sub
    End Class
    #End Region

    Friend Class InvoiceDocumentGenerator
        #Region "Fields"
        Private Const maxItemsInInvoice As Integer = 18
        Private Const goodsStartRow As Integer = 16
        Private Const accountingFormat As String = "_($* #,##0.00_);_($* (#,##0.00);_($* "" - ""??_);_(@_)"
        Private Const amountNumberFormat As String = "_(* #,##0.00_);_(* (#,##0.00);_(* "" - ""??_);_(@_)"
        Private Const dateNumberFormat As String = "mmmm d, yyyy"
        Private Const CurrencyWithRedNegativeAndEmptyZero As String = "_-[$$-409]* #,##0.00_ ;_-[$$-409]* \-#,##0.00\ ;;_-@_ "
        Private Const PercentageWithRedNegativeAndEmptyZero As String = "0.00%;[Red]-0.00%;;@"
        Private Const defaultRegularFontName As String = "Segoe UI"
        Private Const defaultLightFontName As String = "Segoe UI Light"
        Private Const defaultFontSize As Single = 10.5F
        Private ReadOnly watermarkColor As Color = DXColor.FromArgb(&Hff, &HE0, &HE0, &HE0)
        Private ReadOnly goodsEvenColor As Color = DXColor.FromArgb(&Hff, &HF1, &HF1, &HF1)
        Private sheet As Worksheet

        Private workbook_Renamed As IWorkbook
        Public Const FromCompanyId As String = "fromCompany"
        Public Const FromContactNameId As String = "fromContactName"
        Public Const FromEMailId As String = "fromEMail"
        Public Const FromCompanySloganId As String = "fromCompanySlogan"
        Public Const FromAddressId As String = "fromAddress"
        Public Const FromCityId As String = "fromCity"
        Public Const FromStateId As String = "fromState"
        Public Const FromZipId As String = "fromZip"
        Public Const FromPhoneId As String = "fromPhone"
        Public Const FromFaxId As String = "fromFax"
        Public Const ToNameId As String = "toName"
        Public Const ToCompanyId As String = "toCompany"
        Public Const ToStreetId As String = "toStreet"
        Public Const ToCityId As String = "toCity"
        Public Const ToStateId As String = "toState"
        Public Const ToZipId As String = "toZip"
        Public Const ToPhoneId As String = "toPhone"

        Private invoiceParameters_Renamed As Dictionary(Of String, String)

        Private invoiceGoods_Renamed As List(Of InvoiceInMemoryData)

        #End Region

        Public Sub New(ByVal workbook As IWorkbook)
            Me.workbook_Renamed = workbook
            invoiceParameters_Renamed = New Dictionary(Of String, String)()
            invoiceGoods_Renamed = New List(Of InvoiceInMemoryData)()
            InitializeBook()
        End Sub

        Public ReadOnly Property Workbook() As IWorkbook
            Get
                Return workbook_Renamed
            End Get
        End Property
        Public ReadOnly Property InvoiceParameters() As Dictionary(Of String, String)
            Get
                Return invoiceParameters_Renamed
            End Get
        End Property
        Public Property InvoiceGoods() As List(Of InvoiceInMemoryData)
            Get
                Return invoiceGoods_Renamed
            End Get
            Protected Set(ByVal value As List(Of InvoiceInMemoryData))
                invoiceGoods_Renamed = value
            End Set
        End Property

        Public Sub Generate()
            FillInvoiceSheet()
            Workbook.History.Clear()
        End Sub

        Private Sub InitializeBook()
            PrepareBook(Workbook)
        End Sub

        Private Sub FillInvoiceSheet()
            If Not Workbook.Worksheets.Contains(sheet.Name) Then
                Return
            End If

            Workbook.BeginUpdate()
            Try
                Dim usedRange As Range = sheet.GetUsedRange()
                sheet.UnMergeCells(usedRange)
                sheet.Clear(usedRange)

                PrepareColumns(sheet)
                PrepareRows(sheet)

                Dim currentCell As Cell = sheet.Cells(0, 1)
                currentCell.Font.Name = defaultLightFontName
                currentCell.Font.Size = 27
                currentCell.Alignment.Vertical = SpreadsheetVerticalAlignment.Bottom

                currentCell = sheet.Cells(2, 1)
                currentCell.Font.FontStyle = SpreadsheetFontStyle.BoldItalic
                currentCell.Font.Size = 13.5

                SetLeftAlignedBoldValue(sheet.Cells(3, 4), "DATE:")
                SetLeftAlignedBoldValue(sheet.Cells(4, 4), "INVOICE #:")
                SetLeftAlignedBoldValue(sheet.Cells(5, 4), "FOR:")

                PutWatermarkStyleValue(sheet.Cells(0, 5))

                currentCell = sheet.Cells(3, 5)
                currentCell.NumberFormat = dateNumberFormat
                currentCell.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
                currentCell.Formula = "=TODAY()"

                currentCell = sheet.Cells(4, 5)
                currentCell.NumberFormat = "0"
                currentCell.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
                currentCell.Value = 100

                currentCell = sheet.Cells(5, 5)
                currentCell.Alignment.WrapText = True
                currentCell.Font.Italic = True
                currentCell.Value = "Project or service description"

                currentCell = sheet.Cells(7, 1)
                currentCell.Font.Size = 13.5
                currentCell.Font.Bold = True
                currentCell.Value = "BILL TO:"

                FillInvoiceCore()
            Finally
                Workbook.EndUpdate()
            End Try
        End Sub

        Public Sub ApplyParameter(ByVal key As String, ByVal value As String)
            If invoiceParameters_Renamed.ContainsKey(key) Then
                invoiceParameters_Renamed(key) = value
            Else
                invoiceParameters_Renamed.Add(key, value)
            End If
        End Sub

        Private Function GetParameter(ByVal key As String) As String
            Dim result As String = String.Empty
            If Not invoiceParameters_Renamed.TryGetValue(key, result) Then
                result = String.Empty
            End If
            Return result
        End Function

        Public Function GetGoodsAttribute(ByVal key As String, ByVal rowIndex As Integer) As Object
            Dim result As Object = Nothing
            Select Case key
                Case "Quantity"
                    result = invoiceGoods_Renamed(rowIndex).Quantity
                Case "AppendIntoInvoice"
                    result = invoiceGoods_Renamed(rowIndex).Quantity > 0
                Case "Discount"
                    result = invoiceGoods_Renamed(rowIndex).Discount * 100
                Case "ProductName"
                    result = invoiceGoods_Renamed(rowIndex).ProductName
                Case "UnitPrice"
                    result = invoiceGoods_Renamed(rowIndex).Price
            End Select
            Return result
        End Function
        Public Function SetGoodsAttribute(ByVal key As String, ByVal rowIndex As Integer, ByVal value As Object) As Boolean
            Dim result As Boolean = False
            Select Case key
                Case "Quantity"
                    invoiceGoods_Renamed(rowIndex).Quantity = Convert.ToDouble(value)
                Case "AppendIntoInvoice"
                    Dim boolValue As Boolean = Convert.ToBoolean(value)
                    Dim newValue As Double = If(boolValue, 1, 0)
                    invoiceGoods_Renamed(rowIndex).Quantity = newValue
                    result = True
                Case "Discount"
                    invoiceGoods_Renamed(rowIndex).Discount = Convert.ToDouble(value) * 0.01
            End Select
            Return result
        End Function

        Public Sub ClearGoods()
            If invoiceGoods_Renamed Is Nothing Then
                invoiceGoods_Renamed = New List(Of InvoiceInMemoryData)()
            Else
                invoiceGoods_Renamed.Clear()
            End If
        End Sub

        Public Sub AddGoods(ByVal value As InvoiceInMemoryData)
            invoiceGoods_Renamed.Add(value)
        End Sub

        Public Sub SelectRandomGoods()
            If (invoiceGoods_Renamed Is Nothing) OrElse (invoiceGoods_Renamed.Count < 1) Then
                Return
            End If
            Dim random As New Random()
            For i As Integer = 0 To 7
                Dim itemIndex As Integer = random.Next(invoiceGoods_Renamed.Count)
                Dim itemQuantity As Double = random.Next(20) + 1
                invoiceGoods_Renamed(itemIndex).Quantity = itemQuantity
            Next i
        End Sub

        #Region "book default values, sheet names, non-default columns and rows dimensions"
        Private Sub PrepareBook(ByVal book As IWorkbook)
            Dim numberOfSheets As Integer = book.Worksheets.Count
            For i As Integer = numberOfSheets - 1 To 1 Step -1
                book.Worksheets.RemoveAt(i)
            Next i
            book.Unit = Office.DocumentUnit.Point
            book.Styles.DefaultStyle.Font.Name = defaultRegularFontName
            book.Styles.DefaultStyle.Font.Size = defaultFontSize
            book.Styles.DefaultStyle.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            sheet = book.Worksheets(0)
            sheet.Name = "SimpleInvoice"
            sheet.ActiveView.ShowGridlines = False
            sheet.PrintOptions.FitToPage = True
        End Sub

        Private Sub PrepareColumns(ByVal sheet As Worksheet)
            sheet.Columns(0).WidthInCharacters = 6
            sheet.Columns(1).WidthInCharacters = 47.86
            sheet.Columns(2).WidthInCharacters = 12
            sheet.Columns(3).WidthInCharacters = 18
            sheet.Columns(4).WidthInCharacters = 16
            sheet.Columns(5).WidthInCharacters = 21
        End Sub

        Private Sub PrepareRows(ByVal sheet As Worksheet)
            Dim currentRow As Row = sheet.Rows(0)
            currentRow.Height = 52.5

            currentRow = sheet.Rows(2)
            currentRow.Height = Math.Min(sheet.DefaultRowHeight * 2, 400)

            Dim range As Range = sheet("2:6")
            range.Alignment.Vertical = SpreadsheetVerticalAlignment.Top

            currentRow = sheet.Rows(5)
            currentRow.Height = 30

            range = sheet("7:11")
            range.Alignment.Vertical = SpreadsheetVerticalAlignment.Bottom

            range = sheet("16:24")
            range.RowHeight = 21

            range = sheet("37:38")
            range.Alignment.Vertical = SpreadsheetVerticalAlignment.Bottom
        End Sub
        #End Region

        #Region "cell and range decoration primitives"
        Private Sub CreateColumnTitle(ByVal range As Range, ByVal text As String)
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Font.Name = defaultRegularFontName
                style.Font.FontStyle = SpreadsheetFontStyle.Bold
                style.Font.Color = DXColor.FromArgb(&Hff, &H33, &H33, &H33)
                style.Borders.BottomBorder.LineStyle = BorderLineStyle.Medium
                style.Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            Finally
                range.EndUpdateFormatting(style)
            End Try
            range.Value = text
        End Sub

        Private Sub CreateTableColumn(ByVal sheet As Worksheet, ByVal column As Integer, ByVal row As Integer, ByVal rowCount As Integer, ByVal caption As String, ByVal numberFormat As String)
            CreateTableColumn(sheet, column, row, rowCount, caption, numberFormat, Spreadsheet.SpreadsheetHorizontalAlignment.General, 0)
        End Sub

        Private Sub CreateTableColumn(ByVal sheet As Worksheet, ByVal column As Integer, ByVal row As Integer, ByVal rowCount As Integer, ByVal caption As String, ByVal numberFormat As String, ByVal SpreadsheetHorizontalAlignment As Spreadsheet.SpreadsheetHorizontalAlignment, ByVal indent As Integer)
            CreateColumnTitle(sheet.Range.FromLTRB(column, row, column, row), caption)
            Dim range As Range = sheet.Range.FromLTRB(column, row, column, row + rowCount)
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Alignment.Horizontal = SpreadsheetHorizontalAlignment
                If Not String.IsNullOrEmpty(numberFormat) Then
                    style.NumberFormat = numberFormat
                End If
                style.Alignment.Indent = indent
            Finally
                range.EndUpdateFormatting(style)
            End Try
        End Sub

        Private Sub SetCenteredBoldValue(ByVal cell As Cell, ByVal value As String)
            Dim newFmt As Formatting = cell.BeginUpdateFormatting()
            Try
                newFmt.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Center
                newFmt.Font.Bold = True
                newFmt.Font.Name = defaultRegularFontName
                newFmt.Font.Size = 13.5
            Finally
                cell.EndUpdateFormatting(newFmt)
            End Try
            cell.Value = value
        End Sub

        Private Sub SetLeftAlignedBoldValue(ByVal cell As Cell, ByVal text As String)
            Dim newFmt As Formatting = cell.BeginUpdateFormatting()
            Try
                newFmt.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
                newFmt.Font.Name = defaultRegularFontName
                newFmt.Font.Bold = True
                newFmt.Font.Size = defaultFontSize
                newFmt.Font.Color = Color.FromArgb(&HFF, &HBB, &HBA, &HBA)
            Finally
                cell.EndUpdateFormatting(newFmt)
            End Try
            cell.Value = text
        End Sub

        Private Sub PutWatermarkStyleValue(ByVal cell As Cell)
            Dim newFmt As Formatting = cell.BeginUpdateFormatting()
            Try
                newFmt.Font.Size = 36
                newFmt.Font.FontStyle = SpreadsheetFontStyle.BoldItalic
                newFmt.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Right
                newFmt.Alignment.Vertical = SpreadsheetVerticalAlignment.Bottom
                newFmt.Font.Color = watermarkColor
            Finally
                cell.EndUpdateFormatting(newFmt)
            End Try
            cell.Value = "INVOICE"
        End Sub

        Private Sub CreateContactInfoRange(ByVal range As Range)
            range.Merge()
            range.RowHeight = 20
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
                style.Alignment.WrapText = True
            Finally
                range.EndUpdateFormatting(style)
            End Try
        End Sub

        Private Sub SetInvoiceTotalCell(ByVal cell As Cell, ByVal goodsCount As Integer)
            Dim newFmt As Formatting = cell.BeginUpdateFormatting()
            Try
                newFmt.NumberFormat = accountingFormat
                newFmt.Font.Color = DXColor.Black
                newFmt.Fill.BackgroundColor = DXColor.FromArgb(&Hff, &Hea, &Hea, &Hea)
                newFmt.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Center
                newFmt.Font.Size = 13.5
            Finally
                cell.EndUpdateFormatting(newFmt)
            End Try
            Dim formula As String = String.Format("=SUM(F{0}:F{1})", goodsStartRow + 1, goodsStartRow + goodsCount)
            cell.Formula = formula
        End Sub

        Private Sub CreateThankfulRange(ByVal range As Range)
            range.Merge()
            Dim style As Formatting = range.BeginUpdateFormatting()
            Try
                style.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
                style.Font.FontStyle = SpreadsheetFontStyle.BoldItalic
                style.Font.Name = defaultRegularFontName
            Finally
                range.EndUpdateFormatting(style)
            End Try
            range.Value = "THANK YOU FOR YOUR BUSINESS!"
        End Sub
        #End Region


        #Region "Cell values primitives"
        Private Sub ApplySimpleCellValue(ByVal value As String, ByVal column As Integer, ByVal row As Integer)
            Dim currentSheet As Worksheet = Workbook.Worksheets(0)
            Dim currentCell As Cell = currentSheet.Cells(row, column)
            currentCell.Value = value
        End Sub

        Private Sub ApplyComplexCellValue(ByVal column As Integer, ByVal row As Integer, ByVal format As String, ParamArray ByVal values() As Object)
            Dim currentSheet As Worksheet = Workbook.Worksheets(0)
            Dim currentCell As Cell = currentSheet.Cells(row, column)
            Dim formatValues(values.Length - 1) As Object
            For i As Integer = 0 To values.Length - 1
                formatValues(i) = values(i)
            Next i
            currentCell.Value = String.Format(format, values)
        End Sub
        #End Region

        Private Sub CreateVariativePart(ByVal goodsCount As Integer)
            CreateTableColumn(sheet, 1, 15, 18, "Description", String.Empty, Spreadsheet.SpreadsheetHorizontalAlignment.Left, 1)
            CreateTableColumn(sheet, 2, 15, 18, "QTY", String.Empty, Spreadsheet.SpreadsheetHorizontalAlignment.Center, 0)
            CreateTableColumn(sheet, 3, 15, 18, "Price", CurrencyWithRedNegativeAndEmptyZero, Spreadsheet.SpreadsheetHorizontalAlignment.Center, 0)
            CreateTableColumn(sheet, 4, 15, 18, "Discount", PercentageWithRedNegativeAndEmptyZero, Spreadsheet.SpreadsheetHorizontalAlignment.Center, 0)
            CreateTableColumn(sheet, 5, 15, 18, "Amount", CurrencyWithRedNegativeAndEmptyZero, Spreadsheet.SpreadsheetHorizontalAlignment.Center, 0)

            Dim range As String = String.Format("F{0}:F{1}", goodsStartRow + 1, goodsStartRow + goodsCount + 1)
            Dim formula As String = String.Format("C{0}*D{0}*(1-E{0})", goodsStartRow + 1)

            sheet(range).Formula = formula

            Dim totalRowIndex As Integer = goodsStartRow + goodsCount + 1
            SetCenteredBoldValue(sheet.Cells(totalRowIndex, 4), "Total")
            SetInvoiceTotalCell(sheet.Cells(totalRowIndex, 5), goodsCount)

            Dim currentCell As Cell = sheet.Cells(totalRowIndex + 2, 1)
            currentCell.Alignment.Horizontal = Spreadsheet.SpreadsheetHorizontalAlignment.Left
            currentCell.NumberFormat = "0"
            currentCell.Value = "Make all checks payable to Your Company Name"

            CreateContactInfoRange(sheet.Range.FromLTRB(1, totalRowIndex + 3, 5, totalRowIndex + 4))

            CreateThankfulRange(sheet.Range.FromLTRB(1, totalRowIndex + 6, 5, totalRowIndex + 6))
        End Sub

        #Region "Transfer selected products to invoice"
        Private Function PopulateInvoiceGoodsList() As Integer
            Dim goodsCount As Integer = 0
            Dim currentSheet As Worksheet = Workbook.Worksheets(0)
            For i As Integer = 0 To invoiceGoods_Renamed.Count - 1
                If invoiceGoods_Renamed(i).Quantity > 0 Then
                    Dim currentRowIndex As Integer = goodsStartRow + goodsCount
                    Dim currentRow As Row = currentSheet.Rows(currentRowIndex)
                    Dim item As InvoiceInMemoryData = invoiceGoods_Renamed(i)
                    currentRow(1).Value = item.ProductName
                    currentRow(2).Value = item.Quantity
                    currentRow(3).Value = item.Price
                    currentRow(4).Value = item.Discount
                    If (goodsCount Mod 2) <> 0 Then
                        SetRangeFillColor(currentSheet.Range.FromLTRB(1, currentRowIndex, 5, currentRowIndex), goodsEvenColor)
                    End If
                    goodsCount += 1
                    If goodsCount >= maxItemsInInvoice Then
                        Exit For
                    End If
                End If
            Next i
            Return goodsCount
        End Function
        #End Region

        Private Sub SetRangeFillColor(ByVal currentRange As Range, ByVal color As Color)
            Dim newFmt As Formatting = currentRange.BeginUpdateFormatting()
            Try
                newFmt.Fill.BackgroundColor = color
            Finally
                currentRange.EndUpdateFormatting(newFmt)
            End Try
        End Sub

        #Region "Set invoice caption"
        Private Sub FillInvoiceCore()
            ApplySimpleCellValue(GetParameter(FromCompanyId), 1, 0)
            ApplySimpleCellValue(GetParameter(FromCompanySloganId), 1, 2)
            ApplySimpleCellValue(GetParameter(FromAddressId), 1, 3)
            ApplyComplexCellValue(1, 4, "{0}, {1}, {2}", GetParameter(FromCityId), GetParameter(FromStateId), GetParameter(FromZipId))
            ApplyComplexCellValue(1, 5, "Phone: {0}, Fax: {1}", GetParameter(FromPhoneId), GetParameter(FromFaxId))
            ApplySimpleCellValue(GetParameter(ToNameId), 1, 8)
            ApplySimpleCellValue(GetParameter(ToCompanyId), 1, 9)
            ApplySimpleCellValue(GetParameter(ToStreetId), 1, 10)
            ApplyComplexCellValue(1, 11, "{0}, {1}, {2}", GetParameter(ToCityId), GetParameter(ToStateId), GetParameter(ToZipId))
            ApplyComplexCellValue(1, 12, "Phone: {0}", GetParameter(ToPhoneId))
            Dim goodsRowCount As Integer = PopulateInvoiceGoodsList()
            CreateVariativePart(goodsRowCount)
            Dim footerRowIndex As Integer = goodsStartRow + goodsRowCount + 3
            ApplyComplexCellValue(1, footerRowIndex, "Make all checks payable to {0}", GetParameter(FromCompanyId))
            ApplyComplexCellValue(1, footerRowIndex + 1, "If you have any questions concerning this invoice, contact {0}, {1}, {2}", GetParameter(FromContactNameId), GetParameter(FromPhoneId), GetParameter(FromEMailId))
        End Sub

        Private Sub FillInvoice()
            Workbook.BeginUpdate()
            Try
                FillInvoiceCore()
            Finally
                Workbook.EndUpdate()
            End Try
        End Sub
        #End Region
    End Class
End Namespace
