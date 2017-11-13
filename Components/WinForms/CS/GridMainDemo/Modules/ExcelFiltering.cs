using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Menu;
using DevExpress.Data.Filtering;

namespace DevExpress.XtraGrid.Demos {
    public partial class ExcelFiltering : TutorialControl {
        public override BaseView ExportView {
            get { return bandedGridView1; }
        }
        protected override void InitMDBData(string connectionString) {
            VehiclesData.InitOrdersData(connectionString, gridControl1, 10000, 400);
            VehiclesData.InitColumnViewEditors(bandedGridView1);
        }
        public ExcelFiltering() {
            CreateWaitDialog();
            InitializeComponent();
            InitVehiclesData();
            bandedGridView1.ActiveFilterCriteria = new GroupOperator(GroupOperatorType.Or,  
                new FunctionOperator(FunctionOperatorType.IsOutlookIntervalYesterday, new OperandProperty("SalesDate")),
                new FunctionOperator(FunctionOperatorType.IsOutlookIntervalToday, new OperandProperty("SalesDate")));
        }
        #region GenerateReport
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
