Imports System
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/LiveDataClasses.(cs)"), CodeFile("Controls/Converters.(cs)"), CodeFile("ModuleResources/LiveDataTemplates(.SL).xaml")>
    Partial Public Class ManagingLiveData
        Inherits GridDemoModule

        Private generator As ProcessGenerator
        Public Sub New()
            InitializeComponent()
            generator = New ProcessGenerator(Me)
            generator.Initialize()
            grid.AllowLiveDataShaping = True
            grid.ItemsSource = generator.Processes
            grid.DataContext = generator
            updateModeList.SelectedIndex = 0
            chkAllowUpdating.IsChecked = True
        End Sub
        Private Sub CheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            generator.Start()
        End Sub
        Private Sub CheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            generator.Stop()
        End Sub
        Private Sub maxCountSlider_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If generator IsNot Nothing Then
                generator.ProcessMinCount = Math.Max(5, generator.ProcessMaxCount - 15)
            End If
        End Sub

        Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As GridColumnDataEventArgs)
            If e.Column IsNot Nothing AndAlso e.Column.FieldName = "AnimationElement" Then
                e.Value = generator.GetAnimationElement(generator.Processes(e.ListSourceRowIndex))
            End If
        End Sub
        Protected Overrides Sub Clear()
            MyBase.Clear()
            generator.Stop()
        End Sub
        Private Sub updateModeList_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            generator.UpdateMode = CType(updateModeList.SelectedIndex, ProcessGenerator.ProcessUpdateMode)
        End Sub
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
