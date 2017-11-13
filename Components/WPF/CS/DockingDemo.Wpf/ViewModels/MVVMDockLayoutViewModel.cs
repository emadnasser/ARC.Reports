using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Docking;
using Microsoft.Win32;

namespace DockingDemo.ViewModels {
    public abstract class ViewModel : IDisposable {
        protected ViewModel() {
        }
        public virtual string DisplayName { get; protected set; }
        public virtual ImageSource Glyph { get; set; }
        #region IDisposable Members
        public void Dispose() {
            OnDispose();
        }
        protected virtual void OnDispose() { }
#if DEBUG
        ~ViewModel() {
            string msg = string.Format("{0} ({1}) ({2}) Finalized", GetType().Name, DisplayName, GetHashCode());
            System.Diagnostics.Debug.WriteLine(msg);
        }
#endif
        #endregion //IDisposable Members
    }
    public abstract class WorkspaceViewModel : ViewModel {
        protected WorkspaceViewModel() {
            IsClosed = true;
        }

        public event EventHandler RequestClose;

        public virtual bool IsActive { get; set; }
        [BindableProperty(OnPropertyChangedMethodName = "OnIsClosedChanged")]
        public virtual bool IsClosed { get; set; }
        public virtual bool IsOpened { get; set; }

        public void Close() {
            EventHandler handler = RequestClose;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        protected virtual void OnIsClosedChanged() {
            IsOpened = !IsClosed;
        }
    }
    public class CommandViewModel : ViewModel {
        public CommandViewModel() { }
        public CommandViewModel(string displayName, List<CommandViewModel> subCommands)
            : this(displayName, null, null, subCommands) {
        }
        public CommandViewModel(string displayName, ICommand command = null)
            : this(displayName, null, command, null) {
        }
        public CommandViewModel(WorkspaceViewModel owner, ICommand command)
            : this(string.Empty, owner, command) {
        }
        private CommandViewModel(string displayName, WorkspaceViewModel owner = null, ICommand command = null, List<CommandViewModel> subCommands = null) {
            IsEnabled = true;
            Owner = owner;
            if(Owner != null) {
                DisplayName = Owner.DisplayName;
                Glyph = Owner.Glyph;
            } else DisplayName = displayName;
            Command = command;
            Commands = subCommands;
        }

        public ICommand Command { get; private set; }
        public List<CommandViewModel> Commands { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsSeparator { get; set; }
        public bool IsSubItem { get; set; }
        public KeyGesture KeyGesture { get; set; }
        public WorkspaceViewModel Owner { get; private set; }
    }
    abstract public class PanelWorkspaceViewModel : WorkspaceViewModel, IMVVMDockingProperties {
        protected PanelWorkspaceViewModel() {
            ((IMVVMDockingProperties)this).TargetName = WorkspaceName;
        }
        protected PanelWorkspaceViewModel(bool supportPinnedState) {
            ShowPinButton = supportPinnedState;
        }

        public virtual bool IsPreview { get; set; }
        [BindableProperty(OnPropertyChangedMethodName = "OnPinnedChanged")]
        public virtual bool Pinned { get; set; }
        public virtual bool ShowPinButton { get; set; }
        abstract protected string WorkspaceName { get; }
        string IMVVMDockingProperties.TargetName { get; set; }
        public virtual bool Open() { return false; }
        protected void OnPinnedChanged() {
            if(IsPreview) {
                IsPreview = false;
            }
        }
    }
    public class ToolboxViewModel : PanelWorkspaceViewModel {
        public ToolboxViewModel() {
            DisplayName = "Toolbox";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/Toolbox_16x16.png", UriKind.Relative));
        }

        protected override string WorkspaceName { get { return "Toolbox"; } }
    }
    public class SolutionExplorerViewModel : PanelWorkspaceViewModel {
        public SolutionExplorerViewModel() {
            DisplayName = "Solution Explorer";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/Solution Explorer.png", UriKind.Relative));
        }

        public Solution Solution { get; set; }
        protected override string WorkspaceName { get { return "RightHost"; } }
    }
    public class PropertiesViewModel : PanelWorkspaceViewModel {
        public PropertiesViewModel() {
            DisplayName = "Properties";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/PropertiesWindow_16x16.png", UriKind.Relative));
        }

        protected override string WorkspaceName { get { return "RightHost"; } }
    }
    public class ErrorListViewModel : PanelWorkspaceViewModel {
        public ErrorListViewModel() {
            DisplayName = "Error List";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/TaskList_16x16.png", UriKind.Relative));
        }

        protected override string WorkspaceName { get { return "BottomHost"; } }
    }
    public class SearchResultsViewModel : PanelWorkspaceViewModel {
        public SearchResultsViewModel() {
            DisplayName = "Search Results";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/FindInFiles_16x16.png", UriKind.Relative));
        }

        protected override string WorkspaceName { get { return "BottomHost"; } }
    }
    public class OutputViewModel : PanelWorkspaceViewModel {
        public OutputViewModel() {
            DisplayName = "Output";
            Glyph = new BitmapImage(new Uri("/DockingDemo;component/Images/VS2010Docking/Output_16x16.png", UriKind.Relative));
        }

        protected override string WorkspaceName { get { return "BottomHost"; } }
    }
    public class DocumentViewModel : PanelWorkspaceViewModel {
        public DocumentViewModel() {
            IsClosed = false;
        }
        public DocumentViewModel(string displayName, string text) : this() {
            DisplayName = displayName;
            Text = text;
        }

        public string Description { get; protected set; }
        public string Footer { get; protected set; }
        public string Text { get; protected set; }
        protected override string WorkspaceName { get { return "DocumentHost"; } }

        public override bool Open() {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            bool? dialogResult = openFileDialog1.ShowDialog();
            bool dialogResultOK = dialogResult.HasValue && dialogResult.Value;
            if(dialogResultOK) {
                DisplayName = openFileDialog1.SafeFileName;
                System.IO.Stream fileStream = File.OpenRead(openFileDialog1.FileName);
                using(System.IO.StreamReader reader = new System.IO.StreamReader(fileStream)) {
                    Text = reader.ReadToEnd();
                }
                fileStream.Close();
            }
            return dialogResultOK;
        }
    }
    public class BarModel : ViewModel {
        private IList<object> _Commands;

        public BarModel() {
            _Commands = new ObservableCollection<object>();
        }
        public BarModel(string displayName)
            : this() {
            DisplayName = displayName;
        }

        public IList<object> Commands {
            get { return _Commands; }
        }
        public bool IsMainMenu { get; set; }
    }
    public class MainWindowViewModel {
        ReadOnlyCollection<CommandViewModel> _commands;
        ObservableCollection<WorkspaceViewModel> _workspaces;
        const string DefaultText = "This example demonstrates how to use the ItemsSource collection for the DockLayoutManager object in order to apply an MVVM pattern for your application. All BarManager and DockLayoutManager items are defined in the data source. They are bound via the ItemsSource property and visualized via templates. Elements are added and organized in containers according to the attached TargetName property.";
        public MainWindowViewModel() {
            InitDefaultLayout();
        }
        protected virtual void InitDefaultLayout() {
            var panels = new List<PanelWorkspaceViewModel> { _ToolboxViewModel, _SolutionExplorerViewModel, _PropertiesViewModel, _ErrorListViewModel };
            foreach(var panel in panels) {
                OpenOrCloseWorkspace(panel);
            }
            var doc = CreatePanelWorkspaceViewModel(() => new DocumentViewModel("Start Page", DefaultText));
            OpenOrCloseWorkspace(doc, true);
        }
        public ReadOnlyCollection<CommandViewModel> Commands {
            get {
                if(_commands == null) {
                    List<CommandViewModel> cmds = CreateCommands();
                    _commands = new ReadOnlyCollection<CommandViewModel>(cmds);
                }
                return _commands;
            }
        }
        protected virtual List<CommandViewModel> CreateViewCommands() {
            var showToolboxPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowToolboxPanel);
            var showSolutionExplorerPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowSolutionExplorerPanel);
            var showPropertiesPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowPropertiesPanel);
            var showErrorListPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowErrorListPanel);
            var showOutputPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowOutputPanel);
            var showSearchResultsPanelRelayCommand = DelegateCommandFactory.Create<object>(OnShowSearchResultsPanel);
            CommandViewModel toolbox = new CommandViewModel(_ToolboxViewModel, showToolboxPanelRelayCommand);
            CommandViewModel solutionExplorer = new CommandViewModel(_SolutionExplorerViewModel, showSolutionExplorerPanelRelayCommand);
            CommandViewModel properties = new CommandViewModel(_PropertiesViewModel, showPropertiesPanelRelayCommand);
            CommandViewModel errorList = new CommandViewModel(_ErrorListViewModel, showErrorListPanelRelayCommand);
            CommandViewModel output = new CommandViewModel(_OutputViewModel, showOutputPanelRelayCommand);
            CommandViewModel searchResults = new CommandViewModel(_SearchResultsViewModel, showSearchResultsPanelRelayCommand);
            return new List<CommandViewModel>() { toolbox, solutionExplorer, properties, errorList, output, searchResults };
        }
        protected virtual List<CommandViewModel> CreateFileCommands() {
            var openDocumentRelayCommand = DelegateCommandFactory.Create<object>(OnOpenDocument);
            CommandViewModel openDocument = new CommandViewModel("Open...", openDocumentRelayCommand) { Glyph = GlyphHelper.GetGlyph("/Images/Open_16x16.png"), IsEnabled = true };
            return new List<CommandViewModel>() { openDocument };
        }
        List<CommandViewModel> CreateCommands() {
            List<CommandViewModel> fileCommands = CreateFileCommands();
            List<CommandViewModel> viewCommands = CreateViewCommands();
            var file = new CommandViewModel("File", fileCommands);
            var view = new CommandViewModel("View", viewCommands);
            return new List<CommandViewModel> { file, view };
        }
        ReadOnlyCollection<BarModel> _bars;
        public ReadOnlyCollection<BarModel> Bars {
            get {
                if(_bars == null) {
                    List<BarModel> cmds = CreateBars();
                    _bars = new ReadOnlyCollection<BarModel>(cmds);
                }
                return _bars;
            }
        }
        protected virtual List<BarModel> CreateBars() {
            BarModel model = new BarModel("Main") { IsMainMenu = true };
            var commands = CreateCommands();
            foreach(var cmd in commands) {
                model.Commands.Add(cmd);
            }
            return new List<BarModel>() { model };
        }

        public ObservableCollection<WorkspaceViewModel> Workspaces {
            get {
                if(_workspaces == null) {
                    _workspaces = new ObservableCollection<WorkspaceViewModel>();
                    _workspaces.CollectionChanged += OnWorkspacesChanged;
                }
                return _workspaces;
            }
        }

        void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e) {
            if(e.NewItems != null && e.NewItems.Count != 0)
                foreach(WorkspaceViewModel workspace in e.NewItems)
                    workspace.RequestClose += OnWorkspaceRequestClose;

            if(e.OldItems != null && e.OldItems.Count != 0)
                foreach(WorkspaceViewModel workspace in e.OldItems)
                    workspace.RequestClose -= OnWorkspaceRequestClose;
        }

        void OnWorkspaceRequestClose(object sender, EventArgs e) {
            WorkspaceViewModel workspace = sender as WorkspaceViewModel;
            if(workspace is PanelWorkspaceViewModel) {
                ((PanelWorkspaceViewModel)workspace).IsClosed = true;
                if(workspace is DocumentViewModel) {
                    workspace.Dispose();
                    Workspaces.Remove(workspace);
                }
            }
        }
        protected virtual void InitPanelWorkspaceViewModel(PanelWorkspaceViewModel viewModel) { }
        protected T CreatePanelWorkspaceViewModel<T>() where T : PanelWorkspaceViewModel {
            T viewModel = ViewModelSource<T>.Create();
            InitPanelWorkspaceViewModel(viewModel);
            return viewModel;
        }
        protected T CreatePanelWorkspaceViewModel<T>(System.Linq.Expressions.Expression<Func<T>> constructorExpression) where T : PanelWorkspaceViewModel {
            return ViewModelSource.Create(constructorExpression);
        }
        ToolboxViewModel toolBoxViewModel;
        public ToolboxViewModel _ToolboxViewModel {
            get {
                if(toolBoxViewModel == null)
                    toolBoxViewModel = CreatePanelWorkspaceViewModel<ToolboxViewModel>();
                return toolBoxViewModel;
            }
        }
        SolutionExplorerViewModel solutionExplorerViewModel;
        public SolutionExplorerViewModel _SolutionExplorerViewModel {
            get {
                if(solutionExplorerViewModel == null) {
                    solutionExplorerViewModel = CreatePanelWorkspaceViewModel<SolutionExplorerViewModel>();
                    solutionExplorerViewModel.Solution = Solution;
                }
                return solutionExplorerViewModel;
            }
        }
        Solution solution;
        Solution Solution {
            get {
                if(solution == null) {
                    solution = Solution.Create();
                    solution.PropertyChanged += OnSolutionPropertyChanged;
                }
                return solution;
            }
        }
        private void OnSolutionPropertyChanged(object sender, PropertyChangedEventArgs e) {
            if(e.PropertyName == "PreviewItem") {
                OnPreviewItemChanged();
            }
        }
        protected virtual void OnPreviewItemChanged() { }
        PropertiesViewModel propertiesViewModel;
        public PropertiesViewModel _PropertiesViewModel {
            get {
                if(propertiesViewModel == null)
                    propertiesViewModel = CreatePanelWorkspaceViewModel<PropertiesViewModel>();
                return propertiesViewModel;
            }
        }
        ErrorListViewModel errorListViewModel;
        public ErrorListViewModel _ErrorListViewModel {
            get {
                if(errorListViewModel == null)
                    errorListViewModel = CreatePanelWorkspaceViewModel<ErrorListViewModel>();
                return errorListViewModel;
            }
        }
        OutputViewModel outputViewModel;
        public OutputViewModel _OutputViewModel {
            get {
                if(outputViewModel == null)
                    outputViewModel = CreatePanelWorkspaceViewModel<OutputViewModel>();
                return outputViewModel;
            }
        }
        SearchResultsViewModel searchResultsViewModel;
        public SearchResultsViewModel _SearchResultsViewModel {
            get {
                if(searchResultsViewModel == null)
                    searchResultsViewModel = CreatePanelWorkspaceViewModel<SearchResultsViewModel>();
                return searchResultsViewModel;
            }
        }
        protected void OpenOrCloseWorkspace(PanelWorkspaceViewModel workspace, bool activateOnOpen) {
            if(Workspaces.Contains(workspace)) {
                workspace.IsClosed = !workspace.IsClosed;
            } else {
                Workspaces.Add(workspace);
                workspace.IsClosed = false;
                if(activateOnOpen)
                    SetActiveWorkspace(workspace);
            }
        }
        protected void OpenOrCloseWorkspace(PanelWorkspaceViewModel workspace) {
            OpenOrCloseWorkspace(workspace, false);
        }
        void OnShowToolboxPanel(object param) {
            OpenOrCloseWorkspace(_ToolboxViewModel);
        }
        void OnShowSolutionExplorerPanel(object param) {
            OpenOrCloseWorkspace(_SolutionExplorerViewModel);
        }
        void OnShowPropertiesPanel(object param) {
            OpenOrCloseWorkspace(_PropertiesViewModel);
        }
        void OnShowErrorListPanel(object param) {
            OpenOrCloseWorkspace(_ErrorListViewModel);
        }
        void OnShowOutputPanel(object param) {
            OpenOrCloseWorkspace(_OutputViewModel);
        }
        void OnShowSearchResultsPanel(object param) {
            OpenOrCloseWorkspace(_SearchResultsViewModel);
        }
        protected virtual PanelWorkspaceViewModel CreateDocumentViewModel() {
            return CreatePanelWorkspaceViewModel<DocumentViewModel>();
        }
        void OnOpenDocument(object param) {
            var workspace = CreateDocumentViewModel();
            if(!workspace.Open()) return;
            OpenOrCloseWorkspace(workspace, true);
        }

        void SetActiveWorkspace(WorkspaceViewModel workspace) {
            Debug.Assert(Workspaces.Contains(workspace));
            workspace.IsActive = true;
        }
        protected static class GlyphHelper {
            public static BitmapImage GetGlyph(string path) {
                return new BitmapImage(DevExpress.Utils.AssemblyHelper.GetResourceUri(typeof(GlyphHelper).Assembly, path));
            }
        }
    }
    public class SolutionItem {
        readonly Solution solution;

        protected SolutionItem(Solution solution) {
            this.solution = solution;
        }

        public string DisplayName { get; private set; }
        public string GlyphPath { get; private set; }
        [BindableProperty(OnPropertyChangedMethodName = "OnIsSelectedChanged")]
        public virtual bool IsSelected { get; set; }
        public List<SolutionItem> Items {
            get { return items; }
        }

        public static SolutionItem Create(Solution solution, string displayName, string glyph) {
            var solutionItem = ViewModelSource.Create(() => new SolutionItem(solution));
            solutionItem.Do(x => {
                x.DisplayName = displayName;
                x.GlyphPath = glyph;
            });
            return solutionItem;
        }
        protected void OnIsSelectedChanged() {
            if(IsSelected)
                solution.PreviewItem = this;
        }
        private List<SolutionItem> items = new List<SolutionItem>();
    }
    public class Solution : DevExpress.Mvvm.BindableBase {
        protected Solution() {
            SolutionItem root = SolutionItem.Create(this, "WPFApplication", @"/DockingDemo;component/Images/VS2010Docking/Solution Explorer.png");
            SolutionItem properties = SolutionItem.Create(this, "Properties", @"/DockingDemo;component/Images/VS2010Docking/ReferencesClosed_16x16.png");
            SolutionItem references = SolutionItem.Create(this, "References", @"/DockingDemo;component/Images/VS2010Docking/ReferencesOpened_16x16.png");
            SolutionItem file1 = SolutionItem.Create(this, "File1.cs", @"/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png");
            SolutionItem file2 = SolutionItem.Create(this, "File2.cs", @"/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png");
            SolutionItem file3 = SolutionItem.Create(this, "Program.cs", @"/DockingDemo;component/Images/VS2010Docking/FileCS_16x16.png");

            root.Items.AddRange(new SolutionItem[] { properties, references, file1, file2, file3 });
            Items.Add(root);
        }

        public List<SolutionItem> Items {
            get { return items; }
        }
        public virtual SolutionItem PreviewItem { get; set; }

        public static Solution Create() {
            return ViewModelSource.Create(() => new Solution());
        }
        private List<SolutionItem> items = new List<SolutionItem>();
    }
}
