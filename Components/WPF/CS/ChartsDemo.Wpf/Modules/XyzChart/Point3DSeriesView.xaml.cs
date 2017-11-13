using System;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;

namespace ChartsDemo {
    [CodeFile("Modules/XyzChart/Point3DSeriesView(.SL).xaml"),
    CodeFile("Modules/XyzChart/Point3DSeriesView.xaml.(cs)")]
    public partial class Point3DSeriesView : ChartsDemoModule {
        public override ChartControlBase ActualChart { get { return chart; } }

        public ObservableCollection<StarData> Source { get; set; }

        public Point3DSeriesView() {
            InitializeComponent();
            Source = Chart3DUtils.ReadStarsData();
            DataContext = this;
        }
        public override bool SupportSidebarContent() {
            return false;
        }
    }
    public struct StarData {
        public int HipID { get; set; }
        public string Spectr { get; set; }
        public double Lum { get; set; }
        public double CI { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
