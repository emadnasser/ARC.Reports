namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Docking2010;
    using DevExpress.XtraLayout.Utils;

    public partial class EmployeeView : BaseModuleControl {
        public EmployeeView()
            : base(typeof(SynchronizedEmployeeViewModel)) {
            InitializeComponent();
            gvTasks.SetViewFontSize(2, 1);
            gvEvaluations.SetViewFontSize(2, 1);
            BindCommands();
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            lbEvaluations.Tag = true; lbTasks.Tag = false;
            new LabelTabController(lbTasks.Tag, lbEvaluations, lbTasks).EditValueChanged += (s, e) =>
            {
                lciEvaluations.Visibility = (bool)s ? LayoutVisibility.Always : LayoutVisibility.Never;
                lciTasks.Visibility = !(bool)s ? LayoutVisibility.Always : LayoutVisibility.Never;
            };
        }
        protected override void OnDisposing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
            base.OnDisposing();
        }
        public EmployeeViewModel ViewModel {
            get { return GetViewModel<EmployeeViewModel>(); }
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        protected override void OnDelayedUIUpdate() {
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateUI(ViewModel.Entity);
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            fluent.BindCommand(ContactButton(0), x => x.Contacts.Message());
            fluent.BindCommand(ContactButton(1), x => x.Contacts.Phone());
            fluent.BindCommand(ContactButton(2), x => x.Contacts.VideoCall());
            fluent.BindCommand(ContactButton(3), x => x.Contacts.MailTo());
        }
        WindowsUIButton ContactButton(int index) {
            return (WindowsUIButton)buttonPanel.Buttons[index];
        }
        void UpdateUI(Employee employee) {
            if(employee != null) {
                if(!object.Equals(bindingSource.DataSource, employee))
                    bindingSource.DataSource = employee;
                else {
                    employee.ResetBindable();
                    bindingSource.ResetBindings(false);
                }
                gcTasks.DataSource = employee.AssignedTasks;
                gcEvaluations.DataSource = employee.Evaluations;
            }
            else {
                gcTasks.DataSource = null;
                gcEvaluations.DataSource = null;
            }
            modueLayout.Visible = (employee != null);
        }
        public bool IsHorizontalLayout {
            get { return !colDescription.Visible; }
            set {
                gvEvaluations.OptionsView.ShowPreview = value;
                gvTasks.OptionsView.ShowPreview = value;
                colDescription.Visible = !value;
            }
        }
    }
}
