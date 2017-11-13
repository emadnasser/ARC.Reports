Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ucFindOptions
        Inherits XtraUserControl

        Private view As GridView = Nothing
        Public Sub New()
            InitializeComponent()
            InitEditors()
        End Sub
        Private updateValues As Boolean = False
        Public Sub InitData(ByVal view As GridView, ByVal findFilterColumns As List(Of ImageComboBoxItem))
            Me.view = view
            cbFindFilterColumns.Properties.Items.AddRange(findFilterColumns)
            updateValues = True
            ceAllowFindFilter.Checked = view.OptionsFind.AllowFindPanel
            ceAlwaysVisible.Checked = view.OptionsFind.AlwaysVisible
            ceClearFind.Checked = view.OptionsFind.ClearFindOnClose
            ceHighlightFindResults.Checked = view.OptionsFind.HighlightFindResults
            ceShowCloseButton.Checked = view.OptionsFind.ShowCloseButton
            seFindDelay.Value = view.OptionsFind.FindDelay
            cbFindFilterColumns.EditValue = view.OptionsFind.FindFilterColumns
            icbFindMode.EditValue = view.OptionsFind.FindMode
            ceShowClearButton.Checked = view.OptionsFind.ShowClearButton
            ceShowFindButton.Checked = view.OptionsFind.ShowClearButton
            ceSearchInPreview.Checked = view.OptionsFind.SearchInPreview
            updateValues = False
            InitValues()
        End Sub
        Private Sub InitEditors()
            For Each mode As FindMode In System.Enum.GetValues(GetType(FindMode))
                icbFindMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindMode).GetTitle(mode), mode, -1))
            Next mode
        End Sub
        Public ReadOnly Property MinHeight() As Integer
            Get
                Return layoutControl1.Root.MinSize.Height
            End Get
        End Property
        Private Sub InitValues()
            ceAlwaysVisible.Enabled = view.OptionsFind.AllowFindPanel
            If Not view.OptionsFind.AllowFindPanel Then
                ceAlwaysVisible.Checked = False
                view.HideFindPanel()
            Else
                view.ShowFindPanel()
            End If
            ceShowCloseButton.Enabled = Not view.OptionsFind.AlwaysVisible
        End Sub
        '<ceAllowFindFilter>
        Private Sub ceAllowFindFilter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowFindFilter.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.AllowFindPanel = ceAllowFindFilter.Checked
            InitValues()
        End Sub
        '</ceAllowFindFilter>
        '<ceAlwaysVisible>
        Private Sub ceAlwaysVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAlwaysVisible.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.AlwaysVisible = ceAlwaysVisible.Checked
            InitValues()
        End Sub
        '</ceAlwaysVisible>

        '<ceClearFind>
        Private Sub ceClearFind_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceClearFind.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.ClearFindOnClose = ceClearFind.Checked
        End Sub
        '</ceClearFind>

        '<ceHighlightFindResults>
        Private Sub ceHighlightFindResults_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceHighlightFindResults.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.HighlightFindResults = ceHighlightFindResults.Checked
        End Sub
        '</ceHighlightFindResults>

        '<ceShowCloseButton>
        Private Sub ceShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowCloseButton.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.ShowCloseButton = ceShowCloseButton.Checked
        End Sub
        '</ceShowCloseButton>

        '<seFindDelay>
        Private Sub seFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seFindDelay.EditValueChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value)
        End Sub
        '</seFindDelay>
        '<cbFindFilterColumns>
        Private Sub cbFindFilterColumns_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFindFilterColumns.EditValueChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.FindFilterColumns = String.Format("{0}", cbFindFilterColumns.EditValue)
            RefreshFindFilter()
        End Sub

        Private Sub RefreshFindFilter()
            Dim findText As String = view.FindFilterText
            view.ApplyFindFilter(String.Empty)
            view.ApplyFindFilter(findText)
        End Sub
        '</cbFindFilterColumns>
        '<icbFindMode>
        Private Sub icbFindMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFindMode.SelectedIndexChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.FindMode = CType(icbFindMode.EditValue, FindMode)
        End Sub
        '</icbFindMode>
        '<ceShowClearButton>
        Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowClearButton.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.ShowClearButton = ceShowClearButton.Checked
        End Sub
        '</ceShowClearButton>

        '<ceShowFindButton>
        Private Sub ceShowFindButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowFindButton.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsFind.ShowFindButton = ceShowFindButton.Checked
        End Sub
        '</ceShowFindButton>

        '<ceSearchInPreview>
        Private Sub ceSearchInPreview_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceSearchInPreview.CheckedChanged
            If updateValues OrElse view Is Nothing Then
                Return
            End If
            view.OptionsView.ShowPreview = ceSearchInPreview.Checked
            view.OptionsFind.SearchInPreview = ceSearchInPreview.Checked
        End Sub
        '</ceSearchInPreview>
    End Class
End Namespace
