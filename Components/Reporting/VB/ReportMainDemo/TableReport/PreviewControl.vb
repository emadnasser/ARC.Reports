Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.Extensions

Namespace XtraReportsDemos.TableReport
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Private Class TableReportExtension
            Inherits DemoReportExtension

            Public Overrides Function GetEditableDataTypes() As Type()
                Return New Type() { GetType(Integer) }
            End Function
            Protected Overrides Function CreateRepositoryItem(ByVal parameter As Parameter, ByVal dataType As Type, ByVal report As XtraReport) As RepositoryItem
                If parameter.Name = "OrderIdParameter" Then
                    Dim item As New RepositoryItemSpinEdit()
                    item.IsFloatValue = False
                    item.MinValue = 10248
                    item.MaxValue = 11077
                    Return item
                End If
                If parameter.Name = "MaxRowCountParameter" Then
                    Dim item As New RepositoryItemSpinEdit()
                    item.IsFloatValue = False
                    item.MinValue = 1
                    item.MaxValue = Decimal.MaxValue
                    Return item
                End If
                Return Nothing
            End Function
        End Class

        Shared Sub New()
            ReportDesignExtension.RegisterExtension(New TableReportExtension(), XtraReportsDemos.ReportNames.TableReport)
        End Sub

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
        End Sub

        Protected Overrides Function CreateReport() As XtraReport
            Dim report As New Report()
            ReportDesignExtension.AssociateReportWithExtension(report, XtraReportsDemos.ReportNames.TableReport)
            Return report
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

