Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class Menu_ClientSideAPI
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		cbItems.Items.Clear()
		FillComboBox(cbItems, menu.Items)
		cbItems.SelectedIndex = 0
	End Sub
	Private Sub FillComboBox(ByVal comboBox As ASPxComboBox, ByVal items As MenuItemCollection)
		For i As Integer = 0 To items.Count - 1
			comboBox.Items.Add(items(i).Text, items(i).Name)
		Next i
	End Sub
End Class
