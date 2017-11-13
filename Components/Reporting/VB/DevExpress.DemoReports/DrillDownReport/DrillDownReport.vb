Imports System
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Namespace XtraReportsDemos.DrillDownReport
    Partial Public Class DrillDownReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            AddHandler lbShowHide.BeforePrint, AddressOf lbShowHide_BeforePrint
        End Sub
        Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
            lbShowHide.Text = If(DetailReport.DrillDownExpanded, "Hide Details", "Show Details")
        End Sub
    End Class
End Namespace
