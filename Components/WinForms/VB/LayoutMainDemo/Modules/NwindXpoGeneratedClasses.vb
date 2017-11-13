Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace DevExpress.XtraLayout.Demos.DBObjects

	Public Class Employees
		Inherits XPLiteObject
		Private fAddress As String
		<Size(60)> _
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set
				SetPropertyValue(Of String)("Address", fAddress, Value)
			End Set
		End Property
		Private fBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return fBirthDate
			End Get
			Set
				SetPropertyValue(Of DateTime)("BirthDate", fBirthDate, Value)
			End Set
		End Property
		Private fCity As String
		<Size(15)> _
		Public Property City() As String
			Get
				Return fCity
			End Get
			Set
				SetPropertyValue(Of String)("City", fCity, Value)
			End Set
		End Property
		Private fCountry As String
		<Size(15)> _
		Public Property Country() As String
			Get
				Return fCountry
			End Get
			Set
				SetPropertyValue(Of String)("Country", fCountry, Value)
			End Set
		End Property
		Private fEmployeeID As Integer
		<Key(True)> _
		Public Property EmployeeID() As Integer
			Get
				Return fEmployeeID
			End Get
			Set
				SetPropertyValue(Of Integer)("EmployeeID", fEmployeeID, Value)
			End Set
		End Property
		Private fExtension As String
		<Size(4)> _
		Public Property Extension() As String
			Get
				Return fExtension
			End Get
			Set
				SetPropertyValue(Of String)("Extension", fExtension, Value)
			End Set
		End Property
		Private fFirstName As String
		<Size(10)> _
		Public Property FirstName() As String
			Get
				Return fFirstName
			End Get
			Set
				SetPropertyValue(Of String)("FirstName", fFirstName, Value)
			End Set
		End Property
		Private fHireDate As DateTime
		Public Property HireDate() As DateTime
			Get
				Return fHireDate
			End Get
			Set
				SetPropertyValue(Of DateTime)("HireDate", fHireDate, Value)
			End Set
		End Property
		Private fHomePhone As String
		<Size(24)> _
		Public Property HomePhone() As String
			Get
				Return fHomePhone
			End Get
			Set
				SetPropertyValue(Of String)("HomePhone", fHomePhone, Value)
			End Set
		End Property
		Private fLastName As String
		<Size(20)> _
		Public Property LastName() As String
			Get
				Return fLastName
			End Get
			Set
				SetPropertyValue(Of String)("LastName", fLastName, Value)
			End Set
		End Property
		Private fNotes As String
		<Size(SizeAttribute.Unlimited)> _
		Public Property Notes() As String
			Get
				Return fNotes
			End Get
			Set
				SetPropertyValue(Of String)("Notes", fNotes, Value)
			End Set
		End Property
		Private fPhoto As Byte()
		Public Property Photo() As Byte()
			Get
				Return fPhoto
			End Get
			Set
                SetPropertyValue(Of Byte())("Photo", fPhoto, Value)
			End Set
		End Property
		Private fPostalCode As String
		<Size(10)> _
		Public Property PostalCode() As String
			Get
				Return fPostalCode
			End Get
			Set
				SetPropertyValue(Of String)("PostalCode", fPostalCode, Value)
			End Set
		End Property
		Private fRegion As String
		<Size(15)> _
		Public Property Region() As String
			Get
				Return fRegion
			End Get
			Set
				SetPropertyValue(Of String)("Region", fRegion, Value)
			End Set
		End Property
		Private fReportsTo As Integer
		Public Property ReportsTo() As Integer
			Get
				Return fReportsTo
			End Get
			Set
				SetPropertyValue(Of Integer)("ReportsTo", fReportsTo, Value)
			End Set
		End Property
		Private fTitle As String
		<Size(30)> _
		Public Property Title() As String
			Get
				Return fTitle
			End Get
			Set
				SetPropertyValue(Of String)("Title", fTitle, Value)
			End Set
		End Property
		Private fTitleOfCourtesy As String
		<Size(25)> _
		Public Property TitleOfCourtesy() As String
			Get
				Return fTitleOfCourtesy
			End Get
			Set
				SetPropertyValue(Of String)("TitleOfCourtesy", fTitleOfCourtesy, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Orders
		Inherits XPLiteObject
		Private fCustomerID As Customers
		<Size(5)> _
		Public Property CustomerID() As Customers
			Get
				Return fCustomerID
			End Get
			Set
				SetPropertyValue(Of Customers)("CustomerID", fCustomerID, Value)
			End Set
		End Property
		Private fEmployeeID As Employees
		Public Property EmployeeID() As Employees
			Get
				Return fEmployeeID
			End Get
			Set
				SetPropertyValue(Of Employees)("EmployeeID", fEmployeeID, Value)
			End Set
		End Property
		Private fFreight As Decimal
		Public Property Freight() As Decimal
			Get
				Return fFreight
			End Get
			Set
				SetPropertyValue(Of Decimal)("Freight", fFreight, Value)
			End Set
		End Property
		Private fOrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return fOrderDate
			End Get
			Set
				SetPropertyValue(Of DateTime)("OrderDate", fOrderDate, Value)
			End Set
		End Property
		Private fOrderID As Integer
		<Key(True)> _
		Public Property OrderID() As Integer
			Get
				Return fOrderID
			End Get
			Set
				SetPropertyValue(Of Integer)("OrderID", fOrderID, Value)
			End Set
		End Property
		Private fRequiredDate As DateTime
		Public Property RequiredDate() As DateTime
			Get
				Return fRequiredDate
			End Get
			Set
				SetPropertyValue(Of DateTime)("RequiredDate", fRequiredDate, Value)
			End Set
		End Property
		Private fShipAddress As String
		<Size(60)> _
		Public Property ShipAddress() As String
			Get
				Return fShipAddress
			End Get
			Set
				SetPropertyValue(Of String)("ShipAddress", fShipAddress, Value)
			End Set
		End Property
		Private fShipCity As String
		<Size(15)> _
		Public Property ShipCity() As String
			Get
				Return fShipCity
			End Get
			Set
				SetPropertyValue(Of String)("ShipCity", fShipCity, Value)
			End Set
		End Property
		Private fShipCountry As String
		<Size(15)> _
		Public Property ShipCountry() As String
			Get
				Return fShipCountry
			End Get
			Set
				SetPropertyValue(Of String)("ShipCountry", fShipCountry, Value)
			End Set
		End Property
		Private fShipName As String
		<Size(40)> _
		Public Property ShipName() As String
			Get
				Return fShipName
			End Get
			Set
				SetPropertyValue(Of String)("ShipName", fShipName, Value)
			End Set
		End Property
		Private fShippedDate As DateTime
		Public Property ShippedDate() As DateTime
			Get
				Return fShippedDate
			End Get
			Set
				SetPropertyValue(Of DateTime)("ShippedDate", fShippedDate, Value)
			End Set
		End Property
		Private fShipPostalCode As String
		<Size(10)> _
		Public Property ShipPostalCode() As String
			Get
				Return fShipPostalCode
			End Get
			Set
				SetPropertyValue(Of String)("ShipPostalCode", fShipPostalCode, Value)
			End Set
		End Property
		Private fShipRegion As String
		<Size(15)> _
		Public Property ShipRegion() As String
			Get
				Return fShipRegion
			End Get
			Set
				SetPropertyValue(Of String)("ShipRegion", fShipRegion, Value)
			End Set
		End Property
		Private fShipVia As Shippers
		Public Property ShipVia() As Shippers
			Get
				Return fShipVia
			End Get
			Set
				SetPropertyValue(Of Shippers)("ShipVia", fShipVia, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Customers
		Inherits XPLiteObject
		Private fAddress As String
		<Size(60)> _
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set
				SetPropertyValue(Of String)("Address", fAddress, Value)
			End Set
		End Property
		Private fCity As String
		<Size(15)> _
		Public Property City() As String
			Get
				Return fCity
			End Get
			Set
				SetPropertyValue(Of String)("City", fCity, Value)
			End Set
		End Property
		Private fCompanyName As String
		<Size(40)> _
		Public Property CompanyName() As String
			Get
				Return fCompanyName
			End Get
			Set
				SetPropertyValue(Of String)("CompanyName", fCompanyName, Value)
			End Set
		End Property
		Private fContactName As String
		<Size(30)> _
		Public Property ContactName() As String
			Get
				Return fContactName
			End Get
			Set
				SetPropertyValue(Of String)("ContactName", fContactName, Value)
			End Set
		End Property
		Private fContactTitle As String
		<Size(30)> _
		Public Property ContactTitle() As String
			Get
				Return fContactTitle
			End Get
			Set
				SetPropertyValue(Of String)("ContactTitle", fContactTitle, Value)
			End Set
		End Property
		Private fCountry As String
		<Size(15)> _
		Public Property Country() As String
			Get
				Return fCountry
			End Get
			Set
				SetPropertyValue(Of String)("Country", fCountry, Value)
			End Set
		End Property
		Private fCustomerID As String
		<Key, Size(5)> _
		Public Property CustomerID() As String
			Get
				Return fCustomerID
			End Get
			Set
				SetPropertyValue(Of String)("CustomerID", fCustomerID, Value)
			End Set
		End Property
		Private fFax As String
		<Size(24)> _
		Public Property Fax() As String
			Get
				Return fFax
			End Get
			Set
				SetPropertyValue(Of String)("Fax", fFax, Value)
			End Set
		End Property
		Private fPhone As String
		<Size(24)> _
		Public Property Phone() As String
			Get
				Return fPhone
			End Get
			Set
				SetPropertyValue(Of String)("Phone", fPhone, Value)
			End Set
		End Property
		Private fPostalCode As String
		<Size(10)> _
		Public Property PostalCode() As String
			Get
				Return fPostalCode
			End Get
			Set
				SetPropertyValue(Of String)("PostalCode", fPostalCode, Value)
			End Set
		End Property
		Private fRegion As String
		<Size(15)> _
		Public Property Region() As String
			Get
				Return fRegion
			End Get
			Set
				SetPropertyValue(Of String)("Region", fRegion, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Categories
		Inherits XPLiteObject
		Private fCategoryID As Integer
		<Key(True)> _
		Public Property CategoryID() As Integer
			Get
				Return fCategoryID
			End Get
			Set
				SetPropertyValue(Of Integer)("CategoryID", fCategoryID, Value)
			End Set
		End Property
		Private fCategoryName As String
		<Size(15)> _
		Public Property CategoryName() As String
			Get
				Return fCategoryName
			End Get
			Set
				SetPropertyValue(Of String)("CategoryName", fCategoryName, Value)
			End Set
		End Property
		Private fDescription As String
		<Size(SizeAttribute.Unlimited)> _
		Public Property Description() As String
			Get
				Return fDescription
			End Get
			Set
				SetPropertyValue(Of String)("Description", fDescription, Value)
			End Set
		End Property
		Private fPicture As Byte()
        Public Property Picture() As Byte()
            Get
                Return fPicture
            End Get
            Set(ByVal value As Byte())
                SetPropertyValue(Of Byte())("Picture", fPicture, value)
            End Set
        End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Shippers
		Inherits XPLiteObject
		Private fCompanyName As String
		<Size(40)> _
		Public Property CompanyName() As String
			Get
				Return fCompanyName
			End Get
			Set
				SetPropertyValue(Of String)("CompanyName", fCompanyName, Value)
			End Set
		End Property
		Private fPhone As String
		<Size(24)> _
		Public Property Phone() As String
			Get
				Return fPhone
			End Get
			Set
				SetPropertyValue(Of String)("Phone", fPhone, Value)
			End Set
		End Property
		Private fShipperID As Integer
		<Key(True)> _
		Public Property ShipperID() As Integer
			Get
				Return fShipperID
			End Get
			Set
				SetPropertyValue(Of Integer)("ShipperID", fShipperID, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Products
		Inherits XPLiteObject
		Private fCategoryID As Categories
		Public Property CategoryID() As Categories
			Get
				Return fCategoryID
			End Get
			Set
				SetPropertyValue(Of Categories)("CategoryID", fCategoryID, Value)
			End Set
		End Property
		Private fDiscontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set
				SetPropertyValue(Of Boolean)("Discontinued", fDiscontinued, Value)
			End Set
		End Property
		Private fEAN13 As String
		<Size(12)> _
		Public Property EAN13() As String
			Get
				Return fEAN13
			End Get
			Set
				SetPropertyValue(Of String)("EAN13", fEAN13, Value)
			End Set
		End Property
		Private fProductID As Integer
		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set
				SetPropertyValue(Of Integer)("ProductID", fProductID, Value)
			End Set
		End Property
		Private fProductName As String
		<Size(40)> _
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set
				SetPropertyValue(Of String)("ProductName", fProductName, Value)
			End Set
		End Property
		Private fQuantityPerUnit As String
		<Size(20)> _
		Public Property QuantityPerUnit() As String
			Get
				Return fQuantityPerUnit
			End Get
			Set
				SetPropertyValue(Of String)("QuantityPerUnit", fQuantityPerUnit, Value)
			End Set
		End Property
		Private fReorderLevel As Short
		Public Property ReorderLevel() As Short
			Get
				Return fReorderLevel
			End Get
			Set
				SetPropertyValue(Of Short)("ReorderLevel", fReorderLevel, Value)
			End Set
		End Property
		Private fSupplierID As Suppliers
		Public Property SupplierID() As Suppliers
			Get
				Return fSupplierID
			End Get
			Set
				SetPropertyValue(Of Suppliers)("SupplierID", fSupplierID, Value)
			End Set
		End Property
		Private fUnitPrice As Decimal
		Public Property UnitPrice() As Decimal
			Get
				Return fUnitPrice
			End Get
			Set
				SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, Value)
			End Set
		End Property
		Private fUnitsInStock As Short
		Public Property UnitsInStock() As Short
			Get
				Return fUnitsInStock
			End Get
			Set
				SetPropertyValue(Of Short)("UnitsInStock", fUnitsInStock, Value)
			End Set
		End Property
		Private fUnitsOnOrder As Short
		Public Property UnitsOnOrder() As Short
			Get
				Return fUnitsOnOrder
			End Get
			Set
				SetPropertyValue(Of Short)("UnitsOnOrder", fUnitsOnOrder, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Suppliers
		Inherits XPLiteObject
		Private fAddress As String
		<Size(60)> _
		Public Property Address() As String
			Get
				Return fAddress
			End Get
			Set
				SetPropertyValue(Of String)("Address", fAddress, Value)
			End Set
		End Property
		Private fCity As String
		<Size(15)> _
		Public Property City() As String
			Get
				Return fCity
			End Get
			Set
				SetPropertyValue(Of String)("City", fCity, Value)
			End Set
		End Property
		Private fCompanyName As String
		<Size(40)> _
		Public Property CompanyName() As String
			Get
				Return fCompanyName
			End Get
			Set
				SetPropertyValue(Of String)("CompanyName", fCompanyName, Value)
			End Set
		End Property
		Private fContactName As String
		<Size(30)> _
		Public Property ContactName() As String
			Get
				Return fContactName
			End Get
			Set
				SetPropertyValue(Of String)("ContactName", fContactName, Value)
			End Set
		End Property
		Private fContactTitle As String
		<Size(30)> _
		Public Property ContactTitle() As String
			Get
				Return fContactTitle
			End Get
			Set
				SetPropertyValue(Of String)("ContactTitle", fContactTitle, Value)
			End Set
		End Property
		Private fCountry As String
		<Size(15)> _
		Public Property Country() As String
			Get
				Return fCountry
			End Get
			Set
				SetPropertyValue(Of String)("Country", fCountry, Value)
			End Set
		End Property
		Private fFax As String
		<Size(24)> _
		Public Property Fax() As String
			Get
				Return fFax
			End Get
			Set
				SetPropertyValue(Of String)("Fax", fFax, Value)
			End Set
		End Property
		Private fHomePage As String
		<Size(SizeAttribute.Unlimited)> _
		Public Property HomePage() As String
			Get
				Return fHomePage
			End Get
			Set
				SetPropertyValue(Of String)("HomePage", fHomePage, Value)
			End Set
		End Property
		Private fPhone As String
		<Size(24)> _
		Public Property Phone() As String
			Get
				Return fPhone
			End Get
			Set
				SetPropertyValue(Of String)("Phone", fPhone, Value)
			End Set
		End Property
		Private fPostalCode As String
		<Size(10)> _
		Public Property PostalCode() As String
			Get
				Return fPostalCode
			End Get
			Set
				SetPropertyValue(Of String)("PostalCode", fPostalCode, Value)
			End Set
		End Property
		Private fRegion As String
		<Size(15)> _
		Public Property Region() As String
			Get
				Return fRegion
			End Get
			Set
				SetPropertyValue(Of String)("Region", fRegion, Value)
			End Set
		End Property
		Private fSupplierID As Integer
		<Key(True)> _
		Public Property SupplierID() As Integer
			Get
				Return fSupplierID
			End Get
			Set
				SetPropertyValue(Of Integer)("SupplierID", fSupplierID, Value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

End Namespace
