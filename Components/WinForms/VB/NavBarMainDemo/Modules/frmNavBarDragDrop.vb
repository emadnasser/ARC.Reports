Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarDragDrop
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			InitOptions()
		End Sub

		Private mDown As New Point(-10000, -10000)
		Private Function GetItemLink(ByVal data As IDataObject) As NavBarItemLink
			Dim ret As NavBarItemLink = TryCast(data.GetData(GetType(NavBarItemLink)), NavBarItemLink)
			Return ret
		End Function

		Private Function GetListViewItems(ByVal data As IDataObject) As ListView.SelectedListViewItemCollection
			Dim ret As ListView.SelectedListViewItemCollection = TryCast(data.GetData(GetType(ListView.SelectedListViewItemCollection)), ListView.SelectedListViewItemCollection)
			Return ret
		End Function

		Private Sub listView1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles listView1.DragDrop
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing AndAlso link.Item.Enabled Then
				listView1.Items.Add(link.Caption, link.Item.SmallImageIndex)
			End If
		End Sub

		Private Sub listView1_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles listView1.DragEnter
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing AndAlso link.Item.Enabled Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub lbRecycle_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles lbRecycle.DragEnter
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing Then
				e.Effect = DragDropEffects.Move
				lbRecycle.Appearance.ImageIndex = 1
			End If
		End Sub

		Private Sub lbRecycle_DragLeave(ByVal sender As Object, ByVal e As EventArgs) Handles lbRecycle.DragLeave
			lbRecycle.Appearance.ImageIndex = 0
		End Sub

		Private Sub lbRecycle_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles lbRecycle.DragDrop
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing Then
				link.Dispose()
			End If
			lbRecycle.Appearance.ImageIndex = 0
		End Sub


		Private Sub listView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listView1.MouseDown
			listView1.Focus()
			mDown = New Point(e.X, e.Y)
		End Sub

		Private Sub listView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listView1.MouseMove
			If (Math.Abs(e.X - mDown.X) > 5 OrElse Math.Abs(e.Y - mDown.Y) > 5) Then
				Dim selectedItemsCount As Integer = listView1.SelectedItems.Count
				If selectedItemsCount < 0 OrElse e.Button <> MouseButtons.Left Then
					Return
				End If
				listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Copy)
			End If
		End Sub

		Private Sub navBarControl1_NavDragOver(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventArgs) Handles navBarControl1.NavDragOver
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing Then
				Return
			End If
			Dim links As ListView.SelectedListViewItemCollection = GetListViewItems(e.Data)
			If links IsNot Nothing Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Function GetNavBarItemByCaption(ByVal s As String) As NavBarItem
			For Each item As NavBarItem In navBarControl1.Items
				If item.Caption = s Then
					Return item
				End If
			Next item
			Return Nothing
		End Function

		Private Sub navBarControl1_NavDragDrop(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarDragDropEventArgs) Handles navBarControl1.NavDragDrop
			Dim link As NavBarItemLink = GetItemLink(e.Data)
			If link IsNot Nothing Then
				Return
			End If
			Dim links As ListView.SelectedListViewItemCollection = GetListViewItems(e.Data)
			If links IsNot Nothing Then
				If e.InsertPosition <> -1 Then
					For i As Integer = links.Count - 1 To 0 Step -1
						e.Group.ItemLinks.Insert(e.InsertPosition, GetNavBarItemByCaption(links(i).Text))
					Next i
				Else
					For i As Integer = 0 To links.Count - 1
						e.Group.ItemLinks.Add(GetNavBarItemByCaption(links(i).Text))
					Next i
				End If
			End If
		End Sub

		Private Sub SetDragDropFlags(ByVal flag As NavBarDragDrop, ByVal IsChecked As Boolean)
			If IsChecked Then
				navBarControl1.DragDropFlags = navBarControl1.DragDropFlags Or flag
			Else
				navBarControl1.DragDropFlags = navBarControl1.DragDropFlags And Not flag
			End If
		End Sub

		Private Sub InitOptions()
			ceAllowDrag.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowDrag) <> 0
			ceAllowDrop.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowDrop) <> 0
			ceAllowOuterDrop.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowOuterDrop) <> 0
		End Sub

		Private Sub ceAllowDrag_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowDrag.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowDrag, ceAllowDrag.Checked)
		End Sub

		Private Sub ceAllowDrop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowDrop.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowDrop, ceAllowDrop.Checked)
		End Sub

		Private Sub ceAllowOuterDrop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowOuterDrop.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowOuterDrop, ceAllowOuterDrop.Checked)
		End Sub
	End Class
End Namespace
