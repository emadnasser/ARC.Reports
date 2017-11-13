using System.Windows.Input;
using DevExpress.Mvvm;

namespace HybridApp.ViewModels {
    public class HybridAppViewModelBase : NavigationViewModelBase {
        public HybridAppViewModelBase() {
            LoadedCommand = new DelegateCommand(Loaded);
        }
        protected virtual void Loaded() {}
        public ICommand LoadedCommand { get; private set; }
        protected INavigationService NavigationService { get { return ServiceContainer.GetService<INavigationService>(); } }
        protected IDialogService DialogService { get { return ServiceContainer.GetService<IDialogService>(); } }
        protected IMessageBoxService MessageBoxService { get { return ServiceContainer.GetService<IMessageBoxService>(); } }
    }
}
