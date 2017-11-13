Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Spreadsheet
Imports Modules.MailMergeDataSets
Imports Modules.MailMergeDataSets.InvoiceDataSetTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class MailMergeInvoiceModule
		Inherits MailMergeModuleBase
		Protected Overrides Sub LoadTemplate(ByVal spreadsheetControl As SpreadsheetControl)
			spreadsheetControl.Document.LoadDocument(DemoUtils.GetRelativePath("MailMergeTemplates\InvoiceTemplate.xlsx"))
		End Sub
		Protected Overrides Sub LoadData(ByVal book As IWorkbook)
			Dim dataSet As New InvoiceDataSet()
			Dim invoicesTableAdapter As New InvoicesTableAdapter()
			invoicesTableAdapter.Fill(dataSet.Invoices)
			book.MailMergeDataSource = dataSet
			book.MailMergeDataMember = "Invoices"
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
