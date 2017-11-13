Imports System.Data
Imports System.Diagnostics
Imports System.Windows
Imports DevExpress.Data.Linq
Imports DevExpress.Xpf.Core
Imports PivotGridDemo.Controls
Imports PivotGridDemo.PivotGrid.Helpers
Imports System
Imports DevExpress.Xpf.Core.ServerMode

Namespace PivotGridDemo.PivotGrid
    Partial Public Class ServerMode
        Inherits PivotGridDemoModule

        Private Shared IsLoad As Boolean
        Private ReadOnly stateNoData As NoDataState
        Private ReadOnly stateLinq2Sql As Linq2SqlState
        Private ReadOnly timer As New Stopwatch()
        Private currentState As DemoState

        Public WriteOnly Property InteractiveControlsEnabled() As Boolean
            Set(ByVal value As Boolean)
                pivotGrid.IsEnabled = value
            End Set
        End Property
        Private Property State() As DemoState
            Get
                Return currentState
            End Get
            Set(ByVal value As DemoState)
                If currentState Is value Then
                    Return
                End If
                If currentState IsNot Nothing Then
                    currentState.Leave()
                    currentState = Nothing
                End If
                If Not value.Enter() Then
                    stateNoData.Enter()
                    currentState = stateNoData
                    RunDBGenerator(stateLinq2Sql)
                Else
                    currentState = value
                End If
            End Set
        End Property

        Public Sub New()
            InitializeComponent()

            stateNoData = New NoDataState(Me)
            stateLinq2Sql = New Linq2SqlState(Me)

            State = stateNoData
        End Sub

        Private Sub RunDBGenerator(ByVal nextState As DemoState)
            Dim windowDBGenerator As New WindowDatabaseGenerator(Me, State.DBGeneratorString)
            If windowDBGenerator.ShowDialog() = True Then
                If State Is nextState Then
                    pivotGrid.ReloadDataAsync()
                Else
                    State = nextState
                End If
            End If
        End Sub

        Private Sub PivotGridDemoModule_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            IsLoad = True
            State = stateLinq2Sql
            IsLoad = False
        End Sub

        Private Sub btnGenerateTableData_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RunDBGenerator(State)
        End Sub

        Private MustInherit Class DemoState
            Protected demo As ServerMode

            Public MustOverride ReadOnly Property DBGeneratorString() As String

            Public Sub New(ByVal demo As ServerMode)
                Me.demo = demo
            End Sub
            Public MustOverride Function Enter() As Boolean
            Public MustOverride Sub Leave()
        End Class

        Private Class NoDataState
            Inherits DemoState

            Public Overrides ReadOnly Property DBGeneratorString() As String
                Get
                    Return "Start Demo"
                End Get
            End Property

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub

            Public Overrides Function Enter() As Boolean
                demo.InteractiveControlsEnabled = False
                demo.btnGenerateTableData.IsEnabled = True
                Return True
            End Function
            Public Overrides Sub Leave()
            End Sub
        End Class

        Private MustInherit Class DataState
            Inherits DemoState

            Public Overrides ReadOnly Property DBGeneratorString() As String
                Get
                    Return "Return to demo"
                End Get
            End Property

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub

            Protected MustOverride Function LoadData() As Boolean
            Protected MustOverride Sub CleanData()

            Public Overrides Function Enter() As Boolean
                demo.InteractiveControlsEnabled = False
                demo.btnGenerateTableData.IsEnabled = False
                Dim result As Boolean = LoadData()
                demo.btnGenerateTableData.IsEnabled = True
                If result Then
                    demo.InteractiveControlsEnabled = True
                Else
                    If Not IsLoad Then
                        DXMessageBox.Show("Failed to load data. Failed to load data. Use the Generate Data Table button to check the connection parameters or generate a new sample database.", "Server Mode Demo", MessageBoxButton.OK, MessageBoxImage.Error)
                    End If
                End If
                Return result
            End Function

            Public Overrides Sub Leave()
                CleanData()
            End Sub
        End Class

        Private Class Linq2SqlState
            Inherits DataState

            Private dataContext As PivotGridDemoDBDataContext

            Public Sub New(ByVal demo As ServerMode)
                MyBase.New(demo)
            End Sub
            Protected Overrides Function LoadData() As Boolean
                dataContext = DatabaseHelper.GetContext()
                If dataContext Is Nothing Then
                    Return False
                End If
                Try
                    Dim dataSource As New LinqServerModeDataSource()
                    dataSource.QueryableSource = dataContext.Sales
                    demo.pivotGrid.SetDataSourceAsync(dataSource)
                Catch
                    Return False
                End Try
                Return True
            End Function
            Protected Overrides Sub CleanData()
                demo.pivotGrid.DataSource = Nothing
                If dataContext IsNot Nothing Then
                    dataContext.Dispose()
                    dataContext = Nothing
                End If
            End Sub
        End Class

        Private Sub pivotGrid_AsyncOperationStarting(ByVal sender As Object, ByVal e As RoutedEventArgs)
            tbTimeTaken.Text = "..."
            timer.Restart()
        End Sub

        Private Sub pivotGrid_AsyncOperationCompleted(ByVal sender As Object, ByVal e As RoutedEventArgs)
            timer.Stop()
            tbTimeTaken.Text = timer.ElapsedMilliseconds.ToString()
        End Sub
    End Class
End Namespace
