Imports System.Data.OleDb
Imports System.Globalization

Namespace DevExpress.SalesDemo.Model
	Public Class OleDataProvider
		Implements IDataProvider, IDisposable

		Private Enum GroupColumn
			None
			Channel
			Product
			Region
			Sector
		End Enum
		Private ReadOnly connection As OleDbConnection
		Public Sub New(ByVal dbPath As String)
			connection = New OleDbConnection(GetConnectionString(dbPath))
		End Sub
		Public Shared Function GetConnectionString(ByVal dbPath As String) As String
			Return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbPath)
		End Function
		Private Function GetGroupBy(ByVal period As GroupingPeriod, ByVal column As String, ByVal noneFormat As String) As String
			Select Case period
				Case GroupingPeriod.Hour
					Return "Format(" & column & ", 'mm/dd/yy HH:00:00')"
				Case GroupingPeriod.Day
					Return "Format(" & column & ", 'mm/dd/yy 00:00:00')"
				Case Else
					Return noneFormat
			End Select
		End Function
		Private Shared Function GetSaleDate(ByVal value As String, ByVal defaultDate As Date) As Date
			Dim result As Date
			If Date.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, result) Then
				Return result
			End If
			Return defaultDate
		End Function
		Private Function CreateQueryBySales(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As OleDbCommand
			Dim query As String = String.Format("SELECT" & ControlChars.CrLf & "                                                'TOTAL' AS Name," & ControlChars.CrLf & "	                                            SUM(Total_Cost) AS TotalCost, " & ControlChars.CrLf & "	                                            SUM(Units) AS Units," & ControlChars.CrLf & "                                                {0} AS SaleDate" & ControlChars.CrLf & "                                           FROM " & ControlChars.CrLf & "                                                Sales" & ControlChars.CrLf & "                                           WHERE " & ControlChars.CrLf & "                                                Sale_Date BETWEEN @PeriodStart and @PeriodEnd" & ControlChars.CrLf & "                                           GROUP BY" & ControlChars.CrLf & "                                                {0}", GetGroupBy(period, "Sale_Date", "'-'"))
			Dim command As New OleDbCommand(query)
			command.Parameters.Add(New OleDbParameter("@PeriodStart", OleDbType.Date)).Value = start
			command.Parameters.Add(New OleDbParameter("@PeriodEnd", OleDbType.Date)).Value = [end]
			Return command
		End Function
		Private Function CreateJoinQuery(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod, ByVal column As GroupColumn) As OleDbCommand
			Dim groupBy As String = GetGroupBy(period, "Sales.Sale_Date", String.Empty)
			Dim groupByField As String = String.Empty
			Dim groupByCondition As String = String.Empty
			If Not String.IsNullOrEmpty(groupBy) Then
				groupByField = ", " & groupBy & " AS SaleDate"
				groupByCondition = ", " & groupBy
			End If

			Dim keyColumn As String = String.Empty
			Dim tableName As String = String.Empty
			Dim columnName As String = String.Empty

			Select Case column
				Case GroupColumn.Channel
					keyColumn = "ChannelId"
					tableName = "Channels"
					columnName = "Channel_Name"
				Case GroupColumn.Product
					keyColumn = "ProductId"
					tableName = "Products"
					columnName = "Product_Name"
				Case GroupColumn.Region
					keyColumn = "RegionId"
					tableName = "Regions"
					columnName = "Region_Name"
				Case GroupColumn.Sector
					keyColumn = "SectorId"
					tableName = "Sectors"
					columnName = "Sector_Name"
			End Select
			Dim query As String = String.Format("SELECT" & ControlChars.CrLf & "	                                        Cstr(LinkedTable.{1}) as Name," & ControlChars.CrLf & "	                                        SUM(Sales.Total_Cost) as TotalCost, " & ControlChars.CrLf & "	                                        SUM(Sales.Units) as Units" & ControlChars.CrLf & "                                            {2}" & ControlChars.CrLf & "                                        FROM " & ControlChars.CrLf & "                                            Sales" & ControlChars.CrLf & "                                        INNER JOIN " & ControlChars.CrLf & "                                            {3} as LinkedTable on Sales.{0} = LinkedTable.Id" & ControlChars.CrLf & "                                        WHERE " & ControlChars.CrLf & "                                            Sales.Sale_Date BETWEEN @PeriodStart and @PeriodEnd  " & ControlChars.CrLf & "                                        GROUP BY" & ControlChars.CrLf & "                                            Cstr(LinkedTable.{1}) {4}", keyColumn, columnName, groupByField, tableName, groupByCondition)

			Dim command As New OleDbCommand(query)
			command.Parameters.Add(New OleDbParameter("@PeriodStart", OleDbType.Date)).Value = start
			command.Parameters.Add(New OleDbParameter("@PeriodEnd", OleDbType.Date)).Value = [end]
			Return command
		End Function
		Private Function ExecuteQuery(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod, ByVal column As GroupColumn) As IEnumerable(Of SalesGroup)
			Dim result As IList(Of SalesGroup) = Nothing
			If connection.State <> ConnectionState.Open Then
				connection.Open()
			End If
			Dim command As OleDbCommand
			If column = GroupColumn.None Then
				command = CreateQueryBySales(start, [end], period)
			Else
				command = CreateJoinQuery(start, [end], period, column)
			End If
			command.Connection = connection
			command.Prepare()

			result = New List(Of SalesGroup)()
			Using reader = command.ExecuteReader()
				Do While reader.Read()
					Dim name As String = reader("Name").ToString()
					Dim totalCost As Decimal = 0
					Dim units As Integer = 0
					Dim startDate As Date = start
					Dim endDate As Date = [end]
					If Not(TypeOf reader("TotalCost") Is DBNull) Then
						totalCost = Convert.ToDecimal(reader("TotalCost"))
						units = Convert.ToInt32(reader("Units"))
						If reader.FieldCount > 3 Then
							startDate = GetSaleDate(reader("SaleDate").ToString(), start)
							endDate = GetEndDate(startDate, [end], period)
						End If
					End If
					result.Add(New SalesGroup(name, totalCost, units, startDate, endDate))
				Loop
			End Using
			Return result
		End Function
		Private Function GetEndDate(ByVal startDate As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As Date
			If period = GroupingPeriod.Day Then
				Return startDate.AddDays(1).AddMilliseconds(-1)
			ElseIf period = GroupingPeriod.Hour Then
				Return startDate.AddHours(1).AddMilliseconds(-1)
			End If
			Return [end]
		End Function
		#Region "IDataProvider"

		Public Function GetTotalSalesByRange(ByVal start As Date, ByVal [end] As Date) As SalesGroup Implements IDataProvider.GetTotalSalesByRange
			Dim salesGroups = ExecuteQuery(start, [end], GroupingPeriod.All, GroupColumn.None)
			If salesGroups IsNot Nothing Then
				For Each salesGroup In salesGroups
					Return salesGroup
				Next salesGroup
			End If
			Return Nothing
		End Function
		Public Function GetSales(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup) Implements IDataProvider.GetSales
			Return ExecuteQuery(start, [end], period, GroupColumn.None)
		End Function
		Public Function GetSalesByChannel(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup) Implements IDataProvider.GetSalesByChannel
			Return ExecuteQuery(start, [end], period, GroupColumn.Channel)
		End Function
		Public Function GetSalesByProduct(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup) Implements IDataProvider.GetSalesByProduct
			Return ExecuteQuery(start, [end], period, GroupColumn.Product)
		End Function
		Public Function GetSalesByRegion(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup) Implements IDataProvider.GetSalesByRegion
			Return ExecuteQuery(start, [end], period, GroupColumn.Region)
		End Function
		Public Function GetSalesBySector(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup) Implements IDataProvider.GetSalesBySector
			Return ExecuteQuery(start, [end], period, GroupColumn.Sector)
		End Function

		#End Region
		#Region "IDisposable"
		Public Sub Dispose() Implements IDisposable.Dispose
			If connection.State = ConnectionState.Open Then
				connection.Close()
			End If
			connection.Dispose()
		End Sub
		#End Region
	End Class
End Namespace
