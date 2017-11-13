Imports DevExpress.Internal
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.UI
Imports DevExpress.SalesDemo.Model
Imports DevExpress.SalesDemo.Wpf.Helpers
Imports DevExpress.SalesDemo.Wpf.View
Imports DevExpress.SalesDemo.Wpf.View.Common
Imports DevExpress.SalesDemo.Wpf.ViewModel
Imports DevExpress.Xpf.Core
Imports System
Imports System.Windows

Namespace DevExpress.SalesDemo.Wpf
    Partial Public Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            ExceptionHelper.Initialize()
            ViewLocator.Default = New ViewLocator(GetType(App).Assembly)
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name
            Using DataSource.Progress.Subscribe(New DataGenerationProgress())
                DataSource.EnsureDataProvider()
            End Using
            MyBase.OnStartup(e)
            InitModules()
        End Sub
        Public Shared Sub InitModules()
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Dashboard, Function() NavigationItemViewModel.Create(ModuleType.Dashboard, "Sales", "Revenue" & Environment.NewLine & "Snapshots", ResourceImageHelper.GetResourceImage("Sales.png")), GetType(NavigationItemView))
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Products, Function() NavigationItemViewModel.Create(ModuleType.Products, "Products", "Revenue" & Environment.NewLine & "by Products", ResourceImageHelper.GetResourceImage("Products.png")), GetType(NavigationItemView))
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Sectors, Function() NavigationItemViewModel.Create(ModuleType.Sectors, "Sectors", "Revenue" & Environment.NewLine & "by Sectors", ResourceImageHelper.GetResourceImage("Sectors.png")), GetType(NavigationItemView))
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Regions, Function() NavigationItemViewModel.Create(ModuleType.Regions, "Regions", "Revenue" & Environment.NewLine & "by Regions", ResourceImageHelper.GetResourceImage("Regions.png")), GetType(NavigationItemView))
            ViewInjectionManager.Default.Inject(Regions.Navigation, ModuleType.Channels, Function() NavigationItemViewModel.Create(ModuleType.Channels, "Channels", "Revenue" & Environment.NewLine & "by Sales Channels", ResourceImageHelper.GetResourceImage("Channels.png")), GetType(NavigationItemView))

            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Dashboard, Function() SalesDashboardViewModel.Create(), GetType(SalesDashboard))
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Products, Function() ProductsViewModel.Create(), GetType(ProductsView))
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Sectors, Function() SectorsViewModel.Create(), GetType(SectorsView))
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Regions, Function() RegionsViewModel.Create(), GetType(RegionsView))
            ViewInjectionManager.Default.Inject(Regions.Main, ModuleType.Channels, Function() ChannelsViewModel.Create(), GetType(ChannelsView))

            ViewInjectionManager.Default.Navigate(Regions.Navigation, ModuleType.Dashboard)
        End Sub
    End Class
    Friend Class DataGenerationProgress
        Implements IObserver(Of Integer)

        Private Sub IObserverGeneric_OnCompleted() Implements IObserver(Of Integer).OnCompleted
            DXSplashScreen.Close()
        End Sub
        Private Sub IObserverGeneric_OnNext(ByVal value As Integer) Implements IObserver(Of Integer).OnNext
            If Not DXSplashScreen.IsActive Then
                DXSplashScreen.Show(GetType(ProgressSplashScreenView))
                DXSplashScreen.SetState(ProgressSplashScreenViewModel.Create("Generating Sales...", AssemblyInfo.AssemblyCopyright))
            End If
            DXSplashScreen.Progress(CDbl(value))
        End Sub
        Private Sub IObserverGeneric_OnError(ByVal [error] As Exception) Implements IObserver(Of Integer).OnError
            Throw [error]
        End Sub
    End Class
End Namespace
#If CLICKONCE Then
Namespace DevExpress.Internal.DemoLauncher
    Public NotInheritable Class ClickOnceEntryPoint

        Private Sub New()
        End Sub

        Public Shared Function CreateMainWindow() As Window

            Dim app_Renamed As Application = Application.Current
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2013Name
            app_Renamed.Resources.MergedDictionaries.Add(New ResourceDictionary() With {.Source = DevExpress.Utils.AssemblyHelper.GetResourceUri(GetType(ClickOnceEntryPoint).Assembly, "Themes/Common.xaml")})
            Using DataSource.Progress.Subscribe(New DevExpress.SalesDemo.Wpf.DataGenerationProgress())
                DataSource.EnsureDataProvider()
            End Using
            ViewLocator.Default = New ViewLocator(GetType(DevExpress.SalesDemo.Wpf.App).Assembly)
            DevExpress.SalesDemo.Wpf.App.InitModules()
            Return New DevExpress.SalesDemo.Wpf.MainWindow()
        End Function
    End Class
End Namespace
#End If
