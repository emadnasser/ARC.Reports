using DevExpress.Mvvm.POCO;

namespace DevExpress.SalesDemo.Wpf.ViewModel {
    public class SectorsViewModel : PageViewModel {
        public static SectorsViewModel Create() {
            return ViewModelSource.Create(() => new SectorsViewModel());
        }
        protected SectorsViewModel() { }

        public virtual PerformanceBarChartViewModel DailySalesBySectorViewModel { get; protected set; }
        public virtual PerformanceBarChartViewModel UnitSalesBySectorViewModel { get; protected set; }
        public virtual PieBarRangeViewModel PieGaugeRangeViewModel { get; protected set; }
        protected override void Initialize() {
            DailySalesBySectorViewModel = PerformanceBarChartViewModel.Create(ModuleType.Sectors, PerformanceViewMode.Daily); ;
            UnitSalesBySectorViewModel = PerformanceBarChartViewModel.Create(ModuleType.Sectors, PerformanceViewMode.Monthly); ;
            PieGaugeRangeViewModel = PieBarRangeViewModel.Create(ModuleType.Sectors);
        }
    }
}
