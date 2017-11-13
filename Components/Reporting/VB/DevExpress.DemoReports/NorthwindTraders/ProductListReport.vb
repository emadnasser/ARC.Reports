Imports System
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.NorthwindTraders
    Partial Public Class ProductListReport
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.NorthwindTraders_Products
            DisplayName = ReportNames.NorthwindTraders_Products
        End Sub
    End Class
End Namespace
