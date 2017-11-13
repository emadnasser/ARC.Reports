Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Linq
Imports DevExpress.Data.Linq.Helpers
Imports DevExpress.DevAV
Imports DevExpress.Internal

Public NotInheritable Class DataProvider

    Private Sub New()
    End Sub

    Private Shared useCache As Boolean = True

    Private Shared databaseVersion_Renamed As String

    Private Shared customerStores_Renamed As List(Of CustomerStore)

    Private Shared oppChartData As List(Of DataEntryInfo)
    Private Shared rChartData As List(Of DataEntryInfo)
    Private Shared productSalesChartData As Dictionary(Of Long, List(Of DataEntryInfo))
    Private Shared productOppChartData As Dictionary(Of Long, List(Of DataEntryInfo))

    Private Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private Shared ReadOnly Property DataContext() As DevAVDb
        Get
            Dim storageKey = "C47520FF-2FFA-4468-9C22-E6BD4C2FC0C0"
            If Context Is Nothing Then
                Return GetDataContext()
            End If
            If Not Context.Items.Contains(storageKey) Then
                Context.Items(storageKey) = GetDataContext()
            End If
            Return DirectCast(Context.Items(storageKey), DevAVDb)
        End Get
    End Property
    Private Shared ReadOnly Property ExpressionConverter() As ICriteriaToExpressionConverter
        Get
            Return New CriteriaToEFExpressionConverter()
        End Get
    End Property

    Public Shared emptyEntryID As Long = -1
    Public Shared ReadOnly Property DatabaseVersion() As String
        Get
            If String.IsNullOrEmpty(databaseVersion_Renamed) Then
                databaseVersion_Renamed = DataContext.Version.First().Date.ToString("dd_MM_yyyy-HH_mm_ss")
            End If
            Return databaseVersion_Renamed
        End Get
    End Property

    Public Shared ReadOnly Property Employees() As IQueryable(Of Employee)
        Get
            Return DataContext.Employees
        End Get
    End Property
    Public Shared ReadOnly Property EmployeeTasks() As IQueryable(Of EmployeeTask)
        Get
            Return DataContext.Tasks.Where(Function(t) t.AssignedEmployeeId IsNot Nothing AndAlso t.OwnerId IsNot Nothing)
        End Get
    End Property
    Public Shared ReadOnly Property Customers() As IQueryable(Of Customer)
        Get
            Return DataContext.Customers
        End Get
    End Property
    Public Shared ReadOnly Property Products() As IQueryable(Of Product)
        Get
            Return DataContext.Products.Where(Function(p) p.EngineerId IsNot Nothing AndAlso p.SupportId IsNot Nothing)
        End Get
    End Property
    Public Shared ReadOnly Property CustomerEmployees() As IQueryable(Of CustomerEmployee)
        Get
            Return DataContext.CustomerEmployees
        End Get
    End Property
    Public Shared ReadOnly Property Evaluations() As IQueryable(Of Evaluation)
        Get
            Return DataContext.Evaluations
        End Get
    End Property
    Public Shared ReadOnly Property States() As IQueryable(Of State)
        Get
            Return DataContext.States
        End Get
    End Property
    Public Shared ReadOnly Property Crests() As IQueryable(Of Crest)
        Get
            Return DataContext.Crests
        End Get
    End Property
    Public Shared ReadOnly Property Orders() As IQueryable(Of Order)
        Get
            Return DataContext.Orders
        End Get
    End Property
    Public Shared ReadOnly Property OrderItems() As IQueryable(Of OrderItem)
        Get
            Return DataContext.OrderItems.Where(Function(i) i.Order.OrderDate < Date.Now)
        End Get
    End Property
    Public Shared ReadOnly Property QuoteItems() As IQueryable(Of QuoteItem)
        Get
            Return DataContext.QuoteItems.Where(Function(i) i.Quote.Date < Date.Now)
        End Get
    End Property
    Public Shared ReadOnly Property CustomerStores() As IQueryable(Of CustomerStore)
        Get
            Return DataContext.CustomerStores
        End Get
    End Property
    Public Shared ReadOnly Property Quotes() As IQueryable(Of Quote)
        Get
            Return DataContext.Quotes.Where(Function(q) q.Date < Date.Now)
        End Get
    End Property

    Public Shared Function GetEmployees(ByVal filterExpression As String) As IQueryable(Of Employee)
        Return DirectCast(Employees.AppendWhere(ExpressionConverter, CriteriaOperator.Parse(filterExpression)), IQueryable(Of Employee))
    End Function
    Public Shared Function GetEmployeeTasks(ByVal filterExpression As String) As IQueryable(Of EmployeeTask)
        Return DirectCast(EmployeeTasks.AppendWhere(ExpressionConverter, CriteriaOperator.Parse(filterExpression)), IQueryable(Of EmployeeTask))
    End Function

    Public Shared Function CreateEmployee() As Employee
        Return DataContext.Employees.Add(DataContext.Employees.Create())
    End Function
    Public Shared Function CreateTask() As EmployeeTask
        Return DataContext.Tasks.Add(DataContext.Tasks.Create())
    End Function
    Public Shared Sub DeleteEmployee(ByVal id As Long)
        Dim employee = Employees.FirstOrDefault(Function(e) e.Id = id)
        If employee Is Nothing Then
            Return
        End If
        DeleteEmployeeRelations(id)
        DataContext.Employees.Remove(employee)
        DataContext.SaveChanges()
    End Sub
    Public Shared Sub DeleteTask(ByVal id As Long)
        Dim task = EmployeeTasks.FirstOrDefault(Function(e) e.Id = id)
        If task Is Nothing Then
            Return
        End If
        DataContext.Tasks.Remove(task)
        DataContext.SaveChanges()
    End Sub
    Public Shared Sub DeleteEvaluation(ByVal id As Long)
        Dim evaluation = Evaluations.FirstOrDefault(Function(e) e.Id = id)
        If evaluation Is Nothing Then
            Return
        End If
        DataContext.Evaluations.Remove(evaluation)
        DataContext.SaveChanges()
    End Sub
    Public Shared Function CreateProductImage(ByVal product As Product, ByVal data() As Byte) As ProductImage
        Dim image = DataContext.ProductImages.Create()
        image.Picture = New Picture()
        image.Picture.Data = data
        product.Images.Add(image)
        SaveChanges()
        Return image
    End Function

    Public Shared Sub SaveChanges()
        DataContext.SaveChanges()
    End Sub

    Public Shared Function GetCustomerStores() As List(Of CustomerStore)
        If useCache OrElse customerStores_Renamed Is Nothing Then ' TODO
            customerStores_Renamed = CustomerStores.ToList()
        End If
        Return customerStores_Renamed
    End Function
    Public Shared Function GetRevenueChartData() As List(Of DataEntryInfo)
        If (Not useCache) OrElse rChartData Is Nothing Then
            rChartData = OrderItems.GroupBy(Function(i) i.Product.Category).Select(Function(g) New DataEntryInfo() With {.Name = g.Key.ToString(), .Value = g.Sum(Function(i) i.Total)}).ToList()
        End If
        Return rChartData
    End Function
    Public Shared Function GetOpportunitiesChartData() As List(Of DataEntryInfo)
        If (Not useCache) OrElse oppChartData Is Nothing Then
            oppChartData = New List(Of DataEntryInfo)() From {
                New DataEntryInfo() With {.Name = "High", .Value = Quotes.Where(Function(q) q.Opportunity > 0.6).Sum(Function(q) q.Total)},
                New DataEntryInfo() With {.Name = "Medium", .Value = Quotes.Where(Function(q) q.Opportunity > 0.3 AndAlso q.Opportunity < 0.6).Sum(Function(q) q.Total)},
                New DataEntryInfo() With {.Name = "Low", .Value = Quotes.Where(Function(q) q.Opportunity > 0.12 AndAlso q.Opportunity < 0.3).Sum(Function(q) q.Total)},
                New DataEntryInfo() With {.Name = "Unlikely", .Value = Quotes.Where(Function(q) q.Opportunity < 0.12).Sum(Function(q) q.Total)}
            }
        End If
        Return oppChartData
    End Function
    Public Shared Function GetProductOpportunitiesChartData(ByVal product As Product) As List(Of DataEntryInfo)
        If (Not useCache) OrElse productOppChartData Is Nothing Then
            productOppChartData = CreateProductOppChartData()
        End If
        Return productOppChartData(product.Id)
    End Function
    Public Shared Function GetProductSalesChartData(ByVal product As Product) As List(Of DataEntryInfo)
        If (Not useCache) OrElse productSalesChartData Is Nothing Then
            productSalesChartData = CreateProductSalesChartData()
        End If
        Return productSalesChartData(product.Id)
    End Function

    Private Shared Function GetDataContext() As DevAVDb
        DevExpress.DemoData.DemoDbContext.IsWebModel = True

        Dim connectionString = System.Configuration.ConfigurationManager.ConnectionStrings("DevAVConnectionString").ConnectionString
        connectionString = DbEngineDetector.PatchConnectionString(connectionString)
        Return New DevAVDb(connectionString)
    End Function
    Private Shared Function CreateProductSalesChartData() As Dictionary(Of Long, List(Of DataEntryInfo))
        Return OrderItems.GroupBy(Function(q) q.ProductId).Select(Function(g) New With {Key .K = g.Key.Value, Key .V = g.GroupBy(Function(q) q.Order.OrderDate.Year).Select(Function(yg) New With {Key .Year = yg.Key, Key .Total = yg.Sum(Function(i) i.Total)}).OrderBy(Function(i) i.Year).ToList()}).ToDictionary(Function(i) i.K, Function(i) i.V.Select(Function(e) New DataEntryInfo() With {.Name = e.Year.ToString(), .Value = e.Total}).ToList())
    End Function
    Private Shared Function CreateProductOppChartData() As Dictionary(Of Long, List(Of DataEntryInfo))
        Return QuoteItems.GroupBy(Function(q) q.ProductId).Select(Function(g) New With {Key .K = g.Key.Value, Key .V = g.GroupBy(Function(q) q.Quote.Date.Year).Select(Function(yg) New With {Key .Year = yg.Key, Key .Total = yg.Sum(Function(i) i.Total)}).OrderBy(Function(i) i.Year).ToList()}).ToDictionary(Function(i) i.K, Function(i) i.V.Select(Function(e) New DataEntryInfo() With {.Name = e.Year.ToString(), .Value = e.Total}).ToList())
    End Function
    Private Shared Sub DeleteEmployeeRelations(ByVal id As Long)
        Dim tasks = DataContext.Tasks.Where(Function(task) task.OwnerId = id OrElse task.AssignedEmployeeId = id)
        For Each task In tasks
            If task.OwnerId = id Then
                task.OwnerId = Nothing
            End If
            If task.AssignedEmployeeId Is Nothing Then
                task.AssignedEmployeeId = Nothing
            End If
        Next task


        Dim evaluations_Renamed = DataContext.Evaluations.Where(Function(ev) ev.CreatedById = id OrElse ev.EmployeeId = id)
        For Each evaluation In evaluations_Renamed
            If evaluation.CreatedById = id Then
                evaluation.CreatedById = Nothing
            End If
            If evaluation.EmployeeId = id Then
                evaluation.EmployeeId = Nothing
            End If
        Next evaluation


        Dim products_Renamed = DataContext.Products.Where(Function(p) p.EngineerId = id OrElse p.SupportId = id)
        For Each product In products_Renamed
            If product.EngineerId = id Then
                product.EngineerId = Nothing
            End If
            If product.SupportId = id Then
                product.SupportId = Nothing
            End If
        Next product


        Dim orders_Renamed = DataContext.Orders.Where(Function(o) o.EmployeeId = id)
        For Each order In orders_Renamed
            order.EmployeeId = Nothing
        Next order


        Dim quotes_Renamed = DataContext.Quotes.Where(Function(q) q.EmployeeId = id).ToList()
        For Each quote In quotes_Renamed
            quote.EmployeeId = Nothing
        Next quote

        Dim communications = DataContext.Communications.Where(Function(c) c.EmployeeId = id)
        For Each communication In communications
            communication.EmployeeId = Nothing
        Next communication
    End Sub
End Class

Public Class DataEntryInfo
    Public Property Name() As String
    Public Property Value() As Decimal
End Class
