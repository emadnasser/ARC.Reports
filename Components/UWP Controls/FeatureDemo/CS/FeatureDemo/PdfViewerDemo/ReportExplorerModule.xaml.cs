using DevExpress.UI.Xaml.Controls;
using FeatureDemo.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace PdfViewerDemo {
    public sealed partial class ReportExplorerModule : DemoModuleView {
        public ReportExplorerModule() {
            this.InitializeComponent();
        }
    }

    public class ReportParametersSelector : DataTemplateSelector {
        public DataTemplate MultiColumnTemplate { get; set; }
        public DataTemplate MasterDetailTemplate { get; set; }
        public DataTemplate EmptyTemplate { get; set; }
        public DataTemplate TableTemplate { get; set; }
        public DataTemplate SubreportTemplate { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) {
            if(item is MulticolumnParametersViewModel)
                return MultiColumnTemplate;
            if(item is EmptyParametersViewModel)
                return EmptyTemplate;
            if(item is TableReportParametersViewModel)
                return TableTemplate;
            if(item is SubreportParametersViewModel)
                return SubreportTemplate;
            return null;
        }
    }
}
