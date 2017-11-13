using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using System;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class AsynchronousMode : TutorialControl {
        bool isDataBaseGeneratorRunned = false;
		ActionState actionState = ActionState.Normal;

        protected override bool HideCustFormWhenSwitchDemo {
            get { return false; }
        }
        public AsynchronousMode() {
            CreateWaitDialog();
            InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\AsyncMode.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.AsyncMode.xml";

            rgDataSources.SelectedIndex = 0;
            ServerParameters.LoadParameters();
        }
        void AsynchronousMode_Load(object sender, System.EventArgs e) {
            pivotGridControl.FieldsCustomization(splitContainerControl1.Panel2);
            UpdateGenerateDataSourceButtonPosition();
        }
        void AsynchronousMode_Resize(object sender, System.EventArgs e) {
            UpdateGenerateDataSourceButtonPosition();
        }
        void splitContainerControl1_SplitterMoved(object sender, EventArgs e) {
            UpdateGenerateDataSourceButtonPosition();
        }
        void UpdateGenerateDataSourceButtonPosition() {
            btnGenerateDataSource.Left = Math.Max(splitContainerControl1.SplitterBounds.Left - btnGenerateDataSource.Width, rgDataSources.Right + rgDataSources.Margin.Right);
        }
        //<btnGenerateDataSource>
        void btnGenerateDataSource_Click(object sender, EventArgs e) {
            RunDBGenerator("Return to Demo");
        }
        //</btnGenerateDataSource>
        //<rgDataSources>
        void rgDataSources_SelectedIndexChanged(object sender, EventArgs e) {
            DisableControls();
            switch(rgDataSources.SelectedIndex) {
                case 0:
                    Initialize(InitializerDataSource.OlapCube);
                    break;
                case 1:
                    Initialize(InitializerDataSource.TableDataSource);
                    break;
            }
        }
        //</rgDataSources>
        //<btnGenerateDataSource>
        void RunDBGenerator(string demoString) {
            using(frmSQLConnector formConnector = new frmSQLConnector(demoString)) {
                formConnector.ShowDialog();
                if(rgDataSources.SelectedIndex == 1) {
                    rgDataSources.Enabled = false;
                    isDataBaseGeneratorRunned = true;
                    Initialize(InitializerDataSource.TableDataSource);
                }
            }
        }
        //</btnGenerateDataSource>
        void Initialize(InitializerDataSource dataSourceType) {
			actionState = ActionState.Connect;
            AsynchronousPivotInitializer.Initialize(pivotGridControl, AsyncInitializationCompleted, dataSourceType);
			actionState = ActionState.Normal;
        }
        void DisableControls() {
            rgDataSources.Enabled = false;
            btnGenerateDataSource.Enabled = false;
        }
        void EnableControls() {
            rgDataSources.Enabled = true;
            btnGenerateDataSource.Enabled = true;
        }
        void AsyncInitializationCompleted(AsyncOperationResult result) {
            EnableControls();
            if(result == null) {
                if(!isDataBaseGeneratorRunned)
                    RunDBGenerator("Start Demo");
                pivotGridControl.Enabled = false;
                labelError.Text = rgDataSources.SelectedIndex == 0 ? AsynchronousPivotInitializer.OlapError : AsynchronousPivotInitializer.TableError;
                panelError.Visible = true;
            } else {
                pivotGridControl.Enabled = true;
                panelError.Visible = false;
            }
        }
        //<pivotGridControl>
        void pivotGridControl1_CellDoubleClick(object sender, PivotCellEventArgs e) {
			actionState = ActionState.DrillDown;
            AsyncCompletedHandler showDrillDownAction = delegate(AsyncOperationResult result) {
				if(result.Exception != null)
					XtraMessageBox.Show(result.Exception.Message);
				else
					ShowDrillDown((PivotDrillDownDataSource)result.Value);
				actionState = ActionState.Normal;
            };
            pivotGridControl.CreateDrillDownDataSourceAsync(e.ColumnIndex, e.RowIndex, showDrillDownAction);
        }
        void ShowDrillDown(PivotDrillDownDataSource drillDownDataSource) {
            if(drillDownDataSource.RowCount == 0) {
                //Also shows for calculated datafields in this demo
                XtraMessageBox.Show("DrillDown doesn't contains results");
                return;
            }
            XtraForm form = new XtraForm();
            form.Text = String.Format("Drill Down Results: {0} Rows", drillDownDataSource.RowCount);
            form.Width = 520;
            form.Height = 300;
            form.StartPosition = FormStartPosition.CenterParent;
            DataGridView grid = new DataGridView();
            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            grid.DataSource = drillDownDataSource;
            form.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(AsynchronousMode).Assembly);
            form.ShowDialog();
            form.Dispose();
        }
        //</pivotGridControl>
        void pivotGridControl_AsyncOperationCompleted(object sender, EventArgs e) {
            EnableControls();
        }
        void pivotGridControl_AsyncOperationStarting(object sender, EventArgs e) {
            DisableControls();
        }

		void pivotGridControl_QueryException(object sender, PivotQueryExceptionEventArgs e) {
			if(actionState == ActionState.Normal)
				e.Handled = true;
		}
    }
	public enum ActionState {
		Normal,
		Connect,
		DrillDown
	}
}
