Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.FormattingRules
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Function CreateReport() As XtraReport
            Return New XtraReportsDemos.FormattingRules.Report()
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
