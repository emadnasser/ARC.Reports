Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Dragging
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.HitInfo

Namespace DevExpress.XtraLayout.Demos.Modules
	Public Interface IDragManager
		Property DragItem() As BaseLayoutItem
		Sub SetDragCursor(ByVal effect As DragDropEffects)
	End Interface
	Partial Public Class DragDropLayoutControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private ReadOnly Property DragManager() As IDragManager
			Get
				Return TryCast(Parent.Parent, IDragManager)
			End Get
		End Property
		Private newDragItem As BaseLayoutItem = Nothing
        Private Sub layoutControl2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dragDropLayout.MouseDown
            Dim hi As BaseLayoutItemHitInfo = dragDropLayout.CalcHitInfo(New Point(e.X, e.Y))
            Dim tghi As TabbedGroupHitInfo = TryCast(hi, TabbedGroupHitInfo)
            If tghi IsNot Nothing AndAlso tghi.TabbedGroupHotPageIndex >= 0 Then
                newDragItem = (CType(hi.Item, TabbedControlGroup)).TabPages(tghi.TabbedGroupHotPageIndex)
            Else
                newDragItem = hi.Item
            End If
        End Sub
        Private Sub layoutControl2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dragDropLayout.MouseMove
            If newDragItem Is Nothing OrElse e.Button <> MouseButtons.Left OrElse (newDragItem.Parent Is Nothing And Not newDragItem.Owner Is Nothing) Then
                Return
            End If
            DragManager.DragItem = newDragItem
            dragDropLayout.DoDragDrop(DragManager.DragItem, DragDropEffects.Copy)
            newDragItem = Nothing
        End Sub
        Private Sub layoutControl2_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles dragDropLayout.DragDrop
            If dragController IsNot Nothing AndAlso DragManager.DragItem IsNot Nothing Then
                If DragManager.DragItem.Owner Is Nothing OrElse DragManager.DragItem.Parent Is Nothing Then
                    dragController.DragWildItem()
                Else
                    dragController.Drag()
                End If
            End If
            HideDragHelper()
            Parent.Cursor = Cursors.Default
            DragManager.DragItem = Nothing
        End Sub
        Private Sub layoutControl2_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles dragDropLayout.DragEnter
            dragController = Nothing
            ShowDragHelper()
        End Sub
        Private Sub layoutControl2_DragLeave(ByVal sender As Object, ByVal e As EventArgs) Handles dragDropLayout.DragLeave
            HideDragHelper()
        End Sub
        Private Sub layoutControl2_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles dragDropLayout.DragOver
            UpdateDragHelper(New Point(e.X, e.Y))
            e.Effect = DragDropEffects.Copy
            DragManager.SetDragCursor(e.Effect)
        End Sub
        Private Sub layoutControl2_GiveFeedback(ByVal sender As Object, ByVal e As GiveFeedbackEventArgs) Handles dragDropLayout.GiveFeedback
            e.UseDefaultCursors = False
        End Sub
        'dragHelper
        Private window As DragFrameWindow
        Private dragController As LayoutItemDragController = Nothing
        Protected ReadOnly Property DragFrameWindow() As DragFrameWindow
            Get
                If window Is Nothing Then
                    window = New DragFrameWindow(dragDropLayout)
                End If
                Return window
            End Get
        End Property
        Protected Sub ShowDragHelper()
            If DragManager.DragItem Is Nothing Then
                Return
            End If
            DragFrameWindow.Visible = True
        End Sub
        Protected Sub HideDragHelper()
            DragFrameWindow.Reset()
            DragFrameWindow.Visible = False
        End Sub
        Protected Sub UpdateDragHelper(ByVal p As Point)
            If DragManager.DragItem Is Nothing Then
                Return
            End If
            p = dragDropLayout.PointToClient(p)
            dragController = New LayoutItemDragController(DragManager.DragItem, dragDropLayout.Root, New Point(p.X, p.Y))
            DragFrameWindow.DragController = dragController
        End Sub


	End Class
End Namespace
