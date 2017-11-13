Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections.Generic

Namespace DashboardMainDemo
	Public Class SalesDetailsDataGenerator
		Inherits SalesDataGenerator
		Public Class DataItem
			Private retTarget As Integer
			Private ret As Integer
			Private uSoldTarget As Integer
			Private uSold As Integer
			Private uReceived As Integer
			Private revTarget As Decimal
			Private rev As Decimal
			Private curtDate As DateTime
			Private prod As String
			Private cat As String
			Public Property State() As String
			Public Property Category() As String
				Get
					Return cat
				End Get
				Set(ByVal value As String)
					cat = value
				End Set
			End Property
			Public Property Product() As String
				Get
					Return prod
				End Get
				Set(ByVal value As String)
					prod = value
				End Set
			End Property
			Public Property CurrentDate() As DateTime
				Get
					Return curtDate
				End Get
				Set(ByVal value As DateTime)
					curtDate = value
				End Set
			End Property
			Public Property Revenue() As Decimal
				Get
					Return rev
				End Get
				Set(ByVal value As Decimal)
					rev = value
				End Set
			End Property
			Public Property RevenueTarget() As Decimal
				Get
					Return revTarget
				End Get
				Set(ByVal value As Decimal)
					revTarget = value
				End Set
			End Property
			Public Property UnitsSold() As Integer
				Get
					Return uSold
				End Get
				Set(ByVal value As Integer)
					uSold = value
				End Set
			End Property
			Public Property UnitsSoldTarget() As Integer
				Get
					Return uSoldTarget
				End Get
				Set(ByVal value As Integer)
					uSoldTarget = value
				End Set
			End Property
			Public Property Returns() As Integer
				Get
					Return ret
				End Get
				Set(ByVal value As Integer)
					ret = value
				End Set
			End Property
			Public Property ReturnsTarget() As Integer
				Get
					Return retTarget
				End Get
				Set(ByVal value As Integer)
					retTarget = value
				End Set
			End Property
			Public Property UnitsReceived() As Integer
				Get
					Return uReceived
				End Get
				Set(ByVal value As Integer)
					uReceived = value
				End Set
			End Property
		End Class

		Private ReadOnly dat As New List(Of DataItem)()

		Public ReadOnly Property Data() As IEnumerable(Of DataItem)
			Get
				Return dat
			End Get
		End Property

		Public Sub New(ByVal dataSet As DataSet)
			MyBase.New(dataSet)
		End Sub
		Protected Overrides Sub Generate(ByVal context As Context)
			Dim rand As Random = Random
			Dim year As Integer = DateTime.Today.Year - 1
			For month As Integer = 1 To 12
				Dim _date As New DateTime(year, month, 1)
				context.UnitsSoldGenerator.Next()
				Dim uSold As Integer = context.UnitsSoldGenerator.UnitsSold
				Dim uSoldTarget As Integer = context.UnitsSoldGenerator.UnitsSoldTarget
				Dim ret As Integer = CInt(Fix(Math.Round(uSold * rand.NextDouble() * 0.5)))
				Dim retTarget As Integer = CInt(Fix(Math.Round(uSoldTarget * 0.25)))
				Dim uReceived As Integer = uSold + rand.Next(-2, 3)
				Dim rev As Decimal = (uSold - ret) * context.ListPrice
				Dim revTarget As Decimal = (uSoldTarget - retTarget) * context.ListPrice
				dat.Add(New DataItem With {.State = context.State, .Category = context.CategoryName, .Product = context.ProductName, .CurrentDate = _date, .UnitsSold = uSold, .UnitsSoldTarget = uSoldTarget, .Returns = ret, .ReturnsTarget = retTarget, .Revenue = rev, .RevenueTarget = revTarget, .UnitsReceived = uReceived})
			Next month
		End Sub
	End Class
End Namespace
