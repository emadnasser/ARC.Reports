Imports System

Namespace XtraReportsDemos.HugeAmountRecords
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New Report()
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
