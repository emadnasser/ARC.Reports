using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using DevExpress.UI.Xaml.Controls.Internal.Pdf;
using DevExpress.UI.Xaml.Ribbon;
using PdfViewerDemo;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace RibbonDemo {
    public sealed partial class RibbonReportExplorerModule : UserControl {
        public RibbonReportExplorerModule() {
            this.InitializeComponent();
        }

        private void PdfViewer_Loaded(object sender, RoutedEventArgs e) {
        }
    }
}
