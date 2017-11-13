Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraRichEdit
Imports System.Data.OleDb
Imports System.Data
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraTab
Imports DevExpress.XtraBars
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Globalization
Imports DevExpress.Utils
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Office.Services

Namespace DevExpress.XtraRichEdit.Demos
#Region "MasterDetailMailMergeModule"
    Partial Public Class MasterDetailMailMergeModule
        Inherits DevExpress.XtraRichEdit.Demos.TutorialControl
#Region "Fields"
        Private connection As OleDbConnection
        Private dataTable As DataTable
        Private cultureInfo As CultureInfo
        Private dataTableProducts As DataTable
        Private categoryID As Integer = -1
#End Region

        Public Sub New()
            InitializeComponent()

            RtfLoadHelper.Load("MasterDetailMailMergeTemplate.rtf", templateRichEditControl)
            CType(New RichEditDemoExceptionsHandler(templateRichEditControl), RichEditDemoExceptionsHandler).Install()
            RtfLoadHelper.Load("MasterDetailMailMergeMaster.rtf", masterRichEditControl)
            CType(New RichEditDemoExceptionsHandler(masterRichEditControl), RichEditDemoExceptionsHandler).Install()
            RtfLoadHelper.Load("MasterDetailMailMergeDetail.rtf", detailRichEditControl)
            CType(New RichEditDemoExceptionsHandler(detailRichEditControl), RichEditDemoExceptionsHandler).Install()

            cultureInfo = cultureInfo.CreateSpecificCulture("en-US")
        End Sub

#Region "Properties"
        Public Overrides ReadOnly Property PrintingRichEditControl() As RichEditControl
            Get
                Return templateRichEditControl
            End Get
        End Property
#End Region

        Private Sub resultingRichEditControl_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs) Handles resultingRichEditControl.CalculateDocumentVariable
            If e.VariableName = "Categories" Then
                masterRichEditControl.Options.MailMerge.DataSource = dataTable

                Dim result As IRichEditDocumentServer
                result = masterRichEditControl.CreateDocumentServer()
                AddHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable
                masterRichEditControl.MailMerge(result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If
        End Sub
        Private Sub result_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim currentCategoryID As Integer = GetID(e.Arguments(0).Value)
            If currentCategoryID = -1 Then
                Return
            End If

            If categoryID <> currentCategoryID Then
                dataTableProducts = GetDataTable(currentCategoryID)
                categoryID = currentCategoryID
            End If

            If e.VariableName = "Products" Then
                detailRichEditControl.Options.MailMerge.DataSource = dataTableProducts

                Dim result As IRichEditDocumentServer
                result = detailRichEditControl.CreateDocumentServer()

                Dim options As MailMergeOptions = detailRichEditControl.CreateMailMergeOptions()
                options.MergeMode = MergeMode.JoinTables
                AddHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable
                detailRichEditControl.MailMerge(options, result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If
            If e.VariableName = "LowestPrice" Then
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Compute("Min(UnitPrice)", String.Empty))
                e.Handled = True
            End If
            If e.VariableName = "HighestPrice" Then
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Compute("Max(UnitPrice)", String.Empty))
                e.Handled = True
            End If
            If e.VariableName = "ItemsCount" Then
                e.Value = dataTableProducts.Rows.Count
                e.Handled = True
            End If
            If e.VariableName = "TotalSales" Then
                Dim expression As String = String.Format("CategoryID = {0}", e.Arguments(0).Value)
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTable.Select(expression)(0)("TotalSales"))
                e.Handled = True
            End If
        End Sub
        Private Sub detail_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim productId As Integer = GetID(e.Arguments(0).Value)
            If productId = -1 Then
                Return
            End If
            If e.VariableName = "UnitPrice" Then
                Dim expression As String = String.Format("ProductID = {0}", productId)
                e.Value = String.Format(cultureInfo, "{0:C2}", dataTableProducts.Select(expression)(0)("UnitPrice"))
                e.Handled = True
            End If
        End Sub
        Protected Friend Overridable Function GetID(ByVal value As String) As Integer
            Dim result As Integer
            If Int32.TryParse(value, result) Then
                Return result
            End If
            Return -1
        End Function
        Protected Friend Overridable Function GetDataTable(ByVal categoryID As Integer) As DataTable
            Dim cmd As String = String.Format("SELECT * FROM Products WHERE CategoryID = {0}", categoryID)
            Dim selectCommand As New OleDbCommand(cmd, connection)
            Dim adapter As New OleDbDataAdapter(selectCommand)
            Dim result As New DataSet()
            adapter.Fill(result)
            Return result.Tables(0)
        End Function
        Private Sub tabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles tabControl.SelectedPageChanged
            Dim richEditControl As RichEditControl = CType(tabControl.SelectedTabPage.Tag, RichEditControl)
            mergeToNewDocumentPageGroup1.Visible = Not Object.ReferenceEquals(richEditControl, resultingRichEditControl)
            richEditBarController1.RichEditControl = richEditControl
        End Sub
        Private Sub MasterDetailMailMergeModule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            FillData()
            Dim uriService As IUriStreamService = CType(masterRichEditControl.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProvider(dataTable, "FirstOfPicture"))

            MergeToNewDocument()

            ShowAllFieldCodes(templateRichEditControl)
            ShowAllFieldCodes(masterRichEditControl)
            ShowAllFieldCodes(detailRichEditControl)
        End Sub
        Private Sub mergeToNewDocument_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles mergeToNewDocumentItem1.ItemClick
            MergeToNewDocument()
        End Sub
        Private Shared fakeDataSource As List(Of Integer) = CreateFakeDataSource()
        Private Shared Function CreateFakeDataSource() As List(Of Integer)
            Dim result As New List(Of Integer)()
            result.Add(0)
            Return result
        End Function
        Protected Friend Overridable Sub MergeToNewDocument()
            Using dlg As New WaitDialogForm("Please Wait", "Loading ...")
                templateRichEditControl.Options.MailMerge.DataSource = fakeDataSource
                templateRichEditControl.MailMerge(resultingRichEditControl.Document)

                tabControl.SelectedTabPage = resultingDocumentTabPage
            End Using
        End Sub
        Protected Friend Overridable Sub ShowAllFieldCodes(ByVal control As IRichEditControl)
            Dim command As New ShowAllFieldCodesCommand(control)
            command.Execute()
        End Sub
        Private Sub FillData()
            Me.connection = New OleDbConnection()
            Dim path As String = DemoUtils.GetRelativePath("nwind.mdb")
            If path.Length <= 0 Then
                Return
            End If
            DemoUtils.SetConnectionString(Me.connection, path)
            Dim cmd As String = "SELECT DISTINCTROW Categories.CategoryName, Sum(CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100) AS TotalSales, Categories.CategoryID, Categories.Description, First(Categories.Picture) AS FirstOfPicture FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN (Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID GROUP BY Categories.CategoryName, Categories.CategoryID, Categories.Description"
            Dim selectCommand As New OleDbCommand(cmd, connection)

            Dim adapter As New OleDbDataAdapter(selectCommand)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet)

            dataTable = dataSet.Tables(0)
            dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("CategoryID")}
        End Sub
    End Class
#End Region
End Namespace
