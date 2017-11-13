Imports System
Imports System.Linq
Imports System.Windows
Imports GridDemo.Controls
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Data.Linq
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    <CodeFile("Controls/SQLConnectionWindow(.SL).xaml.(cs)"), CodeFile("Controls/DataGridTestClasses.designer.(cs)"), CodeFile("ModuleResources/LinqServerModeTemplates(.SL).xaml")>
    Partial Public Class LINQToSQLServer
        Inherits GridDemoModule

        Private linqDataContext As DataGridTestClassesDataContext
        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf OnLoaded

        End Sub

        Private Sub CreateLinqDataContextIfNull()
            linqDataContext = New DataGridTestClassesDataContext(ServerModeOptions.SQLConnectionString)
            DataContext = linqDataContext
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting Then
                linqServerModeDataSource.QueryableSource = OutlookDataGenerator.CreateServerObjectsList(30000).AsQueryable()
                grid.ItemsSource = linqServerModeDataSource.Data
                Return
            End If
            If Not ServerModeRecordsGeneratorProviderBase.IsDatabaseExists(ServerModeOptions.SQLConnectionString, ServerModeOptions.OutlookTableName) Then
                ShowConnectionWizard()
            End If
            ValidateSource()
        End Sub
        Private Sub ChangeInstantFeedBack(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ValidateSource()
        End Sub
        Private Sub Configure(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowConnectionWizard("Return")
            ValidateSource()
        End Sub

        Private Sub ShowConnectionWizard()
            ShowConnectionWizard("Start Demo")
        End Sub
        Private Sub ShowConnectionWizard(ByVal windowTitle As String)
            linqDataContext = Nothing
            DataContext = linqDataContext
            Dim window As New SQLConnectionWindow(windowTitle) With {.Description = ServerModeOptions.GetGridDescription()}
            If Application.Current IsNot Nothing Then
                window.Owner = Application.Current.MainWindow
            End If
            window.ShowDialog()
            ServerModeOptions.SQLConnectionString = window.GetDataBaseConnectionString()
        End Sub
        Private Sub ValidateSource()
            If Not ServerModeOptions.IsCorrectConnection Then
                grid.ItemsSource = Nothing
                Return
            End If
            CreateLinqDataContextIfNull()
            If chkInstantFeedBack.IsChecked.Value Then
                grid.ItemsSource = linqInstantFeedbackDataSource.Data
            Else
                grid.ItemsSource = linqServerModeDataSource.Data
            End If
        End Sub

        Private Sub CustomizeWaitIndicator(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            If e.NewValue.ToString() = "Custom" Then
                view.WaitIndicatorType = WaitIndicatorType.Panel
                view.WaitIndicatorStyle = TryCast(Resources("CustomWaitIndicatorStyle"), Style)
            Else
                view.ClearValue(GridViewBase.WaitIndicatorStyleProperty)
                view.WaitIndicatorType = CType(e.NewValue, WaitIndicatorType)
            End If
        End Sub
    End Class
End Namespace
