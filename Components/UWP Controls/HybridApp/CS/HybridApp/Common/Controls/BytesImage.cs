using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HybridApp.Views {
    public class BytesImage : ContentControl {
        public BytesImage() {
            DefaultStyleKey = typeof(BytesImage);
        }
        public byte[] BytesSource {
            get { return (byte[])GetValue(BytesSourceProperty); }
            set { SetValue(BytesSourceProperty, value); }
        }
        public static readonly DependencyProperty BytesSourceProperty =
            DependencyProperty.Register("BytesSource", typeof(byte[]), typeof(BytesImage), new PropertyMetadata(null, OnBytesSourceChanged));
        async static void OnBytesSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            BytesImage bytesImage = d as BytesImage;
            byte[] bytes = e.NewValue as byte[];
            bytesImage.Source = bytes == null ? null : await GetImageByBytes(bytes);
        }
        static async Task<BitmapImage> GetImageByBytes(byte[] bytes) {
            BitmapImage image;
            using(InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream()) {
                image = new BitmapImage();
                await stream.WriteAsync(bytes.AsBuffer());
                stream.Seek(0);
                image.SetSource(stream);
            }
            return image;
        }
        public ImageSource Source {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(BytesImage), new PropertyMetadata(null));
        public Stretch Stretch {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }
        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register("Stretch", typeof(Stretch), typeof(BytesImage), new PropertyMetadata(Stretch.Uniform));
    }
}
