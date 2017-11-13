Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for ViewStyles.
	''' </summary>
	Partial Public Class ViewStyles
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Function IndexOf(ByVal itemsCollection As ListBoxItemCollection, ByVal s As String) As Integer
			For i As Integer = 0 To itemsCollection.Count - 1
				If itemsCollection(i).ToString() = s Then
					Return i
				End If
			Next i
			Return -1
		End Function

		Private Sub InitComponent()
			listBox1.Items.AddRange(TryCast(navBarControl1.AvailableNavBarViews.ToArray(GetType(Object)), Object()))
			listBox1.SelectedIndex = IndexOf(listBox1.Items, navBarControl1.View.ToString())
		End Sub

		'<listBox1>
		Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBox1.SelectedIndexChanged
			navBarControl1.View = TryCast(listBox1.SelectedItem, DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator)
			navBarControl1.ResetStyles()
		End Sub
		'</listBox1>
	End Class
End Namespace
