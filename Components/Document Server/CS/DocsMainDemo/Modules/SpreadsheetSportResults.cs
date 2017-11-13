using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Docs.Demos;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Demos;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetSportResultsModule : SpreadsheetTutorialControl {
		public SpreadsheetSportResultsModule() {
			InitializeComponent();
            RefreshPreview();
            SpreadsheetTutorialPanel.Dock = DockStyle.Fill;
		}
        public override IWorkbook CreateBook() {
            SportResultsDocumentGenerator example = new SportResultsDocumentGenerator(DefaultCulture);
            return example.Generate();
        }
        protected override string DefaultFileName {
            get {
                return "SportResults";
            }
        }
	}
}
