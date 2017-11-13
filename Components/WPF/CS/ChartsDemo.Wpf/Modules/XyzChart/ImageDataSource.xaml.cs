using System;
using System.ComponentModel;
using System.Windows.Media;
using DevExpress.DemoData.Utils;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/XyzChart/ImageDataSource(.SL).xaml"),
    CodeFile("Modules/XyzChart/ImageDataSource.xaml.(cs)")]
    public partial class ImageDataSource : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public ImageDataSource() {
            InitializeComponent();
            DataContext = new HeightViewModel();
        }
        public override bool SupportSidebarContent() {
            return false;
        }
    }
    public class FillStyleItem : INotifyPropertyChanged {
        string title;
        FillStyleBase fillStyle;

        public string Title {
            get { return title; }
            set {
                if (title != value) {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }
        public FillStyleBase FillStyle {
            get { return fillStyle; }
            set {
                if (fillStyle != value) {
                    fillStyle = value;
                    NotifyPropertyChanged("FillStyle");
                }
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    public class HeightViewModel : INotifyPropertyChanged {
        DoubleCollection mapValues;
        DoubleCollection mapX;
        DoubleCollection mapY;

        public DoubleCollection MapValues { get { return mapValues; } set { mapValues = value; NotifyPropertyChanged("MapValues"); } }
        public DoubleCollection MapX { get { return mapX; } set { mapX = value; NotifyPropertyChanged("MapX"); } }
        public DoubleCollection MapY { get { return mapY; } set { mapY = value; NotifyPropertyChanged("MapY"); } }

        public static Uri HeightMapUri { get { return AssemblyHelper.GetResourceUri(typeof(ImageDataSource).Assembly, "/Data/Heightmap.jpg"); } }

        #region INotifyPropertyChanged
        PropertyChangedEventHandler onPropertyChanged;
        public event PropertyChangedEventHandler PropertyChanged {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }
        void NotifyPropertyChanged(string propertyName) {
            if(this.onPropertyChanged != null)
                this.onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public HeightViewModel() {
            GenerateMap(HeightMapUri);
        }

        void GenerateMap(Uri uri) {
            ImageData ImageData = new ImageData(uri);
            PixelColor[,] pixels = ImageData.GetPixels();

            int countX = pixels.GetLength(0);
            int countY = pixels.GetLength(1);

            int startX = 0;
            int startY = 0;
            int gridStep = 100;
            double minY = -300;
            double maxY = 3000;

            DoubleCollection mapX = new DoubleCollection(countX);
            DoubleCollection mapY = new DoubleCollection(countY);
            DoubleCollection values = new DoubleCollection(countX * countY);
            bool fullY = false;
            for(int i = 0; i < countX; i++) {
                mapX.Add(startX + i * gridStep);
                for(int j = 0; j < countY; j++) {
                    if(!fullY)
                        mapY.Add(startY + j * gridStep);
                    double value = GetValue(pixels[i, j], minY, maxY);
                    values.Add(value);

                }
                fullY = true;
            }
            MapY = mapY;
            MapX = mapX;
            MapValues = values;
        }

        double GetValue(PixelColor color, double min, double max) {
            double normalizedValue = (double)color.Gray / 255.0;
            return min + normalizedValue * (max - min);
        }
    }
}
