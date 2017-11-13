Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class TreeListDragDrop
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\DragDrop.vb;VB\TreeListMainDemo\Modules\DragObject.vb"
            TutorialInfo.WhatsThisXMLFile = "DragDrop.xml"
            InitData()

            '<treeList1>
            '            
            '~Note: the following properties are set at design time and listed here only for demonstration purposes.
            '~Allow the TreeList to accept objects during drag-and-drop:
            '~treeList1.AllowDrop = True
            '~Enable node drag-and-drop:
            '~treeList1.OptionsBehavior.DragNodes = True
            '~Allow end-users to clone nodes during drag-and-drop by holding the CTRL key down:
            '~treeList1.OptionsBehavior.CanCloneNodesOnDrop = True
            '            
            '</treeList1>

            '<label1>
            '            
            '~Note: the following property is set at design time and listed here only for demonstration purposes.
            '~Allow the label to accept objects during drag-and-drop:
            'label1.AllowDrop = True
            '            
            '</label1>

        End Sub

        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Private Sub InitData()
            Dim node As TreeListNode = treeList1.Nodes.Add("Project: Betaron", New Date(2011, 5, 1), New Date(2011, 9, 20), 0)
            node.StateImageIndex = 0
            node.Nodes.Add("Planning", New Date(2011, 5, 12), New Date(2011, 6, 15), 0).StateImageIndex = 0
            node.Nodes.Add("Design", New Date(2011, 5, 12), New Date(2011, 6, 15), 0).StateImageIndex = 0
            node.Nodes.Add("Development", New Date(2011, 7, 16), New Date(2011, 9, 20), 0).StateImageIndex = 0
            node.Nodes.Add("Testing and Delivery", New Date(2011, 8, 12), New Date(2011, 10, 17), 0).StateImageIndex = 0
            node.Nodes(0).Nodes.Add("Market research", New Date(2011, 5, 1), New Date(2011, 5, 13), 0).StateImageIndex = 2
            node.Nodes(0).Nodes.Add("Making specification", New Date(2011, 5, 14), New Date(2011, 6, 4), 2).StateImageIndex = 2
            node.Nodes(0).Nodes.Add("Documentation", New Date(2011, 6, 5), New Date(2011, 6, 15), 0).StateImageIndex = 2
            node.Nodes(1).Nodes.Add("Design of a web pages", New Date(2011, 7, 16), New Date(2011, 7, 28), 1).StateImageIndex = 2
            node.Nodes(1).Nodes.Add("Pages layout", New Date(2011, 8, 1), New Date(2011, 9, 20), 2).StateImageIndex = 2
            node.Nodes(2).Nodes.Add("Design", New Date(2011, 7, 16), New Date(2011, 7, 28), 2).StateImageIndex = 2
            node.Nodes(2).Nodes.Add("Coding", New Date(2011, 8, 1), New Date(2011, 9, 20), 1).StateImageIndex = 2
            node.Nodes(3).Nodes.Add("Testing", New Date(2011, 8, 12), New Date(2011, 8, 28), 2).StateImageIndex = 2
            node.Nodes(3).Nodes.Add("Content", New Date(2011, 9, 1), New Date(2011, 9, 24), 1).StateImageIndex = 2
            treeList1.ExpandAll()
        End Sub


        Private Function GetVisibleNodeAbove(ByVal node As TreeListNode) As TreeListNode
            Dim visIndex As Integer = treeList1.GetVisibleIndexByNode(node)
            Return treeList1.GetNodeByVisibleIndex(visIndex - 1)
        End Function

        '<imageListBoxControl1>
        Private newItem As ImageListBoxItem = Nothing

        Private Sub imageListBoxControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imageListBoxControl1.MouseDown
            Dim index As Integer = imageListBoxControl1.IndexFromPoint(New Point(e.X, e.Y))
            If index >= 0 Then
                newItem = imageListBoxControl1.Items(index)
            End If
        End Sub

        Private Sub imageListBoxControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imageListBoxControl1.MouseMove
            If newItem Is Nothing OrElse e.Button <> MouseButtons.Left Then
                Return
            End If
            imageListBoxControl1.DoDragDrop(New DragObject(newItem.ImageIndex), DragDropEffects.Copy)
        End Sub

        Private Sub imageListBoxControl1_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles imageListBoxControl1.GiveFeedback
            e.UseDefaultCursors = False
        End Sub
        '</imageListBoxControl1>


        '<treeList1>
        Private Sub treeList1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeList1.DragDrop
            Dim args As DXDragEventArgs = treeList1.GetDXDragEventArgs(e)
            Dim dobj As DragObject = GetDragObject(args.Data)
            If dobj IsNot Nothing Then
                Dim node As TreeListNode = args.TargetNode
                If args.HitInfo.HitInfoType = HitInfoType.Empty OrElse node IsNot Nothing Then
                    node = treeList1.AppendNode(dobj.DragData, node)
                    node.StateImageIndex = dobj.ImageIndex
                    treeList1.MakeNodeVisible(node)
                    Dim parentNode As TreeListNode = node.ParentNode
                    If parentNode IsNot Nothing AndAlso (e.KeyState And 4) <> 0 Then
                        Dim index As Integer = -1
                        If parentNode.ParentNode IsNot Nothing Then
                            index = parentNode.ParentNode.Nodes.IndexOf(parentNode)
                        End If
                        treeList1.MoveNode(node, parentNode.ParentNode)
                        treeList1.SetNodeIndex(node, index)
                    End If
                End If
            End If
            SetDefaultCursor()
        End Sub

        Private Sub treeList1_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeList1.DragLeave
            SetDefaultCursor()
        End Sub

        Private Sub treeList1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeList1.DragOver
            Dim args As DXDragEventArgs = treeList1.GetDXDragEventArgs(e)
            If args.Node Is Nothing Then
                If args.HitInfo.HitInfoType = HitInfoType.Empty OrElse args.HitInfo.Node IsNot Nothing Then
                    args.Effect = DragDropEffects.Copy
                Else
                    args.Effect = DragDropEffects.None
                End If
            End If
            SetDragCursor(args.Effect)
        End Sub
        Private Sub treeList1_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles treeList1.GiveFeedback
            e.UseDefaultCursors = False
        End Sub

        Private Sub SetDefaultCursor()
            Cursor = Cursors.Default
        End Sub
        Private Sub SetDragCursor(ByVal e As DragDropEffects)
            If e = DragDropEffects.Move Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("move.ico"))
            End If
            If e = DragDropEffects.Copy Then
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("copy.ico"))
            End If
            If e = DragDropEffects.None Then
                Cursor = Cursors.No
            End If
        End Sub
        Private Function GetDragObject(ByVal data As IDataObject) As DragObject
            Return TryCast(data.GetData(GetType(DragObject)), DragObject)
        End Function
        Private Function GetDragNode(ByVal data As IDataObject) As TreeListNode
            Return TryCast(data.GetData(GetType(TreeListNode)), TreeListNode)
        End Function
        '</treeList1>

        '<label1>
        Private Sub label1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles label1.DragEnter
            Dim node As TreeListNode = GetDragNode(e.Data)
            If node IsNot Nothing Then
                e.Effect = DragDropEffects.Copy
                Cursor = New Cursor(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("delete.ico"))
                label1.Appearance.ImageIndex = 1
            Else
                Cursor = Cursors.No
            End If
        End Sub
        Private Sub SetDefaultLabel()
            label1.Appearance.ImageIndex = 0
            SetDefaultCursor()
        End Sub
        Private Sub label1_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles label1.DragLeave
            SetDefaultLabel()
        End Sub

        Private Sub label1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles label1.DragDrop
            Dim node As TreeListNode = GetDragNode(e.Data)
            If node IsNot Nothing Then
                treeList1.DeleteNode(node)
            End If
            SetDefaultLabel()
        End Sub
        '</label1>

    End Class
End Namespace
