Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Partial Public Class Data_Linear
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			DataBind()
			treeList.ExpandToLevel(2)
		End If

		Dim show As Boolean = chkServiceColumns.Checked
		treeList.Columns("ID").Visible = show
		treeList.Columns("ParentID").Visible = show
	End Sub
End Class
