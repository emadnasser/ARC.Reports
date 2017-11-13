using System.Collections.Generic;
using DevExpress.Mvvm;
using HybridApp.DataModel;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class OrderCollectionViewModel : CollectionViewModel<Order>, ISupportBackButton {
        public OrderCollectionViewModel() {
            OptionsCommand = new DelegateCommand<bool>(Options);
        }
        public DelegateCommand<bool> OptionsCommand { get; set; }
        protected override void EntitiesChanged(System.Collections.ObjectModel.ObservableCollection<Order> oldValue, System.Collections.ObjectModel.ObservableCollection<Order> newValue) {
            base.EntitiesChanged(oldValue, newValue);
            Sales = DataProvider.Client.GetSalesStatistics();
            SelectedSale = Sales[0];
        }
        public virtual Order ReadyForViewEntity {
            get { return GetProperty(() => ReadyForViewEntity); }
            set { SetProperty(() => ReadyForViewEntity, value); }
        }
        public SalesInfo SelectedSale {
            get { return GetProperty(() => SelectedSale); }
            set { SetProperty(() => SelectedSale, value); }
        }
        public List<SalesInfo> Sales {
            get { return GetProperty(() => Sales); }
            set { SetProperty(() => Sales, value); }
        }
        public bool OptionsPaneVisible {
            get { return GetProperty(() => OptionsPaneVisible); }
            set { SetProperty(() => OptionsPaneVisible, value); }
        }
        protected override void OnParameterChanged(object parameter) {
            base.OnParameterChanged(parameter);
            if(parameter is RangeFilterTreeViewModelBase<Order>) {
                var filterTreeViewModel = parameter as RangeFilterTreeViewModelBase<Order>;
                filterTreeViewModel.SelectionStartDate = new System.DateTime(2001, 1, 1);
                filterTreeViewModel.VisibleStartDate = new System.DateTime(2001, 1, 1);
                filterTreeViewModel.SelectionEndDate = new System.DateTime(2020, 1, 1);
                filterTreeViewModel.VisibleEndDate = new System.DateTime(2020, 1, 1);
                SetEntities();
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
}
