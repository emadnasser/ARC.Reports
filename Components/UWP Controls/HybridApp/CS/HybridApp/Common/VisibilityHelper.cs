using DevExpress.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace HybridApp.Common {
    public static class VisibilityHelper {
        public static readonly DependencyProperty IsHiddenProperty =
            DependencyProperty.RegisterAttached("IsHidden", typeof(object), typeof(VisibilityHelper), new PropertyMetadata(false, OnIsHiddenChanged));

        public static bool GetIsHidden(UIElement d) { return (bool)d.GetValue(IsHiddenProperty); }
        public static void SetIsHidden(UIElement d, bool v) { d.SetValue(IsHiddenProperty, v); }
        static void OnIsHiddenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            UIElement element = (UIElement)d;
            if((bool)e.NewValue) {
                element.Opacity = 0.0;
                element.IsHitTestVisible = false;
            } else {
                element.Opacity = 1.0;
                element.IsHitTestVisible = true;
            }
        }
    }
}
