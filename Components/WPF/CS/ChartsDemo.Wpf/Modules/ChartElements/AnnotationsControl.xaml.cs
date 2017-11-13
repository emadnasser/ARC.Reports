using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Globalization;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;


namespace ChartsDemo {
    [CodeFile("Modules/ChartElements/AnnotationsControl(.SL).xaml"),
     CodeFile("Modules/ChartElements/AnnotationsControl.xaml.(cs)")]
    public partial class AnnotationsControl : ChartsDemoModule {
        AnnotationsViewModel annotationLayoutViewModel;

        public override ChartControlBase ActualChart { get { return chart; } }

        public AnnotationsControl() {
            InitializeComponent();
            annotationLayoutViewModel = new AnnotationsViewModel();
            DataContext = annotationLayoutViewModel;
        }

        void chart_BoundDataChanged(object sender, RoutedEventArgs e) {
            if (chart.Diagram.Series != null && chart.Diagram.Series.Count > 0) {
                Tuple<SeriesPoint, SeriesPoint> minMaxPoints = FindExtremalPoints(chart.Diagram.Series[0]);
                annotationLayoutViewModel.AnnotationMinimumSeriesPoint = minMaxPoints.Item1;
                annotationLayoutViewModel.AnnotationMaximumSeriesPoint = minMaxPoints.Item2;
            }
        }
        Tuple<SeriesPoint, SeriesPoint> FindExtremalPoints(Series series) {
            SeriesPoint minimumPoint = series.Points[0];
            SeriesPoint maximumPoint = series.Points[0];
            foreach (SeriesPoint point in series.Points){
                if (point.Value < minimumPoint.Value)
                    minimumPoint = point;
                if (point.Value > maximumPoint.Value)
                    maximumPoint = point;
            }
            return new Tuple<SeriesPoint, SeriesPoint>(minimumPoint, maximumPoint);
        }
    }

    public class AnnotationsViewModel : INotifyPropertyChanged {
        List<MarsTemperature> marsTemperatureData;
        SeriesPoint annotationMinimumSeriesPoint;
        SeriesPoint annotationMaximumSeriesPoint;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<MarsTemperature> MarsTemperatureData {
            get { return marsTemperatureData; }
            set {
                if (marsTemperatureData != value) {
                    marsTemperatureData = value;
                    OnPropertyChanged("MarsTemperatureData");
                }
            }
        }
        public SeriesPoint AnnotationMinimumSeriesPoint {
            get { return annotationMinimumSeriesPoint; }
            set {
                if (annotationMinimumSeriesPoint != value) {
                    annotationMinimumSeriesPoint = value;
                    OnPropertyChanged("AnnotationMinimumSeriesPoint");
                }
            }
        }
        public SeriesPoint AnnotationMaximumSeriesPoint {
            get { return annotationMaximumSeriesPoint; }
            set {
                if (annotationMaximumSeriesPoint != value) {
                    annotationMaximumSeriesPoint = value;
                    OnPropertyChanged("AnnotationMaximumSeriesPoint");
                }
            }
        }

        public AnnotationsViewModel() {
            MarsTemperatureData = MarsTemperature.GetData();
        }

        void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MarsTemperature {
        public static List<MarsTemperature> GetData() {
            return new List<MarsTemperature>(){
                new MarsTemperature(){ Sol = 2.466424, Temperature = -28.2},
                new MarsTemperature(){ Sol = 2.486035, Temperature = -25.4},
                new MarsTemperature(){ Sol = 2.505635, Temperature = -23.4},
                new MarsTemperature(){ Sol = 2.525235, Temperature = -22.4},
                new MarsTemperature(){ Sol = 2.544851, Temperature = -21},
                new MarsTemperature(){ Sol = 2.564458, Temperature = -19.7},
                new MarsTemperature(){ Sol = 2.584058, Temperature = -15.9},
                new MarsTemperature(){ Sol = 2.603669, Temperature = -15.3},
                new MarsTemperature(){ Sol = 2.623269, Temperature = -15.3},
                new MarsTemperature(){ Sol = 2.64288, Temperature = -18.9},
                new MarsTemperature(){ Sol = 2.66249, Temperature = -21.1},
                new MarsTemperature(){ Sol = 2.682092, Temperature = -23.2},
                new MarsTemperature(){ Sol = 2.701703, Temperature = -26.9},
                new MarsTemperature(){ Sol = 2.721314, Temperature = -30.8},
                new MarsTemperature(){ Sol = 2.760537, Temperature = -43.8},
                new MarsTemperature(){ Sol = 2.780148, Temperature = -45.7},
                new MarsTemperature(){ Sol = 2.79976, Temperature = -49.1},
                new MarsTemperature(){ Sol = 2.819371, Temperature = -51.5},
                new MarsTemperature(){ Sol = 2.838982, Temperature = -55.5},
                new MarsTemperature(){ Sol = 2.858594, Temperature = -57.5},
                new MarsTemperature(){ Sol = 2.878205, Temperature = -61},
                new MarsTemperature(){ Sol = 2.897816, Temperature = -61.1},
                new MarsTemperature(){ Sol = 2.917428, Temperature = -64.5},
                new MarsTemperature(){ Sol = 2.937039, Temperature = -64.9},
                new MarsTemperature(){ Sol = 2.976262, Temperature = -67.8},
                new MarsTemperature(){ Sol = 3.035084, Temperature = -69.3},
                new MarsTemperature(){ Sol = 3.074307, Temperature = -70.4},
                new MarsTemperature(){ Sol = 3.093918, Temperature = -71.3},
                new MarsTemperature(){ Sol = 3.11353, Temperature = -71.9},
                new MarsTemperature(){ Sol = 3.191964, Temperature = -75},
                new MarsTemperature(){ Sol = 3.211575, Temperature = -76},
                new MarsTemperature(){ Sol = 3.231186, Temperature = -74.7},
                new MarsTemperature(){ Sol = 3.250786, Temperature = -71.6},
                new MarsTemperature(){ Sol = 3.270398, Temperature = -67.2},
                new MarsTemperature(){ Sol = 3.289998, Temperature = -63.7},
                new MarsTemperature(){ Sol = 3.309609, Temperature = -59.5},
                new MarsTemperature(){ Sol = 3.329209, Temperature = -53},
                new MarsTemperature(){ Sol = 3.34882, Temperature = -47.7},
                new MarsTemperature(){ Sol = 3.368421, Temperature = -44.3},
                new MarsTemperature(){ Sol = 3.388032, Temperature = -42},
                new MarsTemperature(){ Sol = 3.407632, Temperature = -36},
                new MarsTemperature(){ Sol = 3.427243, Temperature = -32.6},
                new MarsTemperature(){ Sol = 3.446843, Temperature = -29.8},
                new MarsTemperature(){ Sol = 3.466274, Temperature = -27},
                new MarsTemperature(){ Sol = 3.505486, Temperature = -22.3},
                new MarsTemperature(){ Sol = 3.544708, Temperature = -19.5},
                new MarsTemperature(){ Sol = 3.56432, Temperature = -17.1},
                new MarsTemperature(){ Sol = 3.603531, Temperature = -15.1},
                new MarsTemperature(){ Sol = 3.623142, Temperature = -14.8},
                new MarsTemperature(){ Sol = 3.642742, Temperature = -19.2},
                new MarsTemperature(){ Sol = 3.662343, Temperature = -19.5},
                new MarsTemperature(){ Sol = 3.681954, Temperature = -22.4},
                new MarsTemperature(){ Sol = 3.701565, Temperature = -26.1},
                new MarsTemperature(){ Sol = 3.721177, Temperature = -32.1},
                new MarsTemperature(){ Sol = 3.740788, Temperature = -39.2},
                new MarsTemperature(){ Sol = 3.760399, Temperature = -45.2},
                new MarsTemperature(){ Sol = 3.78001, Temperature = -46.6},
                new MarsTemperature(){ Sol = 3.799622, Temperature = -49.9},
                new MarsTemperature(){ Sol = 3.819233, Temperature = -55.2},
                new MarsTemperature(){ Sol = 3.838844, Temperature = -58.4},
                new MarsTemperature(){ Sol = 3.858456, Temperature = -60.1},
                new MarsTemperature(){ Sol = 3.878068, Temperature = -60.2},
                new MarsTemperature(){ Sol = 3.897678, Temperature = -60.8},
                new MarsTemperature(){ Sol = 3.91729, Temperature = -63.9},
                new MarsTemperature(){ Sol = 3.936901, Temperature = -65.1},
                new MarsTemperature(){ Sol = 3.956512, Temperature = -66.3},
                new MarsTemperature(){ Sol = 3.976124, Temperature = -68.7},
                new MarsTemperature(){ Sol = 3.995735, Temperature = -65.5},
                new MarsTemperature(){ Sol = 4.015346, Temperature = -66},
                new MarsTemperature(){ Sol = 4.034958, Temperature = -67.5},
                new MarsTemperature(){ Sol = 4.054569, Temperature = -67.4},
                new MarsTemperature(){ Sol = 4.07418, Temperature = -69.1},
                new MarsTemperature(){ Sol = 4.093792, Temperature = -71.2},
                new MarsTemperature(){ Sol = 4.113403, Temperature = -71.1},
                new MarsTemperature(){ Sol = 4.133014, Temperature = -72.6},
                new MarsTemperature(){ Sol = 4.152626, Temperature = -72.5},
                new MarsTemperature(){ Sol = 4.172237, Temperature = -73.9},
                new MarsTemperature(){ Sol = 4.21146, Temperature = -73.5},
                new MarsTemperature(){ Sol = 4.231071, Temperature = -74.8},
                new MarsTemperature(){ Sol = 4.250684, Temperature = -71.7},
                new MarsTemperature(){ Sol = 4.270294, Temperature = -64.6},
                new MarsTemperature(){ Sol = 4.289895, Temperature = -61.8},
                new MarsTemperature(){ Sol = 4.309505, Temperature = -52.9},
                new MarsTemperature(){ Sol = 4.370569, Temperature = -43.7},
                new MarsTemperature(){ Sol = 4.387928, Temperature = -39.3},
                new MarsTemperature(){ Sol = 4.427139, Temperature = -33.3},
                new MarsTemperature(){ Sol = 4.446739, Temperature = -32.6},
                new MarsTemperature(){ Sol = 4.46617, Temperature = -30.9},
                new MarsTemperature(){ Sol = 4.52737, Temperature = -23.6},
                new MarsTemperature(){ Sol = 4.544582, Temperature = -20.3},
                new MarsTemperature(){ Sol = 4.564193, Temperature = -16.1},
                new MarsTemperature(){ Sol = 4.583793, Temperature = -14.6},
                new MarsTemperature(){ Sol = 4.603404, Temperature = -15.7},
                new MarsTemperature(){ Sol = 4.623004, Temperature = -15.5},
                new MarsTemperature(){ Sol = 4.642616, Temperature = -15.7},
                new MarsTemperature(){ Sol = 4.662216, Temperature = -20.6},
                new MarsTemperature(){ Sol = 4.681816, Temperature = -21.5},
                new MarsTemperature(){ Sol = 4.701427, Temperature = -26.4},
                new MarsTemperature(){ Sol = 4.721039, Temperature = -31.7},
                new MarsTemperature(){ Sol = 4.74065, Temperature = -39.4},
                new MarsTemperature(){ Sol = 4.760261, Temperature = -45.1},
                new MarsTemperature(){ Sol = 4.782272, Temperature = -49},
                new MarsTemperature(){ Sol = 4.799484, Temperature = -50.2},
                new MarsTemperature(){ Sol = 4.819095, Temperature = -54.5},
                new MarsTemperature(){ Sol = 4.838706, Temperature = -57.9},
                new MarsTemperature(){ Sol = 4.858318, Temperature = -59.2},
                new MarsTemperature(){ Sol = 4.877929, Temperature = -63.4},
                new MarsTemperature(){ Sol = 4.89754, Temperature = -62.9},
                new MarsTemperature(){ Sol = 4.917152, Temperature = -60.9},
                new MarsTemperature(){ Sol = 4.936763, Temperature = -63.6},
                new MarsTemperature(){ Sol = 4.95874, Temperature = -63.2},
                new MarsTemperature(){ Sol = 4.975986, Temperature = -68.8},
                new MarsTemperature(){ Sol = 4.995586, Temperature = -67.5},
            };
        }

        public double Temperature { get; set; }
        public double Sol { get; set; }
    }

    public class AnnotationContentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value != null && value is SeriesPoint)
                return parameter.ToString() + ": " + ((SeriesPoint)value).Value.ToString();
            return string.Empty;
        }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new System.NotImplementedException();
        }
    }
}
