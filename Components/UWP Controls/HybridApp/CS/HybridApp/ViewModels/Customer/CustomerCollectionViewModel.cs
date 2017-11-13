using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.UI.Xaml.Grid;
using HybridApp.HybridAppService;
using System;

namespace HybridApp.ViewModels {
    public class CustomerCollectionViewModel : CollectionViewModel<Customer> {
        public CustomerCollectionViewModel() {
        }
        public CustomerDetailsType CustomerDetailsType {
            get { return GetProperty(() => CustomerDetailsType); }
            set { SetProperty(() => CustomerDetailsType, value, async () => await UpdateCustomerDetails()); }
        }
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        async protected override void SelectedEntityChanged(Customer oldValue, Customer newValue) {
            base.SelectedEntityChanged(oldValue, newValue);
            cancellationTokenSource.Cancel();
            cancellationTokenSource = new CancellationTokenSource();
            try {
                await UpdateCustomerDetailsAsync(cancellationTokenSource.Token);
            } catch(TaskCanceledException) { }
        }
        public object CustomerDetails {
            get { return GetProperty(() => CustomerDetails); }
            set { SetProperty(() => CustomerDetails, value); }
        }
        async Task UpdateCustomerDetailsAsync(CancellationToken cancellationToken) {
            if(SelectedEntity != null)
                await Task.Delay(150, cancellationToken);
            await UpdateCustomerDetails(cancellationToken);
        }
        async Task UpdateCustomerDetails(CancellationToken? cancellationToken = null) {
            if(SelectedEntity == null) {
                CustomerDetails = null;
                CustomerEmployeeDetails = null;
                CustomerStoreDetails = null;
                return;
            } else if(CustomerDetailsType == CustomerDetailsType.Contacts) {
                CustomerDetails = (await DataProvider.Client.GetCollection<CustomerEmployee>(cancellationToken)).Where(c => c.CustomerId == SelectedEntity.Id);
            } else if(CustomerDetailsType == CustomerDetailsType.Stores) {
                CustomerDetails = (await DataProvider.Client.GetCollection<CustomerStore>(cancellationToken)).Where(c => c.CustomerId == SelectedEntity.Id);
            }
            CustomerEmployeeDetails = (await DataProvider.Client.GetCollection<CustomerEmployee>(cancellationToken)).Where(c => c.CustomerId == SelectedEntity.Id);
            CustomerStoreDetails = (await DataProvider.Client.GetCollection<CustomerStore>(cancellationToken)).Where(c => c.CustomerId == SelectedEntity.Id);
        }
        public object CustomerEmployeeDetails {
            get { return GetProperty(() => CustomerEmployeeDetails); }
            set { SetProperty(() => CustomerEmployeeDetails, value); }
        }
        public object CustomerStoreDetails {
            get { return GetProperty(() => CustomerStoreDetails); }
            set { SetProperty(() => CustomerStoreDetails, value); }
        }
        void ReloadEntities() {
            SetEntities();
        }
    }
    public enum CustomerDetailsType { Contacts, Stores }
}
