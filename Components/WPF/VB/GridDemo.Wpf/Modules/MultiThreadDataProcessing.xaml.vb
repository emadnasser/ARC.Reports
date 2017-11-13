Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Utils
Imports DevExpress.Xpf.DemoBase

Namespace GridDemo
    <CodeFile("ModuleResources/MultiThreadDataProcessingViewModel.(cs)"), CodeFile("ModuleResources/MultiThreadDataProcessingClasses.(cs)"), CodeFile("ModuleResources/MultiThreadDataProcessingTemplates(.SL).xaml"), CodeFile("Controls/OrderDataGenerator.(cs)")>
    Partial Public Class MultiThreadDataProcessing
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            Dim viewModel As PLinqInstantFeedbackDemoViewModel = CType(Resources("PLinqInstantFeedbackDemoViewModel"), PLinqInstantFeedbackDemoViewModel)
            viewModel.SetIsDesignTime(False)
        End Sub
        Protected Overrides Function GetExportView() As DevExpress.Xpf.Grid.DataViewBase
            Return Nothing
        End Function
    End Class
End Namespace
