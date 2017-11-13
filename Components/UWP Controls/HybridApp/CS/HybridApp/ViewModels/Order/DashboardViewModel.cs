using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using HybridApp.DataModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class DashboardViewModel : CollectionViewModel<Order> {
        protected override void Loaded() {
            base.Loaded();
            DashboardInitialization();
        }
        public IList<SummaryItem> SummaryOpportunities {
            get { return GetProperty(() => SummaryOpportunities); }
            set { SetProperty(() => SummaryOpportunities, value); }
        }
        public IList<SalesSummaryItem> SalesSummarySelectedItem {
            get { return GetProperty(() => SalesSummarySelectedItem); }
            set { SetProperty(() => SalesSummarySelectedItem, value); }
        }
        public IList<CostAverageItem> CostSelectedItem {
            get { return GetProperty(() => CostSelectedItem); }
            set { SetProperty(() => CostSelectedItem, value); }
        }
        public ObservableCollection<bool> GoodSoldPeriodSelector {
            get { return GetProperty(() => GoodSoldPeriodSelector); }
            set { SetProperty(() => GoodSoldPeriodSelector, value); }
        }
        public ObservableCollection<bool> RevenuePeriodSelector {
            get { return GetProperty(() => RevenuePeriodSelector); }
            set { SetProperty(() => RevenuePeriodSelector, value); }
        }

        List<IEnumerable<SalesSummaryItem>> salesSummaryItems;
        List<IEnumerable<CostAverageItem>> costAverageItems;

        void GoodSoldSelectorChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if((bool)e.NewItems[0])
                CostSelectedItem = costAverageItems[e.NewStartingIndex].ToList();
        }
        void RevenuesSelectorChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if((bool)e.NewItems[0])
                SalesSummarySelectedItem = salesSummaryItems[e.NewStartingIndex].ToList();
        }
        void DashboardInitialization() {
            salesSummaryItems = DataProvider.Client.GetSalesSummaryItems();
            costAverageItems = DataProvider.Client.GetCostAverageItems();
            SummaryOpportunities = DataProvider.Client.GetSummaryOpportunitites();
            GoodSoldPeriodSelector = new ObservableCollection<bool>() { true, false, false };
            RevenuePeriodSelector = new ObservableCollection<bool>() { true, false, false };
            GoodSoldPeriodSelector.CollectionChanged += GoodSoldSelectorChanged;
            RevenuePeriodSelector.CollectionChanged += RevenuesSelectorChanged;

            SalesSummarySelectedItem = salesSummaryItems[0].ToList();
            CostSelectedItem = costAverageItems[0].ToList();
        }
    }

}
