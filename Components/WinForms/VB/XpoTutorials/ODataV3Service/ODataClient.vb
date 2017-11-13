Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Xpo.Demos.ODataV3
    Partial Public Class NorthwindEntities
        Inherits System.Data.Services.Client.DataServiceContext
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot)
            Me.ResolveName = New Global.System.Func(Of Global.System.Type, String)(AddressOf Me.ResolveNameFromType)
            Me.ResolveType = New Global.System.Func(Of String, Global.System.Type)(AddressOf Me.ResolveTypeFromName)
            Me.OnContextCreated()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            If typeName.StartsWith("NorthwindModel", Global.System.StringComparison.Ordinal) Then
                Return Me.GetType().Assembly.GetType(String.Concat("DevExpress.Xpo.Demos", typeName.Substring(14)), False)
            End If
            Return Nothing
        End Function
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals("DevExpress.Xpo.Demos", Global.System.StringComparison.Ordinal) Then
                Return String.Concat("NorthwindModel.", clientType.Name)
            End If
            Return Nothing
        End Function
        Public ReadOnly Property Customers() As Global.System.Data.Services.Client.DataServiceQuery(Of Customers)
            Get
                If (Me._Customers Is Nothing) Then
                    Me._Customers = MyBase.CreateQuery(Of Customers)("Customers")
                End If
                Return Me._Customers
            End Get
        End Property
        Private _Customers As Global.System.Data.Services.Client.DataServiceQuery(Of Customers)
        Public ReadOnly Property Orders() As Global.System.Data.Services.Client.DataServiceQuery(Of Orders)
            Get
                If (Me._Orders Is Nothing) Then
                    Me._Orders = MyBase.CreateQuery(Of Orders)("Orders")
                End If
                Return Me._Orders
            End Get
        End Property
        Private _Orders As Global.System.Data.Services.Client.DataServiceQuery(Of Orders)
        Public Sub AddToCustomers(ByVal customers As Customers)
            MyBase.AddObject("Customers", customers)
        End Sub
        Public Sub AddToOrders(ByVal orders As Orders)
            MyBase.AddObject("Orders", orders)
        End Sub
    End Class
    <Global.System.Data.Services.Common.EntitySetAttribute("Customers"), Global.System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")> _
    Partial Public Class Customers
        Implements System.ComponentModel.INotifyPropertyChanged
        Public Shared Function CreateCustomers(ByVal customerID As String, ByVal companyName As String) As Customers
            Dim customers As New Customers()
            customers.CustomerID = customerID
            customers.CompanyName = companyName
            Return customers
        End Function
        Public Property CustomerID() As String
            Get
                Return Me._CustomerID
            End Get
            Set(ByVal value As String)
                Me.OnCustomerIDChanging(value)
                Me._CustomerID = value
                Me.OnCustomerIDChanged()
                Me.OnPropertyChanged("CustomerID")
            End Set
        End Property
        Private _CustomerID As String
        Partial Private Sub OnCustomerIDChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCustomerIDChanged()
        End Sub
        Public Property CompanyName() As String
            Get
                Return Me._CompanyName
            End Get
            Set(ByVal value As String)
                Me.OnCompanyNameChanging(value)
                Me._CompanyName = value
                Me.OnCompanyNameChanged()
                Me.OnPropertyChanged("CompanyName")
            End Set
        End Property
        Private _CompanyName As String
        Partial Private Sub OnCompanyNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCompanyNameChanged()
        End Sub
        Public Property ContactName() As String
            Get
                Return Me._ContactName
            End Get
            Set(ByVal value As String)
                Me.OnContactNameChanging(value)
                Me._ContactName = value
                Me.OnContactNameChanged()
                Me.OnPropertyChanged("ContactName")
            End Set
        End Property
        Private _ContactName As String
        Partial Private Sub OnContactNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnContactNameChanged()
        End Sub
        Public Property ContactTitle() As String
            Get
                Return Me._ContactTitle
            End Get
            Set(ByVal value As String)
                Me.OnContactTitleChanging(value)
                Me._ContactTitle = value
                Me.OnContactTitleChanged()
                Me.OnPropertyChanged("ContactTitle")
            End Set
        End Property
        Private _ContactTitle As String
        Partial Private Sub OnContactTitleChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnContactTitleChanged()
        End Sub
        Public Property Address() As String
            Get
                Return Me._Address
            End Get
            Set(ByVal value As String)
                Me.OnAddressChanging(value)
                Me._Address = value
                Me.OnAddressChanged()
                Me.OnPropertyChanged("Address")
            End Set
        End Property
        Private _Address As String
        Partial Private Sub OnAddressChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnAddressChanged()
        End Sub
        Public Property City() As String
            Get
                Return Me._City
            End Get
            Set(ByVal value As String)
                Me.OnCityChanging(value)
                Me._City = value
                Me.OnCityChanged()
                Me.OnPropertyChanged("City")
            End Set
        End Property
        Private _City As String
        Partial Private Sub OnCityChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCityChanged()
        End Sub
        Public Property Region() As String
            Get
                Return Me._Region
            End Get
            Set(ByVal value As String)
                Me.OnRegionChanging(value)
                Me._Region = value
                Me.OnRegionChanged()
                Me.OnPropertyChanged("Region")
            End Set
        End Property
        Private _Region As String
        Partial Private Sub OnRegionChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnRegionChanged()
        End Sub
        Public Property PostalCode() As String
            Get
                Return Me._PostalCode
            End Get
            Set(ByVal value As String)
                Me.OnPostalCodeChanging(value)
                Me._PostalCode = value
                Me.OnPostalCodeChanged()
                Me.OnPropertyChanged("PostalCode")
            End Set
        End Property
        Private _PostalCode As String
        Partial Private Sub OnPostalCodeChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPostalCodeChanged()
        End Sub
        Public Property Country() As String
            Get
                Return Me._Country
            End Get
            Set(ByVal value As String)
                Me.OnCountryChanging(value)
                Me._Country = value
                Me.OnCountryChanged()
                Me.OnPropertyChanged("Country")
            End Set
        End Property
        Private _Country As String
        Partial Private Sub OnCountryChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCountryChanged()
        End Sub
        Public Property Phone() As String
            Get
                Return Me._Phone
            End Get
            Set(ByVal value As String)
                Me.OnPhoneChanging(value)
                Me._Phone = value
                Me.OnPhoneChanged()
                Me.OnPropertyChanged("Phone")
            End Set
        End Property
        Private _Phone As String
        Partial Private Sub OnPhoneChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPhoneChanged()
        End Sub
        Public Property Fax() As String
            Get
                Return Me._Fax
            End Get
            Set(ByVal value As String)
                Me.OnFaxChanging(value)
                Me._Fax = value
                Me.OnFaxChanged()
                Me.OnPropertyChanged("Fax")
            End Set
        End Property
        Private _Fax As String
        Partial Private Sub OnFaxChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFaxChanged()
        End Sub
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Me.PropertyChangedEvent IsNot Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
    <Global.System.Data.Services.Common.EntitySetAttribute("Orders"), Global.System.Data.Services.Common.DataServiceKeyAttribute("OrderID")> _
    Partial Public Class Orders
        Implements System.ComponentModel.INotifyPropertyChanged
        Public Shared Function CreateOrders(ByVal orderID As Integer) As Orders
            Dim orders As New Orders()
            orders.OrderID = orderID
            Return orders
        End Function
        Public Property OrderID() As Integer
            Get
                Return Me._OrderID
            End Get
            Set(ByVal value As Integer)
                Me.OnOrderIDChanging(value)
                Me._OrderID = value
                Me.OnOrderIDChanged()
                Me.OnPropertyChanged("OrderID")
            End Set
        End Property
        Private _OrderID As Integer
        Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnOrderIDChanged()
        End Sub
        Public Property OrderDate() As Global.System.DateTime?
            Get
                Return Me._OrderDate
            End Get
            Set(ByVal value? As System.DateTime)
                Me.OnOrderDateChanging(value)
                Me._OrderDate = value
                Me.OnOrderDateChanged()
                Me.OnPropertyChanged("OrderDate")
            End Set
        End Property
        Private _OrderDate? As Global.System.DateTime
        Partial Private Sub OnOrderDateChanging(ByVal value? As Global.System.DateTime)
        End Sub
        Partial Private Sub OnOrderDateChanged()
        End Sub
        Public Property RequiredDate() As Global.System.DateTime?
            Get
                Return Me._RequiredDate
            End Get
            Set(ByVal value? As System.DateTime)
                Me.OnRequiredDateChanging(value)
                Me._RequiredDate = value
                Me.OnRequiredDateChanged()
                Me.OnPropertyChanged("RequiredDate")
            End Set
        End Property
        Private _RequiredDate? As Global.System.DateTime
        Partial Private Sub OnRequiredDateChanging(ByVal value? As Global.System.DateTime)
        End Sub
        Partial Private Sub OnRequiredDateChanged()
        End Sub
        Public Property ShippedDate() As Global.System.DateTime?
            Get
                Return Me._ShippedDate
            End Get
            Set(ByVal value? As System.DateTime)
                Me.OnShippedDateChanging(value)
                Me._ShippedDate = value
                Me.OnShippedDateChanged()
                Me.OnPropertyChanged("ShippedDate")
            End Set
        End Property
        Private _ShippedDate? As Global.System.DateTime
        Partial Private Sub OnShippedDateChanging(ByVal value? As Global.System.DateTime)
        End Sub
        Partial Private Sub OnShippedDateChanged()
        End Sub
        Public Property ShipVia() As Integer?
            Get
                Return Me._ShipVia
            End Get
            Set(ByVal value? As Integer)
                Me.OnShipViaChanging(value)
                Me._ShipVia = value
                Me.OnShipViaChanged()
                Me.OnPropertyChanged("ShipVia")
            End Set
        End Property
        Private _ShipVia? As Integer
        Partial Private Sub OnShipViaChanging(ByVal value? As Integer)
        End Sub
        Partial Private Sub OnShipViaChanged()
        End Sub
        Public Property Freight() As Decimal?
            Get
                Return Me._Freight
            End Get
            Set(ByVal value? As Decimal)
                Me.OnFreightChanging(value)
                Me._Freight = value
                Me.OnFreightChanged()
                Me.OnPropertyChanged("Freight")
            End Set
        End Property
        Private _Freight? As Decimal
        Partial Private Sub OnFreightChanging(ByVal value? As Decimal)
        End Sub
        Partial Private Sub OnFreightChanged()
        End Sub
        Public Property ShipName() As String
            Get
                Return Me._ShipName
            End Get
            Set(ByVal value As String)
                Me.OnShipNameChanging(value)
                Me._ShipName = value
                Me.OnShipNameChanged()
                Me.OnPropertyChanged("ShipName")
            End Set
        End Property
        Private _ShipName As String
        Partial Private Sub OnShipNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipNameChanged()
        End Sub
        Public Property ShipAddress() As String
            Get
                Return Me._ShipAddress
            End Get
            Set(ByVal value As String)
                Me.OnShipAddressChanging(value)
                Me._ShipAddress = value
                Me.OnShipAddressChanged()
                Me.OnPropertyChanged("ShipAddress")
            End Set
        End Property
        Private _ShipAddress As String
        Partial Private Sub OnShipAddressChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipAddressChanged()
        End Sub
        Public Property ShipCity() As String
            Get
                Return Me._ShipCity
            End Get
            Set(ByVal value As String)
                Me.OnShipCityChanging(value)
                Me._ShipCity = value
                Me.OnShipCityChanged()
                Me.OnPropertyChanged("ShipCity")
            End Set
        End Property
        Private _ShipCity As String
        Partial Private Sub OnShipCityChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipCityChanged()
        End Sub
        Public Property ShipRegion() As String
            Get
                Return Me._ShipRegion
            End Get
            Set(ByVal value As String)
                Me.OnShipRegionChanging(value)
                Me._ShipRegion = value
                Me.OnShipRegionChanged()
                Me.OnPropertyChanged("ShipRegion")
            End Set
        End Property
        Private _ShipRegion As String
        Partial Private Sub OnShipRegionChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipRegionChanged()
        End Sub
        Public Property ShipPostalCode() As String
            Get
                Return Me._ShipPostalCode
            End Get
            Set(ByVal value As String)
                Me.OnShipPostalCodeChanging(value)
                Me._ShipPostalCode = value
                Me.OnShipPostalCodeChanged()
                Me.OnPropertyChanged("ShipPostalCode")
            End Set
        End Property
        Private _ShipPostalCode As String
        Partial Private Sub OnShipPostalCodeChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipPostalCodeChanged()
        End Sub
        Public Property ShipCountry() As String
            Get
                Return Me._ShipCountry
            End Get
            Set(ByVal value As String)
                Me.OnShipCountryChanging(value)
                Me._ShipCountry = value
                Me.OnShipCountryChanged()
                Me.OnPropertyChanged("ShipCountry")
            End Set
        End Property
        Private _ShipCountry As String
        Partial Private Sub OnShipCountryChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnShipCountryChanged()
        End Sub
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Me.PropertyChangedEvent IsNot Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
End Namespace
