using DevExpress.Mvvm.POCO;
using DevExpress.SalesDemo.Model;
using System;

namespace DevExpress.SalesDemo.Wpf.ViewModel {
    public class PieBarRangeViewModel : DataViewModel {
        public static PieBarRangeViewModel Create(ModuleType moduleType) {
            return ViewModelSource.Create(() => new PieBarRangeViewModel(moduleType));
        }
        protected ModuleType ModuleType { get; private set; }
        protected PieBarRangeViewModel()
            : this(ModuleType.Regions) {
        }
        protected PieBarRangeViewModel(ModuleType moduleType) {
            ModuleType = moduleType;

            BarViewModel = BarViewModel.Create();
            PieViewModel = PieViewModel.Create();
            RangeViewModel = RangeViewModel.Create();
            RangeViewModel.RangeChanged += OnRangeViewModelRangeChanged;
            RangeViewModel.SelectedRangeChanged += OnRangeViewModelSelectedRangeChanged;

            RequestDataForRange();
            RequestDataForPieAndBar();
        }
        public virtual RangeViewModel RangeViewModel { get; protected set; }
        public virtual BarViewModel BarViewModel { get; protected set; }
        public virtual PieViewModel PieViewModel { get; protected set; }

        void OnRangeViewModelRangeChanged(object sender, EventArgs e) {
            RequestDataForRange();
        }
        void OnRangeViewModelSelectedRangeChanged(object sender, EventArgs e) {
            RequestDataForPieAndBar();
        }
        void RequestDataForRange() {
            if(RangeViewModel.RangeStart == null || RangeViewModel.RangeEnd == null || RangeViewModel.RangeStart >= RangeViewModel.RangeEnd)
                return;
            RequestData("RangeViewModel", x => x.GetSales(RangeViewModel.RangeStart.Value, RangeViewModel.RangeEnd.Value.AddDays(1), GroupingPeriod.Day), x => RangeViewModel.LoadData(x));
        }
        void RequestDataForPieAndBar() {
            var range = RangeViewModel.GetSelectedRange();
            if(range == null) return;
            RequestData("Data", x => {
                if(ModuleType == ModuleType.Regions)
                    return x.GetSalesByRegion(range.Value, GroupingPeriod.All);
                else if(ModuleType == ModuleType.Sectors)
                    return x.GetSalesBySector(range.Value, GroupingPeriod.All);
                else if(ModuleType == ModuleType.Products)
                    return x.GetSalesByProduct(range.Value, GroupingPeriod.All);
                else if(ModuleType == ModuleType.Channels)
                    return x.GetSalesByChannel(range.Value, GroupingPeriod.All);
                throw new NotImplementedException();
            }, x => {
                BarViewModel.LoadData(x);
                PieViewModel.LoadData(x);
            });
        }
    }
}
