Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for GroupStyles.
	''' </summary>
	Partial Public Class GroupStyles
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitProperties()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitProperties()
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None Then
                ceAllowSelectedLink.Checked = False
            Else
                ceAllowSelectedLink.Checked = True
            End If
            AddGroupStyleItems(cbLocalStyle)
			AddGroupStyleItems(cbContactStyle)
			AddGroupImageStyle(cbLocalImage)
			AddGroupImageStyle(cbContactImage)
			cbLocalStyle.Text = navBarGroup1.GroupStyle.ToString()
			cbContactStyle.Text = navBarGroup2.GroupStyle.ToString()
			cbLocalImage.Text = navBarGroup1.GroupCaptionUseImage.ToString()
			cbContactImage.Text = navBarGroup2.GroupCaptionUseImage.ToString()
		End Sub

		Private Sub ceAllowSelectedLink_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowSelectedLink.CheckedChanged
            If navBarControl1.LinkSelectionMode = LinkSelectionModeType.None And ceAllowSelectedLink.Checked Then
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl
            End If
            If Not navBarControl1.LinkSelectionMode = LinkSelectionModeType.None And Not ceAllowSelectedLink.Checked Then
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.None
            End If
        End Sub

		Private Sub AddGroupImageStyle(ByVal cb As DevExpress.XtraEditors.ComboBoxEdit)
			For Each name As String In System.Enum.GetNames(GetType(DevExpress.XtraNavBar.NavBarImage))
					cb.Properties.Items.Add(name)
			Next name
		End Sub

		Private Sub AddGroupStyleItems(ByVal cb As DevExpress.XtraEditors.ComboBoxEdit)
			For Each name As String In System.Enum.GetNames(GetType(DevExpress.XtraNavBar.NavBarGroupStyle))
				If name.IndexOf("Text") > 0 Then
					cb.Properties.Items.Add(name)
				End If
			Next name
		End Sub

		Private Function GetGroupStyleByString(ByVal sender As Object) As DevExpress.XtraNavBar.NavBarGroupStyle
			Dim cb As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
			Return CType(System.Enum.Parse(GetType(DevExpress.XtraNavBar.NavBarGroupStyle), cb.SelectedItem.ToString()), DevExpress.XtraNavBar.NavBarGroupStyle)
		End Function

		Private Function GetGroupImageStyleByString(ByVal sender As Object) As DevExpress.XtraNavBar.NavBarImage
			Dim cb As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
			Return CType(System.Enum.Parse(GetType(DevExpress.XtraNavBar.NavBarImage), cb.SelectedItem.ToString()), DevExpress.XtraNavBar.NavBarImage)
		End Function

		Private Sub cbLocalStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLocalStyle.SelectedIndexChanged
			navBarGroup1.GroupStyle = GetGroupStyleByString(sender)
		End Sub

		Private Sub cbContactStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbContactStyle.SelectedIndexChanged
			navBarGroup2.GroupStyle = GetGroupStyleByString(sender)
		End Sub

		Private Sub cbLocalImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLocalImage.SelectedIndexChanged
			navBarGroup1.GroupCaptionUseImage = GetGroupImageStyleByString(sender)
		End Sub

		Private Sub cbContactImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbContactImage.SelectedIndexChanged
			navBarGroup2.GroupCaptionUseImage = GetGroupImageStyleByString(sender)
		End Sub
	End Class
End Namespace
