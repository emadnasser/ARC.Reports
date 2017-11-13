using DevExpress.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace HybridApp.Common {
    class HybridTitleBarControl : ContentControl {
        #region field
        StackPanel titlePanel;
        ContentPresenter logo;
        Button dropDownButton;
        ContentPresenter titleBar;
        ContentPresenter menu;
        FlyoutControl flyoutMenu;
        bool isPopupMode;
        #endregion
        public HybridTitleBarControl() {
            DefaultStyleKey = typeof(HybridTitleBarControl);
            Loaded += OnLoad;
            Unloaded += OnUnload;
        }
        void OnLoad(object sender, RoutedEventArgs e) {
            Window.Current.SizeChanged += OnSizeChange;
            CoreWindow.GetForCurrentThread().PointerPressed += OnPointerPressed;
        }
        void OnUnload(object sender, RoutedEventArgs e) {
            Window.Current.SizeChanged -= OnSizeChange;
            CoreWindow.GetForCurrentThread().PointerPressed -= OnPointerPressed;
        }
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            InitializeChild();
            IsPopupMode = CheckWindowHeight();
            UpdateState();
            SetTitleBar(titlePanel);
        }
        void InitializeChild() {
            titlePanel = (StackPanel)GetTemplateChild("titlePanel");
            logo = (ContentPresenter)GetTemplateChild("logo");
            dropDownButton = (Button)GetTemplateChild("dropDownButton");
            titleBar = (ContentPresenter)GetTemplateChild("titleBar");
            menu = (ContentPresenter)GetTemplateChild("menu");
            flyoutMenu = (FlyoutControl)GetTemplateChild("flyoutMenu");
        }
        void SetTitleBar(UIElement title) {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.SetTitleBar(title);
        }
        void UpdateState() {
            if(!(IsPopupMode || IsMinimized)) {
                IsPopupMode = true;
                return;
            }
            if(IsPopupMode && IsMinimized) {
                IsPopupMode = false;
                return;
            }
        }
        bool CheckWindowHeight() {
            return Window.Current.Bounds.Height < WindowMinHeight;
        }
        #region SubscrizeEvent
        void OnPointerPressed(CoreWindow sender, PointerEventArgs e) {
            if(IsElementClicked(e.CurrentPoint.Position, flyoutMenu))
                return;
            if(IsElementClicked(e.CurrentPoint.Position, dropDownButton)) {
                flyoutMenu.IsOpen = !flyoutMenu.IsOpen;
                VisualStateManager.GoToState(this, flyoutMenu.IsOpen ? "OpenedTitleMenu" : "ClosedTitleMenu", true);
                return;
            }
            VisualStateManager.GoToState(this, "ClosedTitleMenu", true);
        }
        void OnSizeChange(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e) {
            UpdateState();
        }
        #endregion
        bool IsElementClicked(Point point, UIElement element) {
            return VisualTreeHelper.FindElementsInHostCoordinates(point, element).Count() != 0 ;
        }
        #region GoToState
        void GoToPopupMenuMode() {
            VisualStateManager.GoToState(this, "PopupMode", true);
            VisualStateManager.GoToState(this, "ClosedTitleMenu", true);
            menu.Content = null;
            flyoutMenu.PlacementTarget = this;
            flyoutMenu.Content = TitleMenu;
        }
        void GoToMenuMode() {
            VisualStateManager.GoToState(this, "MenuMode", true);
            VisualStateManager.GoToState(this, "ClosedTitleMenu", true);
            flyoutMenu.IsOpen = false;
            flyoutMenu.Content = null;
            menu.Content = TitleMenu;
        }
        #endregion
        #region prop
        bool IsMinimized { get { return CheckWindowHeight(); } }
        bool IsPopupMode {
            get {
                return isPopupMode;
            }
            set {
                if(value != isPopupMode) {
                    if(value) {
                        GoToMenuMode();
                    } else {
                        GoToPopupMenuMode();
                    }
                    isPopupMode = value;
                }
            }
        }
        public object TitleLogo {
            get { return (object)GetValue(TitleLogoProperty); }
            set { SetValue(TitleLogoProperty, value); }
        }
        public object TitleBar {
            get { return (object)GetValue(TitleBarProperty); }
            set { SetValue(TitleBarProperty, value); }
        }
        public object TitleMenu {
            get { return (object)GetValue(TitleMenuProperty); }
            set { SetValue(TitleMenuProperty, value); }
        }
        public double WindowMinHeight {
            get { return (double)GetValue(WindowMinHeightProperty); }
            set { SetValue(WindowMinHeightProperty, value); }
        }
        #endregion
        #region propdp
        public static readonly DependencyProperty TitleLogoProperty =
            DependencyProperty.Register("TitleLogo", typeof(object), typeof(HybridTitleBarControl), new PropertyMetadata(null));

        public static readonly DependencyProperty TitleBarProperty =
            DependencyProperty.Register("TitleBar", typeof(object), typeof(HybridTitleBarControl), new PropertyMetadata(null));

        public static readonly DependencyProperty TitleMenuProperty =
            DependencyProperty.Register("TitleMenu", typeof(object), typeof(HybridTitleBarControl), new PropertyMetadata(null));

        public static readonly DependencyProperty WindowMinHeightProperty =
            DependencyProperty.Register("WindowMinHeight", typeof(double), typeof(HybridTitleBarControl), new PropertyMetadata(750d));
        #endregion
    }
    public class MainDataTemplateSelector : DataTemplateSelector {

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) {
            return base.SelectTemplateCore(item, container);
        }
    }
}
