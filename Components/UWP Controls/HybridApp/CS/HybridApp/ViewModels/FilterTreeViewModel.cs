using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using HybridApp.HybridAppService;
using TypeExtensions = DevExpress.Mvvm.Native.TypeExtensions;

namespace HybridApp.ViewModels {
    public abstract class FilterTreeViewModel<T> : BindableBase {
        public FilterTreeViewModel() {
            SortCommand = new DelegateCommand<string>(Sort);
            AdditionActiveFilters = new SelectableCollection<FilterInfo<T>>();
        }
        void Sort(string filterName) {
            SortFilters.Do(x => x.FirstOrDefault(f => f.Name == filterName).Do(y => SortFilters.SelectedItem = y));
        }
        SelectableCollection<FilterInfo<T>> staticFilters;
        public SelectableCollection<FilterInfo<T>> StaticFilters {
            get { return staticFilters; }
            set { SetProperty(ref staticFilters, value, FiltersChanged); }
        }
        SelectableCollection<FilterInfo<T>> customFilters;
        public SelectableCollection<FilterInfo<T>> CustomFilters {
            get { return customFilters; }
            set { SetProperty(ref customFilters, value, FiltersChanged); }
        }
        SelectableCollection<FilterInfo<T>> sortFilters;
        public SelectableCollection<FilterInfo<T>> SortFilters {
            get { return sortFilters; }
            set { SetProperty(ref sortFilters, value, FiltersChanged); }
        }
        SelectableCollection<FilterInfo<T>> additionActiveFilters;
        public SelectableCollection<FilterInfo<T>> AdditionActiveFilters {
            get { return additionActiveFilters; }
            set { SetProperty(ref additionActiveFilters, value, FiltersChanged); }
        }
        string queryText;
        public string QueryText {
            get { return queryText; }
            set { SetProperty(ref queryText, value, () => QueryText, () => OnSelectedItemChanged(this, null)); }
        }
        void FiltersChanged(SelectableCollection<FilterInfo<T>> oldValue, SelectableCollection<FilterInfo<T>> newValue) {
            oldValue.Do(x => x.SelectedItemChanged -= OnSelectedItemChanged);
            newValue.Do(x => x.SelectedItemChanged += OnSelectedItemChanged);
        }
        protected void OnSelectedItemChanged(object sender, FilterInfo<T> e) {
            if(!initialize)
                SelectedItemChanged(this, new SelectedItemChangeEventArgs<FilterInfo<T>>(e));
        }
        public DelegateCommand<string> SortCommand { get; private set; }
        public event EventHandler<SelectedItemChangeEventArgs<FilterInfo<T>>> SelectedItemChanged = (s, e) => { };
        public IEnumerable<T> FilterCollection(IEnumerable<T> entities) {
            Initialize(entities);
            GetStaticFiltersCount(entities);
            var filteredEntities = entities;
            StaticFilters.Do(x => x.SelectedItem.Do(y => filteredEntities = y.Filter(filteredEntities)));
            CustomFilters.Do(x => x.SelectedItem.Do(y => filteredEntities = y.Filter(filteredEntities)));
            SortFilters.Do(x => x.SelectedItem.Do(y => filteredEntities = y.Filter(filteredEntities)));
            filteredEntities = FilterByQueryText(filteredEntities);
            foreach(var filter in AdditionActiveFilters)
                filteredEntities = filter.Filter(filteredEntities);
            filteredEntities = FilterOverride(filteredEntities);
            initialize = false;
            return filteredEntities;
        }
        IEnumerable<T> FilterByQueryText(IEnumerable<T> filteredEntities) {
            return string.IsNullOrWhiteSpace(QueryText) ? filteredEntities : filteredEntities.Where(e => CheckByQueryText(e));
        }
        bool CheckByQueryText(object entity) {
            return TypeExtensions.GetProperties(entity.GetType()).FirstOrDefault(p => p.GetValue(entity) != null && p.GetValue(entity).ToString().IndexOf(QueryText, StringComparison.CurrentCultureIgnoreCase) != -1) != null;
        }
        protected virtual IEnumerable<T> FilterOverride(IEnumerable<T> entities) { return entities; }
        void Initialize(IEnumerable<T> entities) {
            if(isInitialized)
                return;
            isInitialized = true;
            initialize = true;
            InitializeOverride(entities);
        }
        protected virtual void InitializeOverride(IEnumerable<T> entities) { }

        void GetStaticFiltersCount(IEnumerable<T> entities) {
            if(StaticFilters == null || entities == null)
                return;
            bool countChanged = false;
            foreach(var filter in StaticFilters) {
                int count = filter.Filter(entities).Count();
                if(filter.Count != count) {
                    filter.Count = count;
                    countChanged = true;
                }
            }
            if(countChanged)
                StaticFilters.RaiseItemsContentChanged();
        }

        bool isInitialized = false;
        protected bool initialize = false;
    }
    public class EmptyFilterTreeViewModel<T> : FilterTreeViewModel<T> { }
    public class FilterInfo<T> : BindableBase {
        public FilterInfo(string name, Func<IEnumerable<T>, IEnumerable<T>> filter = null, string icon = null) {
            Name = name;
            Filter = filter != null ? filter : entities => entities;
            icon.Do(x => Icon = new Uri(string.Format("ms-appx:///Resources/Filters/{0}.png", x)));
        }
        public string Name { get; private set; }
        public Func<IEnumerable<T>, IEnumerable<T>> Filter { get; set; }
        public Uri Icon { get; set; }
        public int Count {
            get { return GetProperty(() => Count); }
            set { SetProperty(() => Count, value); }
        }
    }
    public class EmployeeFilterTreeViewModel : FilterTreeViewModel<Employee> {
        public EmployeeFilterTreeViewModel() {
            StaticFilters = new SelectableCollection<FilterInfo<Employee>> {
                new FilterInfo<Employee>("All", icon:"Employees/All"),
                new FilterInfo<Employee>("Salaried", entities => entities.Where(e => e.Status == EmployeeStatus.Salaried), "Employees/Salaried"),
                new FilterInfo<Employee>("Commission", entities => entities.Where(e => e.Status == EmployeeStatus.Commission), "Employees/Commission"),
                new FilterInfo<Employee>("Contract", entities => entities.Where(e => e.Status == EmployeeStatus.Contract), "Employees/Probation"),
                new FilterInfo<Employee>("Terminated", entities => entities.Where(e => e.Status == EmployeeStatus.Terminated), "Employees/Terminated"),
                new FilterInfo<Employee>("On Leave", entities => entities.Where(e => e.Status == EmployeeStatus.OnLeave), "Employees/OnLeave"),
            };
            StaticFilters.SelectedItem = StaticFilters.First();
            SortFilters = new SelectableCollection<FilterInfo<Employee>> {
                new FilterInfo<Employee>("None"),
                new FilterInfo<Employee>("Ascending", entities => entities.OrderBy(e => e.LastName)),
                new FilterInfo<Employee>("Descending", entites => entites.OrderByDescending(e => e.LastName)),
            };
            SortFilters.SelectedItem = SortFilters.First();
        }
    }
    public class ProductFilterTreeViewModel : FilterTreeViewModel<Product> {
        public ProductFilterTreeViewModel() {
            StaticFilters = new SelectableCollection<FilterInfo<Product>> {
                new FilterInfo<Product>("All", icon:"Products/All"),
                new FilterInfo<Product>("Video Players", entities => entities.Where(e => e.Category == ProductCategory.VideoPlayers), "Products/VideoPlayers"),
                new FilterInfo<Product>("Automation", entities => entities.Where(e => e.Category == ProductCategory.Automation), "Products/Automation"),
                new FilterInfo<Product>("Monitors", entities => entities.Where(e => e.Category == ProductCategory.Monitors), "Products/Monitors"),
                new FilterInfo<Product>("Projectors", entities => entities.Where(e => e.Category == ProductCategory.Projectors), "Products/Projectors"),
                new FilterInfo<Product>("Televisions", entities => entities.Where(e => e.Category == ProductCategory.Televisions), "Products/TVs"),
            };
            StaticFilters.SelectedItem = StaticFilters.First();
            CustomFilters = new SelectableCollection<FilterInfo<Product>> {
                new FilterInfo<Product>("All Products", entities => entities),
                new FilterInfo<Product>("HD Video player", entities => entities.Where(e => e.Category == ProductCategory.VideoPlayers && e.Name.Contains("HD"))),
                new FilterInfo<Product>("50inch Plasma", entities => entities.Where(e => e.Category == ProductCategory.Televisions && e.Name.Contains("50"))),
                new FilterInfo<Product>("21inch Monitor", entities => entities.Where(e => e.Category == ProductCategory.Monitors && e.Name.Contains("21"))),
                new FilterInfo<Product>("Remote Control", entities => entities.Where(e => e.Category == ProductCategory.Automation && e.Name.Contains("Remote"))),
            };
        }
    }
    public class CustomerFilterTreeViewModel : FilterTreeViewModel<Customer> {
        public CustomerFilterTreeViewModel() {
            CustomFilters = new SelectableCollection<FilterInfo<Customer>> {
                new FilterInfo<Customer>("All Customers", entities => entities),
                new FilterInfo<Customer>("My Account", entities => entities.Where(e => e.HomeOffice.State == StateEnum.CA)),
                new FilterInfo<Customer>("John's Account", entities => entities.Where(e => e.HomeOffice.State == StateEnum.WA)),
                new FilterInfo<Customer>("Top Stores", entities => entities.Where(e => e.AnnualRevenue >= 90000000000m)),
            };
        }
    }
    public class TaskFilterTreeViewModel : FilterTreeViewModel<EmployeeTask> {
        public TaskFilterTreeViewModel(Employee employee = null) {
            StaticFilters = new SelectableCollection<FilterInfo<EmployeeTask>> {
                new FilterInfo<EmployeeTask>("All Tasks", icon:"Tasks/AllTasks"),
                new FilterInfo<EmployeeTask>("In Progress", entities => entities.Where(e => e.Status == EmployeeTaskStatus.InProgress), "Tasks/InProgress"),
                new FilterInfo<EmployeeTask>("Not Started", entities => entities.Where(e => e.Status == EmployeeTaskStatus.NotStarted), "Tasks/NotStarted"),
                new FilterInfo<EmployeeTask>("Deferred", entities => entities.Where(e => e.Status == EmployeeTaskStatus.Deferred), "Tasks/Deferred"),
                new FilterInfo<EmployeeTask>("Completed", entities => entities.Where(e => e.Status == EmployeeTaskStatus.Completed), "Tasks/Completed"),
                new FilterInfo<EmployeeTask>("High Priority", entities => entities.Where(e => e.Priority == EmployeeTaskPriority.High), "Tasks/HighPriority"),
                new FilterInfo<EmployeeTask>("Urgent", entities => entities.Where(e => e.Priority == EmployeeTaskPriority.Urgent), "Tasks/Urgent"),
            };
            StaticFilters.SelectedItem = StaticFilters.FirstOrDefault();
            employee.Do(x => AdditionActiveFilters.Add(new FilterInfo<EmployeeTask>("", entities => entities.Where(e => e.AssignedEmployeeId == x.Id))));
        }
    }
    public abstract class RangeFilterTreeViewModelBase<TEntity> : FilterTreeViewModel<TEntity> where TEntity : new() {
        protected abstract DateTime GetValue(TEntity entity);
        protected abstract decimal GetDisplay(TEntity entity);
        protected abstract void SetValue(TEntity entity, DateTime value);
        protected abstract void SetDisplay(TEntity entity, decimal display);
        protected override IEnumerable<TEntity> FilterOverride(IEnumerable<TEntity> entities) {
            return entities.Where(e => {
                var value = GetValue(e);
                return value > SelectionStartDate && value < SelectionEndDate;
            });
        }
        public virtual DateTime SelectionStartDate {
            get { return GetProperty(() => SelectionStartDate); }
            set { SetProperty(() => SelectionStartDate, value, () => SelectionDateChanged()); }
        }
        public virtual DateTime SelectionEndDate {
            get { return GetProperty(() => SelectionEndDate); }
            set { SetProperty(() => SelectionEndDate, value, () => SelectionDateChanged()); }
        }
        public virtual DateTime VisibleStartDate {
            get { return GetProperty(() => VisibleStartDate); }
            set { SetProperty(() => VisibleStartDate, value); }
        }
        public virtual DateTime VisibleEndDate {
            get { return GetProperty(() => VisibleEndDate); }
            set { SetProperty(() => VisibleEndDate, value); }
        }
        public virtual DateTime StartDate {
            get { return GetProperty(() => StartDate); }
            set { SetProperty(() => StartDate, value); }
        }
        public virtual DateTime EndDate {
            get { return GetProperty(() => EndDate); }
            set { SetProperty(() => EndDate, value); }
        }
        public virtual List<TEntity> AverageEntities {
            get { return GetProperty(() => AverageEntities); }
            set { SetProperty(() => AverageEntities, value); }
        }
        async void SelectionDateChanged() {
            if(Windows.ApplicationModel.DesignMode.DesignModeEnabled || initialize)
                return;
            await Windows.UI.Xaml.Window.Current.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, new Windows.UI.Core.DispatchedHandler(() => OnSelectedItemChanged(this, null)));
        }
        protected override void InitializeOverride(IEnumerable<TEntity> entities) {
            base.InitializeOverride(entities);
            DateTime startDate = entities.Min(q => GetValue(q));
            DateTime endDate = entities.Max(q => GetValue(q));
            AverageEntities = GetAverageEntities(entities, startDate, endDate, 300);
            StartDate = startDate;
            EndDate = endDate;
            SelectionStartDate = startDate + TimeSpan.FromDays(28);
            SelectionEndDate = endDate - TimeSpan.FromDays(28);
            VisibleStartDate = startDate - TimeSpan.FromDays(1);
            VisibleEndDate = endDate + TimeSpan.FromDays(1);
        }
        public List<TEntity> GetAverageEntities(IEnumerable<TEntity> entities, DateTime startDate, DateTime endDate, int NumberOfPoints) {
            foreach(var filter in AdditionActiveFilters)
                entities = filter.Filter(entities).ToList();
            int daysPerGroup = (endDate - startDate).Days / NumberOfPoints;
            var constDate = new DateTime(1990, 1, 1);
            List<decimal> groups = entities
                .GroupBy(q => (GetValue(q) - constDate).TotalDays / daysPerGroup)
                .Select(g => g.Average(q => GetDisplay(q)))
                .ToList();
            DateTime currentDate = startDate;
            List<TEntity> averageEntities = new List<TEntity>();
            foreach(decimal total in groups) {
                var entity = new TEntity();
                SetValue(entity, currentDate);
                SetDisplay(entity, total);
                averageEntities.Add(entity);
                currentDate = currentDate.AddDays(1);
            }
            return averageEntities;
        }
    }
    public class OrderFilterTreeViewModel : RangeFilterTreeViewModelBase<Order> {
        public OrderFilterTreeViewModel(Customer customer = null) {
            SortFilters = new SelectableCollection<FilterInfo<Order>> {
                new FilterInfo<Order>("None"),
                new FilterInfo<Order>("Ascending", entities => entities.OrderBy(e => e.Customer.Name)),
                new FilterInfo<Order>("Descending", entites => entites.OrderByDescending(e => e.Customer.Name)),
            };
            SortFilters.SelectedItem = SortFilters.First();
            customer.Do(x => AdditionActiveFilters.Add(new FilterInfo<Order>("", entities => entities.Where(e => e.CustomerId == x.Id))));
        }
        protected override DateTime GetValue(Order entity) { return entity.OrderDate; }
        protected override decimal GetDisplay(Order entity) { return entity.TotalAmount; }
        protected override void SetValue(Order entity, DateTime value) { entity.OrderDate = value; }
        protected override void SetDisplay(Order entity, decimal display) { entity.TotalAmount = display; }
    }
    public class QuoteFilterTreeViewModel : RangeFilterTreeViewModelBase<Quote> {
        protected override DateTime GetValue(Quote entity) { return entity.Date; }
        protected override decimal GetDisplay(Quote entity) { return entity.Total; }
        protected override void SetValue(Quote entity, DateTime value) { entity.Date = value; }
        protected override void SetDisplay(Quote entity, decimal display) { entity.Total = display; }
    }
    public class SelectableCollection<T> : ObservableCollection<T> {
        public SelectableCollection() {
            SelectedItem = this.FirstOrDefault();
        }
        T selectedItem;
        public T SelectedItem {
            get { return selectedItem; }
            set {
                if(object.Equals(value, selectedItem))
                    return;
                selectedItem = value;
                SelectedItemChanged(this, value);
            }
        }
        public EventHandler<T> SelectedItemChanged = (s, e) => { };

        public event EventHandler ItemsContentChanged;
        public void RaiseItemsContentChanged() {
            if(ItemsContentChanged != null)
                ItemsContentChanged(this, null);
        }
    }
    public class SelectedItemChangeEventArgs<T> : EventArgs {
        public SelectedItemChangeEventArgs(T item) {
            this.Item = item;
        }
        public T Item { get; set; }
    }
}
