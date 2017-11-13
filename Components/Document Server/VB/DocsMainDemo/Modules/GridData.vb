Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Globalization
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Namespace DevExpress.Docs.Demos
	Public Class GridData
		Implements IList
		Private fCount As Integer = 22
		Private Const ColumnCount As Integer = 10
		Private book_Renamed As IWorkbook
		Public Sub New()
			book_Renamed = New Workbook()
			book_Renamed.Options.Culture = CultureInfo.InvariantCulture
			book_Renamed.LoadDocument(DemoUtils.GetRelativePath("FormulaCalculator_template.xlsx"))
		End Sub

		Friend Sub CreateGridDataSource(ByVal view As GridView, ByVal editor As DevExpress.XtraEditors.Repository.RepositoryItem)
			view.BeginDataUpdate()
			view.Columns.Clear()
			Try
				For i As Integer = 0 To GridData.ColumnCount - 1
					Dim col As New GridColumn()
					view.Columns.Add(col)
					col.FieldName = GetColumnCaption(i)
					col.Caption = col.FieldName
					col.UnboundType = DevExpress.Data.UnboundColumnType.Object
					col.Visible = True
					col.ColumnEdit = editor
				Next i
			Finally
				view.EndDataUpdate()
			End Try
		End Sub
		Private Function GetColumnCaption(ByVal col As Integer) As String
			Return book_Renamed.Worksheets(0).Columns(col).Heading
		End Function
		Public Sub SetCellValue(ByVal row As Integer, ByVal col As Integer, ByVal val As Object)
			Dim cell As Cell = book_Renamed.Worksheets(0).Cells(row, col)
			SetCellValue(cell, val)
		End Sub
		Public Sub SetCellValue(ByVal cell As Cell, ByVal val As Object)
			Try
				Dim value As Decimal = Decimal.Parse(CStr(val))
				If CStr(val) = (CInt(Fix(value))).ToString() Then
					cell.Value = CInt(Fix(value))
				Else
					cell.Value = CDbl(value)
				End If
			Catch
				cell.Value = CStr(val)
			End Try
		End Sub
		Public Function GetCell(ByVal row As Integer, ByVal col As Integer) As Cell
			Return book_Renamed.Worksheets(0).Cells(row, col)
		End Function

		Public ReadOnly Property Book() As IWorkbook
			Get
				Return book_Renamed
			End Get
		End Property
		Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
			Get
				Return fCount
			End Get
		End Property
		Default Public Property Item(ByVal index As Integer) As Object Implements IList.Item
			Get
				Return index
			End Get
			Set(ByVal value As Object)
			End Set
		End Property

		Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
			Get
				Return False
			End Get
		End Property
		Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
		End Sub
		Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
		End Sub
		Public Sub Remove(ByVal value As Object) Implements IList.Remove
		End Sub
		Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
			Return True
		End Function
		Public Sub Clear() Implements IList.Clear
		End Sub
		Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
			Return -1
		End Function
		Public Function Add(ByVal value As Object) As Integer Implements IList.Add
			Return -1
		End Function
		Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
			Get
				Return True
			End Get
		End Property
		Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo
		End Sub
		Public ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
			Get
				Return Me
			End Get
		End Property
		Public Function GetEnumerator() As IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
			Return Nothing
		End Function
	End Class
End Namespace
