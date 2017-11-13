Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Rows_CellMerging
	Inherits Page
	Protected Sub Grid_HtmlDataCellPrepared(ByVal sender As Object, ByVal e As ASPxGridViewTableDataCellEventArgs)
		If e.DataColumn.FieldName <> "ContactTitle" Then
			Return
		End If
		Dim position As String = Convert.ToString(e.CellValue)
		Dim positionIcon As ASPxImage = CType(Grid.FindRowCellTemplateControl(e.VisibleIndex, e.DataColumn, "PositionIcon"), ASPxImage)
		positionIcon.Caption = position
		positionIcon.EmptyImage.IconID = GetIconIDByPosition(position)
	End Sub
	Private Function GetIconIDByPosition(ByVal position As String) As String
		If position = "Sales Representative" Then
			Return "businessobjects_boorder_16x16"
		End If
		If position = "Sales Manager" OrElse position = "Assistant Sales Agent" Then
			Return "businessobjects_boposition_16x16"
		End If
		If position = "Sales Associate" Then
			Return "businessobjects_bodepartment_16x16"
		End If
		If position = "Sales Agent" Then
			Return "businessobjects_boperson_16x16"
		End If
		If position.Contains("Owner") OrElse position = "Order Administrator" Then
			Return "businessobjects_boposition2_16x16"
		End If
		If position = "Marketing Manager" Then
			Return "businessobjects_borole_16x16"
		End If
		If position = "Marketing Assistant" Then
			Return "businessobjects_boemployee_16x16"
		End If
		If position = "Assistant Sales Representative" Then
			Return "businessobjects_boorderitem_16x16"
		End If
		If position = "Accounting Manager" Then
			Return "businessobjects_bouser_16x16"
		End If
		Return String.Empty
	End Function
End Class
