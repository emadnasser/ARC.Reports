using DevExpress.VideoRent.Reports;
namespace DevExpress.VideoRent.Win.ModulesReports {
    public partial class FilmInfoCard : ReportModuleBase {
        public FilmInfoCard() {
            InitializeComponent();
        }

        protected override ReportBase CreateReport() {
            return new FilmInfoCardReport();
        }
    }
}