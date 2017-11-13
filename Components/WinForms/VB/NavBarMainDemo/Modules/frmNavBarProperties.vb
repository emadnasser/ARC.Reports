Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmNavBarProperties
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			InitComponent()
			FillData()
			AddHandler navBarControl1.Groups.CollectionItemChanged, AddressOf GroupChanged
			AddHandler navBarControl1.Items.CollectionItemChanged, AddressOf ItemChanged
			lbClick.Text = "None"
		End Sub
		Private selectedGroup As NavBarGroup = Nothing
		Private selectedLink As NavBarItemLink = Nothing
		Private menuPoint As New Point(0, 0)
		#Region "Init"
		Private Function IndexOf(ByVal objCollection As DevExpress.XtraEditors.Controls.ComboBoxItemCollection, ByVal s As String) As Integer
			For i As Integer = 0 To objCollection.Count - 1
				If objCollection(i).ToString() = s Then
					Return i
				End If
			Next i
			Return -1
		End Function
		Public Sub InitComponent()
			cbStyles.Properties.Items.AddRange(TryCast(navBarControl1.AvailableNavBarViews.ToArray(GetType(Object)), Object()))
			cbStyles.SelectedIndex = IndexOf(cbStyles.Properties.Items, navBarControl1.View.ToString())
			cbScrollStyle.Properties.Items.AddEnum(GetType(SkinExplorerBarViewScrollStyle))
			cbScrollStyle.EditValue = navBarControl1.SkinExplorerBarViewScrollStyle
		End Sub
		Private Sub FillData()
			FillGroups(0)
			FillItems(0)
			InitOptions()
		End Sub
		Private Sub FillGroups(ByVal n As Integer)
			Groups.Items.Clear()
			For i As Integer = 0 To navBarControl1.Groups.Count - 1
				Groups.Items.Add(navBarControl1.Groups(i).Caption)
			Next i
			If Groups.Items.Count > n Then
				Groups.SelectedIndex = n
			End If
			btnRemoveGroup.Enabled = Groups.SelectedIndex <> -1
			ShowGroupProperties()
		End Sub
		Private Sub FillItems(ByVal n As Integer)
			Items.Items.Clear()
			For i As Integer = 0 To navBarControl1.Items.Count - 1
				Items.Items.Add(navBarControl1.Items(i).Caption)
			Next i
			If Items.Items.Count > n Then
				Items.SelectedIndex = n
			End If
			btnRemoveItem.Enabled = Items.SelectedIndex <> -1
			ShowItemProperties()
		End Sub
		Private Sub InitOptions()
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None Then
                chbAllowSelectedLink.Checked = False
            Else
                chbAllowSelectedLink.Checked = True
            End If
            chbAllowDrag.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowDrag) <> 0
			chbAllowDrop.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowDrop) <> 0
			chbAllowOuterDrop.Checked = (navBarControl1.DragDropFlags And NavBarDragDrop.AllowOuterDrop) <> 0
		End Sub
		#End Region
		#Region "Editing"
		Private Sub cbStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbStyles.SelectedIndexChanged
			navBarControl1.View = TryCast(cbStyles.SelectedItem, DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator)
			navBarControl1.ResetStyles()
		End Sub

		Private Sub cbScrollStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbScrollStyle.SelectedIndexChanged
			navBarControl1.SkinExplorerBarViewScrollStyle = CType(cbScrollStyle.EditValue, DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle)
		End Sub

		Private Sub UpdateGroup(ByVal group As NavBarGroup)
			If group Is Nothing Then
				Return
			End If
			Dim ind As Integer = navBarControl1.Groups.IndexOf(group)
			If ind <> -1 Then
				Groups.Items(ind) = group.Caption
				Groups.SelectedIndex = ind
			End If
		End Sub
		Private Sub UpdateItem(ByVal item As NavBarItem)
			If item Is Nothing Then
				Return
			End If
			Dim ind As Integer = navBarControl1.Items.IndexOf(item)
			If ind <> -1 Then
				Items.Items(ind) = item.Caption
				Items.SelectedIndex = ind
			End If
		End Sub
		Private Sub GroupChanged(ByVal sender As Object, ByVal e As CollectionItemEventArgs)
			UpdateGroup(TryCast(e.Item, NavBarGroup))
		End Sub
		Private Sub ItemChanged(ByVal sender As Object, ByVal e As CollectionItemEventArgs)
			UpdateItem(TryCast(e.Item, NavBarItem))
		End Sub
		Private Sub SetDragDropFlags(ByVal flag As NavBarDragDrop, ByVal IsChecked As Boolean)
			If IsChecked Then
				navBarControl1.DragDropFlags = navBarControl1.DragDropFlags Or flag
			Else
				navBarControl1.DragDropFlags = navBarControl1.DragDropFlags And Not flag
			End If
		End Sub
		Private Sub chbAllowDrag_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAllowDrag.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowDrag, chbAllowDrag.Checked)
		End Sub
		Private Sub chbAllowDrop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAllowDrop.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowDrop, chbAllowDrop.Checked)
		End Sub
		Private Sub chbAllowOuterDrop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAllowOuterDrop.CheckedChanged
			SetDragDropFlags(NavBarDragDrop.AllowOuterDrop, chbAllowOuterDrop.Checked)
		End Sub
		Private Sub chbAllowSelectedLink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbAllowSelectedLink.CheckedChanged
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None And chbAllowSelectedLink.Checked Then
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl
            End If
            If Not navBarControl1.LinkSelectionMode = LinkSelectionModeType.None And Not chbAllowSelectedLink.Checked Then
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.None
            End If
        End Sub
		Private Sub ShowGroupProperties()
			If Groups.SelectedIndex <> -1 Then
				propertyGridControl1.SelectedObject = navBarControl1.Groups(Groups.SelectedIndex)
			Else
				propertyGridControl1.SelectedObject = Nothing
			End If
		End Sub
		Private Sub Groups_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Groups.SelectedIndexChanged
			ShowGroupProperties()
		End Sub
		Private Sub ShowItemProperties()
			If Items.SelectedIndex <> -1 Then
				propertyGridControl2.SelectedObject = navBarControl1.Items(Items.SelectedIndex)
			Else
				propertyGridControl2.SelectedObject = Nothing
			End If
		End Sub
		Private Sub Items_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Items.SelectedIndexChanged
			ShowItemProperties()
		End Sub

		Private Sub btnAddGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddGroup.Click
			navBarControl1.Groups.Add()
			FillGroups(navBarControl1.Groups.Count - 1)
		End Sub

		Private Sub btnRemoveGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveGroup.Click
			If Groups.SelectedIndex <> -1 Then
				navBarControl1.Groups.RemoveAt(Groups.SelectedIndex)
			End If
			FillGroups(0)
		End Sub

		Private Sub btnAddItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddItem.Click
			navBarControl1.Items.Add()
			FillItems(navBarControl1.Items.Count - 1)
		End Sub

		Private Sub btnRemoveItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveItem.Click
			If Items.SelectedIndex <> -1 Then
				navBarControl1.Items.RemoveAt(Items.SelectedIndex)
			End If
			FillItems(0)
		End Sub
		#End Region
		#Region "Info"
		Private Sub navBarControl1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarControl1.LinkClicked
			lbClick.Text = "Link Clicked: Group(" & e.Link.Group.Caption & ") / Item(" & e.Link.Caption & ")"
			timer1.Start()
		End Sub

		Private Sub navBarControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBarControl1.MouseMove
			If Not timer1.Enabled Then
				Dim hi As NavBarHitInfo = navBarControl1.CalcHitInfo(New Point(e.X, e.Y))
				lbClick.Text = hi.HitTest.ToString() & "(" & e.X & "; " & e.Y & ")"
			End If
		End Sub

		Private Sub navBarControl1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles navBarControl1.MouseLeave
			lbClick.Text = "None"
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			timer1.Stop()
		End Sub
		#End Region
		#Region "Menus"



		Private Sub navBarControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles navBarControl1.MouseDown
			If e.Button <> MouseButtons.Right Then
				Return
			End If
			Dim hi As NavBarHitInfo = navBarControl1.CalcHitInfo(New Point(e.X, e.Y))
			menuPoint = navBarControl1.PointToScreen(New Point(e.X, e.Y))
			selectedGroup = hi.Group
			If hi.InLink Then
				selectedLink = hi.Link
				pmItem.ShowPopup(navBarControl1.PointToScreen(New Point(e.X, e.Y)))
				Return
			End If
			pmGroup.ShowPopup(navBarControl1.PointToScreen(New Point(e.X, e.Y)))
		End Sub

		Private Sub biDeleteLink_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biDeleteLink.ItemClick
			If selectedLink IsNot Nothing Then
				selectedLink.Dispose()
			End If
		End Sub

		Private Sub biLinkProperties_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biLinkProperties.ItemClick
			Dim dlg As New frmLinkProperties(menuPoint, selectedGroup, selectedLink, navBarControl1.Items, imageList1, imageList2)
			dlg.ShowDialog()
		End Sub

		Private Sub biRemoveGroup_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biRemoveGroup.ItemClick
			If selectedGroup IsNot Nothing Then
				selectedGroup.Dispose()
				FillGroups(0)
			End If
		End Sub

		Private Sub biAddNewGroup_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biAddNewGroup.ItemClick
			navBarControl1.Groups.Add()
			FillGroups(navBarControl1.Groups.Count - 1)
		End Sub

		Private Sub biGroupProperties_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biGroupProperties.ItemClick
			If selectedGroup IsNot Nothing Then
				Dim frm As New DevExpress.XtraEditors.XtraForm()
				frm.Text = "Group Properties (" & selectedGroup.Caption & ")"
				Dim pg As New DevExpress.XtraVerticalGrid.PropertyGridControl()
				Using ms As System.IO.Stream = New System.IO.MemoryStream()
					propertyGridControl1.SaveLayoutToStream(ms)
					ms.Seek(0, System.IO.SeekOrigin.Begin)
					pg.RestoreLayoutFromStream(ms)
				End Using
				pg.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() { New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Color), Me.repositoryItemColorEdit1), New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1)})
				pg.SelectedObject = selectedGroup
				pg.Dock = DockStyle.Fill
				frm.Controls.Add(pg)
				frm.StartPosition = FormStartPosition.Manual
				If menuPoint.X + frm.Width > Screen.PrimaryScreen.WorkingArea.Width Then
					menuPoint.X = Screen.PrimaryScreen.WorkingArea.Width - frm.Width
				End If
				If menuPoint.Y + frm.Height > Screen.PrimaryScreen.WorkingArea.Height Then
					menuPoint.Y = Screen.PrimaryScreen.WorkingArea.Height - frm.Height
				End If
				frm.Location = menuPoint
				frm.FormBorderStyle = FormBorderStyle.SizableToolWindow
				frm.ShowDialog()
			End If
		End Sub

		Private Sub pmGroup_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs) Handles pmGroup.BeforePopup
			Dim b As Boolean = selectedGroup IsNot Nothing
			bsiItems.Enabled = navBarControl1.Items.Count > 0 AndAlso b
			biRemoveGroup.Enabled = b
			biGroupProperties.Enabled = b
			If bsiItems.Enabled Then
				InitItems()
			End If
		End Sub

		Private Function GetBarItemByLink(ByVal nItem As NavBarItem) As BarButtonItem
			For Each item As BarItem In barManager1.Items
				Dim bItem As BarButtonItem = TryCast(item, BarButtonItem)
				If bItem IsNot Nothing Then
					If ReferenceEquals(bItem.Tag, nItem) Then
						bItem.Caption = nItem.Caption
						Return bItem
					End If
				End If
			Next item
			Dim bi As New BarButtonItem(barManager1, nItem.Caption)
			bi.Tag = nItem
			AddHandler bi.ItemClick, AddressOf biAddNewLink_ItemClick
			Return bi
		End Function

		Private Sub InitItems()
			lcItems.ClearLinks()
			For Each item As NavBarItem In navBarControl1.Items
				lcItems.AddItem(GetBarItemByLink(item))
			Next item
		End Sub

		Private Sub biAddNewLink_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
			If selectedGroup IsNot Nothing Then
				selectedGroup.ItemLinks.Add(CType(e.Item.Tag, NavBarItem))
				selectedGroup.Expanded = True
			End If
		End Sub
		#End Region
	End Class
End Namespace
