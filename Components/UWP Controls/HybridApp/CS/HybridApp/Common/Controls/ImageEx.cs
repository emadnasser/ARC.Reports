using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace HybridApp.Views {
    public class ImageEx : ContentControl {
        public ImageSource ConvertedSource {
            get { return (ImageSource)GetValue(ConvertedSourceProperty); }
            set { SetValue(ConvertedSourceProperty, value); }
        }
        public static readonly DependencyProperty ConvertedSourceProperty =
            DependencyProperty.Register("ConvertedSource", typeof(ImageSource), typeof(ImageEx), new PropertyMetadata(null));
        public Uri UriSource {
            get { return (Uri)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("UriSource", typeof(Uri), typeof(ImageEx), new PropertyMetadata(null, UpdateConvertedSource));
        public SolidColorBrush ColorizeBrush {
            get { return (SolidColorBrush)GetValue(ColorizeBrushProperty); }
            set { SetValue(ColorizeBrushProperty, value); }
        }
        public static readonly DependencyProperty ColorizeBrushProperty =
            DependencyProperty.Register("ColorizeBrush", typeof(SolidColorBrush), typeof(ImageEx), new PropertyMetadata(null, UpdateConvertedSource));
        public bool IsColorizeEnabled {
            get { return (bool)GetValue(IsColorizeEnabledProperty); }
            set { SetValue(IsColorizeEnabledProperty, value); }
        }
        public static readonly DependencyProperty IsColorizeEnabledProperty =
            DependencyProperty.Register("IsColorizeEnabled", typeof(bool), typeof(ImageEx), new PropertyMetadata(false, UpdateConvertedSource));
        static async void UpdateConvertedSource(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var imageEx = (ImageEx)d;
            var source = imageEx.UriSource;
            if(source != null && imageEx.IsColorizeEnabled) {
                Color color = imageEx.ColorizeBrush != null ? imageEx.ColorizeBrush.Color : Color.FromArgb(0xFF, 0x78, 0x78, 0x78);
                imageEx.ConvertedSource = await ImageColorizer.ColorizeImage(source, color);
            }
        }
    }
}
