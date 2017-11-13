Imports System
Imports System.Windows

Namespace SpreadsheetDemo
    Partial Public Class AddTransactionForm
        Inherits Window

        Private Function IsLeap(ByVal year As Integer) As Boolean
            Return (year Mod 4 = 0 AndAlso year Mod 100 <> 0) OrElse (year Mod 400 = 0)
        End Function

        Private Function DaysInMonth(ByVal month As Integer, ByVal year As Integer) As Integer
            Dim days(,) As Integer = {
                { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 },
                { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }
            }
            Return days(Convert.ToInt32(IsLeap(year)), month)
        End Function
        Public Sub New(ByVal income As Boolean, ByVal categorys() As String)
            InitializeComponent()
            Me.Title = If(income, "Add income", "Add expense")
            categoryComboBox.Items.AddRange(categorys)
            categoryComboBox.Text = "Uncategorised"
            Dim today As Date = Date.Now
            For i As Integer = 1 To 12
                monthComboBox.Items.Add(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(i))
            Next i
            monthComboBox.SelectedIndex = today.Month - 1
            dayTextEdit.Value = today.Day
            dayTextEdit.MinValue = 1
        End Sub

        Private Sub OkButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            DialogResult = True
        End Sub

        Private Sub MonthComboBoxEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            dayTextEdit.MaxValue = DaysInMonth(monthComboBox.SelectedIndex, 2013)
        End Sub
    End Class
End Namespace
