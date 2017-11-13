Imports System
Imports System.ComponentModel
Imports System.Collections
Imports System.Diagnostics
Imports DevExpress.XtraReports.UI
Imports System.IO

Namespace XtraReportsDemos.OddEvenStyles
    Partial Public Class Report
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            Name = ReportNames.OddEvenStyles
            DisplayName = ReportNames.OddEvenStyles
            ' this.productsTableAdapter1.Fill(this.dsOddEvenStyles1.Products);
        End Sub

    End Class
End Namespace
