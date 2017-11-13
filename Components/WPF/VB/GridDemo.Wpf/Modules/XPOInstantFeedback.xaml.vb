Imports System
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpo
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/XPOInstantFeedbackTemplates(.SL).xaml"), CodeFile("ModuleResources/XPOInstantFeedbackClasses.(cs)"), CodeFile("Controls/Converters.(cs)")>
    Partial Public Class XPOInstantFeedback
        Inherits GridDemoModule

        Public Sub New()
            XPOServiceHelper.SetupXpoLayer()
            InitializeComponent()
            AddHandler waitIndicatorList.EditValueChanged, AddressOf waitIndicatorList_EditValueChanged
        End Sub

        Private Sub XPInstantFeedbackDataSource_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
            Dim s As Session = New UnitOfWork()
            e.Session = s
        End Sub
        Private Sub XPInstantFeedbackDataSource_DismissSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs)
            Dim session As IDisposable = TryCast(e.Session, IDisposable)
            If session IsNot Nothing Then
                session.Dispose()
            End If
        End Sub
        Private Sub waitIndicatorList_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If e.NewValue.ToString() = "Custom" Then
                view.WaitIndicatorType = WaitIndicatorType.Panel
                view.WaitIndicatorStyle = TryCast(Resources("CustomWaitIndicatorStyle"), Style)
            Else
                view.ClearValue(GridViewBase.WaitIndicatorStyleProperty)
                view.WaitIndicatorType = CType(e.NewValue, WaitIndicatorType)
            End If
        End Sub
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
