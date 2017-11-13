Imports System
Imports System.Windows
Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase

Namespace ChartsDemo
    <CodeFile("Modules/BarSeries/BarSideBySide3DControl(.SL).xaml"), CodeFile("Modules/BarSeries/BarSideBySide3DControl.xaml.(cs)")>
    Partial Public Class BarSideBySide3DControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub chbVisible_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each series As BarSideBySideSeries3D In chart.Diagram.Series
                series.LabelsVisibility = True
            Next series
        End Sub
        Private Sub chbVisible_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each series As BarSideBySideSeries3D In chart.Diagram.Series
                series.LabelsVisibility = False
            Next series
        End Sub
        Private Sub lbModel_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim barKind As Bar3DKind = TryCast(lbModel.SelectedItem, Bar3DKind)
            For Each series As BarSeries3D In chart.Diagram.Series
                series.Model = DirectCast(Activator.CreateInstance(barKind.Type), Bar3DModel)
            Next series
        End Sub
        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim model As Bar3DModel = CType(chart.Diagram.Series(0), BarSeries3D).ActualModel
            lbModel.SelectedItem = Bar3DModelKindHelper.FindActualBar3DModelKind(model)
        End Sub
    End Class
End Namespace
