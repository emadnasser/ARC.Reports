Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace XtraReportsDemos.PivotGridAndChart
    Partial Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Protected Overrides Function CreateReport() As DevExpress.XtraReports.UI.XtraReport
            Return New XtraReportsDemos.PivotGridAndChart.Report()
        End Function
    End Class
End Namespace
