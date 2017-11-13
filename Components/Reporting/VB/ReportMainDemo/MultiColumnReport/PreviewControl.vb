Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting


Namespace XtraReportsDemos.MultiColumnReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Private components As System.ComponentModel.IContainer = Nothing

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>


        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
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
    End Class
End Namespace

