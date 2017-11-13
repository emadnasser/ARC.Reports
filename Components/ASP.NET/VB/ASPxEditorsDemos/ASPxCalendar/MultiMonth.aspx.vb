Imports Microsoft.VisualBasic
Imports System.Web.UI

Partial Public Class ASPxCalendar_MultiMonth
	Inherits Page
	Protected Sub ddlDayNameFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
		Select Case ddlColumnsPerRows.SelectedItem.Value.ToString()
			Case "2x2"
				calendar.Rows = 2
				calendar.Columns = 2
			Case "1x3"
				calendar.Columns = 1
				calendar.Rows = 3
			Case "2x1"
				calendar.Columns = 2
				calendar.Rows = 1
		End Select
	End Sub
End Class
