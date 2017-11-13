Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.BarCodes
    Partial Public Class ProductLabelsReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.BarCodes_ProductLabels
            DisplayName = ReportNames.BarCodes_ProductLabels
        End Sub
    End Class
End Namespace
