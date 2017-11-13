Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmLinkProperties
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New(ByVal location As Point, ByVal group As NavBarGroup, ByVal link As NavBarItemLink, ByVal items As NavItemCollection, ByVal imlL As ImageList, ByVal imlS As ImageList)
			InitializeComponent()
			If location.X + Me.Width > Screen.PrimaryScreen.WorkingArea.Width Then
				location.X = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
			End If
			If location.Y + Me.Height > Screen.PrimaryScreen.WorkingArea.Height Then
				location.Y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
			End If
			Me.DesktopLocation = location
			Me.link = link
			Me.items = items
			Me.group = group
			imlLarge = imlL
			imlSmall = imlS
			For Each i As NavBarItem In items
				cbItem.Properties.Items.Add(i.Caption)
			Next i
			cbItem.SelectedItem = link.Item.Caption
		End Sub

		Private link As NavBarItemLink
		Private items As NavItemCollection
		Private group As NavBarGroup
		Private imlLarge, imlSmall As ImageList

		Private Sub cbItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbItem.SelectedIndexChanged
			txtCaption.Text = items(cbItem.SelectedIndex).Caption
			Invalidate(New Rectangle(cbItem.Left, lbImages.Top, 100, 100))
		End Sub

		Private Sub SetNewProperties()
			If group IsNot Nothing Then
				Dim ind As Integer = group.ItemLinks.IndexOf(link)
				If ind <> -1 Then
					link.Dispose()
					group.ItemLinks.Insert(ind, items(cbItem.SelectedIndex))
				End If
			End If
			items(cbItem.SelectedIndex).Caption = txtCaption.Text
		End Sub

		Private Sub frmLinkProperties_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
			If Me.DialogResult = DialogResult.OK Then
				SetNewProperties()
			End If
		End Sub

		Private Sub frmLinkProperties_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
			e.Graphics.DrawImage(imlLarge.Images(items(cbItem.SelectedIndex).LargeImageIndex), cbItem.Left, lbImages.Top)
			e.Graphics.DrawImage(imlSmall.Images(items(cbItem.SelectedIndex).SmallImageIndex), cbItem.Left + 56, lbImages.Top)
		End Sub
	End Class
End Namespace
