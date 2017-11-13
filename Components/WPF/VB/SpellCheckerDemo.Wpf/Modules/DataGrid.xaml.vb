Imports System.Windows
Imports System
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.SpellChecker
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.Native

Namespace SpellCheckerDemo
    Partial Public Class DataGrid
        Inherits SpellCheckerDemoModule

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = EmployeesData.DataSource
        End Sub

        Private stopChecking As Boolean
        Protected Sub CheckGrid()
            stopChecking = False
            SubscribeToEvents()
            CheckCell(0, 0)
        End Sub
        Private Sub SubscribeToEvents()
            AddHandler SpellChecker.CheckCompleteFormShowing, AddressOf Checker_CheckCompleteFormShowing
        End Sub
        Private Sub UnsubscribeFromEvents()
            RemoveHandler SpellChecker.CheckCompleteFormShowing, AddressOf Checker_CheckCompleteFormShowing
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CheckGrid()
        End Sub
        Private Sub Checker_CheckCompleteFormShowing(ByVal sender As Object, ByVal e As DevExpress.XtraSpellChecker.FormShowingEventArgs)
            e.Handled = True
        End Sub
        Private Sub CheckCell(ByVal rowIndex As Integer, ByVal columnIndex As Integer)
            Dim column As GridColumn = grid.Columns(columnIndex)
            If column.IsGrouped Then
                Return
            End If
            grid.CurrentColumn = column
            grid.View.FocusedRowHandle = rowIndex
            grid.View.ShowEditor()
            grid.UpdateLayout()

            Dim activeEditor As BaseEdit = grid.View.ActiveEditor
            If activeEditor Is Nothing OrElse (Not SpellChecker.CanCheck(activeEditor)) Then
                CheckNextCell()
            Else
                UnsubscribeFromEvents()
                AddHandler SpellChecker.CheckCompleteFormShowing, AddressOf Checker_CheckCompleteFormShowing
                AddHandler SpellChecker.AfterCheck, AddressOf Checker_AfterCheck
                CheckActiveEditor(activeEditor)
            End If
        End Sub
        Private Sub CheckActiveEditor(ByVal activeEditor As BaseEdit)
            If activeEditor.IsLoaded Then
                SpellChecker.Check(activeEditor)
            Else
                AddHandler activeEditor.Loaded, AddressOf OnActiveEditorLoaded
            End If
        End Sub
        Private Sub OnActiveEditorLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim activeEditor As BaseEdit = DirectCast(sender, BaseEdit)
            RemoveHandler activeEditor.Loaded, AddressOf OnActiveEditorLoaded
            SpellChecker.Check(activeEditor)
        End Sub
        Private Sub Checker_AfterCheck(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler SpellChecker.AfterCheck, AddressOf Checker_AfterCheck
            RemoveHandler SpellChecker.CheckCompleteFormShowing, AddressOf Checker_CheckCompleteFormShowing
            SubscribeToEvents()
            stopChecking = (TryCast(e, DevExpress.XtraSpellChecker.AfterCheckEventArgs)).Reason = DevExpress.XtraSpellChecker.StopCheckingReason.User
            CheckNextCell()
        End Sub
        Private Sub CheckNextCell()
            CheckNextCell(grid.View.FocusedRowHandle, CType(grid.CurrentColumn, GridColumn))
        End Sub
        Private Sub CheckNextCell(ByVal rowIndex As Integer, ByVal column As GridColumn)
            If stopChecking Then
                UnsubscribeFromEvents()
                Return
            End If
            Dim columnIndex As Integer = grid.Columns.IndexOf(column)
            Dim nextColumnIndex As Integer = If(columnIndex = grid.Columns.Count - 1, 0, columnIndex + 1)
            Dim nextRowIndex As Integer = If(nextColumnIndex = 0, rowIndex + 1, rowIndex)
            If Not grid.IsValidRowHandle(nextRowIndex) Then
                UnsubscribeFromEvents()
                DemoUtils.ShowDialog("Spelling", "Spelling check is complete", Me.GetRootVisual())
            Else
                CheckCell(nextRowIndex, nextColumnIndex)
            End If
        End Sub
        Private Sub editCheckAsYouType_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            ApplySpellCheckMode(CBool(e.NewValue))
        End Sub
        Private Sub grid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ApplySpellCheckMode(True)
        End Sub
    End Class
End Namespace
