Imports Microsoft.VisualBasic
Imports DevExpress.Data.ChartDataSources
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data

Namespace PivotGridOlapBrowser
	Friend NotInheritable Class PivotDataExtractor
		Public Const ColumnNameIsSelected As String = "IsSelected"
		Public Const ColumnNameIsRowTotal As String = "IsRowTotal"
		Public Const ColumnNameIsColumnTotal As String = "IsColumnTotal"
		Public Const ColumnNameIsRowGrandTotal As String = "IsRowGrandTotal"
		Public Const ColumnNameIsColumnGrandTotal As String = "IsColumnGrandTotal"

		Private Sub New()
		End Sub
		Public Shared Function GetDataTable(ByVal pivot As PivotGridControl) As DataTable
			Dim dataTable As New DataTable()
			Dim pivotGrid As IPivotGrid = CType(pivot, IPivotGrid)
			Dim selectionOnly As Boolean = pivotGrid.SelectionOnly
			pivotGrid.SelectionOnly = False
			Try
				Dim properties As PropertyDescriptorCollection = (CType(pivot, ITypedList)).GetItemProperties(Nothing)
				FillDataTableColumns(pivot, properties, dataTable, False)
				FillDataTableRows(pivot, properties, dataTable, False)
			Finally
				pivotGrid.SelectionOnly = selectionOnly
			End Try
			Return dataTable
		End Function
		Private Shared Sub FillDataTableColumns(ByVal pivot As PivotGridControl, ByVal properties As PropertyDescriptorCollection, ByVal dataTable As DataTable, ByVal isDateTimeArguments As Boolean)
			For Each d As PropertyDescriptor In properties
				If isDateTimeArguments AndAlso d.Name = "Arguments" Then
					dataTable.Columns.Add(d.Name, GetType(DateTime))
				Else
					dataTable.Columns.Add(d.Name, d.PropertyType)
				End If
			Next d
			dataTable.Columns.Add(ColumnNameIsColumnTotal, GetType(Boolean))
			dataTable.Columns.Add(ColumnNameIsRowTotal, GetType(Boolean))
			dataTable.Columns.Add(ColumnNameIsColumnGrandTotal, GetType(Boolean))
			dataTable.Columns.Add(ColumnNameIsRowGrandTotal, GetType(Boolean))
			If GetHasSelection(pivot) Then
				dataTable.Columns.Add(ColumnNameIsSelected, GetType(Boolean))
			End If
		End Sub
		Private Shared Sub FillDataTableRows(ByVal pivot As PivotGridControl, ByVal properties As PropertyDescriptorCollection, ByVal dataTable As DataTable, ByVal isDateTimeArguments As Boolean)
			dataTable.Rows.Clear()
			Dim list As IList = CType(pivot, IList)
			For i As Integer = 0 To list.Count - 1
				Dim row As DataRow = dataTable.Rows.Add(New Object() { })
				For Each d As PropertyDescriptor In properties
					Dim value As Object = d.GetValue(list(i))
					If isDateTimeArguments AndAlso d.Name = "Arguments" Then
						Dim dt As DateTime
						Try
							dt = Convert.ToDateTime(value)
						Catch
							dt = DateTime.MinValue
						End Try
						If dt <> DateTime.MinValue Then
							row(d.Name) = dt
						End If
					Else
						row(d.Name) = value
					End If
				Next d
				Dim chartDataSourceRow As PivotChartDataSourceRowItem = CType(list(i), PivotChartDataSourceRowItem)
				Dim cellInfo As PivotCellEventArgs = pivot.Cells.GetCellInfo(chartDataSourceRow.CellX, chartDataSourceRow.CellY)
				Dim columnType As PivotGridValueType = cellInfo.ColumnValueType, rowType As PivotGridValueType = cellInfo.RowValueType
				row(ColumnNameIsColumnTotal) = Object.Equals(columnType, PivotGridValueType.Total) OrElse Object.Equals(columnType, PivotGridValueType.CustomTotal)
				row(ColumnNameIsRowTotal) = Object.Equals(rowType, PivotGridValueType.Total) OrElse Object.Equals(rowType, PivotGridValueType.CustomTotal)
				row(ColumnNameIsColumnGrandTotal) = Object.Equals(columnType, PivotGridValueType.GrandTotal)
				row(ColumnNameIsRowGrandTotal) = Object.Equals(rowType, PivotGridValueType.GrandTotal)
				If GetHasSelection(pivot) Then
					row(ColumnNameIsSelected) = pivot.Cells.MultiSelection.SelectedCells.Contains(New System.Drawing.Point(chartDataSourceRow.CellX, chartDataSourceRow.CellY))
				End If
			Next i
		End Sub
		Private Shared Function GetHasSelection(ByVal pivot As PivotGridControl) As Boolean
			Return pivot.Cells.MultiSelection.SelectedCells.Count > 1
		End Function
	End Class
End Namespace
