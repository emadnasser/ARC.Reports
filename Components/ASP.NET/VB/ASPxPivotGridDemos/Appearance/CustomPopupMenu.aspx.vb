Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxPivotGrid

Partial Public Class Appearance_CustomPopupMenu
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub pivotGrid_PopupMenuCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotPopupMenuCreatedEventArgs)
		If e.MenuType = DevExpress.Web.ASPxPivotGrid.PivotGridPopupMenuType.FieldValueMenu Then
			Dim item As MenuItem = e.Menu.Items.Add("Filter By This Value", "Filter")
			item.BeginGroup = True
			e.Menu.ClientSideEvents.PopUp = "function ASPxClientMenuItemEventHandler(s, e){" & ControlChars.CrLf & "					//MyCode" & ControlChars.CrLf & "					if(pivotGrid.fieldMenuFieldValueIndex == -1)" & ControlChars.CrLf & "						s.Hide();" & ControlChars.CrLf & "				}"
		End If
	End Sub
	Protected Sub pivotGrid_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotGridCustomCallbackEventArgs)
		If String.IsNullOrEmpty(e.Parameters) Then
			Return
		End If
		Dim args() As String = e.Parameters.Split("|"c)
		Select Case args(0)
			Case "F"
				Dim field As PivotGridField = pivotGrid.Fields(args(1))
				Dim itemIndex As Integer = Int32.Parse(args(2))
				Dim filterValue As Object = pivotGrid.GetFieldValueByIndex(field, itemIndex)
				field.FilterValues.ValuesIncluded = New Object() { filterValue }
		End Select
	End Sub
End Class
