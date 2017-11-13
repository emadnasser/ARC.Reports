Imports DevExpress.Xpf.Charts
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Editors
Imports System.Windows

Namespace ChartsDemo
    <CodeFile("Modules/Interactivity/CrosshairCursorControl(.SL).xaml"), CodeFile("Modules/Interactivity/CrosshairCursorControl.xaml.(cs)")>
    Partial Public Class CrosshairCursorControl
        Inherits ChartsDemoModule

        Public Overrides ReadOnly Property ActualChart() As ChartControlBase
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            PrepareComboBox(cbSnapMode, "Nearest Argument", "Nearest Value")
        End Sub
        Private Sub PrepareComboBox(ByVal comboBox As ComboBoxEdit, ParamArray ByVal items() As String)
            For Each item As String In items
                comboBox.Items.Add(item)
            Next item
            comboBox.SelectedIndex = 0
        End Sub

        Private Sub ChartsDemoModule_ModuleAppear(ByVal sender As Object, ByVal e As RoutedEventArgs)
            chart.Animate()
        End Sub
    End Class
End Namespace
