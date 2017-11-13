using System.Linq;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.UI.Interactivity;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml;

namespace HybridApp.Views {
    public class ToggleButtonsResetBehavior : Behavior<StackPanel> {
        ObservableCollection<ToggleButton> buttonsCollection;
        public ToggleButtonsResetBehavior() {
            buttonsCollection = new ObservableCollection<ToggleButton>();
        }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_Loaded;
            foreach(var button in buttonsCollection)
                button.Click -= Button_Click;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            foreach(var button in AssociatedObject.Children.OfType<ToggleButton>()) {
                buttonsCollection.Add(button);
                button.Click += Button_Click;
            }
        }
        void Button_Click(object sender, RoutedEventArgs e) {
            ToggleButton button = ((ToggleButton)sender);
            if(button.IsChecked == true) {
                foreach(var item in buttonsCollection) {
                    if(item.Content.ToString() != button.Content.ToString() && item.IsChecked == true)
                        item.IsChecked = false;
                }
            } else
                button.IsChecked = true;
        }
    }
}
