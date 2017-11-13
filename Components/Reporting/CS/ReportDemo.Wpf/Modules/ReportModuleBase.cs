using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Utils.About;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.DocumentViewer;

namespace ReportWpfDemo {
    public class ReportModuleBase : DemoModule {
        static ReportModuleBase() {
            var dispatcher = Dispatcher.CurrentDispatcher;
            if(dispatcher != null) {
                dispatcher.UnhandledException += Dispatcher_UnhandledException;
            }
        }

        static void Dispatcher_UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
            e.Handled = true;

            if(!System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject())) {
                var exception = e.Exception.GetBaseException();
                MessageBox.Show(exception.ToString(), "Demo Application Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                UAlgo.Default.DoEventException(exception);
            }
        }

        protected ReportModuleViewModelBase ReportModuleViewModel {
            get { return DataContext as ReportModuleViewModelBase; }
        }

        public ReportModuleBase() {
            Interaction.GetBehaviors(this).Add(CreateWindowService());
            Interaction.GetBehaviors(this).Add(CreateDispatchFocusBehavior());
            Loaded += OnLoaded;
        }

        void OnLoaded(object sender, RoutedEventArgs e) {
            Loaded -= OnLoaded;

            if(!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) {

                ReportModuleViewModel.InitializeReport();
            }
        }

        protected override void RaiseBeforeModuleDisappear() {
            base.RaiseBeforeModuleDisappear();
            var viewModel = ReportModuleViewModel;
            if(viewModel != null && viewModel.Report != null)
                viewModel.Report.StopPageBuilding();
        }

        static WindowService CreateWindowService() {
            var style = new Style(typeof(DXTabbedWindow));
            style.Setters.Add(new Setter(DXTabbedWindow.WindowStateProperty, WindowState.Maximized));
            style.Setters.Add(new Setter(DXTabbedWindow.ShowIconProperty, false));
            style.Setters.Add(new Setter(DXTabbedWindow.TitleProperty, "Report Designer"));
            style.Setters.Add(new Setter(DXTabbedWindow.ShowInTaskbarProperty, false));
            return new WindowService {
                WindowShowMode = WindowShowMode.Dialog,
                WindowType = typeof(DXTabbedWindow),
                WindowStyle = style
            };
        }

        static DispatchFocusBehavior CreateDispatchFocusBehavior() {
            var behavior = new DispatchFocusBehavior();
            BindingOperations.SetBinding(behavior, DispatchFocusBehavior.ElementProperty, new Binding() { ElementName = "viewer" });
            return behavior;
        }
    }

    public class ZoomToPageLevelBehavior : Behavior<DocumentViewerControl> {
        protected override void OnAttached() {
            base.OnAttached();
            if(AssociatedObject.IsLoaded) {
                DispatchZoomMode(AssociatedObject);
            } else {
                AssociatedObject.Loaded += AssociatedObject_Loaded;
            }
        }

        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e) {
            var viewer = (DocumentViewerControl)sender;
            viewer.Loaded -= AssociatedObject_Loaded;
            DispatchZoomMode(viewer);
        }

        void DispatchZoomMode(DocumentViewerControl viewer) {
            viewer.Dispatcher.BeginInvoke(
                new Action(() => viewer.ZoomMode = ZoomMode.PageLevel),
                DispatcherPriority.ApplicationIdle);
        }
    }
}
