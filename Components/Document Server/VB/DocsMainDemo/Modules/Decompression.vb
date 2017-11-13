Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports System.IO
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Compression
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors


Namespace DevExpress.Docs.Demos
	Partial Public Class Decompression
		Inherits TutorialControlBase
		Private visualizer As ZipItemVisualizer
		Private currentArchive As ZipArchive
		Private currentPassword As String
		Public Sub New()
			InitializeComponent()
			Me.visualizer = New ZipItemVisualizer(Me.tlZipContent)
			AddHandler Me.visualizer.SelectionChanged, AddressOf OnVisualizerSelectionChanged
			Me.buttonEdit1.EditValue = DemoUtils.GetRelativePath("Example.zip")
			ProcessZipArchive()
		End Sub
		Private Sub ProcessZipArchive()
			Dim pathToZipArchive As String = TryCast(Me.buttonEdit1.EditValue, String)
			If String.IsNullOrEmpty(pathToZipArchive) Then
				Return
			End If
			PrepareToVisualizeArchive()
			Try
				Me.currentArchive = ZipArchive.Read(pathToZipArchive)
			Catch
				XtraMessageBox.Show(Me, "Aarvhive cannot be opened", "Error")
				Return
			End Try
			For Each item As ZipItem In Me.currentArchive
				Dim zipInfo As New ZipItemInfo()
				zipInfo.Name = item.Name
				zipInfo.CompressedSize = item.CompressedSize
				zipInfo.UncompressedSize = item.UncompressedSize
				Me.visualizer.Add(zipInfo)
			Next item
			Me.visualizer.Sort()
		End Sub
		Private Sub ShowItemContent(ByVal itemName As String)
			If CanShowTextContent(itemName) Then
				ShowTextContent(itemName)
			ElseIf CanShowImageContent(itemName) Then
				ShowImageContent(itemName)
			Else
				ShowUnknownContent(itemName)
			End If
		End Sub
		Private Function OpenItem(ByVal itemName As String) As Stream
			If Me.currentArchive Is Nothing Then
				Return Nothing
			End If
			Dim item As ZipItem = Me.currentArchive(itemName)
			AskPassword(item)
			Dim result As Stream = ExtractItemToStream(item)
			If result Is Nothing Then
				Return Nothing
			End If
			result.Seek(0, SeekOrigin.Begin)
			Return result
		End Function
		Private Function ExtractItemToStream(ByVal item As ZipItem) As Stream
			Dim stream As New MemoryStream()
			Try
				item.Extract(stream)
			Catch e1 As WrongPasswordException
				Me.currentPassword = String.Empty
				XtraMessageBox.Show(Me, "The password is incorrect", "Error")
				Return Nothing
			Catch
				XtraMessageBox.Show("Can't unzip file", "Unzip error")
				Return Nothing
			End Try
			Return stream
		End Function
		Private Sub AskPassword(ByVal item As ZipItem)
			If item.EncryptionType.Equals(EncryptionType.None) Then
				Return
			End If
			If String.IsNullOrEmpty(Me.currentPassword) Then
				Dim form As New PasswordForm(item.Name)
				form.StartPosition = FormStartPosition.CenterParent
				If form.ShowDialog(Me) = DialogResult.OK Then
					item.Password = form.Password
					Me.currentPassword = item.Password
				End If
			End If
			item.Password = Me.currentPassword
		End Sub
		Private Sub ShowUnknownContent(ByVal itemName As String)
			Me.pictureBox1.Visible = False
			Me.textPreview.Visible = True
			Me.textPreview.Text = "Can't display content"
		End Sub
		Private Sub ShowImageContent(ByVal itemName As String)
			Using stream As Stream = OpenItem(itemName)
				If stream Is Nothing Then
					Return
				End If
				Me.pictureBox1.Visible = True
				Me.textPreview.Visible = False
				Dim img As Image = Image.FromStream(stream)
				Me.pictureBox1.Image = img
			End Using
		End Sub
		Private Function CanShowImageContent(ByVal itemName As String) As Boolean
			If String.IsNullOrEmpty(itemName) Then
				Return False
			End If
			Dim extensions() As String = { ".bmp", ".png", ".jpeg", ".jpg" }
			Return IsFitToExtension(itemName, extensions)
		End Function
		Private Sub ShowTextContent(ByVal itemName As String)
			Me.pictureBox1.Visible = False
			Me.textPreview.Visible = True
			Using stream As Stream = OpenItem(itemName)
				If stream Is Nothing Then
					Me.textPreview.Text = String.Empty
					Return
				End If
				Dim reader As New StreamReader(stream)
				Dim fileItemName As String = itemName.ToLower()
				If fileItemName.EndsWith(".rtf") Then
					Me.textPreview.RtfText = reader.ReadToEnd()
				ElseIf fileItemName.EndsWith(".docx") Then
					Me.textPreview.LoadDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.OpenXml)
				ElseIf fileItemName.EndsWith(".doc") Then
					Me.textPreview.LoadDocument(stream, DevExpress.XtraRichEdit.DocumentFormat.Doc)
				Else
					Me.textPreview.Text = reader.ReadToEnd()
				End If
			End Using
		End Sub
		Private Sub OnVisualizerSelectionChanged(ByVal sender As Object, ByVal itemName As String)
			ShowItemContent(itemName)
		End Sub
		Private Function CanShowTextContent(ByVal itemName As String) As Boolean
			If String.IsNullOrEmpty(itemName) Then
				Return False
			End If
			Dim extensions() As String = { ".txt", ".xml", ".rels", ".rtf", ".doc", ".docx", ".cs", ".vb", ".aspx" }
			Return IsFitToExtension(itemName, extensions)
		End Function
		Private Shared Function IsFitToExtension(ByVal itemName As String, ByVal extensions() As String) As Boolean
			For Each ext In extensions
				If itemName.EndsWith(ext) Then
					Return True
				End If
			Next ext
			Return False
		End Function
		Private Sub PrepareToVisualizeArchive()
			Me.textPreview.Text = String.Empty
			Me.pictureBox1.Visible = False
			Me.textPreview.Visible = True
			Me.currentPassword = String.Empty
			Me.visualizer.Reset()
			If Me.currentArchive IsNot Nothing Then
				Me.currentArchive.Dispose()
				Me.currentArchive = Nothing
			End If
		End Sub
		Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
			ChooseFile(String.Empty)
		End Sub
		Private Sub buttonEdit1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles buttonEdit1.KeyUp
			If e.KeyCode = Keys.Enter Then
				TryOpen()
			End If
		End Sub
		Private Sub TryOpen()
			Dim fileName As String = TryCast(Me.buttonEdit1.EditValue, String)
			If String.IsNullOrEmpty(fileName) Then
				Return
			End If
			Dim fileInfo As New FileInfo(fileName)
			If (Not fileInfo.Exists) Then
				ChooseFile(fileName)
				Return
			End If
			ProcessZipArchive()
		End Sub
		Private Sub ChooseFile(ByVal initPath As String)
			Using fileDialog As New OpenFileDialog()
				If (Not String.IsNullOrEmpty(initPath)) Then
					fileDialog.InitialDirectory = initPath
				End If
				If fileDialog.ShowDialog() = DialogResult.OK Then
					Me.buttonEdit1.EditValue = fileDialog.FileName
					ProcessZipArchive()
				End If
			End Using
		End Sub
	End Class
	#Region "Visualization Code"
	Public Class ZipItemInfo
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateCompressedSize As Long
		Public Property CompressedSize() As Long
			Get
				Return privateCompressedSize
			End Get
			Set(ByVal value As Long)
				privateCompressedSize = value
			End Set
		End Property
		Private privateUncompressedSize As Long
		Public Property UncompressedSize() As Long
			Get
				Return privateUncompressedSize
			End Get
			Set(ByVal value As Long)
				privateUncompressedSize = value
			End Set
		End Property
	End Class
	Public MustInherit Class VirtualNodeBase
		Protected Sub New(ByVal name As String)
			Name = name
			Children = New List(Of VirtualNodeBase)()
		End Sub
		Private privateChildren As List(Of VirtualNodeBase)
		Public Property Children() As List(Of VirtualNodeBase)
			Get
				Return privateChildren
			End Get
			Private Set(ByVal value As List(Of VirtualNodeBase))
				privateChildren = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Private Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class

	Public Class VirtualNode
		Public Sub New(ByVal name As String)
			Name = name
			Children = New List(Of VirtualNode)()
		End Sub

		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Private Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateChildren As List(Of VirtualNode)
		Public Property Children() As List(Of VirtualNode)
			Get
				Return privateChildren
			End Get
			Private Set(ByVal value As List(Of VirtualNode))
				privateChildren = value
			End Set
		End Property
		Private privateValue As ZipItemInfo
		Public Property Value() As ZipItemInfo
			Get
				Return privateValue
			End Get
			Set(ByVal value As ZipItemInfo)
				privateValue = value
			End Set
		End Property

		Public Sub AddChild(ByVal node As VirtualNode)
			Children.Add(node)
		End Sub
		Friend Function GetChildByName(ByVal pathItem As String) As VirtualNode
			For Each node In Children
				If node.Name = pathItem Then
					Return node
				End If
			Next node
			Return Nothing
		End Function
		Public Sub Sort()
			Children.Sort(New VirualNodeComparer())
			For Each item In Children
				item.Sort()
			Next item
		End Sub
		Public ReadOnly Property HasChild() As Boolean
			Get
				Return Children.Count > 0
			End Get
		End Property
	End Class
	Public Delegate Sub NodeSelectionChanged(ByVal sender As Object, ByVal itemName As String)
	Public Class ZipItemVisualizer
		Private treeList As TreeList
		Private loadDrives As Boolean
		Private root As New VirtualNode(String.Empty)

		Public Sub New(ByVal treeList As TreeList)
			Me.treeList = treeList
			AddHandler Me.treeList.CustomDrawNodeCell, AddressOf OnTreeListCustomDrawNodeCell
			AddHandler Me.treeList.VirtualTreeGetChildNodes, AddressOf OnTreeListVirtualTreeGetChildNodes
			AddHandler Me.treeList.VirtualTreeGetCellValue, AddressOf OnTreeListVirtualTreeGetCellValue
			AddHandler Me.treeList.FocusedNodeChanged, AddressOf OnTreeListFocusedNodeChanged
			For Each column As DevExpress.XtraTreeList.Columns.TreeListColumn In Me.treeList.Columns
				column.OptionsColumn.AllowSort = False
			Next column
			Reset()
		End Sub

		Public Event SelectionChanged As NodeSelectionChanged

		Private Sub OnTreeListFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs)
			Dim node As VirtualNode = TryCast(e.Node.GetValue(Me.treeList.Columns(0).FieldName), VirtualNode)
			If SelectionChangedEvent Is Nothing Then
				Return
			End If
			Dim itemInfo As ZipItemInfo = node.Value
			Dim name As String = If((itemInfo Is Nothing), Nothing, itemInfo.Name)
			RaiseEvent SelectionChanged(Me, name)
		End Sub
		Public Sub Reset()
			Me.loadDrives = False
			Me.treeList.DataSource = Nothing
			Me.root = New VirtualNode(String.Empty)
		End Sub
		Public Sub Add(ByVal item As ZipItemInfo)
			Dim pathItems() As String = item.Name.Split("/"c)
			Dim currentNode As VirtualNode = root
			For Each pathItem In pathItems
				If String.IsNullOrEmpty(pathItem) Then
					Continue For
				End If
				Dim node As VirtualNode = currentNode.GetChildByName(pathItem)
				If node Is Nothing Then
					node = New VirtualNode(pathItem)
					currentNode.AddChild(node)
				End If
				currentNode = node
			Next pathItem
			currentNode.Value = item
		End Sub
		Public Sub Sort()
			Me.root.Sort()
			Me.treeList.DataSource = New Object()
		End Sub
		Friend Function GetRootNodes() As VirtualNode()
			Return Me.root.Children.ToArray()
		End Function
		Private Sub OnTreeListVirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo)
			Dim current As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If (Not loadDrives) Then
				Dim roots() As VirtualNode = GetRootNodes()
				e.Children = roots
				loadDrives = True
			Else
				Dim currentNode As VirtualNode = CType(e.Node, VirtualNode)
				e.Children = currentNode.Children.ToArray()
			End If
			Cursor.Current = current
		End Sub
		Private Sub OnTreeListVirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo)
			Dim vn As VirtualNode = TryCast(e.Node, VirtualNode)
			e.CellData = vn
		End Sub
		Private Sub OnTreeListCustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs)
			e.CellText = String.Empty
			Dim node As VirtualNode = TryCast(e.Node.GetValue(e.Column.FieldName), VirtualNode)
			If node Is Nothing Then
				Return
			End If
			If e.Column.FieldName = "Name" AndAlso node IsNot Nothing Then
				If (Not node.HasChild) Then
					e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
				End If
				e.CellText = node.Name
				Return
			End If
			Dim zipItem As ZipItemInfo = node.Value
			If zipItem Is Nothing OrElse node.HasChild Then
				Return
			End If
			FormatAsSizeColumn(e.Appearance)
			Dim size As Long = 0
			If e.Column.FieldName = "CompressedSize" Then
				size = zipItem.CompressedSize
			ElseIf e.Column.FieldName = "UncompressedSize" Then
				size = zipItem.UncompressedSize
			End If
			e.CellText = GetText(size)
		End Sub
		Private Sub FormatAsSizeColumn(ByVal appearance As AppearanceObject)
			appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
			appearance.Font = New Font(appearance.Font, FontStyle.Italic)
		End Sub
		Private Function GetText(ByVal size As Long) As String
			If size >= 1024 Then
				Return String.Format("{0:### ### ###} KB", size \ 1024)
			End If
			Return String.Format("{0} Bytes", size)
		End Function
	End Class
	#End Region
	#Region "VirualNodeComparer"
	Friend Class VirualNodeComparer
		Implements IComparer(Of VirtualNode)
		Public Function Compare(ByVal x As VirtualNode, ByVal y As VirtualNode) As Integer Implements IComparer(Of VirtualNode).Compare
			If (Not x.HasChild) AndAlso y.HasChild Then
				Return 1
			Else
				If x.HasChild AndAlso (Not y.HasChild) Then
					Return -1
				End If
			End If
			Return String.Compare(x.Name, y.Name)
		End Function
	End Class
	#End Region
End Namespace
