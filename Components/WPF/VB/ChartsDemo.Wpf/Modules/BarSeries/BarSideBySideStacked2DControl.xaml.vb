Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/BarSeries/BarSideBySideStacked2DControl(.SL).xaml"), CodeFile("Modules/BarSeries/BarSideBySideStacked2DControl.xaml.(cs)")>
    Partial Public Class BarSideBySideStacked2DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            chart.DataSource = AgeStructure.GetDataByAgeAndGender()
            GroupSeries()
            lbModel.SelectedItem = Bar2DModelKindHelper.FindActualBar2DModelKind(GetType(SimpleBar2DModel))
        End Sub

        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
        Private Sub lbGroupBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GroupSeries()
            chart.Animate()
        End Sub
        Private Sub GroupSeries()
            For Each series As BarSideBySideStackedSeries2D In chart.Diagram.Series
                Dim genderAge As GenderAgeInfo = CType(series.Tag, GenderAgeInfo)
                series.StackedGroup = If(lbGroupBy.SelectedIndex = 0, genderAge.Gender, genderAge.Age)
            Next series
        End Sub
    End Class
End Namespace
