Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.IO

Partial Public Class TreeView_VirtualMode
	Inherits Page
	Friend Shared DotsPathRegex As New System.Text.RegularExpressions.Regex("^[\.]+$")

	Private Const FileImageUrl As String = "~/TreeView/Images/FileSystem/file.png"
	Private Const DirImageUrl As String = "~/TreeView/Images/FileSystem/directory.png"

	Protected Sub treeView_VirtualModeCreateChildren(ByVal sender As Object, ByVal e As TreeViewVirtualModeCreateChildrenEventArgs)
		Dim parentNodePath As String = If(String.IsNullOrEmpty(e.NodeName), Page.MapPath("~/"), e.NodeName)

		If DotsPathRegex.IsMatch(parentNodePath) Then 'page relative path is not allowed
			Return
		End If

		Dim children As New List(Of TreeViewVirtualNode)()
		If Directory.Exists(parentNodePath) Then
			PopulateChildNodes(Directory.GetDirectories(parentNodePath), False, DirImageUrl, children)
			PopulateChildNodes(Directory.GetFiles(parentNodePath), True, FileImageUrl, children)
		End If
		e.Children = children
	End Sub

	Private Sub PopulateChildNodes(ByVal paths() As String, ByVal isLeaf As Boolean, ByVal imageUrl As String, ByVal children As List(Of TreeViewVirtualNode))
		For Each childPath As String In paths
			Dim childFileName As String = Path.GetFileName(childPath)
			If IsSystemName(childFileName) Then
				Continue For
			End If
			Dim childNode As New TreeViewVirtualNode(childPath, childFileName)
			childNode.IsLeaf = isLeaf
			childNode.Image.Url = imageUrl
			children.Add(childNode)
		Next childPath
	End Sub

	Private Function IsSystemName(ByVal name As String) As Boolean
		name = name.ToLower()
		Return name.StartsWith("app_") OrElse name = "bin" OrElse name.EndsWith(".aspx.cs") OrElse name.EndsWith(".aspx.vb")
	End Function
End Class
