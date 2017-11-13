Imports System
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.Xpf.Editors


Namespace RichEditDemo
    Partial Public Class OperationRestrictions
        Inherits RichEditDemoModule

        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("TextWithImages.rtf", richEdit)
            edtMinZoomFactor.EditValue = 0.5
            edtMaxZoomFactor.EditValue = 3.0
        End Sub

        Public ReadOnly Property IsHideDisabled() As Boolean
            Get
                Return edtHideDisabled.IsChecked.Value
            End Get
        End Property
        Public ReadOnly Property CurrentFileName() As String
            Get
                Return richEdit.Options.DocumentSaveOptions.CurrentFileName
            End Get
        End Property

        Public Function UpdateBarItemVisibility(ByVal capabilityCheckBoxChecked? As Boolean) As DocumentCapability
            If (Not capabilityCheckBoxChecked.HasValue) OrElse capabilityCheckBoxChecked.Value Then
                Return DocumentCapability.Enabled
            End If
            Return If(IsHideDisabled, DocumentCapability.Hidden, DocumentCapability.Disabled)
        End Function

        Private Function GetOptionValue(ByVal sender As Object) As DocumentCapability
            If DirectCast(sender, CheckEdit).IsChecked.Value Then
                Return DocumentCapability.Enabled
            End If
            If IsHideDisabled Then
                Return DocumentCapability.Hidden
            End If
            Return DocumentCapability.Disabled
        End Function

        Private Sub clipboardCut_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Cut = GetOptionValue(sender)
        End Sub
        Private Sub clipboardCopy_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Copy = GetOptionValue(sender)
        End Sub
        Private Sub clipboardPaste_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Paste = GetOptionValue(sender)
        End Sub
        Private Sub fileNew_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.CreateNew = GetOptionValue(sender)
        End Sub
        Private Sub fileOpen_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Open = GetOptionValue(sender)
        End Sub
        Private Sub fileSave_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Save = GetOptionValue(sender)
        End Sub
        Private Sub fileSaveAs_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.SaveAs = GetOptionValue(sender)
        End Sub
        Private Sub filePrint_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Printing = GetOptionValue(sender)
        End Sub
        Private Sub commonDrag_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Drag = GetOptionValue(sender)
        End Sub
        Private Sub commonDrop_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Drop = GetOptionValue(sender)
        End Sub
        Private Sub zoom_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.Zooming = GetOptionValue(sender)
        End Sub
        Private Sub readonly_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.ReadOnly = DirectCast(sender, CheckEdit).IsChecked.Value
        End Sub
        Private Sub showPopupMenu_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.Options.Behavior.ShowPopupMenu = GetOptionValue(sender)
        End Sub
        Private Sub hideDisabledItems_CheckedChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            richEdit.BeginUpdate()
            Try
                Dim options As RichEditBehaviorOptions = richEdit.Options.Behavior
                options.Cut = UpdateBarItemVisibility(Me.edtAllowCut.IsChecked)
                options.Copy = UpdateBarItemVisibility(Me.edtAllowCopy.IsChecked)
                options.Paste = UpdateBarItemVisibility(Me.edtAllowPaste.IsChecked)
                options.Drag = UpdateBarItemVisibility(Me.edtAllowDrag.IsChecked)
                options.Drop = UpdateBarItemVisibility(Me.edtAllowDrop.IsChecked)
                options.Save = UpdateBarItemVisibility(Me.edtAllowSave.IsChecked)
                options.SaveAs = UpdateBarItemVisibility(Me.edtAllowSaveAs.IsChecked)
                options.Printing = UpdateBarItemVisibility(Me.edtAllowPrinting.IsChecked)
                options.CreateNew = UpdateBarItemVisibility(Me.edtAllowCreateNew.IsChecked)
                options.Open = UpdateBarItemVisibility(Me.edtAllowOpen.IsChecked)
                options.Zooming = UpdateBarItemVisibility(Me.edtAllowZoom.IsChecked)
            Finally
                richEdit.EndUpdate()
            End Try
        End Sub

        Private Sub minZoom_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Try
                richEdit.Options.Behavior.MinZoomFactor = Convert.ToSingle(e.NewValue)
            Catch
            End Try
        End Sub

        Private Sub maxZoom_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Try
                richEdit.Options.Behavior.MaxZoomFactor = Convert.ToSingle(e.NewValue)
            Catch
            End Try
        End Sub
    End Class
End Namespace
