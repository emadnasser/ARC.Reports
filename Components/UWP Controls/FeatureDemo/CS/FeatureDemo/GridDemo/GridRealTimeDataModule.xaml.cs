using FeatureDemo.Data;
using DevExpress.Data;
using DevExpress.UI.Xaml.Grid;
using DevExpress.Core.Localization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Path = Windows.UI.Xaml.Shapes.Path;

namespace GridDemo {
    public sealed partial class GridRealTimeDataModule : GridDemoUserControl {        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("Model", typeof(StockDataViewModel), typeof(GridRealTimeDataModule), new PropertyMetadata(null));


        static GridRealTimeDataModule() {

            Localizer.AddString(GridStringID.DefaultFixedTotalSummaryFormatString_Count, "COUNT");
            Localizer.AddString(GridStringID.DefaultFixedTotalSummaryFormatString_Max, "MAX OF {0}");
        }
        #region dep props
        public StockDataViewModel Model {
            get { return (StockDataViewModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }
        #endregion
        public GridRealTimeDataModule() {
            this.InitializeComponent();
            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }
        void OnLoaded(object sender, RoutedEventArgs e) {
            Model = new StockDataViewModel(grid);
            Model.Resume();
            Application.Current.DebugSettings.EnableFrameRateCounter = false;
            grid.CustomSummary += grid_CustomSummary;
        }
        void OnUnloaded(object sender, RoutedEventArgs e) {
            grid.CustomSummary -= grid_CustomSummary;
            Model.Unload();
            Model = null;
        }

        protected internal override GridControl Grid { get { return grid; } }
        public override void OnNavigatingFrom() {
            base.OnNavigatingFrom();
        }
        public override void OnNavigatedTo() {
            base.OnNavigatedTo();
        }

        void grid_CustomSummary(object sender, CustomSummaryEventArgs e) {
            if(e.SummaryProcess != CustomSummaryProcess.Finalize || Model == null)
                return;
            e.TotalValue = new RealLiveDataCustomSummary() { Negative = Model.NegativePriceHistoryList.ToList(), Positive = Model.PositivePriceCountList.ToList() };
        }
    }

    public class RealLiveDataCustomSummary {
        public List<double> Positive { get; set; }
        public List<double> Negative { get; set; }
    }

}
