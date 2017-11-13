using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HybridApp.Common {
    public class AppBarExtensions {
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.RegisterAttached("ImageSource", typeof(Uri), typeof(AppBarExtensions), new PropertyMetadata(null, OnImageSourcePropertyChanged));
        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.RegisterAttached("Stretch", typeof(Stretch), typeof(AppBarExtensions), new PropertyMetadata(Stretch.None, OnStretchPropertyChanged));
        static void OnStretchPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            Image image = GetImage(d);
            image.Stretch = (Stretch)e.NewValue;
            EnsureImageSize(image);
        }
        static void OnImageSourcePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var image = GetImage(d);
            image.Source = new BitmapImage(e.NewValue as Uri);
            EnsureImageSize(image);
        }

        static Image GetImage(DependencyObject d) {
            ButtonBase appBarButton = (ButtonBase)d;
            if(!(appBarButton.Content is Image))
                appBarButton.Content = new Image();
            Image image = (Image)appBarButton.Content;
            return image;
        }
        static void EnsureImageSize(Image image) {
            image.Width = 20;
            image.Height = 20;
        }
        public static Uri GetImageSource(DependencyObject obj) {
            return (Uri)obj.GetValue(ImageSourceProperty);
        }
        public static void SetImageSource(DependencyObject obj, Uri value) {
            obj.SetValue(ImageSourceProperty, value);
        }
        public static Stretch GetStretch(DependencyObject obj) {
            return (Stretch)obj.GetValue(StretchProperty);
        }
        public static void SetStretch(DependencyObject obj, Stretch value) {
            obj.SetValue(StretchProperty, value);
        }
    }
}
