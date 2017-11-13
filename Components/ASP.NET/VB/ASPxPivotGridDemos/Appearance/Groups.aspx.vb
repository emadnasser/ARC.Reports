Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.XtraPivotGrid

Partial Public Class Features_Groups
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Private Sub GroupsExpandCollapse(ByVal expand As Boolean)
		For Each group As PivotGridGroup In pivotGrid.Groups
			For Each field As PivotGridFieldBase In group
				field.ExpandedInFieldsGroup = expand
			Next field
		Next group
	End Sub
	Protected Sub buttonExpandAll_Click(ByVal sender As Object, ByVal e As EventArgs)
		GroupsExpandCollapse(True)
	End Sub
	Protected Sub buttonCollapseAll_Click(ByVal sender As Object, ByVal e As EventArgs)
		GroupsExpandCollapse(False)
	End Sub
End Class
