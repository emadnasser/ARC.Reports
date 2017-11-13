Imports System
Imports System.Linq
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.Xpf.RichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Office.Services

Imports System.Data
Imports DevExpress.DemoData.Models

Namespace RichEditDemo
    Partial Public Class MasterDetailMailMerge
        Inherits RichEditDemoModule

        Private dataSetCategories As List(Of Category)
        Private dataSetProducts As List(Of Product)
        Private dataSetOrderDetails As List(Of OrderDetail)
        Private cultureInfo As CultureInfo
        Private currentDataSetProducts As List(Of Product)
        Private categoryID As Integer = -1

        Public Sub New()
            InitializeComponent()

            RtfLoadHelper.Load("MasterDetailMailMergeTemplate.rtf", templateRichEditControl)
            RtfLoadHelper.Load("MasterDetailMailMergeMaster.rtf", masterRichEditControl)
            RtfLoadHelper.Load("MasterDetailMailMergeDetail.rtf", detailRichEditControl)

            dataSetCategories = NWindContext.Create().Categories.ToList()
            dataSetProducts = NWindContext.Create().Products.ToList()
            dataSetOrderDetails = NWindContext.Create().OrderDetails.ToList()

            Dim uriService As IUriStreamService = DirectCast(masterRichEditControl.GetService(GetType(IUriStreamService)), IUriStreamService)
            uriService.RegisterProvider(New DBUriStreamProviderBase(Of Category)(NWindContext.Create().Categories.ToList(), Function(cs, id) cs.First(Function(c) c.CategoryID = id).Picture))

            cultureInfo = New CultureInfo("en-US")
        End Sub

        Private Sub resultingRichEditControl_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            If e.VariableName = "Categories" Then
                masterRichEditControl.Options.MailMerge.DataSource = dataSetCategories.ToList()

                Dim result As IRichEditDocumentServer = masterRichEditControl.CreateDocumentServer()
                AddHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable
                masterRichEditControl.MailMerge(result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If
        End Sub
        Private Sub result_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim arguments As ArgumentCollection = e.Arguments
            Dim currentCategoryID As Integer = GetID(arguments(0).Value)
            If currentCategoryID = -1 Then
                Return
            End If
            If categoryID <> currentCategoryID Then
                currentDataSetProducts = GetData(currentCategoryID).ToList()
                categoryID = currentCategoryID
            End If

            If e.VariableName = "Products" Then
                detailRichEditControl.Options.MailMerge.DataSource = currentDataSetProducts

                Dim result As IRichEditDocumentServer = detailRichEditControl.CreateDocumentServer()

                Dim options As MailMergeOptions = detailRichEditControl.CreateMailMergeOptions()
                options.MergeMode = MergeMode.JoinTables
                AddHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable
                detailRichEditControl.MailMerge(options, result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If
            If e.VariableName = "LowestPrice" Then
                e.Value = currentDataSetProducts.Min(Function(p) p.UnitPrice)
                e.Handled = True
            End If
            If e.VariableName = "HighestPrice" Then
                e.Value = currentDataSetProducts.Max(Function(p) p.UnitPrice)
                e.Handled = True
            End If
            If e.VariableName = "ItemsCount" Then
                e.Value = currentDataSetProducts.Count()
                e.Handled = True
            End If
            If e.VariableName = "TotalSales" Then
                e.Value = GetTotalSales(arguments)
                e.Handled = True
            End If
        End Sub
        Protected Friend Overridable Sub detail_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim productId As Integer = GetID(e.Arguments(0).Value)
            If productId = -1 Then
                Return
            End If
            If e.VariableName = "UnitPrice" Then
                e.Value = GetUnitPrice(e.Arguments)
                e.Handled = True
            End If
        End Sub
        Protected Friend Overridable Function GetID(ByVal value As String) As Integer
            Dim result As Integer = Nothing
            If Int32.TryParse(value, result) Then
                Return result
            End If
            Return -1
        End Function
        Protected Friend Overridable Function GetData(ByVal categoryID As Integer) As List(Of Product)
            Return dataSetProducts.Where(Function(o) CBool(o.CategoryID = CType(categoryID, Long?))).ToList()
        End Function
        Protected Friend Overridable Function GetTotalSales(ByVal arguments As ArgumentCollection) As Object
            Dim sum As Decimal = NWindContext.Create().OrderDetailsExtended.Sum(Function(o) o.ExtendedPrice)
            Return String.Format(cultureInfo, "{0:C2}", sum)
        End Function
        Protected Friend Overridable Function GetUnitPrice(ByVal arguments As ArgumentCollection) As Object
            Dim price As Decimal = CDec(currentDataSetProducts.First(Function(p) p.ProductID = Convert.ToInt64(arguments(0).Value)).UnitPrice)
            Return String.Format(cultureInfo, "{0:C2}", price)
        End Function
        Private Sub DemoModuleControl_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            ribbon.SelectedPage = pageMailings
            MergeToNewDocument()
            ShowAllFieldCodes(templateRichEditControl)
            ShowAllFieldCodes(masterRichEditControl)
            ShowAllFieldCodes(detailRichEditControl)
        End Sub
        Private Sub mergeToNewDocument_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            MergeToNewDocument()
        End Sub
        Private Shared fakeDataSource As List(Of Integer) = CreateFakeDataSource()
        Private Shared Function CreateFakeDataSource() As List(Of Integer)
            Dim result As New List(Of Integer)()
            result.Add(0)
            Return result
        End Function
        Protected Friend Overridable Sub MergeToNewDocument()
            masterRichEditControl.ApplyTemplate()
            detailRichEditControl.ApplyTemplate()
            resultingRichEditControl.ApplyTemplate()

            templateRichEditControl.Options.MailMerge.DataSource = fakeDataSource
            templateRichEditControl.MailMerge(resultingRichEditControl.Document)

            tabControl.SelectedItem = resultingDocumentTabItem
        End Sub
        Protected Friend Overridable Sub ShowAllFieldCodes(ByVal control As IRichEditControl)
            Dim command As New ShowAllFieldCodesCommand(control)
            command.Execute()
        End Sub
        Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlSelectionChangedEventArgs)
            If tabControl Is Nothing OrElse richEditControlProvider Is Nothing Then
                Return
            End If

            Dim selectedRichEditControl As RichEditControl = GetSelectedRichEditControl()
            ResetBarManagers()
            selectedRichEditControl.BarManager = barManager1
            selectedRichEditControl.Ribbon = ribbon
            richEditControlProvider.RichEditControl = selectedRichEditControl

            Dim isSelectedResultingControl As Boolean = Object.ReferenceEquals(selectedRichEditControl, resultingRichEditControl)
            Dim isPageMailingsSelected As Boolean = pageMailings.IsSelected
            Dim isPageMailingsWithoutMergeSelected As Boolean = pageMailingsWithoutMerge.IsSelected
            Dim oldPageMailingsVisible As Boolean = pageMailings.IsVisible
            pageMailings.IsVisible = Not isSelectedResultingControl
            pageMailingsWithoutMerge.IsVisible = isSelectedResultingControl

            If oldPageMailingsVisible <> pageMailings.IsVisible Then
                pageMailings.IsSelected = (Not isSelectedResultingControl) AndAlso isPageMailingsWithoutMergeSelected
                pageMailingsWithoutMerge.IsSelected = isSelectedResultingControl AndAlso isPageMailingsSelected
            End If
        End Sub
        Protected Friend Overridable Function GetSelectedRichEditControl() As RichEditControl
            Dim selectedTabItem As Object = tabControl.SelectedItem
            If selectedTabItem Is templateTabItem Then
                Return templateRichEditControl
            End If
            If selectedTabItem Is masterTabItem Then
                Return masterRichEditControl
            End If
            If selectedTabItem Is detailTabItem Then
                Return detailRichEditControl
            End If
            If selectedTabItem Is resultingDocumentTabItem Then
                Return resultingRichEditControl
            End If
            Return Nothing
        End Function
        Protected Friend Overridable Sub ResetBarManagers()
            templateRichEditControl.BarManager = Nothing
            masterRichEditControl.BarManager = Nothing
            detailRichEditControl.BarManager = Nothing
            resultingRichEditControl.BarManager = Nothing
            templateRichEditControl.Ribbon = Nothing
            masterRichEditControl.Ribbon = Nothing
            detailRichEditControl.Ribbon = Nothing
            resultingRichEditControl.Ribbon = Nothing
        End Sub
    End Class
End Namespace
