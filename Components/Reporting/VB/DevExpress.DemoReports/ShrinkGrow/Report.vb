Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.ShrinkGrow
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            ''' <summary>
            ''' Required for Windows.Forms Class Composition Designer support
            ''' </summary>
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            Name = ReportNames.ShrinkGrow
            DisplayName = ReportNames.ShrinkGrow
        End Sub


        Private Sub xrLabel4_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel4.BeforePrint
            DirectCast(sender, XRLabel).Text = String.Format("{0} {1}", GetCurrentColumnValue(Of String)("FirstName"), GetCurrentColumnValue("LastName"))
        End Sub

        Private Sub xrLabel5_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel5.BeforePrint
            DirectCast(sender, XRLabel).Text = String.Format("{0}, {1}, {2}", GetCurrentColumnValue(Of String)("Country"), GetCurrentColumnValue(Of String)("City"), GetCurrentColumnValue("Address"))
        End Sub

        Private Sub xrLabel6_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrLabel6.BeforePrint
            Dim dateTime As Date = GetCurrentColumnValue(Of Date)("BirthDate")
            DirectCast(sender, XRLabel).Text = dateTime.ToLongDateString()
        End Sub
    End Class
End Namespace
