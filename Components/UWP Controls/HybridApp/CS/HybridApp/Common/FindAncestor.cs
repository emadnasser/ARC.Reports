using DevExpress.Core.Native;
using DevExpress.Mvvm.UI.Native;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public static class FindAncestor {
        public static readonly DependencyProperty AncestorTypeProperty =
            DependencyPropertyManager.RegisterAttached("AncestorType", typeof(string), typeof(FindAncestor), new DXPropertyMetadata(null, OnAncestorTypeChanged));
        public static readonly DependencyProperty AncestorProperty =
            DependencyPropertyManager.RegisterAttached("Ancestor", typeof(object), typeof(FindAncestor), new DXPropertyMetadata(null, OnAncestorChanged));
        public static readonly DependencyProperty AncestorDataContextProperty =
            DependencyPropertyManager.RegisterAttached("AncestorDataContext", typeof(object), typeof(FindAncestor), new DXPropertyMetadata(null));

        public static string GetAncestorType(FrameworkElement d) { return (string)d.GetValue(AncestorTypeProperty); }
        public static void SetAncestorType(FrameworkElement d, string v) { d.SetValue(AncestorTypeProperty, v); }
        public static object GetAncestor(FrameworkElement d) { return d.GetValue(AncestorProperty); }
        public static void SetAncestor(FrameworkElement d, object v) { d.SetValue(AncestorProperty, v); }
        public static object GetAncestorDataContext(FrameworkElement d) { return d.GetValue(AncestorDataContextProperty); }
        public static void SetAncestorDataContext(FrameworkElement d, object v) { d.SetValue(AncestorDataContextProperty, v); }

        static void OnAncestorTypeChanged(DependencyObject d, DXDependencyPropertyChangedEventArgs e) {
            FrameworkElement element = (FrameworkElement)d;
            element.Loaded += OnElementLoaded;
        }
        static void OnElementLoaded(object sender, RoutedEventArgs e) {
            FrameworkElement element = (FrameworkElement)sender;
            string ancestorType = GetAncestorType(element);
            SetAncestor(element, LayoutHelper.FindLayoutOrVisualParentObject(element, o => o.GetType().Name == ancestorType) as FrameworkElement);
        }
        static void OnAncestorChanged(DependencyObject d, DXDependencyPropertyChangedEventArgs e) {
            FrameworkElement element = (FrameworkElement)d;
            element.SetBinding(AncestorDataContextProperty, new Binding() { Path = new PropertyPath("DataContext"), Source = e.NewValue, Mode = BindingMode.OneWay });
        }
    }
}
