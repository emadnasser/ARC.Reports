using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;

namespace PivotGridOlapBrowser.Helpers {
    public class BrowserGrid : GridControl, IXRControlCreatable {
        public BrowserGrid(BrowserPivot pivot) {
            GridView mainView = new GridView();
            mainView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            mainView.OptionsBehavior.Editable = false;            
            MainView = mainView;
        }
        #region IXRControlCreatable Members
        public new XRControl CreateControl() {
            return XRGridEx.Create(this);
        }
        #endregion
    }
}
