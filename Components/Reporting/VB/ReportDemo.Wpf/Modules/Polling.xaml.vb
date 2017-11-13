Imports System.Collections.Generic
Imports DevExpress.XtraReports
Imports XtraReportsDemos.PollingReport
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraPrinting

Namespace ReportWpfDemo
    Partial Public Class Polling
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class PollingReportViewModel
        Inherits ReportModuleViewModelBase

        Private ReadOnly data As IList(Of ResultingData) = New List(Of ResultingData)()
        Private pollCount As Integer = 3

        Private ReadOnly Property IsPollingReportActive() As Boolean
            Get
                Return TypeOf Report Is PollingReport
            End Get
        End Property

        Protected Overrides Function CreateReport() As IReport
            Return If((Not IsPollingReportActive), CreatePollingReport(), CreateResultingReport())
        End Function

        Private Function CreatePollingReport() As XtraReport
            Return New PollingReport()
        End Function

        Private Function CreateResultingReport() As XtraReport
            Dim resultingReport = New XtraReportsDemos.PollingReport.ResultingReport()
            resultingReport.ResultingReportDS.DataSource = data
            pollCount += 1
            resultingReport.Parameters("paramPollCount").Value = pollCount
            Return resultingReport
        End Function

        Public Sub ChangeReport(ByVal args As DocumentPreviewMouseEventArgs)
            If args.Brick Is Nothing Then
                Return
            End If

            If Not ReferenceEquals(CType(args.Brick, VisualBrick).BrickOwner,If(IsPollingReportActive, DirectCast(Report, PollingReport).ResultingLink, DirectCast(Report, ResultingReport).PollingLink)) Then
                Return
            End If
            If IsPollingReportActive Then
                DirectCast(Report, PollingReport).UpdateData(data)
            End If
            Report = CreateReport()
            Report.CreateDocument()
        End Sub
    End Class
End Namespace
