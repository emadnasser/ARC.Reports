Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class ucProductsGrid
        Inherits UserControl
        Public Sub New()
            InitializeComponent()
            AddHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
            If SalesPerformanceDataGenerator.Current.FilterTotalSales.Any() Then
                totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales
            End If
        End Sub
        Private Sub OnUpdateDataSource(ByVal sender As Object, ByVal e As EventArgs)
            totalSalesItemBindingSource.DataSource = SalesPerformanceDataGenerator.Current.FilterTotalSales
        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
                If SalesPerformanceDataGenerator.IsCurrentDataGeneratorExist Then
                    RemoveHandler SalesPerformanceDataGenerator.Current.UpdateDataSource, AddressOf OnUpdateDataSource
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
    Public Class ucProductsBorderlessGrid
        Inherits ucProductsGrid
        Public Sub New()
            MyBase.New()
            gridView1.BorderStyle = XtraEditors.Controls.BorderStyles.Default
        End Sub
    End Class
End Namespace

