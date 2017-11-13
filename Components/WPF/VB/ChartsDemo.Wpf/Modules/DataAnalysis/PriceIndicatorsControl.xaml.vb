Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Data
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/DataAnalysis/PriceIndicatorsControl(.SL).xaml"), CodeFile("Modules/DataAnalysis/PriceIndicatorsControl.xaml.(cs)")>
    Partial Public Class PriceIndicatorsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class

    Public Class SelectedPriceIndicatorToVisibleConverter
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim movingAverage = TryCast(values(0), Indicator)
            Dim listBoxItem = TryCast(values(1), ListBoxEditItem)
            If movingAverage IsNot Nothing AndAlso listBoxItem IsNot Nothing AndAlso TypeOf listBoxItem.Tag Is Type AndAlso movingAverage.GetType() Is CType(listBoxItem.Tag, Type) Then
                Return True
            Else
                Return False
            End If
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
