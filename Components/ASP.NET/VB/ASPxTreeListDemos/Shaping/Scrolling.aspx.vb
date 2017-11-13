Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web

Partial Public Class Shaping_Scrolling
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			For Each name As String In System.Enum.GetNames(GetType(ScrollBarMode))
				HorzScrollCombo.Items.Add(name)
				VertScrollCombo.Items.Add(name)
			Next name
			HorzScrollCombo.Text = ScrollBarMode.Auto.ToString()
			VertScrollCombo.Text = ScrollBarMode.Auto.ToString()

			treeList.DataBind()
			treeList.ExpandAll()
		End If

		treeList.Settings.HorizontalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), HorzScrollCombo.Text), ScrollBarMode)
		treeList.Settings.VerticalScrollBarMode = CType(System.Enum.Parse(GetType(ScrollBarMode), VertScrollCombo.Text), ScrollBarMode)
	End Sub
End Class
