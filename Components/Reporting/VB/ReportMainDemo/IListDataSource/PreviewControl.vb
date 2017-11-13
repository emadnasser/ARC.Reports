Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports DevExpress.XtraReports

Namespace XtraReportsDemos.IListDatasource
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As XtraReport
            Return New Report()
        End Function
    End Class
End Namespace

