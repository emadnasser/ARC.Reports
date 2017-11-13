Imports System
Imports System.Collections.Generic
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.DataAccess.Excel

Namespace XtraReportsDemos.PollingReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Private showResults As Boolean = False
        Private pollCount As Integer = 3
        Private data As IList(Of ResultingData) = New List(Of ResultingData)()

        Protected Overrides Function CreateReport() As XtraReport
            If showResults Then
                Dim resultingReport As ResultingReport = New XtraReportsDemos.PollingReport.ResultingReport()
                AddHandler resultingReport.PollingLink.PreviewClick, AddressOf Link_PreviewClick
                resultingReport.ResultingReportDS.DataSource = data
                pollCount += 1
                resultingReport.Parameters("paramPollCount").Value = pollCount
                Return resultingReport
            Else
                Dim pollingReport As PollingReport = New XtraReportsDemos.PollingReport.PollingReport()
                AddHandler pollingReport.ResultingLink.PreviewClick, AddressOf Link_PreviewClick
                Return pollingReport
            End If
        End Function
        Private Sub Link_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs)
            showResults = Not showResults
            If TypeOf Report Is PollingReport Then
                CType(Report, PollingReport).UpdateData(data)
            End If
            Report = Nothing
            Activate()
        End Sub
    End Class
End Namespace

