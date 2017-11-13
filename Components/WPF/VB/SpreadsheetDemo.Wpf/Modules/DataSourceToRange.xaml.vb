﻿Imports System
Imports System.Globalization
Imports System.Data
Imports System.Text
Imports System.Windows.Data
Imports DevExpress.Spreadsheet
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraSpreadsheet.Demos
Imports Modules.DataBinding
Imports Modules.DataBinding.nwindOrdersTableAdapters

Namespace SpreadsheetDemo
    Partial Public Class DataSourceToRange
        Inherits SpreadsheetDemoModule

        Private dataView As DataView
        Private previousRange As Range
        Private locked As Boolean = False

        Public Sub New()
            InitializeComponent()
            Me.spreadsheetControl1.Options.Culture = DefaultCulture
            Me.spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"))
            ribbonControl1.SelectedPage = pageHome

            DemoUtils.SetDatabasePath()
            Dim dataSet As New nwindOrders()
            BindEditors(dataSet)
            BindDataSourceToWorksheet(dataSet)
        End Sub

        Private Sub BindDataSourceToWorksheet(ByVal dataSet As nwindOrders)
            Dim orderDetailsAdapter As New OrderDetailsTableAdapter()
            orderDetailsAdapter.Fill(dataSet.OrderDetails)
            dataView = New DataView(dataSet.OrderDetails)
            dataView.Sort = "OrderID"
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.DataBindings.BindToDataSource(dataView, 4, 1)
            UpdateTotalPrice()
        End Sub

        Private Sub BindEditors(ByVal dataSet As nwindOrders)
            Dim ordersAdapter As New OrdersTableAdapter()
            ordersAdapter.Fill(dataSet.Orders)

            edOrderId.ItemsSource = dataSet.Orders
            edOrderId.DisplayMemberPath = "OrderID"
            edOrderId.SelectedValuePath = "OrderID"
            Dim productsAdapter As New ProductsTableAdapter()
            productsAdapter.Fill(dataSet.Products)
            edProductName.ItemsSource = dataSet.Products
            edProductName.DisplayMemberPath = "ProductName"
            edProductName.SelectedValuePath = "ProductName"
        End Sub

        Private Sub SetupDataView()
            If dataView Is Nothing Then
                Return
            End If
            Dim sb As New StringBuilder()
            Dim order As String = If(edOrderId.SelectedValue IsNot Nothing, edOrderId.SelectedValue.ToString(), String.Empty)
            Dim productName As String = If(edProductName.SelectedValue IsNot Nothing, edProductName.SelectedValue.ToString(), String.Empty)
            If Not String.IsNullOrEmpty(order) Then
                sb.AppendFormat("OrderID = {0}", order)
            End If
            If Not String.IsNullOrEmpty(productName) Then
                If sb.Length > 0 Then
                    sb.Append(" AND ")
                End If
                sb.AppendFormat("ProductName = '{0}'", productName.Replace("'", "''"))
            End If
            If If(chbDiscount.IsChecked, False) Then
                If sb.Length > 0 Then
                    sb.Append(" AND ")
                End If
                sb.Append("Discount > 0")
            End If
            spreadsheetControl1.BeginUpdate()
            Try
                dataView.RowFilter = sb.ToString()
                UpdateTotalPrice()
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub

        Private Sub UpdateTotalPrice()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.BeginUpdate()
            Try
                Dim sheet As Worksheet = workbook.Worksheets(0)
                Dim currentRange As Range = sheet.DataBindings(0).Range
                Dim subtotalRange As Range
                If previousRange IsNot Nothing Then
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex)
                    subtotalRange.ClearContents()
                    If currentRange.RowCount < previousRange.RowCount Then
                        subtotalRange = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1)
                        subtotalRange.ClearContents()
                    End If
                    previousRange = Nothing
                End If
                If dataView.Count > 0 Then
                    previousRange = currentRange
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex)
                    subtotalRange.FormulaInvariant = "=E5*F5*(1-G5)"
                    Dim range As Range = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1)
                    range.Value = "Total"
                    range = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1)
                    range.FormulaInvariant = String.Format("=SUBTOTAL(9,{0})", subtotalRange.GetReferenceA1())
                End If
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub edOrderId_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
            If Not locked Then
                SetupDataView()
            End If
        End Sub

        Private Sub edProductName_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
            If Not locked Then
                SetupDataView()
            End If
        End Sub

        Private Sub chbDiscount_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If Not locked Then
                SetupDataView()
            End If
        End Sub

        Private Sub chbDiscount_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            If Not locked Then
                SetupDataView()
            End If
        End Sub

        Private Sub btnResetFilter_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            locked = True
            Try
                edOrderId.SelectedValue = Nothing
                edProductName.SelectedValue = Nothing
                chbDiscount.IsChecked = False
                SetupDataView()
            Finally
                locked = False
            End Try
        End Sub
    End Class
End Namespace