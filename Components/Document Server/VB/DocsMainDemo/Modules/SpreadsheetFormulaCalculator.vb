Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetFormulaCalculatorModule
		Inherits TutorialControlBase
		#Region "Fields"
		Private data As New GridData()
		Private formulaSetting As Boolean
		#End Region

		Public Sub New()
			InitializeComponent()
			Me.data.CreateGridDataSource(gridView1, Me.repositoryItemTextEdit)
			InitializeGridView()
			grid.DataSource = data
		End Sub

		Private Sub gridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView1.CellValueChanged
			Dim cell As Cell = GetSelectedCell()
			If formulaSetting Then
				formulaSetting = False
				formulaEdit.Text = cell.Formula
				Return
			End If
			Me.data.SetCellValue(cell, e.Value)
		End Sub
		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim value As String = CStr(e.Value)
			If (Not String.IsNullOrEmpty(value)) AndAlso value.Chars(0) = "="c Then
				SetFormula(value)
				formulaSetting = True
				Return
			End If
			If e.IsGetData Then
				Dim cell As Cell = Me.data.GetCell(CInt(Fix(e.Row)), e.Column.VisibleIndex)
				e.Value = If(cell.Value.IsEmpty, Nothing, cell.DisplayText)
			Else
				Me.data.SetCellValue(CInt(Fix(e.Row)), e.Column.VisibleIndex, e.Value)
			End If
		End Sub
		Private Sub gridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles gridView1.CustomDrawRowIndicator
			Dim rowIndex As Integer = gridView1.GetVisibleIndex(e.RowHandle)
			If rowIndex >= 0 Then
				rowIndex += 1
				e.Info.DisplayText = rowIndex.ToString()
			End If
			e.Info.ImageIndex = -1
		End Sub
		Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
			ShowFormula()
		End Sub
		Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			ShowFormula()
		End Sub
		Private Sub formulaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles formulaEdit.KeyDown
			If e.KeyValue <> 13 Then
				Return
			End If
			SetFormula(formulaEdit.Text)
			gridView1.RefreshData()
		End Sub
		Private Sub repositoryItemTextEdit_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemTextEdit.Enter
			Dim cell As Cell = GetSelectedCell()
			formulaEdit.Text = cell.Formula
			If (Not String.IsNullOrEmpty(cell.Formula)) Then
				CType(sender, TextEdit).Text = cell.Formula
			End If
		End Sub
		Private Sub repositoryItemTextEdit_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemTextEdit.Leave
			Dim cell As Cell = GetSelectedCell()
			If cell.Formula.Length > 0 AndAlso cell.Formula(0) = "="c Then
				Return
			End If
			BeginInvoke(New MethodInvoker(AddressOf gridView1.RefreshData))
		End Sub

		Private Function GetSelectedCell() As Cell
			Dim selectedRow As Integer = gridView1.GetVisibleIndex(gridView1.FocusedRowHandle)
			Dim selectedColumn As Integer = gridView1.FocusedColumn.VisibleIndex
			If selectedRow < 0 OrElse selectedColumn < 0 Then
				Return Nothing
			End If

			Return Me.data.GetCell(selectedRow, selectedColumn)
		End Function
		Private Sub SetFormula(ByVal formula As String)
			Dim cell As Cell = GetSelectedCell()
			If (Not String.IsNullOrEmpty(formula)) AndAlso formula.Chars(0) = "="c Then
				cell.Formula = formula
			Else
				data.SetCellValue(cell, formula)
			End If
		End Sub
		Private Sub ShowFormula()
			Dim cell As Cell = GetSelectedCell()
			If cell IsNot Nothing Then
				formulaEdit.Text = cell.Formula
			End If
		End Sub

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveButton.Click
			Dim fileName As String = SpreadsheetTutorialControl.GetSaveFileName("Excel Workbook(*.xlsx)|*.xlsx|Excel 97-2003 Workbook(*.xls)|*.xls|CSV (Comma delimited)(*.csv)|*.csv|PDF(*.pdf)|*.pdf", "Formula_Calculator")

			If (Not String.IsNullOrEmpty(fileName)) Then
				Dim ext As String = Path.GetExtension(fileName)
				If ext = ".xlsx" Then
					Me.data.Book.SaveDocument(fileName, DocumentFormat.OpenXml)
				ElseIf ext = ".xls" Then
					Me.data.Book.SaveDocument(fileName, DocumentFormat.Xls)
				ElseIf ext = ".csv" Then
					Me.data.Book.SaveDocument(fileName, DocumentFormat.Csv)
				ElseIf ext = ".pdf" Then
					Me.data.Book.ExportToPdf(fileName)
				End If
			End If
			SpreadsheetTutorialControl.ShowFile(fileName, Me)
		End Sub
		Private Sub InitializeGridView()
			Me.gridView1.Columns(1).Width = 230
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			Dim gridView As GridView = TryCast(sender, GridView)
			If (Not gridView.IsEditing) AndAlso (Not gridView.GridControl.Focused) AndAlso gridView.FocusedRowHandle = e.RowHandle AndAlso gridView.FocusedColumn.Equals(e.Column) Then
				e.Appearance.BackColor = gridView.PaintAppearance.HideSelectionRow.BackColor
			End If
		End Sub
	End Class
End Namespace
