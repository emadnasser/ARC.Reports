Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for AddItemLinks.
	''' </summary>
	Partial Public Class AddItemLinks
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			ExistSelectedItemLink()
			ExistSeparatorItemLink()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub ExistSelectedItemLink()
			button3.Enabled = navBarControl1.ActiveGroup.SelectedLink IsNot Nothing
			button2.Enabled = button3.Enabled
		End Sub

		Private Sub ExistSeparatorItemLink()
			Dim res As Boolean = False
			If navBarControl1.ActiveGroup IsNot Nothing Then
				For i As Integer = navBarControl1.ActiveGroup.ItemLinks.Count - 1 To 0 Step -1
					Dim itemLinks = navBarControl1.ActiveGroup.ItemLinks(i)
					Dim separator = TryCast(itemLinks.Item, DevExpress.XtraNavBar.NavBarSeparatorItem)
					If separator Is Nothing Then
						Continue For
					End If

					res = True
					Exit For
				Next i
			End If

			button5.Enabled = res
		End Sub

		'<button1>
		Private i As Integer = 0

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim item As DevExpress.XtraNavBar.NavBarItem = navBarControl1.Items.Add()
			item.SmallImageIndex = imageComboBoxEdit1.SelectedIndex
			item.LargeImageIndex = item.SmallImageIndex
			item.Caption = "Item " & (i).ToString()
			i += 1
			navBarControl1.ActiveGroup.ItemLinks.Add(item)
			ExistSelectedItemLink()
		End Sub
		'</button1>

		Private Sub navBarControl1_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl1.ActiveGroupChanged
			ExistSelectedItemLink()
		End Sub

		Private Sub navBarControl1_SelectedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs) Handles navBarControl1.SelectedLinkChanged
			ExistSelectedItemLink()
		End Sub

		'<button2>
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			If navBarControl1.ActiveGroup.SelectedLink IsNot Nothing Then
				navBarControl1.ActiveGroup.SelectedLink.Dispose()
			End If
			ExistSelectedItemLink()
		End Sub
		'</button2>

		'<button3>
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If navBarControl1.ActiveGroup.SelectedLink IsNot Nothing Then
				navBarControl1.ActiveGroup.SelectedLink.Item.Dispose()
			End If
			ExistSelectedItemLink()
		End Sub
		'</button3>

		'<button4>
		Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button4.Click
			Dim item As DevExpress.XtraNavBar.NavBarItem = navBarControl1.Items.Add(True)
			navBarControl1.ActiveGroup.ItemLinks.Add(item)
			navBarControl1.ActiveGroup.SelectedLink = Nothing
			ExistSeparatorItemLink()
		End Sub
		'</button4>

		'<button5>
		Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button5.Click
			If navBarControl1.ActiveGroup IsNot Nothing Then
				For i As Integer = navBarControl1.ActiveGroup.ItemLinks.Count - 1 To 0 Step -1
					Dim itemLinks = navBarControl1.ActiveGroup.ItemLinks(i)
					Dim separator = TryCast(itemLinks.Item, DevExpress.XtraNavBar.NavBarSeparatorItem)
					If separator Is Nothing Then
						Continue For
					End If

					separator.Dispose()
					Exit For
				Next i
			End If
			ExistSeparatorItemLink()
		End Sub
		'</button5>

		Private Sub AddItemLinks_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To imageCollection1.Images.Count - 1
				imageComboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem("", i, i))
			Next i
			imageComboBoxEdit1.Properties.LargeImages = imageCollection1
			imageComboBoxEdit1.Properties.SmallImages = imageCollection2
			imageComboBoxEdit1.SelectedIndex = 1
		End Sub
	End Class
End Namespace
