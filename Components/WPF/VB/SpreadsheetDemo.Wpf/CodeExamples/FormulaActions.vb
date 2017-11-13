Imports System
Imports DevExpress.Spreadsheet
Imports System.Drawing
Imports DevExpress.Utils

Namespace SpreadsheetExamples
    Public NotInheritable Class FormulaActions

        Private Sub New()
        End Sub

        Private Shared Sub UseConstantsAndCalculationOperatorsInFormulas(ByVal workbook As IWorkbook)
'            #Region "#ConstantsAndCalculationOperators"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            workbook.Worksheets(0).Cells("B2").Formula = "= (1+5)*6"

            Dim header As Range = worksheet.Range("A1:B1")
            header(0).Value = "Formula"
            header(1).Value = "Value"
            header.FillColor = Color.LightGray
            header.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center

            worksheet("A2").Value = "'" & worksheet("B2").Formula
'            #End Region ' #ConstantsAndCalculationOperators
        End Sub

        Public Shared Sub R1C1ReferencesInFormulas(ByVal workbook As IWorkbook)
'            #Region "#R1C1ReferencesInFormulas"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            workbook.DocumentSettings.R1C1ReferenceStyle = True
            worksheet.Cells("D2").Formula = "=SUM(RC[-3]:R[9]C[-3])"
            worksheet.Cells("D3").Formula = "=SUM(R2C1:R11C1)"
            worksheet.Cells("A1").Value = "Data"
            worksheet.Range.Parse("R2C1:R11C1", ReferenceStyle.UseDocumentSettings).Formula = "=ROW() - 1"

            worksheet.Cells("B1").ColumnWidthInCharacters = 30
            worksheet.Cells("B1").Value = "Cell Reference Style"
            worksheet.Cells("B2").Value = "Relative R1C1 Cell Reference"
            worksheet.Cells("B3").Value = "Absolute R1C1 Cell Reference"

            worksheet.Cells("C1").ColumnWidthInCharacters = 25
            worksheet.Cells("C1").Value = "Formula"
            worksheet.Cells("C2").Value = "=SUM(RC[-3]:R[9]C[-3])"
            worksheet.Cells("C3").Value = "=SUM(R2C1:R11C1)"

            worksheet.Cells("D1").ColumnWidthInCharacters = 25
            worksheet.Cells("D1").Value = "Value"

            worksheet.Range.Parse("R1C1:R1C4", ReferenceStyle.UseDocumentSettings).FillColor = Color.LightGray
            worksheet.Range.Parse("R1C1:R11C4", ReferenceStyle.UseDocumentSettings).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
'            #End Region ' #R1C1ReferencesInFormulas
        End Sub

        Private Shared Sub UseNamesInFormulas(ByVal workbook As IWorkbook)
'            #Region "#NamesInFormulas"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            Dim range As Range = worksheet("A2:C5")
            range.Name = "myRange"
            worksheet.Cells("F3").Formula = "= SUM(myRange)"

            Dim dataRangeHeader As Range = worksheet.Range("A1:C1")
            worksheet.MergeCells(dataRangeHeader)
            dataRangeHeader.Value = "myRange:"
            dataRangeHeader.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            dataRangeHeader.FillColor = Color.LightGray

            worksheet("A2:C5").Value = 2
            worksheet("A2:C5").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet("A2:C5").Borders.SetOutsideBorders(Color.LightBlue, BorderLineStyle.Medium)

            Dim sumHeader As Range = worksheet.Range("E1:F1")
            worksheet.MergeCells(sumHeader)
            sumHeader.Value = "Sum:"
            sumHeader.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            sumHeader.FillColor = Color.LightGray

            worksheet.Range("E2:F2").ColumnWidthInCharacters = 15
            worksheet.Cells("E2").Value = "Formula:"
            worksheet.Cells("E3").Value = "Value:"
            worksheet.Cells("F2").Value = "= SUM(myRange)"
'            #End Region ' #NamesInFormulas
        End Sub
        Private Shared Sub CreateNamedFormulas(ByVal workbook As IWorkbook)
'            #Region "#CreateNamedFormulas"
            Dim worksheet1 As Worksheet = workbook.Worksheets("Sheet1")
            Dim worksheet2 As Worksheet = workbook.Worksheets("Sheet2")
            worksheet1.DefinedNames.Add("Range_Sum", "=SUM(Sheet1!$A$1:$C$3)")
            workbook.DefinedNames.Add("Range_DoubleSum", "=2*Sheet1!Range_Sum")
            worksheet2.Cells("C2").Formula = "=Sheet1!Range_Sum"
            worksheet2.Cells("C3").Formula = "=Range_DoubleSum"
            worksheet2.Cells("C4").Formula = "=Range_DoubleSum + 100"

            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets("Sheet2")

            worksheet1.Cells("A1").Value = 2
            worksheet1.Cells("B2").Value = 3
            worksheet1.Cells("C3").Value = 4

            worksheet2("A1:C1").FillColor = Color.LightGray
            worksheet2("A1:C1").ColumnWidthInCharacters = 25

            worksheet2.Cells("A1").Value = "Formula Name"
            worksheet2.Cells("B1").Value = "Formula"
            worksheet2.Cells("C1").Value = "Formula Result"

            worksheet2.Cells("A2").Value = "Range_Sum"
            worksheet2.Cells("A3").Value = "Range_DoubleSum"
            worksheet2.Cells("A4").Value = "-"

            worksheet2.Cells("B2").Value = "'=SUM(Sheet1!$A$1:$C$3)"
            worksheet2.Cells("B3").Value = "'=2*Sheet1!Range_Sum"
            worksheet2.Cells("B4").Value = "'=Range_DoubleSum + 100"

            worksheet2("A:C").AutoFitColumns()
'            #End Region ' #CreateNamedFormulas
        End Sub
        Private Shared Sub UseFunctionsInFormulas(ByVal workbook As IWorkbook)
'            #Region "#FunctionsInFormulas"

            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Cells("A2").Value = 15
            worksheet.Range("A3:A5").Value = 3
            worksheet.Cells("A6").Value = 20
            worksheet.Cells("A7").Value = 15.12345
            worksheet.Cells("C2").FormulaInvariant = "= IF(A2<10, ""Normal"", ""Excess"")"
            worksheet.Cells("C3").Formula = "=AVERAGE(A2:A7)"
            worksheet.Cells("C4").FormulaInvariant = "=SUM(A3:A5,A6,100)"
            worksheet.Cells("C5").FormulaInvariant = "=ROUND(SUM(A6,A7),2)"
            worksheet.Cells("C6").Formula = "= Today()"
            worksheet.Cells("C6").NumberFormat = "m/d/yy"
            worksheet.Cells("C7").Formula = "=UPPER(""formula"")"


            Dim header As Range = worksheet.Range("A1:C1")
            header(0).Value = "Data:"
            header(1).Value = "Formula text:"
            header(2).Value = "Formula result:"
            header.Style = workbook.Styles("Header")
            worksheet("A1:A7").Alignment.Indent = 1

            Dim rangeWithFormulas As Range = worksheet.Range("C2:C7")
            Dim rangeWithFormulaDescription As Range = worksheet.Range("B2:B7")

            For index As Integer = rangeWithFormulas.RowCount - 1 To 0 Step -1
                rangeWithFormulaDescription(index).Value = "'" & rangeWithFormulas(index).Formula
            Next index
            worksheet.Range("B1:C7").AutoFitColumns()
'            #End Region ' #FunctionsInFormulas
        End Sub

        Private Shared Sub CreateSharedAndArrayFormulas(ByVal workbook As IWorkbook)
'            #Region "#SharedAndArrayFormulas"
            Dim worksheet As Worksheet = workbook.Worksheets(0)
            worksheet.Cells("A2").Value = 1
            worksheet("A3:A11").Formula = "=SUM(A2+1)"
            worksheet("B2:B11").Formula = "=A2+2"
            worksheet("C2:C13").ArrayFormula = "=A2:A11*B2:B11"
            worksheet("D2:D11").ArrayFormula = "=C2:C11*2"
            worksheet.Range("D12").ArrayFormula = "=SUM(B2:B11*C2:C11*D2:D11)"
            If worksheet.Cells("C13").HasArrayFormula Then
                Dim af As String = worksheet.Cells("C13").ArrayFormula
                worksheet.Cells("C13").GetArrayFormulaRange().ArrayFormula = String.Empty
                worksheet("C2:C11").ArrayFormula = af
            End If

            Dim header As Range = worksheet("A1:D1")
            header.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            header.FillColor = Color.LightGray
            header.Font.Bold = True
            header(0).Value = "Use Shared Formulas:"
            header(2).Value = "Use Array Formulas:"

            worksheet.MergeCells(worksheet.Range("A1:B1"))
            worksheet.MergeCells(worksheet.Range("C1:D1"))
            header.ColumnWidthInCharacters = 10
'            #End Region ' #SharedAndArrayFormulas
        End Sub
    End Class
End Namespace
