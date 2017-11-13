using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views{
    public sealed partial class EmployeeTaskCollectionControl : UserControl {
        public EmployeeTaskCollectionControl() {
            this.InitializeComponent();
        }
        public string QueryText {
            get { return (string)GetValue(QueryTextProperty); }
            set { SetValue(QueryTextProperty, value); }
        }
        public bool ShowTotalSummary {
            get { return (bool)GetValue(ShowTotalSummaryProperty); }
            set { SetValue(ShowTotalSummaryProperty, value); }
        }
        public static readonly DependencyProperty ShowTotalSummaryProperty =
            DependencyProperty.Register("ShowTotalSummary", typeof(string), typeof(EmployeeTaskCollectionControl), new PropertyMetadata(true));
        public static readonly DependencyProperty QueryTextProperty =
            DependencyProperty.Register("QueryText", typeof(string), typeof(EmployeeTaskCollectionControl), new PropertyMetadata(string.Empty));
        void container_Loaded(object sender, RoutedEventArgs e) {
            var panel = (FrameworkElement)sender;
            panel.Width = grid.ActualWidth - panel.Margin.Left - panel.Margin.Right;
        }
    }
}
