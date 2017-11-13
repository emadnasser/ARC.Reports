Imports System
Imports System.Windows.Data
Imports System.Windows.Markup
Imports DevExpress.Xpf.DemoBase
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.DemoData.Models
Imports System.Linq
Imports System.Data
Imports System.Collections.Generic
Imports System.IO

Namespace PivotGridDemo.PivotGrid
    Partial Public Class CellTemplates
        Inherits PivotGridDemoModule

        #Region "static stuff"
        Public Shared ReadOnly IsCellTemplateVisibleProperty As DependencyProperty
        Public Shared ReadOnly IsCellValueVisibleProperty As DependencyProperty
        Public Shared ReadOnly IsCellShareVisibleProperty As DependencyProperty

        Shared Sub New()
            Dim ownerType As Type = GetType(CellTemplates)
            IsCellTemplateVisibleProperty = DependencyProperty.Register("IsCellTemplateVisible", GetType(Boolean), ownerType, New PropertyMetadata(True, AddressOf OnCellTemplateVisiblePropertyChanged))
            IsCellValueVisibleProperty = DependencyProperty.Register("IsCellValueVisible", GetType(Boolean), ownerType, New PropertyMetadata(True))
            IsCellShareVisibleProperty = DependencyProperty.Register("IsCellShareVisible", GetType(Boolean), ownerType, New PropertyMetadata(True))
        End Sub
        Private Shared Sub OnCellTemplateVisiblePropertyChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, CellTemplates).OnCellTemplateVisibleChanged()
        End Sub
        #End Region

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().ProductReports.ToList()
        End Sub

        Private Function toPr(ByVal row As DataRow) As ProductReport
            Return New ProductReport With {.CategoryName = DirectCast(row("CategoryName"), String), .ProductName = DirectCast(row("ProductName"), String), .ProductSales = DirectCast(row("ProductSales"), Decimal), .ShippedDate = DirectCast(row("ShippedDate"), Date)}
        End Function

        Private Function print(ByVal rep As ProductReport) As String
            Return String.Format("{0}|{1}|{2}|{3}", rep.CategoryName, rep.ProductName, rep.ProductSales, rep.ShippedDate)
        End Function

        Public Property IsCellTemplateVisible() As Boolean
            Get
                Return CBool(GetValue(IsCellTemplateVisibleProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCellTemplateVisibleProperty, value)
            End Set
        End Property

        Public Property IsCellValueVisible() As Boolean
            Get
                Return CBool(GetValue(IsCellValueVisibleProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCellValueVisibleProperty, value)
            End Set
        End Property

        Public Property IsCellShareVisible() As Boolean
            Get
                Return CBool(GetValue(IsCellShareVisibleProperty))
            End Get
            Set(ByVal value As Boolean)
                SetValue(IsCellShareVisibleProperty, value)
            End Set
        End Property

        Private Sub OnCellTemplateVisibleChanged()
            If IsCellTemplateVisible Then
                fieldSales.CellTemplate = CType(Resources("CellTemplate"), DataTemplate)
                fieldYear.Width = 200
            Else
                fieldSales.CellTemplate = Nothing
                fieldYear.Width = 100
            End If
        End Sub

        Private Sub TemplatesList_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Select Case templatesList.SelectedIndex
                Case 0
                    IsCellTemplateVisible = False
                Case 1
                    IsCellTemplateVisible = True
                    IsCellValueVisible = False
                    IsCellShareVisible = True
                Case 2
                    IsCellTemplateVisible = True
                    IsCellValueVisible = True
                    IsCellShareVisible = True
            End Select
        End Sub
    End Class

    Public Class RoundConverter
        Inherits MarkupExtension
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return System.Convert.ToInt32(value)
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
