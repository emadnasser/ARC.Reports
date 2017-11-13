Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace XtraReportsDemos.Subreports
    Partial Public Class MasterReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Shared Sub New()
            AddHandler XtraReport.FilterComponentProperties, AddressOf OnFilterDesignProperties
        End Sub
        Private Shared Sub OnFilterDesignProperties(ByVal sender As Object, ByVal e As FilterComponentPropertiesEventArgs)
            If TypeOf e.Component Is SubreportBase AndAlso TypeOf sender Is MasterReport Then
                e.Properties.Remove("ReportSource")
            End If
        End Sub
        Public Sub New()
            InitializeComponent()
            Name = ReportNames.Subreports
            DisplayName = ReportNames.Subreports
        End Sub
        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
            If subreport1.ReportSource IsNot Nothing Then
                subreport1.ApplyParameterBindings()
                subreport1.ReportSource.ApplyFiltering()
                e.Cancel = subreport1.ReportSource.RowCount = 0
            End If
        End Sub
        Private Sub MasterReport_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            If subreport1.ReportSource IsNot Nothing Then
                subreport1.ReportSource.FillDataSource()
            End If
        End Sub
    End Class
End Namespace
