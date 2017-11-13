Imports System.Drawing.Printing
Imports System.Linq
Imports DevExpress.XtraReports.Parameters

Namespace XtraReportsDemos.CalculatedFieldsReport
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.CalculatedFieldsReport
            DisplayName = ReportNames.CalculatedFieldsReport
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles MyBase.BeforePrint
            UpdateReportCalculatedField()
        End Sub

        Private Sub UpdateReportCalculatedField()
            Dim columnName As String = GetDescription(CType(ExpressionParameter.LookUpSettings, StaticListLookUpSettings), CStr(ExpressionParameter.Value))
            Dim expressionValue As String = CStr(ExpressionParameter.Value)
            SetReportParameters(columnName, expressionValue)
        End Sub

        Private Sub SetReportParameters(ByVal columnName As String, ByVal expression As String)
            calculatedField1.Expression = expression
            xrTableCell12.Text = columnName
            xrLabel3.Summary.FormatString = "Total " & columnName & " - {0:c}"
            xrLabel3.XlsxFormatString = """Total " & columnName & " - ""$0.00"
        End Sub

        Private Shared Function GetDescription(ByVal lookupSettings As StaticListLookUpSettings, ByVal value As String) As String
            Dim lookup = lookupSettings.LookUpValues.FirstOrDefault(Function(x) CStr(x.Value) = value)
            Return If(lookup IsNot Nothing, lookup.Description, "")
        End Function
    End Class
End Namespace
