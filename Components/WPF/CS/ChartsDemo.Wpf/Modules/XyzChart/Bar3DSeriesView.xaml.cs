using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media.Media3D;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/XyzChart/Bar3DSeriesView(.SL).xaml"),
    CodeFile("Modules/XyzChart/Bar3DSeriesView.xaml.(cs)")]
    public partial class Bar3DSeriesView : ChartsDemoModule {
        readonly Bar3DViewModel viewModel;

        public override ChartControlBase ActualChart { get { return chart; } }

        public Bar3DSeriesView() {
            InitializeComponent();
            this.viewModel = new Bar3DViewModel(300);
            DataContext = viewModel;
        }

        void ButtonGenerateClick(object sender, System.Windows.RoutedEventArgs e) {
            viewModel.GenerateData();
        }
    }

    public class Bar3DViewModel : INotifyPropertyChanged {
        readonly int pointsCount;
        ObservableCollection<Point3D> source;
        public ObservableCollection<Point3D> Source { get { return source; } set { source = value; NotifyPropertyChanged("Source"); } }

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

        public Bar3DViewModel(int pointsCount) {
            this.pointsCount = pointsCount;
            GenerateData();
        }

        public void GenerateData() {
            Source = DataPointHelper.GenerateRandomData(pointsCount);
        }
    }
}
