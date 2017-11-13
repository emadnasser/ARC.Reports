Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class ASPxListBox_MultiSelect
	Inherits Page
	Private Const DefaultXPath As String = "//Model"
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
	End Sub
	Protected Sub lbModels_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.CallbackEventArgsBase)
		FilterModels(lbFeatures.Items)
		lbModels.DataBind()
	End Sub
	Protected Sub FilterModels(ByVal items As ListEditItemCollection)
		Dim sb As New StringBuilder(DefaultXPath)
		Dim firstAttribute As Boolean = True
		For Each item As ListEditItem In items
			If (Not item.Selected) Then
				Continue For
			End If
			If firstAttribute Then
				firstAttribute = False
				sb.Append("[")
			Else
				sb.Append(" and ")
			End If
			sb.AppendFormat("@{0}=""{1}""", item.Value, item.Selected.ToString().ToLower())
		Next item
		If (Not firstAttribute) Then
			sb.Append("]")
		End If
		PhoneModels.XPath = sb.ToString()
	End Sub
	Protected Sub ResetFiltration()
		lbFeatures.Value = Nothing
		PhoneModels.XPath = DefaultXPath
		lbModels.DataBind()
	End Sub
	Protected Sub lbSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim cb As ASPxComboBox = CType(sender, ASPxComboBox)
		Dim newSelectionMode As ListEditSelectionMode = CType(System.Enum.Parse(GetType(ListEditSelectionMode), cb.SelectedItem.Text), ListEditSelectionMode)
		lbFeatures.SelectionMode = newSelectionMode
		lbModels.SelectionMode = newSelectionMode
		ResetFiltration()
	End Sub
End Class
