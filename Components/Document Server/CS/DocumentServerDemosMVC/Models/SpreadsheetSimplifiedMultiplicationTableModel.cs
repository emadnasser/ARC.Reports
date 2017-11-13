using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetSimplifiedMultiplicationTableModel : SpreadsheetModelBase {
        public SpreadsheetSimplifiedMultiplicationTableModel() {
            TableCount = 8;
            ColumnCount = 4;

            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewSimplifiedMultiplicationTable";
        }

        public int ColumnCount { get; set; }
        public int TableCount { get; set; }
    }
}
