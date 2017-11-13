Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucChartProductItem
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
			monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales
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
			monthlySalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.MonthlySales
		End Sub
	End Class
End Namespace
