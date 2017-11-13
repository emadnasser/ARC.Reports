Imports DevExpress.DemoData.Models
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration
Imports System.Linq
Imports DevExpress.DemoData.Models.Mapping
Imports DevExpress.Mvvm
Imports System.Data.Common
Imports DevExpress.Internal
Imports System.IO
Imports System.Data.SQLite


Namespace DevExpress.DemoData

    Public MustInherit Class DataLoaderBase
        Protected Sub LoadIfNeed(ByRef checkFlag As Boolean, ByVal target As IQueryable)
            If Not checkFlag Then
                target.Load()
                checkFlag = True
            End If
        End Sub
    End Class

    Public Class NWindDataLoader
        Inherits DataLoaderBase

        Private context As NWindContext
        Public Sub New()
            If Not ViewModelBase.IsInDesignMode Then
                context = NWindContext.Create()
            End If
        End Sub
        Public ReadOnly Property Invoices() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Invoice)()
                End If
                Return context.Invoices.OrderBy(Function(i) i.OrderID).ToList()
            End Get
        End Property
        Public ReadOnly Property ObservableInvoices() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Invoice)()
                End If
                Return New System.Collections.ObjectModel.ObservableCollection(Of Invoice)(context.Invoices.OrderBy(Function(i) i.OrderID))
            End Get
        End Property
        Public ReadOnly Property ObservableInvoices200() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Invoice)()
                End If
                Return New System.Collections.ObjectModel.ObservableCollection(Of Invoice)(context.Invoices.Take(200).OrderBy(Function(i) i.OrderID))
            End Get
        End Property
        Public ReadOnly Property Customers() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Customer)()
                End If
                context.Customers.Load()
                Return context.Customers.Local
            End Get
        End Property
        Public ReadOnly Property Employees() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Employee)()
                End If
                context.Employees.Load()
                Return context.Employees.Local
            End Get
        End Property
        Public ReadOnly Property EmployeesWithOrdersAndOrderDetails() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Employee)()
                End If
                context.Employees.Include(Function(x) x.Orders.Select(Function(y) y.OrderDetails)).Load()
                Return context.Employees.Local
            End Get
        End Property
        Public ReadOnly Property Products() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Product)()
                End If
                context.Products.Load()
                Return context.Products.Local
            End Get
        End Property
        Public ReadOnly Property Categories() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Category)()
                End If
                context.Categories.Load()
                Return context.Categories.Local
            End Get
        End Property
        Public ReadOnly Property OrderDetails() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of OrderDetail)()
                End If
                context.OrderDetails.Load()
                Return context.OrderDetails.Local
            End Get
        End Property
        Public ReadOnly Property OrderDetailsExtended() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of OrderDetailsExtended)()
                End If
                context.OrderDetailsExtended.Load()
                Return context.OrderDetailsExtended.Local
            End Get
        End Property
        Public ReadOnly Property Orders() As Object
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of Order)()
                End If
                context.Orders.Load()
                Return context.Orders.Local
            End Get
        End Property
        Public Shared ReadOnly Property Titles() As List(Of String)
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New List(Of String)()
                End If
                Return NWindContext.Create().Employees.Select(Function(e) e.Title).Distinct().ToList()
            End Get
        End Property
        Public Shared ReadOnly Property Countries() As String()
            Get
                If ViewModelBase.IsInDesignMode Then
                    Return New String(){}
                End If
                Return NWindContext.Create().CountriesArray
            End Get
        End Property
    End Class
End Namespace

' NWindContext.cs

Namespace DevExpress.DemoData.Models
    Friend NotInheritable Class DbContextPreloader(Of T As {DbContext, New})

        Private Sub New()
        End Sub

        Private Shared task As System.Threading.Tasks.Task
        Shared Sub New()
            Dim action As Action = Nothing
            If ViewModelBase.IsInDesignMode Then
                action = Sub()
                End Sub
            Else
                action = Sub()
                    Dim context = New T()
                    Dim prop = GetType(T).GetProperties().Where(Function(p) p.PropertyType.IsGenericType AndAlso p.PropertyType.GetGenericTypeDefinition() Is GetType(DbSet(Of ))).FirstOrDefault()
                    If prop Is Nothing Then
                        Return
                    End If
                    Dim query = DirectCast(prop.GetValue(context, Nothing), IQueryable(Of Object))
                    query.Count()
                End Sub
            End If
            task = (New System.Threading.Tasks.TaskFactory()).StartNew(action)
        End Sub
        Public Shared Function Preload() As System.Threading.Tasks.Task
            Return task
        End Function
    End Class

    Partial Public Class NWindContext
        Inherits DbContext

        Public Sub New()
            MyBase.New(CreateConnection(), True)
        End Sub
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Public Sub New(ByVal connection As DbConnection)
            MyBase.New(connection, True)
        End Sub

        Shared Sub New()
            Database.SetInitializer(Of NWindContext)(Nothing)
        End Sub

        Private Shared filePath As String
        Private Shared Function CreateConnection() As DbConnection
            If filePath Is Nothing Then
                filePath = DataDirectoryHelper.GetFile("nwind.db", DataDirectoryHelper.DataFolderName)
            End If
            Try
                Dim attributes = File.GetAttributes(filePath)
                If attributes.HasFlag(FileAttributes.ReadOnly) Then
                    File.SetAttributes(filePath, attributes And (Not FileAttributes.ReadOnly))
                End If
            Catch
            End Try
            Dim connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection()
            connection.ConnectionString = New SQLiteConnectionStringBuilder With {.DataSource = filePath}.ConnectionString
            Return connection
        End Function

        Public Overrides Function SaveChanges() As Integer
            Throw New Exception("Readonly context")
        End Function

        Public Shared Function Preload() As System.Threading.Tasks.Task
            Return DbContextPreloader(Of NWindContext).Preload()
        End Function

        Public Shared Function Create() As NWindContext
            Preload().Wait()
            Return New NWindContext()
        End Function

        Public Property Categories() As DbSet(Of Category)
        Public Property Customers() As DbSet(Of Customer)
        Public Property Employees() As DbSet(Of Employee)
        Public Property EmployeeTerritories() As DbSet(Of EmployeeTerritory)
        Public Property OrderDetails() As DbSet(Of OrderDetail)
        Public Property Orders() As DbSet(Of Order)
        Public Property Products() As DbSet(Of Product)
        Public Property Regions() As DbSet(Of Region)
        Public Property Shippers() As DbSet(Of Shipper)
        Public Property Suppliers() As DbSet(Of Supplier)
        Public Property Territories() As DbSet(Of Territory)
        Public Property AlphabeticalListOfProducts() As DbSet(Of AlphabeticalListOfProduct)
        Public Property CategoryProducts() As DbSet(Of CategoryProduct)
        Public Property CurrentProductLists() As DbSet(Of CurrentProductList)
        Public Property CustomerAndSuppliersByCities() As DbSet(Of CustomerAndSuppliersByCity)
        Public Property CustomerReports() As DbSet(Of CustomerReport)
        Public Property Invoices() As DbSet(Of Invoice)
        Public Property OrderDetailsExtended() As DbSet(Of OrderDetailsExtended)
        Public Property OrderReports() As DbSet(Of OrderReport)
        Public Property OrdersQries() As DbSet(Of OrdersQry)
        Public Property OrderSubtotals() As DbSet(Of OrderSubtotal)
        Public Property ProductReports() As DbSet(Of ProductReport)
        Public Property ProductsAboveAveragePrices() As DbSet(Of ProductsAboveAveragePrice)
        Public Property ProductsByCategories() As DbSet(Of ProductsByCategory)
        Public Property SalesByCategories() As DbSet(Of SalesByCategory)
        Public Property SalesPersons() As DbSet(Of SalesPerson)
        Public Property SalesTotalsByAmounts() As DbSet(Of SalesTotalsByAmount)
        Public Property SummaryOfSalesByQuarters() As DbSet(Of SummaryOfSalesByQuarter)
        Public Property SummaryOfSalesByYears() As DbSet(Of SummaryOfSalesByYear)

        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Configurations.Add(New CategoryMap())
            modelBuilder.Configurations.Add(New CustomerMap())
            modelBuilder.Configurations.Add(New EmployeeMap())
            modelBuilder.Configurations.Add(New EmployeeTerritoryMap())
            modelBuilder.Configurations.Add(New OrderDetailMap())
            modelBuilder.Configurations.Add(New OrderMap())
            modelBuilder.Configurations.Add(New ProductMap())
            modelBuilder.Configurations.Add(New RegionMap())
            modelBuilder.Configurations.Add(New ShipperMap())
            modelBuilder.Configurations.Add(New SupplierMap())
            modelBuilder.Configurations.Add(New TerritoryMap())
            modelBuilder.Configurations.Add(New AlphabeticalListOfProductMap())
            modelBuilder.Configurations.Add(New CategoryProductMap())
            modelBuilder.Configurations.Add(New CurrentProductListMap())
            modelBuilder.Configurations.Add(New CustomerAndSuppliersByCityMap())
            modelBuilder.Configurations.Add(New CustomerReportMap())
            modelBuilder.Configurations.Add(New InvoiceMap())
            modelBuilder.Configurations.Add(New OrderDetailsExtendedMap())
            modelBuilder.Configurations.Add(New OrderReportMap())
            modelBuilder.Configurations.Add(New OrdersQryMap())
            modelBuilder.Configurations.Add(New OrderSubtotalMap())
            modelBuilder.Configurations.Add(New ProductReportMap())
            modelBuilder.Configurations.Add(New ProductsAboveAveragePriceMap())
            modelBuilder.Configurations.Add(New ProductsByCategoryMap())
            modelBuilder.Configurations.Add(New SalesByCategoryMap())
            modelBuilder.Configurations.Add(New SalesPersonMap())
            modelBuilder.Configurations.Add(New SalesTotalsByAmountMap())
            modelBuilder.Configurations.Add(New SummaryOfSalesByQuarterMap())
            modelBuilder.Configurations.Add(New SummaryOfSalesByYearMap())
        End Sub

        Public CountriesArray() As String = { "United States", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil", "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands", "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Lucia", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis", "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)", "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe" }
    End Class
End Namespace

' AlphabeticalListOfProduct.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class AlphabeticalListOfProduct
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property SupplierID() As Long?
        Public Property CategoryID() As Long?
        Public Property QuantityPerUnit() As String
        Public Property UnitPrice() As Decimal?
        Public Property UnitsInStock() As Short?
        Public Property UnitsOnOrder() As Short?
        Public Property ReorderLevel() As Short?
        Public Property Discontinued() As Boolean
        Public Property EAN13() As String
        Public Property CategoryName() As String
    End Class
End Namespace

' Category.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Category
        Public Property CategoryID() As Long
        Public Property CategoryName() As String
        Public Property Description() As String
        Public Property Picture() As Byte()
        Public Property Icon25() As Byte()
        Public Property Icon17() As Byte()
        Public Overridable Property Products() As ICollection(Of Product)
    End Class
End Namespace

' CategoryProduct.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class CategoryProduct
        Public Property ProductID() As Long
        Public Property SupplierID() As Long?
        Public Property ProductName() As String
        Public Property CategoryName() As String
        Public Property Picture() As Byte()
        Public Property Description() As String
    End Class
End Namespace

' CurrentProductList.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class CurrentProductList
        Public Property ProductID() As Long
        Public Property ProductName() As String
    End Class
End Namespace

' Customer.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Customer
        Public Property CustomerID() As String
        Public Property CompanyName() As String
        Public Property ContactName() As String
        Public Property ContactTitle() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
        Public Property Phone() As String
        Public Property Fax() As String

        Public Overridable Property Employees() As ICollection(Of Employee)
        Public Overridable Property Orders() As ICollection(Of Order)
    End Class
End Namespace

' CustomerAndSuppliersByCity.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class CustomerAndSuppliersByCity
        Public Property City() As String
        Public Property CompanyName() As String
        Public Property ContactName() As String
    End Class
End Namespace

' CustomerReport.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class CustomerReport
        Public Property ProductName() As String
        Public Property CompanyName() As String
        Public Property OrderDate() As Date?
        Public Property ProductAmount() As Decimal
    End Class
End Namespace

' Employee.cs

Namespace DevExpress.DemoData.Models
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "DXCA003", Justification := "VB Convertion")>
    Partial Public Class Employee
        Inherits BindableBase

        Private _EmployeeID As Long
        Public Property EmployeeID() As Long
            Get
                Return _EmployeeID
            End Get
            Set(ByVal value As Long)
                SetProperty(_EmployeeID, value, "EmployeeID")
            End Set
        End Property
        Private _LastName As String
        Public Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(ByVal value As String)
                SetProperty(_LastName, value, "LastName")
            End Set
        End Property
        Private _FirstName As String
        Public Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(ByVal value As String)
                SetProperty(_FirstName, value, "FirstName")
            End Set
        End Property
        Private _Title As String
        Public Property Title() As String
            Get
                Return _Title
            End Get
            Set(ByVal value As String)
                SetProperty(_Title, value, "Title")
            End Set
        End Property
        Private _TitleOfCourtesy As String
        Public Property TitleOfCourtesy() As String
            Get
                Return _TitleOfCourtesy
            End Get
            Set(ByVal value As String)
                SetProperty(_TitleOfCourtesy, value, "TitleOfCourtesy")
            End Set
        End Property
        Private _BirthDate? As Date
        Public Property BirthDate() As Date?
            Get
                Return _BirthDate
            End Get
            Set(ByVal value? As Date)
                SetProperty(_BirthDate, value, "BirthDate")
            End Set
        End Property
        Private _HireDate? As Date
        Public Property HireDate() As Date?
            Get
                Return _HireDate
            End Get
            Set(ByVal value? As Date)
                SetProperty(_HireDate, value, "HireDate")
            End Set
        End Property
        Private _Address As String
        Public Property Address() As String
            Get
                Return _Address
            End Get
            Set(ByVal value As String)
                SetProperty(_Address, value, "Address")
            End Set
        End Property
        Private _City As String
        Public Property City() As String
            Get
                Return _City
            End Get
            Set(ByVal value As String)
                SetProperty(_City, value, "City")
            End Set
        End Property
        Private _Region As String
        Public Property Region() As String
            Get
                Return _Region
            End Get
            Set(ByVal value As String)
                SetProperty(_Region, value, "Region")
            End Set
        End Property
        Private _PostalCode As String
        Public Property PostalCode() As String
            Get
                Return _PostalCode
            End Get
            Set(ByVal value As String)
                SetProperty(_PostalCode, value, "PostalCode")
            End Set
        End Property
        Private _Country As String
        Public Property Country() As String
            Get
                Return _Country
            End Get
            Set(ByVal value As String)
                SetProperty(_Country, value, "Country")
            End Set
        End Property
        Private _HomePhone As String
        Public Property HomePhone() As String
            Get
                Return _HomePhone
            End Get
            Set(ByVal value As String)
                SetProperty(_HomePhone, value, "HomePhone")
            End Set
        End Property
        Private _Extension As String
        Public Property Extension() As String
            Get
                Return _Extension
            End Get
            Set(ByVal value As String)
                SetProperty(_Extension, value, "Extension")
            End Set
        End Property
        Private _Photo() As Byte
        Public Property Photo() As Byte()
            Get
                Return _Photo
            End Get
            Set(ByVal value As Byte())
                SetProperty(_Photo, value, "Photo")
            End Set
        End Property
        Private _Notes As String
        Public Property Notes() As String
            Get
                Return _Notes
            End Get
            Set(ByVal value As String)
                SetProperty(_Notes, value, "Notes")
            End Set
        End Property
        Private _ReportsTo? As Long
        Public Property ReportsTo() As Long?
            Get
                Return _ReportsTo
            End Get
            Set(ByVal value? As Long)
                SetProperty(_ReportsTo, value, "ReportsTo")
            End Set
        End Property
        Private _Email As String
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                SetProperty(_Email, value, "Email")
            End Set
        End Property
        Private _GroupName As String
        Public Property GroupName() As String
            Get
                Return _GroupName
            End Get
            Set(ByVal value As String)
                SetProperty(_GroupName, value, "GroupName")
            End Set
        End Property

        Private _FullName As String = Nothing
        Public ReadOnly Property FullName() As String
            Get
                If _FullName Is Nothing Then
                    _FullName = String.Format("{0} {1}", FirstName, LastName)
                End If
                Return _FullName
            End Get
        End Property

        Public Overridable Property Customers() As ICollection(Of Customer)
        Public Overridable Property Orders() As ICollection(Of Order)
        Public Overridable Property Employees() As ICollection(Of Employee)
        Public Overridable Property SubEmployee() As Employee
        Public ReadOnly Property PageHeader() As String
            Get
                Return (FirstName & " " & LastName).ToUpper()
            End Get
        End Property
        Public ReadOnly Property PageContent() As String
            Get
                Return FirstName & " " & LastName & " was born on " & DateToString(BirthDate) & ". Now lives in " & City & ", " & Country & ". " & TitleOfCourtesy & " " & LastName & " holds a position of " & Title & " our " & Region & " deparment, (" & City & " " & Country & "). Joined our company on " & DateToString(HireDate) & "."
            End Get
        End Property
        Private Function DateToString(ByVal [date]? As Date) As String
            If [date] Is Nothing Then
                Return Nothing
            End If
            Dim Months() As String = { "January", "February", "Marth", "April", "May", "June", "July", "August", "September", "October", "November", "December" }
            Return [date].Value.Day & "th of " & Months([date].Value.Month - 1) & " in " & [date].Value.Year
        End Function

        Private _ChartSource As IEnumerable(Of ChartPoint) = Nothing
        Public ReadOnly Property ChartSource() As IEnumerable(Of ChartPoint)
            Get
                If _ChartSource Is Nothing Then
                    CreateChartSource()
                End If
                Return _ChartSource
            End Get
        End Property

        Private Sub CreateChartSource()
            Dim list As IEnumerable(Of ChartPoint) = (
                From o In Orders
                Group o By o.OrderDate Into cp = Group
                Select New ChartPoint() With {.ArgumentMember = OrderDate, .Orders = cp.ToList()}).ToList()
            For Each cp As ChartPoint In list
                Dim value As Decimal = 0
                For Each order As Order In cp.Orders
                    For Each inv As OrderDetailsExtended In order.OrderDetails
                        value += inv.Quantity * inv.UnitPrice
                    Next inv
                Next order
                cp.ValueMember = CInt((value))
            Next cp
            _ChartSource = list
        End Sub
    End Class

    Public Class ChartPoint
        Private privateArgumentMember? As Date
        Public Property ArgumentMember() As Date?
            Get
                Return privateArgumentMember
            End Get
            Friend Set(ByVal value? As Date)
                privateArgumentMember = value
            End Set
        End Property
        Public Property ValueMember() As Integer
        Friend Property Orders() As IList(Of Order)
    End Class
End Namespace

' EmployeeTerritory.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class EmployeeTerritory
        Public Property EmployeeID() As Long
        Public Property TerritoryID() As String
    End Class
End Namespace

' InternationalOrder.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class InternationalOrder
        Public Property OrderID() As Long
        Public Property CustomsDescription() As String
        Public Property ExciseTax() As Decimal
        Public Overridable Property Order() As Order
    End Class
End Namespace

' Invoice.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Invoice
        Public Property ShipName() As String
        Public Property ShipAddress() As String
        Public Property ShipCity() As String
        Public Property ShipRegion() As String
        Public Property ShipPostalCode() As String
        Public Property ShipCountry() As String
        Public Property CustomerID() As String
        Public Property CustomerName() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
        Public Property OrderID() As Long
        Public Property OrderDate() As Date?
        Public Property RequiredDate() As Date?
        Public Property ShippedDate() As Date?
        Public Property ShipperName() As String
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
        Public Property Freight() As Decimal?
    End Class
End Namespace

' Order.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Order
        Public Property OrderID() As Long
        Public Property CustomerID() As String
        Public Property EmployeeID() As Long?
        Public Property OrderDate() As Date?
        Public Property RequiredDate() As Date?
        Public Property ShippedDate() As Date?
        Public Property ShipVia() As Long?
        Public Property Freight() As Decimal?
        Public Property ShipName() As String
        Public Property ShipAddress() As String
        Public Property ShipCity() As String
        Public Property ShipRegion() As String
        Public Property ShipPostalCode() As String
        Public Property ShipCountry() As String

        Public Overridable Property Employee() As Employee
        Public Overridable Property Customer() As Customer
        Public Overridable Property OrderDetails() As ICollection(Of OrderDetailsExtended)
    End Class
End Namespace

' OrderDetail.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class OrderDetail
        Public Property OrderID() As Long
        Public Property ProductID() As Long
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
    End Class
End Namespace

' OrderDetailsExtended.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class OrderDetailsExtended
        Public Property OrderID() As Long
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
        Public Property ExtendedPrice() As Decimal

        Public Overridable Property Order() As Order
    End Class
End Namespace

' OrderReport.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class OrderReport
        Public Property OrderID() As Long
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
        Public Property ExtendedPrice() As Decimal
    End Class
End Namespace

' OrdersQry.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class OrdersQry
        Public Property OrderID() As Long
        Public Property CustomerID() As String
        Public Property EmployeeID() As Long?
        Public Property OrderDate() As Date?
        Public Property RequiredDate() As Date?
        Public Property ShippedDate() As Date?
        Public Property ShipVia() As Long?
        Public Property Freight() As Decimal?
        Public Property ShipName() As String
        Public Property ShipAddress() As String
        Public Property ShipCity() As String
        Public Property ShipRegion() As String
        Public Property ShipPostalCode() As String
        Public Property ShipCountry() As String
        Public Property CompanyName() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
    End Class
End Namespace

' OrderSubtotal.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class OrderSubtotal
        Public Property OrderID() As Long
    End Class
End Namespace

' PreviousEmployee.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class PreviousEmployee
        Public Property EmployeeID() As Long
        Public Property LastName() As String
        Public Property FirstName() As String
        Public Property Title() As String
        Public Property TitleOfCourtesy() As String
        Public Property BirthDate() As Date?
        Public Property HireDate() As Date?
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
        Public Property HomePhone() As String
        Public Property Extension() As String
        Public Property Photo() As Byte()
        Public Property Notes() As String
        Public Property PhotoPath() As String
    End Class
End Namespace

' Product.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Product
        Public Property ProductID() As Long
        Public Property ProductName() As String
        Public Property SupplierID() As Long?
        Public Property CategoryID() As Long?
        Public Property QuantityPerUnit() As String
        Public Property UnitPrice() As Decimal?
        Public Property UnitsInStock() As Short?
        Public Property UnitsOnOrder() As Short?
        Public Property ReorderLevel() As Short?
        Public Property Discontinued() As Boolean
        Public Property EAN13() As String

        Public Overridable Property Category() As Category
    End Class
End Namespace

' ProductReport.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class ProductReport
        Public Property CategoryName() As String
        Public Property ProductName() As String
        Public Property ProductSales() As Decimal
        Public Property ShippedDate() As Date?
    End Class
End Namespace

' ProductsAboveAveragePrice.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class ProductsAboveAveragePrice
        Public Property ProductName() As String
        Public Property UnitPrice() As Decimal?
    End Class
End Namespace

' ProductsByCategory.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class ProductsByCategory
        Public Property CategoryName() As String
        Public Property ProductName() As String
        Public Property QuantityPerUnit() As String
        Public Property UnitsInStock() As Short?
        Public Property Discontinued() As Boolean
    End Class
End Namespace

' Region.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Region
        Public Property RegionID() As Long
        Public Property RegionDescription() As String
    End Class
End Namespace

' SalesByCategory.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class SalesByCategory
        Public Property CategoryID() As Long
        Public Property CategoryName() As String
        Public Property ProductName() As String
    End Class
End Namespace

' SalesPerson.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class SalesPerson
        Public Property OrderID() As Long
        Public Property Country() As String
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property ProductName() As String
        Public Property CategoryName() As String
        Public Property OrderDate() As Date?
        Public Property UnitPrice() As Decimal
        Public Property Quantity() As Short
        Public Property Discount() As Double
        Public Property ExtendedPrice() As Decimal
        Public Property FullName() As String
    End Class
End Namespace

' SalesTotalsByAmount.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class SalesTotalsByAmount
        Public Property OrderID() As Long
        Public Property CompanyName() As String
        Public Property ShippedDate() As Date?
    End Class
End Namespace

' Shipper.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Shipper
        Public Property ShipperID() As Long
        Public Property CompanyName() As String
        Public Property Phone() As String
    End Class
End Namespace

' SummaryOfSalesByQuarter.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class SummaryOfSalesByQuarter
        Public Property ShippedDate() As Date?
        Public Property OrderID() As Long
    End Class
End Namespace

' SummaryOfSalesByYear.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class SummaryOfSalesByYear
        Public Property ShippedDate() As Date?
        Public Property OrderID() As Long
    End Class
End Namespace

' Supplier.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Supplier
        Public Property SupplierID() As Long
        Public Property CompanyName() As String
        Public Property ContactName() As String
        Public Property ContactTitle() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property Region() As String
        Public Property PostalCode() As String
        Public Property Country() As String
        Public Property Phone() As String
        Public Property Fax() As String
        Public Property HomePage() As String
    End Class
End Namespace

' Territory.cs

Namespace DevExpress.DemoData.Models
    Partial Public Class Territory
        Public Property TerritoryID() As String
        Public Property TerritoryDescription() As String
        Public Property RegionID() As Long
    End Class
End Namespace

' AlphabeticalListOfProductMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class AlphabeticalListOfProductMap
        Inherits EntityTypeConfiguration(Of AlphabeticalListOfProduct)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)

            ' Properties
            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.QuantityPerUnit).HasMaxLength(20)

            Me.Property(Function(t) t.EAN13).HasMaxLength(2147483647)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            ' Table & Column Mappings
            Me.ToTable("AlphabeticalListOfProducts")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.SupplierID).HasColumnName("SupplierID")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.QuantityPerUnit).HasColumnName("QuantityPerUnit")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.UnitsInStock).HasColumnName("UnitsInStock")
            Me.Property(Function(t) t.UnitsOnOrder).HasColumnName("UnitsOnOrder")
            Me.Property(Function(t) t.ReorderLevel).HasColumnName("ReorderLevel")
            Me.Property(Function(t) t.Discontinued).HasColumnName("Discontinued")
            Me.Property(Function(t) t.EAN13).HasColumnName("EAN13")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
        End Sub
    End Class
End Namespace

' CategoryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CategoryMap
        Inherits EntityTypeConfiguration(Of Category)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CategoryID)

            ' Properties
            Me.Property(Function(t) t.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.Description).HasMaxLength(1073741823)

            Me.Property(Function(t) t.Picture).HasMaxLength(2147483647)

            ' Table & Column Mappings
            Me.ToTable("Categories")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.Description).HasColumnName("Description")
            Me.Property(Function(t) t.Picture).HasColumnName("Picture")
        End Sub
    End Class
End Namespace

' CategoryProductMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CategoryProductMap
        Inherits EntityTypeConfiguration(Of CategoryProduct)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)

            ' Properties
            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.Picture).HasMaxLength(2147483647)

            Me.Property(Function(t) t.Description).HasMaxLength(1073741823)

            ' Table & Column Mappings
            Me.ToTable("CategoryProducts")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.SupplierID).HasColumnName("SupplierID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.Picture).HasColumnName("Picture")
            Me.Property(Function(t) t.Description).HasColumnName("Description")
        End Sub
    End Class
End Namespace

' CurrentProductListMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CurrentProductListMap
        Inherits EntityTypeConfiguration(Of CurrentProductList)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)

            ' Properties
            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("CurrentProductList")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
        End Sub
    End Class
End Namespace

' CustomerAndSuppliersByCityMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CustomerAndSuppliersByCityMap
        Inherits EntityTypeConfiguration(Of CustomerAndSuppliersByCity)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CompanyName)

            ' Properties
            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.ContactName).HasMaxLength(30)

            ' Table & Column Mappings
            Me.ToTable("CustomerAndSuppliersByCity")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.ContactName).HasColumnName("ContactName")
        End Sub
    End Class
End Namespace

' CustomerMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CustomerMap
        Inherits EntityTypeConfiguration(Of Customer)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CustomerID)

            ' Properties
            Me.Property(Function(t) t.CustomerID).IsRequired().IsFixedLength().HasMaxLength(5)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.ContactName).HasMaxLength(30)

            Me.Property(Function(t) t.ContactTitle).HasMaxLength(30)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.Phone).HasMaxLength(24)

            Me.Property(Function(t) t.Fax).HasMaxLength(24)

            ' Table & Column Mappings
            Me.ToTable("Customers")
            Me.Property(Function(t) t.CustomerID).HasColumnName("CustomerID")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.ContactName).HasColumnName("ContactName")
            Me.Property(Function(t) t.ContactTitle).HasColumnName("ContactTitle")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.Phone).HasColumnName("Phone")
            Me.Property(Function(t) t.Fax).HasColumnName("Fax")
            Me.HasMany(Function(x) x.Orders).WithOptional(Function(x) x.Customer).HasForeignKey(Function(x) x.CustomerID)
        End Sub
    End Class
End Namespace

' CustomerReportMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class CustomerReportMap
        Inherits EntityTypeConfiguration(Of CustomerReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.ProductName, Key t.CompanyName})

            ' Properties
            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("CustomerReports")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
        End Sub
    End Class
End Namespace

' EmployeeMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class EmployeeMap
        Inherits EntityTypeConfiguration(Of Employee)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.EmployeeID)

            ' Properties
            Me.Property(Function(t) t.EmployeeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.LastName).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.FirstName).IsRequired().HasMaxLength(10)

            Me.Property(Function(t) t.Title).HasMaxLength(30)

            Me.Property(Function(t) t.TitleOfCourtesy).HasMaxLength(25)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.HomePhone).HasMaxLength(24)

            Me.Property(Function(t) t.Extension).HasMaxLength(4)

            Me.Property(Function(t) t.Photo).HasMaxLength(2147483647)

            Me.Property(Function(t) t.Notes).HasMaxLength(1073741823)

            ' Table & Column Mappings
            Me.ToTable("Employees")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.LastName).HasColumnName("LastName")
            Me.Property(Function(t) t.FirstName).HasColumnName("FirstName")
            Me.Property(Function(t) t.Title).HasColumnName("Title")
            Me.Property(Function(t) t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy")
            Me.Property(Function(t) t.BirthDate).HasColumnName("BirthDate")
            Me.Property(Function(t) t.HireDate).HasColumnName("HireDate")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.HomePhone).HasColumnName("HomePhone")
            Me.Property(Function(t) t.Extension).HasColumnName("Extension")
            Me.Property(Function(t) t.Photo).HasColumnName("Photo")
            Me.Property(Function(t) t.Notes).HasColumnName("Notes")
            Me.Property(Function(t) t.ReportsTo).HasColumnName("ReportsTo")
            Me.Property(Function(t) t.GroupName).HasColumnName("GroupName")
            Me.HasMany(Function(x) x.Customers).WithMany(Function(x) x.Employees).Map(Sub(m)
                m.ToTable("EmployeeCustomers")
                m.MapLeftKey("EmployeeId")
                m.MapRightKey("CustomerId")
            End Sub)
            Me.HasMany(Function(x) x.Employees).WithOptional(Function(x) x.SubEmployee).HasForeignKey(Function(x) x.ReportsTo)
            Me.HasMany(Function(x) x.Orders).WithOptional(Function(x) x.Employee).HasForeignKey(Function(x) x.EmployeeID)
        End Sub
    End Class
End Namespace

' EmployeeTerritoryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class EmployeeTerritoryMap
        Inherits EntityTypeConfiguration(Of EmployeeTerritory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.EmployeeID, Key t.TerritoryID})

            ' Properties
            Me.Property(Function(t) t.EmployeeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.TerritoryID).IsRequired().HasMaxLength(20)

            ' Table & Column Mappings
            Me.ToTable("EmployeeTerritories")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.TerritoryID).HasColumnName("TerritoryID")
        End Sub
    End Class
End Namespace

' InvoiceMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class InvoiceMap
        Inherits EntityTypeConfiguration(Of Invoice)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.CustomerName, Key t.OrderID, Key t.ShipperName, Key t.ProductID, Key t.ProductName, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.ShipName).HasMaxLength(40)

            Me.Property(Function(t) t.ShipAddress).HasMaxLength(60)

            Me.Property(Function(t) t.ShipCity).HasMaxLength(15)

            Me.Property(Function(t) t.ShipRegion).HasMaxLength(15)

            Me.Property(Function(t) t.ShipPostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.ShipCountry).HasMaxLength(15)

            Me.Property(Function(t) t.CustomerID).IsFixedLength().HasMaxLength(5)

            Me.Property(Function(t) t.CustomerName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ShipperName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("Invoices")
            Me.Property(Function(t) t.ShipName).HasColumnName("ShipName")
            Me.Property(Function(t) t.ShipAddress).HasColumnName("ShipAddress")
            Me.Property(Function(t) t.ShipCity).HasColumnName("ShipCity")
            Me.Property(Function(t) t.ShipRegion).HasColumnName("ShipRegion")
            Me.Property(Function(t) t.ShipPostalCode).HasColumnName("ShipPostalCode")
            Me.Property(Function(t) t.ShipCountry).HasColumnName("ShipCountry")
            Me.Property(Function(t) t.CustomerID).HasColumnName("CustomerID")
            Me.Property(Function(t) t.CustomerName).HasColumnName("CustomerName")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
            Me.Property(Function(t) t.RequiredDate).HasColumnName("RequiredDate")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
            Me.Property(Function(t) t.ShipperName).HasColumnName("ShipperName")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
            Me.Property(Function(t) t.Freight).HasColumnName("Freight")
        End Sub
    End Class
End Namespace

' OrderDetailMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrderDetailMap
        Inherits EntityTypeConfiguration(Of OrderDetail)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.ProductID, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("OrderDetails")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrderDetailsExtendedMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrderDetailsExtendedMap
        Inherits EntityTypeConfiguration(Of OrderDetailsExtended)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.ProductID, Key t.ProductName, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("OrderDetailsExtended")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrderMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrderMap
        Inherits EntityTypeConfiguration(Of Order)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CustomerID).IsFixedLength().HasMaxLength(5)

            Me.Property(Function(t) t.ShipName).HasMaxLength(40)

            Me.Property(Function(t) t.ShipAddress).HasMaxLength(60)

            Me.Property(Function(t) t.ShipCity).HasMaxLength(15)

            Me.Property(Function(t) t.ShipRegion).HasMaxLength(15)

            Me.Property(Function(t) t.ShipPostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.ShipCountry).HasMaxLength(15)

            ' Table & Column Mappings
            Me.ToTable("Orders")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.CustomerID).HasColumnName("CustomerID")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
            Me.Property(Function(t) t.RequiredDate).HasColumnName("RequiredDate")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
            Me.Property(Function(t) t.ShipVia).HasColumnName("ShipVia")
            Me.Property(Function(t) t.Freight).HasColumnName("Freight")
            Me.Property(Function(t) t.ShipName).HasColumnName("ShipName")
            Me.Property(Function(t) t.ShipAddress).HasColumnName("ShipAddress")
            Me.Property(Function(t) t.ShipCity).HasColumnName("ShipCity")
            Me.Property(Function(t) t.ShipRegion).HasColumnName("ShipRegion")
            Me.Property(Function(t) t.ShipPostalCode).HasColumnName("ShipPostalCode")
            Me.Property(Function(t) t.ShipCountry).HasColumnName("ShipCountry")
            Me.HasMany(Function(x) x.OrderDetails).WithRequired(Function(x) x.Order).HasForeignKey(Function(x) x.OrderID)
        End Sub
    End Class
End Namespace

' OrderReportMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrderReportMap
        Inherits EntityTypeConfiguration(Of OrderReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.ProductID, Key t.ProductName, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("OrderReports")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' OrdersQryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrdersQryMap
        Inherits EntityTypeConfiguration(Of OrdersQry)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.CompanyName})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CustomerID).IsFixedLength().HasMaxLength(5)

            Me.Property(Function(t) t.ShipName).HasMaxLength(40)

            Me.Property(Function(t) t.ShipAddress).HasMaxLength(60)

            Me.Property(Function(t) t.ShipCity).HasMaxLength(15)

            Me.Property(Function(t) t.ShipRegion).HasMaxLength(15)

            Me.Property(Function(t) t.ShipPostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.ShipCountry).HasMaxLength(15)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            ' Table & Column Mappings
            Me.ToTable("OrdersQry")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.CustomerID).HasColumnName("CustomerID")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
            Me.Property(Function(t) t.RequiredDate).HasColumnName("RequiredDate")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
            Me.Property(Function(t) t.ShipVia).HasColumnName("ShipVia")
            Me.Property(Function(t) t.Freight).HasColumnName("Freight")
            Me.Property(Function(t) t.ShipName).HasColumnName("ShipName")
            Me.Property(Function(t) t.ShipAddress).HasColumnName("ShipAddress")
            Me.Property(Function(t) t.ShipCity).HasColumnName("ShipCity")
            Me.Property(Function(t) t.ShipRegion).HasColumnName("ShipRegion")
            Me.Property(Function(t) t.ShipPostalCode).HasColumnName("ShipPostalCode")
            Me.Property(Function(t) t.ShipCountry).HasColumnName("ShipCountry")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
        End Sub
    End Class
End Namespace

' OrderSubtotalMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class OrderSubtotalMap
        Inherits EntityTypeConfiguration(Of OrderSubtotal)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("OrderSubtotals")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' PreviousEmployeeMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class PreviousEmployeeMap
        Inherits EntityTypeConfiguration(Of PreviousEmployee)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.EmployeeID)

            ' Properties
            Me.Property(Function(t) t.EmployeeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.LastName).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.FirstName).IsRequired().HasMaxLength(10)

            Me.Property(Function(t) t.Title).HasMaxLength(30)

            Me.Property(Function(t) t.TitleOfCourtesy).HasMaxLength(25)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.HomePhone).HasMaxLength(24)

            Me.Property(Function(t) t.Extension).HasMaxLength(4)

            Me.Property(Function(t) t.Photo).HasMaxLength(2147483647)

            Me.Property(Function(t) t.Notes).HasMaxLength(2147483647)

            Me.Property(Function(t) t.PhotoPath).HasMaxLength(255)

            ' Table & Column Mappings
            Me.ToTable("PreviousEmployees")
            Me.Property(Function(t) t.EmployeeID).HasColumnName("EmployeeID")
            Me.Property(Function(t) t.LastName).HasColumnName("LastName")
            Me.Property(Function(t) t.FirstName).HasColumnName("FirstName")
            Me.Property(Function(t) t.Title).HasColumnName("Title")
            Me.Property(Function(t) t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy")
            Me.Property(Function(t) t.BirthDate).HasColumnName("BirthDate")
            Me.Property(Function(t) t.HireDate).HasColumnName("HireDate")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.HomePhone).HasColumnName("HomePhone")
            Me.Property(Function(t) t.Extension).HasColumnName("Extension")
            Me.Property(Function(t) t.Photo).HasColumnName("Photo")
            Me.Property(Function(t) t.Notes).HasColumnName("Notes")
            Me.Property(Function(t) t.PhotoPath).HasColumnName("PhotoPath")
        End Sub
    End Class
End Namespace

' ProductMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ProductMap
        Inherits EntityTypeConfiguration(Of Product)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductID)

            ' Properties
            Me.Property(Function(t) t.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.QuantityPerUnit).HasMaxLength(20)

            Me.Property(Function(t) t.EAN13).HasMaxLength(2147483647)

            ' Table & Column Mappings
            Me.ToTable("Products")
            Me.Property(Function(t) t.ProductID).HasColumnName("ProductID")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.SupplierID).HasColumnName("SupplierID")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.QuantityPerUnit).HasColumnName("QuantityPerUnit")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.UnitsInStock).HasColumnName("UnitsInStock")
            Me.Property(Function(t) t.UnitsOnOrder).HasColumnName("UnitsOnOrder")
            Me.Property(Function(t) t.ReorderLevel).HasColumnName("ReorderLevel")
            Me.Property(Function(t) t.Discontinued).HasColumnName("Discontinued")
            Me.Property(Function(t) t.EAN13).HasColumnName("EAN13")
            Me.HasOptional(Function(p) p.Category).WithMany(Function(c) c.Products).HasForeignKey(Function(p) p.CategoryID)
        End Sub
    End Class
End Namespace

' ProductReportMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ProductReportMap
        Inherits EntityTypeConfiguration(Of ProductReport)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.CategoryName, Key t.ProductName, Key t.ShippedDate})

            ' Properties
            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("ProductReports")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.ProductSales).HasColumnName("ProductSales")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
        End Sub
    End Class
End Namespace

' ProductsAboveAveragePriceMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ProductsAboveAveragePriceMap
        Inherits EntityTypeConfiguration(Of ProductsAboveAveragePrice)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.ProductName)

            ' Properties
            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("ProductsAboveAveragePrice")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
        End Sub
    End Class
End Namespace

' ProductsByCategoryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ProductsByCategoryMap
        Inherits EntityTypeConfiguration(Of ProductsByCategory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.CategoryName, Key t.ProductName, Key t.Discontinued})

            ' Properties
            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.QuantityPerUnit).HasMaxLength(20)

            ' Table & Column Mappings
            Me.ToTable("ProductsByCategory")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.QuantityPerUnit).HasColumnName("QuantityPerUnit")
            Me.Property(Function(t) t.UnitsInStock).HasColumnName("UnitsInStock")
            Me.Property(Function(t) t.Discontinued).HasColumnName("Discontinued")
        End Sub
    End Class
End Namespace

' RegionMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class RegionMap
        Inherits EntityTypeConfiguration(Of Region)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.RegionID)

            ' Properties
            Me.Property(Function(t) t.RegionID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.RegionDescription).IsRequired().IsFixedLength().HasMaxLength(50)

            ' Table & Column Mappings
            Me.ToTable("Region")
            Me.Property(Function(t) t.RegionID).HasColumnName("RegionID")
            Me.Property(Function(t) t.RegionDescription).HasColumnName("RegionDescription")
        End Sub
    End Class
End Namespace

' SalesByCategoryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SalesByCategoryMap
        Inherits EntityTypeConfiguration(Of SalesByCategory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.CategoryID)

            ' Properties
            Me.Property(Function(t) t.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("SalesByCategory")
            Me.Property(Function(t) t.CategoryID).HasColumnName("CategoryID")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
        End Sub
    End Class
End Namespace

' SalesPersonMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SalesPersonMap
        Inherits EntityTypeConfiguration(Of SalesPerson)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.FirstName, Key t.LastName, Key t.ProductName, Key t.CategoryName, Key t.UnitPrice, Key t.Quantity, Key t.Discount})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.FirstName).IsRequired().HasMaxLength(10)

            Me.Property(Function(t) t.LastName).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.ProductName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.CategoryName).IsRequired().HasMaxLength(15)

            Me.Property(Function(t) t.UnitPrice).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.Quantity).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("SalesPerson")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.FirstName).HasColumnName("FirstName")
            Me.Property(Function(t) t.LastName).HasColumnName("LastName")
            Me.Property(Function(t) t.ProductName).HasColumnName("ProductName")
            Me.Property(Function(t) t.CategoryName).HasColumnName("CategoryName")
            Me.Property(Function(t) t.OrderDate).HasColumnName("OrderDate")
            Me.Property(Function(t) t.UnitPrice).HasColumnName("UnitPrice")
            Me.Property(Function(t) t.Quantity).HasColumnName("Quantity")
            Me.Property(Function(t) t.Discount).HasColumnName("Discount")
        End Sub
    End Class
End Namespace

' SalesTotalsByAmountMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SalesTotalsByAmountMap
        Inherits EntityTypeConfiguration(Of SalesTotalsByAmount)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.OrderID, Key t.CompanyName})

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            ' Table & Column Mappings
            Me.ToTable("SalesTotalsByAmount")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
        End Sub
    End Class
End Namespace

' ShipperMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class ShipperMap
        Inherits EntityTypeConfiguration(Of Shipper)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) New With {Key t.ShipperID, Key t.CompanyName})

            ' Properties
            Me.Property(Function(t) t.ShipperID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.Phone).HasMaxLength(24)

            ' Table & Column Mappings
            Me.ToTable("Shippers")
            Me.Property(Function(t) t.ShipperID).HasColumnName("ShipperID")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.Phone).HasColumnName("Phone")
        End Sub
    End Class
End Namespace

' SummaryOfSalesByQuarterMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SummaryOfSalesByQuarterMap
        Inherits EntityTypeConfiguration(Of SummaryOfSalesByQuarter)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("SummaryOfSalesByQuarter")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' SummaryOfSalesByYearMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SummaryOfSalesByYearMap
        Inherits EntityTypeConfiguration(Of SummaryOfSalesByYear)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.OrderID)

            ' Properties
            Me.Property(Function(t) t.OrderID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("SummaryOfSalesByYear")
            Me.Property(Function(t) t.ShippedDate).HasColumnName("ShippedDate")
            Me.Property(Function(t) t.OrderID).HasColumnName("OrderID")
        End Sub
    End Class
End Namespace

' SupplierMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class SupplierMap
        Inherits EntityTypeConfiguration(Of Supplier)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.SupplierID)

            ' Properties
            Me.Property(Function(t) t.SupplierID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            Me.Property(Function(t) t.CompanyName).IsRequired().HasMaxLength(40)

            Me.Property(Function(t) t.ContactName).HasMaxLength(30)

            Me.Property(Function(t) t.ContactTitle).HasMaxLength(30)

            Me.Property(Function(t) t.Address).HasMaxLength(60)

            Me.Property(Function(t) t.City).HasMaxLength(15)

            Me.Property(Function(t) t.Region).HasMaxLength(15)

            Me.Property(Function(t) t.PostalCode).HasMaxLength(10)

            Me.Property(Function(t) t.Country).HasMaxLength(15)

            Me.Property(Function(t) t.Phone).HasMaxLength(24)

            Me.Property(Function(t) t.Fax).HasMaxLength(24)

            Me.Property(Function(t) t.HomePage).HasMaxLength(1073741823)

            ' Table & Column Mappings
            Me.ToTable("Suppliers")
            Me.Property(Function(t) t.SupplierID).HasColumnName("SupplierID")
            Me.Property(Function(t) t.CompanyName).HasColumnName("CompanyName")
            Me.Property(Function(t) t.ContactName).HasColumnName("ContactName")
            Me.Property(Function(t) t.ContactTitle).HasColumnName("ContactTitle")
            Me.Property(Function(t) t.Address).HasColumnName("Address")
            Me.Property(Function(t) t.City).HasColumnName("City")
            Me.Property(Function(t) t.Region).HasColumnName("Region")
            Me.Property(Function(t) t.PostalCode).HasColumnName("PostalCode")
            Me.Property(Function(t) t.Country).HasColumnName("Country")
            Me.Property(Function(t) t.Phone).HasColumnName("Phone")
            Me.Property(Function(t) t.Fax).HasColumnName("Fax")
            Me.Property(Function(t) t.HomePage).HasColumnName("HomePage")
        End Sub
    End Class
End Namespace

' TerritoryMap.cs

Namespace DevExpress.DemoData.Models.Mapping
    Public Class TerritoryMap
        Inherits EntityTypeConfiguration(Of Territory)

        Public Sub New()
            ' Primary Key
            Me.HasKey(Function(t) t.TerritoryID)

            ' Properties
            Me.Property(Function(t) t.TerritoryID).IsRequired().HasMaxLength(20)

            Me.Property(Function(t) t.TerritoryDescription).IsRequired().IsFixedLength().HasMaxLength(50)

            Me.Property(Function(t) t.RegionID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)

            ' Table & Column Mappings
            Me.ToTable("Territories")
            Me.Property(Function(t) t.TerritoryID).HasColumnName("TerritoryID")
            Me.Property(Function(t) t.TerritoryDescription).HasColumnName("TerritoryDescription")
            Me.Property(Function(t) t.RegionID).HasColumnName("RegionID")
        End Sub
    End Class
End Namespace
