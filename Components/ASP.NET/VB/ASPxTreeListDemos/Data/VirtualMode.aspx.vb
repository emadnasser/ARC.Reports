Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web.ASPxTreeList

Partial Public Class Data_VirtualMode
	Inherits Page

	Protected Sub treeList_VirtualModeCreateChildren(ByVal sender As Object, ByVal e As TreeListVirtualModeCreateChildrenEventArgs)
		Dim path As String = If(e.NodeObject Is Nothing, Page.MapPath("~/"), e.NodeObject.ToString())

		Dim children As New List(Of String)()
		If Directory.Exists(path) Then
			For Each name As String In Directory.GetDirectories(path)
				If (Not IsSystemName(name)) Then
					children.Add(name)
				End If
			Next name
			For Each name As String In Directory.GetFiles(path)
				If (Not IsSystemName(name)) Then
					children.Add(name)
				End If
			Next name
		End If
		e.Children = children
	End Sub

	Protected Sub treeList_VirtualModeNodeCreating(ByVal sender As Object, ByVal e As TreeListVirtualModeNodeCreatingEventArgs)
		Dim nodePath As String = e.NodeObject.ToString()
		e.NodeKeyValue = GetNodeGuid(nodePath)
		e.IsLeaf = Not Directory.Exists(nodePath)
		e.SetNodeValue("name", Path.GetFileName(nodePath))
		e.SetNodeValue("date", Directory.GetCreationTime(nodePath))
	End Sub

	Private Function GetNodeGuid(ByVal path As String) As Guid
		If (Not Map.ContainsKey(path)) Then
			Map(path) = Guid.NewGuid()
		End If
		Return Map(path)
	End Function
	Private ReadOnly Property Map() As Dictionary(Of String, Guid)
		Get
			Const key As String = "DX_PATH_GUID_MAP"
			If Session(key) Is Nothing Then
				Session(key) = New Dictionary(Of String, Guid)()
			End If
			Return TryCast(Session(key), Dictionary(Of String, Guid))
		End Get
	End Property
	Private Function IsSystemName(ByVal name As String) As Boolean
		name = Path.GetFileName(name).ToLower()
		Return name.StartsWith("app_") OrElse name = "bin" OrElse name.EndsWith(".aspx.cs") OrElse name.EndsWith(".aspx.vb")
	End Function

End Class
