using DevExpress.XtraReports;

namespace ReportWpfDemo {
    /// <summary>
    /// Interaction logic for IListDataSourceReportModule.xaml
    /// </summary>
    public partial class IListDataSource : ReportModuleBase {
        public IListDataSource() {
            InitializeComponent();
        }
    }

    public class IListDataSourceViewModel : ReportModuleViewModelBase {
        protected override IReport CreateReport() {
            return new XtraReportsDemos.IListDatasource.Report();
        }
    }
}
