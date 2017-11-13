Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraVerticalGrid.Demos
	Partial Public Class UnboundField
		Inherits TutorialControl

		Private firstNameRow, lastNameRow, UnboundRow As BaseRow

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\UnboundField.vb"
			TutorialInfo.WhatsThisXMLFile = "UnboundField.xml"
			DevExpress.XtraVerticalGrid.Design.XViews.ConfigureDemoView(vGridControl1)
		End Sub
		'<cbNameOrder>
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            UnboundRow = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            UnboundRow.Properties.UnboundType = DevExpress.Data.UnboundColumnType.String
            firstNameRow = vGridControl1.Rows.GetRowByFieldName("First Name", True)
            lastNameRow = vGridControl1.Rows.GetRowByFieldName("Last Name", True)
            firstNameRow.ParentRow.ChildRows.Insert(UnboundRow, 0)
            ConfigureUnboundFieldCaption()
        End Sub

		Private Sub ConfigureUnboundFieldCaption()
			UnboundRow.Properties.Caption = cbNameOrder.SelectedItem.ToString()
		End Sub

		Private Sub vGridControl1_CustomUnboundData(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDataEventArgs) Handles vGridControl1.CustomUnboundData
			If Not e.IsGetData Then
				Return
			End If
			e.Value = GetText(e.ListSourceRowIndex)
		End Sub
		'</cbNameOrder>
		Private Sub cbFirst_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbNameOrder.SelectedIndexChanged
			ConfigureUnboundFieldCaption()
			vGridControl1.Refresh()
		End Sub
		'<cbNameOrder>
		Private Function GetText(ByVal sourceIndex As Integer) As String
			Dim result As String = ""
			Select Case cbNameOrder.SelectedIndex
				Case 0
					result = vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString() & " " & vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString()
				Case 1
					result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString() & " " & vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString()
				Case 2
					result = vGridControl1.GetCellValue(firstNameRow, sourceIndex).ToString()
				Case 3
					result = vGridControl1.GetCellValue(lastNameRow, sourceIndex).ToString()
				Case 4
				Case Else
					Throw New Exception()
			End Select
			Return result
		End Function
		'</cbNameOrder>
	End Class
End Namespace
