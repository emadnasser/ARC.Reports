using DevExpress.VideoRent.Reports;
namespace DevExpress.VideoRent.Win.ModulesReports {
    public partial class CustomerFilmRentsList : ReportModuleBase {
        public CustomerFilmRentsList() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new CustomerFilmRentsListReport();
        }
    }
}