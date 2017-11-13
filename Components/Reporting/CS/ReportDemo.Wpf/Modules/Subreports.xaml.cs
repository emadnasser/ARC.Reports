using System;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Printing.Parameters.Models;
using DevExpress.XtraReports;

namespace ReportWpfDemo {
    public partial class Subreports : ReportModuleBase {
        public Subreports() {
            InitializeComponent();
        }
    }

    interface IParametersModelProvider {
        ParametersModel ParametersModel { get; }
    }
    [TargetType(typeof(DocumentPreviewControl))]
    public class ParametersModelProvider : ServiceBase, IParametersModelProvider {
        ParametersModel IParametersModelProvider.ParametersModel {
            get {
                return IsAttached
                    ? (AssociatedObject as DocumentPreviewControl).With(x => x.ParametersModel)
                    : null;
            }
        }
    }

    public class SubreportsViewModel : ReportModuleViewModelBase {
        const string FromDateParameterName = "fromDateParameter";
        const string ToDateParameterName = "toDateParameter";
        ParametersModel ParametersModel { get { return GetService<IParametersModelProvider>().With(x => x.ParametersModel); } }

        void ParametersModel_Validate(object sender, ValidateParameterEventArgs e) {
            if(e.ParameterModel.Name == FromDateParameterName) {
                if(!(e.ParameterModel.Value is DateTime)) {
                    e.Error = "Please enter a valid Date.";
                }
            }

            if(e.ParameterModel.Name == ToDateParameterName) {
                if(!(e.ParameterModel.Value is DateTime)) {
                    e.Error = "Please enter a valid Date.";
                }
                var fromDateParameter = ParametersModel.FindParameterByName(FromDateParameterName);
                if(fromDateParameter == null || !(fromDateParameter.Value is DateTime)) {
                    return;
                }
                e.Error = (DateTime)e.ParameterModel.Value < (DateTime)fromDateParameter.Value ? "The end date should be grater than the start date." : string.Empty;
            }
        }

        protected override IReport CreateReport() {
            ParametersModel.Do(x => {
                x.Validate -= ParametersModel_Validate;
                x.Validate += ParametersModel_Validate;
            });
            return new XtraReportsDemos.Subreports.MasterReport();
        }
    }
}
