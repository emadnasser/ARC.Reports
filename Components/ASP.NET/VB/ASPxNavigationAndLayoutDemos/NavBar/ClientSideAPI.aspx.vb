Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI
Imports DevExpress.Web.Demos

Partial Public Class NavBar_ClientSideAPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		FillGroupsDropDownList(cbGroups, NavBar.Groups)
		cbGroups.SelectedIndex = 0
		cbItems.SelectedIndex = 0
	End Sub

	Private Sub FillGroupsDropDownList(ByVal comboBox As ASPxComboBox, ByVal groups As NavBarGroupCollection)
		comboBox.Items.Clear()
		For i As Integer = 0 To groups.Count - 1
			comboBox.Items.Add(New ListEditItem(groups(i).Text, groups(i).Name))
		Next i
	End Sub
End Class
