using DevExpress.UI.Xaml.Grid;
using FeatureDemo.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace GridDemo {
    public sealed partial class InplaceEditing : GridDemoUserControl {
        public InplaceEditing() {
            this.InitializeComponent();
        }
        protected internal override GridControl Grid { get { return grid; } }
    }
    public abstract class ObjectToImageConverter : IValueConverter {
        Dictionary<string, BitmapImage> images = new Dictionary<string, BitmapImage>();

        public object Convert(object value, Type targetType, object parameter, string language) {
            string path = GetImagePath(value);
            BitmapImage image = null;
            if(!images.TryGetValue(path, out image)) {
                image = new BitmapImage(new Uri(path));
                images[path] = image;
            }
            return image;
        }
        protected abstract string GetImagePath(object value);

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
    public class PriorityToImageConverter : ObjectToImageConverter {
        protected override string GetImagePath(object value) {
            return "ms-appx:///GridDemo/Icons/Priority/" + Enum.GetName(typeof(Priority), value) + ".png";
        }
    }
    public class StatusToImageConverter : ObjectToImageConverter {
        protected override string GetImagePath(object value) {
            return "ms-appx:///GridDemo/Icons/Status/" + Enum.GetName(typeof(Status), value) + ".png";
        }
    }
}
