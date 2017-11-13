Imports DevExpress.Utils
Imports System.Windows.Forms
Imports System.Drawing
Imports System

Namespace DevExpress.DevAV

    Partial Public Class FilterForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            Icon = AppHelper.AppIcon
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Bounds = PlacementHelper.Arrange(Size, Owner.Bounds, ContentAlignment.MiddleCenter)
        End Sub
        Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
            MyBase.OnControlAdded(e)
            If TypeOf e.Control Is UserControl Then
                AcceptButton = Find(e.Control, Function(btn) btn.Text = "OK")
                CancelButton = Find(e.Control, Function(btn) btn.Text = "Cancel")
            End If
        End Sub
        Private Function Find(ByVal control As Control, ByVal predicate As Predicate(Of Control)) As IButtonControl
            For Each child As Control In control.Controls
                If TypeOf child Is IButtonControl AndAlso predicate(child) Then
                    Return DirectCast(child, IButtonControl)
                End If
                Dim nested As IButtonControl = Find(child, predicate)
                If nested IsNot Nothing Then
                    Return nested
                End If
            Next child
            Return Nothing
        End Function
    End Class
End Namespace
