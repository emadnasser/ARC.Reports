using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("Delegate Commands", "Commanding.cs")]
    [CodeExampleHighlightTokens("DelegateCommand", "Func")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class DelegateCommands {
        static DelegateCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { commandButton };
        }
        [CodeExampleCase("Simple Command")]
        public static void SimpleCommand(SimpleButton commandButton) {
            // This is simple command that shows a message
            DelegateCommand command = new DelegateCommand(() => {
                XtraMessageBox.Show("Hello! I'm running!");
            });
            // UI binding for button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Command with CanExecute condition")]
        public static void CommandWithCanExecuteCondition(SimpleButton commandButton) {
            Func<bool> canExecute = () => (2 + 2 == 4);
            // This command is created with the `canExecute` parameter.
            DelegateCommand command = new DelegateCommand(() => {
                XtraMessageBox.Show("Hello! I'm running, because the `canExecute` condition is `True`. Try to change this condition!");
            }, canExecute);
            // UI binding for the button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Parameterized Command")]
        public static void ParameterizedCommand(SimpleButton commandButton) {
            // This command is created as parameterized.
            DelegateCommand<object> command = new DelegateCommand<object>((v) => {
                XtraMessageBox.Show(string.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", v));
            });
            //
            object parameter = 5;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
        [CodeExampleCase("Parameterized Command with CanExecute condition")]
        public static void ParameterizedCommandWithCanExecuteCondition(SimpleButton commandButton) {
            Func<int, bool> canExecute = (p) => (2 + 2 == p);
            // This command is created as parameterized and with `canExecute` parameter.
            DelegateCommand<int> command = new DelegateCommand<int>((v) => {
                XtraMessageBox.Show(string.Format(
                    "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                    "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", v));
            }, canExecute);
            //
            int parameter = 4;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
    }

    [CodeExampleClass("POCO Commands", "Commanding.cs")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class POCOCommands {
        static POCOCommands() {
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
            if (context != null) context.Dispose();
        }
        [CodeExampleCase("Simple Command", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void SimpleCommand(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            // UI binding for the button
            mvvmContext.BindCommand<ViewModelWithSimpleCommand>(commandButton, x => x.DoSomething());
        }
        [CodeExampleCase("Command with CanExecute condition", new Type[] { typeof(ViewModelWithConditionalCommand) })]
        public static void CommandWithCanExecuteCondition(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithConditionalCommand);
            // UI binding for the button
            mvvmContext.BindCommand<ViewModelWithConditionalCommand>(commandButton, x => x.DoSomething());
        }
        [CodeExampleCase("Parameterized Command", new Type[] { typeof(ViewModelWithParametrizedCommand) })]
        public static void ParameterizedCommand(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithParametrizedCommand);
            //
            object parameter = 5;
            // Binding the button to the parameterized command
            mvvmContext.BindCommand<ViewModelWithParametrizedCommand, object>(commandButton, (x, p) => x.DoSomething(p), x => parameter);
        }
        [CodeExampleCase("Parameterized Command with CanExecute condition", new Type[] { typeof(ViewModelWithParametrizedConditionalCommand) })]
        public static void ParameterizedCommandWithCanExecuteCondition(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithParametrizedConditionalCommand);
            //
            int parameter = 4;
            // Binding the button to the parameterized command
            mvvmContext.BindCommand<ViewModelWithParametrizedConditionalCommand, int>(commandButton, (x, p) => x.DoSomething(p), x => parameter);
        }
        [CodeExampleCase("Fluent API for commands", new Type[] { typeof(ViewModelWithParametrizedConditionalCommand) })]
        public static void ParameterizedCommandWithCanExecuteConditionFluentAPI(MVVMContext mvvmContext, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithParametrizedConditionalCommand);
            //
            int parameter = 4;
            // UI binding for button with the `queryParameter` function
            var fluentAPI = mvvmContext.OfType<ViewModelWithParametrizedConditionalCommand>();
            fluentAPI.BindCommand(commandButton, (x, p) => x.DoSomething(p), x => parameter);
        }

        [CodeExampleNestedClass("POCO View Model with simple command")]
        public class ViewModelWithSimpleCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                XtraMessageBox.Show("Hello! I'm running!");
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that depends on specific condition")]
        public class ViewModelWithConditionalCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                XtraMessageBox.Show("Hello! I'm running, because the `canExecute` condition is `True`.");
            }
            // The `CanExecute` method for the `SayHello` command.
            public bool CanDoSomething() {
                return (2 + 2) == 4;
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that has a parameter")]
        public class ViewModelWithParametrizedCommand {
            // A parameterized POCO-command will be created from this method.
            public void DoSomething(object p) {
                XtraMessageBox.Show(string.Format("Hello! The parameter passed to command is {0}. Try to change this parameter!", p));
            }
        }
        [CodeExampleNestedClass("POCO View Model with command that has a parameter and depends on specific condition")]
        public class ViewModelWithParametrizedConditionalCommand {
            // A parameterized POCO-command will be created from this method.
            public void DoSomething(int p) {
                XtraMessageBox.Show(string.Format(
                    "Hello! The parameter passed to command is {0}." + Environment.NewLine +
                    "And I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", p));
            }
            // A parameterized `CanExecute` method for the `Say` command.
            public bool CanDoSomething(int p) {
                return (2 + 2) == p;
            }
        }
    }

    [CodeExampleClass("POCO Asynchronous Commands", "Commanding.cs")]
    [CodeExampleHighlightTokens("Task", "IDispatcherService")]
    [CodeExampleUnderlineTokens("BindCommand", "BindCancelCommand", "GetAsyncCommand", "BeginInvoke")]
    public static class POCOAsyncCommands {
        static POCOAsyncCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            ProgressBarControl progressBar = new ProgressBarControl();
            progressBar.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Start Command Execution";
            commandButton.Dock = DockStyle.Top;

            SimpleButton cancelButton = new SimpleButton();
            cancelButton.Text = "Cancel Command Execution";
            cancelButton.Dock = DockStyle.Top;

            cancelButton.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            progressBar.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton, cancelButton, progressBar };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if (context != null) context.Dispose();
        }
        [CodeExampleCase("Simple Command", new Type[] { typeof(ViewModelWithAsyncCommand) })]
        public static void SimpleCommand(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            cancelButton.Visible = false;
            progressBar.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommand);
            // UI binding for the button
            mvvmContext.BindCommand<ViewModelWithAsyncCommand>(commandButton, x => x.DoSomethingAsynchronously());
        }
        [CodeExampleCase("Simple Command with Cancellation", new Type[] { typeof(ViewModelWithAsyncCommandAndCancellation) })]
        public static void SimpleCommandWithCancellation(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommandAndCancellation);
            // UI binding for the button
            mvvmContext.BindCommand<ViewModelWithAsyncCommandAndCancellation>(commandButton, x => x.DoSomethingAsynchronously());
            // UI binding for cancelation
            mvvmContext.BindCancelCommand<ViewModelWithAsyncCommandAndCancellation>(cancelButton, x => x.DoSomethingAsynchronously());
            // UI binding for progress
            mvvmContext.SetBinding(progressBar, p => p.EditValue, "Progress");
        }
        [CodeExampleCase("Fluent API for commands", new Type[] { typeof(ViewModelWithAsyncCommandAndCancellation) })]
        public static void SimpleCommandWithCancellationFluentAPI(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommandAndCancellation);
            var fluentAPI = mvvmContext.OfType<ViewModelWithAsyncCommandAndCancellation>();
            // UI binding for the button
            fluentAPI.BindCommand(commandButton, x => x.DoSomethingAsynchronously());
            // UI binding for cancelation
            fluentAPI.BindCancelCommand(cancelButton, x => x.DoSomethingAsynchronously());
            // UI binding for progress
            fluentAPI.SetBinding(progressBar, p => p.EditValue, x => x.Progress);
        }

        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommand {
            // An asynchronous POCO-command will be created from this method.
            public Task DoSomethingAsynchronously() {
                return Task.Factory.StartNew(() => {
                    System.Threading.Thread.Sleep(1000); // do some work here
                });
            }
        }
        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommandAndCancellation {
            // An asynchronous POCO-command will be created from this method.
            public Task DoSomethingAsynchronously() {
                return Task.Factory.StartNew(() => {
                    var asyncCommand = this.GetAsyncCommand(x => x.DoSomethingAsynchronously());
                    for (int i = 0; i <= 100; i++) {
                        if (asyncCommand.IsCancellationRequested) // cancellation check
                            break;
                        System.Threading.Thread.Sleep(25); // do some work here
                        UpdateProgressOnUIThread(i);
                    }
                    UpdateProgressOnUIThread(0);
                });
            }
            // Property for progress
            public int Progress { get; private set; }
            protected IDispatcherService DispatcherService {
                get { return this.GetService<IDispatcherService>(); }
            }
            void UpdateProgressOnUIThread(int progress) {
                DispatcherService.BeginInvoke(() => {
                    Progress = progress;
                    this.RaisePropertyChanged(x => x.Progress);
                });
            }
        }
    }

    [CodeExampleClass("Legacy Commands", "Commanding.cs")]
    [CodeExampleUnderlineTokens("BindCommand")]
    public static class LegacyCommands {
        static LegacyCommands() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;
            return new object[] { commandButton };
        }
        [CodeExampleCase("Simple Command", new Type[] { typeof(LegacyCommand) })]
        public static void SimpleLegacyCommand(SimpleButton commandButton) {
            // This is simple legacy-command. It provides the Execute method for doing something.
            LegacyCommand command = new LegacyCommand();
            // UI binding for the button
            commandButton.BindCommand(command);
        }
        [CodeExampleCase("Parameterized Command", new Type[] { typeof(LegacyCommandWithParameter) })]
        public static void ParameterizedCommandWithCanExecuteCondition(SimpleButton commandButton) {
            // This is legacy-command with both Execute(object) and CanExecute(object) methods.
            LegacyCommandWithParameter command = new LegacyCommandWithParameter();
            int parameter = 4;
            // UI binding for button with the `queryParameter` function
            commandButton.BindCommand(command, () => parameter);
        }
        [CodeExampleNestedClass]
        public class LegacyCommand {
            public void Execute(object parameter) {
                XtraMessageBox.Show("Hello! I'm  Legacy command and I'm running!");
            }
        }
        [CodeExampleNestedClass]
        public class LegacyCommandWithParameter {
            public void Execute(object parameter) {
                XtraMessageBox.Show(string.Format(
                    "Hello! I'm  Legacy command and the parameter passed to me is {0}." + Environment.NewLine +
                    "I'm running, because the `canExecute` condition is `True` for this parameter." + Environment.NewLine +
                    "Try to change this parameter!", parameter));
            }
            public bool CanExecute(object parameter) {
                return object.Equals(2 + 2, parameter);
            }
        }
    }

    [CodeExampleClass("The WithCommand extension", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("WithCommand", "Bind")]
    public static class WithCommandExtention {
        static WithCommandExtention() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton commandButton2 = new SimpleButton();
            commandButton2.Text = "Execute Command 2";
            commandButton2.Dock = DockStyle.Top;
            commandButton2.Parent = sampleHost;
            commandButton2.Visible = false;

            SimpleButton commandButton1 = new SimpleButton();
            commandButton1.Text = "Execute Command 1";
            commandButton1.Dock = DockStyle.Top;
            commandButton1.Parent = sampleHost;

            return new object[] { mvvmContext, commandButton1, commandButton2 };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if (context != null) context.Dispose();
        }
        [CodeExampleCase("Binding to one UI element", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BindingToOneElement(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            var fluentAPI = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // UI binding for a single button
            fluentAPI.WithCommand(x => x.DoSomething())
                .Bind(commandButton1);
        }
        [CodeExampleCase("Binding to multiple UI elements", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BindingToMultipleElement(MVVMContext mvvmContext, SimpleButton commandButton1, SimpleButton commandButton2) {
            commandButton2.Visible = true;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            var fluentAPI = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            // Binding two different buttons to the same command
            fluentAPI.WithCommand(x => x.DoSomething())
                .Bind(commandButton1)
                .Bind(commandButton2);
        }
        [CodeExampleNestedClass("POCO View Model with simple command")]
        public class ViewModelWithSimpleCommand {
            // A POCO-command will be created from this method.
            public void DoSomething() {
                XtraMessageBox.Show("Hello! I'm running!");
            }
        }
    }

    [CodeExampleClass("The WithCommand extension for asynchronous commands", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleHighlightTokens("Task", "IDispatcherService")]
    [CodeExampleUnderlineTokens("WithCommand", "Bind", "BindCancel")]
    public static class WithCommandExtentionAsync {
        static WithCommandExtentionAsync() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            ProgressBarControl progressBar = new ProgressBarControl();
            progressBar.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Start Command Execution";
            commandButton.Dock = DockStyle.Top;

            SimpleButton cancelButton = new SimpleButton();
            cancelButton.Text = "Cancel Command Execution";
            cancelButton.Dock = DockStyle.Top;

            cancelButton.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            progressBar.Parent = sampleHost;
            return new object[] { mvvmContext, commandButton, cancelButton, progressBar };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if (context != null) context.Dispose();
        }
        [CodeExampleCase("Binding to an asynchronous command", new Type[] { typeof(ViewModelWithAsyncCommandAndCancellation) })]
        public static void BindingToAsynchronousCommand(MVVMContext mvvmContext, SimpleButton commandButton, SimpleButton cancelButton, ProgressBarControl progressBar) {
            mvvmContext.ViewModelType = typeof(ViewModelWithAsyncCommandAndCancellation);
            var fluentAPI = mvvmContext.OfType<ViewModelWithAsyncCommandAndCancellation>();
            // UI binding for buttons
            fluentAPI.WithCommand(x => x.DoSomethingAsynchronously())
                .Bind(commandButton)
                .BindCancel(cancelButton);
            // UI binding for progress
            fluentAPI.SetBinding(progressBar, p => p.EditValue, x => x.Progress);
        }
        [CodeExampleNestedClass]
        public class ViewModelWithAsyncCommandAndCancellation {
            // An asynchronous POCO-command will be created from this method.
            public Task DoSomethingAsynchronously() {
                return Task.Factory.StartNew(() => {
                    var asyncCommand = this.GetAsyncCommand(x => x.DoSomethingAsynchronously());
                    for (int i = 0; i <= 100; i++) {
                        if (asyncCommand.IsCancellationRequested) // cancellation check
                            break;
                        System.Threading.Thread.Sleep(25); // do some work here
                        UpdateProgressOnUIThread(i);
                    }
                    UpdateProgressOnUIThread(0);
                });
            }
            // Property for progress
            public int Progress { get; private set; }
            protected IDispatcherService DispatcherService {
                get { return this.GetService<IDispatcherService>(); }
            }
            void UpdateProgressOnUIThread(int progress) {
                DispatcherService.BeginInvoke(() => {
                    Progress = progress;
                    this.RaisePropertyChanged(x => x.Progress);
                });
            }
        }
    }

    [CodeExampleClass("Command triggers", "Commanding.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("WithCommand", "After", "Before", "OnCanExecuteChanged")]
    public static class CommandTriggers {
        static CommandTriggers() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            CheckEdit triggerCheckEdit = new CheckEdit();
            triggerCheckEdit.Dock = DockStyle.Top;
            triggerCheckEdit.Text = "Allow execute";
            triggerCheckEdit.Parent = sampleHost;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Text = "Execute Command";
            commandButton.Dock = DockStyle.Top;
            commandButton.Parent = sampleHost;

            return new object[] { mvvmContext, triggerCheckEdit, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if (context != null) context.Dispose();
        }
        [CodeExampleCase("A follow-up command", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void AfterCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            triggerCheckEdit.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            var fluentAPI = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            fluentAPI.BindCommand(commandButton, x => x.DoSomething());
            // After the target comand executes, the message shows up
            fluentAPI.WithCommand(x => x.DoSomething())
                .After(() => XtraMessageBox.Show("The target command has been executed"));
        }
        [CodeExampleCase("A prelude command", new Type[] { typeof(ViewModelWithSimpleCommand) })]
        public static void BeforeCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            triggerCheckEdit.Visible = false;
            //
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommand);
            var fluentAPI = mvvmContext.OfType<ViewModelWithSimpleCommand>();
            fluentAPI.BindCommand(commandButton, x => x.DoSomething());
            // Before the target comand executes, the message shows up
            fluentAPI.WithCommand(x => x.DoSomething())
                .Before(() => XtraMessageBox.Show("The target command is about to be executed"));
        }
        [CodeExampleCase("A trigger for the CanExecute condition", new Type[] { typeof(ViewModelWithSimpleCommandAndCanExecute) })]
        public static void OnCanExecuteCommandTrigger(MVVMContext mvvmContext, CheckEdit triggerCheckEdit, SimpleButton commandButton) {
            mvvmContext.ViewModelType = typeof(ViewModelWithSimpleCommandAndCanExecute);
            var fluentAPI = mvvmContext.OfType<ViewModelWithSimpleCommandAndCanExecute>();
            fluentAPI.BindCommand(commandButton, x => x.DoSomething());
            fluentAPI.SetBinding(triggerCheckEdit, e => e.Checked, x => x.AllowExecute);
            // When the CanExecute condition changes, the message shows up
            fluentAPI.WithCommand(x => x.DoSomething())
                .OnCanExecuteChanged(() => XtraMessageBox.Show("The CanExecute condition has changed"));
        }
        [CodeExampleNestedClass("POCO View Model with a simple command")]
        public class ViewModelWithSimpleCommand {
            public void DoSomething() {
                XtraMessageBox.Show("Hello! I'm running!");
            }
        }
        [CodeExampleNestedClass("POCO View Model with a simple command and the CanExecute condition")]
        public class ViewModelWithSimpleCommandAndCanExecute {
            public virtual bool AllowExecute {
                get;
                set;
            }
            public ViewModelWithSimpleCommandAndCanExecute() {
                AllowExecute = true;
            }
            protected void OnAllowExecuteChanged() {
                this.RaiseCanExecuteChanged(x => x.DoSomething());
            }
            public bool CanDoSomething() {
                return AllowExecute;
            }
            public void DoSomething() {
                XtraMessageBox.Show("Hello! I'm running!");
            }
        }
    }
}
