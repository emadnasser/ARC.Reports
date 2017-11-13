using System;
using System.Drawing;
using DevExpress.SalesDemo.Win.Modules;
using DevExpress.Utils.About;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.Utils.Taskbar;

namespace DevExpress.SalesDemo.Win {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        System.Drawing.Image userPic;
        public MainForm() {
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, this);
            using(Model.DataSource.Progress.Subscribe(new DataGenerationProgress()))
                Model.DataSource.EnsureDataProvider();
            InitializeComponent();
            LoadResources();

            loginFlyout.Action = CreateLoginAction();
            closeFlyout.Action = CreateCloseAction();
            windowsUIView.FlyoutHidden += windowsUIView_FlyoutHidden;
            windowsUIView.QueryStartupContentContainer += windowsUIView_QueryStartupContentContainer;
            windowsUIView.NavigationBarsShowing += windowsUIView_NavigationBarsShowing;
            windowsUIView.CustomDrawBackButton += windowsUIView_CustomDrawBackButton;
            windowsUIView.NavigatedTo += windowsUIView_NavigatedTo;
            windowsUIView.NavigatedFrom += windowsUIView_NavigatedFrom;
        }
        string UserName = "John Smith";
        void windowsUIView_NavigatedTo(object sender, NavigationEventArgs e) {
            if(e.Target == loginFlyout)
                e.Parameter = UserName;
        }
        void windowsUIView_NavigatedFrom(object sender, NavigationEventArgs e) {
            if(e.Source == loginFlyout && loginFlyout.LastResult == System.Windows.Forms.DialogResult.OK) {
                UserName = e.Parameter as string;
                hubGroup.Caption = UserName;
            }
        }
        void LoadResources() {
            userPic = LoadImage("User.png");
            documentSalesDashboard.Image = LoadImage("Sales.png");
            documentProducts.Image = LoadImage("Products.png");
            documentSectors.Image = LoadImage("Sectors.png");
            documentRegions.Image = LoadImage("Regions.png");
            documentChannels.Image = LoadImage("Channels.png");
            windowsUIView.BackgroundImage = LoadImage("Background.png");
        }
        static System.Drawing.Image LoadImage(string imageName) {
            return Utils.ResourceImageHelper.CreateImageFromResources(Model.ModelAssemblyHelper.GetResourcePath(imageName), Model.ModelAssemblyHelper.ModelAssembly);
        }
        Brush borderBrush = new SolidBrush(Color.FromArgb(0xa6, 0xa6, 0xa6));
        Brush borderHotBrush = new SolidBrush(Color.FromArgb(126, 180, 234));
        void windowsUIView_CustomDrawBackButton(object sender, CustomDrawBackButtonEventArgs e) {
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(e.ButtonInfo.Hot ? borderHotBrush : borderBrush, Rectangle.Inflate(e.ButtonInfo.ImageBounds, 3, 3));
            e.Graphics.FillEllipse(Brushes.White, Rectangle.Inflate(e.ButtonInfo.ImageBounds, 1, 1));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            e.DrawGlyph(userPic);
            e.Handled = true;
        }
        void windowsUIView_NavigationBarsShowing(object sender, NavigationBarsCancelEventArgs e) {
            e.Cancel = (e.ContentContainer == hubGroup);
        }
        void windowsUIView_FlyoutHidden(object sender, FlyoutResultEventArgs e) {
            if(windowsUIView.ActiveFlyoutContainer == loginFlyout)
                windowsUIView.ActivateContainer(hubGroup);
        }
        void windowsUIView_QueryStartupContentContainer(object sender, QueryContentContainerEventArgs e) {
            hubGroup.Caption = UserName;
            e.ContentContainer = hubGroup;
        }
        void windowsUIView_QueryControl(object sender, XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            Type moduleType = typeof(MainForm).Assembly.GetType(e.Document.ControlTypeName);
            BaseModule module = Activator.CreateInstance(moduleType) as BaseModule;
            module.Init(barManager);
            e.Control = module;
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) {
            base.OnClosing(e);
            if(windowsUIView.ShowFlyoutDialog(closeFlyout) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
        }
        FlyoutAction CreateLoginAction() {
            FlyoutAction loginAction = new FlyoutAction();
            loginAction.Caption = Text + " LOGIN";
            loginAction.Commands.Add(FlyoutCommand.OK);
            return loginAction;
        }
        FlyoutAction CreateCloseAction() {
            FlyoutAction closeAction = new FlyoutAction();
            closeAction.Caption = Text;
            closeAction.Description = "Do you really want to close the demo?";
            closeAction.Commands.Add(FlyoutCommand.Yes);
            closeAction.Commands.Add(FlyoutCommand.No);
            return closeAction;
        }
    }
    class DataGenerationProgress : IObserver<int> {
        void IObserver<int>.OnCompleted() {
            XtraSplashScreen.SplashScreenManager.CloseDefaultSplashScreen();
        }
        void IObserver<int>.OnNext(int value) {
            if(DevExpress.XtraSplashScreen.SplashScreenManager.Default == null) {
                XtraSplashScreen.SplashScreenManager.ShowDefaultProgressSplashScreen("Generating Sales...");
            }
            XtraSplashScreen.SplashScreenManager.SetDefaultProgressSplashScreenValue(false, value);
        }
        void IObserver<int>.OnError(Exception error) { throw error; }
    }
}
