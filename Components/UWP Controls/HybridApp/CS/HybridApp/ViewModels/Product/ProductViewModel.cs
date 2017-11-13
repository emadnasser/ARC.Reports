using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class ProductViewModel : SingleObjectViewModel<Product> {
        async protected override void OnEntityChanged(Product oldValue, Product newValue) {
            await UpdateLookUp();
            base.OnEntityChanged(oldValue, newValue);
            UpdatePdfDocument();
        }
        async Task UpdateLookUp() {
            LookUpEmployees = await DataProvider.Client.GetCollection<Employee>();
        }
        async void UpdatePdfDocument() {
            if (!this.Entity.IsNew)
                PdfDocument = (await DataProvider.Client.GetEntity<ProductCatalog>(Entity.Id)).PDF;
        }
        public byte[] PdfDocument {
            get { return GetProperty(() => PdfDocument); }
            set { SetProperty(() => PdfDocument, value); }
        }
        public ObservableCollection<Employee> LookUpEmployees {
            get { return GetProperty(() => LookUpEmployees); }
            set { SetProperty(() => LookUpEmployees, value); }
        }
    }
}
