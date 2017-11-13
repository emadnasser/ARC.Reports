Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Public Class DataSourceItem
	Public Shared Function GetDataSource() As List(Of DataSourceItem)
		Dim list = New List(Of DataSourceItem)()
		list.Add(New DataSourceItem("A", 20, 5, 8))
		list.Add(New DataSourceItem("B", 50, 3, 5))
		list.Add(New DataSourceItem("C", 40, 20, 10))
		list.Add(New DataSourceItem("D", 22, 15, 5))
		list.Add(New DataSourceItem("E", 30, 5, 8))
		list.Add(New DataSourceItem("F", 45, 5, 4))
		list.Add(New DataSourceItem("G", 35, 5, 3))
		list.Add(New DataSourceItem("H", 28, 4, 2))
		list.Add(New DataSourceItem("I", 46, 6, 4))
		list.Add(New DataSourceItem("J", 27, 8, 20))
		list.Add(New DataSourceItem("K", 20, 5, 8))
		list.Add(New DataSourceItem("L", 50, 3, 5))
		list.Add(New DataSourceItem("M", 40, 20, 10))
		list.Add(New DataSourceItem("N", 22, 15, 5))
		list.Add(New DataSourceItem("O", 30, 5, 8))
		list.Add(New DataSourceItem("P", 45, 5, 2))
		list.Add(New DataSourceItem("Q", 35, 5, 5))
		list.Add(New DataSourceItem("R", 28, 4, 4))
		list.Add(New DataSourceItem("S", 46, 6, 5))
		list.Add(New DataSourceItem("T", 27, 8, 8))
		Return list
	End Function

	Public Property Argument() As String
	Public Property Value() As Double
	Public Property PositiveError() As Double
	Public Property NegativeError() As Double

	Public Sub New(ByVal argument As String, ByVal value As Double, ByVal positiveError As Double, ByVal negativeError As Double)
		Argument = argument
		Value = value
		PositiveError = positiveError
		NegativeError = negativeError
	End Sub
End Class
