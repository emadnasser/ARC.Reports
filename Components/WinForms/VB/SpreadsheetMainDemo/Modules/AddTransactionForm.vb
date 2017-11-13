Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class AddTransactionForm
		Inherits Form
		Private result As AddTransactionResult
		Private Function IsLeap(ByVal year As Integer) As Boolean
			Return (year Mod 4 = 0 AndAlso year Mod 100 <> 0) OrElse (year Mod 400 = 0)
		End Function

		Private Function DaysInMonth(ByVal month As Integer, ByVal year As Integer) As Integer
			Dim days(,) As Integer = { { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }, { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 } }
			Return days(Convert.ToInt32(IsLeap(year)), month)
		End Function

		Public Sub New(ByVal income As Boolean, ByVal categorys() As String, ByVal result As AddTransactionResult)
			InitializeComponent()
			Me.Text = If(income, "Add income", "Add expense")
			categoryComboBox.Properties.Items.AddRange(categorys)
			categoryComboBox.Text = "Uncategorised"
			Dim today As DateTime = DateTime.Now
			monthComboBox.Properties.BeginUpdate()
			For i As Integer = 1 To 12
				monthComboBox.Properties.Items.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i))
			Next i
			monthComboBox.Properties.EndUpdate()
			monthComboBox.SelectedIndex = today.Month - 1
			dayTextEdit.Value = today.Day
			dayTextEdit.Properties.MinValue = 1
			Me.result = result
		End Sub

		Public Sub SetMenuManager(ByVal menuManager As IDXMenuManager)
			DemoMenuManager.SetMenuManager(Controls, menuManager)
		End Sub

		Private Sub FillResult()
			result.Category = If(categoryComboBox.Text = "", "Uncategorised", categoryComboBox.Text)
			result.TransactionDate = New DateTime(2013, monthComboBox.SelectedIndex + 1, CInt(Fix(dayTextEdit.Value)))
			result.Sum = CSng(sumEdit.Value)
		End Sub

		Private Sub OkButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
			FillResult()
		End Sub

		Private Sub MonthComboBoxEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles monthComboBox.EditValueChanged
			dayTextEdit.Properties.MaxValue = DaysInMonth(monthComboBox.SelectedIndex, 2013)
		End Sub
	End Class
End Namespace
