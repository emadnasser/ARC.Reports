Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	'<vGridControl1>
	Public Class Contacts
		Inherits ArrayList
		Public Sub New()
            Me.Add(New Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", True, DateTime.Parse("12/02/2003", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "Visa", 199.99, DateTime.Now))
            Me.Add(New Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", False, DateTime.Parse("11/11/2004", System.Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AmExpress", 78.25, DateTime.Now))
            Me.Add(New Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", True, DateTime.Parse("01/01/2004", System.Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "Visa", 1299, DateTime.Now))
            Me.Add(New Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", True, DateTime.Parse("10/07/2004", System.Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "Master", 354.12, DateTime.Now))
            Me.Add(New Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", False, DateTime.Parse("09/08/2003", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "Cash", 9.99, DateTime.Now))
            Me.Add(New Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", True, DateTime.Parse("06/04/2003", System.Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "Visa", 520, DateTime.Now))
		End Sub
	End Class
	'</vGridControl1>
	Public Class Contact
		Private clientID_Renamed As Integer
		Private firstName_Renamed As String
		Private lastName_Renamed As String
		Private companyName_Renamed As String
		Private address_Renamed As String
		Private city_Renamed As String
		Private state_Renamed As String
		Private zipCode_Renamed As String
		Private phone_Renamed As String
		Private customer_Renamed As Boolean
		Private dateOpen_Renamed As DateTime
		Private occupation_Renamed As String
		Private riskLevel_Renamed As Integer
		Private interest_Renamed As String
		Private gender_Renamed As String
		Private paymentType_Renamed As String
		Private paymentAmount_Renamed As Double
		Private paymentDate_Renamed As DateTime

		Public Sub New(ByVal clientID_Renamed As Integer, ByVal firstName_Renamed As String, ByVal lastName_Renamed As String, ByVal companyName_Renamed As String, ByVal address_Renamed As String, ByVal city_Renamed As String, ByVal state_Renamed As String, ByVal zipCode_Renamed As String, ByVal phone_Renamed As String, ByVal customer_Renamed As Boolean, ByVal dateOpen_Renamed As DateTime, ByVal occupation_Renamed As String, ByVal riskLevel_Renamed As Integer, ByVal interest_Renamed As String, ByVal gender_Renamed As String, ByVal paymentType_Renamed As String, ByVal paymentAmount_Renamed As Double, ByVal paymentDate_Renamed As DateTime)
			Me.clientID_Renamed = clientID_Renamed
			Me.firstName_Renamed = firstName_Renamed
			Me.lastName_Renamed = lastName_Renamed
			Me.companyName_Renamed = companyName_Renamed
			Me.address_Renamed = address_Renamed
			Me.city_Renamed = city_Renamed
			Me.state_Renamed = state_Renamed
			Me.zipCode_Renamed = zipCode_Renamed
			Me.phone_Renamed = phone_Renamed
			Me.customer_Renamed = customer_Renamed
			Me.dateOpen_Renamed = dateOpen_Renamed
			Me.occupation_Renamed = occupation_Renamed
			Me.riskLevel_Renamed = riskLevel_Renamed
			Me.interest_Renamed = interest_Renamed
			Me.gender_Renamed = gender_Renamed
			Me.paymentType_Renamed = paymentType_Renamed
			Me.paymentAmount_Renamed = paymentAmount_Renamed
			Me.paymentDate_Renamed = paymentDate_Renamed
		End Sub

		Public ReadOnly Property ClientID() As Integer
			Get
				Return clientID_Renamed
			End Get
		End Property
		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set
				firstName_Renamed = Value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set
				lastName_Renamed = Value
			End Set
		End Property
		Public Property CompanyName() As String
			Get
				Return companyName_Renamed
			End Get
			Set
				companyName_Renamed = Value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set
				address_Renamed = Value
			End Set
		End Property
		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set
				city_Renamed = Value
			End Set
		End Property
		Public Property State() As String
			Get
				Return state_Renamed
			End Get
			Set
				state_Renamed = Value
			End Set
		End Property
		Public Property ZipCode() As String
			Get
				Return zipCode_Renamed
			End Get
			Set
				zipCode_Renamed = Value
			End Set
		End Property
		Public Property Phone() As String
			Get
				Return phone_Renamed
			End Get
			Set
				phone_Renamed = Value
			End Set
		End Property
		Public Property Customer() As Boolean
			Get
				Return customer_Renamed
			End Get
			Set
				customer_Renamed = Value
			End Set
		End Property
		Public Property DateOpen() As DateTime
			Get
				Return dateOpen_Renamed
			End Get
			Set
				dateOpen_Renamed = Value
			End Set
		End Property
		Public Property Occupation() As String
			Get
				Return occupation_Renamed
			End Get
			Set
				occupation_Renamed = Value
			End Set
		End Property
		Public Property RiskLevel() As Integer
			Get
				Return riskLevel_Renamed
			End Get
			Set
				riskLevel_Renamed = Value
			End Set
		End Property
		Public Property Interest() As String
			Get
				Return interest_Renamed
			End Get
			Set
				interest_Renamed = Value
			End Set
		End Property
		Public Property Gender() As String
			Get
				Return gender_Renamed
			End Get
			Set
				gender_Renamed = Value
			End Set
		End Property
		Public Property PaymentType() As String
			Get
				Return paymentType_Renamed
			End Get
			Set
				paymentType_Renamed = Value
			End Set
		End Property
		Public Property PaymentAmount() As Double
			Get
				Return paymentAmount_Renamed
			End Get
			Set
				paymentAmount_Renamed = Value
			End Set
		End Property
		Public Property PaymentDate() As DateTime
			Get
				Return paymentDate_Renamed
			End Get
			Set
				paymentDate_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
