Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraTreeList.Columns
Imports System.Collections
Imports DevExpress.XtraTreeList.ViewInfo

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class FindPanelOptions
		Inherits XtraForm

		Private treeList_Renamed As TreeList
		Public Sub New(ByVal treeList As TreeList)
			Me.treeList_Renamed = treeList
			InitializeComponent()
			Init(Me.TreeList.VisibleColumns)
		End Sub
		Protected ReadOnly Property TreeList() As TreeList
			Get
				Return treeList_Renamed
			End Get
		End Property
		Private Sub Init(ByVal findFilterColumns As VisibleColumnsList)
			InitFindFilterColumns(findFilterColumns)
			ceHighlightFindResults.Checked = TreeList.OptionsFind.HighlightFindResults
			ceShowCloseButton.Checked = TreeList.OptionsFind.ShowCloseButton
			ceShowClearButton.Checked = TreeList.OptionsFind.ShowClearButton
			ceShowFindButton.Checked = TreeList.OptionsFind.ShowFindButton
			seFindDelay.Value = TreeList.OptionsFind.FindDelay
			cbFindFilterColumns.EditValue = TreeList.OptionsFind.FindFilterColumns
			cbFindMode.EditValue = TreeList.OptionsFind.FindMode

			For Each mode As FindMode In System.Enum.GetValues(GetType(FindMode))
				cbFindMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindMode).GetTitle(mode), mode, -1))
			Next mode
		End Sub
		Private Sub InitFindFilterColumns(ByVal findFilterColumns As VisibleColumnsList)
			cbFindFilterColumns.Properties.Items.Add(New ImageComboBoxItem("*", "*"))
			For i As Integer = 0 To findFilterColumns.Count - 1
				Dim captions As String = findFilterColumns(i).GetCaption()
				Dim fieldNames As String = findFilterColumns(i).FieldName
				For j As Integer = i To findFilterColumns.Count - 1
					If j <> i Then
						captions &= String.Format(";{0}", findFilterColumns(j).GetCaption())
						fieldNames &= String.Format(";{0}", findFilterColumns(j).FieldName)
					End If
					cbFindFilterColumns.Properties.Items.Add(New ImageComboBoxItem(captions, fieldNames))
				Next j
			Next i
		End Sub
		Private Sub Apply()
			TreeList.OptionsFind.HighlightFindResults = ceHighlightFindResults.Checked
			TreeList.OptionsFind.ShowCloseButton = ceShowCloseButton.Checked
			TreeList.OptionsFind.ShowClearButton = ceShowClearButton.Checked
			TreeList.OptionsFind.ShowFindButton = ceShowFindButton.Checked
			TreeList.OptionsFind.FindFilterColumns = String.Format("{0}", cbFindFilterColumns.EditValue)
			TreeList.OptionsFind.FindMode = CType(cbFindMode.EditValue, FindMode)
			TreeList.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value)
		End Sub
		Private Sub btnApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnApply.Click
			Apply()
		End Sub
	End Class
End Namespace
