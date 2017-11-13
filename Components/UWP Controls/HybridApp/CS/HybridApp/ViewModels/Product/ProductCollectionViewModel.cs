using DevExpress.Data;
using DevExpress.Mvvm;
using DevExpress.UI.Xaml.Grid;
using HybridApp.HybridAppService;

namespace HybridApp.ViewModels {
    public class ProductCollectionViewModel : CollectionViewModel<Product> {
        public ProductCollectionViewModel() {
        }
        void ReloadEntities() {
            SetEntities();
        }
    }
}
