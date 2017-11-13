Imports System.Data.OleDb

Namespace DevExpress.Demos.SalesDBGenerator
	Public Class SalesGenerator
		Implements DevExpress.SalesDemo.Model.IDataGenerator

		Private currentDate As Date = Date.Today.AddDays(40)
		Private minRequiredDate As New Date(2012, 1, 1)
		Private maxId As Integer = 0
		Public Function Run(ByVal connectionString As String) As Boolean
			Using connection = New OleDbConnection(connectionString)
				connection.Open()
				'new OleDbCommand("delete * from sales", connection).ExecuteNonQuery(); //FOR TEST PURPOSES
				Dim helper = New SqlHelper(Of OleDbConnection, OleDbCommand)()
				Dim minDate As Date = helper.GetDate(helper.ReadValue(connection, "select min(sale_date) from sales"))
				Dim maxDate As Date = helper.GetDate(helper.ReadValue(connection, "select max(sale_date) from sales"))
				Me.maxId = helper.GetInt(helper.ReadValue(connection, "select max(id) from sales"))
				Dim startDate As Date = minRequiredDate
				If minDate > startDate AndAlso maxDate <> Date.MinValue Then
					startDate = maxDate.AddDays(1)
				End If
				If startDate > Date.Today.AddDays(2) Then
					Return True
				End If
				Dim daysCount As Integer = CInt(Fix(currentDate.Subtract(startDate).TotalDays))
				RaiseStart()
				Try
					Generate(connection, startDate, daysCount)
				Finally
					RaiseComplete()
				End Try
				connection.Close()
			End Using
			Return True
		End Function
		Private random As New Random(100)
		Private Sub Generate(ByVal connection As OleDbConnection, ByVal startDate As Date, ByVal daysCount As Integer)
			Using transaction = connection.BeginTransaction()
				For n As Integer = 0 To daysCount - 1
					Console.Write("{0} of {1}" & vbCr, n + 1, daysCount)
					GenerateDay(connection, transaction, n, startDate.AddDays(n))
					RaiseProgress(CDbl(n) / CDbl(daysCount))
				Next n
				transaction.Commit()
			End Using
		End Sub
		Private timeInterval As Integer = 15
		Private startTime As Integer = 8
		Private endTime As Integer = 17
		Private dailySalesGrowth As Double = 0.007R
		Private Sub GenerateDay(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal n As Integer, ByVal day As Date)
			Dim salesPerDay As Integer = random.Next(180, CInt(Fix(200 * (1 + (day.Subtract(minRequiredDate).TotalDays * dailySalesGrowth) / 10))))
			Dim generateIntervals() As Integer = GenerateTimeIntervals(salesPerDay)
			Dim start As New Date(day.Year, day.Month, day.Day, startTime, 0, 0)
			For d As Integer = 0 To generateIntervals.Length - 1
				For x As Integer = 0 To generateIntervals(d) - 1
					GenerateSale(connection, transaction, start)
				Next x
				start = start.AddMinutes(timeInterval)
			Next d
		End Sub
		Private Sub GenerateSale(ByVal connection As OleDbConnection, ByVal transaction As OleDbTransaction, ByVal [date] As Date)
			Dim id As Integer = GetId()
			Dim region As Integer = regions(rndRegions(random.Next(0, rndRegions.Length))).Id
			Dim channel As Integer = channels(rndChannels(random.Next(0, rndChannels.Length))).Id
			Dim sector As Integer = sectors(rndSectors(random.Next(0, rndSectors.Length))).Id
			Dim product As Product = products(rndProducts(random.Next(0, rndProducts.Length)))
			Dim productPrice As Integer = product.Price
			Dim discount As Integer = rndDiscounts(random.Next(0, rndDiscounts.Length))
			Dim units As Integer = rndUnits(random.Next(0, rndUnits.Length))
			Dim totalPrice As Integer = (productPrice * units) - discount
			Dim helper As New SqlHelper(Of OleDbConnection, OleDbCommand)()
			helper.Execute(connection, transaction, "insert into sales (id, units, cost_per_unit, discount, total_cost, sale_date, productId, RegionId, ChannelId, SectorId) " & "values (@id, @units, @cost_per_unit, @discount, @total_cost, @sale_date, @productId, @RegionId, @ChannelId, @SectorId)", New OleDbParameter("@id", id), New OleDbParameter("@units", units), New OleDbParameter("@cost_per_unit", productPrice), New OleDbParameter("@discount", discount), New OleDbParameter("@total_cost", totalPrice), New OleDbParameter("@sale_date", [date]), New OleDbParameter("@productId", product.Id), New OleDbParameter("@RegionId", region), New OleDbParameter("@ChannelId", channel), New OleDbParameter("@SectorId", sector))
		End Sub
		Private Function GetId() As Integer
			maxId += 1
			Return maxId
		End Function
		Private Function GenerateTimeIntervals(ByVal salesPerDay As Integer) As Integer()
			Dim count As Integer = ((endTime) - startTime) * (60 \ timeInterval)
			Dim res(count) As Integer
			Dim salesPerInterval As Integer = salesPerDay \ res.Length
			Dim n As Integer = 10
			Do
				Dim num As Integer = random.Next(salesPerInterval - CInt(Fix(salesPerInterval * 0.8)), salesPerInterval + CInt(Fix(salesPerInterval * 0.3)))
				If num > salesPerDay Then
					num = salesPerDay
				End If
				salesPerDay -= num
				res(n) += num
				If num < 1 Then
					Exit Do
				End If
				If n >= res.Length - 1 Then
					n = 0
				End If
				n += 1
			Loop
			Return res
		End Function
		#Region "Progress"
		Public Event Start As SalesDemo.Model.ProgressEventHandler Implements DevExpress.SalesDemo.Model.IDataGenerator.Start
		Public Event Progress As SalesDemo.Model.ProgressEventHandler Implements DevExpress.SalesDemo.Model.IDataGenerator.Progress
		Public Event Complete As SalesDemo.Model.ProgressEventHandler Implements DevExpress.SalesDemo.Model.IDataGenerator.Complete
		Private Sub RaiseStart()
			RaiseEvent Start(Me, New SalesDemo.Model.ProgressEventArgs(0))
		End Sub
		Private Sub RaiseProgress(ByVal progress As Double)
			RaiseEvent Progress(Me, New SalesDemo.Model.ProgressEventArgs(CInt(Fix(100.0 * progress))))
		End Sub
		Private Sub RaiseComplete()
			RaiseEvent Complete(Me, New SalesDemo.Model.ProgressEventArgs(100))
		End Sub
		#End Region ' Progress
		#Region "Sample Data"
		Private rndDiscounts() As Integer = { 100, 200, 300, 400, 500, 600, 700, 800 }
		Private rndUnits() As Integer = { 1, 1, 2, 2, 3, 4 }
		Private rndRegions() As Integer = { 0, 0, 0, 0, 0, 1, 2, 2, 2, 3, 3, 4 }
		Private rndChannels() As Integer = { 0, 0, 0, 0, 1, 2, 3, 3, 4, 4 }
		Private rndSectors() As Integer = { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 5, 5, 5 }
		Private rndProducts() As Integer = { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 5, 5 }

		Private products() As Product = { New Product() With {.Id = 1, .Name = "Eco Max", .Price = 2500}, New Product() With {.Id = 2, .Name = "Eco Supreme", .Price = 2000}, New Product() With {.Id = 3, .Name = "EnviroCare", .Price = 1750}, New Product() With {.Id = 4, .Name = "EnviroCare Max", .Price = 2800}, New Product() With {.Id = 5, .Name = "SolarOne", .Price = 1500}, New Product() With {.Id = 6, .Name = "SolarMax", .Price = 2250} }
		Private regions() As Region = { New Region() With {.Id = 1, .Name = "North America"}, New Region() With {.Id = 2, .Name = "South America"}, New Region() With {.Id = 3, .Name = "Europe"}, New Region() With {.Id = 4, .Name = "Asia"}, New Region() With {.Id = 5, .Name = "Australia"} }
		Private channels() As Channel = { New Channel() With {.Id = 1, .Name = "Direct"}, New Channel() With {.Id = 2, .Name = "VARs"}, New Channel() With {.Id = 3, .Name = "Consultants"}, New Channel() With {.Id = 4, .Name = "Resellers"}, New Channel() With {.Id = 5, .Name = "Retail"} }
		Private sectors() As Sector = { New Sector() With {.Id = 1, .Name = "Energy"}, New Sector() With {.Id = 2, .Name = "Manufacturing"}, New Sector() With {.Id = 3, .Name = "Telecom"}, New Sector() With {.Id = 4, .Name = "Insurance"}, New Sector() With {.Id = 5, .Name = "Banking"}, New Sector() With {.Id = 6, .Name = "Health"} }
		#End Region ' Sample Data
	End Class
	Public Class Product
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privatePrice As Integer
		Public Property Price() As Integer
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Integer)
				privatePrice = value
			End Set
		End Property
		Private privateDiscount As Integer
		Public Property Discount() As Integer
			Get
				Return privateDiscount
			End Get
			Set(ByVal value As Integer)
				privateDiscount = value
			End Set
		End Property
	End Class
	Public Class Region
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
	Public Class Channel
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
	Public Class Sector
		Private privateId As Integer
		Public Property Id() As Integer
			Get
				Return privateId
			End Get
			Set(ByVal value As Integer)
				privateId = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace
