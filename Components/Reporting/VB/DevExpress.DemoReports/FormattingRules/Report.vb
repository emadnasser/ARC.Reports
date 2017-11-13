Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.FormattingRules
    Partial Public Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.FormattingRulesReport
            DisplayName = ReportNames.FormattingRulesReport
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles MyBase.BeforePrint
            UpdateFormattingRule()
        End Sub

        Private Sub UpdateFormattingRule()
            formattingRule1.Condition = CStr(ConditionParameter.Value)
            formattingRule1.ApplyStyle(StyleSheet(CStr(StyleParameter.Value)))
        End Sub
    End Class
End Namespace
