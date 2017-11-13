Imports DevExpress.XtraReports.Extensions
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.CustomDraw
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>		

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.SuspendLayout()
            ' 
            ' PreviewControl
            ' 
            Me.Name = "PreviewControl"
            Me.ResumeLayout(False)

        End Sub
        #End Region

        Protected Overrides Function CreateReport() As XtraReport
            Dim report As New CustomDraw.Report()
            ReportDesignExtension.AssociateReportWithExtension(report, XtraReportsDemos.ReportNames.CustomDraw)
            Return report
        End Function
    End Class
End Namespace
