Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraTreeList.Demos.Tutorials
	''' <summary>
	''' Summary description for UnboundMode.
	''' </summary>
	Public Partial Class UnboundMode
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub InitData()
			InitFolders(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()), Nothing)
		End Sub

		Private Sub InitFolders(ByVal path As String, ByVal pNode As TreeListNode)
			treeList1.BeginUnboundLoad()
			Dim node As TreeListNode
			Dim di As DirectoryInfo
			Try
				Dim root As String() = Directory.GetDirectories(path)
				For Each s As String In root
					Try
						di = New DirectoryInfo(s)
						node = treeList1.AppendNode(New Object() { s, di.Name, "Folder", Nothing }, pNode)
						node.StateImageIndex = 0
						node.HasChildren = HasFiles(s)
						If node.HasChildren Then
							node.Tag = True
						End If
					Catch
					End Try
				Next s
			Catch
			End Try
			InitFiles(path, pNode)
			treeList1.EndUnboundLoad()
		End Sub

		Private Sub InitFiles(ByVal path As String, ByVal pNode As TreeListNode)
			Dim node As TreeListNode
			Dim fi As FileInfo
			Try
				Dim root As String() = Directory.GetFiles(path)
				For Each s As String In root
					fi = New FileInfo(s)
					node = treeList1.AppendNode(New Object() { s, fi.Name, "File", fi.Length }, pNode)
					node.StateImageIndex = 1
					node.HasChildren = False
				Next s
			Catch
			End Try
		End Sub

		Private Function HasFiles(ByVal path As String) As Boolean
			Dim root As String() = Directory.GetFiles(path)
			If root.Length > 0 Then
			Return True
			End If
			root = Directory.GetDirectories(path)
			If root.Length > 0 Then
			Return True
			End If
			Return False
		End Function

		Private Sub treeList1_BeforeExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeExpandEventArgs) Handles treeList1.BeforeExpand
			If Not e.Node.Tag Is Nothing Then
                Dim currentCursor As Cursor = Windows.Forms.Cursor.Current
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
				InitFolders(e.Node.GetDisplayText("FullName"), e.Node)
				e.Node.Tag = Nothing
                Windows.Forms.Cursor.Current = currentCursor
			End If
		End Sub

		Private Sub treeList1_AfterExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeList1.AfterExpand
			If e.Node.StateImageIndex <> 1 Then
			e.Node.StateImageIndex = 2
			End If
		End Sub

		Private Sub treeList1_AfterCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeList1.AfterCollapse
			If e.Node.StateImageIndex <> 1 Then
			e.Node.StateImageIndex = 0
			End If
		End Sub
	End Class
End Namespace
