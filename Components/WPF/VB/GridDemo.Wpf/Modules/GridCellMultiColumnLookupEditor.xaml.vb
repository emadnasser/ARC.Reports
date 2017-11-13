Imports System
Imports System.Windows.Controls
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports System.Collections
Imports DevExpress.Xpf.Grid.LookUp
Imports DevExpress.Xpf.DemoBase
Imports System.Data
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("ModuleResources/GridCellMultiColumnLookupEditorResources(.SL).xaml"), CodeFile("ModuleResources/GridCellMultiColumnLookupEditorClasses.(cs)")>
    Partial Public Class GridCellMultiColumnLookupEditor
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub RaiseModuleAppear()
            MyBase.RaiseModuleAppear()
            ShowLookUp()
        End Sub
        Protected Overrides Sub Clear()
            view.CloseEditor()
            MyBase.Clear()
        End Sub
        Private Sub ShowLookUp()
            grid.CurrentColumn = grid.Columns("CustomerID")
            view.ShowEditor()
            Dispatcher.BeginInvoke(New Action(Sub()
                Dim lookUpEdit As LookUpEdit = TryCast(view.ActiveEditor, LookUpEdit)
                If lookUpEdit IsNot Nothing Then
                    lookUpEdit.ShowPopup()
                End If
            End Sub))
        End Sub
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
