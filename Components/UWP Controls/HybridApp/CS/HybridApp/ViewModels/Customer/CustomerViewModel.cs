using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Core.Native;
using DevExpress.Mvvm;
using DevExpress.UI.Xaml.Map;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class CustomerViewModel : SingleObjectViewModel<Customer>, ISupportBackButton {
        public CustomerViewModel() {
            OptionsCommand = new DelegateCommand<bool>(Options);
        }
        public DelegateCommand<bool> OptionsCommand { get; set; }
        protected override void OnEntityChanged(Customer oldValue, Customer newValue) {
            base.OnEntityChanged(oldValue, newValue);
            OrderCollectionViewModel = new OrderCollectionLookUpViewModel((Customer)newValue);
            RangeControlVisible = OrderCollectionViewModel.OrderFilterTreeViewModel.AverageEntities.Count != 0;
        }
        public OrderCollectionLookUpViewModel OrderCollectionViewModel {
            get { return GetProperty(() => OrderCollectionViewModel); }
            set { SetProperty(() => OrderCollectionViewModel, value); }
        }
        public bool RangeControlVisible {
            get { return GetProperty(() => RangeControlVisible); }
            set { SetProperty(() => RangeControlVisible, value); }
        }
        public bool OptionsPaneVisible {
            get { return GetProperty(() => OptionsPaneVisible); }
            set { SetProperty(() => OptionsPaneVisible, value); }
        }
        public bool Manipulation {
            get { return GetProperty(() => Manipulation); }
            set { SetProperty(() => Manipulation, value); }
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
    public class OrderCollectionLookUpViewModel : CollectionViewModel<Order> {
        Customer customer;
        public OrderCollectionLookUpViewModel(Customer customer)
            : base(new OrderFilterTreeViewModel(customer)) {
            this.customer = customer;
            CenterPoint = new GeoPoint(40, -110);

            OrderFilterTreeViewModel.StartDate = new System.DateTime(2001, 1, 1);
            OrderFilterTreeViewModel.SelectionStartDate = new System.DateTime(2001, 1, 1);
            OrderFilterTreeViewModel.VisibleStartDate = new System.DateTime(2001, 1, 1);
            OrderFilterTreeViewModel.SelectionEndDate = new System.DateTime(2020, 1, 1);
            OrderFilterTreeViewModel.VisibleEndDate = new System.DateTime(2020, 1, 1);
            OrderFilterTreeViewModel.EndDate = new System.DateTime(2020, 1, 1);
            SetEntities();
        }
        async protected override void EntitiesChanged(ObservableCollection<Order> oldValue, ObservableCollection<Order> newValue) {
            base.EntitiesChanged(oldValue, newValue);
            if(Entities.Count() == 0) {
                MinimumSalesValue = MaximumSalesValue = 0;
                GroupedStores = Enumerable.Empty<GroupedStore>();
                return;
            }
            var groupedStores = Entities.GroupBy<Order, CustomerStore>(order => order.Store);
            MinimumSalesValue = groupedStores.Min<IGrouping<CustomerStore, Order>>(orders => orders.Sum(order => order.TotalAmount));
            MaximumSalesValue = groupedStores.Max<IGrouping<CustomerStore, Order>>(orders => orders.Sum(order => order.TotalAmount));
            decimal dif = MaximumSalesValue - MinimumSalesValue;
            ObservableCollection<Quote> quotes = await DataProvider.Client.GetCollection<Quote>();
            GroupedStores = groupedStores.Select(group => new GroupedStore {
                Address = group.Key.Address,
                TotalSales = group.Sum(order => order.TotalAmount),
                TotalOpportunities = GetQuotesTotal(quotes, group.Key, OrderFilterTreeViewModel.SelectionStartDate, OrderFilterTreeViewModel.SelectionEndDate),
                AbsSize = group.Count() > 1 ? (double)((group.Sum(order => order.TotalAmount) - MinimumSalesValue) / dif) : 1
            }).ToList();
            if(GroupedStores != null && GroupedStores != Enumerable.Empty<GroupedStore>())
                CenterPoint = new GeoPoint() { Latitude = GroupedStores.Average(iu => iu.Address.Latitude), Longitude = GroupedStores.Average(iu => iu.Address.Longitude) };
            else
                CenterPoint = new GeoPoint(customer.HomeOffice.Latitude, customer.HomeOffice.Longitude);
            SelectedItem = GroupedStores.LastOrDefault();
        }
        decimal GetQuotesTotal(ObservableCollection<Quote> quotes, CustomerStore customerStore, DateTime begin, DateTime end) {
            return quotes.Where(q => q.CustomerId == customerStore.CustomerId && q.Date >= begin && q.Date <= end).Sum(q => q.Total);
        }
        public OrderFilterTreeViewModel OrderFilterTreeViewModel {
            get { return base.FilterTreeViewModel as OrderFilterTreeViewModel; }
        }
        public virtual GroupedStore SelectedItem {
            get { return GetProperty(() => SelectedItem); }
            set { SetProperty(() => SelectedItem, value); }
        }
        public virtual decimal MinimumSalesValue {
            get { return GetProperty(() => MinimumSalesValue); }
            set { SetProperty(() => MinimumSalesValue, value); }
        }
        public virtual decimal MaximumSalesValue {
            get { return GetProperty(() => MaximumSalesValue); }
            set { SetProperty(() => MaximumSalesValue, value); }
        }
        public GeoPoint CenterPoint {
            get { return GetProperty(() => CenterPoint); }
            set { SetProperty(() => CenterPoint, value); }
        }
        public virtual IEnumerable<GroupedStore> GroupedStores {
            get { return GetProperty(() => GroupedStores); }
            set { SetProperty(() => GroupedStores, value); }
        }
    }
    public class GroupedStore : BindableBase, ISelectableItem {
        public Address Address { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalOpportunities { get; set; }
        public double AbsSize { get; set; }
        public bool IsSelected {
            get { return GetProperty(() => IsSelected); }
            set { SetProperty(() => IsSelected, value); }
        }
    }
}
