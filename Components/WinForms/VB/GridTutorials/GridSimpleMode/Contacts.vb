Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace DevExpress.XtraGrid.Demos.Tutorials
	Public Class ContactList
		Inherits System.Collections.CollectionBase

		Public Shared Function GetContacts() As ContactList
			Dim cl As ContactList = New ContactList()
			cl.Add(Contact.ReadContact1())
			cl.Add(Contact.ReadContact2())
			cl.Add(Contact.ReadContact3())
			cl.Add(Contact.ReadContact4())
			cl.Add(Contact.ReadContact5())
			Return cl
		End Function

		Public Default Property Item(ByVal index As Integer) As Contact
			Get
				Return CType(List(index), Contact)
			End Get
			Set
				List(index) = Value
			End Set
		End Property

		Public Function Add(ByVal value As Contact) As Integer
			Return List.Add(value)
		End Function

		Public Sub Insert(ByVal index As Integer, ByVal value As Contact)
			List.Insert(index, value)
		End Sub

		Public Function IndexOf(ByVal value As Contact) As Integer
			Return List.IndexOf(value)
		End Function

		Public Function Contains(ByVal value As Contact) As Boolean
			Return List.Contains(value)
		End Function

		Public Sub Remove(ByVal value As Contact)
			List.Remove(value)
		End Sub

		Public Sub CopyTo(ByVal array As Contact(), ByVal index As Integer)
			List.CopyTo(array, index)
		End Sub
	End Class
	Public Class Contact
		Private fID As String
		Private fFirstName As String
		Private fLastName As String
		Private fCompany As String
		Private fAddress As String
		Private fCustomer As Boolean
		Private fPurchaseDate As DateTime
		Private fPaymentType As String
		Private fPaymentAmount As Double

		Friend Sub New(ByVal ID As String)
			MyBase.New()
			Me.fID = ID
		End Sub
		Public ReadOnly Property ID() As String
			Get
				Return fID
			End Get
		End Property
		Public Property FirstName() As String
			Get
				Return fFirstName
			End Get
			Set
				fFirstName = Value
			End Set
		End Property
		Public Property LastName() As String
			Get
				Return fLastName
			End Get
			Set
				fLastName = Value
			End Set
		End Property
		Public Property Company() As String
			Get
				Return fCompany
			End Get
			Set
				fCompany = Value
			End Set
		End Property
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set
				fAddress = Value
			End Set
		End Property
		Public Property Customer() As Boolean
			Get
				Return fCustomer
			End Get
			Set
				fCustomer = Value
			End Set
		End Property
		Public Property PurchaseDate() As DateTime
			Get
				Return fPurchaseDate
			End Get
			Set
				fPurchaseDate = Value
			End Set
		End Property
		Public Property PaymentType() As String
			Get
				Return fPaymentType
			End Get
			Set
				fPaymentType = Value
			End Set
		End Property
		Public Property PaymentAmount() As Double
			Get
				Return fPaymentAmount
			End Get
			Set
				fPaymentAmount = Value
			End Set
		End Property

		Friend Shared Function ReadContact1() As Contact
			Dim c As Contact = New Contact("n1")
			c.FirstName = "John"
			c.LastName = "Doe"
			c.Company = "Doe Enterprises"
			c.Address = "123 Home Lane," & Constants.vbCrLf & "Homesville," & Constants.vbCrLf & "CA," & Constants.vbCrLf & "55555"
			c.Customer = True
            c.PurchaseDate = DateTime.Parse("5/3/2003", System.Globalization.CultureInfo.InvariantCulture)
			c.PaymentType = "M"
			c.PaymentAmount = 330.99
			Return c
		End Function

		Friend Shared Function ReadContact2() As Contact
			Dim c As Contact = New Contact("n2")
			c.FirstName = "Sam"
			c.LastName = "Hill"
			c.Company = "Hill Corporation"
			c.Address = "45 Hill St.," & Constants.vbCrLf & "Hillsville," & Constants.vbCrLf & "NJ," & Constants.vbCrLf & "44444"
			c.Customer = False
            c.PurchaseDate = DateTime.Parse("5/7/2002", System.Globalization.CultureInfo.InvariantCulture)
			c.PaymentType = "A"
			c.PaymentAmount = 100.0
			Return c
		End Function

		Friend Shared Function ReadContact3() As Contact
			Dim c As Contact = New Contact("n3")
			c.FirstName = "Karen"
			c.LastName = "Holmes"
			c.Company = "Holmes World"
			c.Address = "933 Holmes Dr.," & Constants.vbCrLf & "Johnsonville," & Constants.vbCrLf & "NY," & Constants.vbCrLf & "33333"
			c.Customer = True
            c.PurchaseDate = DateTime.Parse("7/11/2001", System.Globalization.CultureInfo.InvariantCulture)
			c.PaymentType = "C"
			c.PaymentAmount = 230.50
			Return c
		End Function

		Friend Shared Function ReadContact4() As Contact
			Dim c As Contact = New Contact("n4")
			c.FirstName = "Bobbie"
			c.LastName = "Valentine"
			c.Company = "Valentine Hearts"
			c.Address = "533 Heart St.Suite," & Constants.vbCrLf & "Chicago," & Constants.vbCrLf & "IL," & Constants.vbCrLf & "89123"
			c.Customer = True
            c.PurchaseDate = DateTime.Parse("6/1/2004", System.Globalization.CultureInfo.InvariantCulture)
			c.PaymentType = "V"
			c.PaymentAmount = 550.1
			Return c
		End Function

		Friend Shared Function ReadContact5() As Contact
			Dim c As Contact = New Contact("n5")
			c.FirstName = "Frank"
			c.LastName = "Frankson"
			c.Company = "Frankson Media"
			c.Address = "121 Media Center Dri," & Constants.vbCrLf & "New York," & Constants.vbCrLf & "NY," & Constants.vbCrLf & "12121"
			c.Customer = False
            c.PurchaseDate = DateTime.Parse("2/2/2003", System.Globalization.CultureInfo.InvariantCulture)
			c.PaymentType = "A"
			c.PaymentAmount = 50.0
			Return c
		End Function
	End Class
End Namespace
