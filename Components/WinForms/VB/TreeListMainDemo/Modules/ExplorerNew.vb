Imports System.Collections
Imports System.ComponentModel
Imports System.IO



Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class ExplorerNew
		Inherits TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property
		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\ExplorerNew.vb"
			TutorialInfo.WhatsThisXMLFile = "ExplorerNew.xml"
			InitData()
		End Sub

		'<treeList1>
		Private Sub InitData()
			treeList1.DataSource = New Object()
		End Sub

		Private loadDrives As Boolean = False

		Private Sub treeList1_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Handles treeList1.VirtualTreeGetChildNodes
			Dim current As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If Not loadDrives Then
				Dim roots() As String = Directory.GetLogicalDrives()
				e.Children = roots
				loadDrives = True
			Else
				Try
					Dim path As String = CStr(e.Node)
					If Directory.Exists(path) Then
						Dim dirs() As String = Directory.GetDirectories(path)
						Dim files() As String = Directory.GetFiles(path)
						Dim arr(dirs.Length + files.Length - 1) As String
						dirs.CopyTo(arr, 0)
						files.CopyTo(arr, dirs.Length)
						e.Children = arr
					Else
						e.Children = New Object() { }
					End If
				Catch
					e.Children = New Object() { }
				End Try
			End If
			Cursor.Current = current
		End Sub

		Private Sub treeList1_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Handles treeList1.VirtualTreeGetCellValue
			Dim di As New DirectoryInfo(CStr(e.Node))
			If e.Column Is colName Then
				e.CellData = di.Name
			End If
			If e.Column Is colType Then
				If IsDrive(CStr(e.Node)) Then
					e.CellData = "Drive"
				ElseIf Not IsFile(di) Then
					e.CellData = "Folder"
				Else
					e.CellData = "File"
				End If
			End If
			If e.Column Is colSize Then
				If IsFile(di) Then
					e.CellData = (New FileInfo(CStr(e.Node))).Length
				Else
					e.CellData = Nothing
				End If
			End If
		End Sub


		Private Function IsFile(ByVal info As DirectoryInfo) As Boolean
			Try
				Return (info.Attributes And FileAttributes.Directory) = 0
			Catch
				Return False
			End Try
		End Function
		Private Function IsDrive(ByVal val As String) As Boolean
			Dim drives() As String = Directory.GetLogicalDrives()
			For Each drive As String In drives
				If drive.Equals(val) Then
					Return True
				End If
			Next drive
			Return False
		End Function
		'</treeList1>


		Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles treeList1.GetStateImage
			If e.Node.GetDisplayText("Type") = "Folder" Then
				e.NodeImageIndex = If(e.Node.Expanded, 1, 0)
			ElseIf e.Node.GetDisplayText("Type") = "File" Then
				e.NodeImageIndex = 2
			Else
				e.NodeImageIndex = 3
			End If
		End Sub

		Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
			If e.Column Is Me.colSize Then
				If e.Node.GetDisplayText("Type") = "File" Then
					e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
					e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Italic)
					Dim size As Int64 = Convert.ToInt64(e.Node.GetValue("Size"))
					If size >= 1024 Then
						e.CellText = String.Format("{0:### ### ###} KB", size \ 1024)
					Else
						e.CellText = String.Format("{0} Bytes", size)
					End If
				Else
					e.CellText = String.Format("<{0}>", e.Node.GetDisplayText("Type"))
				End If
			End If

			If e.Column Is Me.colName Then
				If e.Node.GetDisplayText("Type") = "File" Then
					e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				End If
			End If
		End Sub

	End Class
End Namespace

