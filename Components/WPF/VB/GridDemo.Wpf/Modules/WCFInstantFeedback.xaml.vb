Imports System
Imports System.Diagnostics
Imports DevExpress.Xpf.DemoBase.Helpers
Imports System.Windows.Data
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/WcfInstantFeedbackViewModel.(cs)"), CodeFile("ModuleResources/WcfInstantFeedbackTemplates(.SL).xaml"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class WCFInstantFeedback
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Dim viewModel As New WCFInstantFeedbackViewModel()
            DataContext = viewModel
            AddHandler viewModel.PropertyChanged, AddressOf viewModel_PropertyChanged
        End Sub

        Private Sub viewModel_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
            If Not(TryCast(sender, WCFInstantFeedbackViewModel)).IsUseExtendedDataQuery Then
                colProductName.GroupIndex = -1
                grid.FilterCriteria = Nothing
            End If
        End Sub
        Protected Overrides Function GetExportView() As DevExpress.Xpf.Grid.DataViewBase
            Return Nothing
        End Function
    End Class
End Namespace
