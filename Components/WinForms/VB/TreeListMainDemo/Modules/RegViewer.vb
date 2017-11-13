Imports System.Collections
Imports System.ComponentModel
Imports Microsoft.Win32
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class TreeListRegViewer
        Inherits TutorialControl

        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return Nothing
            End Get
        End Property
        Protected Overrides ReadOnly Property BarName() As String
            Get
                Return "RegViewer"
            End Get
        End Property
        Protected Overrides ReadOnly Property Manager() As BarManager
            Get
                Return barManager1
            End Get
        End Property
        Protected Overrides Sub InitBarInfo()
            Me.BarInfos.Add(New BarInfo("Display Style", New ItemClickEventHandler(AddressOf StyleClick), imageCollection3.Images(0), True, True, False))
            Me.BarInfos.Add(New BarInfo("Full Collapse", New ItemClickEventHandler(AddressOf CollapseClick), imageCollection3.Images(1), False, False, True))
            Me.BarInfos.Add(New BarInfo("Show First Footer", New ItemClickEventHandler(AddressOf ShowFirstFooterClick), imageCollection3.Images(2), True, False, False))
            Me.BarInfos.Add(New BarInfo("Show Second Footer", New ItemClickEventHandler(AddressOf ShowSecondFooterClick), imageCollection3.Images(3), True, False, False))
            Me.BarInfos.Add(New BarInfo("Show Preview", New ItemClickEventHandler(AddressOf ShowPreviewClick), imageCollection3.Images(4), True, False, False))
            Me.BarInfos.Add(New BarInfo("Columns Selector", New ItemClickEventHandler(AddressOf ColumnsSelectorClick), imageCollection3.Images(5), True, False, False))
        End Sub

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\RegViewer.vb"
            TutorialInfo.WhatsThisXMLFile = "RegViewer.xml"
        End Sub

        '<treeList1>
        Private root As Array = System.Enum.GetValues(GetType(RegistryHive))
        Private rootNames() As String

        Private Sub TreeListRegViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CreateArrayWithNames()
            AppendNodes(rootNames, Nothing, "", "")
            '<skip>
            SetAppearances(treeList1, treeList2)
            ResetOddEvenAppearance(treeList1)
            '</skip>
        End Sub
        '</treeList1>

        Private Sub StyleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If GetBarItemPushed(0) Then
                treeList1.Dock = DockStyle.Left
                splitter1.Dock = DockStyle.Left
                treeList1.Width = Width \ 3
            Else
                treeList1.Dock = DockStyle.Top
                splitter1.Dock = DockStyle.Top
                treeList1.Height = Height \ 2
            End If
        End Sub
        Private Sub CollapseClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.CollapseAll()
        End Sub
        Private Sub ShowFirstFooterClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.OptionsView.ShowSummaryFooter = GetBarItemPushed(2)
        End Sub
        Private Sub ShowSecondFooterClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList2.OptionsView.ShowSummaryFooter = GetBarItemPushed(3)
        End Sub
        Private Sub ShowPreviewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            treeList1.OptionsView.ShowHorzLines = GetBarItemPushed(4)
            treeList1.OptionsView.AutoCalcPreviewLineCount = treeList1.OptionsView.ShowHorzLines
            treeList1.OptionsView.ShowPreview = treeList1.OptionsView.AutoCalcPreviewLineCount
        End Sub
        Private Sub ColumnsSelectorClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If GetBarItemPushed(5) Then
                treeList2.ColumnsCustomization()
            Else
                treeList2.DestroyCustomization()
            End If
        End Sub


        '<treeList1>
        '        
        '~Add root nodes representing root Registry Keys:
        '         
        Private Sub AppendNodes(ByVal names() As String, ByVal aNode As TreeListNode, ByVal root As String, ByVal root2 As String)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor

            treeList1.BeginUnboundLoad()
            Dim node As TreeListNode
            For Each s As String In names
                node = treeList1.AppendNode(New Object() {s}, aNode)
                Try
                    If root = "" Then
                        node.HasChildren = KeyByName(s, "").SubKeyCount > 0
                    Else
                        node.HasChildren = KeyByName(root, (If(root2 <> "", root2 & "\" & s, s))).SubKeyCount > 0
                    End If
                    node.Tag = True
                Catch
                End Try
            Next s
            treeList1.EndUnboundLoad()

            Cursor.Current = currentCursor
        End Sub
        '        
        '~Append child nodes (child Registry Keys) when a node is expanded:
        '         
        Private Sub treeList1_BeforeExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeExpandEventArgs) Handles treeList1.BeforeExpand
            If Convert.ToBoolean(e.Node.Tag) Then
                Dim fullName As String = FullNameByNode(e.Node, 0)
                Dim name1 As String = RegKey(fullName, 0)
                Dim name2 As String = RegKey(fullName, 2)
                Dim rk As RegistryKey = KeyByName(name1, name2)
                Dim names() As String = rk.GetSubKeyNames()
                AppendNodes(names, e.Node, name1, name2)
            End If
            e.Node.Tag = False
        End Sub
        '        
        '~Expand/collapse nodes when pressing the Right and Left Arrow keyboard buttons:
        '         
        Private Sub treeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles treeList1.KeyDown
            Dim tl As TreeList = TryCast(sender, TreeList)
            If tl.FocusedNode IsNot Nothing Then
                If e.KeyCode = Keys.Right Then
                    If (Not tl.FocusedNode.Expanded) AndAlso tl.FocusedNode.HasChildren Then
                        tl.FocusedNode.Expanded = True
                    Else
                        tl.MoveNextVisible()
                    End If
                End If
                If e.KeyCode = Keys.Left Then
                    If tl.FocusedNode.Expanded Then
                        tl.FocusedNode.Expanded = False
                    Else
                        tl.MovePrevVisible()
                    End If
                End If
            End If
        End Sub

        Private Sub CreateArrayWithNames()
            rootNames = New String(root.Length - 1) {}
            For i As Integer = 0 To root.Length - 1
                rootNames(i) = StringKeyByRegistryHive(CType(root.GetValue(i), RegistryHive))
            Next i
        End Sub
        Private Function StringKeyByRegistryHive(ByVal hKey As RegistryHive) As String
            Return RegistryKey.OpenRemoteBaseKey(hKey, "").Name
        End Function
        Private Function KeyByName(ByVal name As String, ByVal subName As String) As RegistryKey
            Dim ind As Integer = -1
            For i As Integer = 0 To rootNames.Length - 1
                If name = rootNames.GetValue(i).ToString() Then
                    ind = i
                    Exit For
                End If
            Next i
            If ind > -1 Then
                Try
                    If subName <> "" Then
                        Return RegistryKey.OpenRemoteBaseKey(CType(root.GetValue(ind), RegistryHive), "").OpenSubKey(subName)
                    Else
                        Return RegistryKey.OpenRemoteBaseKey(CType(root.GetValue(ind), RegistryHive), "")
                    End If
                Catch
                End Try
            End If
            Return Nothing
        End Function
        '</treeList1>

        '<treeList2>
        Private Sub treeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList1.FocusedNodeChanged
            Dim s As String = FullNameByNode(e.Node, 0)
            barStaticItem1.Caption = s
            AppendValues(s)
        End Sub

        Private Sub AppendValues(ByVal key As String)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor

            treeList2.BeginUnboundLoad()
            treeList2.ClearNodes()
            Dim node As TreeListNode
            Dim aNode As TreeListNode = Nothing
            Dim rk As RegistryKey = KeyByName(RegKey(key, 0), RegKey(key, 2))
            Try
                Dim values() As String = rk.GetValueNames()
                For Each s As String In values
                    Dim obj As Object = rk.GetValue(s)
                    node = treeList2.AppendNode(New Object() {IIf(s = "", "(Default)", s), obj, obj.GetType().ToString()}, aNode)
                Next s
            Catch
            End Try
            treeList2.EndUnboundLoad()
            Cursor.Current = currentCursor
        End Sub
        '</treeList2>

        Private Sub SetAppearances(ByVal sourceTreeList As TreeList, ByVal treeList As TreeList)
            treeList.Appearance.Assign(sourceTreeList.Appearance)
        End Sub

        Private Sub ResetOddEvenAppearance(ByVal tl As TreeList)
            tl.Appearance.OddRow.Reset()
            tl.Appearance.EvenRow.Reset()
        End Sub

        Private Function RegKey(ByVal s As String, ByVal i As Integer) As String
            Dim sArr() As String = s.Split("\"c)
            If i = 0 Then
                Return sArr(0)
            ElseIf i = 1 Then
                Return sArr(sArr.Length - 1)
            Else
                Dim ret As String = ""
                For n As Integer = 1 To sArr.Length - 1
                    ret &= sArr(n) & (If(n < sArr.Length - 1, "\", ""))
                Next n
                Return ret
            End If
        End Function
        Private Function FullNameByNode(ByVal node As TreeListNode, ByVal columnId As Integer) As String
            Dim ret As String = node.GetValue(columnId).ToString()
            Do While node.ParentNode IsNot Nothing
                node = node.ParentNode
                ret = node.GetValue(columnId).ToString() & "\" & ret
            Loop
            Return ret
        End Function


        Private Sub treeList1_GetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles treeList1.GetSelectImage
            If e.Node.ParentNode Is Nothing Then
                e.NodeImageIndex = 0
            Else
                e.NodeImageIndex = If(e.FocusedNode, 2, 1)
            End If
        End Sub

        Private Sub treeList2_GetSelectImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs) Handles treeList2.GetSelectImage
            Dim s As String = e.Node.GetValue(colType).ToString()
            If s = "System.Byte[]" Then
                e.NodeImageIndex = 2
            ElseIf s = "System.Int32" Then
                e.NodeImageIndex = 1
            Else
                e.NodeImageIndex = 0
            End If
        End Sub
        Private Function ByteToString(ByVal b() As Byte) As String
            Dim ret As String = ""
            Dim app As Integer = 10
            Dim i As Integer = 0
            Do While i < b.Length AndAlso i < app
                ret &= b.GetValue(i).ToString() & (If(i = app - 1 AndAlso i <> b.Length - 1, "...", " "))
                i += 1
            Loop
            Return ret
        End Function
        Private Sub treeList2_GetNodeDisplayValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetNodeDisplayValueEventArgs) Handles treeList2.GetNodeDisplayValue
            If e.Column.AbsoluteIndex = 1 Then
                If e.Node.GetValue(2).ToString() = "System.Byte[]" Then
                    e.Value = ByteToString(CType(e.Value, Byte()))
                End If
                If e.Node.GetValue(2).ToString() = "System.String" Then
                    e.Value = String.Format(Chr(34) + "{0}" + Chr(34), e.Value)
                End If
            End If
        End Sub



        Private Sub treeList2_HideCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList2.HideCustomizationForm
            SetBarItemChecked(5, False)
        End Sub

        Private Sub treeList1_GetPreviewText(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetPreviewTextEventArgs) Handles treeList1.GetPreviewText
            e.PreviewText = FullNameByNode(e.Node, 0)
        End Sub

        Private Sub treeList2_ShowCustomizationForm(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList2.ShowCustomizationForm
            SetBarItemChecked(5, True)
        End Sub
    End Class
End Namespace
