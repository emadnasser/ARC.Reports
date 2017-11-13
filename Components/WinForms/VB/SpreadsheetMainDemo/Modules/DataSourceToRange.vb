Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports Modules.DataBinding
Imports Modules.DataBinding.nwindOrdersTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DataSourceToRangeModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private dataView As DataView
		Private previousRange As Range
		Private locked As Boolean = False

		Public Sub New()
			InitializeComponent()

			spreadsheetControl1.Options.Culture = DefaultCulture
			spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"), DocumentFormat.Xlsx)

			Dim dataSet As New nwindOrders()
			BindEditors(dataSet)
			BindDataSourceToWorksheet(dataSet)
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
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
			' Order ID
			Dim ordersAdapter As New OrdersTableAdapter()
			ordersAdapter.Fill(dataSet.Orders)
			edOrderId.Properties.DataSource = dataSet.Orders
			edOrderId.Properties.Columns.Add(New XtraEditors.Controls.LookUpColumnInfo("OrderID"))
			edOrderId.Properties.DisplayMember = "OrderID"
			edOrderId.Properties.ValueMember = "OrderID"
			' Product
			Dim productsAdapter As New ProductsTableAdapter()
			productsAdapter.Fill(dataSet.Products)
			edProductName.Properties.DataSource = dataSet.Products
			edProductName.Properties.Columns.Add(New XtraEditors.Controls.LookUpColumnInfo("ProductName"))
			edProductName.Properties.DisplayMember = "ProductName"
			edProductName.Properties.ValueMember = "ProductName"
		End Sub

		Private Sub edOrderId_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edOrderId.EditValueChanged
			If (Not locked) Then
				SetupDataView()
			End If
		End Sub

		Private Sub edProductName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles edProductName.EditValueChanged
			If (Not locked) Then
				SetupDataView()
			End If
		End Sub

		Private Sub chbDiscount_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chbDiscount.CheckedChanged
			If (Not locked) Then
				SetupDataView()
			End If
		End Sub

		Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
			locked = True
			Try
				edOrderId.EditValue = Nothing
				edProductName.EditValue = Nothing
				chbDiscount.Checked = False
				SetupDataView()
			Finally
				locked = False
			End Try
		End Sub

		Private Sub SetupDataView()
			If dataView Is Nothing Then
				Return
			End If
			Dim sb As New StringBuilder()
			If (Not String.IsNullOrEmpty(edOrderId.Text)) Then
				sb.AppendFormat("OrderID = {0}", edOrderId.Text)
			End If
			If (Not String.IsNullOrEmpty(edProductName.Text)) Then
				If sb.Length > 0 Then
					sb.Append(" AND ")
				End If
				sb.AppendFormat("ProductName = '{0}'", edProductName.Text.Replace("'", "''"))
			End If
			If chbDiscount.Checked Then
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
	End Class
End Namespace
