using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using FeatureDemo.Common;
using FeatureDemo.DataModel;
using Windows.UI.Xaml;
using DevExpress.UI.Xaml.Layout;
using DevExpress.Core.Native;
using Windows.UI;
using DevExpress.Core;
using System.Runtime.Serialization;

namespace FeatureDemo.ViewModel {
    public class MainViewModel : NavigationViewModelBase, ISupportNavigationEvents, ISupportGoBack {
        public const string MainScreenId = "MainScreen";
        #region services
        INavigationService NavigationService { get { return ServiceContainer.GetService<INavigationService>(); } }
        #endregion
        #region commands
        public ICommand DemoModuleClickCommand { get; }
        public ICommand ShowPrevCommand { get; }
        public ICommand ShowNextCommand { get; }
        public ICommand HamburgerMenuItemClickCommand { get; }
        #endregion
        #region properties
        private bool showCommandBar = false;
        private bool showHamburgerButton = true;
        private bool isHamburgerMenuOpen = false;
        private bool prevNextEnabled = false;
        private bool showLabels = true;
        int selectedDemoModuleIndex = 0;
        object selectedHamburgerMenuItem;

        public bool PrevNextEnabled {
            get { return prevNextEnabled; }
            set { SetProperty(ref prevNextEnabled, value); }
        }
        public List<object> HamburgerMenuItems { get; }
        public object SelectedHamburgerMenuItem {
            get { return selectedHamburgerMenuItem; }
            set { SetProperty(ref selectedHamburgerMenuItem, value); }
        }
        public bool ShowCommandBar {
            get { return showCommandBar; }
            set { SetProperty(ref showCommandBar, value); }
        }
        public bool ShowHamburgerButton {
            get { return showHamburgerButton; }
            set { SetProperty(ref showHamburgerButton, value); }
        }
        public bool IsHamburgerMenuOpen {
            get { return isHamburgerMenuOpen; }
            set { SetProperty(ref isHamburgerMenuOpen, value, OnIsHamburgerMenuOpenChanged); }
        }
        public int SelectedDemoModuleIndex {
            get { return selectedDemoModuleIndex; }
            set { SetProperty(ref selectedDemoModuleIndex, value, OnSelectedDemoModuleIndexChanged); }
        }
        public bool ShowLabels {
            get { return showLabels; }
            set { SetProperty(ref showLabels, value); }
        }
        bool IsStateRestored { get; set; }
        NavigationLevel NavigationLevel { get; set; } = NavigationLevel.Main;
        List<string> navigationHistory;
        public ObservableCollection<DemoModuleViewModel> DemoModules { get; private set; }
        public ObservableCollection<DemoModuleViewModel> FilteredDemoModules { get; private set; }

        #endregion
        public MainViewModel() {
            navigationHistory = new List<string>() { MainScreenId };
            HamburgerMenuItems = new List<object>();
            DemoModuleClickCommand = new DelegateCommand<object>(DemoModuleClickCommandExecute);
            ShowNextCommand = new DelegateCommand<object>(ShowNextCommandExecute);
            ShowPrevCommand = new DelegateCommand<object>(ShowPrevCommandExecute);
            HamburgerMenuItemClickCommand = new DelegateCommand<object>(HamburgerMenuItemClickCommandExecute);
            InitializeDemoModulesAndHamburgerMenuItems();
        }
        void InitializeDemoModulesAndHamburgerMenuItems() {
            HamburgerMenuItems.Add(new HamburgerMenuItem(this,
                                                         "Featured Demos",
                                                          @"M4 60h52c2.2 0 4-1.8 4-4V4c0-2.2-1.8-4-4-4H4C1.8 0 0 1.8 0 4v52C0 58.2 1.8 60 4 60z
                                                          M72 60h52c2.2 0 4-1.8 4-4V4c0-2.2-1.8-4-4-4H72c-2.2 0-4 1.8-4 4v52C68 58.2 69.8 60 72 60z
                                                          M140 60h52c2.2 0 4-1.8 4-4V4c0-2.2-1.8-4-4-4h-52c-2.2 0-4 1.8-4 4v52C136 58.2 137.8 60 140 60z
                                                          M4 128h52c2.2 0 4-1.8 4-4V72c0-2.2-1.8-4-4-4H4c-2.2 0-4 1.8-4 4v52C0 126.2 1.8 128 4 128z
                                                          M72 128h52c2.2 0 4-1.8 4-4V72c0-2.2-1.8-4-4-4H72c-2.2 0-4 1.8-4 4v52C68 126.2 69.8 128 72 128z
                                                          M140 128h52c2.2 0 4-1.8 4-4V72c0-2.2-1.8-4-4-4h-52c-2.2 0-4 1.8-4 4v52C136 126.2 137.8 128 140 128z
                                                          M4 196h52c2.2 0 4-1.8 4-4v-52c0-2.2-1.8-4-4-4H4c-2.2 0-4 1.8-4 4v52C0 194.2 1.8 196 4 196z
                                                          M72 196h52c2.2 0 4-1.8 4-4v-52c0-2.2-1.8-4-4-4H72c-2.2 0-4 1.8-4 4v52C68 194.2 69.8 196 72 196z
                                                          M140 196h52c2.2 0 4-1.8 4-4v-52c0-2.2-1.8-4-4-4h-52c-2.2 0-4 1.8-4 4v52C136 194.2 137.8 196 140 196z",
                                                          MainScreenId
            ));
            int topDemoModuleCount = 0;
            DemoModules = new ObservableCollection<DemoModuleViewModel>();
            int insertIndex = 0;
            foreach(DemoModuleGroup demoModuleGroup in DataModel.DataModel.Current.DemoModuleGroups) {
                foreach(DemoModule demoModule in demoModuleGroup.DemoModules) {
                    if(demoModule.IsHighlighted) {
                        if(demoModule.IsUpdated || demoModule.IsNew) {
                            insertIndex = 0;
                        } else
                            insertIndex = topDemoModuleCount;
                        topDemoModuleCount++;
                    } else {
                        insertIndex = DemoModules.Count;
                    }
                    DemoModules.Insert(insertIndex, new DemoModuleViewModel(this, demoModuleGroup, demoModule));

                }
                HamburgerMenuItems.Add(new HamburgerMenuItem(this, demoModuleGroup.Title, demoModuleGroup.Icon, demoModuleGroup.Name));
            }

            string colorSchemeItemIcon = App.Current.Resources["ColorSchemesIconData"] as string;
            HamburgerMenuItems.Add(new HamburgerMenuThemeSwitcherItem() { Title = "Color Scheme", Icon = colorSchemeItemIcon });
            HamburgerMenuItems.Add(new HamburgerMenuHyperLink() { Title = "Privacy Policy", Uri = @"https://www.devexpress.com/Products/NET/Controls/Win10Apps/privacy-policy.xml" });

            FilteredDemoModules = new ObservableCollection<DemoModuleViewModel>();
            foreach(DemoModuleViewModel demoModule in DemoModules) {
                FilteredDemoModules.Add(demoModule);
            }
        }
        void NavigateToDemoModule(DemoModuleViewModel demoModule) {
            UpdateFilteredDemoModules(demoModule);
            SelectedDemoModuleIndex = 0;
            NavigationLevel = NavigationLevel.DemoModule;
            Navigate("DemoModulePage", demoModule.DemoModule.ViewTypeName);
        }
        void UpdateFilteredDemoModules(DemoModuleViewModel firstDemoModule) {
            int index = DemoModules.IndexOf(firstDemoModule);
            FilteredDemoModules.Clear();
            for(int i = index; i < DemoModules.Count; i++) {
                if(DemoModules[i].IsVisible)
                    FilteredDemoModules.Add(DemoModules[i]);
            }
            for(int i = 0; i < index; i++) {
                if(DemoModules[i].IsVisible)
                    FilteredDemoModules.Add(DemoModules[i]);
            }
            PrevNextEnabled = FilteredDemoModules.Count > 1;
        }
        void Navigate(string pageName, string navigationParameter) {
            NavigationService.Navigate(pageName, navigationParameter, null, false);
        }
        bool SelectHamburgerMenuItemByParameter(object parameter) {
            HamburgerMenuItem item = HamburgerMenuItems.OfType<HamburgerMenuItem>().FirstOrDefault(x => x.GroupName != null && x.GroupName == parameter as string);
            if(item != null) {
                SelectedHamburgerMenuItem = item;
                ApplyFilter(item.GroupName);
                return true;
            }
            return false;
        }
        void ApplyFilter(string filterString) {
            DemoModules.ForEach(x => x.IsVisible = x.Group.Name == filterString || filterString == MainScreenId && x.DemoModule.IsHighlighted || string.IsNullOrEmpty(filterString));
            ShowLabels = filterString == MainScreenId;
        }

        void RestoreState(object parameter, PageStateStorage storage) {
            List<string> savedNavigationHistory;
            if(storage.TryGetParameter("DemoNavigationHistory", out savedNavigationHistory)) {
                navigationHistory = savedNavigationHistory;
            };
            object hamburgerMenuItemGroupName = navigationHistory == null ? parameter : navigationHistory[navigationHistory.Count - 1];
            SelectHamburgerMenuItemByParameter(hamburgerMenuItemGroupName);
            if(hamburgerMenuItemGroupName.Equals(parameter)) return;
            DemoModuleViewModel demoModule = DemoModules.First(x => x.DemoModule.ViewTypeName.Equals(parameter));
            UpdateFilteredDemoModules(demoModule);
            NavigationLevel = NavigationLevel.DemoModule;
            SelectedDemoModuleIndex = storage.GetParameter("SelectedDemoModuleIndex", SelectedDemoModuleIndex);
        }
        void SaveState(PageStateStorage storage) {
            storage.SaveParameter("SelectedDemoModuleIndex", SelectedDemoModuleIndex);
            storage.SaveParameter("NeedDisableNavigationOnSelectedHamburgerMenuItemChanged", true);
            storage.SaveParameter("DemoNavigationHistory", navigationHistory);
        }
        #region command handlers
        void ShowNextCommandExecute(object parameter) {
            SelectedDemoModuleIndex = (SelectedDemoModuleIndex + 1) % FilteredDemoModules.Count;
        }
        void ShowPrevCommandExecute(object parameter) {
            SelectedDemoModuleIndex = SelectedDemoModuleIndex == 0 ? FilteredDemoModules.Count - 1 : SelectedDemoModuleIndex - 1;
        }
        void HamburgerMenuItemClickCommandExecute(object parameter) {
            if(SelectHamburgerMenuItemByParameter(parameter)) {
                AddNavigationHistoryEntry(parameter.ToString());
                NavigationLevel = NavigationLevel.Main;
                Navigate("MainPage", parameter.ToString());
                GetService<IResetScrollViewService>()?.Reset();
            }
        }
        void AddNavigationHistoryEntry(string entry) {
            if(navigationHistory.Count != 0 && navigationHistory[navigationHistory.Count - 1] == entry)
                return;
            navigationHistory.Add(entry);
        }
        internal void DemoModuleClickCommandExecute(object parameter) {
            NavigateToDemoModule(parameter as DemoModuleViewModel);
        }
        #endregion
        #region property change handlers
        protected virtual void OnIsHamburgerMenuOpenChanged(bool oldValue, bool newValue) {

        }
        protected virtual void OnSelectedDemoModuleIndexChanged(int oldValue, int newValue) {
        }
        #endregion
        #region ISupportNavigationEvents
        void ISupportNavigationEvents.OnNavigated(DXNavigationEventArgs e) {
            if(IsStateRestored) return;
            RestoreState(e.Parameter, e.Storage);
            IsStateRestored = true;
        }
        void ISupportNavigationEvents.OnNavigating(DXNavigatingCancelEventArgs e) {
            SaveState(e.CurrentPageStorage);
        }
        #endregion
        #region ISupportGoBack
        public bool CanGoBack {
            get { return navigationHistory != null && navigationHistory.Count > 1 || NavigationLevel == NavigationLevel.DemoModule; }
        }

        public void GoBack() {
            string parameter = null;
            if(NavigationLevel == NavigationLevel.DemoModule) {
                parameter = navigationHistory[navigationHistory.Count - 1];
                NavigationLevel = NavigationLevel.Main;
            } else  if(navigationHistory != null && navigationHistory.Count > 1) {
                parameter = navigationHistory[navigationHistory.Count - 2];
                navigationHistory.RemoveAt(navigationHistory.Count - 1);
            }
            SelectHamburgerMenuItemByParameter(parameter);
            Navigate("MainPage", parameter);
        }

        #endregion
    }
    public class HamburgerMenuItem {
        public MainViewModel MainViewModel { get; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string GroupName { get; set; }
        public HamburgerMenuItem(MainViewModel viewModel, string title, string icon, string groupName = null) {
            MainViewModel = viewModel;
            Title = title;
            Icon = icon;
            GroupName = groupName;
        }
        public HamburgerMenuItem() {
        }
    }
    public class ColorSchemeInfo {
        public string PublicName { get { return ColorSchemeName + (RequestedTheme == ElementTheme.Light ? " Light" : " Dark"); } }
        public string ColorSchemeName { get; private set; }
        public ElementTheme RequestedTheme { get; private set; }
        public ColorSchemeInfo(string colorSchemeName, ElementTheme requestedTheme) {
            ColorSchemeName = colorSchemeName;
            RequestedTheme = requestedTheme;
        }
    }
    public class HamburgerMenuThemeSwitcherItem {
        public string Title { get; set; }
        public string Icon { get; set; }
    }
    public class HamburgerMenuHyperLink : HamburgerMenuItem {
        public string Uri { get; set; }
        public HamburgerMenuHyperLink() {
        }
    }
    public enum NavigationLevel { Main, DemoModule }
}
