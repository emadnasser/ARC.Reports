using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    public class ImageLayoutPanel : Panel {
        double childHeight;
        protected override Size MeasureOverride(Size availableSize) {
            double childWith = 0.0;
            foreach(UIElement child in Children) {
                child.Measure(new Size(availableSize.Width, childHeight));
                if(child.DesiredSize.Width > childWith)
                    childWith = child.DesiredSize.Width;
            }
            return new Size(childWith, 1.0);
        }
        protected override Size ArrangeOverride(Size finalSize) {
            foreach(UIElement child in Children)
                child.Arrange(new Rect(new Point(), finalSize));
            double newChildHeight = finalSize.Height;
            if(newChildHeight != childHeight && newChildHeight != 0) {
                childHeight = newChildHeight;
                InvalidateMeasure();
            }
            return finalSize;
        }
    }
}
