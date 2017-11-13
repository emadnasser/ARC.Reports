using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class SpreadsheetMultiplicationTableModel : SpreadsheetModelBase {
        public SpreadsheetMultiplicationTableModel() {
            Width = 10;
            Height = 10;
            CreateInfoCells = true;
            UseSharedFormula = true;

            PreviewModel.CanShowOnlyFirstWorksheet = true;
            PreviewModel.PreviewDocumentAction = "PreviewMultiplicationTable";
        }

        public int Width { get; set; }
        public int Height { get; set; }
        public bool CreateInfoCells { get; set; }
        public bool UseSharedFormula { get; set; }
    }
}
