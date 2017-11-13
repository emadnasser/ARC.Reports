Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Office
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.Web.Demos
	Public Class Shipment
		Public Const DefaultEmptyValueString As String = "n/a"

		Public Property Id() As String
		Public Property Sender() As String
		Public Property Recipient() As String
		Public Property Weight() As Double
		Public Property ShippingDate() As DateTime
		Public Property DeliveryDate() As DateTime

		Public Sub New()
			Id = String.Empty
			Sender = DefaultEmptyValueString
			Recipient = DefaultEmptyValueString
		End Sub
		Public Sub New(ByVal id As String, ByVal sender As String, ByVal recipient As String, ByVal weight As Double, ByVal shippingDate As DateTime, ByVal deliveryDate As DateTime)
			Id = id
			Sender = sender
			Recipient = recipient
			Weight = weight
			ShippingDate = shippingDate
			DeliveryDate = deliveryDate
		End Sub
		Private Function IsEmpty() As Boolean
			Return String.IsNullOrEmpty(Id)
		End Function
		Public Function GetShipmentWeight() As String
			If IsEmpty() Then
				Return DefaultEmptyValueString
			End If
			Return String.Format("{0} lbs ({1} kg)", Weight.ToString("0.00"), (0.45359237 * Weight).ToString("0.00"))
		End Function
		Private Function FormatDate(ByVal [date] As DateTime) As String
			If IsEmpty() Then
				Return DefaultEmptyValueString
			Else
				Return [date].ToShortDateString()
			End If
		End Function
		Public Function GetShippingDate() As String
			Return FormatDate(ShippingDate)
		End Function
		Public Function GetDeliveryDate() As String
			Return FormatDate(DeliveryDate)
		End Function
	End Class
	Public NotInheritable Class SampleDataSource
		Private Shared data_Renamed As List(Of Shipment)
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Data() As List(Of Shipment)
			Get
				If data_Renamed Is Nothing Then
					data_Renamed = GenerateSampleData()
				End If
				Return data_Renamed
			End Get
		End Property

		Private Shared Function GenerateSampleData() As List(Of Shipment)
			data_Renamed = New List(Of Shipment)()
			data_Renamed.Add(New Shipment("P101406", "Quebec, CA", "Baltimore, MD, US", 6.8, New DateTime(2016, 10, 4), New DateTime(2016, 10, 13)))
			data_Renamed.Add(New Shipment("P101201", "New Orleans, LA, US", "Los Angeles, CA, US", 2.3, New DateTime(2016, 10, 1), New DateTime(2016, 10, 3)))
			data_Renamed.Add(New Shipment("P121203", "Pittsburgh, PA, US", "Edmonton, CA", 0.8, New DateTime(2016, 10, 8), New DateTime(2016, 10, 15)))
			data_Renamed.Add(New Shipment("P207524", "Dallas, TX, US", "Barselona, ES", 5.1, New DateTime(2016, 10, 10), New DateTime(2016, 10, 23)))
			data_Renamed.Add(New Shipment("P301189", "Rome, IT", "Los Angeles, CA, US", 4.5, New DateTime(2016, 10, 14), New DateTime(2016, 11, 1)))
			data_Renamed.Add(New Shipment("P526101", "Ljubljana, SI", "Omaha, NE, US", 3.3, New DateTime(2016, 10, 18), New DateTime(2016, 11, 13)))

			Return data_Renamed
		End Function

		Public Shared Function Lookup(ByVal key As String) As Shipment
			Dim shipment As Shipment = Data.Find(Function(p) p.Id = key)
			If shipment Is Nothing Then
				shipment = New Shipment()
			End If
			Return shipment
		End Function
	End Class
End Namespace
