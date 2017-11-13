using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.MVVM.Demos.CodeExamples {
    [CodeExampleClass("POCO Bindable Properties", "Bindings.cs")]
    [CodeExampleHighlightTokens("MVVMContext", "DataSourceUpdateMode")]
    [CodeExampleUnderlineTokens("SetBinding", "DataBindings")]
    public static class BindindableProperties {
        static BindindableProperties() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.NullValuePrompt = "Please, enter the Title here...";
            editor.Properties.NullValuePromptShowForEmptyValue = true;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Report the Title property value";

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Standard Data-Binding", new Type[] { typeof(ViewModel) })]
        public static void StandardDataBinding(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            ViewModel viewModel = mvvmContext.GetViewModel<ViewModel>();
            // Data binding for the Title property (via the DataBindings collection)
            editor.DataBindings.Add("EditValue", viewModel, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            // UI binding for the Report command
            commandButton.Click += (s, e) => XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString());
        }
        [CodeExampleCase("Data-Binding via MVVMContext", new Type[] { typeof(ViewModel) })]
        public static void SimpleBinding(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the Title property (via MVVMContext API)
            mvvmContext.SetBinding(editor, e => e.EditValue, "Title");
            // UI binding for the Report command
            ViewModel viewModel = mvvmContext.GetViewModel<ViewModel>();
            commandButton.Click += (s, e) => XtraMessageBox.Show(viewModel.GetTitleAsHumanReadableString());
        }
        [CodeExampleCase("Data-Binding via MVVMContext (Fluent API)", new Type[] { typeof(ViewModel) })]
        public static void SimpleBindingFluentAPI(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the Title property (via MVVMContext API)
            var fluentAPI = mvvmContext.OfType<ViewModel>();
            fluentAPI.SetBinding(editor, e => e.EditValue, x => x.Title);
            // UI binding for the Report command
            commandButton.Click += (s, e) => XtraMessageBox.Show(fluentAPI.ViewModel.GetTitleAsHumanReadableString());
        }
        [CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the INotifyPropertyChanged.")]
        public class ViewModel {
            // Bindable property will be created from this property.
            public virtual string Title { get; set; }
            // Just a method for readability
            public string GetTitleAsHumanReadableString() {
                if(Title == null)
                    return "(Null)";
                if(Title.Length == 0)
                    return "(Empty)";
                if(string.IsNullOrWhiteSpace(Title))
                    return "(WhiteSpace)";
                return Title;
            }
        }
    }

    [CodeExampleClass("POCO Dependencies", "Bindings.cs")]
    [CodeExampleHighlightTokens("BindableProperty")]
    [CodeExampleUnderlineTokens("SetBinding", "RaisePropertyChanged")]
    public static class DependencyProperties {
        static DependencyProperties() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor1 = new TextEdit();
            editor1.Dock = DockStyle.Top;
            editor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor1.Properties.Mask.EditMask = "n0";
            editor1.Properties.Mask.UseMaskAsDisplayFormat = true;

            TextEdit editor2 = new TextEdit();
            editor2.Dock = DockStyle.Top;
            editor2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor2.Properties.Mask.EditMask = "n0";
            editor2.Properties.Mask.UseMaskAsDisplayFormat = true;

            LabelControl resultLabel = new LabelControl();
            resultLabel.Dock = DockStyle.Top;
            resultLabel.AutoSizeMode = LabelAutoSizeMode.Vertical;

            resultLabel.Parent = sampleHost;
            editor1.Parent = sampleHost;
            editor2.Parent = sampleHost;
            return new object[] { mvvmContext, editor1, editor2, resultLabel };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Simple dependencies", new Type[] { typeof(MultViewModel) })]
        public static void SimpleDependencies(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(MultViewModel);
            // Data binding for the operands
            mvvmContext.SetBinding(editor1, e => e.EditValue, "Operand1");
            mvvmContext.SetBinding(editor2, e => e.EditValue, "Operand2");
            // Data binding for the result
            mvvmContext.SetBinding(resultLabel, l => l.Text, "ResultText");
        }
        [CodeExampleCase("PropertyChanged notifications", new Type[] { typeof(SumViewModel) })]
        public static void PropertyChangedNotifications(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(SumViewModel);
            // Data binding for the operands
            mvvmContext.SetBinding(editor1, e => e.EditValue, "Operand1");
            mvvmContext.SetBinding(editor2, e => e.EditValue, "Operand2");
            // Data binding for the result
            mvvmContext.SetBinding(resultLabel, l => l.Text, "ResultText");
        }
        [CodeExampleNestedClass("POCO View Model provides out-of-the-box support of the OnXXXChanging/OnXXXChanged callbacks.")]
        public class MultViewModel {
            public MultViewModel() {
                Operand1 = 2;
                Operand2 = 3;
            }
            public virtual int Operand1 { get; set; }
            public virtual int Operand2 { get; set; }
            public virtual int Result { get; set; }
            public virtual string ResultText { get; set; }
            // OnChanged callback will be created for the Operand1 property from this method.
            protected void OnOperand1Changed() {
                // Result depends on Operand1
                UpdateResult();
            }
            // OnChanged callback will be created for the Operand2 property from this method.
            protected void OnOperand2Changed() {
                // Result depends on Operand2
                UpdateResult();
            }
            // OnChanged callback will be created for the Result property from this method.
            protected void OnResultChanged() {
                // ResultText depends on Result
                UpdateResultText();
            }
            void UpdateResult() {
                Result = Operand1 * Operand2;
            }
            void UpdateResultText() {
                ResultText = string.Format("The result of operands multiplication is: {0:n0}", Result);
            }
        }
        [CodeExampleNestedClass("POCO View Model supports attributes and extension-methods for different purposes.")]
        public class SumViewModel {
            public SumViewModel() {
                Operand1 = 2;
                Operand2 = 2;
            }
            // using the BindableProperty attribute
            [BindableProperty(OnPropertyChangedMethodName = "NotifyResultAndResultTextChanged")]
            public virtual int Operand1 { get; set; }
            // using the BindableProperty attribute
            [BindableProperty(OnPropertyChangedMethodName = "NotifyResultAndResultTextChanged")]
            public virtual int Operand2 { get; set; }
            // We will raise change-notification for this property manually
            public int Result {
                get { return Operand1 + Operand2; }
            }
            // We will raise change-notification for this property manually
            public string ResultText {
                get { return string.Format("The result of operands summarization is: {0:n0}", Result); }
            }
            protected void NotifyResultAndResultTextChanged() {
                this.RaisePropertyChanged(x => x.Result); // change-notification for the Result
                this.RaisePropertyChanged(x => x.ResultText); // change-notification for the ResultText
            }
        }
    }

    [CodeExampleClass("POCO Meta-Declarations", "Bindings.cs")]
    [CodeExampleHighlightTokens("MetadataType", "Metadata")]
    [CodeExampleUnderlineTokens("SetBinding", "Property")]
    public static class POCO_MetaDeclarations {
        static POCO_MetaDeclarations() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor1 = new TextEdit();
            editor1.Dock = DockStyle.Top;
            editor1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor1.Properties.Mask.EditMask = "n0";
            editor1.Properties.Mask.UseMaskAsDisplayFormat = true;

            TextEdit editor2 = new TextEdit();
            editor2.Dock = DockStyle.Top;
            editor2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor2.Properties.Mask.EditMask = "n0";
            editor2.Properties.Mask.UseMaskAsDisplayFormat = true;

            LabelControl resultLabel = new LabelControl();
            resultLabel.Dock = DockStyle.Top;
            resultLabel.AutoSizeMode = LabelAutoSizeMode.Vertical;

            resultLabel.Parent = sampleHost;
            editor1.Parent = sampleHost;
            editor2.Parent = sampleHost;
            return new object[] { mvvmContext, editor1, editor2, resultLabel };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Bindable Properties and Dependencies", new Type[] { typeof(SumViewModel_MetaPOCO) })]
        public static void BindableProperties(MVVMContext mvvmContext, TextEdit editor1, TextEdit editor2, LabelControl resultLabel) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(SumViewModel_MetaPOCO);
            // Data binding for the operands
            mvvmContext.SetBinding(editor1, e => e.EditValue, "Operand1");
            mvvmContext.SetBinding(editor2, e => e.EditValue, "Operand2");
            // Data binding for the result
            mvvmContext.SetBinding(resultLabel, l => l.Text, "ResultText");
        }
        [CodeExampleNestedClass("POCO View Model properties supports Fluent Meta-declarations via Metadata-types.")]
        [System.ComponentModel.DataAnnotations.MetadataType(typeof(Metadata))]
        public class SumViewModel_MetaPOCO {
            public SumViewModel_MetaPOCO() {
                Operand1 = 2;
                Operand2 = 2;
                Result = 4;
            }
            // This property will be declared as Non-Bindable property via Fluent API
            public virtual int Result { get; set; }
            // This property will be declared as Bindable property via Fluent API
            public virtual int Operand1 { get; set; }
            // This property will be declared as Bindable property via Fluent API
            public virtual int Operand2 { get; set; }
            // We will raise change-notification for this property manually
            public string ResultText {
                get { return string.Format("The result of operands summarization is: {0:n0}", Result); }
            }
            // We will declare this method as OnChanged callback for the Operand1 and the Operand2 properties
            protected void NotifyResultAndResultTextChanged() {
                Result = Operand1 + Operand2;
                this.RaisePropertyChanged(x => x.Result); // change-notification for the Result
                this.RaisePropertyChanged(x => x.ResultText); // change-notification for the ResultText
            }
            // Metadata class for the SumViewModel_MetaPOCO
            public class Metadata : IMetadataProvider<SumViewModel_MetaPOCO> {
                void IMetadataProvider<SumViewModel_MetaPOCO>.BuildMetadata(MetadataBuilder<SumViewModel_MetaPOCO> builder) {
                    builder.Property(x => x.Result)
                        .DoNotMakeBindable();
                    builder.Property(x => x.Operand1).
                        OnPropertyChangedCall(x => x.NotifyResultAndResultTextChanged());
                    builder.Property(x => x.Operand2).
                        OnPropertyChangedCall(x => x.NotifyResultAndResultTextChanged());
                }
            }
        }
    }

    [CodeExampleClass("Entity Bindings", "Bindings.cs")]
    [CodeExampleHighlightTokens("Entity")]
    [CodeExampleUnderlineTokens("SetObjectDataSourceBinding")]
    public static class EntityBindings {
        static EntityBindings() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            SimpleButton createBtn = new SimpleButton();
            createBtn.Text = "Create a new Entity";
            createBtn.Dock = DockStyle.Top;
            createBtn.Parent = sampleHost;

            TextEdit textEditor = new TextEdit();
            textEditor.Dock = DockStyle.Top;
            textEditor.Parent = sampleHost;

            TextEdit idEditor = new TextEdit();
            idEditor.ReadOnly = true;
            idEditor.Dock = DockStyle.Top;
            idEditor.Parent = sampleHost;

            return new object[] { mvvmContext, idEditor, textEditor, createBtn };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        //
        [CodeExampleNestedClass]
        public class Entity {
            public Entity(int id) {
                this.ID = id;
                this.Text = "Entity " + id.ToString();
            }
            public int ID { get; private set; }
            public string Text { get; set; }
        }
        //
        [CodeExampleCase("Data-Binding of Entity properties", new Type[] { typeof(ViewModel), typeof(Entity) })]
        public static void ObjectDataSourceBinding(MVVMContext mvvmContext, TextEdit idEditor, TextEdit textEditor, SimpleButton createBtn) {
            // Seting the POCO-ViewModel type
            mvvmContext.ViewModelType = typeof(ViewModel);

            var fluentApi = mvvmContext.OfType<ViewModel>();
            // Creating the BindingSource
            BindingSource entityBindingSource = new BindingSource();
            entityBindingSource.DataSource = typeof(Entity);
            // Creating the UI bindings
            idEditor.DataBindings.Add(new Binding("EditValue", entityBindingSource, "ID"));
            textEditor.DataBindings.Add(new Binding("EditValue", entityBindingSource, "Text", true, DataSourceUpdateMode.OnPropertyChanged));
            // Creating two-way binding of the Entity property onto the BindingSource.DataSource
            fluentApi.SetObjectDataSourceBinding(entityBindingSource, x => x.Entity, x => x.Update());
            // Bind the Create command which creates a new Entity
            fluentApi.BindCommand(createBtn, x => x.Create());
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            static int id = 0;
            public ViewModel() {
                Create();
            }
            public virtual Entity Entity {
                get;
                set;
            }
            // Create a new entity
            public void Create() {
                Entity = new Entity(id++);
            }
            // Update command
            public void Update() {
                var msgService = this.GetService<IMessageBoxService>();
                msgService.ShowMessage("Entity was updated from the UI!");
            }
        }
    }

    [CodeExampleClass("Collection Bindings", "Bindings.cs")]
    [CodeExampleHighlightTokens("Entity")]
    [CodeExampleUnderlineTokens("SetItemsSourceBinding")]
    public static class CollectionBindings {
        static CollectionBindings() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            ImageListBoxControl itemsListBox = new ImageListBoxControl();
            itemsListBox.Dock = DockStyle.Top;
            itemsListBox.Parent = sampleHost;

            SimpleButton removeButton = new SimpleButton();
            removeButton.Dock = DockStyle.Top;
            removeButton.Text = "Remove";
            removeButton.Parent = sampleHost;

            SimpleButton addButton = new SimpleButton();
            addButton.Dock = DockStyle.Top;
            addButton.Text = "Add";
            addButton.Parent = sampleHost;

            return new object[] { mvvmContext, addButton, removeButton, itemsListBox };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding of Items collection", new Type[] { typeof(ViewModel), typeof(Entity) })]
        public static void CollectionDataBinding(MVVMContext mvvmContext, SimpleButton addButton, SimpleButton removeButton, ImageListBoxControl listBox) {
            // Seting the POCO-ViewModel type
            mvvmContext.ViewModelType = typeof(ViewModel);

            var fluentApi = mvvmContext.OfType<ViewModel>();
            // Populating the ListBox with items, generated from the Entites collection
            fluentApi.SetItemsSourceBinding(
                listBox,            // Target
                lb => lb.Items,     // Items Selector 
                x => x.Entities,    // Source Selector  
                (item, entity) => object.Equals(item.Value, entity),    // Match Expression - checks whether or not this item matches the current entity
                entity => new ImageListBoxItem(entity),                 // Create Expression - creates a new item based on the current entity
                null,                                                   // Dispose Expression - disposes of a target element when its related source collection record is removed
                (item, entity) =>                                       // Change Expression - modifies existing items
                {
                    ((ImageListBoxItem)item).Description = entity.Text;
                });
            // Binding the SelectedValue property to the currently selected entity
            fluentApi.SetBinding(listBox, lb => lb.SelectedValue, x => x.SelectedEntity);
            // Command bindings
            fluentApi.BindCommand(addButton, x => x.Add());
            fluentApi.BindCommand(removeButton, x => x.Remove());
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Entities = new ObservableCollection<Entity>()
                {
                    new Entity(0),
                    new Entity(1)
                };
            }
            public virtual Entity SelectedEntity {
                get;
                set;
            }
            public virtual ObservableCollection<Entity> Entities {
                get;
                set;
            }
            protected void OnSelectedEntityChanged() {
                this.RaiseCanExecuteChanged(x => x.Remove());
            }
            protected void OnEntitiesChanged() {
                SelectedEntity = Entities.FirstOrDefault();
            }
            // Add a new item
            public void Add() {
                Entities.Add(new Entity(Entities.Count));
            }
            // Remove the selected item
            public void Remove() {
                Entities.Remove(SelectedEntity);
            }
            public bool CanRemove() {
                return SelectedEntity != null;
            }
        }
        [CodeExampleNestedClass]
        public class Entity {
            public Entity(int id) {
                this.ID = id;
                this.Text = "Entity " + id.ToString();
            }
            public int ID { get; private set; }
            public string Text { get; set; }
        }
    }

    [CodeExampleClass("UI Triggers", "Bindings.cs")]
    [CodeExampleUnderlineTokens("SetTrigger")]
    public static class UITriggers {
        static UITriggers() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            CheckEdit checkEdit = new CheckEdit();
            checkEdit.Dock = DockStyle.Top;
            checkEdit.Text = "IsActive";

            LabelControl label = new LabelControl();
            label.Dock = DockStyle.Top;
            label.AutoSizeMode = LabelAutoSizeMode.Vertical;
            label.Text = "Inactive";

            label.Parent = sampleHost;
            checkEdit.Parent = sampleHost;
            return new object[] { mvvmContext, checkEdit, label };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Simple UI Trigger", new Type[] { typeof(UIViewModel) })]
        public static void SimpleTrigger(MVVMContext mvvmContext, CheckEdit checkEdit, LabelControl label) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(UIViewModel);
            // Data binding for the IsActive property
            mvvmContext.SetBinding<CheckEdit, UIViewModel, bool>(checkEdit, c => c.Checked, x => x.IsActive);
            // Property-change Trigger for the IsActive property
            mvvmContext.SetTrigger<UIViewModel, bool>(x => x.IsActive, (active) =>
            {
                label.Text = active ? "Active" : "Inactive";
            });
        }
        [CodeExampleCase("Simple UI Trigger (Fluent API)", new Type[] { typeof(UIViewModel) })]
        public static void SimpleTriggerFluentAPI(MVVMContext mvvmContext, CheckEdit checkEdit, LabelControl label) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(UIViewModel);
            // Data binding for the IsActive property
            var fluentAPI = mvvmContext.OfType<UIViewModel>();
            fluentAPI.SetBinding(checkEdit, c => c.Checked, x => x.IsActive);
            // Property-change Trigger for the IsActive property
            fluentAPI.SetTrigger(x => x.IsActive, (active) =>
            {
                label.Text = active ? "Active" : "Inactive";
            });
        }
        [CodeExampleNestedClass("We will track the IsActive property changing in UI")]
        public class UIViewModel {
            public virtual bool IsActive { get; set; }
        }
    }

    [CodeExampleClass("Binding to Legacy ViewModels", "Bindings.cs")]
    [CodeExampleUnderlineTokens("SetViewModel")]
    public static class LegacyViewModels {
        static LegacyViewModels() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.NullValuePrompt = "Please, enter the Title here...";
            editor.Properties.NullValuePromptShowForEmptyValue = true;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Report the Title property value";

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding via MVVMContext", new Type[] { typeof(LegacyViewModel) })]
        public static void SimpleBinding(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            var legacyViewModel = new LegacyViewModel("Legacy ViewModel");
            // initialize the MVVMContext with the specific ViewModel's instance
            mvvmContext.SetViewModel(typeof(LegacyViewModel), legacyViewModel);
            // Data binding for the Title property (via MVVMContext API)
            mvvmContext.SetBinding(editor, e => e.EditValue, "Title");
            // UI binding for the Report command
            commandButton.Click += (s, e) => XtraMessageBox.Show(legacyViewModel.Title);
        }
        [CodeExampleCase("Data-Binding via MVVMContext (Fluent API)", new Type[] { typeof(LegacyViewModel) })]
        public static void SimpleBindingFluentAPI(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            var legacyViewModel = new LegacyViewModel("Legacy ViewModel");
            // initialize the MVVMContext with the specific ViewModel's instance
            mvvmContext.SetViewModel(typeof(LegacyViewModel), legacyViewModel);
            // Data binding for the Title property (via MVVMContext API)
            var fluentAPI = mvvmContext.OfType<LegacyViewModel>();
            fluentAPI.SetBinding(editor, e => e.EditValue, x => x.Title);
            // UI binding for the Report command
            commandButton.Click += (s, e) => XtraMessageBox.Show(legacyViewModel.Title);
        }
        [CodeExampleNestedClass]
        public class LegacyViewModel {
            string titleCore;
            public LegacyViewModel(string title) {
                this.titleCore = title;
            }
            public virtual string Title {
                get { return titleCore; }
                set {
                    if(titleCore == value) return;
                    titleCore = value;
                    OnTitleChanged();
                }
            }
            void OnTitleChanged() {
                EventHandler h = TitleChanged;
                if(h != null) h(this, EventArgs.Empty);
            }
            public event EventHandler TitleChanged;
        }
    }

    [CodeExampleClass("Data-Binding Capabilities (Binding Path)", "Bindings.cs")]
    [CodeExampleHighlightTokens("ViewModelSource")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Path {
        static BindingFeatures_Path() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.NullValuePrompt = "Please, enter the Title here...";
            editor.Properties.NullValuePromptShowForEmptyValue = true;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Report the Title property value";

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding to Nested Properties", new Type[] { typeof(ViewModel), typeof(NestedViewModel) })]
        public static void NestedBinding(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the Title property of nested ViewModel  (via MVVMContext API)
            mvvmContext.SetBinding(editor, e => e.EditValue, "Child.Title");
            // UI binding for the Report command
            ViewModel viewModel = mvvmContext.GetViewModel<ViewModel>();
            commandButton.Click += (s, e) => XtraMessageBox.Show(viewModel.GetChildTitleAsHumanReadableString());
        }
        [CodeExampleCase("Data-Binding to Nested Properties (Fluent API)", new Type[] { typeof(ViewModel), typeof(NestedViewModel) })]
        public static void NestedBindingFluentAPI(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the Title property of nested ViewModel (via MVVMContext FluentAPI)
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.SetBinding(editor, e => e.EditValue, x => x.Child.Title);
            // UI binding for the Report command
            ViewModel viewModel = mvvmContext.GetViewModel<ViewModel>();
            commandButton.Click += (s, e) => XtraMessageBox.Show(viewModel.GetChildTitleAsHumanReadableString());
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                // Create Nested ViewModel as POCO-ViewModel
                Child = ViewModelSource.Create<NestedViewModel>();
            }
            // Nested ViewModel
            public NestedViewModel Child { get; private set; }
            // Just a method for readability
            public string GetChildTitleAsHumanReadableString() {
                if(Child.Title == null)
                    return "Child.Title is (Null)";
                if(Child.Title.Length == 0)
                    return "Child.Title is (Empty)";
                if(string.IsNullOrWhiteSpace(Child.Title))
                    return "Child.Title is (WhiteSpace)";
                return "Child.Title = " + Child.Title;
            }
        }
        [CodeExampleNestedClass]
        public class NestedViewModel {
            public virtual string Title { get; set; }
        }
    }

    [CodeExampleClass("Data-Binding Capabilities (Converters)", "Bindings.cs")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Converters {
        static BindingFeatures_Converters() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TrackBarControl trackBar = new TrackBarControl();
            trackBar.Dock = DockStyle.Top;
            trackBar.Properties.Minimum = 0;
            trackBar.Properties.Maximum = 100;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;
            editor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            editor.Properties.Mask.EditMask = "##0";
            editor.Properties.Mask.UseMaskAsDisplayFormat = true;

            editor.Parent = sampleHost;
            trackBar.Parent = sampleHost;
            return new object[] { mvvmContext, trackBar, editor };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding via Default Converters (Fluent API)", new Type[] { typeof(ViewModel) })]
        public static void ConvertBindingFluentAPI_DefaultConverter(MVVMContext mvvmContext, TrackBarControl trackBar, TextEdit editor) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the Progress property (via MVVMContext FluentAPI)
            var fluent = mvvmContext.OfType<ViewModel>();
            // Binding two integer properties - 'Value' and 'Progress'. No conversion needed
            fluent.SetBinding(trackBar, t => t.Value, x => x.Progress);
            // Binding the string 'Text' property to the integer 'Progress'. Values are automatically converted to/from an appropriate type.
            fluent.SetBinding(editor, e => e.Text, x => x.Progress);
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public virtual int Progress { get; set; }
        }
    }
    [CodeExampleClass("Data-Binding Capabilities (Converters)", "Bindings.cs")]
    [CodeExampleHighlightTokens("State", "CheckState")]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_BackConverter {
        static BindingFeatures_BackConverter() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            CheckEdit check = new CheckEdit();
            check.Dock = DockStyle.Top;
            check.Properties.AllowGrayed = true;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Report the ModelState property value";

            check.Parent = sampleHost;
            commandButton.Parent = sampleHost;
            return new object[] { mvvmContext, check, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding with Custom Converters (Fluent API)", new Type[] { typeof(ViewModel) })]
        public static void ConvertBindingFluentAPIOneWay(MVVMContext mvvmContext, CheckEdit check, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the ModelState property (via MVVMContext FluentAPI)
            var fluent = mvvmContext.OfType<ViewModel>();
            fluent.SetBinding(check, e => e.CheckState, x => x.ModelState,
                modelState =>
                {
                    // Convert the ViewModel.State to CheckState
                    switch(modelState) {
                        case ViewModel.State.Active:
                            return CheckState.Checked;
                        case ViewModel.State.Inactive:
                            return CheckState.Unchecked;
                        default:
                            return CheckState.Indeterminate;
                    }
                },
                checkState =>
                {
                    // Convert back from CheckState to the ViewModel.State
                    switch(checkState) {
                        case CheckState.Checked:
                            return ViewModel.State.Active;
                        case CheckState.Unchecked:
                            return ViewModel.State.Inactive;
                        default:
                            return ViewModel.State.Suspended;
                    }
                });
            fluent.SetBinding(check, e => e.Text, x => x.ModelState, modelState =>
                string.Format("Click to change the current ViewModel state from {0} to {1}", modelState, (ViewModel.State)((1 + (int)modelState) % 3)));
            // UI binding for the Report command
            fluent.BindCommand(commandButton, x => x.ReportState());
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public virtual State ModelState { get; set; }
            public enum State {
                Suspended = 0,
                Inactive = 1,
                Active = 2
            }
            public void ReportState() {
                this.GetService<IMessageBoxService>().ShowMessage(ModelState.ToString());
            }
        }
    }

    [CodeExampleClass("Data-Binding Capabilities (Formatting)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Formatting {
        static BindingFeatures_Formatting() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            LabelControl label = new LabelControl();
            label.Dock = DockStyle.Top;

            SpinEdit editor = new SpinEdit();
            editor.Properties.IsFloatValue = false;
            editor.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;
            commandButton.Text = "Reset Price";

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            label.Parent = sampleHost;
            return new object[] { mvvmContext, label, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding with Formatting", new Type[] { typeof(ViewModel) })]
        public static void FormatBinding(MVVMContext mvvmContext, LabelControl label, SpinEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // One-way Data binding for the Price property (display as currency)
            mvvmContext.SetBinding(label, l => l.Text, "Price", "Price: {0:C}");
            // Data binding for the Price property editing
            mvvmContext.SetBinding(editor, e => e.EditValue, "Price");
            // UI binding for the Reset command
            mvvmContext.BindCommand<ViewModel>(commandButton, x => x.Reset());
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Reset();
            }
            public virtual int Price { get; set; }
            public void Reset() {
                Price = 175;
            }
        }
    }
    [CodeExampleClass("Data-Binding Capabilities (Events)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetBinding")]
    public static class BindingFeatures_Events {
        static BindingFeatures_Events() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editor = new TextEdit();
            editor.Dock = DockStyle.Top;

            SimpleButton commandButton = new SimpleButton();
            commandButton.Dock = DockStyle.Top;

            commandButton.Parent = sampleHost;
            editor.Parent = sampleHost;
            return new object[] { mvvmContext, editor, commandButton };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding with custom conversion handling", new Type[] { typeof(ViewModel) })]
        public static void BindingConvert(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Binding Convert handling
            mvvmContext.BindingConvert += (s, e) =>
            {
                string strValue = e.Value as string;
                if(strValue != null) {
                    int intValue;
                    if(int.TryParse(strValue, out intValue))
                        e.Value = intValue;
                    else
                        e.Value = null;
                }
                if(e.Value == null) 
                    e.Value = 0;
            };
            // Data binding for the Value property
            mvvmContext.SetBinding(editor, e => e.EditValue, "Value");
            // UI binding for the Reset command
            mvvmContext.BindCommand<ViewModel>(commandButton, x => x.Reset());
            mvvmContext.SetBinding(commandButton, b => b.Text, "Value", "Reset Value ({0})");
        }
        [CodeExampleCase("Data-Binding with custom error handling", new Type[] { typeof(ViewModel) })]
        public static void BindingError(MVVMContext mvvmContext, TextEdit editor, SimpleButton commandButton) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Binding Error handling
            mvvmContext.BindingError += (s, e) =>
            {
                editor.ErrorText = e.Error.Message;
            };
            // When Errors changed
            mvvmContext.BindingBehavior.Errors.PropertyChanged += (s, e) =>
            {
                var errors = ((System.ComponentModel.IDataErrorInfo)s);
                if(errors.Error == null)
                    editor.ErrorText = null;
            };
            // Data binding for the Value property
            mvvmContext.SetBinding(editor, e => e.EditValue, "Value");
            // UI binding for the Reset command
            mvvmContext.BindCommand<ViewModel>(commandButton, x => x.Reset());
            mvvmContext.SetBinding(commandButton, b => b.Text, "Value", "Reset Value ({0})");
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                Reset();
            }
            public virtual int Value {
                get;
                set;
            }
            protected void OnValueChanged() {
                this.RaiseCanExecuteChanged(x => x.Reset());
            }
            public bool CanReset() {
                return Value != 42;
            }
            public void Reset() {
                Value = 42;
            }
        }
    }
    [CodeExampleClass("Data-Binding Capabilities (MultiBinding)", "Bindings.cs"), CodeExampleVersionID(162)]
    [CodeExampleUnderlineTokens("SetMultiBinding")]
    public static class BindingFeatures_MultiBinding {
        static BindingFeatures_MultiBinding() {
            DelegateCommand.DefaultUseCommandManager = false;
        }
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = sampleHost;

            TextEdit editForFirstName = new TextEdit();
            editForFirstName.Dock = DockStyle.Top;
            TextEdit editForLastName = new TextEdit();
            editForLastName.Dock = DockStyle.Top;
            TextEdit editForFullName = new TextEdit();
            editForFullName.Dock = DockStyle.Top;

            editForFullName.Parent = sampleHost;
            editForLastName.Parent = sampleHost;
            editForFirstName.Parent = sampleHost;
            return new object[] { mvvmContext, editForFirstName, editForLastName, editForFullName };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var context = MVVMContext.FromControl(sampleHost);
            if(context != null) context.Dispose();
        }
        [CodeExampleCase("Data-Binding for Multiple properties at once(via formatting)", new Type[] { typeof(ViewModel) })]
        public static void FormatBinding(MVVMContext mvvmContext, TextEdit editForFirstName, TextEdit editForLastName, TextEdit editForFullName) {
            editForFullName.ReadOnly = true;
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the FirstName and Last Name properties
            mvvmContext.SetBinding(editForFirstName, e => e.EditValue, "FirstName");
            mvvmContext.SetBinding(editForLastName, e => e.EditValue, "LastName");
            // Multi binding for the dispaying FullName (one-way)
            mvvmContext.SetMultiBinding(editForFullName, e => e.Text, new string[] { "FirstName", "LastName" }, "{1}, {0}");
        }
        [CodeExampleCase("Data-Binding for Multiple properties at once(via converters)", new Type[] { typeof(ViewModel) })]
        public static void ConvertBinding(MVVMContext mvvmContext, TextEdit editForFirstName, TextEdit editForLastName, TextEdit editForFullName) {
            // Set type of POCO-ViewModel
            mvvmContext.ViewModelType = typeof(ViewModel);
            // Data binding for the FirstName and Last Name properties editing
            mvvmContext.SetBinding(editForFirstName, e => e.EditValue, "FirstName");
            mvvmContext.SetBinding(editForLastName, e => e.EditValue, "LastName");
            // Multi binding for the editing FullName (two-way)
            mvvmContext.SetMultiBinding(editForFullName, e => e.EditValue, new string[] { "FirstName", "LastName" },
                values => string.Join(",", values), value => ((string)value).Split(','));
        }
        [CodeExampleNestedClass]
        public class ViewModel {
            public ViewModel() {
                FirstName = "John";
                LastName = "Smith";
            }
            public virtual string FirstName { get; set; }
            public virtual string LastName { get; set; }
        }
    }
}
