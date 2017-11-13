using DevExpress.Mvvm;
using FeatureDemo.Common;
using System;
using System.Threading;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
namespace EditorsDemo {
    public class NumericMaskViewModel : ViewModelBase {
        DispatcherTimer timer;
        public NumericMaskViewModel() {
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 2, 0) };
            NegativeAlternativeValue = 399.9;
        }

        private void OnTimerTick(object sender, object e) {
            NegativeAlternativeValue = -NegativeAlternativeValue;
        }

        public double NegativeAlternativeValue {
            get { return GetProperty(() => NegativeAlternativeValue); }
            set { SetProperty(() => NegativeAlternativeValue, value); }
        }
        public void Stop() {
            timer.Stop();
            timer.Tick -= OnTimerTick;
        }
        public void Start() {
            timer.Tick += OnTimerTick;
            timer.Start();
        }
    }
    public sealed partial class NumericMaskModule : UserControl {
        public NumericMaskModule() {
            DataContext = new NumericMaskViewModel();
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
            this.InitializeComponent();
        }

        private void OnLoaded(object sender, RoutedEventArgs e) {
            (DataContext as NumericMaskViewModel)?.Start();
        }

        private void OnUnloaded(object sender, RoutedEventArgs e) {
            (DataContext as NumericMaskViewModel)?.Stop();
        }
    }
}
