using DevExpress.Mvvm.UI.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace HybridApp.Common {
    public class PaneAnimationBehavior : Behavior<FrameworkElement> {
        TranslateTransform paneTransform;
        DoubleAnimation animation;
        Storyboard storyboard;

        public static readonly DependencyProperty PaneVisibilityProperty =
            DependencyProperty.Register("PaneVisibility", typeof(Visibility), typeof(PaneAnimationBehavior),
                new PropertyMetadata(Visibility.Collapsed, (s, e) => ((PaneAnimationBehavior)s).PaneVisibilityChange()));
        public Visibility PaneVisibility {
            get { return (Visibility)GetValue(PaneVisibilityProperty); }
            set { SetValue(PaneVisibilityProperty, value); }
        }
        public Duration Duration { get; set; }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Visibility = Visibility.Collapsed;
            paneTransform = new TranslateTransform() { X = -500 };
            AssociatedObject.RenderTransform = paneTransform;
            animation = new DoubleAnimation() {
                Duration = this.Duration,
                EasingFunction = new CubicEase() { EasingMode = EasingMode.EaseOut }
            };
            storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTarget(animation, paneTransform);
            Storyboard.SetTargetProperty(animation, "X");
            AssociatedObject.Resources.Add("Animation", storyboard);
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_Loaded;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            AssociatedObject.Visibility = Visibility.Visible;
        }
        void PaneVisibilityChange() {
            if(AssociatedObject == null) return;
            animation.From = (PaneVisibility == Visibility.Collapsed) ? 0 : -AssociatedObject.ActualWidth;
            animation.To = (PaneVisibility == Visibility.Collapsed) ? -AssociatedObject.ActualWidth : 0;
            storyboard.Begin();
        }
    }
}
