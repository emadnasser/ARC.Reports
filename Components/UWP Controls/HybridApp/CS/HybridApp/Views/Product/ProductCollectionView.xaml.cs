using DevExpress.Data;
using DevExpress.UI.Xaml.Grid;
using HybridApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    public sealed partial class ProductCollectionView : Page {
        public ProductCollectionView() {
            this.InitializeComponent();
            DataContext = ViewModel = new ProductCollectionViewModel();
        }
        public ProductCollectionViewModel ViewModel { get; set; }
        void DemoSparkColumnChart_Loaded(object sender, RoutedEventArgs e) {
            DemoSparkColumnChart chart = ((DemoSparkColumnChart)sender);
            chart.Width = gridControl.ActualWidth - 36;
            chart.Redraw();
        }
        void CustomSummary(object sender, CustomSummaryEventArgs e) {
            GridSummaryItem summaryItem = e.Item as GridSummaryItem;
            if(summaryItem.FieldName == "MonthlySales") {
                e.TotalValue = 1667800;
                e.TotalValueReady = true;
            }
        }
    }
}
