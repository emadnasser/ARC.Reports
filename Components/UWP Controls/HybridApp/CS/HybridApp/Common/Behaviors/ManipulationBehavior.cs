using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.UI.Xaml.Layout;
using Windows.UI.Xaml;

namespace HybridApp.Views {
    public class ManipulationBehavior : Behavior<FrameworkElement> {
        DispatcherTimer releaseTimer;
        public ManipulationBehavior() {
            releaseTimer = new DispatcherTimer();
            releaseTimer.Interval = new System.TimeSpan(500);
            releaseTimer.Tick += releaseTimer_Tick;
        }
        public static readonly DependencyProperty ManipulationProperty =
    DependencyProperty.Register("Manipulation", typeof(bool), typeof(ManipulationBehavior), new PropertyMetadata(false));
        public bool Manipulation {
            get { return (bool)GetValue(ManipulationProperty); }
            set { SetValue(ManipulationProperty, value); }
        }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.ManipulationStarted += Started;
            AssociatedObject.ManipulationCompleted += Completed;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.ManipulationStarted -= Started;
            AssociatedObject.ManipulationCompleted -= Completed;
        }
        void Started(object sender, Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e) {
            Manipulation = true;
        }
        void Completed(object sender, Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e) {
            releaseTimer.Start();
        }
        void releaseTimer_Tick(object sender, object e) {
            Manipulation = false;
            releaseTimer.Stop();
        }
    }
    public class MultiBindingManipulationBehavior : Behavior<PivotContainer> {
        public MultiBindingManipulationBehavior() {
        }
        public static readonly DependencyProperty Manipulation1Property =
            DependencyProperty.Register("Manipulation1", typeof(bool), typeof(MultiBindingManipulationBehavior),
                new PropertyMetadata(false, (s, e) => ((MultiBindingManipulationBehavior)s).OnManipulationChange()));
        public static readonly DependencyProperty Manipulation2Property =
            DependencyProperty.Register("Manipulation2", typeof(bool), typeof(MultiBindingManipulationBehavior),
                new PropertyMetadata(false, (s, e) => ((MultiBindingManipulationBehavior)s).OnManipulationChange()));
        public bool Manipulation1 {
            get { return (bool)GetValue(Manipulation1Property); }
            set { SetValue(Manipulation1Property, value); }
        }
        public bool Manipulation2 {
            get { return (bool)GetValue(Manipulation2Property); }
            set { SetValue(Manipulation2Property, value); }
        }
        void OnManipulationChange() {
            if(AssociatedObject != null) {
                AssociatedObject.IsHitTestVisible = !(Manipulation1 || Manipulation2);
            }
        }
        protected override void OnAttached() {
            base.OnAttached();
        }
        protected override void OnDetaching() {
            base.OnDetaching();
        }
    }
}
