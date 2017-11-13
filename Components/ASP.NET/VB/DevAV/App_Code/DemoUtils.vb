Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Caching
Imports System.Web.SessionState
Imports System.Xml.Linq
Imports DevExpress.Data.Filtering
Imports DevExpress.DevAV
Imports DevExpress.DevAV.Reports
Imports DevExpress.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Public Enum ReportType
    CustomerProfile
    CustomerContactsDirectory
    CustomerSalesDetail
    CustomerSalesSummary
    EmployeeDirectory
    EmployeeSummary
    EmployeeProfile
    EmployeeTaskList
    ProductOrders
    ProductSalesSummary
    ProductProfile
    TaskList
    SalesOrdersSummary
End Enum

Public Class FilterItem
    Public Property Name() As String
    Public Property Expression() As String
    Public Property IsCustom() As Boolean
End Class

Public NotInheritable Class DemoUtils

    Private Sub New()
    End Sub

    Private Const SerializedStringArraySeparator As Char = "|"c
    Private Const StatesFilePath As String = "~/App_Data/States.xml", GridViewViewModeKey As String = "GridView", ContactImageSlideViewModeKey As String = "Contacts", EmployeePageViewModeCookieKey As String = "EmployeeViewMode", TaskPageViewModeCookieKey As String = "TaskViewMode", ImageSliderModeCookieKey As String = "CustomerImageSliderMode", StateHiddenFieldContextKey As String = "216A8C03-7A8A-4735-8CBB-4C62E0D4D23C", SearchExpressionsContextKey As String = "7063240E-83E6-415E-A399-5F6C917CA385"

    Private Shared _isSiteMode? As Boolean

    Private Shared spreadsheetTempDir_Renamed As String
    Private Shared spreadsheetTempClearTime As Date = Date.Now

    Private Shared reportDisplayNames_Renamed As New Dictionary(Of ReportType, String)()

    Private Shared stateDisplayNames_Renamed As Dictionary(Of String, String)
    Private Shared reportDisplayNamesLockObject As New Object()
    Private Shared stateDisplayNamesLockObject As New Object()
    Private Shared clearSpreadsheetTempFolderLockObject As New Object()

    Private Shared ReadOnly Property ReportDisplayNames() As Dictionary(Of ReportType, String)
        Get
            SyncLock reportDisplayNamesLockObject
                If reportDisplayNames_Renamed.Count = 0 Then
                    PopuplateReportNames(reportDisplayNames_Renamed)
                End If
                Return reportDisplayNames_Renamed
            End SyncLock
        End Get
    End Property
    Private Shared ReadOnly Property StateDisplayNames() As Dictionary(Of String, String)
        Get
            SyncLock stateDisplayNamesLockObject
                If stateDisplayNames_Renamed Is Nothing Then
                    stateDisplayNames_Renamed = XDocument.Load(MapPath(StatesFilePath)).Descendants("State").ToDictionary(Function(n) n.Attribute("Name").Value, Function(n) n.Attribute("DisplayName").Value)
                End If
                Return stateDisplayNames_Renamed
            End SyncLock
        End Get
    End Property

    Shared Sub New()
        RegisterFilterEnums()
        DashboardFilter = New FilterBag("Dashboard", CreateDashboardStandardFilters())
        CustomerFilter = New FilterBag("Customer", CreateCustomerStandardFilters(), "Name", "BillingAddress.Line", "BillingAddress.City")
        EmployeeFilter = New FilterBag("Employee", CreateEmployeeStandardFilters(), "FirstName", "LastName", "Title")
        TaskFilter = New FilterBag("Task", CreateTaskStandardFilters(), "Subject", "Description", "AssignedEmployee.FirstName", "AssignedEmployee.LastName")
        ProductFilter = New FilterBag("Product", CreateProductStandardFilters(), "Name")
    End Sub

    Public Shared ImageLoader As New DemoImageLoader()

    Public Shared ReadOnly Property Context() As HttpContext
        Get
            Return HttpContext.Current
        End Get
    End Property
    Private Shared Function MapPath(ByVal virtualPath As String) As String
        Return Context.Server.MapPath(virtualPath)
    End Function

    Private Shared Property StateHiddenField() As ASPxHiddenField
        Get
            Return TryCast(Context.Items(StateHiddenFieldContextKey), ASPxHiddenField)
        End Get
        Set(ByVal value As ASPxHiddenField)
            Context.Items(StateHiddenFieldContextKey) = value
        End Set
    End Property

    Public Shared ReadOnly Property IsSiteMode() As Boolean
        Get
            If Not _isSiteMode.HasValue Then
                _isSiteMode = ConfigurationManager.AppSettings("SiteMode").Equals("true", StringComparison.InvariantCultureIgnoreCase)
            End If
            Return _isSiteMode.Value
        End Get
    End Property

    Public Shared Sub RegisterStateHiddenField(ByVal hf As ASPxHiddenField)
        StateHiddenField = hf
    End Sub
    Public Shared Function TryGetClientStateValue(Of T)(ByVal key As String, <System.Runtime.InteropServices.Out()> ByRef result As T) As Boolean
        If Not IsStateHiddenFieldContainsKey(key) Then
            result = Nothing
            Return False
        End If
        result = CType(StateHiddenField(key), T)
        Return True
    End Function
    Public Shared Function TrySetClientStateValue(Of T)(ByVal key As String, ByVal value As T) As Boolean
        If StateHiddenField Is Nothing Then
            Return False
        End If
        StateHiddenField(key) = value
        Return True
    End Function
    Public Shared Function TryGetClientStateIDValue(ByVal key As String, <System.Runtime.InteropServices.Out()> ByRef result As Long) As Boolean
        If Not IsStateHiddenFieldContainsKey(key) Then
            result = -1
            Return False
        End If
        result = Long.Parse(StateHiddenField(key).ToString())
        Return True
    End Function
    Private Shared Function IsStateHiddenFieldContainsKey(ByVal key As String) As Boolean
        Return StateHiddenField IsNot Nothing AndAlso StateHiddenField.Contains(key)
    End Function

    ' ViewMode
    Public Shared ReadOnly Property IsEmployeeGridViewMode() As Boolean
        Get
            Return GetCookie(EmployeePageViewModeCookieKey, GridViewViewModeKey) = GridViewViewModeKey
        End Get
    End Property
    Public Shared ReadOnly Property IsTaskGridViewMode() As Boolean
        Get
            Return GetCookie(TaskPageViewModeCookieKey, GridViewViewModeKey) = GridViewViewModeKey
        End Get
    End Property
    Public Shared ReadOnly Property IsContactImageSliderMode() As Boolean
        Get
            Return GetCookie(ImageSliderModeCookieKey, ContactImageSlideViewModeKey) = ContactImageSlideViewModeKey
        End Get
    End Property

    Private Shared Function GetCookie(ByVal key As String, ByVal defaultValue As String) As String
        Dim cookie = HttpContext.Current.Request.Cookies(key)
        Return If(cookie Is Nothing, defaultValue, cookie.Value)
    End Function

    ' Search
    Public Shared Function HighlightSearchText(ByVal source As String, ByVal searchText As String) As String
        If String.IsNullOrWhiteSpace(searchText) Then
            Return source
        End If
        Dim regex = GetSearchExpression(searchText)
        If regex.IsMatch(source) Then
            Return String.Format("<span>{0}</span>", regex.Replace(source, "<span class='hgl'>$0</span>"))
        End If
        Return source
    End Function
    Private Shared Function GetSearchExpression(ByVal searchText As String) As Regex
        If Not SearchExpressions.ContainsKey(searchText) Then
            SearchExpressions(searchText) = New Regex(Regex.Escape(searchText), RegexOptions.IgnoreCase)
        End If
        Return SearchExpressions(searchText)
    End Function
    Private Shared ReadOnly Property SearchExpressions() As Dictionary(Of String, Regex)
        Get
            If Context.Items(SearchExpressionsContextKey) Is Nothing Then
                Context.Items(SearchExpressionsContextKey) = New Dictionary(Of String, Regex)()
            End If
            Return DirectCast(Context.Items(SearchExpressionsContextKey), Dictionary(Of String, Regex))
        End Get
    End Property

    ' Filters
    Private Shared privateDashboardFilter As FilterBag
    Public Shared Property DashboardFilter() As FilterBag
        Get
            Return privateDashboardFilter
        End Get
        Private Set(ByVal value As FilterBag)
            privateDashboardFilter = value
        End Set
    End Property
    Private Shared privateCustomerFilter As FilterBag
    Public Shared Property CustomerFilter() As FilterBag
        Get
            Return privateCustomerFilter
        End Get
        Private Set(ByVal value As FilterBag)
            privateCustomerFilter = value
        End Set
    End Property
    Private Shared privateEmployeeFilter As FilterBag
    Public Shared Property EmployeeFilter() As FilterBag
        Get
            Return privateEmployeeFilter
        End Get
        Private Set(ByVal value As FilterBag)
            privateEmployeeFilter = value
        End Set
    End Property
    Private Shared privateTaskFilter As FilterBag
    Public Shared Property TaskFilter() As FilterBag
        Get
            Return privateTaskFilter
        End Get
        Private Set(ByVal value As FilterBag)
            privateTaskFilter = value
        End Set
    End Property
    Private Shared privateProductFilter As FilterBag
    Public Shared Property ProductFilter() As FilterBag
        Get
            Return privateProductFilter
        End Get
        Private Set(ByVal value As FilterBag)
            privateProductFilter = value
        End Set
    End Property

    Private Shared Sub RegisterFilterEnums()
        EnumProcessingHelper.RegisterEnum(GetType(CustomerStatus))
        EnumProcessingHelper.RegisterEnum(GetType(EmployeeStatus))
        EnumProcessingHelper.RegisterEnum(GetType(EmployeeTaskStatus))
        EnumProcessingHelper.RegisterEnum(GetType(EmployeeTaskPriority))
    End Sub
    Private Shared Function CreateDashboardStandardFilters() As Dictionary(Of String, FilterItem)
        Dim result = New Dictionary(Of String, FilterItem)()
        Dim category = New OperandProperty("Product.Category")
        Dim name = New OperandProperty("Product.Name")
        result.CreateItem("All", Nothing)
        result.CreateItem("Video Players", CType(category Is "VideoPlayers", CriteriaOperator))
        result.CreateItem("Plasma TVs", category Is "Televisions" And New FunctionOperator(FunctionOperatorType.Contains, name, "Plasma"))
        result.CreateItem("LCD TVs", category Is "Televisions" And New FunctionOperator(FunctionOperatorType.Contains, name, "LCD"))
        Return result
    End Function
    Private Shared Function CreateCustomerStandardFilters() As Dictionary(Of String, FilterItem)
        Dim result = New Dictionary(Of String, FilterItem)()
        Dim state = New OperandProperty("BillingAddress.State")
        result.CreateItem("All", Nothing)
        result.CreateItem("Illinois", CType(state Is "IL", CriteriaOperator))
        result.CreateItem("California", CType(state Is "CA", CriteriaOperator))
        result.CreateItem("Arizona", CType(state Is "AR", CriteriaOperator))
        result.CreateItem("Georgia", CType(state Is "GA", CriteriaOperator))
        Return result
    End Function
    Private Shared Function CreateEmployeeStandardFilters() As Dictionary(Of String, FilterItem)
        Dim result = New Dictionary(Of String, FilterItem)()
        Dim status = New OperandProperty("Status")
        result.CreateItem("All", Nothing)
        result.CreateItem("Salaried", CType(status Is New OperandValue(EmployeeStatus.Salaried), CriteriaOperator))
        result.CreateItem("Commission", CType(status Is New OperandValue(EmployeeStatus.Commission), CriteriaOperator))
        result.CreateItem("Contract", CType(status Is New OperandValue(EmployeeStatus.Contract), CriteriaOperator))
        Return result
    End Function
    Private Shared Function CreateTaskStandardFilters() As Dictionary(Of String, FilterItem)
        Dim result = New Dictionary(Of String, FilterItem)()
        Dim [date] = New OperandProperty("DueDate")
        Dim status = New OperandProperty("Status")
        result.CreateItem("All", Nothing)
        result.CreateItem("Pending", [date] <= Date.Now.Date And status IsNot New OperandValue(EmployeeTaskStatus.Completed))
        result.CreateItem("Deferred", CType(status Is New OperandValue(EmployeeTaskStatus.Deferred), CriteriaOperator))
        result.CreateItem("Completed", CType(status Is New OperandValue(EmployeeTaskStatus.Completed), CriteriaOperator))
        Return result
    End Function
    Private Shared Function CreateProductStandardFilters() As Dictionary(Of String, FilterItem)
        Dim result = New Dictionary(Of String, FilterItem)()
        Dim category = New OperandProperty("Category")
        Dim name = New OperandProperty("Name")
        result.CreateItem("All", Nothing)
        result.CreateItem("Video Players", CType(category Is "VideoPlayers", CriteriaOperator))
        result.CreateItem("Plasma TVs", category Is "Televisions" And New FunctionOperator(FunctionOperatorType.Contains, name, "Plasma"))
        result.CreateItem("LCD TVs", category Is "Televisions" And New FunctionOperator(FunctionOperatorType.Contains, name, "LCD"))
        Return result
    End Function

    ' Reports
    Public Shared Function CreateReport(ByVal queryString As String) As XtraReport
        Dim args = DemoUtils.DeserializeCallbackArgs(queryString)
        If args.Count = 0 Then
            Return Nothing
        End If
        Dim rType As ReportType = Nothing
        If Not System.Enum.TryParse(args(0), rType) Then
            Return Nothing
        End If
        Dim itemID = If((Not String.IsNullOrEmpty(args(1))), Long.Parse(args(1)), DataProvider.emptyEntryID)
        Return CreateReport(rType, itemID)
    End Function

    Public Shared Function CreateReport(ByVal reportType As ReportType, ByVal itemID As Long) As XtraReport
        Select Case reportType
            Case ReportType.CustomerProfile
                Return CreateCustomerProfileReport()
            Case ReportType.CustomerContactsDirectory
                Return CreateCustomerContactsReport(itemID)
            Case ReportType.CustomerSalesDetail
                Return CreateCustomerSalesDetailReport(itemID)
            Case ReportType.CustomerSalesSummary
                Return CreateCustomerSalesSummaryReport(itemID)
            Case ReportType.EmployeeDirectory
                Return CreateEmployeeDirectoryReport()
            Case ReportType.EmployeeSummary
                Return CreateEmployeeSummaryReport()
            Case ReportType.EmployeeProfile
                Return CreateEmployeeProfileReport()
            Case ReportType.EmployeeTaskList
                Return CreateEmployeeTaskListReport(itemID)
            Case ReportType.ProductOrders
                Return CreateProductOrdersReport(itemID)
            Case ReportType.ProductSalesSummary
                Return CreateProductSalesSummaryReport(itemID)
            Case ReportType.ProductProfile
                Return CreateProductProfileReport(itemID)
            Case ReportType.TaskList
                Return CreateEmployeeTaskListReport()
            Case ReportType.SalesOrdersSummary
                Return CreateSalesOrdersSummaryReport()
        End Select
        Return Nothing
    End Function

    Private Shared Function CreateCustomerProfileReport() As XtraReport
        Return New CustomerProfile() With {.DataSource = DataProvider.Customers.ToList()}
    End Function
    Private Shared Function CreateCustomerContactsReport(ByVal customerID As Long) As XtraReport
        Dim report = New CustomerContactsDirectory()
        Dim customer = DataProvider.Customers.FirstOrDefault(Function(c) c.Id = customerID)
        If customer Is Nothing Then
            Return Nothing
        End If
        report.DataSource = customer.Employees
        Return report
    End Function
    Private Shared Function CreateCustomerSalesDetailReport(ByVal customerID As Long) As XtraReport
        Dim report = New CustomerSalesDetailReport()
        Dim customer = DataProvider.Customers.FirstOrDefault(Function(c) c.Id = customerID)
        If customer IsNot Nothing Then
            Return Nothing
        End If
        report.SetChartData(QueriesHelper.GetCustomerSaleOrderItemDetails(customer.Id, DataProvider.OrderItems))
        report.DataSource = QueriesHelper.GetCustomerSaleDetails(customer.Id, DataProvider.OrderItems)
        Return report
    End Function
    Private Shared Function CreateCustomerSalesSummaryReport(ByVal customerID As Long) As XtraReport
        Dim report = New CustomerSalesSummaryReport()
        Dim customer = DataProvider.Customers.FirstOrDefault(Function(c) c.Id = customerID)
        If customer Is Nothing Then
            Return Nothing
        End If
        report.DataSource = QueriesHelper.GetCustomerSaleOrderItemDetails(customer.Id, DataProvider.OrderItems)
        Return report
    End Function
    Private Shared Function CreateEmployeeDirectoryReport() As XtraReport
        Return New EmployeeDirectory() With {.DataSource = DataProvider.Employees.ToList()}
    End Function
    Private Shared Function CreateEmployeeSummaryReport() As XtraReport
        Return New EmployeeSummary() With {.DataSource = DataProvider.Employees.ToList()}
    End Function
    Private Shared Function CreateEmployeeProfileReport() As XtraReport
        Return New EmployeeProfile() With {.DataSource = DataProvider.Employees.ToList()}
    End Function
    Private Shared Function CreateEmployeeTaskListReport(ByVal employeeID As Long) As XtraReport
        Dim report = New EmployeeTaskList()
        Dim employee = DataProvider.Employees.FirstOrDefault(Function(e) e.Id = employeeID)
        If employee Is Nothing Then
            Return Nothing
        End If
        report.DataSource = employee.AssignedTasks
        Return report
    End Function
    Private Shared Function CreateProductOrdersReport(ByVal productID As Long) As XtraReport
        Dim report = New ProductOrders()
        Dim product = DataProvider.Products.FirstOrDefault(Function(p) p.Id = productID)
        If product Is Nothing Then
            Return Nothing
        End If
        report.DataSource = product.OrderItems
        report.SetStates(DataProvider.States.ToList())
        Return report
    End Function
    Private Shared Function CreateProductSalesSummaryReport(ByVal productID As Long) As XtraReport
        Dim report = New ProductSalesSummary()
        Dim product = DataProvider.Products.FirstOrDefault(Function(p) p.Id = productID)
        If product Is Nothing Then
            Return Nothing
        End If
        report.DataSource = product.OrderItems
        Return report
    End Function
    Private Shared Function CreateProductProfileReport(ByVal productID As Long) As XtraReport
        Return New ProductProfile() With {.DataSource = DataProvider.Products.Where(Function(p) p.Id = productID).ToList()}
    End Function
    Private Shared Function CreateEmployeeTaskListReport() As XtraReport
        Return New EmployeeTaskList() With {.DataSource = DataProvider.EmployeeTasks.ToList()}
    End Function
    Private Shared Function CreateSalesOrdersSummaryReport() As XtraReport
        Return New SalesOrdersSummaryReport() With {.DataSource = QueriesHelper.GetSaleSummaries(DataProvider.OrderItems)}
    End Function

    Public Shared Function GetReportDisplayName(ByVal rType As ReportType) As String
        Return ReportDisplayNames(rType)
    End Function
    Private Shared Sub PopuplateReportNames(ByVal names As Dictionary(Of ReportType, String))
        names(ReportType.CustomerProfile) = "Profile Report"
        names(ReportType.CustomerContactsDirectory) = "Contact Directory Report"
        names(ReportType.CustomerSalesSummary) = "Sales Summary Report"
        names(ReportType.CustomerSalesDetail) = "Sales Detail Report"

        names(ReportType.EmployeeDirectory) = "Directory Report"
        names(ReportType.EmployeeSummary) = "List Report"
        names(ReportType.EmployeeProfile) = "Detail Report"
        names(ReportType.EmployeeTaskList) = "Task Report"

        names(ReportType.ProductOrders) = "Order Details Report"
        names(ReportType.ProductSalesSummary) = "Sales Summary Report"
        names(ReportType.ProductProfile) = "Specification Summary Report"

        names(ReportType.TaskList) = "Task Report"

        names(ReportType.SalesOrdersSummary) = "Sales Orders Summary Report"
    End Sub

    ' Spreadsheet
    Public Shared Sub LoadSpreadsheetFile(ByVal load As Action(Of String))
        Dim path = System.IO.Path.Combine(SpreadsheetTempDir, Guid.NewGuid().ToString() & ".xlsx")
        load(path)
        File.Delete(path)
    End Sub
    Public Shared Sub ClearSpreadsheetTempFolder()
        If Date.Now > spreadsheetTempClearTime Then
            Return
        End If
        SyncLock clearSpreadsheetTempFolderLockObject
            Dim dir = New DirectoryInfo(SpreadsheetTempDir)
            Dim files = dir.GetFiles().Where(Function(f) (Date.Now - f.LastAccessTime).TotalMinutes > 20)
            For Each file In files
                System.IO.File.Delete(file.FullName)
            Next file
            spreadsheetTempClearTime = Date.Now.AddMinutes(10)
        End SyncLock
    End Sub
    Private Shared ReadOnly Property SpreadsheetTempDir() As String
        Get
            If String.IsNullOrEmpty(spreadsheetTempDir_Renamed) Then
                spreadsheetTempDir_Renamed = HttpContext.Current.Request.MapPath("~/App_Data/SpreadhsheetTempFolder")
                If Not Directory.Exists(spreadsheetTempDir_Renamed) Then
                    Directory.CreateDirectory(spreadsheetTempDir_Renamed)
                End If
            End If
            Return spreadsheetTempDir_Renamed
        End Get
    End Property

    Public Shared Function GetStateDisplayName(ByVal name As String) As String
        Return If(StateDisplayNames.ContainsKey(name), StateDisplayNames(name), String.Empty)
    End Function

    Public Shared Sub BindComboBoxToEnum(ByVal comboBox As ASPxComboBox, ByVal enumType As Type)
        comboBox.ValueType = enumType
        PopulateComboBoxItems(comboBox.Items, enumType)
    End Sub
    Public Shared Sub BindComboBoxToEnum(ByVal prop As ComboBoxProperties, ByVal enumType As Type)
        prop.ValueType = enumType
        PopulateComboBoxItems(prop.Items, enumType)
    End Sub
    Public Shared Sub EnsureGridFocusedRowIndex(ByVal grid As ASPxGridView) ' TODO
        grid.FocusedRowIndex = If(grid.FocusedRowIndex < 0, 0, grid.FocusedRowIndex)
    End Sub

    Public Shared Function DeserializeCallbackArgs(ByVal data As String) As List(Of String)
        Dim items = New List(Of String)()
        Try
            If Not String.IsNullOrEmpty(data) Then
                Dim currentPos As Integer = 0
                Dim dataLength As Integer = data.Length
                Do While currentPos < dataLength
                    Dim item As String = DeserializeStringArrayItem(data, currentPos)
                    items.Add(item)
                Loop
            End If
        Catch
            items.Clear()
        End Try
        Return items
    End Function
    Private Shared Function DeserializeStringArrayItem(ByVal data As String, ByRef currentPos As Integer) As String
        Dim indexOfFirstSeparator As Integer = data.IndexOf(SerializedStringArraySeparator, currentPos)
        Dim itemLengthString As String = data.Substring(currentPos, indexOfFirstSeparator - currentPos)
        Dim itemLength As Integer = Int32.Parse(itemLengthString)
        currentPos += itemLengthString.Length + 1
        Dim item As String = data.Substring(currentPos, itemLength)
        currentPos += itemLength
        Return item
    End Function
    Private Shared Sub PopulateComboBoxItems(ByVal items As ListEditItemCollection, ByVal enumType As Type)
        items.Clear()
        For Each value In System.Enum.GetValues(enumType)
            items.Add(DevExpress.Web.Internal.CommonUtils.SplitPascalCaseString(value.ToString()), value)
        Next value
    End Sub
End Class

Public Class DemoImageLoader
    Private Const DefaultEmployeeImageName As String = "DefaultEmployee.png", ThumbnailsFolderName As String = "Thumb", ImageStringFormat As String = "{0}.jpg", EnsureImagesByTimeoutKey As String = "EnsureImagesByTimeoutKey"
    Private Const EnsureImagesInterval As Integer = 5
    Private loadImagesFromDBLockObject As New Object()
    Private ResizedPictureHash As New Dictionary(Of Long, Byte())()

    Private ReadOnly Property TempFolderName() As String
        Get
            Return "TempImages_" & DataProvider.DatabaseVersion
        End Get
    End Property

    Private ReadOnly Property TempFolderVirtPath() As String
        Get
            Return Path.Combine("~", "Content", TempFolderName)
        End Get
    End Property
    Private ReadOnly Property ProductsVirtPath() As String
        Get
            Return Path.Combine(TempFolderVirtPath, "Products")
        End Get
    End Property
    Private ReadOnly Property EmployeesVirtPath() As String
        Get
            Return Path.Combine(TempFolderVirtPath, "Employees")
        End Get
    End Property
    Private ReadOnly Property CustomersVirtPath() As String
        Get
            Return Path.Combine(TempFolderVirtPath, "Customers")
        End Get
    End Property
    Private ReadOnly Property CustomerEmployeesVirtPath() As String
        Get
            Return Path.Combine(CustomersVirtPath, "CustomerEmployees")
        End Get
    End Property
    Private ReadOnly Property CrestsVirtPath() As String
        Get
            Return Path.Combine(CustomersVirtPath, "Crests")
        End Get
    End Property

    Public Function ProductImagesVirtPath(ByVal productID As Long) As String
        Return Path.Combine(ProductsVirtPath, productID.ToString())
    End Function
    Public Function ProductThumbVirtPath(ByVal productID As Long) As String
        Return Path.Combine(ProductImagesVirtPath(productID), ThumbnailsFolderName)
    End Function

    Public Function ProductMainImageVirtPath(ByVal productID As Long) As String
        Return Path.Combine(ProductsVirtPath, ImageName(productID))
    End Function
    Public Function ProductImageVirtPath(ByVal productID As Long, ByVal imageID As Long) As String
        Return Path.Combine(ProductImagesVirtPath(productID), ImageName(imageID))
    End Function
    Public Function ProductThumbImageVirtPath(ByVal productID As Long, ByVal imageID As Long) As String
        Return Path.Combine(ProductThumbVirtPath(productID), ImageName(imageID))
    End Function

    Public Function EmployeeImageVirtPath(ByVal id As Long) As String
        Return Path.Combine(EmployeesVirtPath, ImageName(id))
    End Function
    Public Function CustomerEmployeeImageVirtPath(ByVal id As Long) As String
        Return Path.Combine(CustomerEmployeesVirtPath, ImageName(id))
    End Function
    Public Function CrestImageVirtPath(ByVal id As Long) As String
        Return Path.Combine(CrestsVirtPath, ImageName(id))
    End Function

    Private ReadOnly Property TempFolderPath() As String
        Get
            Return MapPath(TempFolderVirtPath)
        End Get
    End Property
    Private ReadOnly Property ProductsPath() As String
        Get
            Return MapPath(ProductsVirtPath)
        End Get
    End Property
    Private ReadOnly Property EmployeesPath() As String
        Get
            Return MapPath(EmployeesVirtPath)
        End Get
    End Property
    Private ReadOnly Property CustomersPath() As String
        Get
            Return MapPath(CustomersVirtPath)
        End Get
    End Property
    Private ReadOnly Property CustomerEmployeesPath() As String
        Get
            Return MapPath(CustomerEmployeesVirtPath)
        End Get
    End Property
    Private ReadOnly Property CrestsPath() As String
        Get
            Return MapPath(CrestsVirtPath)
        End Get
    End Property

    Private Function ProductImagesPath(ByVal productID As Long) As String
        Return MapPath(ProductImagesVirtPath(productID))
    End Function
    Private Function ProductThumbPath(ByVal productID As Long) As String
        Return MapPath(ProductThumbVirtPath(productID))
    End Function

    Private Function ProductMainImagePath(ByVal productID As Long) As String
        Return MapPath(ProductMainImageVirtPath(productID))
    End Function
    Private Function ProductImagePath(ByVal productID As Long, ByVal imageID As Long) As String
        Return MapPath(ProductImageVirtPath(productID, imageID))
    End Function
    Private Function ProductThumbImagePath(ByVal productID As Long, ByVal imageID As Long) As String
        Return MapPath(ProductThumbImageVirtPath(productID, imageID))
    End Function

    Private Function EmployeeImagePath(ByVal id As Long) As String
        Return MapPath(EmployeeImageVirtPath(id))
    End Function
    Private Function CustomerEmployeeImagePath(ByVal id As Long) As String
        Return MapPath(CustomerEmployeeImageVirtPath(id))
    End Function
    Private Function CrestImagePath(ByVal id As Long) As String
        Return MapPath(CrestImageVirtPath(id))
    End Function

    Private ReadOnly Property DefaultEmployeeImagePath() As String
        Get
            Return MapPath(Path.Combine("~", "Content", "Images", DefaultEmployeeImageName))
        End Get
    End Property

    Private Function ImageName(ByVal id As Long) As String
        Return String.Format(ImageStringFormat, id)
    End Function
    Private Function MapPath(ByVal virtualPath As String) As String ' ~/
        Return Path.Combine(SiteRootPath, virtualPath.Substring(2))
    End Function


    Private siteRootPath_Renamed As String
    Private ReadOnly Property SiteRootPath() As String
        Get
            If String.IsNullOrEmpty(siteRootPath_Renamed) Then
                siteRootPath_Renamed = HttpContext.Current.Server.MapPath("~/")
            End If
            Return siteRootPath_Renamed
        End Get
    End Property

    Public Sub EnsureImages()
        If (Not Directory.Exists(TempFolderPath)) OrElse Directory.GetFiles(TempFolderPath, "*.jpg", SearchOption.AllDirectories).Length = 0 Then
            LoadImagesFromDB()
        End If
        HttpRuntime.Cache.Insert(EnsureImagesByTimeoutKey, Me, Nothing, Date.UtcNow.Add(TimeSpan.FromMinutes(EnsureImagesInterval)), Cache.NoSlidingExpiration, CacheItemPriority.NotRemovable, Sub(k, v, r) EnsureImages())
    End Sub
    Public Sub LoadImagesFromDB()
        Try
            If Not Directory.Exists(TempFolderPath) Then
                Directory.CreateDirectory(TempFolderPath)
            End If
            LoadProductImages()
            LoadEmployeeImages()
            LoadCustomerImages()
            ResizedPictureHash.Clear()
        Catch
            If Directory.Exists(TempFolderPath) Then
                Directory.Delete(TempFolderPath, True)
            End If
        End Try
    End Sub
    Private Sub LoadProductImages()
        Dim productsInfo = DataProvider.Products.Select(Function(p) New With {Key .ID = p.Id, Key .MainPicture = p.PrimaryImage, Key .Images = p.Images.Select(Function(i) New With {Key .ID = i.Id, Key .Picture = i.Picture}).ToList()}).ToList()
        If Not Directory.Exists(ProductsPath) Then
            Directory.CreateDirectory(ProductsPath)
        End If
        For Each productInfo In productsInfo
            If Not Directory.Exists(ProductImagesPath(productInfo.ID)) Then
                Directory.CreateDirectory(ProductImagesPath(productInfo.ID))
            End If
            If Not Directory.Exists(ProductThumbPath(productInfo.ID)) Then
                Directory.CreateDirectory(ProductThumbPath(productInfo.ID))
            End If
            For Each imageInfo In productInfo.Images
                CreateImage(ProductImagePath(productInfo.ID, imageInfo.ID), imageInfo.Picture.Data)
                CreateImage(ProductThumbImagePath(productInfo.ID, imageInfo.ID), imageInfo.Picture, 250, True)
            Next imageInfo
            CreateImage(ProductMainImagePath(productInfo.ID), productInfo.MainPicture, 250, True)
        Next productInfo
    End Sub
    Private Sub LoadEmployeeImages()
        Dim employeesInfo = DataProvider.Employees.Select(Function(e) New With {Key .ID = e.Id, Key .Image = e.Picture}).ToList()
        If Not Directory.Exists(EmployeesPath) Then
            Directory.CreateDirectory(EmployeesPath)
        End If
        For Each info In employeesInfo
            If info.Image IsNot Nothing Then
                CreateImage(EmployeeImagePath(info.ID), info.Image, 200, False)
            Else
                CreateDefaultEmployeeImage(info.ID)
            End If
        Next info
    End Sub
    Private Sub LoadCustomerImages()
        Dim customerEmployeesInfo = DataProvider.CustomerEmployees.Select(Function(e) New With {Key .ID = e.Id, Key .Image = e.Picture}).ToList()
        Dim crestsInfo = DataProvider.Crests.Select(Function(c) New With {Key .ID = c.Id, Key .ImageData = c.LargeImage}).ToList()
        If Not Directory.Exists(CustomersPath) Then
            Directory.CreateDirectory(CustomersPath)
        End If
        If Not Directory.Exists(CrestsPath) Then
            Directory.CreateDirectory(CrestsPath)
        End If
        If Not Directory.Exists(CustomerEmployeesPath) Then
            Directory.CreateDirectory(CustomerEmployeesPath)
        End If
        For Each info In customerEmployeesInfo
            CreateImage(CustomerEmployeeImagePath(info.ID), info.Image, 200, False)
        Next info
        For Each info In crestsInfo
            CreateImage(CrestImagePath(info.ID), info.ImageData)
        Next info
    End Sub

    Public Sub CreateDefaultEmployeeImage(ByVal employeeID As Long)
        Dim path = EmployeeImagePath(employeeID)
        If Not File.Exists(path) Then
            File.Copy(DefaultEmployeeImagePath, path)
        End If
    End Sub

    Public Sub AddProductImage(ByVal product As Product, ByVal data() As Byte)
        If product Is Nothing Then
            Return
        End If
        Dim image = DataProvider.CreateProductImage(product, data)
        CreateImage(ProductImagePath(product.Id, image.Id), image.Picture.Data)
        CreateImage(ProductThumbImagePath(product.Id, image.Id), image.Picture, 250, True)
    End Sub

    Private Function ResizeImage(ByVal picture As Picture, ByVal dimension As Integer, ByVal isWidth As Boolean) As Byte()
        If Not ResizedPictureHash.ContainsKey(picture.Id) Then
            ResizedPictureHash(picture.Id) = ResizeImageCore(picture.Data, dimension, isWidth)
        End If
        Return ResizedPictureHash(picture.Id)
    End Function
    Private Function ResizeImageCore(ByVal data() As Byte, ByVal dimension As Integer, ByVal isWidth As Boolean) As Byte()
        Using original = Image.FromStream(New MemoryStream(data))
        Using newImage = InscribeImage(original, dimension, True)
        Using outStream = New MemoryStream()
            newImage.Save(outStream, ImageFormat.Jpeg)
            Return outStream.ToArray()
        End Using
        End Using
        End Using
    End Function
    Private Sub CreateImage(ByVal path As String, ByVal picture As Picture, ByVal dimension As Integer, ByVal isWidth As Boolean)
        Dim data = ResizeImage(picture, dimension, isWidth)
        CreateImage(path, data)
    End Sub
    Private Shared Sub CreateImage(ByVal path As String, ByVal data() As Byte)
        File.WriteAllBytes(path, data)
    End Sub

    Private Shared Function InscribeImage(ByVal image As Image, ByVal dimension As Integer, ByVal isWidth As Boolean) As Image
        Dim size As New Size(If(isWidth, dimension, CInt(image.Width) * dimension \ image.Height),If((Not isWidth), dimension, CInt(image.Height) * dimension \ image.Width))
        Dim result = New Bitmap(size.Width, size.Height)
        Using graphics = System.Drawing.Graphics.FromImage(result)
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
            graphics.DrawImage(image, New Rectangle(New Point(0, 0), size))
        End Using
        Return result
    End Function

    Public Function GetPriorityImageUrl(ByVal priority As EmployeeTaskPriority) As String
        Return Path.Combine("~/Content/Images/Priority/", GetPriorityImageName(priority))
    End Function
    Private Function GetPriorityImageName(ByVal priority As EmployeeTaskPriority) As String
        Select Case priority
            Case EmployeeTaskPriority.Low
                Return "Priority1.png"
            Case EmployeeTaskPriority.Normal
                Return "Priority2.png"
            Case EmployeeTaskPriority.High
                Return "Priority3.png"
            Case EmployeeTaskPriority.Urgent
                Return "Priority4.png"
        End Select
        Return String.Empty
    End Function
End Class

Public Class FilterBag
    Private Const SearchTextHiddenFieldKey As String = "SearchText", FilterControlExpressionHiddenFieldKey As String = "FilterControlExpression", CustomFilterItemsSessionKey As String = "5485495F-0268-48DB-A531-7D86F7A97905"

    Public Sub New(ByVal name As String, ByVal defaultFilters As Dictionary(Of String, FilterItem), ParamArray ByVal searchFieldNames() As String)
        Me.Name = name
        DefaultFilterItems = defaultFilters
        Me.SearchFieldNames = New HashSet(Of String)(searchFieldNames)
    End Sub

    Protected ReadOnly Property Session() As HttpSessionState
        Get
            Return DemoUtils.Context.Session
        End Get
    End Property
    Private privateName As String
    Public Property Name() As String
        Get
            Return privateName
        End Get
        Private Set(ByVal value As String)
            privateName = value
        End Set
    End Property

    ' not modified
    Private privateDefaultFilterItems As Dictionary(Of String, FilterItem)
    Protected Property DefaultFilterItems() As Dictionary(Of String, FilterItem)
        Get
            Return privateDefaultFilterItems
        End Get
        Private Set(ByVal value As Dictionary(Of String, FilterItem))
            privateDefaultFilterItems = value
        End Set
    End Property
    Private privateSearchFieldNames As HashSet(Of String)
    Public Property SearchFieldNames() As HashSet(Of String)
        Get
            Return privateSearchFieldNames
        End Get
        Private Set(ByVal value As HashSet(Of String))
            privateSearchFieldNames = value
        End Set
    End Property

    ' depend on client state
    Public ReadOnly Property SearchText() As String
        Get
            Dim value As String = Nothing
            DemoUtils.TryGetClientStateValue(Of String)(SearchTextHiddenFieldKey, value)
            Return If((Not String.IsNullOrEmpty(value)), value, String.Empty)
        End Get
    End Property
    Public Property FilterControlExpression() As String
        Get
            Dim value As String = Nothing
            DemoUtils.TryGetClientStateValue(Of String)(FilterControlExpressionHiddenFieldKey, value)
            Return If((Not String.IsNullOrEmpty(value)), value, String.Empty)
        End Get
        Set(ByVal value As String)
            DemoUtils.TrySetClientStateValue(Of String)(FilterControlExpressionHiddenFieldKey, value)
        End Set
    End Property
    Protected ReadOnly Property CustomFilterItems() As Dictionary(Of String, FilterItem)
        Get
            Dim key = CustomFilterItemsSessionKey & Name
            If Session(key) Is Nothing Then
                Session(key) = New Dictionary(Of String, FilterItem)()
            End If
            Return DirectCast(Session(key), Dictionary(Of String, FilterItem))
        End Get
    End Property

    Protected ReadOnly Property SearchCriteria() As CriteriaOperator
        Get
            If String.IsNullOrEmpty(SearchText) OrElse SearchFieldNames.Count = 0 Then
                Return Nothing
            End If
            Dim operators = SearchFieldNames.Select(Function(f) New FunctionOperator(FunctionOperatorType.Contains, New OperandProperty(f), SearchText)).OfType(Of CriteriaOperator)().ToList()
            Return If(operators.Count > 1, New GroupOperator(GroupOperatorType.Or, operators), operators(0))
        End Get
    End Property
    Public Function GetExpression(ByVal useSearch As Boolean) As String
        Dim search = If(useSearch, SearchCriteria, Nothing)
        Dim filterControl = CriteriaOperator.Parse(FilterControlExpression)
        Dim criteria = GroupOperator.And(filterControl, search)
        Return If((Not Object.ReferenceEquals(criteria, Nothing)), criteria.ToString(), String.Empty)
    End Function

    Public Function GetFilterItems() As Dictionary(Of String, FilterItem)
        Return DefaultFilterItems.Union(CustomFilterItems).ToDictionary(Function(p) p.Key, Function(p) p.Value)
    End Function
    Public Function CreateCustomFilter(ByVal name As String, ByVal criteria As String) As FilterItem
        Return CustomFilterItems.CreateItem(name, criteria, True)
    End Function

    Public Function GetActiveFilterName() As String
        Dim item = GetFilterItems().FirstOrDefault(Function(p) GetIsActiveFilter(p.Value.Expression))
        Return If((Not Object.ReferenceEquals(item, Nothing)), item.Key, String.Empty)
    End Function
    Public Function GetIsActiveFilter(ByVal expression As String) As Boolean
        Return expression = FilterControlExpression
    End Function
End Class

Public Module DemoExtentionUtils
    <System.Runtime.CompilerServices.Extension> _
    Public Function CreateItem(ByVal self As Dictionary(Of String, FilterItem), ByVal name As String, ByVal criteria As String, Optional ByVal custom As Boolean = False) As FilterItem
        Return self.CreateItem(name, CriteriaOperator.Parse(criteria), custom)
    End Function
    <System.Runtime.CompilerServices.Extension> _
    Public Function CreateItem(ByVal self As Dictionary(Of String, FilterItem), ByVal name As String, ByVal criteria As CriteriaOperator, Optional ByVal custom As Boolean = False) As FilterItem
        Dim key = String.Format("{0}_{1}", name, custom)
        If (Not self.ContainsKey(key)) OrElse custom Then
            Dim expression = If((Not Object.ReferenceEquals(criteria, Nothing)), criteria.ToString(), String.Empty)
            self(key) = New FilterItem() With {.Name = name, .Expression = expression, .IsCustom = custom}
        End If
        Return self(key)
    End Function
    <System.Runtime.CompilerServices.Extension> _
    Public Function Add(Of T)(ByVal self As ArrayList, ByVal item As T) As T
        self.Add(item)
        Return item
    End Function
    <System.Runtime.CompilerServices.Extension> _
    Public Function Add(ByVal self As ArrayList, ByVal column As FilterControlComboBoxColumn, ByVal enumType As Type) As FilterControlComboBoxColumn
        self.Add(column)
        DemoUtils.BindComboBoxToEnum(column.PropertiesComboBox, enumType)
        Return column
    End Function

    <System.Runtime.CompilerServices.Extension> _
    Public Function Add(ByVal collection As TableRowCollection) As TableRow ' TODO check why it doesn't work
        Dim row = New TableRow()
        collection.Add(row)
        Return row
    End Function
End Module
