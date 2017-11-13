Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucCategorySales
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
			totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
                If SalesPerformanceDataGenerator.IsCurrentDataGeneratorExist Then
                    RemoveHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
                End If
            End If
            MyBase.Dispose(disposing)
		End Sub
		Private Sub OnUpdateDataSource(ByVal sender As Object, ByVal e As EventArgs)
			totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales
		End Sub
	End Class
End Namespace
