Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class HomeAccountingModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private generator As HomeAccountingDocumentGenerator
		Public Sub New()
			InitializeComponent()
			spreadsheetControl1.Options.Culture = DefaultCulture
			Dim book As IWorkbook = spreadsheetControl1.Document
			GenerateDocument(book)
			spreadsheetControl1.ReadOnly = True
			spreadsheetControl1.Document.History.Clear()
		End Sub

		Private Sub GenerateDocument(ByVal book As IWorkbook)
			spreadsheetControl1.BeginUpdate()
			Try
				generator = New HomeAccountingDocumentGenerator(book)
				generator.Generate()
			Finally
				spreadsheetControl1.EndUpdate()
			End Try
		End Sub

		Private Sub AddExpensebuttonClick(ByVal sender As Object, ByVal e As EventArgs) Handles addExpenseButton.Click
			AddExpense()
		End Sub

		Private Sub AddIncomeButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles addIncomeButton.Click
			AddIncome()
		End Sub

		Private Sub AddExpense()
			Dim transactionResult As New AddTransactionResult()
			Dim addChargeForm As New AddTransactionForm(False, generator.ExpenseCategorys.ToArray(), transactionResult)
			addChargeForm.SetMenuManager(spreadsheetControl1.MenuManager)
			If addChargeForm.ShowDialog() = DialogResult.OK Then
				spreadsheetControl1.BeginUpdate()
				Try
					generator.AddTransaction(False, transactionResult.TransactionDate, transactionResult.Sum, transactionResult.Category)
				Finally
					spreadsheetControl1.EndUpdate()
				End Try
			End If
		End Sub

		Private Sub AddIncome()
			Dim transactionResult As New AddTransactionResult()
			Dim addGainForm As New AddTransactionForm(True, generator.IncomeCategorys.ToArray(), transactionResult)
			addGainForm.SetMenuManager(spreadsheetControl1.MenuManager)
			If addGainForm.ShowDialog() = DialogResult.OK Then
				spreadsheetControl1.BeginUpdate()
				Try
					generator.AddTransaction(True, transactionResult.TransactionDate, transactionResult.Sum, transactionResult.Category)
				Finally
					spreadsheetControl1.EndUpdate()
				End Try
			End If
		End Sub

		Private Sub ReadOnlyCheckCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles readOnlyCheck.CheckedChanged
			spreadsheetControl1.ReadOnly = readOnlyCheck.Checked
		End Sub

		Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
			Const WM_KEYDOWN As Integer = &H100
			Const WM_SYSKEYDOWN As Integer = &H104

			If (msg.Msg = WM_KEYDOWN) OrElse (msg.Msg = WM_SYSKEYDOWN) Then
				Select Case keyData
					Case Keys.F7
						AddIncome()

					Case Keys.F8
						AddExpense()
				End Select
			End If

			Return MyBase.ProcessCmdKey(msg, keyData)
		End Function

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub

	End Class

	Public Class AddTransactionResult
		Public Property Sum() As Single
		Public Property TransactionDate() As DateTime
		Public Property Category() As String
		Public Sub New()
			Sum = 0
			TransactionDate = DateTime.Today
			Category = String.Empty
		End Sub
	End Class


End Namespace
