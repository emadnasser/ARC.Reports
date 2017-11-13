using DevExpress.Mvvm.UI.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace HybridApp.Common {
    public class HamburgerButtonBehavior : Behavior<ToggleButton> {
        public static readonly DependencyProperty ButtonCheckedProperty =
            DependencyProperty.Register("ButtonChecked", typeof(bool), typeof(HamburgerButtonBehavior), new PropertyMetadata(false, (s, e) => ((HamburgerButtonBehavior)s).OnButtonCheckedChanged()));
        public static readonly DependencyProperty PaneSelectedItemProperty =
            DependencyProperty.Register("PaneSelectedItem", typeof(object), typeof(HamburgerButtonBehavior), new PropertyMetadata(null, (s, e) => ((HamburgerButtonBehavior)s).OnSelectedItemChanged()));

        public bool ButtonChecked {
            get { return (bool)GetValue(ButtonCheckedProperty); }
            set { SetValue(ButtonCheckedProperty, value); }
        }
        public object PaneSelectedItem {
            get { return GetValue(PaneSelectedItemProperty); }
            set { SetValue(PaneSelectedItemProperty, value); }
        }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Checked += Checked;
            AssociatedObject.Unchecked += Unchecked;
        }
        protected override void OnDetaching() {
            AssociatedObject.Checked -= Checked;
            AssociatedObject.Unchecked -= Unchecked;
            base.OnDetaching();
        }
        void OnSelectedItemChanged() {
            if(AssociatedObject != null)
                AssociatedObject.IsChecked = false;
        }
        void OnButtonCheckedChanged() {
            if(AssociatedObject != null)
                AssociatedObject.IsChecked = ButtonChecked;
        }
        void Unchecked(object sender, RoutedEventArgs e) {
            ButtonChecked = false;
        }
        void Checked(object sender, RoutedEventArgs e) {
            ButtonChecked = true;
        }
    }
}
