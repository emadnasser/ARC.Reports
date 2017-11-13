Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Xml
Imports DevExpress.Xpf.Core
Imports PivotGridDemo.Controls
Imports System.Windows
Imports System.Windows.Input

Namespace PivotGridDemo.PivotGrid.Helpers
    Public Delegate Sub UpdateProgressCallback(ByVal percents As Integer)
    Public Delegate Sub DatabaseGeneratedCallback()
    Public Delegate Sub DataSetFilledCallback(ByVal dataSet As DataSet)

    Public NotInheritable Class DatabaseHelper

        Private Sub New()
        End Sub

        Private ReadOnly Shared random As New Random()
        Private ReadOnly Shared worker As New BackgroundWorker()
        Private Shared ReadOnly FirstNames() As String = { "Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice" }
        Private Shared ReadOnly LastNames() As String = { "Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson" }
        Private Shared ReadOnly Adjectives() As String = { "Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy" }
        Private Shared ReadOnly ProductNames() As String = { "Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin", "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain" }
        Private Shared ReadOnly CategoryNames() As String = { "Business", "Presents", "Accessories", "Home", "Hobby" }
        Public Shared AsyncDataSetSql As String = "select" & ControlChars.CrLf & _
"	            Orders.OID as OrderID," & ControlChars.CrLf & _
"	            SalesPersonName," & ControlChars.CrLf & _
"	            CustomerName," & ControlChars.CrLf & _
"	            CategoryName," & ControlChars.CrLf & _
"	            ProductName," & ControlChars.CrLf & _
"	            Quantity," & ControlChars.CrLf & _
"	            UnitPrice," & ControlChars.CrLf & _
"	            OrderDate" & ControlChars.CrLf & _
"            from" & ControlChars.CrLf & _
"	            orders" & ControlChars.CrLf & _
"	            join Sales on Sales.[Order] = Orders.OID" & ControlChars.CrLf & _
"	            join SalesPeople on Orders.SalesPerson = SalesPeople.OID" & ControlChars.CrLf & _
"	            join Customers on Orders.Customer = Customers.OID" & ControlChars.CrLf & _
"	            join Products on Sales.Product = Products.OID" & ControlChars.CrLf & _
"	            join Categories on Products.Category = Categories.OID"
        Public Shared ServerModeDataSetSql As String = "select" & ControlChars.CrLf & _
"	            Sales.[Order] as OrderID," & ControlChars.CrLf & _
"	            Sales.Product as ProductID," & ControlChars.CrLf & _
"	            Sales.Quantity," & ControlChars.CrLf & _
"	            Sales.UnitPrice," & ControlChars.CrLf & _
"	            Orders.SalesPerson as [Order.SalesPersonID]," & ControlChars.CrLf & _
"	            Orders.Customer as [Order.CustomerID]," & ControlChars.CrLf & _
"	            Orders.OrderDate as [Order.OrderDate]," & ControlChars.CrLf & _
"	            Products.ProductName as [Product.ProductName]," & ControlChars.CrLf & _
"	            Products.Category as [Product.CategoryID]," & ControlChars.CrLf & _
"	            SalesPeople.SalesPersonName as [Order.SalesPerson.SalesPersonName]," & ControlChars.CrLf & _
"	            Customers.CustomerName as [Order.Customer.CustomerName]," & ControlChars.CrLf & _
"	            Categories.CategoryName as [Product.Category.CategoryName]" & ControlChars.CrLf & _
"            from" & ControlChars.CrLf & _
"	            Sales" & ControlChars.CrLf & _
"	            join Orders on Orders.OID = Sales.[Order]" & ControlChars.CrLf & _
"	            join SalesPeople on SalesPeople.OID = Orders.SalesPerson" & ControlChars.CrLf & _
"	            join Customers on Customers.OID = Orders.Customer" & ControlChars.CrLf & _
"	            join Products on Products.OID = Sales.Product" & ControlChars.CrLf & _
"	            join Categories on Categories.OID = Products.Category"

        Shared Sub New()
            AddHandler worker.DoWork, AddressOf GenerateDatabaseAsyncCore
            worker.WorkerReportsProgress = True
            worker.WorkerSupportsCancellation = True
        End Sub
        Public Shared ReadOnly Property IsGenerating() As Boolean
            Get
                Return worker.IsBusy
            End Get
        End Property
        Public Shared Sub GenerateDatabaseAsync(ByVal rowsCount As Integer, ByVal updateProgressCallback As UpdateProgressCallback, ByVal databaseGeneratedCallback As DatabaseGeneratedCallback)
            AddHandler worker.ProgressChanged, Sub(sender As Object, e As ProgressChangedEventArgs) updateProgressCallback(e.ProgressPercentage)
            AddHandler worker.RunWorkerCompleted, Sub(sender As Object, e As RunWorkerCompletedEventArgs) databaseGeneratedCallback()
            worker.RunWorkerAsync(rowsCount)
        End Sub
        Public Shared Sub CancelDatabaseGenerationAsync()
            worker.CancelAsync()
        End Sub
        Private Shared Sub GenerateDatabaseAsyncCore(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            worker.ReportProgress(0)
            Dim rowsCount As Integer = DirectCast(e.Argument, Integer)
            Dim rowsRemaining As Integer = rowsCount
            Using uow As New UnitOfWork()
                Try
                    uow.ClearDatabase()
                Catch
                End Try
                Dim salesPersonCount As Integer = random.Next(40, 50)
                Dim customersCount As Integer = random.Next(40, 50)
                Dim productsCount As Integer = random.Next(80, 100)
                Dim peopleNames As List(Of String) = GeneratePeopleNames(salesPersonCount + customersCount)
                Dim fullProductNames As List(Of String) = GenerateProductNames(productsCount)
                Dim indexPersonName As Integer = 0

                Dim salesPeople As New XPCollection(Of SalesPerson)(uow)
                For i As Integer = 0 To salesPersonCount - 1
                    salesPeople.Add(New SalesPerson(uow, peopleNames(indexPersonName)))
                    indexPersonName += 1
                Next i

                Dim customers As New XPCollection(Of Customer)(uow)
                For i As Integer = 0 To customersCount - 1
                    customers.Add(New Customer(uow, peopleNames(indexPersonName)))
                    indexPersonName += 1
                Next i


                Dim categories_Renamed As New XPCollection(Of Category)(uow)
                For i As Integer = 0 To CategoryNames.Length - 1
                    categories_Renamed.Add(New Category(uow, CategoryNames(i)))
                Next i

                Dim products As New XPCollection(Of Product)(uow)
                For i As Integer = 0 To productsCount - 1
                    products.Add(New Product(uow, fullProductNames(i), categories_Renamed(random.Next(categories_Renamed.Count)), random.Next(500)))
                Next i

                Do

                       For k As Integer = 0 To 299

                    Dim order As New Order(uow, salesPeople(random.Next(salesPeople.Count)), customers(random.Next(customers.Count)), GetDate())
                    Dim salesCount As Integer = If(rowsRemaining >= 5, random.Next(1, 6), rowsRemaining)
                    For j As Integer = 0 To salesCount - 1
                        Dim product As Product = products(random.Next(products.Count))
                        Dim TempSale As Sale = New Sale(uow, order, product, random.Next(1, 100), GetProductPrice(product))
                        rowsRemaining -= 1
                    Next j
                       Next k
                    uow.CommitChanges()
                    worker.ReportProgress(rowsCount - rowsRemaining)
                Loop While (Not worker.CancellationPending) AndAlso rowsRemaining > 0
                uow.FlushChanges()
            End Using
        End Sub
        Private Shared Function GeneratePeopleNames(ByVal count As Integer) As List(Of String)
            Dim names As New Dictionary(Of String, Integer)(count)
            Do While names.Count < count
                Dim name As String = GeneratePeopleName()
                If Not names.ContainsKey(name) Then
                    names.Add(name, 1)
                End If
            Loop
            Return names.Keys.ToList()
        End Function
        Private Shared Function GenerateProductNames(ByVal count As Integer) As List(Of String)
            Dim names As New Dictionary(Of String, Integer)(count)
            Do While names.Count < count
                Dim name As String = GenerateProductName()
                If Not names.ContainsKey(name) Then
                    names.Add(name, 1)
                End If
            Loop
            Return names.Keys.ToList()
        End Function
        Private Shared Function GeneratePeopleName() As String
            Return FirstNames(random.Next(FirstNames.Length)) & " " & LastNames(random.Next(LastNames.Length))
        End Function
        Private Shared Function GenerateProductName() As String
            Return Adjectives(random.Next(Adjectives.Length)) & " " & ProductNames(random.Next(ProductNames.Length))
        End Function
        Private Shared Function GetProductPrice(ByVal product As Product) As Decimal
            Return product.Price * CDec(0.5 + random.NextDouble())
        End Function
        Private Shared Function GetDate() As Date
            Return New Date(random.Next(2007, 2015), random.Next(1, 13), random.Next(1, 28))
        End Function
        Public Shared Sub GetDataSetAsync(ByVal sql As String, ByVal callback As DataSetFilledCallback)
            Dim workerDataSetFiller As New BackgroundWorker()
            AddHandler workerDataSetFiller.DoWork, AddressOf GetDataSetAsyncCore
            AddHandler workerDataSetFiller.RunWorkerCompleted, Sub(s As Object, e As RunWorkerCompletedEventArgs) callback(If(e.Error Is Nothing, DirectCast(e.Result, DataSet), Nothing))
            workerDataSetFiller.RunWorkerAsync(sql)
            workerDataSetFiller.Dispose()
        End Sub
        Private Shared Sub GetDataSetAsyncCore(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            Dim sql As String = DirectCast(e.Argument, String)
            e.Result = GetDataSet(sql)
        End Sub
        Public Shared Function GetDataSet(ByVal sql As String) As DataSet
            Dim connectionString As String = ServerParameters.GetDBConnectionString()
            Dim connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(sql, connection)
            Dim dataSet As DataSet
            Try
                dataSet = New DataSet()
                adapter.Fill(dataSet, "sales")
            Catch
                dataSet = Nothing
            Finally
                connection.Dispose()
            End Try
            Return dataSet
        End Function
        Public Shared Function GetContext() As PivotGridDemoDBDataContext
            Dim context As New PivotGridDemoDBDataContext(ServerParameters.GetDBConnectionString())
            Dim databaseOK As Boolean = False
            Try
                databaseOK = context.DatabaseExists()
            Finally
                If Not databaseOK Then
                    context.Dispose()
                    context = Nothing
                End If
            End Try
            Return context
        End Function
        Public Shared Function CalculateRecordCount() As Integer
            Try
                Using connection As New SqlConnection(ServerParameters.GetDBConnectionString())
                    connection.Open()
                    Using command As New SqlCommand("select count(OID) as count from [dbo].[Sales]", connection)
                        Return DirectCast(command.ExecuteScalar(), Integer)
                    End Using
                End Using
            Catch
                Try
                    CType(New SqlConnection(ServerParameters.GetServerConnectionString()), SqlConnection).Open()
                Catch
                    Return -1
                End Try
                Return 0
            End Try
        End Function
        Private Shared Function TryConnectToServer() As Boolean
            Dim connection As New SqlConnection(ServerParameters.GetServerConnectionString())
            Try
                connection.Open()
                connection.Close()
            Catch
                Return False
            Finally
                connection.Dispose()
            End Try
            Return True
        End Function
        Public Shared Function CreateDataLayer() As Boolean
            If Not TryConnectToServer() Then
                Return False
            End If
            Dim store As IDataStore
            Try
                store = XpoDefault.GetConnectionProvider(ServerParameters.GetDBConnectionString(), AutoCreateOption.DatabaseAndSchema)
            Catch
                Return False
            End Try
            XpoDefault.DataLayer = New SimpleDataLayer(store)
            Return True
        End Function
    End Class

    Public Class ServerParameters
        #Region "Singleton"
        Public Sub New()
        End Sub
        Private Shared fInstance As ServerParameters
        Private Shared ReadOnly Property Instance() As ServerParameters
            Get
                If fInstance Is Nothing Then
                    fInstance = New ServerParameters()
                End If
                Return fInstance
            End Get
        End Property
        #End Region
        Private Const ServerParametersFileName As String = "PivotGridSQLParameters.xml"
        Private fServer As String = DbEngineDetector.GetSqlServerInstanceName()
        Private fLogin As String = "sa"
        Private fPassword As String = String.Empty
        Private fUseWindowsAuthentication As Boolean = True

        Public Shared ReadOnly Property DBName() As String
            Get
                Return "PivotGridDemoDB"
            End Get
        End Property
        Public Shared Property Server() As String
            Get
                Return Instance.fServer
            End Get
            Set(ByVal value As String)
                Instance.fServer = value
            End Set
        End Property
        Public Shared Property Login() As String
            Get
                Return Instance.fLogin
            End Get
            Set(ByVal value As String)
                Instance.fLogin = value
            End Set
        End Property
        Public Shared Property Password() As String
            Get
                Return Instance.fPassword
            End Get
            Set(ByVal value As String)
                Instance.fPassword = value
            End Set
        End Property
        Public Shared Property UseWindowsAuthentication() As Boolean
            Get
                Return Instance.fUseWindowsAuthentication
            End Get
            Set(ByVal value As Boolean)
                Instance.fUseWindowsAuthentication = value
            End Set
        End Property
        Public Shared Sub LoadParameters()
            If Not File.Exists(ServerParametersFileName) Then
                Return
            End If
            Dim doc As New XmlDocument()
            Try
                doc.Load(ServerParametersFileName)
                If doc.DocumentElement.Name = "Parameters" Then
                    Dim parameters() As String = doc.DocumentElement.InnerText.Split(New Char() { ";"c })
                    Server = parameters(0)
                    UseWindowsAuthentication = Convert.ToBoolean(parameters(1))
                    Login = parameters(2)
                End If
            Catch
            End Try
        End Sub
        Public Shared Sub SaveParameters()
            Try
                Using writer As New XmlTextWriter(ServerParametersFileName, Encoding.UTF8)
                    writer.WriteElementString("Parameters", String.Format("{0};{1};{2}", Server, UseWindowsAuthentication, Login))
                End Using
            Catch
            End Try
        End Sub
        Public Shared Function GetServerConnectionString() As String
            If UseWindowsAuthentication Then
                Return String.Format("data source={0};integrated security=SSPI;connect timeout=10", Server)
            Else
                Return String.Format("data source={0};user id={1};password={2};connect timeout=10", Server, Login, Password)
            End If
        End Function
        Public Shared Function GetDBConnectionString() As String
            Return String.Format("{0};initial catalog={1}", GetServerConnectionString(), DBName)
        End Function
    End Class

    #Region "XPOs"
    <Persistent("SalesPeople")>
    Public Class SalesPerson
        Inherits XPObject

        Private fName As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub
        <Persistent("SalesPersonName")>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property
        <Association("SalesPeople-Orders")>
        Public ReadOnly Property Orders() As XPCollection(Of Order)
            Get
                Return GetCollection(Of Order)("Orders")
            End Get
        End Property
    End Class

    <Persistent("Customers")>
    Public Class Customer
        Inherits XPObject

        Private fName As String

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub
        <Persistent("CustomerName")>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property
        <Association("Customers-Orders")>
        Public ReadOnly Property Orders() As XPCollection(Of Order)
            Get
                Return GetCollection(Of Order)("Orders")
            End Get
        End Property
    End Class

    <Persistent("Orders")>
    Public Class Order
        Inherits XPObject

        Private fSalesPerson As SalesPerson
        Private fCustomer As Customer
        Private fDate As Date

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal salesPerson As SalesPerson, ByVal customer As Customer, ByVal [date] As Date)
            Me.New(session)
            Me.SalesPerson = salesPerson
            Me.Customer = customer
            Me.Date = [date]
            salesPerson.Orders.Add(Me)
            customer.Orders.Add(Me)
        End Sub
        <Association("SalesPeople-Orders")>
        Public Property SalesPerson() As SalesPerson
            Get
                Return fSalesPerson
            End Get
            Set(ByVal value As SalesPerson)
                SetPropertyValue("SalesPerson", fSalesPerson, value)
            End Set
        End Property
        <Association("Customers-Orders")>
        Public Property Customer() As Customer
            Get
                Return fCustomer
            End Get
            Set(ByVal value As Customer)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property
        <Association("Orders-Sales")>
        Public ReadOnly Property Sales() As XPCollection(Of Sale)
            Get
                Return GetCollection(Of Sale)("Sales")
            End Get
        End Property
        <Persistent("OrderDate"), Indexed>
        Public Property [Date]() As Date
            Get
                Return fDate
            End Get
            Set(ByVal value As Date)
                SetPropertyValue("Date", fDate, value)
            End Set
        End Property
    End Class

    <Persistent("Categories")>
    Public Class Category
        Inherits XPObject

        Private fName As String
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String)
            Me.New(session)
            Me.Name = name
        End Sub
        <Persistent("CategoryName")>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property
        <Association("Category-Products")>
        Public ReadOnly Property Products() As XPCollection(Of Product)
            Get
                Return GetCollection(Of Product)("Products")
            End Get
        End Property
    End Class

    <Persistent("Products")>
    Public Class Product
        Inherits XPObject

        Private fName As String
        Private fCategory As Category
        Private fPrice As Decimal

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal name As String, ByVal category As Category, ByVal price As Decimal)
            Me.New(session)
            Me.Name = name
            Me.Category = category
            Me.Category.Products.Add(Me)
            Me.Price = price
        End Sub
        <Persistent("ProductName")>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Name", fName, value)
            End Set
        End Property
        <Association("Category-Products")>
        Public Property Category() As Category
            Get
                Return fCategory
            End Get
            Set(ByVal value As Category)
                SetPropertyValue("Category", fCategory, value)
            End Set
        End Property
        <Association("Product-Sales")>
        Public ReadOnly Property Sales() As XPCollection(Of Sale)
            Get
                Return GetCollection(Of Sale)("Sales")
            End Get
        End Property
        <NonPersistent>
        Public Property Price() As Decimal
            Get
                Return fPrice
            End Get
            Set(ByVal value As Decimal)
                fPrice = value
            End Set
        End Property
    End Class

    <Persistent("Sales")>
    Public Class Sale
        Inherits XPObject

        Private fOrder As Order
        Private fProduct As Product
        Private fQuantity As Integer
        Private fUnitPrice As Decimal

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New(ByVal session As Session, ByVal order As Order, ByVal product As Product, ByVal quantity As Integer, ByVal unitPrice As Decimal)
            Me.New(session)
            Me.Order = order
            Me.Product = product
            Me.Quantity = quantity
            Me.UnitPrice = unitPrice
            order.Sales.Add(Me)
            product.Sales.Add(Me)
        End Sub
        <Association("Orders-Sales")>
        Public Property Order() As Order
            Get
                Return fOrder
            End Get
            Set(ByVal value As Order)
                SetPropertyValue("Order", fOrder, value)
            End Set
        End Property
        <Association("Product-Sales")>
        Public Property Product() As Product
            Get
                Return fProduct
            End Get
            Set(ByVal value As Product)
                SetPropertyValue("Product", fProduct, value)
            End Set
        End Property
        <Persistent("Quantity")>
        Public Property Quantity() As Integer
            Get
                Return fQuantity
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue("Quantity", fQuantity, value)
            End Set
        End Property
        <Persistent("UnitPrice")>
        Public Property UnitPrice() As Decimal
            Get
                Return fUnitPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue("UnitPrice", fUnitPrice, value)
            End Set
        End Property
    End Class
    #End Region
End Namespace
