using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Mvvm.UI.Interactivity;
using HybridApp.HybridAppService;
using HybridApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HybridApp.Views {
    public class EmployeesFilterControlBehavior : FilterControlBehavior<Employee> {
    }
    public class ProductsFilterControlBehavior : FilterControlBehavior<Product> {
    }
    public class TasksFilterControlBehavior : FilterControlBehavior<EmployeeTask> {
    }
    public abstract class FilterControlBehavior<T> : Behavior<CommandBar> {
        ObservableCollection<AppBarToggleButton> buttonsCollection;
        FilterInfo<T> selectedItemAfterUpdate;
        FilterInfo<T> selectedFilterItem;
        DispatcherTimer selectionTimer;
        bool isSelected = false;
        public static readonly DependencyProperty StaticFiltersProperty =
    DependencyProperty.Register("StaticFilters", typeof(SelectableCollection<FilterInfo<T>>), typeof(FilterControlBehavior<T>),
        new PropertyMetadata(null, (s, e) => ((FilterControlBehavior<T>)s).FiltersUpdate()));

        public SelectableCollection<FilterInfo<T>> StaticFilters {
            get { return (SelectableCollection<FilterInfo<T>>)GetValue(StaticFiltersProperty); }
            set { SetValue(StaticFiltersProperty, value); }
        }
        public FilterControlBehavior() {
        }
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.Loaded += AssociatedObject_Loaded;
            AssociatedObject.Unloaded += AssociatedObject_Unloaded;
            selectionTimer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 0, 50) };
            selectionTimer.Tick += SelectionTimer_Tick;
        }
        protected override void OnDetaching() {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_Loaded;
            AssociatedObject.Unloaded -= AssociatedObject_Unloaded;
            selectionTimer.Tick -= SelectionTimer_Tick;
        }
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e) {
            buttonsCollection = new ObservableCollection<AppBarToggleButton>();
            foreach(var button in AssociatedObject.SecondaryCommands.OfType<AppBarToggleButton>()) {
                buttonsCollection.Add(button);
                button.Click += Button_Click;
            }
            SelectButtonOnFirstLoaded();
            LoadFilterCount();
        }
        void AssociatedObject_Unloaded(object sender, RoutedEventArgs e) {
            foreach(var button in buttonsCollection)
                button.Click -= Button_Click;
        }
        void SelectButtonOnFirstLoaded() {
            if(isSelected) return;
            isSelected = true;
            if(selectedItemAfterUpdate != null) {
                AppBarToggleButton selectedButton = buttonsCollection.FirstOrDefault(x => x.Label.Contains(selectedItemAfterUpdate.Name));
                if(selectedButton != null)
                    selectedButton.IsChecked = true;
            }
        }
        void LoadFilterCount() {
            if(buttonsCollection == null) return;
            foreach(var item in StaticFilters) {
                AppBarToggleButton button = buttonsCollection.FirstOrDefault(x => x.Label.Contains(item.Name));
                if(button != null)
                    button.Label = item.Name + " (" + item.Count.ToString() + ")";
            }
        }
        void Button_Click(object sender, RoutedEventArgs e) {
            AppBarToggleButton button = (AppBarToggleButton)sender;
            foreach(var item in StaticFilters)
                if(button.Label.Contains(item.Name)) {
                    selectedFilterItem = item;
                    selectionTimer.Start();
                    if(button.IsChecked == false)
                        button.IsChecked = true;
                    ResetToggleButtons(item.Name);
                    return;
                }
        }
        void SelectionTimer_Tick(object sender, object e) {
            selectionTimer.Stop();
            StaticFilters.SelectedItem = selectedFilterItem;
        }
        void ResetToggleButtons(string selectedItemName) {
            foreach(var item in StaticFilters) {
                AppBarToggleButton button = buttonsCollection.FirstOrDefault(x => x.Label.Contains(item.Name));
                if(button != null && !button.Label.Contains(selectedItemName))
                    button.IsChecked = false;
            }
        }
        void FiltersUpdate() {
            if(StaticFilters != null) {
                selectedItemAfterUpdate = StaticFilters.SelectedItem;
                StaticFilters.ItemsContentChanged -= ItemsContentChanged;
                if(StaticFilters.Count > 0)
                    StaticFilters.ItemsContentChanged += ItemsContentChanged;
            }
        }
        void ItemsContentChanged(object sender, EventArgs e) {
            LoadFilterCount();
        }
    }
}
