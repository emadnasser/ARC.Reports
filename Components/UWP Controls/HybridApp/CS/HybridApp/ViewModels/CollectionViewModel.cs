using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using HybridApp.Common;
using HybridApp.DataModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace HybridApp.ViewModels {
    public abstract class CollectionViewModel<TEntity> : HybridAppViewModelBase where TEntity : class, new() {
        protected IWaitIndicatorService WaitIndicatorService { get { return ServiceContainer.GetService<IWaitIndicatorService>(); } }
        public CollectionViewModel(FilterTreeViewModel<TEntity> filterTreeViewModel = null) {
            FilterTreeViewModel = filterTreeViewModel;
            FilterTreeViewModel.Do(x => x.SelectedItemChanged += (s, e) => SetEntities());
            EditCommand = new DelegateCommand<TEntity>(Edit, CanEdit);
            NewCommand = new DelegateCommand(New, CanNew);
            DeleteCommand = new DelegateCommand<TEntity>(Delete);
            Messenger.Default.Register<EntityMessage<TEntity>>(this, OnEntityMessage);
            if(!InitializeEntitiesOnlyByFiltering)
                SetEntities();
        }
        public virtual bool InitializeEntitiesOnlyByFiltering { get { return true; } }
        public FilterTreeViewModel<TEntity> FilterTreeViewModel {
            get { return GetProperty(() => FilterTreeViewModel); }
            set { SetProperty(() => FilterTreeViewModel, value, SetEntities); }
        }
        protected virtual void OnEntityMessage(EntityMessage<TEntity> message) { }
        public ICommand EditCommand { get; private set; }
        public ICommand NewCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        protected async void SetEntities() {
            var entities = await GetEntities();
            FilterTreeViewModel.Do(x => entities = x.FilterCollection(entities).AsObservableCollection());
            TEntity selectedEntity = SelectedEntity;
            SelectedEntity = null;
            if(selectedEntity == null)
                selectedEntity = entities.With(x => x.FirstOrDefault());
            else if(!entities.Contains(selectedEntity)) {
                selectedEntity = entities.With(x => x.FirstOrDefault());
            } else {
                int index = Entities.IndexOf(selectedEntity);
                Entities = entities;
                SelectedEntity = Entities[index];

                return;
            }
            Entities = entities;
            SelectedEntity = selectedEntity;
        }
        protected virtual async Task<ObservableCollection<TEntity>> GetEntities() {
            if(!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return await DataProvider.Client.GetCollection<TEntity>();
            else
                return DesignTimeEntityGenerator.CreateCollection<TEntity>();
        }
        public void New() {
            Edit(null);
        }
        protected virtual bool CanNew() {
            return true;
        }
        public void EditEntity(object sender, RoutedEventArgs e) {
            TEntity entity = (e?.OriginalSource as FrameworkElement)?.DataContext as TEntity;
            if(entity == null)
                entity = (sender as ButtonBase)?.CommandParameter as TEntity;
            Edit(entity);
        }
        protected virtual void Edit(TEntity entity) {
            if(WaitIndicatorService != null)
                WaitIndicatorService.Activate(true, () => EditCore(entity));
            else
                EditCore(entity);
        }
        void EditCore(TEntity entity) {
            NavigationService.Navigate(typeof(TEntity).Name + "View", entity, this);
        }
        protected virtual bool CanEdit(TEntity entity) {
            return entity != null;
        }
        const string editMessage = "Editing is disabled for this database.";
        async protected virtual void Delete(TEntity entity) {
            MessageResult confirmationResult = MessageResult.No;
            string df = entity.GetType().Name;
            await MessageBoxService.ShowAsync("Do you want to delete " + entity.GetType().Name + "?", " ", MessageButton.YesNo).ContinueWith((x) => { confirmationResult = x.Result; });
            if(confirmationResult == MessageResult.Yes) {
                Entities.Remove(entity);
                DataProvider.Client.Delete(entity);
                SetEntities();
            }
        }
        protected virtual bool CanDelete(TEntity entity) {
            return entity != null;
        }
        ObservableCollection<TEntity> entities;
        public ObservableCollection<TEntity> Entities {
            get { return entities; }
            set { SetProperty(ref entities, value, EntitiesChanged); }
        }
        TEntity selectedEntity;
        public TEntity SelectedEntity {
            get { return selectedEntity; }
            set { SetProperty(ref selectedEntity, value, SelectedEntityChanged); }
        }
        protected virtual void EntitiesChanged(ObservableCollection<TEntity> oldValue, ObservableCollection<TEntity> newValue) { }
        protected virtual void SelectedEntityChanged(TEntity oldValue, TEntity newValue) { }
        protected override void OnParameterChanged(object parameter) {
            base.OnParameterChanged(parameter);
            if(parameter is FilterTreeViewModel<TEntity>) {
                FilterTreeViewModel = parameter as FilterTreeViewModel<TEntity>;
                FilterTreeViewModel.SelectedItemChanged += (s, e) => SetEntities();
            }
        }
    }
}
