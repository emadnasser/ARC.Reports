using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Graphics.Printing;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Printing;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Storage.Streams;
using System.Diagnostics;
using Windows.Storage;

namespace FeatureDemo.Common {
    public class PrintFrameworkElementBehavior : DevExpress.Mvvm.UI.Interactivity.Behavior<FrameworkElement> {
        PrintDocument printDocument;
        public IPrintDocumentSource DocumentSource {
            get { return (IPrintDocumentSource)GetValue(DocumentSourceProperty); }
            set { SetValue(DocumentSourceProperty, value); }
        }
        public static readonly DependencyProperty DocumentSourceProperty =
            DependencyProperty.Register("DocumentSource", typeof(IPrintDocumentSource), typeof(PrintFrameworkElementBehavior), new PropertyMetadata(null));
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Loaded += AssociatedObject_Loaded;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            this.DataContextChanged += PrintFrameworkElementBehavior_DataContextChanged;
            if(DataContext != null)
                UpdateDocumentSource();
        }
        void PrintFrameworkElementBehavior_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args) {
            UpdateDocumentSource();
        }
        void UpdateDocumentSource() {
            printDocument = new PrintDocument();
            printDocument.Paginate += OnPaginate;
            printDocument.GetPreviewPage += OnGetPreviewPage;
            printDocument.AddPages += OnAddPages;
            DocumentSource = printDocument.DocumentSource;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            printDocument = null;
        }
        async Task<Image> RenderPageForPrinting(FrameworkElement fe) {
            var oldTheme = AssociatedObject.RequestedTheme;
            fe.RequestedTheme = ElementTheme.Light;
            try {
                RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
                await renderTargetBitmap.RenderAsync(fe);
                var pixelBuffer = await renderTargetBitmap.GetPixelsAsync();
                var pixels = pixelBuffer.ToArray();

                WriteableBitmap bitmap = new WriteableBitmap(renderTargetBitmap.PixelWidth, renderTargetBitmap.PixelHeight);
                using(Stream stream = bitmap.PixelBuffer.AsStream()) {
                    await stream.WriteAsync(pixels, 0, pixels.Length);
                }

                return new Image() { Source = bitmap };
            } finally {
                AssociatedObject.RequestedTheme = oldTheme;
            }
        }

        async void OnAddPages(object sender, AddPagesEventArgs e) {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => {
                var image = await RenderPageForPrinting(AssociatedObject);
                printDocument.AddPage(image);
                printDocument.AddPagesComplete();
            });
        }
        async void OnGetPreviewPage(object sender, GetPreviewPageEventArgs e) {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => {
                var image = await RenderPageForPrinting(AssociatedObject);
                printDocument.SetPreviewPage(e.PageNumber, image);
            });
        }
        async void OnPaginate(object sender, PaginateEventArgs e) {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => {
                printDocument.SetPreviewPageCount(1, PreviewPageCountType.Final);
            });
        }
    }
}
