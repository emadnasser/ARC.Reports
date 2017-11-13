Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports Modules.MailMergeDataSets
Imports Modules.MailMergeDataSets.MasterDetailDataSetTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MailMergeMasterDetailModule
		Inherits MailMergeModuleBase
		Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
			spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\MasterDetailTemplate.xlsx"))
		End Sub
		Protected Overrides Sub LoadData(ByVal book As IWorkbook)
			Dim dataSet As New MasterDetailDataSet()
			Dim adapter As New SuppliersTableAdapter()
			adapter.Fill(dataSet.Suppliers)
			Dim orderDetailsAdapter As New OrderDetailsTableAdapter()
			orderDetailsAdapter.Fill(dataSet.OrderDetails)
			Dim productsAdapter As New ProductsTableAdapter()
			productsAdapter.Fill(dataSet.Products)
			book.MailMergeDataSource = dataSet
			book.MailMergeDataMember = "Suppliers"
		End Sub
		Protected Overrides ReadOnly Property ShowHideCommentsItem() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property ShowFilterPanel() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
