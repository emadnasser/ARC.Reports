using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("MessageBox Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IMessageBoxService")]
    [CodeExampleUnderlineTokens("RegisterMessageBoxService", "RegisterXtraMessageBoxService", "RegisterFlyoutMessageBoxService", "ShowMessage")]
    public static class MessageBoxServices {
        static MessageBoxServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            MVVMContext.RegisterXtraMessageBoxService();
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("MessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void MessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the MessageBoxService
            MVVMContext.RegisterMessageBoxService();
            //
            mvvmContext.ViewModelType = typeof(SayHelloViewModel);
            // UI binding for button
            mvvmContext.BindCommand<SayHelloViewModel>(commandButton, x => x.SayHello());
        }
        [CodeExampleCase("XtraMessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void XtraMessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the XtraMessageBoxService
            MVVMContext.RegisterXtraMessageBoxService();
            //
            mvvmContext.ViewModelType = typeof(SayHelloViewModel);
            // UI binding for button
            mvvmContext.BindCommand<SayHelloViewModel>(commandButton, x => x.SayHello());
        }
        [CodeExampleCase("FlyoutMessageBox Service", new Type[] { typeof(SayHelloViewModel) })]
        public static void FlyoutMessageBoxService(MVVMContext mvvmContext, SimpleButton commandButton) {
            // Force use the FlyoutMessageBoxService
            MVVMContext.RegisterFlyoutMessageBoxService();
            //
            mvvmContext.ViewModelType = typeof(SayHelloViewModel);
            // UI binding for button
            mvvmContext.BindCommand<SayHelloViewModel>(commandButton, x => x.SayHello());
        }
        //
        [CodeExampleNestedClass]
        public class SayHelloViewModel {
            protected IMessageBoxService MessageBoxService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IMessageBoxService>(); }
            }
            public void SayHello() {
                // using the MessageBoxService.ShowMessage method
                if(MessageBoxService.ShowMessage("Hello, buddy! Have a nice day!", "Greeting", MessageButton.OK, MessageIcon.Information) == MessageResult.OK) {
                    // do something
                }
            }
        }
    }

    [CodeExampleClass("Dialog Services", "Services.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "IDialogService", "ISupportParameter")]
    [CodeExampleUnderlineTokens("RegisterXtraDialogService", "RegisterRibbonDialogService", "RegisterFlyoutDialogService", "ShowDialog")]
    public static class DialogServices {
        static DialogServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;

            MemoEdit memo = new MemoEdit();
            memo.Dock = DockStyle.Top;
            memo.Properties.ReadOnly = true;
            memo.MinimumSize = new System.Drawing.Size(0, 100);

            commandButton.Parent = sampleHost;
            memo.Parent = sampleHost;

            return new object[] { mvvmContext, commandButton, memo };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("XtraDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void XtraDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the XtraDialogService
            MVVMContext.RegisterXtraDialogService();
            //
            mvvmContext.ViewModelType = typeof(NotesViewModel);
            // UI binding for Notes
            mvvmContext.SetBinding(memo, m => m.EditValue, "Notes");
            // UI binding for button
            mvvmContext.BindCommand<NotesViewModel>(commandButton, x => x.EditNotes());
        }
        [CodeExampleCase("FlyoutDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void FlyoutDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the FlyoutDialogService
            MVVMContext.RegisterFlyoutDialogService();
            //
            mvvmContext.ViewModelType = typeof(NotesViewModel);
            // UI binding for Notes
            mvvmContext.SetBinding(memo, m => m.EditValue, "Notes");
            // UI binding for button
            mvvmContext.BindCommand<NotesViewModel>(commandButton, x => x.EditNotes());
        }
        [CodeExampleCase("RibbonDialog Service", new Type[] { typeof(NotesViewModel), typeof(EditNotesViewModel), typeof(NotesEditor) })]
        public static void RibbonDialogService(MVVMContext mvvmContext, SimpleButton commandButton, MemoEdit memo) {
            // Force use the RibbonDialogService
            MVVMContext.RegisterRibbonDialogService();
            //
            mvvmContext.ViewModelType = typeof(NotesViewModel);
            // UI binding for Notes
            mvvmContext.SetBinding(memo, m => m.EditValue, "Notes");
            // UI binding for button
            mvvmContext.BindCommand<NotesViewModel>(commandButton, x => x.EditNotes());
        }
        [CodeExampleNestedClass]
        public class NotesViewModel {
            public NotesViewModel() {
                Notes = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            }
            public virtual string Notes { get; protected set; }
            // using the GetService<> extension method for obtaining service instance
            protected IDialogService DialogService {
                get { return this.GetService<IDialogService>(); }
            }
            public void EditNotes() {
                var dialogParams = new object[] { Notes };
                if(DialogService.ShowDialog(MessageButton.OKCancel, "Edit Notes", "EditNotes", dialogParams, this) == MessageResult.OK)
                    Notes = dialogParams[0] as string;
            }
        }
        [CodeExampleNestedClass]
        public class EditNotesViewModel : ISupportParameter {
            public virtual string Notes { get; set; }
            protected void OnNotesChanged() {
                parameters[0] = Notes;
            }
            object[] parameters;
            object ISupportParameter.Parameter {
                get { return parameters[0]; }
                set {
                    if(object.ReferenceEquals(parameters, value)) return;
                    parameters = (object[])value;
                    Notes = parameters[0] as string;
                }
            }
        }
        [CodeExampleNestedClass]
        [DevExpress.Utils.MVVM.UI.ViewType("EditNotes")]
        public class NotesEditor : XtraUserControl {
            public NotesEditor() {
                this.Padding = new Padding(12);
                this.MinimumSize = new System.Drawing.Size(320, 160);
                //
                MVVMContext mvvmContext = new MVVMContext();
                mvvmContext.ContainerControl = this;
                mvvmContext.ViewModelType = typeof(EditNotesViewModel);
                //
                MemoEdit memo = new MemoEdit();
                memo.Dock = DockStyle.Fill;
                memo.Parent = this;
                // Data-binding for Notes
                mvvmContext.SetBinding(memo, m => m.EditValue, "Notes");
            }
        }
    }

    [CodeExampleClass("Layout Serialization Service", "Services.cs")]
    [CodeExampleHighlightTokens("LayoutSerializationService", "ILayoutSerializationService")]
    [CodeExampleUnderlineTokens("Create", "Serialize", "Deserialize")]
    public static class LayoutService {
        static LayoutService() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton saveLayoutButton = new SimpleButton();
            saveLayoutButton.Text = "Save Layout";
            saveLayoutButton.Dock = DockStyle.Top;

            SimpleButton loadLayoutButton = new SimpleButton();
            loadLayoutButton.Text = "Load Layout";
            loadLayoutButton.Dock = DockStyle.Top;

            SplitContainerControl container = new SplitContainerControl();
            container.Dock = DockStyle.Top;
            container.Panel1.BackColor = System.Drawing.Color.LightGray;
            container.Panel2.BackColor = System.Drawing.Color.Beige;

            container.Parent = sampleHost;
            loadLayoutButton.Parent = sampleHost;
            saveLayoutButton.Parent = sampleHost;

            return new object[] { mvvmContext, saveLayoutButton, loadLayoutButton, container };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Save and Load Layout", new Type[] { typeof(LayoutViewModel) })]
        public static void LayoutSerialization(MVVMContext mvvmContext, SimpleButton saveLayoutButton, SimpleButton loadLayoutButton, SplitContainerControl container) {
            mvvmContext.ViewModelType = typeof(LayoutViewModel);
            // Use the LayoutSerializationService for SplitContainerControl
            mvvmContext.RegisterService(LayoutSerializationService.Create(container, true));
            // Binding commands to buttons
            mvvmContext.BindCommand<LayoutViewModel>(saveLayoutButton, x => x.SaveLayout());
            mvvmContext.BindCommand<LayoutViewModel>(loadLayoutButton, x => x.LoadLayout());
        }
        [CodeExampleNestedClass]
        public class LayoutViewModel {
            protected ILayoutSerializationService Service {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ILayoutSerializationService>(); }
            }
            protected string Layout { get; private set; }
            public void SaveLayout() {
                // Using the ILayoutSerializationService.Serialize method
                Layout = Service.Serialize();
            }
            public void LoadLayout() {
                // Using the ILayoutSerializationService.Deserialize method
                Service.Deserialize(Layout);
            }
        }
    }

    [CodeExampleClass("Notification Service", "Services.cs")]
    [CodeExampleHighlightTokens("NotificationService", "INotificationService", "INotification", "INotificationInfo")]
    [CodeExampleUnderlineTokens("Create", "ShowAsync", "Hide", "CreatePredefinedNotification", "CreateCustomNotification")]
    [CodeExampleVersionID(161)] 
    public static class NotificationServices {
        static NotificationServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton hideNotificationButton = new SimpleButton();
            hideNotificationButton.Text = "Hide Notification";
            hideNotificationButton.Dock = DockStyle.Top;
            hideNotificationButton.Parent = sampleHost;

            SimpleButton showNotificationButton = new SimpleButton();
            showNotificationButton.Text = "Show Notification";
            showNotificationButton.Dock = DockStyle.Top;
            showNotificationButton.Parent = sampleHost;

            AlertControl alertControl = new AlertControl();
            ToastNotificationsManager toastNotificationsManager1 = new ToastNotificationsManager();
            toastNotificationsManager1.ApplicationId = "Components" + AssemblyInfo.VirtDirSuffix + "_Demo_Center" + AssemblyInfo.VirtDirSuffix;
            toastNotificationsManager1.ApplicationName = "DevAV";

            return new object[] { mvvmContext, showNotificationButton, hideNotificationButton, toastNotificationsManager1, alertControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Predefined Notification(Toast Style)", new Type[] { typeof(HelloViewModel) })]
        public static void ToastNotificationStylePredefinedNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModel);
            // Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager));
            // Binding commands to buttons
            mvvmContext.BindCommand<HelloViewModel>(showNotificationButton, x => x.ShowNotification());
            mvvmContext.BindCommand<HelloViewModel>(hideNotificationButton, x => x.HideNotification());
        }
        [CodeExampleCase("Predefined Notification(Alert Style)", new Type[] { typeof(HelloViewModel) })]
        public static void AlertControlStylePredefinedNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModel);
            // Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl));
            // Binding commands to buttons
            mvvmContext.BindCommand<HelloViewModel>(showNotificationButton, x => x.ShowNotification());
            mvvmContext.BindCommand<HelloViewModel>(hideNotificationButton, x => x.HideNotification());
        }
        [CodeExampleCase("Custom Notification(Toast Style)", new Type[] { typeof(HelloViewModelWithINotificationInfo) })]
        public static void ToastNotificationStyleCustomNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModelWithINotificationInfo);
            // Use the ToastNotificationManager as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(toastNotificationManager));
            // Binding commands to buttons
            mvvmContext.BindCommand<HelloViewModelWithINotificationInfo>(showNotificationButton, x => x.ShowNotification());
            mvvmContext.BindCommand<HelloViewModelWithINotificationInfo>(hideNotificationButton, x => x.HideNotification());
        }
        [CodeExampleCase("Custom Notification(Alert Style)", new Type[] { typeof(HelloViewModelWithINotificationInfo) })]
        public static void AlertControlStyleCustomNotification(MVVMContext mvvmContext, SimpleButton showNotificationButton, SimpleButton hideNotificationButton, INotificationProvider toastNotificationManager, INotificationProvider alertControl) {
            mvvmContext.ViewModelType = typeof(HelloViewModelWithINotificationInfo);
            // Use the AlertControl as a NotificationService provider
            mvvmContext.RegisterService(NotificationService.Create(alertControl));
            // Binding commands to buttons
            mvvmContext.BindCommand<HelloViewModelWithINotificationInfo>(showNotificationButton, x => x.ShowNotification());
            mvvmContext.BindCommand<HelloViewModelWithINotificationInfo>(hideNotificationButton, x => x.HideNotification());
        }
        [CodeExampleNestedClass]
        public class HelloViewModel {
            protected INotificationService INotificationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INotificationService>(); }
            }
            public virtual INotification Notification {
                get;
                set;
            }
            protected virtual void OnNotificationChanged() {
                this.RaiseCanExecuteChanged(x => x.HideNotification());
            }
            List<INotification> notifications = new List<INotification>();
            public void ShowNotification() {
                // using the INotificationService.CreatePredefinedNotification method
                Notification = INotificationService.CreatePredefinedNotification("Hello, buddy!", "Have a nice day!", "Greeting");
                notifications.Add(Notification);
                // using the INotification.ShowAsync method
                Notification.ShowAsync();
            }
            public void HideNotification() {
                // using the INotification.Hide method
                Notification.Hide();
                if(notifications.Remove(Notification))
                    Notification = (notifications.Count == 0) ? null : notifications[notifications.Count - 1];
            }
            public bool CanHideNotification() {
                return Notification != null;
            }
        }
        [CodeExampleNestedClass]
        public class HelloViewModelWithINotificationInfo : INotificationInfo {
            protected INotificationService INotificationService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<INotificationService>(); }
            }
            public virtual INotification Notification {
                get;
                set;
            }
            protected virtual void OnNotificationChanged() {
                this.RaiseCanExecuteChanged(x => x.HideNotification());
            }
            List<INotification> notifications = new List<INotification>();
            public void ShowNotification() {
                // using the INotificationService.CreateCustomNotification method
                Notification = INotificationService.CreateCustomNotification(this);
                notifications.Add(Notification);
                // using the INotification.ShowAsync method
                Notification.ShowAsync();
            }
            public void HideNotification() {
                // using the INotification.Hide method
                Notification.Hide();
                if(notifications.Remove(Notification))
                    Notification = (notifications.Count == 0) ? null : notifications[notifications.Count - 1];
            }
            public bool CanHideNotification() {
                return Notification != null;
            }
            #region INotificationInfo
            string INotificationInfo.Header {
                get { return "Hello, buddy!"; }
            }
            string INotificationInfo.Body {
                get { return "Have a nice day!"; }
            }
            string INotificationInfo.Body2 {
                get { return "Greeting"; }
            }
            System.Drawing.Image INotificationInfo.Image {
                get { return null; }
            }
            #endregion
        }
    }

    [CodeExampleClass("SplashScreen Service", "Services.cs")]
    [CodeExampleHighlightTokens("ISplashScreenService", "SplashScreen", "DemoProgressSplashScreen", "CommandId")]
    [CodeExampleUnderlineTokens("Create", "ShowSplashScreen", "SetSplashScreenState", "HideSplashScreen")]
    [CodeExampleVersionID(161)] 
    public static class SplashScreenServices {
        static SplashScreenServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton hideSplashScreenButton = new SimpleButton();
            hideSplashScreenButton.Text = "Hide";
            hideSplashScreenButton.Dock = DockStyle.Top;
            hideSplashScreenButton.Parent = sampleHost;

            SimpleButton showSplashScreenButton = new SimpleButton();
            showSplashScreenButton.Text = "Show";
            showSplashScreenButton.Dock = DockStyle.Top;
            showSplashScreenButton.Parent = sampleHost;

            SplashScreenManager splashScreenManager = new SplashScreenManager();

            return new object[] { mvvmContext, showSplashScreenButton, hideSplashScreenButton, splashScreenManager };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Default SplashScreen", new Type[] { typeof(DefaultSplashScreenViewModel) })]
        public static void ShowDefaultSplashScreen(MVVMContext mvvmContext, SimpleButton showSplashScreenButton, SimpleButton hideSplashScreenButton, SplashScreenManager splashScreenManager) {
            hideSplashScreenButton.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(DefaultSplashScreenViewModel);
            // UI binding for button
            mvvmContext.BindCommand<DefaultSplashScreenViewModel>(showSplashScreenButton, x => x.Show());
        }
        [CodeExampleCase("Custom SplashScreen", new Type[] { typeof(CustomSplashScreenViewModel), typeof(CustomSplashScreen) })]
        public static void ShowCustomSplashScreen(MVVMContext mvvmContext, SimpleButton showSplashScreenButton, SimpleButton hideSplashScreenButton, SplashScreenManager splashScreenManager) {
            mvvmContext.ViewModelType = typeof(CustomSplashScreenViewModel);
            // SplashScreenManager setup
            splashScreenManager.Properties.UseFadeInEffect = false;
            splashScreenManager.Properties.UseFadeOutEffect = false;
            // Use the SplashScreenManager as a SplashScreenService provider
            mvvmContext.RegisterService(SplashScreenService.Create(splashScreenManager));
            // UI binding for buttons
            mvvmContext.BindCommand<CustomSplashScreenViewModel>(showSplashScreenButton, x => x.Show());
            mvvmContext.BindCommand<CustomSplashScreenViewModel>(hideSplashScreenButton, x => x.Hide());
        }

        [CodeExampleNestedClass]
        public class DefaultSplashScreenViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public void Show() {
                // Using the ISplashScreenService.ShowSplashScreen method with null parameters that show default SplashScreen
                SplashScreenService.ShowSplashScreen(null);
                // Using the ISplashScreenService.SetSplashScreenState
                SplashScreenService.SetSplashScreenState("Loading...");
                int maxProgress = 10000;
                for(int i = 1; i <= maxProgress; i++) {
                    // using the ISplashScreenService.SetSplashScreenProgress
                    SplashScreenService.SetSplashScreenProgress(i, maxProgress);
                }
                Hide();
            }
            public void Hide() {
                // Using the ISplashScreenService.HideSplashScreen method
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class CustomSplashScreenViewModel {
            protected ISplashScreenService SplashScreenService {
                // Using the GetService<> extension method to obtain the service instance
                get { return this.GetService<ISplashScreenService>(); }
            }
            public void Show() {
                // Showing the splash screen
                SplashScreenService.ShowSplashScreen("CustomSplashScreen");
                // Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Hello, buddy! Have a nice day!");
            }
            public void Hide() {
                // Setting the splash screen message
                SplashScreenService.SetSplashScreenState("Bye!");
                System.Threading.Thread.Sleep(1000);
                // Hiding the splash screen
                SplashScreenService.HideSplashScreen();
            }
        }
        [CodeExampleNestedClass]
        public class CustomSplashScreen : SplashScreen {
            public CustomSplashScreen()
                : base() {
                stateLabel = new Label();
                stateLabel.Text = "State";
                stateLabel.AutoSize = false;
                stateLabel.Dock = DockStyle.Fill;
                stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.Controls.Add(stateLabel);
            }
            Label stateLabel;
            public override void ProcessCommand(Enum cmd, object arg) {
                base.ProcessCommand(cmd, arg);
                DemoProgressSplashScreen.CommandId command = (DemoProgressSplashScreen.CommandId)cmd;
                if(command == DemoProgressSplashScreen.CommandId.MVVMSetState)
                    stateLabel.Text = (string)arg;
            }
        }
    }

    [CodeExampleClass("Open/Save File Dialog Services", "Services.cs")]
    [CodeExampleHighlightTokens("IOpenFileDialogService", "ISaveFileDialogService")]
    [CodeExampleUnderlineTokens("ShowDialog")]
    [CodeExampleVersionID(161)] 
    public static class FileDialogServices {
        static FileDialogServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            MemoEdit logMemoEdit = new MemoEdit();
            logMemoEdit.ReadOnly = true;
            logMemoEdit.Dock = DockStyle.Fill;
            logMemoEdit.Parent = sampleHost;

            SimpleButton showDialogButton = new SimpleButton();
            showDialogButton.Text = "Show Dialog";
            showDialogButton.Dock = DockStyle.Top;
            showDialogButton.Parent = sampleHost;

            return new object[] { mvvmContext, showDialogButton, logMemoEdit };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Open File Dialog Service", new Type[] { typeof(OpenFileDialogViewModel) })]
        public static void ShowOpenFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(OpenFileDialogViewModel);
            var fluentApi = mvvmContext.OfType<OpenFileDialogViewModel>();
            // UI binding for memoEdit
            fluentApi.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluentApi.BindCommand(showDialogButton, x => x.ShowFileDialog());
        }
        [CodeExampleCase("Save File Dialog Service", new Type[] { typeof(SaveFileDialogViewModel) })]
        public static void ShowSaveFileDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(SaveFileDialogViewModel);
            var fluentApi = mvvmContext.OfType<SaveFileDialogViewModel>();
            // UI binding for memoEdit
            fluentApi.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluentApi.BindCommand(showDialogButton, x => x.ShowFileDialog());
        }

        [CodeExampleNestedClass]
        public class OpenFileDialogViewModel {
            public OpenFileDialogViewModel() {
                // Set IOpenFileDialogService settings
                this.Title = "Open File Dialog";
                this.Filter = "All Files|*.*|Text|*.txt";
                this.FilterIndex = 2;
            }
            protected IOpenFileDialogService OpenFileDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IOpenFileDialogService>(); }
            }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFileDialog() {
                // Using the IOpenFileDialogService.ShowDialog method
                if(this.OpenFileDialogService.ShowDialog(DialogFileOKCallback, string.Empty))
                    AppendLogString("Open file: " + this.OpenFileDialogService.File.Name);
                else
                    AppendLogString("Cancel");
            }
            public virtual string Log { get; protected set; }
            public virtual string Filter { get; protected set; }
            protected virtual void OnFilterChanged() {
                this.OpenFileDialogService.Filter = this.Filter;
                AppendLogString("Set Filter: " + this.Filter);
            }
            public virtual int FilterIndex { get; protected set; }
            protected virtual void OnFilterIndexChanged() {
                this.OpenFileDialogService.FilterIndex = this.FilterIndex;
                AppendLogString("Set FilterIndex: " + this.FilterIndex.ToString());
            }
            public virtual string Title { get; protected set; }
            protected virtual void OnTitleChanged() {
                this.OpenFileDialogService.Title = this.Title;
                AppendLogString("Set Title: " + this.Title);
            }
            protected virtual void DialogFileOKCallback(System.ComponentModel.CancelEventArgs e) {
                MessageBox.Show("File is opened");
            }
        }
        [CodeExampleNestedClass]
        public class SaveFileDialogViewModel {
            public SaveFileDialogViewModel() {
                // Set ISaveFileDialogService settings
                this.Title = "Save File Dialog";
                this.Filter = "Text|*.txt";
            }
            protected ISaveFileDialogService SaveFileDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<ISaveFileDialogService>(); }
            }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFileDialog() {
                // Using the ISaveFileDialogService.ShowDialog method
                if(this.SaveFileDialogService.ShowDialog(DialogFileOKCallback, string.Empty, string.Empty))
                    AppendLogString("Save file: " + this.SaveFileDialogService.File.Name);
                else
                    AppendLogString("Cancel");
            }
            public virtual string Log { get; protected set; }
            public virtual string Filter { get; protected set; }
            protected virtual void OnFilterChanged() {
                this.SaveFileDialogService.Filter = this.Filter;
                AppendLogString("Set Filter: " + this.Filter);
            }
            public virtual int FilterIndex { get; protected set; }
            protected virtual void OnFilterIndexChanged() {
                this.SaveFileDialogService.FilterIndex = this.FilterIndex;
                AppendLogString("Set FilterIndex: " + this.FilterIndex.ToString());
            }
            public virtual string Title { get; protected set; }
            protected virtual void OnTitleChanged() {
                this.SaveFileDialogService.Title = this.Title;
                AppendLogString("Set Title: " + this.Title);
            }
            protected virtual void DialogFileOKCallback(System.ComponentModel.CancelEventArgs e) {
                MessageBox.Show("File is saved");
            }
        }
    }

    [CodeExampleClass("FolderBrowser Dialog Service", "Services.cs")]
    [CodeExampleHighlightTokens("IFolderBrowserDialogService", "Environment")]
    [CodeExampleUnderlineTokens("ShowDialog")]
    [CodeExampleVersionID(161)] 
    public static class FolderBrowserDialogService {
        static FolderBrowserDialogService() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            MemoEdit logMemoEdit = new MemoEdit();
            logMemoEdit.ReadOnly = true;
            logMemoEdit.Dock = DockStyle.Fill;
            logMemoEdit.Parent = sampleHost;

            SimpleButton showDialogButton = new SimpleButton();
            showDialogButton.Text = "Show Dialog";
            showDialogButton.Dock = DockStyle.Top;
            showDialogButton.Parent = sampleHost;

            return new object[] { mvvmContext, showDialogButton, logMemoEdit };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Folder Browser Dialog Service", new Type[] { typeof(FolderBrowserDialogViewModel) })]
        public static void ShowFolderBrowserDialog(MVVMContext mvvmContext, SimpleButton showDialogButton, MemoEdit logMemoEdit) {
            mvvmContext.ViewModelType = typeof(FolderBrowserDialogViewModel);
            var fluentApi = mvvmContext.OfType<FolderBrowserDialogViewModel>();
            // UI binding for memoEdit
            fluentApi.SetBinding(logMemoEdit, le => le.Text, x => x.Log);
            // UI binding for button
            fluentApi.BindCommand(showDialogButton, x => x.ShowFolderDialog());
        }

        [CodeExampleNestedClass]
        public class FolderBrowserDialogViewModel {
            protected IFolderBrowserDialogService FolderBrowserDialogService {
                // using the GetService<> extension method for obtaining service instance
                get { return this.GetService<IFolderBrowserDialogService>(); }
            }
            public virtual string Log { get; protected set; }
            protected virtual void AppendLogString(string str) {
                // Update log
                Log += str + Environment.NewLine;
            }
            public void ShowFolderDialog() {
                if(this.FolderBrowserDialogService.ShowDialog())
                    AppendLogString("Folder path: " + this.FolderBrowserDialogService.ResultPath);
                else
                    AppendLogString("Cancel");
            }
        }
    }

    [CodeExampleClass("Custom Services", "Services.cs")]
    [CodeExampleHighlightTokens("CustomService", "ICustomService", "ServiceProperty")]
    [CodeExampleUnderlineTokens("RegisterService")]
    public static class CustomServices {
        static CustomServices() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Custom Service", new Type[] { typeof(ViewModelWithCustomService), typeof(ICustomService), typeof(CustomService) })]
        public static void UseCustomService(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithCustomService);
            // Custom service registration
            mvvmContext.RegisterService(new CustomService());
            // UI binding for button
            mvvmContext.BindCommand<ViewModelWithCustomService>(commandButton, x => x.DoSomethingViaCustomService());
        }
        [CodeExampleCase("Custom Service with Key", new Type[] { typeof(ViewModelWithKeyedCustomService), typeof(ICustomService), typeof(CustomService) })]
        public static void UseCustomServiceWithKey(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithKeyedCustomService);
            // Custom service registration
            mvvmContext.RegisterService("SomeKey1", new CustomService("Custom Service 1"));
            mvvmContext.RegisterService("SomeKey2", new CustomService("Custom Service 2"));
            // UI binding for button
            mvvmContext.BindCommand<ViewModelWithKeyedCustomService>(commandButton, x => x.DoSomethingViaCustomServices());
        }

        [CodeExampleNestedClass]
        public interface ICustomService {
            void DoSomething();
        }
        [CodeExampleNestedClass]
        public class CustomService : ICustomService {
            string text;
            public CustomService(string text = null) {
                this.text = text;
            }
            public void DoSomething() {
                XtraMessageBox.Show("Hi!", text ?? "CustomService");
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithCustomService {
            public void DoSomethingViaCustomService() {
                this.GetService<ICustomService>().DoSomething();
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithKeyedCustomService {
            [DevExpress.Mvvm.DataAnnotations.ServiceProperty(Key = "SomeKey1")]
            protected virtual ICustomService CustomService1 {
                get { throw new NotImplementedException(); }
            }
            [DevExpress.Mvvm.DataAnnotations.ServiceProperty(Key = "SomeKey2")]
            protected virtual ICustomService CustomService2 {
                get { throw new NotImplementedException(); }
            }
            public void DoSomethingViaCustomServices() {
                CustomService1.DoSomething();
                CustomService2.DoSomething();
            }
        }
    }
}
