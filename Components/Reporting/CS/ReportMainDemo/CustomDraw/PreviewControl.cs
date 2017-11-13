using DevExpress.XtraReports.Extensions;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CustomDraw {
    public class PreviewControl : XtraReportsDemos.PreviewControl {

        public PreviewControl() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>		

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // PreviewControl
            // 
            this.Name = "PreviewControl";
            this.ResumeLayout(false);

        }
        #endregion

        protected override XtraReport CreateReport() {
            CustomDraw.Report report = new CustomDraw.Report();
            ReportDesignExtension.AssociateReportWithExtension(report, XtraReportsDemos.ReportNames.CustomDraw);
            return report;
        }
    }
}
