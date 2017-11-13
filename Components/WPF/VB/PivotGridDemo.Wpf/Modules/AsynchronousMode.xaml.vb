Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.PivotGrid
Imports PivotGridDemo.PivotGrid.Helpers
Imports System.Diagnostics

Namespace PivotGridDemo.PivotGrid
    Partial Public Class AsynchronousMode
        Inherits PivotGridDemoModule

        Private Const TableConnectError As String = "A connection error occurred. Please make sure that you have generated a data source and provided proper connection settings."
        Private Const OlapConnectError As String = "A connection error occurred. Please make sure that you have provided proper connection settings." & ControlChars.Lf & "To connect to OLAP cubes, you should have Microsoft SQL Server 2005 Analysis Services 9.0 OLE DB provider installed on your system."
        Private isDataBaseGeneratorRunned As Boolean = False
        Private currentDataSource As InitializerDataSource
        Private lastSplitterY As Double = 200

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ServerParameters.LoadParameters()
            radioOlapCube.IsChecked = True
        End Sub
        Private Sub pivotGrid_AsyncOperationCompleted(ByVal sender As Object, ByVal e As RoutedEventArgs)
            EnableControls()
        End Sub
        Private Sub pivotGrid_AsyncOperationStarting(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DisableControls()
        End Sub
        Private Sub btnGenerateTableData_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RunDBGenerator("Return to Demo")
        End Sub
        Private Sub RunDBGenerator(ByVal demoString As String)
            Dim windowDBGenerator As New WindowDatabaseGenerator(Me, demoString)
            Dim cancelInitialization? As Boolean = windowDBGenerator.ShowDialog()
            If cancelInitialization = False AndAlso radioTableDataSource.IsChecked.Value Then
                DisableControls()
                isDataBaseGeneratorRunned = True
                Initialize(InitializerDataSource.TableDataSource)
            End If
        End Sub
        Private Sub radioOlapCube_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DisableControls()
            Initialize(InitializerDataSource.OlapCube)
        End Sub
        Private Sub radioTableDataSource_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DisableControls()
            If isDataBaseGeneratorRunned Then
                Initialize(InitializerDataSource.TableDataSource)
            Else
                RunDBGenerator("Start Demo")
                EnableControls()
            End If
        End Sub
        Private Sub Initialize(ByVal dataSourceType As InitializerDataSource)
            currentDataSource = dataSourceType
            AsynchronousPivotInitializer.Initialize(pivotGrid, AddressOf ProcessAsyncResult, currentDataSource)
        End Sub
        Private Sub DisableControls()
            radioTableDataSource.IsEnabled = False
            radioOlapCube.IsEnabled = False
            btnGenerateTableData.IsEnabled = False
            DispatcherHelper.DoEvents()
        End Sub
        Private Sub EnableControls()
            radioTableDataSource.IsEnabled = True
            radioOlapCube.IsEnabled = True
            btnGenerateTableData.IsEnabled = True
        End Sub
        Private Sub ShowErrorInfo()
            If currentDataSource = InitializerDataSource.OlapCube Then
                tbOlap.Visibility = System.Windows.Visibility.Visible
                DXMessageBox.Show(OlapConnectError, "Could not connect to OLAP cube", MessageBoxButton.OK, MessageBoxImage.Error)
            Else
                DXMessageBox.Show(TableConnectError, "Could not connect to data source", MessageBoxButton.OK, MessageBoxImage.Error)
            End If
        End Sub
        Private Sub ProcessAsyncResult(ByVal result As AsyncOperationResult)
            If result Is Nothing Then
                If currentDataSource = InitializerDataSource.OlapCube OrElse isDataBaseGeneratorRunned Then
                    ShowErrorInfo()
                Else
                    RunDBGenerator("Start Demo")
                End If
            End If
            EnableControls()
        End Sub
        Private Sub pivotGrid_CellDoubleClick(ByVal sender As Object, ByVal e As PivotCellEventArgs)
            Dim showDrillDownHandler As AsyncCompletedHandler = Sub(result As AsyncOperationResult)
                Try
                    If result.Exception IsNot Nothing Then
                        DXMessageBox.Show(result.Exception.Message)
                    Else
                        ShowDrillDown(CType(result.Value, PivotDrillDownDataSource))
                    End If
                Catch ex As Exception
                    DXMessageBox.Show(ex.Message)
                End Try
            End Sub
            pivotGrid.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, showDrillDownHandler)
        End Sub
        Private Sub ShowDrillDown(ByVal drillDownDataSource As PivotDrillDownDataSource)
            If drillDownDataSource.RowCount = 0 Then
                DXMessageBox.Show("DrillDown operation returned no rows")
                Return
            End If
            Dim grid As New GridControl()
            grid.View = New TableView() With {.AllowPerPixelScrolling = True}
            grid.ItemsSource = drillDownDataSource
            grid.PopulateColumns()

            Dim popupContainer As FloatingContainer = FloatingWindowContainer.ShowDialog(grid, Me, New Size(520, 300), New FloatingContainerParameters() With {.AllowSizing = True, .CloseOnEscape = True, .Title = String.Format("Drill Down Results: {0} Rows", drillDownDataSource.RowCount), .ClosedDelegate = Nothing})
            AddLogicalChild(popupContainer)
        End Sub

        Private Sub HyperlinkOlap_RequestNavigate(ByVal sender As Object, ByVal e As System.Windows.Navigation.RequestNavigateEventArgs)
            Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri))
            e.Handled = True
        End Sub

        Private Sub OnPivotGridSizeChanged(ByVal sender As Object, ByVal e As SizeChangedEventArgs)
            Dim pivot As PivotGridControl = TryCast(sender, PivotGridControl)
            If pivot Is Nothing OrElse pivot.RenderSize.Height < 200 OrElse lastSplitterY <> pivot.FieldListSplitterY Then
                Return
            End If
            pivot.FieldListSplitterY = Math.Round((pivot.RenderSize.Height - 90) * 0.5)
            lastSplitterY = pivot.FieldListSplitterY
        End Sub

        Private Sub OnPivotGridOlapException(ByVal sender As Object, ByVal e As PivotOlapExceptionEventArgs)
            e.Handled = True
        End Sub
    End Class
End Namespace
