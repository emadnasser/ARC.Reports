Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Linq
Imports System
Imports System.Collections.Generic

Namespace DashboardMainDemo
	Public Class WebsiteStatisticsDataGenerator
		Public Class WebsiteStatisticsItem
			Private count_Renamed As Integer
			Private date_Renamed As DateTime
			Private trafficSource_Renamed As String
			Private trafficSourceDetails_Renamed As String
			Private browser_Renamed As String
			Private browserDetails_Renamed As String

			Public Property Count() As Integer
				Get
					Return count_Renamed
				End Get
				Set(ByVal value As Integer)
					count_Renamed = value
				End Set
			End Property
			Public Property [Date]() As DateTime
				Get
					Return date_Renamed
				End Get
				Set(ByVal value As DateTime)
					date_Renamed = value
				End Set
			End Property
			Public Property TrafficSource() As String
				Get
					Return trafficSource_Renamed
				End Get
				Set(ByVal value As String)
					trafficSource_Renamed = value
				End Set
			End Property
			Public Property TrafficSourceDetails() As String
				Get
					Return trafficSourceDetails_Renamed
				End Get
				Set(ByVal value As String)
					trafficSourceDetails_Renamed = value
				End Set
			End Property
			Public Property Browser() As String
				Get
					Return browser_Renamed
				End Get
				Set(ByVal value As String)
					browser_Renamed = value
				End Set
			End Property
			Public Property BrowserDetails() As String
				Get
					Return browserDetails_Renamed
				End Get
				Set(ByVal value As String)
					browserDetails_Renamed = value
				End Set
			End Property
		End Class
		Private Interface IChanceInterval
			Property Chance() As Double
		End Interface
		Private Class DataPairElement
			Implements IChanceInterval
			Private data_Renamed As String
			Private dataDetails_Renamed As String
			Private chance_Renamed As Double
			Public Property Data() As String
				Get
					Return data_Renamed
				End Get
				Set(ByVal value As String)
					data_Renamed = value
				End Set
			End Property
			Public Property DataDetails() As String
				Get
					Return dataDetails_Renamed
				End Get
				Set(ByVal value As String)
					dataDetails_Renamed = value
				End Set
			End Property
			Public Property Chance() As Double
				Get
					Return chance_Renamed
				End Get
				Set(ByVal value As Double)
					chance_Renamed = value
				End Set
			End Property
			Private Property IChanceInterval_Chance() As Double Implements IChanceInterval.Chance
				Get
					Return chance_Renamed
				End Get
				Set(ByVal value As Double)
					chance_Renamed = value
				End Set
			End Property
		End Class
		Private Class UserDataElement
			Implements IChanceInterval
			Private userId_Renamed As String
			Private chance_Renamed As Double
			Public Property UserId() As String
				Get
					Return userId_Renamed
				End Get
				Set(ByVal value As String)
					userId_Renamed = value
				End Set
			End Property
			Public Property Chance() As Double
				Get
					Return chance_Renamed
				End Get
				Set(ByVal value As Double)
					chance_Renamed = value
				End Set
			End Property
			Private Property IChanceInterval_Chance() As Double Implements IChanceInterval.Chance
				Get
					Return chance_Renamed
				End Get
				Set(ByVal value As Double)
					chance_Renamed = value
				End Set
			End Property
		End Class

		Private ReadOnly rand As New Random()
		Private ReadOnly items As New List(Of WebsiteStatisticsItem)()
		Public ReadOnly Property WebsiteStatistics() As IEnumerable(Of WebsiteStatisticsItem)
			Get
				Return items
			End Get
		End Property

		Public Sub New()
			InitializeData()
		End Sub
		Private Sub InitializeData()
			Dim dataTrafficSourceList As IList(Of DataPairElement) = GetTrafficSourceData()
			Dim browsersDataList As IList(Of DataPairElement) = GetBrowserData()
			Dim usersDataList As IList(Of UserDataElement) = GetUsersData(10000)
			Dim currentDate As DateTime = DateTime.Today.AddYears(-1)
			Dim endDate As DateTime = DateTime.Today.AddDays(-1)
			Do While currentDate < endDate
				Dim monthModifier As Double = 1 + 0.03 * Math.Abs(currentDate.Month - 6)
				Dim baseCount As Integer = rand.Next(100000, 150000)
				For Each browserData As DataPairElement In browsersDataList
					For Each trafficData As DataPairElement In dataTrafficSourceList
						Dim item As New WebsiteStatisticsItem()
						item.Count = Convert.ToInt32(baseCount * (browserData.Chance / 100) * (trafficData.Chance / 100) * monthModifier)
						item.Date = currentDate
						item.TrafficSource = trafficData.Data
						item.TrafficSourceDetails = trafficData.DataDetails
						item.Browser = browserData.Data
						item.BrowserDetails = browserData.DataDetails
						items.Add(item)
					Next trafficData
				Next browserData
				currentDate = currentDate.AddMonths(1)
			Loop
		End Sub
		Private Function GetUsersData(ByVal count As Integer) As IList(Of UserDataElement)
			Dim result As IList(Of UserDataElement) = Enumerable.Range(0, count).Select(Function(i) New UserDataElement() With {.UserId = Guid.NewGuid().ToString(), .Chance = rand.Next(1, 3)}).ToList()
			InitChance(result.Cast(Of IChanceInterval)().ToList())
			Return result
		End Function
		Private Function GetBrowserData() As IList(Of DataPairElement)
			Dim result As IList(Of DataPairElement) = New List(Of DataPairElement)()
			result.Add(New DataPairElement() With {.Chance = 2.6, .Data = "IE", .DataDetails = "8"})
			result.Add(New DataPairElement() With {.Chance = 4.7, .Data = "IE", .DataDetails = "9"})
			result.Add(New DataPairElement() With {.Chance = 5.3, .Data = "IE", .DataDetails = "11"})
			result.Add(New DataPairElement() With {.Chance = 0.3, .Data = "IE", .DataDetails = "Others"})

			result.Add(New DataPairElement() With {.Chance = 38.0, .Data = "Chrome", .DataDetails = "Latest"})
			result.Add(New DataPairElement() With {.Chance = 17.3, .Data = "Chrome", .DataDetails = "Others"})

			result.Add(New DataPairElement() With {.Chance = 11.4, .Data = "Firefox", .DataDetails = "Latest"})
			result.Add(New DataPairElement() With {.Chance = 6.4, .Data = "Firefox", .DataDetails = "Others"})

			result.Add(New DataPairElement() With {.Chance = 1.7, .Data = "Safari", .DataDetails = "Others"})

			result.Add(New DataPairElement() With {.Chance = 0.7, .Data = "Opera", .DataDetails = "O Mini"})
			result.Add(New DataPairElement() With {.Chance = 3.0, .Data = "Opera", .DataDetails = "Others"})

			InitChance(result.Cast(Of IChanceInterval)().ToList())
			Return result
		End Function
		Private Function GetTrafficSourceData() As IList(Of DataPairElement)
			Dim result As IList(Of DataPairElement) = New List(Of DataPairElement)()
			result.Add(New DataPairElement() With {.Chance = 51.0, .Data = "Direct", .DataDetails = "Direct"})
			result.Add(New DataPairElement() With {.Chance = 19.0, .Data = "Referring Site", .DataDetails = "Facebook"})
			result.Add(New DataPairElement() With {.Chance = 02.0, .Data = "Referring Site", .DataDetails = "Google Ads"})
			result.Add(New DataPairElement() With {.Chance = 10.0, .Data = "Referring Site", .DataDetails = "Google+"})
			result.Add(New DataPairElement() With {.Chance = 13.3, .Data = "Referring Site", .DataDetails = "Twitter"})
			result.Add(New DataPairElement() With {.Chance = 02.3, .Data = "Referring Site", .DataDetails = "LinkedIn"})
			result.Add(New DataPairElement() With {.Chance = 03.3, .Data = "Search Engine", .DataDetails = "Bing"})
			result.Add(New DataPairElement() With {.Chance = 10.3, .Data = "Search Engine", .DataDetails = "Google"})
			result.Add(New DataPairElement() With {.Chance = 02.3, .Data = "Search Engine", .DataDetails = "Yahoo"})
			InitChance(result.Cast(Of IChanceInterval)().ToList())
			Return result
		End Function
		Private Sub InitChance(ByVal dataList As IList(Of IChanceInterval))
			Dim sum As Double = dataList.Sum(Function(d) d.Chance)
			For Each data As IChanceInterval In dataList
				data.Chance = 100 * data.Chance / sum
			Next data
		End Sub
	End Class
End Namespace
