Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports System.Web.UI

Partial Public Class NavBar_ServerSide
	Inherits Page
	Private Const EnabledImageUrl As String = "~/NavBar/Images/online.png"
	Private Const DisabledImageUrl As String = "~/NavBar/Images/offline.png"

	Private ReadOnly Property SelectedItemName() As String
		Get
			Return ddlItems.SelectedItem.Value.ToString()
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			Return
		End If
		Dim rand As New Random()
		For Each group As NavBarGroup In ASPxNavBar1.Groups
			ddlItems.Items.Add(New ListEditItem(group.Text, group.Name))
			FillItemsDropDownList(ddlItems, group.Items)
			ddlItems.SelectedIndex = 0
			Dim index As Integer = rand.Next(group.Items.Count)
			ApplyFilter(group.Items(index).Name)
		Next group
	End Sub

	Protected Sub cbEnable_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		ApplyFilter(ddlItems.SelectedItem.Value.ToString())
	End Sub

	Protected Sub cbVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As NavBarItem = ASPxNavBar1.Items.FindByName(SelectedItemName)
		If item IsNot Nothing Then
			item.Visible = cbVisible.Checked
			Return
		End If
		Dim group As NavBarGroup = ASPxNavBar1.Groups.FindByName(SelectedItemName)
		If group IsNot Nothing Then
			group.Visible = cbVisible.Checked
		End If
	End Sub

	Protected Sub cbSelect_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim item As NavBarItem = ASPxNavBar1.Items.FindByName(SelectedItemName)
		If item IsNot Nothing Then
			item.Selected = cbSelect.Checked
			Return
		End If
		Dim group As NavBarGroup = ASPxNavBar1.Groups.FindByName(SelectedItemName)
		If group IsNot Nothing Then
			group.Expanded = cbSelect.Checked
		End If
	End Sub

	Protected Sub ASPxNavBar1_HeaderClick(ByVal sender As Object, ByVal e As NavBarGroupCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "HeaderClick")
		ddlItems.Value = e.Group.Name

		ChangeCheckBoxLabel()
		cbEnable.Checked = e.Group.Enabled
		cbVisible.Checked = e.Group.Visible
		cbSelect.Checked = Not e.Group.Expanded
	End Sub

	Protected Sub ASPxNavBar1_ExpandedChanging(ByVal sender As Object, ByVal e As NavBarGroupCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "ExpandedChanging")
	End Sub

	Protected Sub ASPxNavBar1_ExpandedChanged(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
		EventMonitor.TraceEvent(sender, e, "ExpandedChanged")
	End Sub

	Protected Sub ASPxNavBar1_ItemClick(ByVal sender As Object, ByVal e As NavBarItemEventArgs)
		EventMonitor.TraceEvent(sender, e, "ItemClick")
		ddlItems.Value = ASPxNavBar1.SelectedItem.Name
		ddlItems_SelectedIndexChanged(sender, e)
	End Sub

	Protected Sub ddlItems_Load(ByVal sender As Object, ByVal e As EventArgs)
		ChangeCheckBoxLabel()
	End Sub

	Protected Sub ddlItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		ChangeCheckBoxLabel()
		Dim item As NavBarItem = ASPxNavBar1.Items.FindByName(SelectedItemName)
		If item IsNot Nothing Then
			cbEnable.Checked = item.Enabled
			cbVisible.Checked = item.Visible
			cbSelect.Checked = item.Selected
			Return
		End If
		Dim group As NavBarGroup = ASPxNavBar1.Groups.FindByName(SelectedItemName)
		If group IsNot Nothing Then
			cbEnable.Checked = group.Enabled
			cbVisible.Checked = group.Visible
			cbSelect.Checked = group.Expanded
		End If
	End Sub

	Private Sub ApplyFilter(ByVal value As String)
		Dim item As NavBarItem = ASPxNavBar1.Items.FindByName(value)
		If item IsNot Nothing Then
			item.Enabled = Not item.Enabled
			item.Image.Url = If(item.Enabled, EnabledImageUrl, DisabledImageUrl)
			Return
		End If
		Dim group As NavBarGroup = ASPxNavBar1.Groups.FindByName(value)
		If group IsNot Nothing Then
			group.Enabled = Not group.Enabled
		End If
		For Each groupItem As NavBarItem In group.Items
			groupItem.Image.Url = If(group.Enabled AndAlso groupItem.Enabled, EnabledImageUrl, DisabledImageUrl)
		Next groupItem
	End Sub

	Private Sub ChangeCheckBoxLabel()
		cbSelect.Text = If(ddlItems.SelectedItem.Text.Contains("-"), "Selected", "Expanded")
	End Sub

	Private Sub FillItemsDropDownList(ByVal dropDownList As ASPxComboBox, ByVal items As NavBarItemCollection)
		For i As Integer = 0 To items.Count - 1
			dropDownList.Items.Add(New ListEditItem(" - " & items(i).Text, items(i).Name))
		Next i
	End Sub
End Class
