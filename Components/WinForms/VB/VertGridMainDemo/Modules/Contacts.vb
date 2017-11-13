Imports System.Collections

Namespace DevExpress.XtraVerticalGrid.Demos
	Public Class Contacts
		Inherits ArrayList

		Public Sub New()
            Me.Add(New Contact(1, "John", "Doe", "Doe Enterprises", "123 Home Lane", "Homesville", "CA", "74561", "(555)956-15-47", True, Date.Parse("12/02/2001", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 1, "Enjoys horseback riding and paints.", "M", "VS", 199.99, Date.Now, 0, 4))
            Me.Add(New Contact(2, "Karen", "Holmes", "Holmes World", "933 Heart St. Suite ", "Chicago", "IL", "55561", "(555)342-25-74", False, Date.Parse("11/11/2002", System.Globalization.CultureInfo.InvariantCulture), "Doctor", 2, "Has five children. Loves to travel.", "F", "AM", 78.25, Date.Now, 1, 4))
            Me.Add(New Contact(3, "Frank", "Frankson", "Frankson Media", "349 Graphic Design L", "Newman", "OK", "12458", "(555)155-05-02", True, Date.Parse("01/01/2002", System.Globalization.CultureInfo.InvariantCulture), "Retired", 0, "Retired. Enjoys travel and bungee jumping.", "M", "VS", 1299, Date.Now, 0, 9))
            Me.Add(New Contact(4, "Leticia", "Ford", "Ford Consulting", "93900 Carter Lane", "Cartersville", "GA", "19564", "(555)776-15-66", True, Date.Parse("10/07/2002", System.Globalization.CultureInfo.InvariantCulture), "Engineer", 1, "none", "F", "MS", 354.12, Date.Now, 2, 3))
            Me.Add(New Contact(5, "Henry", "McAllister", "McAllister Systems", "436 1st Ave.", "Cleveland", "OH", "99523", "(555)941-24-32", False, Date.Parse("09/08/2002", System.Globalization.CultureInfo.InvariantCulture), "Programmer", 0, "Enjoys fishing, skiing, and skydiving.", "M", "CS", 9.99, Date.Now, 3, 1))
            Me.Add(New Contact(6, "Roger", "Michelson", "Michelson Systems", "3920 Michelson Dr.", "Bridgeford", "CT", "74123", "(555)954-51-88", True, Date.Parse("06/04/2001", System.Globalization.CultureInfo.InvariantCulture), "Special agent", 2, "Archery, windsurfing and food.", "M", "VS", 520, Date.Now, 4, 2))
		End Sub
	End Class
	Public Class Products
		Inherits ArrayList

		Public Sub New()
			Me.Add(New Product(0, "XtraGrid", "The first and most comprehensive 100% native grid control suite for Visual Studio .NET!"))
			Me.Add(New Product(1, "XtraEditors", "Like the XtraGrid, the XtraEditors Library is the first comprehensive suite of individual field editors - written from groud-up using the C# programming language."))
			Me.Add(New Product(2, "XtraBars", "The XtraBars is our 100% native .NET component library which fully emulates the menu/toolbar and sidebar navigation systems introduced in MS Office(c) XP and the .NET IDE."))
			Me.Add(New Product(3, "XtraTreeList", "The XtraTreeList Suite is our 100% native .NET component library which allows you to break passed the traditional limits of treeview controls and represent information - be it in bound or unbound mode - to your end users in an intuitive TreeList metaphor."))
			Me.Add(New Product(4, "XtraPrinting", "The XtraPrinting Library is the perfect support library for those using the XtraGrid and XtraTreeList Suite."))
			Me.Add(New Product(5, "XtraNavBar", "Bring the User Interface of Windows XP - MS Office - and Visual Studio .NET to your applications with the most advanced navigation bar available for .NET."))
			Me.Add(New Product(6, "ASPxGrid", "An ultra-advanced Outlook(c) style WebForms Grid control engineered specifically for ASP.NET."))
		End Sub
	End Class
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
		Private dateOpen_Renamed As Date
		Private occupation_Renamed As String
		Private riskLevel_Renamed As Integer
		Private interest_Renamed As String
		Private gender_Renamed As String
		Private paymentType_Renamed As String
		Private paymentAmount_Renamed As Double
		Private paymentDate_Renamed As Date
		Private productID_Renamed As Integer
		Private copies_Renamed As Integer

		Public Sub New(ByVal clientID As Integer, ByVal firstName As String, ByVal lastName As String, ByVal companyName As String, ByVal address As String, ByVal city As String, ByVal state As String, ByVal zipCode As String, ByVal phone As String, ByVal customer As Boolean, ByVal dateOpen As Date, ByVal occupation As String, ByVal riskLevel As Integer, ByVal interest As String, ByVal gender As String, ByVal paymentType As String, ByVal paymentAmount As Double, ByVal paymentDate As Date, ByVal productID As Integer, ByVal copies As Integer)
			Me.clientID_Renamed = clientID
			Me.firstName_Renamed = firstName
			Me.lastName_Renamed = lastName
			Me.companyName_Renamed = companyName
			Me.address_Renamed = address
			Me.city_Renamed = city
			Me.state_Renamed = state
			Me.zipCode_Renamed = zipCode
			Me.phone_Renamed = phone
			Me.customer_Renamed = customer
			Me.dateOpen_Renamed = dateOpen
			Me.occupation_Renamed = occupation
			Me.riskLevel_Renamed = riskLevel
			Me.interest_Renamed = interest
			Me.gender_Renamed = gender
			Me.paymentType_Renamed = paymentType
			Me.paymentAmount_Renamed = paymentAmount
			Me.paymentDate_Renamed = paymentDate
			Me.productID_Renamed = productID
			Me.copies_Renamed = copies
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
			Set(ByVal value As String)
				firstName_Renamed = value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				lastName_Renamed = value
			End Set
		End Property
		Public Property CompanyName() As String
			Get
				Return companyName_Renamed
			End Get
			Set(ByVal value As String)
				companyName_Renamed = value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set(ByVal value As String)
				address_Renamed = value
			End Set
		End Property
		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set(ByVal value As String)
				city_Renamed = value
			End Set
		End Property
		Public Property State() As String
			Get
				Return state_Renamed
			End Get
			Set(ByVal value As String)
				state_Renamed = value
			End Set
		End Property
		Public Property ZipCode() As String
			Get
				Return zipCode_Renamed
			End Get
			Set(ByVal value As String)
				zipCode_Renamed = value
			End Set
		End Property
		Public Property Phone() As String
			Get
				Return phone_Renamed
			End Get
			Set(ByVal value As String)
				phone_Renamed = value
			End Set
		End Property
		Public Property Customer() As Boolean
			Get
				Return customer_Renamed
			End Get
			Set(ByVal value As Boolean)
				customer_Renamed = value
			End Set
		End Property
		Public Property DateOpen() As Date
			Get
				Return dateOpen_Renamed
			End Get
			Set(ByVal value As Date)
				dateOpen_Renamed = value
			End Set
		End Property
		Public Property Occupation() As String
			Get
				Return occupation_Renamed
			End Get
			Set(ByVal value As String)
				occupation_Renamed = value
			End Set
		End Property
		Public Property RiskLevel() As Integer
			Get
				Return riskLevel_Renamed
			End Get
			Set(ByVal value As Integer)
				riskLevel_Renamed = value
			End Set
		End Property
		Public Property Interest() As String
			Get
				Return interest_Renamed
			End Get
			Set(ByVal value As String)
				interest_Renamed = value
			End Set
		End Property
		Public Property Gender() As String
			Get
				Return gender_Renamed
			End Get
			Set(ByVal value As String)
				gender_Renamed = value
			End Set
		End Property
		Public Property PaymentType() As String
			Get
				Return paymentType_Renamed
			End Get
			Set(ByVal value As String)
				paymentType_Renamed = value
			End Set
		End Property
		Public Property PaymentAmount() As Double
			Get
				Return paymentAmount_Renamed
			End Get
			Set(ByVal value As Double)
				paymentAmount_Renamed = value
			End Set
		End Property
		Public Property PaymentDate() As Date
			Get
				Return paymentDate_Renamed
			End Get
			Set(ByVal value As Date)
				paymentDate_Renamed = value
			End Set
		End Property
		Public Property ProductID() As Integer
			Get
				Return productID_Renamed
			End Get
			Set(ByVal value As Integer)
				productID_Renamed = value
			End Set
		End Property
		Public Property Copies() As Integer
			Get
				Return copies_Renamed
			End Get
			Set(ByVal value As Integer)
				copies_Renamed = value
			End Set
		End Property
	End Class
	Public Class Product
		Private id_Renamed As Integer
		Private name_Renamed As String
		Private description_Renamed As String
		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal description As String)
			Me.id_Renamed = id
			Me.name_Renamed = name
			Me.description_Renamed = description
		End Sub
		Public ReadOnly Property ID() As Integer
			Get
				Return id_Renamed
			End Get
		End Property
		Public ReadOnly Property Name() As String
			Get
				Return name_Renamed
			End Get
		End Property
		Public ReadOnly Property Description() As String
			Get
				Return description_Renamed
			End Get
		End Property
	End Class
End Namespace
