Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Web.UI
Imports DevExpress.Web
Imports DevExpress.Web.ASPxTreeList
Imports DevExpress.Web.Data
Imports DevExpress.Web.Demos

Partial Public Class Editing_FileManager
	Inherits Page

	Protected Sub tree_VirtualModeCreateChildren(ByVal sender As Object, ByVal e As TreeListVirtualModeCreateChildrenEventArgs)
		Dim nodePath As String = If(e.NodeObject Is Nothing, FileManagerHelper.RootFolder, e.NodeObject.ToString())
		If Directory.Exists(nodePath) Then
			Dim children As New List(Of String)()
			Dim names() As String
			names = Directory.GetDirectories(nodePath)
			For Each name As String In names
				children.Add(name)
			Next name
			names = Directory.GetFiles(nodePath)
			For Each name As String In names
				children.Add(name)
			Next name
			e.Children = children
		End If
	End Sub
	Protected Sub tree_VirtualModeNodeCreating(ByVal sender As Object, ByVal e As TreeListVirtualModeNodeCreatingEventArgs)
		Dim nodePath As String = e.NodeObject.ToString()
		e.NodeKeyValue = FileManagerHelper.GetPathKey(nodePath)
		e.IsLeaf = (Not Directory.Exists(nodePath)) OrElse (Directory.GetFiles(nodePath).Length < 1 AndAlso Directory.GetDirectories(nodePath).Length < 1)
		e.SetNodeValue(FileManagerHelper.FullPathName, nodePath)
		e.SetNodeValue(FileManagerHelper.NameFieldName, Path.GetFileName(nodePath))
	End Sub


	Protected Sub tree_NodeInserting(ByVal sender As Object, ByVal e As ASPxDataInsertingEventArgs)
		Dim parentNode As TreeListNode = tree.FindNodeByKeyValue(tree.NewNodeParentKey)
		EnsureNode(parentNode)
		Dim parentFolder As String
		If parentNode Is tree.RootNode Then
			parentFolder = FileManagerHelper.RootFolder
		Else
			parentFolder = parentNode.GetValue(FileManagerHelper.FullPathName).ToString()
		End If
		Dim name As String = parentFolder & Path.DirectorySeparatorChar + ReadName(e.NewValues)
		If Directory.Exists(name) Then
			Throw New DemoException("Directory exists.")
		End If
		Directory.CreateDirectory(name)
		tree.RefreshVirtualTree(parentNode)
		FocusByPath(name)
	End Sub

	Protected Sub tree_NodeUpdating(ByVal sender As Object, ByVal e As ASPxDataUpdatingEventArgs)
		Dim oldName As String = ReadName(e.OldValues)
		Dim newName As String = ReadName(e.NewValues)
		If oldName = newName Then
			Return
		End If
		Dim key As String = e.Keys(0).ToString()
		Dim node As TreeListNode = tree.FindNodeByKeyValue(key)
		EnsureNode(node)
		Dim oldPath As String = node.GetValue(FileManagerHelper.FullPathName).ToString()
		Dim newPath As String = Path.GetDirectoryName(oldPath) + Path.DirectorySeparatorChar & newName
		FileManagerHelper.MovePath(oldPath, newPath)
	End Sub

	Protected Sub tree_NodeDeleting(ByVal sender As Object, ByVal e As ASPxDataDeletingEventArgs)
		Dim key As String = e.Keys(0).ToString()
		Dim node As TreeListNode = tree.FindNodeByKeyValue(key)
		EnsureNode(node)
		Dim name As String = node.GetValue(FileManagerHelper.FullPathName).ToString()
		If Directory.Exists(name) Then
			Directory.Delete(name)
		ElseIf File.Exists(name) Then
			File.Delete(name)
		End If
		tree.RefreshVirtualTree(node.ParentNode)
	End Sub

	Protected Sub tree_ProcessDragNode(ByVal sender As Object, ByVal e As TreeListNodeDragEventArgs)
		Dim oldPath As String = e.Node.GetValue(FileManagerHelper.FullPathName).ToString()
		Dim destination As String = If(e.NewParentNode Is tree.RootNode, FileManagerHelper.RootFolder, e.NewParentNode.GetValue(FileManagerHelper.FullPathName).ToString())
		Dim newPath As String = destination & Path.DirectorySeparatorChar + Path.GetFileName(oldPath)
		FileManagerHelper.MovePath(oldPath, newPath)
		tree.RefreshVirtualTree()
		e.Handled = True
	End Sub

	Protected Sub tree_NodeValidating(ByVal sender As Object, ByVal e As TreeListNodeValidationEventArgs)
		Dim obj As Object = e.NewValues(FileManagerHelper.NameFieldName)
		If obj Is Nothing OrElse (Not IsValidName(obj.ToString())) Then
			e.NodeError = "Invalid name."
		End If
	End Sub

	Protected Sub tree_CustomNodeSort(ByVal sender As Object, ByVal e As TreeListCustomNodeSortEventArgs)
		Dim value1 As Object = e.Node1.GetValue(FileManagerHelper.FullPathName)
		Dim value2 As Object = e.Node2.GetValue(FileManagerHelper.FullPathName)
		If value1 Is Nothing OrElse value2 Is Nothing Then
			Return
		End If
		Dim isFolder1 As Boolean = Directory.Exists(value1.ToString())
		Dim isFolder2 As Boolean = Directory.Exists(value2.ToString())
		If isFolder1 <> isFolder2 Then
			e.Handled = True
			e.Result = If(isFolder2, 1, -1)
		End If
	End Sub

	Protected Sub tree_CustomJSProperties(ByVal sender As Object, ByVal e As TreeListCustomJSPropertiesEventArgs)
		Dim keys As New List(Of String)()
		For Each node As TreeListNode In tree.GetVisibleNodes()
			Dim pathName As String = node.GetValue(FileManagerHelper.FullPathName).ToString()
			If Directory.Exists(pathName) Then
				keys.Add(node.Key)
			End If
		Next node
		e.Properties("cpFolderKeys") = keys
	End Sub

	Protected Sub uploader_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
		Using fileContent As Stream = uploader.UploadedFiles(0).FileContent
			FileManagerHelper.BeginUploadFile(uploader.UploadedFiles(0).FileName, fileContent)
		End Using
	End Sub
	Protected Sub tree_CustomCallback(ByVal sender As Object, ByVal e As TreeListCustomCallbackEventArgs)
		If e.Argument = "upload_complete" Then
			Dim node As TreeListNode = tree.FocusedNode
			Dim folderName As String = If(node Is Nothing, FileManagerHelper.RootFolder, node.GetValue(FileManagerHelper.FullPathName).ToString())
			Dim uploadedName As String = FileManagerHelper.EndUploadFile(folderName)
			If (Not String.IsNullOrEmpty(uploadedName)) Then
				If node IsNot Nothing Then
					node.Expanded = True
				End If
				tree.RefreshVirtualTree()
				FocusByPath(uploadedName)
			End If
		End If
	End Sub

	Protected Function GetNodeGlyph(ByVal container As TreeListDataCellTemplateContainer) As String
		Dim fmt As String = "~/Editing/Images/{0}.png"
		If container.NodeKey Is Nothing Then
			Return String.Format(fmt, "closed")
		End If
		Dim name As String = container.GetValue(FileManagerHelper.FullPathName).ToString()
		If Directory.Exists(name) Then
			If container.Expandable AndAlso container.Expanded Then
				Return String.Format(fmt, "opened")
			End If
			Return String.Format(fmt, "closed")
		End If
		Return String.Format(fmt, "file")
	End Function
	Private Sub EnsureNode(ByVal node As TreeListNode)
		If node Is Nothing Then
			Throw New DemoException("Node not found.")
		End If
	End Sub
	Private Function ReadName(ByVal values As IDictionary) As String
		Dim obj As Object = values(FileManagerHelper.NameFieldName)
		If obj Is Nothing Then
			Return String.Empty
		End If
		Return obj.ToString().Trim()
	End Function
	Private Function IsValidName(ByVal name As String) As Boolean
		name = name.Trim()
		Return name.Length > 0 AndAlso (Not name.StartsWith(".")) AndAlso (Not name.Contains("/")) AndAlso Not name.Contains("\")
	End Function
	Private Sub FocusByPath(ByVal name As String)
		Dim key As String = FileManagerHelper.GetPathKey(name).ToString()
		Dim node As TreeListNode = tree.FindNodeByKeyValue(key)
		If node Is Nothing Then
			Return
		End If
		node.Focus()
	End Sub
End Class
