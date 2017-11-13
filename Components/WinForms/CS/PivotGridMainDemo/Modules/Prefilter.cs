using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using System.Globalization;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class Prefilter : TutorialControl {
        bool initialized;

		public Prefilter() {
			CreateWaitDialog();
			InitializeComponent();

            TutorialInfo.WhatsThisCodeFile = "CS\\PivotGridMainDemo\\Modules\\Prefilter.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraPivotGrid.Demos.CodeInfo.Prefilter.xml";

			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            initialized = true;
            ApplyPrefilter();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        //<dateEdit1>
        //<dateEdit2>
		private void dateEdit_EditValueChanged(object sender, EventArgs e) {
            if(initialized)
			    ApplyPrefilter();
		}

		void ApplyPrefilter() {
			string str1 = GetCriteria(dateEdit1.DateTime, true),
				str2 = GetCriteria(dateEdit2.DateTime, false);

			if(!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(str2))
				pivotGridControl1.Prefilter.Criteria = CriteriaOperator.Parse(str1 + " And " + str2);
			else
				pivotGridControl1.Prefilter.Criteria = CriteriaOperator.Parse(str1 + str2);
		}        
		string GetCriteria(DateTime date, bool isGreater) {
			if(date.Ticks == 0) return "";
			return string.Format("{0} {1} #{2}#", fieldOrderDate.Name, isGreater ? ">=" : "<=", 
                Convert.ToString(date, CultureInfo.InvariantCulture));
		}
        //</dateEdit2>
        //</dateEdit1>
	}
}
