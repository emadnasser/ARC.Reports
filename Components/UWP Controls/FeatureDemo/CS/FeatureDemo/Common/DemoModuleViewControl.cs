using DevExpress.Core.Extensions;
using DevExpress.Core.Native;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI.Native;
using FeatureDemo.View;
using FeatureDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace FeatureDemo.Common {
    [ContentProperty(Name = nameof(DemoModuleContent))]
    public class DemoModuleView : UserControl {
        protected const double MaxMarginWidth = 1920;
        protected const double MinMarginWidth = 456;
        #region public props
        public UIElement DemoModuleContent { get; set; }
        public UIElement Options { get; set; }
        public bool HideOptionsInitially { get; set; }
        public Thickness MinMargin { get; set; } = new Thickness(20);
        public Thickness MaxMargin { get; set; } = new Thickness(50);
        public bool HasOptions { get { return Options != null; } }
        public double OptionsPaneWidth { get; set; } = 250;
        #endregion
        #region props
        internal SplitView SplitView { get; set; }
        internal bool IsLoaded { get; set; }
        public IList<VisualStateGroup> VisualStateGroups { get; } = new List<VisualStateGroup>();
        #endregion
        #region events
        internal event EventHandler Initialized;
        #endregion
        public DemoModuleView() {
            Loading += OnLoading;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e) {
            IsLoaded = true;
        }

        protected Thickness GetContentMargin(double width) {
            if(double.IsPositiveInfinity(width))
                width = MaxMarginWidth;
            double k = (Math.Min(Math.Max(width, MinMarginWidth), MaxMarginWidth) - MinMarginWidth) / (MaxMarginWidth - MinMarginWidth);
            return new Thickness(
                Math.Round(MinMargin.Left + k * (MaxMargin.Left - MinMargin.Left)),
                Math.Round(MinMargin.Top + k * (MaxMargin.Top - MinMargin.Top)),
                Math.Round(MinMargin.Right + k * (MaxMargin.Right - MinMargin.Right)),
                Math.Round(MinMargin.Bottom + k * (MaxMargin.Bottom - MinMargin.Bottom))
                );
        }
        protected override Size MeasureOverride(Size availableSize) {
            if(DemoModuleContent is FrameworkElement) {
                ((FrameworkElement)DemoModuleContent).Margin = GetContentMargin(availableSize.Width);
            }
            return base.MeasureOverride(availableSize);
        }
        private void CopyVisualStateGroups(FrameworkElement element) {
            if(element == null) return;
            IList<VisualStateGroup> elementGroups = VisualStateManager.GetVisualStateGroups(element);
            if(elementGroups.Count == 0 && VisualStateGroups.Count != 0) {
                foreach(VisualStateGroup group in VisualStateGroups) {
                    elementGroups.Add(group);
                }
            }
        }
        private void OnLoading(FrameworkElement sender, object args) {
            if(Content != null) return;
            if(!HasOptions) {
                CopyVisualStateGroups(DemoModuleContent as FrameworkElement);
                Content = DemoModuleContent;
            } else {
                SplitView = new SplitView() { PanePlacement = SplitViewPanePlacement.Right, OpenPaneLength = OptionsPaneWidth, PaneBackground = new SolidColorBrush(Colors.Transparent) };
                ScrollViewer paneScrollViewer = new ScrollViewer();
                paneScrollViewer.Style = (Style)Application.Current.Resources["DemoModulePaneScrollViewerStyle"];
                paneScrollViewer.Content = Options;
                SplitView.Content = DemoModuleContent;
                SplitView.Pane = paneScrollViewer;
                CopyVisualStateGroups(SplitView);
                Content = SplitView;
                if(DesignMode.DesignModeEnabled) {
                    SplitView.DisplayMode = SplitViewDisplayMode.Inline;
                    SplitView.IsPaneOpen = true;
                }
            }
            if(!DesignMode.DesignModeEnabled)
                Initialized.Invoke(this, null);
        }
    }
}
