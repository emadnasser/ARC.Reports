Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Utils
Imports DevExpress.Web

Partial Public Class Menu_ServerSide
	Inherits Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			ASPxMenu1.ShowPopOutImages = DefaultBoolean.False
			FillItemsList(ddlItems, ASPxMenu1.Items, False)
			ddlItems.SelectedIndex = 0
		End If
	End Sub

	Private Sub FillItemsList(ByVal dropDownList As ASPxComboBox, ByVal items As MenuItemCollection, ByVal isChild As Boolean)
		For Each item As MenuItem In items
			Dim itemText As String = (If(isChild, " - ", "")) + item.Text
			dropDownList.Items.Add(New ListEditItem(itemText, item.Name))
			FillItemsList(dropDownList, item.Items, True)
		Next item
	End Sub

	Protected Sub ASPxMenu1_ItemClick(ByVal sender As Object, ByVal e As MenuItemEventArgs)
		EventMonitor.TraceEvent(sender, e, "ItemClick")
		ddlItems.Value = ASPxMenu1.SelectedItem.Name
		ddlItems_SelectedIndexChanged(sender, e)
	End Sub

	Protected Sub cbEnable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As MenuItem = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString())
		If item IsNot Nothing Then
			item.Enabled = cbEnable.Checked
		End If
	End Sub

	Protected Sub cbVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As MenuItem = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString())
		If item IsNot Nothing Then
			item.Visible = cbVisible.Checked
		End If
	End Sub

	Protected Sub cbSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As MenuItem = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString())
		If item IsNot Nothing Then
			item.Selected = cbSelect.Checked
		End If
	End Sub

	Protected Sub ddlItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As MenuItem = ASPxMenu1.Items.FindByName(ddlItems.SelectedItem.Value.ToString())
		If item IsNot Nothing Then
			cbEnable.Checked = item.Enabled
			cbVisible.Checked = item.Visible
			cbSelect.Checked = item.Selected
		End If
	End Sub

End Class
