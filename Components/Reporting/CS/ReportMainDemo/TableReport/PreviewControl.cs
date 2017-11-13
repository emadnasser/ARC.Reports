using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.Extensions;

namespace XtraReportsDemos.TableReport
{
    public class PreviewControl : XtraReportsDemos.PreviewControl {
        class TableReportExtension : DemoReportExtension {
            public override Type[] GetEditableDataTypes() {
                return new Type[] { typeof(int) };
            }
            protected override RepositoryItem CreateRepositoryItem(Parameter parameter, Type dataType, XtraReport report) {
                if(parameter.Name == "OrderIdParameter") {
                    RepositoryItemSpinEdit item = new RepositoryItemSpinEdit();
                    item.IsFloatValue = false;
                    item.MinValue = 10248;
                    item.MaxValue = 11077;
                    return item; 
                }
                if(parameter.Name == "MaxRowCountParameter") {
                    RepositoryItemSpinEdit item = new RepositoryItemSpinEdit();
                    item.IsFloatValue = false;
                    item.MinValue = 1;
                    item.MaxValue = Decimal.MaxValue;
                    return item;
                }
                return null;
            }
        }

        static PreviewControl() {
            ReportDesignExtension.RegisterExtension(new TableReportExtension(), XtraReportsDemos.ReportNames.TableReport);
        }

		public PreviewControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();			
		}
		
		protected override XtraReport CreateReport() {
			Report report = new Report();
            ReportDesignExtension.AssociateReportWithExtension(report, XtraReportsDemos.ReportNames.TableReport);
            return report;
		}
		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // PreviewControl
            // 
            this.Name = "PreviewControl";
            this.ResumeLayout(false);

		}
		#endregion
	}
}

