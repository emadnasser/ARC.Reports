using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Demos.Helpers;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class ServerMode : TutorialControl {
        readonly NoDataState stateNoData;
        readonly Linq2SqlState stateLinq2Sql;
        readonly Stopwatch timer = new Stopwatch();
        DemoState currentState;

        public PanelControl PnlDemo { get { return panelDemo; } }
        public PanelControl PnlNoConnection { get { return panelNoConnection; } }
        public object PivotDataSource {
            set {
                pivotGridControl.SetDataSourceAsync(value, (result) => {});
            }
        }
        DemoState State {
            get { return currentState; }
            set {
                if(currentState == value)
                    return;
                if(currentState != null) {
                    currentState.Leave();
                    currentState = null;
                }
                if(!value.Enter()) {
                    stateNoData.Enter();
                    currentState = stateNoData;
                }
                else
                    currentState = value;
            }
        }
        protected override bool HideCustFormWhenSwitchDemo {
            get { return false; }
        }

        public ServerMode() {
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\ServerMode.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.ServerMode.xml";

            ServerParameters.LoadParameters();

            stateNoData = new NoDataState(this);
            stateLinq2Sql = new Linq2SqlState(this);

            State = stateNoData;
        }

		//<panelFieldCust>
        void ServerMode_Load(object sender, EventArgs e) {
            pivotGridControl.FieldsCustomization(panelFieldCust);
            State = stateLinq2Sql;
        }
		//</panelFieldCust>

        void btnGenerateDataSource_Click(object sender, EventArgs e) {
            RunDBGenerator(State);
        }

        void btnGenerateDatasourceLarge_Click(object sender, EventArgs e) {
            RunDBGenerator(stateLinq2Sql);
        }

        void RunDBGenerator(DemoState nextState) {
            using(frmSQLConnector formConnector = new frmSQLConnector(State.DBGeneratorString)) {
                if(formConnector.ShowDialog() == DialogResult.OK) {
                    if(State == nextState)
                        pivotGridControl.RefreshData();
                    else
                        State = nextState;
                }
            }
        }

        long startMemory;
        void pivotGridControl_AsyncOperationStarting(object sender, EventArgs e) {
            lcTimeTaken.Text = "Working...";
            timer.Restart();
            startMemory = GC.GetTotalMemory(true);
        }

        void pivotGridControl_AsyncOperationCompleted(object sender, EventArgs e) {
            timer.Stop();
            lcTimeTaken.Text = timer.ElapsedMilliseconds.ToString();
        }

        abstract class DemoState {
            protected ServerMode demo;

            public abstract string DBGeneratorString { get; }

            public DemoState(ServerMode demo) {
                this.demo = demo;
            }
            public abstract bool Enter();
            public abstract void Leave();
        }

        class NoDataState : DemoState {
            public override string DBGeneratorString { get { return "Start Demo"; } }

            public NoDataState(ServerMode demo)
                : base(demo) {
            }

            public override bool Enter() {
                //demo.PnlDemo.Visible = false;
                demo.PnlNoConnection.Visible = true;
                demo.PnlNoConnection.Enabled = true;
                return true;
            }
            public override void Leave() {
            }
        }

        abstract class DataState : DemoState {
            bool firstEnter = true;

            public override string DBGeneratorString { get { return "Return to demo"; } }

            protected abstract int RgDataSourcesSelectedIndex { get; }

            public DataState(ServerMode demo)
                : base(demo) {
            }

            protected abstract bool LoadData();
            protected abstract void CleanData();

            public override bool Enter() {
                demo.PnlDemo.Enabled = false;
                demo.PnlNoConnection.Enabled = false;
                bool result = LoadData();
                if(result) {
                    demo.PnlDemo.Visible = true;
                    demo.PnlDemo.Enabled = true;
                    demo.PnlNoConnection.Visible = false;
                }
                else if(!firstEnter) {
                    XtraMessageBox.Show("Failed to load data. Use the Generate Database button to check the connection parameters or generate a new sample database.", "Server Mode Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(firstEnter)
                    firstEnter = false;
                return result;
            }

            public override void Leave() {
                CleanData();
            }
        }

        class Linq2SqlState : DataState {
            PivotGridDemoDBDataContext dataContext;

            public Linq2SqlState(ServerMode demo)
                : base(demo) {
            }
            //<rgDataSources>
            protected override bool LoadData() {
                dataContext = DatabaseHelper.GetContext();
                if(dataContext == null)
                    return false;
                try {
                    LinqServerModeSource dataSource = new LinqServerModeSource();
                    dataSource.QueryableSource = dataContext.Sales;
                    demo.PivotDataSource = dataSource;
                }
                catch {
                    return false;
                }
                return true;
            }
            //</rgDataSources>
            protected override void CleanData() {
                demo.PivotDataSource = null;
                if(dataContext != null) {
                    dataContext.Dispose();
                    dataContext = null;
                }
            }
            protected override int RgDataSourcesSelectedIndex { get { return 0; } }
        }
    }
}
