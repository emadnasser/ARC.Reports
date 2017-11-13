Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CalculatedFieldsReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Return New XtraReportsDemos.CalculatedFieldsReport.Report()
        End Function

        Private Overloads Sub InitializeComponent()
            Me.SuspendLayout()
            '
            ' PreviewControl
            '
            Me.Name = "PreviewControl"
            Me.ResumeLayout(False)
        End Sub
    End Class
End Namespace
