using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using HybridApp.HybridAppService;
using HybridApp.ViewModels;
using Windows.UI;

namespace HybridApp {
    public class DevAVDbViewModel : CollectionViewModel<ModuleViewModelBase> {
        bool waitIndicatorEnabled;
        public DevAVDbViewModel() {
            waitIndicatorEnabled = true;
        }
        protected override async Task<ObservableCollection<ModuleViewModelBase>> GetEntities() {
            await Task.Yield();
            return new ObservableCollection<ModuleViewModelBase>() {
                new ModuleViewModel<Order>(this, "Dashboard", "DashboardView", this, "Dashboard", Color.FromArgb(0xFF, 0x00, 0x87, 0x9C), groupHeader:"MY WORLD"),
                new ModuleViewModel<EmployeeTask>(this, "Tasks", "TaskCollectionView", this, "Tasks", Color.FromArgb(0xFF, 0x40, 0x40, 0x40), new TaskFilterTreeViewModel(), "MY WORLD"),
                new ModuleViewModel<Employee>(this, "Employees", "EmployeeCollectionView", this, "Employees", Color.FromArgb(0xFF, 0xCC, 0x6D, 0x00), new EmployeeFilterTreeViewModel(), "OPERATIONS"),
                new ModuleViewModel<Product>(this, "Products", "ProductCollectionView", this, "Products", Color.FromArgb(0xFF, 0x00, 0x73, 0xC4), new ProductFilterTreeViewModel(), "OPERATIONS"),
                new ModuleViewModel<Customer>(this, "Customers", "CustomerCollectionView", this, "Customers", Color.FromArgb(0xFF, 0x40, 0x40, 0x40), new CustomerFilterTreeViewModel(), "OPERATIONS"),
                new ModuleViewModel<Order>(this, "Sales", "OrderCollectionView", this, "Sales", Color.FromArgb(0xFF, 0x3E, 0x70, 0x38), new OrderFilterTreeViewModel(), "OPERATIONS"),
                new ModuleViewModel<Quote>(this, "Opportunities", "QuoteCollectionView", this, "Opportunities", Color.FromArgb(0xFF, 0x40, 0x40, 0x40), new QuoteFilterTreeViewModel(), "OPERATIONS"),
            };
        }
        public override bool InitializeEntitiesOnlyByFiltering { get { return false; } }
        protected override void EntitiesChanged(ObservableCollection<ModuleViewModelBase> oldValue, ObservableCollection<ModuleViewModelBase> newValue) {
            base.EntitiesChanged(oldValue, newValue);
            GroupedEntities = Entities.GroupBy(x => x.GroupHeader).ToList();
        }
        public List<IGrouping<string, ModuleViewModelBase>> GroupedEntities {
            get { return GetProperty(() => GroupedEntities); }
            set { SetProperty(() => GroupedEntities, value); }
        }
        protected override void Loaded() {
            base.Loaded();
            SelectedEntity = Entities.Single(m => m.Title == "Employees");
        }
        protected override void SelectedEntityChanged(ModuleViewModelBase oldValue, ModuleViewModelBase newValue) {
            base.SelectedEntityChanged(oldValue, newValue);
            if(!waitIndicatorEnabled) {
                waitIndicatorEnabled = true;
                return;
            }
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => NavigateCore(oldValue, newValue));
            else
                NavigateCore(oldValue, newValue);
        }
        void NavigateCore(ModuleViewModelBase oldValue, ModuleViewModelBase newValue) {
            if(newValue != null && NavigationService != null) {
                NavigationService.Navigate(newValue.DocumentType, newValue.FilterTreeViewModel, this);
            }
        }
        public Type SourcePageType {
            get { return GetProperty(() => SourcePageType); }
            set { SetProperty(() => SourcePageType, value, SourcePageTypeChanged); }
        }
        void SourcePageTypeChanged() {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(false);
            var entity = Entities.FirstOrDefault(x => x.DocumentType == SourcePageType.Name);
            if(entity != null && SelectedEntity != entity) {
                waitIndicatorEnabled = false;
                SelectedEntity = entity;
            }
        }
        public bool HamburgerMenuVisible {
            get { return GetProperty(() => HamburgerMenuVisible); }
            set { SetProperty(() => HamburgerMenuVisible, value); }
        }
    }
    public class ModuleViewModelBase {
        DevAVDbViewModel owner;
        public ModuleViewModelBase() { }
        public ModuleViewModelBase(DevAVDbViewModel owner, string title, string documentType, object parentViewModel, string icon, Color color, string groupHeader = null) {
            this.owner = owner;
            Title = title;
            DocumentType = documentType;
            ParentViewModel = parentViewModel;
            Icon = new Uri(string.Format("ms-appx:/Resources/Menu/{0}.png", icon));
            Color = color;
            GroupHeader = groupHeader;
            OnSelectedCommand = new DelegateCommand(OnSelect);
        }
        void OnSelect() {
            owner.SelectedEntity = this;
        }
        public DelegateCommand OnSelectedCommand { get; set; }
        public Uri Icon { get; set; }
        public string Title { get; private set; }
        public string DocumentType { get; private set; }
        public object ParentViewModel { get; private set; }
        public Color Color { get; set; }
        public string GroupHeader { get; set; }
        public object FilterTreeViewModel { get; set; }
    }
    public class ModuleViewModel<TEntity> : ModuleViewModelBase {
        public ModuleViewModel() { }
        public ModuleViewModel(DevAVDbViewModel owner, string title, string documentType, object parentViewModel, string icon, Color color, FilterTreeViewModel<TEntity> filterTreeViewModel = null, string groupHeader = null) :
            base(owner, title, documentType, parentViewModel, icon, color, groupHeader) {
            FilterTreeViewModel = filterTreeViewModel ?? new EmptyFilterTreeViewModel<TEntity>();
        }
    }
}
