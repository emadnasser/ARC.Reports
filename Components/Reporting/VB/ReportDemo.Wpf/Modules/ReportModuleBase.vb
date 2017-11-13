Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Threading
Imports DevExpress.Mvvm.UI
Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Utils.About
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.DocumentViewer

Namespace ReportWpfDemo
    Public Class ReportModuleBase
        Inherits DemoModule

        Shared Sub New()
            Dim dispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher
            If dispatcher IsNot Nothing Then
                AddHandler dispatcher.UnhandledException, AddressOf Dispatcher_UnhandledException
            End If
        End Sub

        Private Shared Sub Dispatcher_UnhandledException(ByVal sender As Object, ByVal e As DispatcherUnhandledExceptionEventArgs)
            e.Handled = True

            If Not System.ComponentModel.DesignerProperties.GetIsInDesignMode(New DependencyObject()) Then
                Dim exception = e.Exception.GetBaseException()
'                #Region "DEMO_REMOVE"
                ' Using regular MessageBox instead of DXMessageBox for errors to prevent continuous exceptions in internal dxp-bindings
'                #End Region
                MessageBox.Show(exception.ToString(), "Demo Application Error", MessageBoxButton.OK, MessageBoxImage.Warning)
                UAlgo.Default.DoEventException(exception)
            End If
        End Sub

        Protected ReadOnly Property ReportModuleViewModel() As ReportModuleViewModelBase
            Get
                Return TryCast(DataContext, ReportModuleViewModelBase)
            End Get
        End Property

        Public Sub New()
            Interaction.GetBehaviors(Me).Add(CreateWindowService())
            Interaction.GetBehaviors(Me).Add(CreateDispatchFocusBehavior())
            AddHandler Loaded, AddressOf OnLoaded
        End Sub

        Private Sub OnLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            RemoveHandler Loaded, AddressOf OnLoaded

            If Not System.ComponentModel.DesignerProperties.GetIsInDesignMode(Me) Then
'                #Region "DEMO_REMOVE"
                Dim viewer = DevExpress.Xpf.Core.Native.LayoutHelper.FindElementByType(Of DevExpress.Xpf.Printing.DocumentPreviewControl)(Me)
                Debug.Assert(viewer IsNot Nothing AndAlso viewer.Name = "viewer", "Can not find a DocumentPreviewControl with the name 'viewer'.") ' T424481
'                #End Region

                ReportModuleViewModel.InitializeReport()
            End If
        End Sub

        Protected Overrides Sub RaiseBeforeModuleDisappear()
            MyBase.RaiseBeforeModuleDisappear()
            Dim viewModel = ReportModuleViewModel
            If viewModel IsNot Nothing AndAlso viewModel.Report IsNot Nothing Then
                viewModel.Report.StopPageBuilding()
            End If
        End Sub

        Private Shared Function CreateWindowService() As WindowService
            Dim style = New Style(GetType(DXTabbedWindow))
            style.Setters.Add(New Setter(DXTabbedWindow.WindowStateProperty, WindowState.Maximized))
            style.Setters.Add(New Setter(DXTabbedWindow.ShowIconProperty, False))
            style.Setters.Add(New Setter(DXTabbedWindow.TitleProperty, "Report Designer"))
            style.Setters.Add(New Setter(DXTabbedWindow.ShowInTaskbarProperty, False))
            Return New WindowService With {.WindowShowMode = WindowShowMode.Dialog, .WindowType = GetType(DXTabbedWindow), .WindowStyle = style}
        End Function

        Private Shared Function CreateDispatchFocusBehavior() As DispatchFocusBehavior
            Dim behavior = New DispatchFocusBehavior()
            BindingOperations.SetBinding(behavior, DispatchFocusBehavior.ElementProperty, New Binding() With {.ElementName = "viewer"})
            Return behavior
        End Function
    End Class

    Public Class ZoomToPageLevelBehavior
        Inherits Behavior(Of DocumentViewerControl)

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            If AssociatedObject.IsLoaded Then
                DispatchZoomMode(AssociatedObject)
            Else
                AddHandler AssociatedObject.Loaded, AddressOf AssociatedObject_Loaded
            End If
        End Sub

        Private Sub AssociatedObject_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim viewer = DirectCast(sender, DocumentViewerControl)
            RemoveHandler viewer.Loaded, AddressOf AssociatedObject_Loaded
            DispatchZoomMode(viewer)
        End Sub

        Private Sub DispatchZoomMode(ByVal viewer As DocumentViewerControl)
            viewer.Dispatcher.BeginInvoke(New Action(Sub() viewer.ZoomMode = ZoomMode.PageLevel), DispatcherPriority.ApplicationIdle)
        End Sub
    End Class
End Namespace
