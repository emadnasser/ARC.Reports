using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Common {
    public sealed class WaitIndicator : ContentControl {
        public WaitIndicator() {
            this.DefaultStyleKey = typeof(WaitIndicator);
        }
        public object ActiveObject {
            get { return (object)GetValue(ActiveObjectProperty); }
            set { SetValue(ActiveObjectProperty, value); }
        }
        public static readonly DependencyProperty ActiveObjectProperty =
            DependencyProperty.Register("ActiveObject", typeof(object), typeof(WaitIndicator), new PropertyMetadata(null, (d,e) => ((WaitIndicator)d).OnActiveObjectChanged(e)));
        public bool IsActive {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(bool), typeof(WaitIndicator), new PropertyMetadata(true));
        void OnActiveObjectChanged(DependencyPropertyChangedEventArgs e) {
            IsActive = e.NewValue == null;
        }
    }
}
