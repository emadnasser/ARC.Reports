Imports System
Imports System.Linq
Imports System.Windows
Imports GridDemo.Controls
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Grid

Namespace GridDemo
    <CodeFile("ModuleResources/EntityFrameworkModuleTemplates(.SL).xaml"), CodeFile("ModuleResources/SharedResources(.SL).xaml"), CodeFile("Controls/Converters.(cs)"), CodeFile("Controls/EFServerModeModel1.Designer.(cs)")>
    Partial Public Class EntityFrameworkModule
        Inherits GridDemoModule

        Private objectContext As DXGridServerModeDBEntities
        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf OnLoaded
        End Sub

        Private Sub CreateObjectContextIfNull()
            If objectContext IsNot Nothing Then
                Return
            End If
            Dim builder As New System.Data.EntityClient.EntityConnectionStringBuilder()
            builder.ProviderConnectionString = ServerModeOptions.SQLConnectionString
            builder.Metadata = "res://*/Controls.EFServerModeModel.csdl|res://*/Controls.EFServerModeModel.ssdl|res://*/Controls.EFServerModeModel.msl"
            builder.Provider = "System.Data.SqlClient"
            objectContext = New DXGridServerModeDBEntities(builder.ToString())
            DataContext = objectContext
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If DevExpress.Xpf.DemoBase.DemoTesting.DemoTestingHelper.IsTesting Then
                entityServerModeDataSource.ElementType = GetType(WpfServerSideGridTest)
                entityServerModeDataSource.QueryableSource = OutlookDataGenerator.CreateServerObjectsList(30000).AsQueryable()
                grid.ItemsSource = entityServerModeDataSource.Data
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
            objectContext = Nothing
            DataContext = objectContext
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
            CreateObjectContextIfNull()
            If chkInstantFeedBack.IsChecked.Value Then
                grid.ItemsSource = entityInstantFeedbackDataSource.Data
            Else
                grid.ItemsSource = entityServerModeDataSource.Data
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
