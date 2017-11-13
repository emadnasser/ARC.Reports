Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Demos
Imports DevExpress.Xpf.Editors
Imports DevExpress.Mvvm
Imports System.Linq
Imports System.Linq.Expressions
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace SpreadsheetDemo
    Partial Public Class PersonalFinance
        Inherits SpreadsheetDemoModule

        Private generator As HomeAccountingDocumentGenerator
        Public Sub New()
            DataContext = ViewModelSource.Create(Function() New HomeAccountingViewModel())
            InitializeComponent()
            spreadsheetControl1.Options.Culture = DefaultCulture
            Dim book As IWorkbook = spreadsheetControl1.Document
            GenerateDocument(book)
            spreadsheetControl1.ReadOnly = True
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.Document.History.Clear()
            AddIncome()
            ribbonControl1.SelectedPage = pageHome
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

        Private Sub AddExpense()
            IsIncome = False
            Dim expenseCategorysArray(generator.ExpenseCategorys.Count - 1) As String
            generator.ExpenseCategorys.CopyTo(expenseCategorysArray)
            InitAddTransaction(False, expenseCategorysArray)
        End Sub
        Private Property IsIncome() As Boolean
        Private Sub AddIncome()
            IsIncome = True
            Dim incomeCategoriesArray(generator.IncomeCategorys.Count - 1) As String
            generator.IncomeCategorys.CopyTo(incomeCategoriesArray)
            InitAddTransaction(True, incomeCategoriesArray)
        End Sub
        Public Sub InitAddTransaction(ByVal income As Boolean, ByVal categories() As String)
            Dim vm As HomeAccountingViewModel = TryCast(DataContext, HomeAccountingViewModel)
            categoryComboBox.ItemsSource = categories
            vm.Category = "Uncategorised"
            vm.TransactionDate = Date.Today
        End Sub

        Private Sub ListBoxEditSelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If DirectCast(sender, ListBoxEdit).SelectedItem.ToString() = "Income" Then
                AddIncome()
            Else
                AddExpense()
            End If
        End Sub
        Private Sub AddClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim vm As HomeAccountingViewModel = TryCast(DataContext, HomeAccountingViewModel)
            spreadsheetControl1.BeginUpdate()
            Try
                generator.AddTransaction(IsIncome, vm.TransactionDate, CSng(Convert.ToDouble(vm.Sum, CultureInfo.CurrentCulture)), vm.Category)
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub
    End Class

    <POCOViewModel>
    Public Class HomeAccountingViewModel
        Inherits BindableBase

        Public Sub New()
            Sum = 0
            Category = String.Empty
        End Sub
        Public Overridable Property Sum() As Decimal
        Public Overridable Property TransactionDate() As Date
        Public Overridable Property Category() As String
    End Class
End Namespace
