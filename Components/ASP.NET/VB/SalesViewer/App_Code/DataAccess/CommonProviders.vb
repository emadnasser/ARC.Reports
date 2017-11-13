Imports System
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Diagnostics
Imports System.Linq
Imports System.Web
Imports System.Web.Caching
Imports SalesDataContext = DataContext.SalesDataContext

Namespace DataAccess
    Public MustInherit Class BaseEntity
    End Class

    Public MustInherit Class BaseProvider(Of T As BaseEntity)
        Implements IDisposable

        Public ReadOnly Property DataTable() As Table(Of T)
            Get
                Return DataContext.GetTable(Of T)()
            End Get
        End Property
        Private privateDataContext As DataContext.SalesDataContext
        Protected Property DataContext() As DataContext.SalesDataContext
            Get
                Return privateDataContext
            End Get
            Private Set(ByVal value As DataContext.SalesDataContext)
                privateDataContext = value
            End Set
        End Property
        Private ReadOnly Property Cache() As Cache
            Get
                Return System.Web.HttpContext.Current.Cache
            End Get
        End Property

        Public Sub New()
            DataContext = New SalesDataContext()
            DataContext.ObjectTrackingEnabled = False
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            If DataContext IsNot Nothing Then
                DataContext.Dispose()
            End If
        End Sub

        Protected Function TryGetResult(Of TResult)(ByVal func As Func(Of TResult), Optional ByVal useCache As Boolean = False, Optional ByVal keySuffix As Object = Nothing, Optional ByVal nonExpireCache As Boolean = False) As TResult
            Dim result As TResult = Nothing
            If useCache Then
                Dim key As String = String.Format("{0}.{1}.{2}", Me.GetType().Name, func.Method.Name, If(keySuffix, ""))
                If Cache(key) IsNot Nothing Then
                    result = DirectCast(Cache(key), TResult)
                Else
                    result = func()
                    Dim expirationDate As Date = If(nonExpireCache, Date.MaxValue, DateTimeHelper.GetIntervalEndDate(Date.Now, SelectionInterval.Day))
                    Cache.Insert(key, result, Nothing, expirationDate, TimeSpan.Zero)
                End If
            Else
                result = func()
            End If
            Return result
        End Function
    End Class

    Public Class CustomersProvider
        Inherits BaseProvider(Of DataContext.Customer)

        Public Function GetList() As IEnumerable(Of Customer)
            Return TryGetResult(Of IEnumerable(Of Customer))(Function() (
                From c In DataTable
                Select New Customer With {.Id = c.Id, .Name = c.FullName, .Address = c.Address, .City = c.City.Name, .Fax = c.Fax, .PostalCode = c.Zip, .State = c.City.State, .Phone = c.Phone}).OrderBy(Function(c) c.Name).ToList(), useCache:= True, nonExpireCache:= True)
        End Function
        Public Function GetCustomerLocation(ByVal customerId As Integer) As Location
            Return TryGetResult(Of Location)(Function() (
                From c In DataTable
                Where c.Id = customerId
                Select New Location() With {.Latitude = c.City.Latitude, .Longitude = c.City.Longitude}).FirstOrDefault(), useCache:= True, keySuffix:= customerId, nonExpireCache:= True)
        End Function
    End Class
    Public Class ProductsProvider
        Inherits BaseProvider(Of DataContext.Product)

        Public Function GetList() As IEnumerable(Of Product)
            Return TryGetResult(Of IEnumerable(Of Product))(Function() (
                From p In DataTable
                Select New Product With {.Id = p.Id, .Name = p.Name, .BaseCost = p.BaseCost, .Description = p.Description, .ListPrice = p.ListPrice, .UnitsInInventory = p.UnitsInInventory, .UnitsInManufacturing = p.UnitsInManufacturing}).OrderBy(Function(p) p.Name).ToList(), useCache:= True, nonExpireCache:= True)
        End Function
        Public Function GetProjectManager(ByVal productId As Integer) As Contact
            Return TryGetResult(Of Contact)(Function() DataTable.Where(Function(p) p.Id = productId).Select(Function(c) New Contact() With {.Address = c.ProjectManager.Address, .City = c.ProjectManager.City.Name, .Email = c.ProjectManager.Email, .FullName = c.ProjectManager.FullName, .State = c.ProjectManager.City.State, .Zip = c.ProjectManager.Zip, .Phone = c.ProjectManager.Phone}).FirstOrDefault(), useCache:= True, keySuffix:= productId, nonExpireCache:= True)
        End Function
        Public Function GetSupportManager(ByVal productId As Integer) As Contact
            Return TryGetResult(Of Contact)(Function() DataTable.Where(Function(p) p.Id = productId).Select(Function(c) New Contact() With {.Address = c.SupportManager.Address, .City = c.SupportManager.City.Name, .Email = c.SupportManager.Email, .FullName = c.SupportManager.FullName, .State = c.SupportManager.City.State, .Zip = c.SupportManager.Zip, .Phone = c.SupportManager.Phone}).FirstOrDefault(), useCache:= True, keySuffix:= productId, nonExpireCache:= True)
        End Function
        Public Function GetPlant(ByVal productId As Integer) As Plant
            Return TryGetResult(Of Plant)(Function() DataTable.Where(Function(x) x.Id = productId).Select(Function(x) New Plant() With {.Address = x.Plant.Address, .City = x.Plant.City.Name, .Name = x.Plant.Name, .State = x.Plant.City.State, .Zip = x.Plant.Zip}).FirstOrDefault(), useCache:= True, keySuffix:= productId, nonExpireCache:= True)
        End Function
    End Class
    #Region "Data Transfer Objects"
    Public Class Customer
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property PostalCode() As String
        Public Property State() As String
        Public Property Fax() As String
        Public Property Phone() As String
    End Class

    Public Class Product
        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Description() As String
        Public Property BaseCost() As Double
        Public Property ListPrice() As Double
        Public Property UnitsInInventory() As Integer
        Public Property UnitsInManufacturing() As Integer
    End Class
    Public Class Contact
        Public Property FullName() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property State() As String
        Public Property Zip() As String
        Public Property Email() As String
        Public Property Phone() As String
    End Class
    Public Class Plant
        Public Property Name() As String
        Public Property Address() As String
        Public Property City() As String
        Public Property State() As String
        Public Property Zip() As String
    End Class
    Public Class Location
        Public Property Latitude() As Double
        Public Property Longitude() As Double
    End Class
    #End Region
End Namespace
