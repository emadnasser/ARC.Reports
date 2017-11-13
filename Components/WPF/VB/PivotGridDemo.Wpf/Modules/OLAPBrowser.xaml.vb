Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media.Animation
Imports System.Windows.Threading
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.PivotGrid

Namespace PivotGridDemo.PivotGrid
    Partial Public Class OLAPBrowser
        Inherits PivotGridDemoModule

        Private Const YearFieldName As String = "[Date].[Calendar].[Calendar Year]"
        Private Const CategoryFieldName As String = "[Product].[Product].[Product]"
        Private Const TotalCostFieldName As String = "[Measures].[Total Product Cost]"
        Private Const FreightFieldName As String = "[Measures].[Freight Cost]"
        Private Const QuantityOrderFieldName As String = "[Measures].[Order Quantity]"
        Protected Const DefaultFieldWidth As Integer = 90
        Private lastSplitterY As Double = 200

        Private Shared Function GetSampleCubeFileName() As String
            Return "AdventureWorks.cub"
        End Function

        Private Shared sampleFileName_Renamed As String
        Private ReadOnly DataSourceDialohHeight As Integer = 230
        Private ReadOnly Property SampleConnectionString() As String
            Get
                Return "Provider=msolap;Data Source=" & SampleFileName & ";Initial Catalog=Adventure Works;Cube Name=Adventure Works"
            End Get
        End Property
        Protected Shared ReadOnly Property SampleFileName() As String
            Get
                If String.IsNullOrEmpty(sampleFileName_Renamed) Then
                    sampleFileName_Renamed = Path.GetFullPath(DataFilesHelper.FindFile(GetSampleCubeFileName(), DataFilesHelper.DataPath))
                    If File.Exists(sampleFileName_Renamed) Then
      Try
       File.SetAttributes(sampleFileName_Renamed, FileAttributes.Normal)
      Catch
      End Try
                    End If
                End If
                Return sampleFileName_Renamed
            End Get
        End Property

        Private Function PivotConnectionString() As String
            Return pivotGrid.OlapConnectionString
        End Function
        Private Function IsSampleCube() As Boolean
            Return pivotGrid.OlapConnectionString.Contains("Cube Name=Adventure Works")
        End Function
        Shared Sub New()
            Dim ownerType As Type = GetType(OLAPBrowser)
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnPivotGridLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitPivotGrid(SampleConnectionString)
        End Sub

        Private Sub OnPivotGridSizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
            Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
            If pivot Is Nothing OrElse pivot.RenderSize.Height < 200 OrElse lastSplitterY <> pivot.FieldListSplitterY Then
                Return
            End If
            pivot.FieldListSplitterY = Math.Round((pivot.RenderSize.Height - 90) * 0.5)
            lastSplitterY = pivot.FieldListSplitterY
        End Sub

        Private Sub InitPivotLayoutSampleOlapDB(ByVal result As AsyncOperationResult)
            If pivotGrid.Fields.Count = 0 OrElse (Not IsSampleCube()) Then
                Return
            End If
            pivotGrid.BeginUpdate()
            Dim fieldProduct As PivotGridField = pivotGrid.Fields(CategoryFieldName), fieldYear As PivotGridField = pivotGrid.Fields(YearFieldName), fieldTotalCost As PivotGridField = pivotGrid.Fields(TotalCostFieldName), fieldFreightCost As PivotGridField = pivotGrid.Fields(FreightFieldName), fieldOrderQuantity As PivotGridField = pivotGrid.Fields(QuantityOrderFieldName)
            If fieldProduct Is Nothing OrElse fieldYear Is Nothing OrElse fieldTotalCost Is Nothing OrElse fieldFreightCost Is Nothing OrElse fieldOrderQuantity Is Nothing Then
                pivotGrid.EndUpdateAsync()
                Return
            End If
            fieldProduct.Area = FieldArea.RowArea
            fieldYear.Area = FieldArea.ColumnArea
            fieldYear.SortOrder = FieldSortOrder.Descending
            fieldTotalCost.Width = DefaultFieldWidth + 20
            fieldTotalCost.CellFormat = "c2"
            fieldFreightCost.Width = DefaultFieldWidth
            fieldFreightCost.CellFormat = "c2"
            fieldOrderQuantity.Width = DefaultFieldWidth + 5
            fieldProduct.Visible = True
            fieldYear.Visible = True
            fieldTotalCost.Visible = True
            fieldFreightCost.Visible = True
            fieldOrderQuantity.Visible = True
            pivotGrid.EndUpdateAsync()
        End Sub

        Private Sub InitPivotGrid(ByVal connectionString As String)
            If String.IsNullOrWhiteSpace(connectionString) Then
                pivotGrid.DataSource = Nothing
                Return
            End If
            If PivotConnectionString() = connectionString Then
                Return
            End If
            pivotGrid.BeginUpdate()
            pivotGrid.Fields.Clear()
            pivotGrid.Groups.Clear()
            pivotGrid.OlapConnectionString = connectionString
            pivotGrid.EndUpdateAsync(Sub(result As AsyncOperationResult)
                If pivotGrid.Fields.Count = 0 Then
                    pivotGrid.RetrieveFieldsAsync(FieldArea.FilterArea, False, AddressOf InitPivotLayoutSampleOlapDB)
                End If
            End Sub)
        End Sub

        Private dialog As DataSourceDialog
        Private Sub OnShowConnectionClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If pivotGrid Is Nothing OrElse pivotGrid.IsAsyncInProgress Then
                Return
            End If
            errorBorder.Visibility = System.Windows.Visibility.Collapsed
            dialog = New DataSourceDialog()
            dialog.Style = CType(ResourceHelper.FindResource(Me, "DataSourceDialogStyle"), Style)
            Dim pars As New FloatingContainerParameters()
            pars.AllowSizing = False
            pars.CloseOnEscape = True
            pars.Title = "OLAP Connection"
            pars.ClosedDelegate = AddressOf DialogClosed
            FloatingContainer.ShowDialogContent(dialog, Me, New Size(600, DataSourceDialohHeight), pars)
        End Sub

        Private Sub DialogClosed(ByVal close? As Boolean)
            Application.Current.MainWindow.Activate()
            If dialog Is Nothing Then
                Return
            End If
            Dim connectionString As String = dialog.GetConnectionString()
            dialog = Nothing
            If Not close.Equals(True) Then
                Return
            End If
            If String.IsNullOrWhiteSpace(connectionString) Then
                Return
            End If
            InitPivotGrid(connectionString)

        End Sub

        Private Sub pivotGrid_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Dim showDrillDownHandler As AsyncCompletedHandler = Sub(result As AsyncOperationResult)
                Try
                    If result.Exception IsNot Nothing Then
                        ShowMessageBox(result.Exception.Message)
                    Else
                        ShowDrillDown(CType(result.Value, PivotDrillDownDataSource))
                    End If
                Catch ex As Exception
                    ShowMessageBox(ex.Message)
                End Try
            End Sub
            pivotGrid.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, showDrillDownHandler)
        End Sub

        Private Sub ShowDrillDown(ByVal drillDownDataSource As PivotDrillDownDataSource)
            If drillDownDataSource.RowCount = 0 Then
                ShowMessageBox("DrillDown operation returned no rows")
                Return
            End If
            Dim grid As New GridControl()
            grid.View = New TableView() With {.AllowPerPixelScrolling = True, .ShowGroupPanel = False}
            grid.ItemsSource = drillDownDataSource
            grid.PopulateColumns()
            grid.ShowBorder = False
            FloatingWindowContainer.ShowDialogContent(grid, Me, New Size(520, 300), New FloatingContainerParameters() With {.AllowSizing = True, .CloseOnEscape = True, .Title = String.Format("Drill Down Results: {0} Rows", drillDownDataSource.RowCount), .ClosedDelegate = Nothing})
        End Sub

        Private Sub ShowMessageBox(ByVal message As String)
            Dim pars As New FloatingContainerParameters()
            pars.AllowSizing = False
            pars.Title = "Error"
            Dim text As New TextBlock()
            text.Text = message
            text.VerticalAlignment = System.Windows.VerticalAlignment.Center
            text.HorizontalAlignment = System.Windows.HorizontalAlignment.Center
            FloatingContainer.ShowDialogContent(text, Me, New Size(420, 150), pars)
        End Sub

        Private Sub OnPivotGridOlapException(ByVal sender As Object, ByVal e As PivotOlapExceptionEventArgs)
            e.Handled = True
            pivotGrid.Dispatcher.BeginInvoke(New Action(Sub() ShowOLAPErrorMessage(e)))
        End Sub

        Private Sub ShowOLAPErrorMessage(ByVal e As PivotOlapExceptionEventArgs)
            errorText.Text = (e.Exception.Message & ControlChars.CrLf & " " & (If(e.Exception.InnerException IsNot Nothing, e.Exception.InnerException.Message, String.Empty)))
            VisualStateManager.GoToState(Me, "ShowErrorMessage", True)
            Dim timer As New DispatcherTimer()
            timer.Interval = New TimeSpan(0, 0, 10)
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
            e.Handled = True
        End Sub

        Private Sub OnTimerTick(ByVal sender1 As Object, ByVal e1 As EventArgs)
            Dim self As DispatcherTimer = TryCast(sender1, DispatcherTimer)
            If self Is Nothing Then
                Return
            End If
            self.Stop()
            RemoveHandler self.Tick, AddressOf OnTimerTick
            VisualStateManager.GoToState(Me, "HideErrorMessage", True)
        End Sub
    End Class
End Namespace
