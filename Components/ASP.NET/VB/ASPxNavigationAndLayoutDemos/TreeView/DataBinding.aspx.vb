Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Web
Imports System.Xml

Partial Public Class TreeView_DataBinding
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			treeView.DataBind()
			treeView.ExpandToDepth(0)
		End If
	End Sub

	Protected Sub treeView_NodeDataBound(ByVal sender As Object, ByVal e As TreeViewNodeEventArgs)
		Dim dataNode As XmlNode = (TryCast((TryCast(e.Node.DataItem, IHierarchyData)).Item, XmlNode))
		If dataNode.Name = "class" Then
			e.Node.TextStyle.Font.Bold = True
		End If
	End Sub
End Class
