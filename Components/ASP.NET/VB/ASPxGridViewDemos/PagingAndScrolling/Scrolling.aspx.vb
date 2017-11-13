Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class PagingAndScrolling_Scrolling
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			For Each name As String In System.Enum.GetNames(GetType(ScrollBarMode))
				HorzScrollCombo.Items.Add(name)
				VertScrollCombo.Items.Add(name)
			Next name
			HorzScrollCombo.Text = ScrollBarMode.Hidden.ToString()
			VertScrollCombo.Text = ScrollBarMode.Auto.ToString()
		End If

		Grid.Settings.HorizontalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), HorzScrollCombo.Text), ScrollBarMode)
		Grid.Settings.VerticalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), VertScrollCombo.Text), ScrollBarMode)

		For i As Integer = 7 To Grid.Columns.Count - 1
			Grid.Columns(i).Visible = Grid.Settings.HorizontalScrollBarMode <> ScrollBarMode.Hidden
		Next i
	End Sub
End Class
