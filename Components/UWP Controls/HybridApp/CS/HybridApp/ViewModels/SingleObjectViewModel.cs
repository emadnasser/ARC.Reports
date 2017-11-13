using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using HybridApp.Common;
using HybridApp.DataModel;
using HybridApp.HybridAppService;
using Windows.ApplicationModel.Resources.Core;
using Windows.Phone.UI.Input;
using System.Collections.Generic;

namespace HybridApp.ViewModels {
    public class SingleObjectViewModel<TEntity> : HybridAppViewModelBase where TEntity : DatabaseObject, new() {
        bool canSaveEntity;
        bool entityPropertyChanged;
        public SingleObjectViewModel() {
            SaveCommand = new DelegateCommand(Save, CanSave);
            SaveAndCloseCommand = new DelegateCommand(() => SaveAndCloseCore(false), CanSaveAndClose);
            CancelAndCloseCommand = new DelegateCommand(CancelAndClose);
            Messenger.Default.Register<EntityMessage<TEntity>>(this, OnEntityMessage);
            if(Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                Entity = DesignTimeEntityGenerator.CreateEntity<TEntity>();
            HasValidData = true;
        }
        protected virtual void OnEntityMessage(EntityMessage<TEntity> message) { }
        protected override void Loaded() {
            base.Loaded();
            if(Entity == null)
                Entity = CreateEntity();
            if(ResourceContext.GetForCurrentView().QualifierValues["DeviceFamily"] == "Mobile") {
                HardwareButtons.BackPressed += HardwareBackPressed;
            }
            SubscribePropertyChanged();
            entityPropertyChanged = Entity.IsNew;
            canSaveEntityChange();
        }
        void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            entityPropertyChanged = true;
            canSaveEntityChange();
        }
        void canSaveEntityChange() {
            canSaveEntity = entityPropertyChanged && HasValidData;
            this.SaveAndCloseCommand.RaiseCanExecuteChanged();
            this.SaveCommand.RaiseCanExecuteChanged();
        }
        protected override void OnNavigatedFrom() {
            base.OnNavigatedFrom();
            UnsubscribeEvents();
        }
        void HardwareBackPressed(object sender, BackPressedEventArgs e) {
            UnsubscribeEvents();
        }
        static IEnumerable<Type> GetParentTypes(Type type) {
            if((type == null) || (type.GetTypeInfo().BaseType == null)) {
                yield break;
            }
            yield return type;
            var currentBaseType = type.GetTypeInfo().BaseType;
            while(currentBaseType != null) {
                yield return currentBaseType;
                currentBaseType = currentBaseType.GetTypeInfo().BaseType;
            }
        }
        void SubscribePropertyChanged() {
            Entity.PropertyChanged += Entity_PropertyChanged;
            var types = GetParentTypes(Entity.GetType());
            foreach(var prop in types.Select(x => x.GetTypeInfo()).SelectMany(x => x.DeclaredProperties)) {
                if(TypeExtensions.GetInterfaces(prop.PropertyType).Contains(typeof(INotifyPropertyChanged))) {
                    if(prop.GetValue(Entity) == null) {
                        prop.SetValue(Entity, Activator.CreateInstance(prop.PropertyType));
                    }
                    var propValue = prop.GetValue(Entity) as INotifyPropertyChanged;
                    if(propValue != null)
                        propValue.PropertyChanged += Entity_PropertyChanged;
                }
            }
        }
        void UnsubscribeEvents() {
            if(ResourceContext.GetForCurrentView().QualifierValues["DeviceFamily"] == "Mobile") {
                HardwareButtons.BackPressed -= HardwareBackPressed;
            }
            Entity.PropertyChanged -= Entity_PropertyChanged;
            var types = GetParentTypes(Entity.GetType());
            foreach(var prop in types.Select(x => x.GetTypeInfo()).SelectMany(x => x.DeclaredProperties)) {
                if(TypeExtensions.GetInterfaces(prop.PropertyType).Contains(typeof(INotifyPropertyChanged))) {
                    var propValue = prop.GetValue(Entity) as INotifyPropertyChanged;
                    if(propValue != null)
                        propValue.PropertyChanged -= Entity_PropertyChanged;
                }
            }
        }
        public bool HasValidData {
            get { return GetProperty(() => HasValidData); }
            set { SetProperty(() => HasValidData, value, canSaveEntityChange); }
        }
        protected virtual TEntity CreateEntity() {
            return new TEntity();
        }
        void CancelAndClose() {
            Close();
        }
        internal async void SaveAndCloseCore(bool force) {
            if(await TrySave(force)) {
                CallParentMethod("ReloadEntities");
                Close();
            }
        }
        const string editMessage = "Editing is disabled for this database.";
        protected virtual bool CanSaveAndClose() {
            return CanSave();
        }
        async void Save() { await TrySave(); }
        async protected virtual Task<bool> TrySave(bool force = false) {
            MessageResult confirmationResult = MessageResult.No;
            if(Entity.IsCloned) {
                confirmationResult = await ShowMessage("Do you want to save changes?", "", force);
                if(confirmationResult == MessageResult.Yes)
                    DataProvider.Client.Replace((TEntity)Parameter, Entity);
            } else if(Entity.IsNew) {
                confirmationResult = await ShowMessage("Do you want to save new " + Entity.GetType().Name + "?", "", force);
                if(confirmationResult == MessageResult.Yes) {
                    var entities = await DataProvider.Client.GetCollection<TEntity>();
                    Entity.Id = entities.Max(x => x.Id) + 1;
                    DataProvider.Client.Add(Entity);
                }
            }
            return true;
        }
        async Task<MessageResult> ShowMessage(string text, string caption, bool force) {
            if(force)
                return MessageResult.Yes;
            return await MessageBoxService.ShowAsync(text, caption, MessageButton.YesNo);
        }
        void AddEntity() {
            Messenger.Default.Send(new EntityMessage<TEntity>(Entity, EntityMessageType.Added));
        }
        void SetEntity() {
            CloneProperties(Entity, (TEntity)Parameter);
            Messenger.Default.Send(new EntityMessage<TEntity>(Entity, EntityMessageType.Changed));
        }
        public virtual void Close() {
            NavigationService.GoBack();
        }
        protected virtual bool CanSave() {
            return canSaveEntity;
        }
        public DelegateCommand SaveCommand { get; private set; }
        public DelegateCommand SaveAndCloseCommand { get; private set; }
        public DelegateCommand CancelAndCloseCommand { get; private set; }
        TEntity entity;
        public TEntity Entity {
            get { return entity; }
            set { SetProperty(ref entity, value, OnEntityChanged); }
        }
        protected virtual void OnEntityChanged(TEntity oldValue, TEntity newValue) {
        }
        protected override void OnParameterChanged(object parameter) {
            base.OnParameterChanged(parameter);
            TEntity entity = (TEntity)Parameter;
            Entity = entity != null ? Clone(entity) : null;
        }
        TEntity Clone(TEntity from) {
            TEntity to = new TEntity();
            CloneProperties(from, to);
            to.IsCloned = true;
            return to;
        }
        void CloneProperties(TEntity from, TEntity to) {
            foreach(var propertyInfo in typeof(TEntity).GetProperties().Where(pi => pi.Name != "IsCloned" && pi.CanWrite && pi.CanRead)) {
                propertyInfo.SetValue(to, propertyInfo.GetValue(from));
            }
        }
        bool CallParentMethod(string methodName) {
            object viewModel = ((this as ISupportParentViewModel).ParentViewModel);
            Type type = viewModel.GetType();
            TypeInfo typeInfo = type.GetTypeInfo();
            MethodInfo method = typeInfo.GetDeclaredMethod(methodName);
            if(method == null)
                return false;
            method.Invoke(viewModel, null);
            return true;
        }
    }
}
