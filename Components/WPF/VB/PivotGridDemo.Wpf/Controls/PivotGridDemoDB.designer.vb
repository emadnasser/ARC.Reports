Imports System
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Linq
Imports System.Reflection
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Linq.Mapping
Imports System.Data.Linq

'#pragma warning disable 1591

Namespace PivotGridDemo.Controls


 <Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="PivotGridDemoDB")>
 Partial Public Class PivotGridDemoDBDataContext
     Inherits System.Data.Linq.DataContext

  Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertCategory(ByVal instance As Category)
    End Sub
    Partial Private Sub UpdateCategory(ByVal instance As Category)
    End Sub
    Partial Private Sub DeleteCategory(ByVal instance As Category)
    End Sub
    Partial Private Sub InsertSalesPerson(ByVal instance As SalesPerson)
    End Sub
    Partial Private Sub UpdateSalesPerson(ByVal instance As SalesPerson)
    End Sub
    Partial Private Sub DeleteSalesPerson(ByVal instance As SalesPerson)
    End Sub
    Partial Private Sub InsertCustomer(ByVal instance As Customer)
    End Sub
    Partial Private Sub UpdateCustomer(ByVal instance As Customer)
    End Sub
    Partial Private Sub DeleteCustomer(ByVal instance As Customer)
    End Sub
    Partial Private Sub InsertOrder(ByVal instance As Order)
    End Sub
    Partial Private Sub UpdateOrder(ByVal instance As Order)
    End Sub
    Partial Private Sub DeleteOrder(ByVal instance As Order)
    End Sub
    Partial Private Sub InsertProduct(ByVal instance As Product)
    End Sub
    Partial Private Sub UpdateProduct(ByVal instance As Product)
    End Sub
    Partial Private Sub DeleteProduct(ByVal instance As Product)
    End Sub
    Partial Private Sub InsertSale(ByVal instance As Sale)
    End Sub
    Partial Private Sub UpdateSale(ByVal instance As Sale)
    End Sub
    Partial Private Sub DeleteSale(ByVal instance As Sale)
    End Sub
    #End Region

  Public Sub New(ByVal connection As String)
      MyBase.New(connection, mappingSource)
   OnCreated()
  End Sub

  Public Sub New(ByVal connection As System.Data.IDbConnection)
      MyBase.New(connection, mappingSource)
   OnCreated()
  End Sub

  Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
      MyBase.New(connection, mappingSource)
   OnCreated()
  End Sub

  Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
      MyBase.New(connection, mappingSource)
   OnCreated()
  End Sub

  Public ReadOnly Property Categories() As System.Data.Linq.Table(Of Category)
   Get
    Return Me.GetTable(Of Category)()
   End Get
  End Property

  Public ReadOnly Property SalesPersons() As System.Data.Linq.Table(Of SalesPerson)
   Get
    Return Me.GetTable(Of SalesPerson)()
   End Get
  End Property

  Public ReadOnly Property Customers() As System.Data.Linq.Table(Of Customer)
   Get
    Return Me.GetTable(Of Customer)()
   End Get
  End Property

  Public ReadOnly Property Orders() As System.Data.Linq.Table(Of Order)
   Get
    Return Me.GetTable(Of Order)()
   End Get
  End Property

  Public ReadOnly Property Products() As System.Data.Linq.Table(Of Product)
   Get
    Return Me.GetTable(Of Product)()
   End Get
  End Property

  Public ReadOnly Property Sales() As System.Data.Linq.Table(Of Sale)
   Get
    Return Me.GetTable(Of Sale)()
   End Get
  End Property
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Categories")>
 Partial Public Class Category
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _CategoryName As String

  Private _Products As EntitySet(Of Product)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCategoryIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnCategoryIDChanged()
    End Sub
    Partial Private Sub OnCategoryNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnCategoryNameChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Products = New EntitySet(Of Product)(New Action(Of Product)(AddressOf Me.attach_Products), New Action(Of Product)(AddressOf Me.detach_Products))
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property CategoryID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnCategoryIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("CategoryID")
     Me.OnCategoryIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryName", DbType:="NVarChar(100)")>
  Public Property CategoryName() As String
   Get
    Return Me._CategoryName
   End Get
   Set(ByVal value As String)
    If (Me._CategoryName <> value) Then
     Me.OnCategoryNameChanging(value)
     Me.SendPropertyChanging()
     Me._CategoryName = value
     Me.SendPropertyChanged("CategoryName")
     Me.OnCategoryNameChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Category_Product", Storage:="_Products", ThisKey:="CategoryID", OtherKey:="CategoryID")>
  Public Property Products() As EntitySet(Of Product)
   Get
    Return Me._Products
   End Get
   Set(ByVal value As EntitySet(Of Product))
    Me._Products.Assign(value)
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Private Sub attach_Products(ByVal entity As Product)
   Me.SendPropertyChanging()
   entity.Category = Me
  End Sub

  Private Sub detach_Products(ByVal entity As Product)
   Me.SendPropertyChanging()
   entity.Category = Nothing
  End Sub
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.SalesPeople")>
 Partial Public Class SalesPerson
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _SalesPersonName As String

  Private _Orders As EntitySet(Of Order)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSalesPersonIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnSalesPersonIDChanged()
    End Sub
    Partial Private Sub OnSalesPersonNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnSalesPersonNameChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Orders = New EntitySet(Of Order)(New Action(Of Order)(AddressOf Me.attach_Orders), New Action(Of Order)(AddressOf Me.detach_Orders))
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property SalesPersonID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnSalesPersonIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("SalesPersonID")
     Me.OnSalesPersonIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SalesPersonName", DbType:="NVarChar(100)")>
  Public Property SalesPersonName() As String
   Get
    Return Me._SalesPersonName
   End Get
   Set(ByVal value As String)
    If (Me._SalesPersonName <> value) Then
     Me.OnSalesPersonNameChanging(value)
     Me.SendPropertyChanging()
     Me._SalesPersonName = value
     Me.SendPropertyChanged("SalesPersonName")
     Me.OnSalesPersonNameChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="SalesPeople_Order", Storage:="_Orders", ThisKey:="SalesPersonID", OtherKey:="SalesPersonID")>
  Public Property Orders() As EntitySet(Of Order)
   Get
    Return Me._Orders
   End Get
   Set(ByVal value As EntitySet(Of Order))
    Me._Orders.Assign(value)
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Private Sub attach_Orders(ByVal entity As Order)
   Me.SendPropertyChanging()
   entity.SalesPerson = Me
  End Sub

  Private Sub detach_Orders(ByVal entity As Order)
   Me.SendPropertyChanging()
   entity.SalesPerson = Nothing
  End Sub
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Customers")>
 Partial Public Class Customer
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _CustomerName As String

  Private _Orders As EntitySet(Of Order)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCustomerIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnCustomerNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnCustomerNameChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Orders = New EntitySet(Of Order)(New Action(Of Order)(AddressOf Me.attach_Orders), New Action(Of Order)(AddressOf Me.detach_Orders))
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property CustomerID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnCustomerIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("CustomerID")
     Me.OnCustomerIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomerName", DbType:="NVarChar(100)")>
  Public Property CustomerName() As String
   Get
    Return Me._CustomerName
   End Get
   Set(ByVal value As String)
    If (Me._CustomerName <> value) Then
     Me.OnCustomerNameChanging(value)
     Me.SendPropertyChanging()
     Me._CustomerName = value
     Me.SendPropertyChanged("CustomerName")
     Me.OnCustomerNameChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Orders", ThisKey:="CustomerID", OtherKey:="CustomerID")>
  Public Property Orders() As EntitySet(Of Order)
   Get
    Return Me._Orders
   End Get
   Set(ByVal value As EntitySet(Of Order))
    Me._Orders.Assign(value)
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Private Sub attach_Orders(ByVal entity As Order)
   Me.SendPropertyChanging()
   entity.Customer = Me
  End Sub

  Private Sub detach_Orders(ByVal entity As Order)
   Me.SendPropertyChanging()
   entity.Customer = Nothing
  End Sub
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Orders")>
 Partial Public Class Order
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _SalesPerson? As Integer

  Private _Customer? As Integer

  Private _OrderDate? As Date

  Private _Sales As EntitySet(Of Sale)

  Private _Customer1 As EntityRef(Of Customer)

  Private _SalesPeople As EntityRef(Of SalesPerson)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnSalesPersonIDChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnSalesPersonIDChanged()
    End Sub
    Partial Private Sub OnCustomerIDChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnCustomerIDChanged()
    End Sub
    Partial Private Sub OnOrderDateChanging(ByVal value? As Date)
    End Sub
    Partial Private Sub OnOrderDateChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Sales = New EntitySet(Of Sale)(New Action(Of Sale)(AddressOf Me.attach_Sales), New Action(Of Sale)(AddressOf Me.detach_Sales))
   Me._Customer1 = Nothing
   Me._SalesPeople = Nothing
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property OrderID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnOrderIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("OrderID")
     Me.OnOrderIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="SalesPerson", Storage:="_SalesPerson", DbType:="Int")>
  Public Property SalesPersonID() As Integer?
   Get
    Return Me._SalesPerson
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._SalesPerson.Equals(value)) Then
     Me.OnSalesPersonIDChanging(value)
     Me.SendPropertyChanging()
     Me._SalesPerson = value
     Me.SendPropertyChanged("SalesPersonID")
     Me.OnSalesPersonIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Customer", Storage:="_Customer", DbType:="Int")>
  Public Property CustomerID() As Integer?
   Get
    Return Me._Customer
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._Customer.Equals(value)) Then
     Me.OnCustomerIDChanging(value)
     Me.SendPropertyChanging()
     Me._Customer = value
     Me.SendPropertyChanged("CustomerID")
     Me.OnCustomerIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderDate", DbType:="DateTime")>
  Public Property OrderDate() As Date?
   Get
    Return Me._OrderDate
   End Get
   Set(ByVal value? As Date)
    If (Not Me._OrderDate.Equals(value)) Then
     Me.OnOrderDateChanging(value)
     Me.SendPropertyChanging()
     Me._OrderDate = value
     Me.SendPropertyChanged("OrderDate")
     Me.OnOrderDateChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_Sale", Storage:="_Sales", ThisKey:="OrderID", OtherKey:="OrderID")>
  Public Property Sales() As EntitySet(Of Sale)
   Get
    Return Me._Sales
   End Get
   Set(ByVal value As EntitySet(Of Sale))
    Me._Sales.Assign(value)
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Customer_Order", Storage:="_Customer1", ThisKey:="CustomerID", OtherKey:="CustomerID", IsForeignKey:=True)>
  Public Property Customer() As Customer
   Get
    Return Me._Customer1.Entity
   End Get
   Set(ByVal value As Customer)
    Dim previousValue As Customer = Me._Customer1.Entity
    If ((previousValue IsNot value) OrElse (Me._Customer1.HasLoadedOrAssignedValue = False)) Then
     Me.SendPropertyChanging()
     If (previousValue IsNot Nothing) Then
      Me._Customer1.Entity = Nothing
      previousValue.Orders.Remove(Me)
     End If
     Me._Customer1.Entity = value
     If (value IsNot Nothing) Then
      value.Orders.Add(Me)
      Me._Customer = value.CustomerID
     Else
      Me._Customer = Nothing
     End If
     Me.SendPropertyChanged("Customer")
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="SalesPeople_Order", Storage:="_SalesPeople", ThisKey:="SalesPersonID", OtherKey:="SalesPersonID", IsForeignKey:=True)>
  Public Property SalesPerson() As SalesPerson
   Get
    Return Me._SalesPeople.Entity
   End Get
   Set(ByVal value As SalesPerson)
    Dim previousValue As SalesPerson = Me._SalesPeople.Entity
    If ((previousValue IsNot value) OrElse (Me._SalesPeople.HasLoadedOrAssignedValue = False)) Then
     Me.SendPropertyChanging()
     If (previousValue IsNot Nothing) Then
      Me._SalesPeople.Entity = Nothing
      previousValue.Orders.Remove(Me)
     End If
     Me._SalesPeople.Entity = value
     If (value IsNot Nothing) Then
      value.Orders.Add(Me)
      Me._SalesPerson = value.SalesPersonID
     Else
      Me._SalesPerson = Nothing
     End If
     Me.SendPropertyChanged("SalesPerson")
    End If
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Private Sub attach_Sales(ByVal entity As Sale)
   Me.SendPropertyChanging()
   entity.Order = Me
  End Sub

  Private Sub detach_Sales(ByVal entity As Sale)
   Me.SendPropertyChanging()
   entity.Order = Nothing
  End Sub
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Products")>
 Partial Public Class Product
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _ProductName As String

  Private _Category? As Integer

  Private _Sales As EntitySet(Of Sale)

  Private _Category1 As EntityRef(Of Category)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnProductIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnProductIDChanged()
    End Sub
    Partial Private Sub OnProductNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnProductNameChanged()
    End Sub
    Partial Private Sub OnCategoryIDChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnCategoryIDChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Sales = New EntitySet(Of Sale)(New Action(Of Sale)(AddressOf Me.attach_Sales), New Action(Of Sale)(AddressOf Me.detach_Sales))
   Me._Category1 = Nothing
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property ProductID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnProductIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("ProductID")
     Me.OnProductIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(100)")>
  Public Property ProductName() As String
   Get
    Return Me._ProductName
   End Get
   Set(ByVal value As String)
    If (Me._ProductName <> value) Then
     Me.OnProductNameChanging(value)
     Me.SendPropertyChanging()
     Me._ProductName = value
     Me.SendPropertyChanged("ProductName")
     Me.OnProductNameChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Category", Storage:="_Category", DbType:="Int")>
  Public Property CategoryID() As Integer?
   Get
    Return Me._Category
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._Category.Equals(value)) Then
     Me.OnCategoryIDChanging(value)
     Me.SendPropertyChanging()
     Me._Category = value
     Me.SendPropertyChanged("CategoryID")
     Me.OnCategoryIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Product_Sale", Storage:="_Sales", ThisKey:="ProductID", OtherKey:="ProductID")>
  Public Property Sales() As EntitySet(Of Sale)
   Get
    Return Me._Sales
   End Get
   Set(ByVal value As EntitySet(Of Sale))
    Me._Sales.Assign(value)
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Category_Product", Storage:="_Category1", ThisKey:="CategoryID", OtherKey:="CategoryID", IsForeignKey:=True)>
  Public Property Category() As Category
   Get
    Return Me._Category1.Entity
   End Get
   Set(ByVal value As Category)
    Dim previousValue As Category = Me._Category1.Entity
    If ((previousValue IsNot value) OrElse (Me._Category1.HasLoadedOrAssignedValue = False)) Then
     Me.SendPropertyChanging()
     If (previousValue IsNot Nothing) Then
      Me._Category1.Entity = Nothing
      previousValue.Products.Remove(Me)
     End If
     Me._Category1.Entity = value
     If (value IsNot Nothing) Then
      value.Products.Add(Me)
      Me._Category = value.CategoryID
     Else
      Me._Category = Nothing
     End If
     Me.SendPropertyChanged("Category")
    End If
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub

  Private Sub attach_Sales(ByVal entity As Sale)
   Me.SendPropertyChanging()
   entity.Product = Me
  End Sub

  Private Sub detach_Sales(ByVal entity As Sale)
   Me.SendPropertyChanging()
   entity.Product = Nothing
  End Sub
 End Class

 <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Sales")>
 Partial Public Class Sale
     Implements INotifyPropertyChanging, INotifyPropertyChanged

  Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

  Private _OID As Integer

  Private _Order? As Integer

  Private _Product? As Integer

  Private _Quantity? As Integer

  Private _UnitPrice? As Decimal

  Private _Order1 As EntityRef(Of Order)

  Private _Product1 As EntityRef(Of Product)

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSaleIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnSaleIDChanged()
    End Sub
    Partial Private Sub OnOrderIDChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnOrderIDChanged()
    End Sub
    Partial Private Sub OnProductIDChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnProductIDChanged()
    End Sub
    Partial Private Sub OnQuantityChanging(ByVal value? As Integer)
    End Sub
    Partial Private Sub OnQuantityChanged()
    End Sub
    Partial Private Sub OnUnitPriceChanging(ByVal value? As Decimal)
    End Sub
    Partial Private Sub OnUnitPriceChanged()
    End Sub
    #End Region

  Public Sub New()
   Me._Order1 = Nothing
   Me._Product1 = Nothing
   OnCreated()
  End Sub

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="OID", Storage:="_OID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
  Public Property SaleID() As Integer
   Get
    Return Me._OID
   End Get
   Set(ByVal value As Integer)
    If (Me._OID <> value) Then
     Me.OnSaleIDChanging(value)
     Me.SendPropertyChanging()
     Me._OID = value
     Me.SendPropertyChanged("SaleID")
     Me.OnSaleIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Order]", Storage:="_Order", DbType:="Int")>
  Public Property OrderID() As Integer?
   Get
    Return Me._Order
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._Order.Equals(value)) Then
     Me.OnOrderIDChanging(value)
     Me.SendPropertyChanging()
     Me._Order = value
     Me.SendPropertyChanged("OrderID")
     Me.OnOrderIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Product", Storage:="_Product", DbType:="Int")>
  Public Property ProductID() As Integer?
   Get
    Return Me._Product
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._Product.Equals(value)) Then
     Me.OnProductIDChanging(value)
     Me.SendPropertyChanging()
     Me._Product = value
     Me.SendPropertyChanged("ProductID")
     Me.OnProductIDChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Quantity", DbType:="Int")>
  Public Property Quantity() As Integer?
   Get
    Return Me._Quantity
   End Get
   Set(ByVal value? As Integer)
    If (Not Me._Quantity.Equals(value)) Then
     Me.OnQuantityChanging(value)
     Me.SendPropertyChanging()
     Me._Quantity = value
     Me.SendPropertyChanged("Quantity")
     Me.OnQuantityChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UnitPrice", DbType:="Money")>
  Public Property UnitPrice() As Decimal?
   Get
    Return Me._UnitPrice
   End Get
   Set(ByVal value? As Decimal)
    If (Not Me._UnitPrice.Equals(value)) Then
     Me.OnUnitPriceChanging(value)
     Me.SendPropertyChanging()
     Me._UnitPrice = value
     Me.SendPropertyChanged("UnitPrice")
     Me.OnUnitPriceChanged()
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Order_Sale", Storage:="_Order1", ThisKey:="OrderID", OtherKey:="OrderID", IsForeignKey:=True)>
  Public Property Order() As Order
   Get
    Return Me._Order1.Entity
   End Get
   Set(ByVal value As Order)
    Dim previousValue As Order = Me._Order1.Entity
    If ((previousValue IsNot value) OrElse (Me._Order1.HasLoadedOrAssignedValue = False)) Then
     Me.SendPropertyChanging()
     If (previousValue IsNot Nothing) Then
      Me._Order1.Entity = Nothing
      previousValue.Sales.Remove(Me)
     End If
     Me._Order1.Entity = value
     If (value IsNot Nothing) Then
      value.Sales.Add(Me)
      Me._Order = value.OrderID
     Else
      Me._Order = Nothing
     End If
     Me.SendPropertyChanged("Order")
    End If
   End Set
  End Property

  <Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Product_Sale", Storage:="_Product1", ThisKey:="ProductID", OtherKey:="ProductID", IsForeignKey:=True)>
  Public Property Product() As Product
   Get
    Return Me._Product1.Entity
   End Get
   Set(ByVal value As Product)
    Dim previousValue As Product = Me._Product1.Entity
    If ((previousValue IsNot value) OrElse (Me._Product1.HasLoadedOrAssignedValue = False)) Then
     Me.SendPropertyChanging()
     If (previousValue IsNot Nothing) Then
      Me._Product1.Entity = Nothing
      previousValue.Sales.Remove(Me)
     End If
     Me._Product1.Entity = value
     If (value IsNot Nothing) Then
      value.Sales.Add(Me)
      Me._Product = value.ProductID
     Else
      Me._Product = Nothing
     End If
     Me.SendPropertyChanged("Product")
    End If
   End Set
  End Property

  Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Overridable Sub SendPropertyChanging()
RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
  End Sub

  Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub
 End Class
End Namespace
'#pragma warning restore 1591
