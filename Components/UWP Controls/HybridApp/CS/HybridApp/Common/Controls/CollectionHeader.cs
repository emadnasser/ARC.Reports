using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    public class HybridAppHeader : ContentControl {
        public HybridAppHeader() {
            DefaultStyleKey = typeof(HybridAppHeader);
        }
        public string LeftHeader {
            get { return (string)GetValue(LeftHeaderProperty); }
            set { SetValue(LeftHeaderProperty, value); }
        }
        public static readonly DependencyProperty LeftHeaderProperty =
            DependencyProperty.Register("LeftHeader", typeof(string), typeof(HybridAppHeader), new PropertyMetadata(null));
        public string RightHeader {
            get { return (string)GetValue(RightHeaderProperty); }
            set { SetValue(RightHeaderProperty, value); }
        }
        public static readonly DependencyProperty RightHeaderProperty =
            DependencyProperty.Register("RightHeader", typeof(string), typeof(HybridAppHeader), new PropertyMetadata(null));
    }
}
