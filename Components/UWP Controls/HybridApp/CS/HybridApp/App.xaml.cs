using System;
using DevExpress.UI.Xaml.Layout;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace HybridApp {
    sealed partial class App : Application {
        public App() {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            DevExpress.UI.Xaml.Layout.Utils.ApplicationViewState.ApplicationViewMinWidth = 0d;
        }
        void SetTileBarStyle() {
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            Color color = Color.FromArgb(255, 63, 63, 63);

            titleBar.BackgroundColor = color;
            titleBar.ForegroundColor = Colors.White;
            titleBar.InactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = color;
            titleBar.ButtonInactiveBackgroundColor = color;
            titleBar.InactiveBackgroundColor = color;
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
        }
        protected override async void OnLaunched(LaunchActivatedEventArgs args) {
            SetTileBarStyle();
            if(args.PreviousExecutionState == ApplicationExecutionState.Running) {
                Window.Current.Activate();
                return;
            }
            DXFrame rootFrame = new DXFrame() { HideBackButton = true };
            if(args.PreviousExecutionState == ApplicationExecutionState.Terminated ||
                args.PreviousExecutionState == ApplicationExecutionState.ClosedByUser) {
                await SuspensionManager.RestoreAsync();
            }
            SuspensionManager.RegisterFrame(rootFrame, "AppFrame");
            Window.Current.Content = rootFrame;
            if(rootFrame.Content == null) {
                if(!rootFrame.Navigate(typeof(DevAVDbView), "AllGroups")) {
                    throw new Exception("Failed to create initial page");
                }
            }
            Window.Current.Activate();
            HideStatusBar();
        }
        async void HideStatusBar() {
            if(ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar")) {
                StatusBar statusBar = StatusBar.GetForCurrentView();
                await statusBar.HideAsync();
            }
        }
        async void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }
    }
}
