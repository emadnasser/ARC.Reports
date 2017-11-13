Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.Data
Imports DevExpress.Web.ASPxTreeList

Partial Public Class Summary_Custom
	Inherits Page
	Protected Sub treeList_CustomSummaryCalculate(ByVal sender As Object, ByVal e As TreeListCustomSummaryEventArgs)
		Select Case e.SummaryProcess
			Case CustomSummaryProcess.Start
				e.Value = CDec(0)
			Case CustomSummaryProcess.Calculate
				If e.Node.Selected Then
					e.Value = CDec(e.Value) + CDec(e.Node("Budget"))
				End If
		End Select
	End Sub
End Class
