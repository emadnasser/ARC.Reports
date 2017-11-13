using System.Linq;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace HybridApp.Views {
    public class CollectionControl : ContentControl {
        public CollectionControl() {
            Loaded += OnLoad;
            Unloaded += OnUnload;
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                CoreWindow.GetForCurrentThread().PointerPressed += OnPointerPressed;
            DefaultStyleKey = typeof(CollectionControl);
        }
        void OnLoad(object sender, RoutedEventArgs e) {
            if(!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            Window.Current.SizeChanged += WindowSizeChange;
            Update();
        }
        void OnUnload(object sender, RoutedEventArgs e) {
            if(!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
            Window.Current.SizeChanged -= WindowSizeChange;
        }
        Border leftCollapsibleContent;
        Border rightCollapsibleContent;
        ToggleButton leftExpandButton;
        ToggleButton rightExpandButton;
        double windowSize = 1050d;
        bool isOpen;
        internal bool IsOpen {
            get {
                return isOpen;
            }
            set {
                if(value == isOpen)
                    return;
                isOpen = value;
                if(isOpen) {
                    OpenLeft();
                    OpenRight();
                } else {
                    CloseLeft();
                    CloseRight();
                }
            }
        }
        bool IsMinimized { get { return Window.Current.Bounds.Width < windowSize; } }
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            leftCollapsibleContent = (Border)GetTemplateChild("leftCollapsibleContent");
            leftExpandButton = (ToggleButton)GetTemplateChild("leftExpandButton");
            rightCollapsibleContent = (Border)GetTemplateChild("rightCollapsibleContent");
            rightExpandButton = (ToggleButton)GetTemplateChild("rightExpandButton");
            IsOpen = Window.Current.Bounds.Width < windowSize;
            Update();
        }
        void Update() {
            if(!(IsOpen || IsMinimized)) {
                IsOpen = true;
                return;
            }
            if(IsOpen && IsMinimized) {
                IsOpen = false;
            }
        }
        #region OpenAndClose
        void CloseRight() {
            rightExpandButton.IsChecked = true;
            rightCollapsibleContent.Margin = new Thickness(0, 19,0, 3);
            Grid.SetColumn(rightCollapsibleContent, 2);
        }
        void CloseLeft() {
            leftExpandButton.IsChecked = false;
            leftCollapsibleContent.Margin = new Thickness(0);
            leftCollapsibleContent.VerticalAlignment = VerticalAlignment.Top;
            Grid.SetColumn(leftCollapsibleContent, 2);
        }
        void OpenRight() {
            rightExpandButton.IsChecked = false;
            rightCollapsibleContent.Margin = new Thickness(0, 19, 40, 3);
            Grid.SetColumn(rightCollapsibleContent, 4);
        }
        void OpenLeft() {
            leftExpandButton.IsChecked = true;
            leftCollapsibleContent.Margin = new Thickness(40, 0, 0, 3);
            leftCollapsibleContent.VerticalAlignment = VerticalAlignment.Stretch;
            Grid.SetColumn(leftCollapsibleContent, 0);
        }
        #endregion
        void WindowSizeChange(object sender, WindowSizeChangedEventArgs e) {
            Update();
        }
        bool ElementMissedInCordinates(Point point, UIElement element) {
            return VisualTreeHelper.FindElementsInHostCoordinates(point, element).Count() == 0;
        }
        bool NeedClosePopup(Point point) {
            if(!IsMinimized)
                return false;
            return ElementMissedInCordinates(point, leftCollapsibleContent)
                && ElementMissedInCordinates(point, rightCollapsibleContent)
                && ElementMissedInCordinates(point, leftExpandButton)
                && ElementMissedInCordinates(point, rightExpandButton);
        }
        void OnPointerPressed(CoreWindow sender, PointerEventArgs e) {
            if(!NeedClosePopup(e.CurrentPoint.Position))
                return;
            leftExpandButton.IsChecked = false;
            rightExpandButton.IsChecked = true;
        }
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(CollectionControl), new PropertyMetadata(null));
        public static readonly DependencyProperty FooterProperty =
            DependencyProperty.Register("Footer", typeof(object), typeof(CollectionControl), new PropertyMetadata(null));
        public static readonly DependencyProperty LeftCollapsibleContentProperty =
            DependencyProperty.Register("LeftCollapsibleContent", typeof(object), typeof(CollectionControl), new PropertyMetadata(null));
        public static readonly DependencyProperty RightCollapsibleContentProperty =
            DependencyProperty.Register("RightCollapsibleContent", typeof(object), typeof(CollectionControl), new PropertyMetadata(null));
        public static readonly DependencyProperty MainContentProperty =
            DependencyProperty.Register("MainContent", typeof(object), typeof(CollectionControl), new PropertyMetadata(null));
        public object Header {
            get { return (object)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }
        public object Footer {
            get { return (object)GetValue(FooterProperty); }
            set { SetValue(FooterProperty, value); }
        }
        public object LeftCollapsibleContent {
            get { return (object)GetValue(LeftCollapsibleContentProperty); }
            set { SetValue(LeftCollapsibleContentProperty, value); }
        }
        public object RightCollapsibleContent {
            get { return (object)GetValue(RightCollapsibleContentProperty); }
            set { SetValue(RightCollapsibleContentProperty, value); }
        }
        public object MainContent {
            get { return (object)GetValue(MainContentProperty); }
            set { SetValue(MainContentProperty, value); }
        }
    }
}
