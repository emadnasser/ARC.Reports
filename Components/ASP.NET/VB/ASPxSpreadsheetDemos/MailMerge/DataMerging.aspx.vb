Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.IO
Imports System.Xml.Serialization
Imports DevExpress.Web.Demos
Imports DevExpress.Spreadsheet

Partial Public Class MailMerge_DataMerging
	Inherits OfficeDemoPage
	Private Const StartRowIndex As Integer = 10, MaxReportRowsCount As Integer = 15

	Protected ReadOnly Property Worksheet() As Worksheet
		Get
			Return Spreadsheet.Document.Worksheets.ActiveWorksheet
		End Get
	End Property

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		SpreadsheetDemoUtils.HideFileTab(Spreadsheet)

		If Page.IsPostBack Then
			Return
		End If

		Dim filePath = Path.Combine(DirectoryManagmentUtils.CurrentDataDirectory, "ExpenseReport.xlsx")
		Spreadsheet.Open(filePath)

		Dim expenses = LoadExpensesReportData()
		FillGeneralReportInfo(expenses.Info)
		FillReport(expenses.Expenses)
		Spreadsheet.Document.Worksheets.ActiveWorksheet.ActiveView.ShowGridlines = False
		Spreadsheet.Document.History.Clear()
	End Sub
	Private Function LoadExpensesReportData() As ExpensesReport
		Using stream As Stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Expenses.xml"))
			Dim serializer As New XmlSerializer(GetType(ExpensesReport))
			Return CType(serializer.Deserialize(stream), ExpensesReport)
		End Using
	End Function
	Private Sub FillGeneralReportInfo(ByVal info As ExpensesInfo)
		Worksheet("D2").Value = info.Purpose
		Worksheet("D3").Value = info.StatementNumber

		Worksheet("C7").Value = info.EmployeeName
		Worksheet("C8").Value = info.EmployeeDepartment
		Worksheet("G7").Value = info.EmployeePosition
		Worksheet("G8").Value = info.Manager
		Worksheet("K7").Value = info.SSN
		Worksheet("K8").Value = info.EmployeeID
	End Sub
	Private Sub FillReport(ByVal report As List(Of Expense))
		Dim reportCount As Integer = Math.Min(report.Count, MaxReportRowsCount)
		For i As Integer = 0 To reportCount - 1
			Dim expense As Expense = report(i)
			Dim rowOffset As Integer = StartRowIndex + i + 1
			Worksheet("B" & rowOffset).Value = expense.CreationDate
			Worksheet("C" & rowOffset).Value = expense.Account
			Worksheet("D" & rowOffset).Value = expense.Description
			Worksheet("F" & rowOffset).Value = expense.Hotel
			Worksheet("H" & rowOffset).Value = expense.Transport
			Worksheet("I" & rowOffset).Value = expense.Fuel
			Worksheet("J" & rowOffset).Value = expense.Meals
			Worksheet("L" & rowOffset).Value = expense.Phone
			Worksheet("M" & rowOffset).Value = expense.Entertainment
			Worksheet("N" & rowOffset).Value = expense.Misc
		Next i
	End Sub
End Class
