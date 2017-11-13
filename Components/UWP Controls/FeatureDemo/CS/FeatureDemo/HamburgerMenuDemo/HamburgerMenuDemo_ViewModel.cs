using System;
using DevExpress.Mvvm;
using DevExpress.UI.Xaml.Layout;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using System.Windows.Input;
using FeatureDemo.Common;
using System.Collections.Generic;
using FeatureDemo.ViewModel;
using DevExpress.Core;

namespace HamburgerMenuDemo {
    public class HamburgerMenuDemo_ViewModel : NavigationViewModelBase {
        bool IsInitializing { get; set; }
        public ICommand CloseWindowCommand { get; private set; }

        public string CheckBoxState {
            get { return this.GetProperty<string>(); }
            set { this.SetProperty(value); }
        }
        public string SelectedRadioButtonGlyph {
            get { return this.GetProperty<string>(); }
            set { this.SetProperty(value); }
        }
        public bool IsCalendarRadioButtonChecked {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value, UpdateSelectedRadioButton); }
        }
        public bool IsMailRadioButtonChecked {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value, UpdateSelectedRadioButton); }
        }
        public bool IsCheckBoxChecked {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value, UpdateCheckBoxState); }
        }
        public string Description {
            get { return this.GetProperty<string>(); }
            set { this.SetProperty(value); }
        }
        public string Title {
            get { return this.GetProperty<string>(); }
            set { this.SetProperty(value); }
        }
        public string Header {
            get { return this.GetProperty<string>(); }
            set { this.SetProperty(value); }
        }
        public bool AllowCustomizingWindowTitle {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value); }
        }
        public bool ShowMenuOnEmptySpaceBarClick {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value); }
        }

        public HamburgerMenuAvailableViewStates AvailableViewStates {
            get { return this.GetProperty<HamburgerMenuAvailableViewStates>(); }
            set { this.SetProperty(value); }
        }
        public bool IsFlyoutViewStateEnabled {
            get { return this.GetProperty<bool>(); }
            set {
                this.SetProperty(value, OnIsFlyoutViewStateEnabledChanged); }
        }
        public bool IsOverlayViewStateEnabled {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value, OnIsOverlayViewStateEnabledChanged); }
        }
        public bool IsInlineViewStateEnabled {
            get { return this.GetProperty<bool>(); }
            set { this.SetProperty(value, OnIsInlineViewStateEnabledChanged); }
        }
        protected bool IsAvailableViewStateEmpty() {
            return !IsInlineViewStateEnabled && !IsOverlayViewStateEnabled && !IsFlyoutViewStateEnabled;
        }
        protected void OnIsFlyoutViewStateEnabledChanged() {
            if(!IsFlyoutViewStateEnabled && IsAvailableViewStateEmpty()) {
                this.GetService<IDispatcherService>().BeginInvoke(() => IsFlyoutViewStateEnabled = true);
                return;
            }
            UpdateAvailableViewState();
        }
        protected void OnIsOverlayViewStateEnabledChanged() {
            if(!IsOverlayViewStateEnabled && IsAvailableViewStateEmpty()) {
                this.GetService<IDispatcherService>().BeginInvoke(() =>IsOverlayViewStateEnabled = true);
                return;
            }
            UpdateAvailableViewState();
        }
        protected void OnIsInlineViewStateEnabledChanged() {
            if(!IsInlineViewStateEnabled && IsAvailableViewStateEmpty()) {
                this.GetService<IDispatcherService>().BeginInvoke(() => IsInlineViewStateEnabled = true);
                return;
            }
            UpdateAvailableViewState();
        }
        void UpdateSelectedRadioButton() {
            SelectedRadioButtonGlyph = IsCalendarRadioButtonChecked ? "\uE787" : "\uE715";
        }
        void UpdateCheckBoxState() {
            CheckBoxState = IsCheckBoxChecked ? "Checked" : "Unchecked";
        }

        protected void UpdateAvailableViewState() {
            HamburgerMenuAvailableViewStates state = (HamburgerMenuAvailableViewStates)0;
            if(IsInlineViewStateEnabled)
                state = state | HamburgerMenuAvailableViewStates.Inline;
            if(IsOverlayViewStateEnabled)
                state = state | HamburgerMenuAvailableViewStates.Overlay;
            if(IsFlyoutViewStateEnabled)
                state = state | HamburgerMenuAvailableViewStates.Flyout;
            AvailableViewStates = state;
        }

        public HamburgerMenuDemo_ViewModel() {
            IsInitializing = true;
            Header = "Menu Header";
            IsMailRadioButtonChecked = true;
            UpdateCheckBoxState();
            CloseWindowCommand = new DelegateCommand(OnCloseWindowCommandExecute);
            AllowCustomizingWindowTitle = true;
            ShowMenuOnEmptySpaceBarClick = true;
            IsInlineViewStateEnabled = true;
            IsOverlayViewStateEnabled = true;
            IsFlyoutViewStateEnabled = true;
            IsInitializing = false;
        }

        private async void OnCloseWindowCommandExecute() {
            if(await GetService<IMessageBoxService>().ShowAsync("Do you want to close the demo?", "Hamburger Menu Demo", MessageButton.YesNo) == MessageResult.Yes) {
                GetService<ICloseWindowService>().Close();
            }
        }
    }
}
