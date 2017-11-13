using System;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HybridApp.Views {
    public static class ImageColorizer {
        public static async Task<ImageSource> ColorizeImage(Uri source, Color color) {
            source = FixUri(source);
            var file = await StorageFile.GetFileFromApplicationUriAsync(source);
            var bd = await BitmapDecoder.CreateAsync(BitmapDecoder.PngDecoderId, await file.OpenAsync(FileAccessMode.Read));
            var pd = await bd.GetPixelDataAsync();
            var buffer = pd.DetachPixelData();
            int k = 0;
            for(var i = 0; i < buffer.Length - 4; i += 4) {
                if(buffer[i + 3] != 0) {
                    buffer[i] = bd.BitmapPixelFormat == BitmapPixelFormat.Bgra8 ? color.B : color.R;
                    buffer[i + 1] = color.G;
                    buffer[i + 2] = bd.BitmapPixelFormat == BitmapPixelFormat.Bgra8 ? color.R : color.B; ;
                }
                k++;
            }

            var newStream = new InMemoryRandomAccessStream();
            var bitmap = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, newStream);
            bitmap.SetPixelData(bd.BitmapPixelFormat, BitmapAlphaMode.Straight, bd.PixelWidth, bd.PixelHeight, bd.DpiX, bd.DpiY, buffer);
            await bitmap.FlushAsync();

            newStream.Seek(0);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.SetSource(newStream);
            return bitmapImage;
        }
        const string errorUri = @"ms-appx:/";
        const string rightUri = @"ms-appx:///";
        static Uri FixUri(Uri source) {
            if(source.OriginalString.Contains(errorUri) && !source.OriginalString.Contains(rightUri))
                source = new Uri(source.OriginalString.Replace(errorUri, rightUri));
            return source;
        }
    }

}
