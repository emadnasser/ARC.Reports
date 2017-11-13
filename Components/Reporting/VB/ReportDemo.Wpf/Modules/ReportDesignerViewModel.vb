Imports System.Windows.Input
Imports DevExpress.Mvvm
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI

Namespace ReportWpfDemo
    Public Class ReportDesignerViewModel
        Inherits ImmutableObject

        Private privateReport As XtraReport
        Public Property Report() As XtraReport
            Get
                Return privateReport
            End Get
            Private Set(ByVal value As XtraReport)
                privateReport = value
            End Set
        End Property
        Private privateReportSavedCommand As ICommand
        Public Property ReportSavedCommand() As ICommand
            Get
                Return privateReportSavedCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateReportSavedCommand = value
            End Set
        End Property
        Private privateSaved As Boolean
        Public Property Saved() As Boolean
            Get
                Return privateSaved
            End Get
            Private Set(ByVal value As Boolean)
                privateSaved = value
            End Set
        End Property

        Public Sub New(ByVal report As XtraReport)
            Guard.ArgumentNotNull(report, "report")
            ReportSavedCommand = New DelegateCommand(AddressOf OnReportSaved)
            Me.Report = report
        End Sub

        Private Sub OnReportSaved()
            Saved = True
        End Sub
    End Class
End Namespace
