Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace DashboardMainDemo
	Public Class SalesOverviewDataGenerator
		Inherits SalesDataGenerator
		Public Class DataItem
			Private sTarget As Decimal
			Private sal As Decimal
			Private curtDate As DateTime
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
			Public Property CurrentDate() As DateTime
				Get
					Return curtDate
				End Get
				Set(ByVal value As DateTime)
					curtDate = value
				End Set
			End Property
			Public Property Sales() As Decimal
				Get
					Return sal
				End Get
				Set(ByVal value As Decimal)
					sal = value
				End Set
			End Property
			Public Property SalesTarget() As Decimal
				Get
					Return sTarget
				End Get
				Set(ByVal value As Decimal)
					sTarget = value
				End Set
			End Property
		End Class

		Public Class DataKey
			Private ReadOnly state As String
			Private ReadOnly category As String
			Private ReadOnly dt As DateTime

			Public Sub New(ByVal state As String, ByVal category As String, ByVal dt As DateTime)
				Me.state = state
				Me.category = category
				Me.dt = dt
			End Sub
			Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
				Dim key As DataKey = CType(obj, DataKey)
				Return key.state = state AndAlso key.category = category AndAlso key.dt = dt
			End Function
			Public Overrides Function GetHashCode() As Integer
				Return state.GetHashCode() Xor category.GetHashCode() Xor dt.GetHashCode()
			End Function
		End Class

		Private ReadOnly dat As New Dictionary(Of DataKey, DataItem)()
		Private ReadOnly startDate As DateTime
		Private ReadOnly endDate As DateTime

		Public ReadOnly Property Data() As IEnumerable(Of DataItem)
			Get
				Return dat.Values
			End Get
		End Property

		Public Sub New(ByVal dataSet As DataSet)
			MyBase.New(dataSet)
			endDate = DateTime.Today
			startDate = New DateTime(endDate.Year - 2, 1, 1)
		End Sub
		Protected Overrides Sub Generate(ByVal context As Context)
			Dim dt As DateTime = startDate
			Do While dt < endDate
				If dt.DayOfWeek = DayOfWeek.Monday Then
					context.UnitsSoldGenerator.Next()
					Dim sales As Decimal = context.UnitsSoldGenerator.UnitsSold * context.ListPrice
					Dim salesTarget As Decimal = context.UnitsSoldGenerator.UnitsSoldTarget * context.ListPrice
					Dim datKey As New DataKey(context.State, context.CategoryName, dt)
					Dim datItem As DataItem = Nothing
					If (Not dat.TryGetValue(datKey, datItem)) Then
						datItem = New DataItem With {.CurrentDate = dt, .Category = context.CategoryName, .State = context.State}
						dat.Add(datKey, datItem)
					End If
					datItem.Sales += sales
					datItem.SalesTarget += salesTarget
				End If
				dt = dt.AddDays(1)
			Loop
		End Sub
	End Class
End Namespace
