Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Windows.Data
Imports System.Xml.Linq
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors

Namespace ChartsDemo
    <CodeFile("Modules/DataAnalysis/OscillatorIndicatorsControl(.SL).xaml"), CodeFile("Modules/DataAnalysis/OscillatorIndicatorsControl.xaml.(cs)")>
    Partial Public Class OscillatorIndicatorsControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.Diagram.Series(0).DataSource = CsvReader.ReadFinancialData("USDJPYDaily.csv")
        End Sub

        Public Overrides Function SupportSidebarContent() As Boolean
            Return False
        End Function
    End Class

    Public Class SelectedSeparatePaneIndicatorToVisibleConverter
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim movingAverage = TryCast(values(0), SeparatePaneIndicator)
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
