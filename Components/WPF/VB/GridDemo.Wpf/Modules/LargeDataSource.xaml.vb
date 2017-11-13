Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports System.Collections
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Editors
Imports System.Threading
Imports System.Windows.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.Data.Browsing
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    <CodeFile("Controls/OutlookDataGenerator.(cs)"), CodeFile("ModuleResources/LargeDataSourceClasses.(cs)")>
    Partial Public Class LargeDataSource
        Inherits GridDemoModule

        Private vList As New VirtualList()
        Public Sub New()
            InitializeComponent()
            AssignDataSource()
        End Sub

        Private Sub AssignDataSource()
            setRowColumnCountButton.Cursor = Cursors.Wait
            vList.RecordCount = CType(rowCountListBox.SelectedItem, CountInfo).Value
            vList.ColumnCount = CType(columnCountListBox.SelectedItem, CountInfo).Value
            grid.ItemsSource = Nothing
            grid.Columns.Clear()
            grid.Columns.BeginUpdate()
            Dim properties As PropertyDescriptorCollection = DirectCast(vList, ITypedList).GetItemProperties(Nothing)
            For Each propertyDescriptor As PropertyDescriptor In properties
                Dim column As New GridColumn()
                column.FieldName = propertyDescriptor.Name
                If column.FieldName.Contains("Subject") Then
                    column.EditSettings = New MemoEditSettings() With {.PopupWidth = 300, .ShowIcon = False, .MemoTextWrapping=TextWrapping.Wrap, .MemoVerticalScrollBarVisibility = ScrollBarVisibility.Auto}
                End If
                If column.FieldName.Contains("Priority") Then
                    column.SortMode = ColumnSortMode.Value
                End If
                If column.FieldName.Contains("Size") Then
                    column.BestFitArea = BestFitArea.Header
                End If
                column.AllowEditing = (If(propertyDescriptor.Name = "ID(1)", DefaultBoolean.False, DefaultBoolean.Default))
                column.Header = (If(propertyDescriptor.Name = "ID(1)", "ID(1)", Nothing))
                column.AllowColumnFiltering = (If(propertyDescriptor.Name = "ID(1)", DefaultBoolean.False, DefaultBoolean.True))
                Dim settings As BaseEditSettings = CreateEditSettings(propertyDescriptor.Name)
                If settings IsNot Nothing Then
                    column.EditSettings = settings
                End If
                grid.Columns.Add(column)
            Next propertyDescriptor
            grid.Columns.EndUpdate()
            grid.ItemsSource = vList
            Dispatcher.BeginInvoke(DispatcherPriority.Render, New Action(AddressOf ClearCursorProperty))
        End Sub
  Private Sub ClearCursorProperty()
   setRowColumnCountButton.ClearValue(FrameworkElement.CursorProperty)
  End Sub
        Private Function CreateEditSettings(ByVal propertyName As String) As BaseEditSettings
            If propertyName = "ID(1)" Then
                Return New TextEditSettings() With {.DisplayFormat = "#,0", .HorizontalContentAlignment = EditSettingsHorizontalAlignment.Right}
            End If
            If propertyName.StartsWith("Size") Then
                Return New TextEditSettings() With {.Mask = "## ##0", .MaskType = MaskType.Numeric, .MaskUseAsDisplayFormat = True, .HorizontalContentAlignment = EditSettingsHorizontalAlignment.Right}
            End If
            If propertyName.StartsWith("Priority") Then
                Return New ComboBoxEditSettings() With {.ItemsSource = DevExpress.Utils.EnumExtensions.GetValues(GetType(Priority)), .IsTextEditable = False}
            End If
            Return Nothing
        End Function
        Private Sub setRowColumnCountButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            AssignDataSource()
        End Sub

        Private Sub view_CustomBestFit(ByVal sender As Object, ByVal e As CustomBestFitEventArgs)
            If e.Column.FieldName <> "ID(1)" Then
                Return
            End If
            Dim largestIDHandles As New List(Of Integer)()
            For i As Integer = vList.Count - 1 To 0 Step -1
                Dim rowHanle As Integer = grid.GetRowHandleByListIndex(i)
                If rowHanle <> GridControl.InvalidRowHandle Then
                    largestIDHandles.Add(rowHanle)
                End If
                If largestIDHandles.Count >= 100 Then
                    Exit For
                End If
            Next i
            e.BestFitRows = largestIDHandles
        End Sub
        Protected Overrides Function GetExportView() As DataViewBase
            Return Nothing
        End Function
        Protected Overrides Function GetReportView() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Return Nothing
        End Function
    End Class
End Namespace
