Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports System.Linq
Imports System.IO
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Xpf.Grid
Imports DevExpress.Office.Services

Imports System.Data
Imports DevExpress.DemoData.Models

Namespace RichEditDemo
    Partial Public Class MergeDatabaseRecords
        Inherits RichEditDemoModule

        Private ds As Object
        Private Function CreateDataSource() As IEnumerable(Of Object)
            Return (
                From e In NWindContext.Create().Employees , c In e.Customers
                Select New With {Key .EmployeeID = e.EmployeeID, Key .LastName = e.LastName, Key .FirstName = e.FirstName, Key .Title = e.Title, Key .TitleOfCourtesy = e.TitleOfCourtesy, Key .BirthDate = e.BirthDate, Key .HireDate = e.HireDate, Key .Employees = New With {Key .Address = e.Address, Key .City = e.City, Key .Region = e.Region, Key .PostalCode = e.PostalCode, Key .Country = e.Country}, Key .HomePhone = e.HomePhone, Key .Extension = e.Extension, Key .Photo = e.Photo, Key .Notes = e.Notes, Key .ReportsTo = e.ReportsTo, Key .Email = e.Email, Key .CustomerID = c.CustomerID, Key .CompanyName = c.CompanyName, Key .ContactName = c.ContactName, Key .ContactTitle = c.ContactTitle, Key .Customers = New With {Key .Address = c.Address, Key .City = c.City, Key .Region = c.Region, Key .PostalCode = c.PostalCode, Key .Country = c.Country}, Key .Phone = c.Phone, Key .Fax = c.Fax}).ToList()
        End Function
        Public Sub New()
            InitializeComponent()
            RtfLoadHelper.Load("MailMerge.rtf", richEdit)
            Me.ds = CreateDataSource()

            Dim uriService As IUriStreamService = DirectCast(richEdit.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProviderBase(Of DevExpress.DemoData.Models.Employee)(NWindContext.Create().Employees.ToList(), Function(es, id) es.First(Function(e) e.EmployeeID = id).Photo))
            AddHandler richEdit.Loaded, AddressOf richEdit_Loaded
            AddHandler gridControl1.Loaded, AddressOf gridControl1_Loaded
            AddHandler gridControl1.View.FocusedRowHandleChanged, AddressOf View_FocusedRowChanged
        End Sub

        Private Sub gridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitializeGrid(ds)
        End Sub

        Private Sub richEdit_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitializeRichEdit(ds)
        End Sub

        Private Sub InitializeRichEdit(ByVal ds As Object)
            Dim options As RichEditMailMergeOptions = richEdit.Options.MailMerge
            options.DataSource = Nothing
            options.DataSource = ds
            options.ViewMergedData = True
        End Sub
        Private Sub InitializeGrid(ByVal ds As Object)
            Me.gridControl1.ItemsSource = ds
            Me.gridControl1.View.AllowEditing = False
            Me.gridControl1.View.ShowColumnHeaders = False
            CType(Me.gridControl1.View, GridViewBase).ShowGroupPanel = False
            Me.gridControl1.SortInfo.AddRange(New DevExpress.Xpf.Grid.GridSortInfo("LastName", System.ComponentModel.ListSortDirection.Ascending))
        End Sub
        Private Sub View_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.FocusedRowHandleChangedEventArgs)
            richEdit.Options.MailMerge.ActiveRecord = gridControl1.GetListIndexByRowHandle(e.RowData.RowHandle.Value)
        End Sub
    End Class
    Public Class DBUriStreamProviderBase(Of T)
        Implements IUriStreamProvider

        Private Shared ReadOnly prefix As String = "dbimg://"


        Private ds_Renamed As IEnumerable(Of T)
        Private selector As Func(Of IEnumerable(Of T), Long, Byte())

        Public Sub New(ByVal ds As IEnumerable(Of T), ByVal selector As Func(Of IEnumerable(Of T), Long, Byte()))
            Me.ds_Renamed = ds
            Me.selector = selector
        End Sub

        Public ReadOnly Property Ds() As Object
            Get
                Return ds_Renamed
            End Get
        End Property

        #Region "IUriStreamProvider Members"
        Private Function IUriStreamProvider_GetStream(ByVal uri As String) As Stream Implements IUriStreamProvider.GetStream
            uri = uri.Trim()
            If Not uri.StartsWith(prefix) Then
                Return Nothing
            End If
            Dim strId As String = uri.Substring(prefix.Length).Trim()
            Dim id As Integer = Nothing
            If Not Integer.TryParse(strId, id) Then
                Return Nothing
            End If
            Dim bytes() As Byte = selector(ds_Renamed, id)
            If bytes Is Nothing Then
                Return Nothing
            End If
            Return New MemoryStream(bytes)
        End Function
        #End Region
    End Class
End Namespace
