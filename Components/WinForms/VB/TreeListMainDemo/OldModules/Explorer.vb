Imports System.Collections
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListExplorer
		Inherits TutorialControl

		Public Overrides ReadOnly Property ExportControl() As TreeList
			Get
				Return treeList1
			End Get
		End Property
		Protected Overrides ReadOnly Property BarName() As String
			Get
				Return "Explorer"
			End Get
		End Property
		Protected Overrides ReadOnly Property Manager() As BarManager
			Get
				Return barManager1
			End Get
		End Property
		Protected Overrides Sub InitBarInfo()
			Me.BarInfos.Add(New BarInfo("Show Logical Drivers", New ItemClickEventHandler(AddressOf ShowLogicalDriversClick), imageList3.Images(0), True, False, False))
			Me.BarInfos.Add(New BarInfo("Assign Check", New ItemClickEventHandler(AddressOf AssignCheckClick), imageList3.Images(1), True, True, False))
			Me.BarInfos.Add(New BarInfo("Even And Odd Style Enabled", New ItemClickEventHandler(AddressOf EvenOddStyleClick), imageList3.Images(2), True, True, False))
			Me.BarInfos.Add(New BarInfo("Show Footer", New ItemClickEventHandler(AddressOf ShowFooterClick), imageList3.Images(3), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Preview", New ItemClickEventHandler(AddressOf ShowPreviewClick), imageList3.Images(6), True, False, False))
			Me.BarInfos.Add(New BarInfo("Show Grid", New ItemClickEventHandler(AddressOf ShowGridClick), imageList3.Images(7), True, False, False))
			Me.BarInfos.Add(New BarInfo("Alpha Blending", New ItemClickEventHandler(AddressOf AlphaBlendingClick), imageList3.Images(8), False, False, False))
			Me.BarInfos.Add(New BarInfo("Checked Items List", New ItemClickEventHandler(AddressOf ListClick), imageList3.Images(4), False, False, True))
		End Sub

		Public Sub New()
			InitializeComponent()
			Me.colSize.StyleName = "Style1"
			InitRoot()
			xtraTreeListBlending1.Enabled = True
		End Sub

		Private Sub ShowLogicalDriversClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.ClearNodes()
			InitRoot()
		End Sub
		Private Sub AssignCheckClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If GetBarItemPushed(1) Then
				bar1.ItemLinks(1).Visible = True
				treeList1.StateImageList = imageList2
			Else
				bar1.ItemLinks(1).Visible = False
				treeList1.StateImageList = Nothing
			End If
			SetBarItemEnabled(7, GetBarItemPushed(1))
		End Sub
		Private Sub EvenOddStyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.EnableAppearanceEvenRow = GetBarItemPushed(2)
		End Sub
		Private Sub ShowFooterClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(3)
		End Sub
		Private Sub ShowPreviewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowPreview = GetBarItemPushed(4)
		End Sub
		Private Sub ShowGridClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			treeList1.OptionsView.ShowVertLines = GetBarItemPushed(5)
			treeList1.OptionsView.ShowHorzLines = treeList1.OptionsView.ShowVertLines
		End Sub
		Private Sub AlphaBlendingClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			xtraTreeListBlending1.ShowDialog()
		End Sub
		Private Sub ListClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim f As New DevExpress.XtraEditors.XtraForm()
			Dim tb As New TextBox()
			tb.Multiline = True
			tb.Dock = DockStyle.Fill
			tb.ScrollBars = ScrollBars.Vertical
			tb.Text = CheckedItemsInfoMain()
			tb.SelectionLength = 0

			f.Controls.Add(tb)
			f.Text = "CheckedItems Info"
			f.StartPosition = FormStartPosition.Manual
			f.FormBorderStyle = FormBorderStyle.SizableToolWindow
			f.Location = DevExpress.Utils.ControlUtils.CalcLocation(Control.MousePosition, Control.MousePosition, f.Size)
			f.ShowDialog()
		End Sub

		Private Function HasFiles(ByVal path As String) As Boolean
			Dim root() As String = Directory.GetFiles(path)
			If root.Length > 0 Then
				Return True
			End If
			root = Directory.GetDirectories(path)
			If root.Length > 0 Then
				Return True
			End If
			Return False
		End Function

		Private Sub InitFolders(ByVal path As String, ByVal pNode As TreeListNode, ByVal check As CheckState)
			treeList1.BeginUnboundLoad()
			Dim node As TreeListNode
			Dim di As DirectoryInfo
			Try
				Dim root() As String = Directory.GetDirectories(path)
				For Each s As String In root
					Try
						di = New DirectoryInfo(s)
						node = treeList1.AppendNode(New Object() { s, di.Name, "Folder", Nothing, di.Attributes, check }, pNode)
						node.HasChildren = HasFiles(s)
						If node.HasChildren Then
							node.Tag = True
						End If
					Catch
					End Try
				Next s
			Catch
			End Try
			InitFiles(path, pNode, check)
			treeList1.EndUnboundLoad()
		End Sub

		Private Sub InitFiles(ByVal path As String, ByVal pNode As TreeListNode, ByVal check As CheckState)
			Dim node As TreeListNode
			Dim fi As FileInfo
			Try
				Dim root() As String = Directory.GetFiles(path)
				For Each s As String In root
					fi = New FileInfo(s)
					node = treeList1.AppendNode(New Object() { s, fi.Name, "File", fi.Length, fi.Attributes, check }, pNode)
					node.HasChildren = False
				Next s
			Catch
			End Try
		End Sub

		Private Sub InitDrives()
			treeList1.BeginUnboundLoad()
            Dim node As TreeListNode
            Dim aNode As TreeListNode = Nothing
			Try
				Dim root() As String = Directory.GetLogicalDrives()

				For Each s As String In root
                    node = treeList1.AppendNode(New Object() {s, s, "Logical Driver", Nothing, Nothing, CheckState.Unchecked}, aNode)
					node.HasChildren = True
					node.Tag = True
				Next s
			Catch
			End Try
			treeList1.EndUnboundLoad()
		End Sub
		Private Sub InitRoot()
			If Not GetBarItemPushed(0) Then
				InitFolders(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory()), Nothing, CheckState.Unchecked)
			Else
				InitDrives()
			End If
		End Sub

		Private Sub treeList1_BeforeExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeExpandEventArgs) Handles treeList1.BeforeExpand
			If e.Node.Tag IsNot Nothing Then
				Dim currentCursor As Cursor = Cursor.Current
				Cursor.Current = Cursors.WaitCursor
				InitFolders(e.Node.GetDisplayText("FullName"), e.Node, CType(e.Node.GetValue("Check"), CheckState))
				e.Node.Tag = Nothing
				Cursor.Current = currentCursor
			End If
		End Sub

		Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles treeList1.GetSelectImage
			If e.Node.GetDisplayText("Type") = "Folder" Then
				e.NodeImageIndex = If(e.Node.Expanded, 1, 0)
			ElseIf e.Node.GetDisplayText("Type") = "File" Then
				e.NodeImageIndex = 2
			Else
				e.NodeImageIndex = 3
			End If
		End Sub

		Private Sub treeList1_GetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles treeList1.GetStateImage
			Dim check As CheckState = CType(e.Node.GetValue("Check"), CheckState)
			If check = CheckState.Unchecked Then
				e.NodeImageIndex = 0
			ElseIf check = CheckState.Checked Then
				e.NodeImageIndex = 1
			Else
				e.NodeImageIndex = 2
			End If
		End Sub

		Private Sub treeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles treeList1.KeyDown
			If e.KeyData = Keys.Space Then
				SetCheckedNode(treeList1.FocusedNode)
			End If
			If e.KeyData = Keys.Enter Then
				If treeList1.FocusedNode.GetDisplayText("Type") = "File" Then
					Try
						Dim process As New System.Diagnostics.Process()
						process.StartInfo.FileName = treeList1.FocusedNode.GetDisplayText("FullName")
						process.StartInfo.Verb = "Open"
						process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
						process.Start()
					Catch
					End Try
				Else
					If treeList1.FocusedNode.HasChildren Then
						treeList1.FocusedNode.Expanded = Not treeList1.FocusedNode.Expanded
					End If
				End If
			End If
		End Sub

		Private Sub SetCheckedNode(ByVal node As TreeListNode)
			Dim check As CheckState = CType(node.GetValue("Check"), CheckState)
			If check = CheckState.Indeterminate OrElse check = CheckState.Unchecked Then
				check = CheckState.Checked
			Else
				check = CheckState.Unchecked
			End If
			treeList1.FocusedNode = node
			treeList1.BeginUpdate()
			node("Check") = check
			StatusBarDisplayText(treeList1.FocusedNode)
			SetCheckedChildNodes(node, check)
			SetCheckedParentNodes(node, check)
			treeList1.EndUpdate()
		End Sub
		Private Sub SetCheckedChildNodes(ByVal node As TreeListNode, ByVal check As CheckState)
			For i As Integer = 0 To node.Nodes.Count - 1
				node.Nodes(i)("Check") = check
				SetCheckedChildNodes(node.Nodes(i), check)
			Next i
		End Sub
		Private Sub SetCheckedParentNodes(ByVal node As TreeListNode, ByVal check As CheckState)
			If node.ParentNode IsNot Nothing Then
				Dim b As Boolean = False
				For i As Integer = 0 To node.ParentNode.Nodes.Count - 1
					If Not check.Equals(node.ParentNode.Nodes(i)("Check")) Then
						b = Not b
						Exit For
					End If
				Next i
				node.ParentNode("Check") = If(b, CheckState.Indeterminate, check)
				SetCheckedParentNodes(node.ParentNode, check)
			End If
		End Sub

		Private Function CheckedItemsInfoMain() As String
			Dim s As String = ""
			CheckedItemsInfo(Nothing, s)
			If s = "" Then
				s = "No checked files..."
			End If
			Return s
		End Function

		Private Sub CheckedItemsInfo(ByVal pnode As TreeListNode, ByRef s As String)
			Dim nodes As TreeListNodes = If(pnode IsNot Nothing, pnode.Nodes, treeList1.Nodes)
			For Each node As TreeListNode In nodes
				Dim nodeChecked As CheckState = CType(node.GetValue("Check"), CheckState)
				If nodeChecked <> CheckState.Unchecked Then
					If nodeChecked = CheckState.Checked AndAlso node.GetDisplayText("Type") = "File" Then
						s &= node.GetDisplayText("FullName") & vbCrLf
					End If
					CheckedItemsInfo(node, s)
				End If
			Next node
		End Sub

		Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
			StatusBarDisplayText(e.Node)
		End Sub

		Private Sub StatusBarDisplayText(ByVal node As TreeListNode)
			If node IsNot Nothing Then
				barStaticItem1.Caption = node.GetDisplayText("FullName")
				barStaticItem2.Caption = node.GetDisplayText("Check")
			Else
				barStaticItem2.Caption = ""
				barStaticItem1.Caption = barStaticItem2.Caption
			End If
		End Sub

		Private Sub treeList1_CompareNodeValues(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CompareNodeValuesEventArgs) Handles treeList1.CompareNodeValues
			Dim type1 As String = e.Node1.GetDisplayText("Type")
			Dim type2 As String = e.Node2.GetDisplayText("Type")
			If type1 <> type2 Then
				If type1 = "Folder" Then
					e.Result = If(e.SortOrder = SortOrder.Ascending, -1, 1)
				Else
					e.Result = If(e.SortOrder = SortOrder.Ascending, 1, -1)
				End If
			End If
		End Sub

		Private Sub treeList1_GetPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetPreviewTextEventArgs) Handles treeList1.GetPreviewText
			e.PreviewText = e.Node.GetDisplayText("FullName")
		End Sub

		Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles treeList1.MouseDown
			If e.Button = MouseButtons.Left Then
				Dim hInfo As TreeListHitInfo = treeList1.CalcHitInfo(New Point(e.X, e.Y))
				If hInfo.HitInfoType = HitInfoType.StateImage Then
					SetCheckedNode(hInfo.Node)
				End If
			End If
		End Sub
	End Class
End Namespace
