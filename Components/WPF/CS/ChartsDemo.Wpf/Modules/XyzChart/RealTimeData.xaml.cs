using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;

namespace ChartsDemo {
    [CodeFile("Modules/XyzChart/RealTimeData(.SL).xaml"),
    CodeFile("Modules/XyzChart/RealTimeData.xaml.(cs)")]
    public partial class RealTimeData : ChartsDemoModule {
        readonly RealTimeSurfaceViewModel model;
        bool lastEnabledState;

        public override ChartControlBase ActualChart { get { return chart; } }

        public RealTimeData() {
            InitializeComponent();
            this.model = new RealTimeSurfaceViewModel((int)slDimension.Value + 1);
            DataContext = this.model;
        }

        void DemoModuleLoaded(object sender, RoutedEventArgs e) {
            this.model.IsEnabled = true;
        }
        void DemoModuleUnloaded(object sender, RoutedEventArgs e) {
            this.model.IsEnabled = false;
        }
        void ButtonPauseClick(object sender, RoutedEventArgs e) {
            this.model.IsEnabled = !this.model.IsEnabled;
            btnPause.Content = this.model.IsEnabled ? "Pause" : "Resume";
        }
        void DataSizeChanged(object sender, EditValueChangedEventArgs e) {
            int size = Convert.ToInt32(e.NewValue);
            this.model.Size = size + 1;
            this.model.IsEnabled = lastEnabledState;
        }
        private void DataSizeChanging(object sender, EditValueChangingEventArgs e) {
            this.lastEnabledState = this.model.IsEnabled;
            this.model.IsEnabled = false;
        }
    }

    public class RealTimeSurfaceViewModel : INotifyPropertyChanged {
        const double ValueFactor = 0.5;
        const int Interval = 40;

        readonly DataGenerator dataGenerator;
        readonly DispatcherTimer timer;
        IEnumerable<object> argumentsX;
        IEnumerable<object> argumentsY;
        IEnumerable<double> values;
        FillStyleBase fillStyle;
        PropertyChangedEventHandler onPropertyChanged;

        public IEnumerable<object> ArgumentsX {
            get { return argumentsX; }
            set {
                argumentsX = value;
                NotifyPropertyChanged("ArgumentsX");
            }
        }
        public IEnumerable<object> ArgumentsY {
            get { return argumentsY; }
            set {
                argumentsY = value;
                NotifyPropertyChanged("ArgumentsY");
            }
        }
        public IEnumerable<double> Values {
            get { return values; }
            set {
                values = value;
                NotifyPropertyChanged("Values");
            }
        }
        public FillStyleBase FillStyle {
            get { return fillStyle; }
            set {
                fillStyle = value;
                NotifyPropertyChanged("FillStyle");
            }
        }
        public int Size {
            get { return dataGenerator.Size; }
            set {
                dataGenerator.Size = value;
                NotifyPropertyChanged("MinValue");
                NotifyPropertyChanged("MaxValue");
                UpdateDataSource();
                UpdateValues();
            }
        }
        public bool IsEnabled {
            get { return timer.IsEnabled; }
            set { timer.IsEnabled = value; }
        }
        public double MinValue { get { return -Size / 3 - 1.5; } }
        public double MaxValue { get { return Size / 3 + 1.5; } }

        public event PropertyChangedEventHandler PropertyChanged {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        public RealTimeSurfaceViewModel(int initialSize) {
            this.dataGenerator = new DataGenerator();
            this.timer = CreateTimer();
            Size = initialSize;
        }

        DispatcherTimer CreateTimer() {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(Interval);
            timer.Tick += timerTick;
            return timer;
        }
        void timerTick(object sender, EventArgs e) {
            UpdateValues();
        }
        void NotifyPropertyChanged(string propertyName) {
            if (this.onPropertyChanged != null)
                this.onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        FillStyleBase CreateGradientFillStyle() {
            GradientFillStyle style = new GradientFillStyle();
            style.ColorStops.Add(new ColorStop() { Offset = new Unit(MaxValue) });
            style.ColorStops.Add(new ColorStop() { Offset = new Unit(0) });
            style.ColorStops.Add(new ColorStop() { Offset = new Unit(MinValue) });
            return style;
        }
        void UpdateDataSource() {
            IEnumerable<object> arguments = dataGenerator.GenerateArguments();
            ArgumentsX = arguments;
            ArgumentsY = arguments;
            dataGenerator.RecreateElevations();
            FillStyle = CreateGradientFillStyle();
        }
        void UpdateValues() {
            Values = dataGenerator.GenerateValues();
        }
    }
}
