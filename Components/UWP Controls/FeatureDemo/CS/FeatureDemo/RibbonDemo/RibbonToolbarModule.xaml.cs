using FeatureDemo.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace RibbonDemo {
    public sealed partial class RibbonToolbarModule : DemoModuleView {
        public RibbonViewModel ViewModel { get { return DataContext as RibbonViewModel; } }
        public RibbonToolbarModule() {
            this.InitializeComponent();
            Unloaded += OnUnloaded;
        }

        void OnUnloaded(object sender, RoutedEventArgs e) {
            var popups = VisualTreeHelper.GetOpenPopups(Window.Current);
            foreach(var popup in popups) {
                popup.IsOpen = false;
            }
            InputPane.GetForCurrentView().TryHide();
        }
    }
}
