Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.BrowserDemo
	Public Partial Class ctrlFavorites
		Inherits System.Windows.Forms.UserControl
		Public Event AddNewFavorite As EventHandler
		Public Event EditFavorite As EventHandler
		Public Event DeleteFavorite As EventHandler
		Public Event OpenFavorite As EventHandler

		Public Sub New()
			InitializeComponent()
			ItemsEnabled()
		End Sub

		Private Sub ItemsEnabled()
			iEdit.Enabled = listBox1.SelectedIndex >= 0
			iDelete.Enabled = iEdit.Enabled
			iOpen.Enabled = iDelete.Enabled
		End Sub

		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBox1.SelectedIndexChanged
			ItemsEnabled()
		End Sub

		Public Sub DeleteItems()
			listBox1.Items.Clear()
		End Sub

		Public Sub AddItem(ByVal item As BarItem, ByVal init As Boolean)
			listBox1.Items.Add(item.Caption)
			If (Not init) Then
			listBox1.SelectedIndex = listBox1.Items.Count - 1
			End If
		End Sub

		Private Sub iAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAdd.ItemClick
			If Not AddNewFavoriteEvent Is Nothing Then
			RaiseEvent AddNewFavorite(Me, EventArgs.Empty)
			End If
		End Sub

		Private Sub iEdit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iEdit.ItemClick
			Dim i As Integer = listBox1.SelectedIndex
			If Not EditFavoriteEvent Is Nothing AndAlso Not listBox1.SelectedItem Is Nothing Then
				RaiseEvent EditFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
			End If
			listBox1.SelectedIndex = i
		End Sub

		Private Sub iDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iDelete.ItemClick
			Dim i As Integer = listBox1.SelectedIndex
			If Not DeleteFavoriteEvent Is Nothing AndAlso Not listBox1.SelectedItem Is Nothing Then
				RaiseEvent DeleteFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
			End If
			Try
				listBox1.SelectedIndex = i
			Catch
			End Try
			ItemsEnabled()
		End Sub

		Private Sub DoOpenFavorite()
			If Not OpenFavoriteEvent Is Nothing AndAlso Not listBox1.SelectedItem Is Nothing Then
				RaiseEvent OpenFavorite(listBox1.SelectedItem.ToString(), EventArgs.Empty)
			End If
		End Sub

		Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOpen.ItemClick
			DoOpenFavorite()
		End Sub

		Private Sub listBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBox1.DoubleClick
			DoOpenFavorite()
		End Sub
	End Class
End Namespace
