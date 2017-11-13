using DevExpress.Data;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Native;
using DevExpress.UI.Xaml.Grid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace HybridApp.Views {
    public sealed partial class CustomerCollectionView : Page {
        public CustomerCollectionView() {
            this.InitializeComponent();
        }
        void Card_Loaded(object sender, RoutedEventArgs e) {
            Grid gridCard = (Grid)sender;
            gridCard.Width = grid.ActualWidth - gridCard.Margin.Left - gridCard.Margin.Right - 17;
        }
        void DemoSparkColumnChart_Loaded(object sender, RoutedEventArgs e) {
            DemoSparkColumnChart chart = ((DemoSparkColumnChart)sender);
            chart.Width = gridControl.ActualWidth - 36;
            chart.Redraw();
        }
        void CustomSummary(object sender, CustomSummaryEventArgs e) {
            GridSummaryItem summaryItem = e.Item as GridSummaryItem;
            if(summaryItem.FieldName == "MonthlySales") {
                e.TotalValue = 3000490;
                e.TotalValueReady = true;
            }
        }
    }
    public class GridControlEventArgsConverter : EventArgsConverterBase<DoubleTappedRoutedEventArgs> {
        protected override object Convert(object sender, DoubleTappedRoutedEventArgs args) {
            var element = args.OriginalSource as DependencyObject;
            if(element == null)
                return null;
            var row = LayoutHelper.FindParentObject<DataRowControlBase>(element);
            return row?.DataContext;
        }
    }
}
