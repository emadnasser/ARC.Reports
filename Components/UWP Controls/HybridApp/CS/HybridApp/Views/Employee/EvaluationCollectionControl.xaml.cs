using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    public sealed partial class EvaluationCollectionControl : UserControl {
        public EvaluationCollectionControl() {
            this.InitializeComponent();
        }
        void container_Loaded(object sender, RoutedEventArgs e) {
            StackPanel panel = (StackPanel)sender;
            panel.Width = grid.ActualWidth - panel.Margin.Left - panel.Margin.Right;
        }
    }
}
