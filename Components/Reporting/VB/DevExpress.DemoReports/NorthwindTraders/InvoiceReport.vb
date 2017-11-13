Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.NorthwindTraders
    Partial Public Class InvoiceReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private Total As Double = 0.0F
        Public Sub New()
            InitializeComponent()

            Name = ReportNames.NorthwindTraders_Invoice
            DisplayName = ReportNames.NorthwindTraders_Invoice
        End Sub

        Private Sub lbShipCityRegionPostalCode_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbShipCityRegionPostalCode.BeforePrint
            DirectCast(sender, XRLabel).Text = GetColumnValue("ShipCity") & "  " & GetColumnValue("ShipRegion") & "  " & GetColumnValue("ShipPostalCode")
        End Sub
        Private Sub lbCityRegionPostalCode_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbCityRegionPostalCode.BeforePrint
            DirectCast(sender, XRLabel).Text = GetColumnValue("City") & "  " & GetColumnValue("Region") & "  " & GetColumnValue("PostalCode")
        End Sub
        Private Function GetColumnValue(ByVal columnValue As String) As String
            If GetCurrentColumnValue(columnValue) IsNot Nothing Then
                Return GetCurrentColumnValue(columnValue).ToString()
            End If
            Return "  "
        End Function
        Private Sub clTotal_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles clTotal.BeforePrint
            Dim cell As XRTableCell = TryCast(sender, XRTableCell)
            Total = Convert.ToDouble(clSubtotal.Summary.GetResult()) + Convert.ToDouble(GetCurrentColumnValue("Freight"))
            Dim s As String = String.Format("{0:'Total: '$#,##.00}", Total)
            cell.Text = s
        End Sub
    End Class
End Namespace
