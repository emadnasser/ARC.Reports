using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Core.Native;
using DevExpress.Mvvm;
using HybridApp.DataModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class QuoteCollectionViewModel : CollectionViewModel<Quote>, ISupportBackButton {
        public QuoteCollectionViewModel() {
            OptionsCommand = new DelegateCommand<bool>(Options);
        }
        public DelegateCommand<bool> OptionsCommand { get; set; }
        protected override void EntitiesChanged(ObservableCollection<Quote> oldValue, ObservableCollection<Quote> newValue) {
            base.EntitiesChanged(oldValue, newValue);
            UpdateSummaryOpportunities();
            UpdateMapItems();
        }
        protected override void OnParameterChanged(object parameter) {
            base.OnParameterChanged(parameter);
            if(parameter is RangeFilterTreeViewModelBase<Quote>) {
                var filterTreeViewModel = parameter as RangeFilterTreeViewModelBase<Quote>;
                filterTreeViewModel.SelectionStartDate = new System.DateTime(2001, 1, 1);
                filterTreeViewModel.VisibleStartDate = new System.DateTime(2001, 1, 1);
                filterTreeViewModel.SelectionEndDate = new System.DateTime(2020, 1, 1);
                filterTreeViewModel.VisibleEndDate = new System.DateTime(2020, 1, 1);
                SetEntities();
                UpdateMapItems();
            }
        }

        async void UpdateMapItems() {
            var customers = await DataProvider.Client.GetCollection<Customer>();
            var items = Opportunities.GetOpportunities(Entities, customers, Opportunities.Stage.Summary)
                .GroupBy(item => item.Address, new AddressComparer());
            if(items.Count() > 0) {
                decimal minValue = items.Min(group => group.Sum(quote => quote.Value));
                decimal maxValue = items.Max(group => group.Sum(quote => quote.Value));
                decimal dif = (maxValue - minValue > (decimal)0.01) ? (maxValue - minValue) : 1;
                GrouppedMapItems = items.Select(group => new SelectableMapItem {
                    Address = group.Key,
                    Total = group.Sum(item => item.Value),
                    AbsSize = (double)((group.Sum(item => item.Value) - minValue) / dif),
                }).ToList();

            } else {
                GrouppedMapItems = Enumerable.Empty<object>();
            }
            SelectedMapItem = GrouppedMapItems.LastOrDefault();
        }
        public IEnumerable<SummaryItem> SummaryOpportunities {
            get { return GetProperty(() => SummaryOpportunities); }
            set { SetProperty(() => SummaryOpportunities , value); }
        }
        public IEnumerable<object> GrouppedMapItems {
            get { return GetProperty(() => GrouppedMapItems); }
            set { SetProperty(() => GrouppedMapItems, value); }
        }
        public object SelectedMapItem {
            get { return GetProperty(() => SelectedMapItem); }
            set { SetProperty(() => SelectedMapItem, value); }
        }
        public bool OptionsPaneVisible {
            get { return GetProperty(() => OptionsPaneVisible); }
            set { SetProperty(() => OptionsPaneVisible, value); }
        }
        public bool Manipulation {
            get { return GetProperty(() => Manipulation); }
            set { SetProperty(() => Manipulation, value); }
        }
        void UpdateSummaryOpportunities() {
            SummaryOpportunities = GetSummaryOpportunities(Entities);
        }
        public static IEnumerable<SummaryItem> GetSummaryOpportunities(ObservableCollection<Quote> quotes) {
            if(quotes == null)
                return new SummaryItem[] { new SummaryItem { Summary = 0, StageName = "" } };
            var res = new List<SummaryItem>();
            res.Add(GetSummaryItem(quotes, Stage.High));
            res.Add(GetSummaryItem(quotes, Stage.Medium));
            res.Add(GetSummaryItem(quotes, Stage.Low));
            res.Add(GetSummaryItem(quotes, Stage.Unlikely));
            return res;
        }
        public static SummaryItem GetSummaryItem(ObservableCollection<Quote> quotes, Stage stage) {
            return new SummaryItem {
                StageName = stage.ToString(),
                Summary = GetQuotes(quotes, stage).Sum(q => q.Total)
            };
        }
        static IEnumerable<Quote> GetQuotes(ObservableCollection<Quote> quotes, Stage stage) {
            double min, max;
            GetRange(stage, out min, out max);
            return quotes.Where(q => q.Opportunity > min && q.Opportunity < max);
        }
        static void GetRange(Stage stage, out double min, out double max) {
            switch(stage) {
                case Stage.High:
                    max = 1.0;
                    min = 0.6;
                    break;
                case Stage.Medium:
                    min = 0.3;
                    max = 0.6;
                    break;
                case Stage.Low:
                    min = 0.12;
                    max = 0.3;
                    break;
                case Stage.Summary:
                    min = 0.0;
                    max = 1.0;
                    break;
                default:
                    min = 0.0;
                    max = 0.12;
                    break;
            }
        }
        public void Options(bool parameter) {
            OptionsPaneVisible = parameter;
        }
        #region ISupportBackButton
        public void BackButtonPressed(ref bool handled) {
            if(OptionsPaneVisible) {
                handled = true;
                OptionsPaneVisible = false;
            }
        }
        #endregion
    }
    public enum Stage {
        High,
        Medium,
        Low,
        Unlikely,
        Summary
    }
    class AddressComparer : IEqualityComparer<Address> {
        public bool Equals(Address x, Address y) {
            return x.State.Equals(y.State) && x.City.Equals(y.City);
        }
        public int GetHashCode(Address obj) {
            return obj.State.GetHashCode() ^ obj.City.GetHashCode();
        }
    }
    public class SelectableMapItem : BindableBase, ISelectableItem {
        public Address Address { get; set; }
        public decimal Total { get; set; }
        public double AbsSize { get; set; }
        public bool IsSelected {
            get { return GetProperty(() => IsSelected); }
            set { SetProperty(() => IsSelected, value); }
        }
    }
}
