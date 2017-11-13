using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using PivotGridOlapBrowser.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace PivotGridOlapBrowser {
    public enum DataState {
        Default,
        SingleColumn,
        SingleRow
    }
    public partial class BrowserPivot : UserControl, IXRControlCreatable {
        static readonly object evtIsBusyChanged = new object();

        bool fIsBusy;
        string fConnectionString;

        readonly MemberPropertiesToolTipController memberTooltipController;

        public BrowserPivot() {
            InitializeComponent();
            this.memberTooltipController = new MemberPropertiesToolTipController(pivotGrid);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsBusy {
            get { return fIsBusy; }
            protected set {
                if(fIsBusy == value) return;
                fIsBusy = value;
                OnIsBusyChanged();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ConnectionString {
            get { return fConnectionString; }
            set {
                if(fConnectionString == value) return;
                fConnectionString = value;
                OnConnectionStringChanged();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PivotGridFieldCollection Fields {
            get { return pivotGrid.Fields; }
        }
        
        public void SaveLayoutToStream(Stream stream) {
            pivotGrid.SaveLayoutToStream(stream);
        }

        public void SaveCollapsedStateToStream(Stream stream) {
            pivotGrid.SaveCollapsedStateToStream(stream);
        }

        public PivotGridAdomdDataSource DataSourceClone { 
            get { 
                return pivotGrid.CreateOLAPDataSourceClone() as PivotGridAdomdDataSource; 
            }
        }

        public event EventHandler IsBusyChanged {
            add { Events.AddHandler(evtIsBusyChanged, value); }
            remove { Events.RemoveHandler(evtIsBusyChanged, value); }
        }

        public event PivotCellEventHandler CellDoubleClick {
            add { pivotGrid.CellDoubleClick += value; }
            remove { pivotGrid.CellDoubleClick -= value; }
        }

        public DataTable Data { 
            get {
                return PivotDataExtractor.GetDataTable(pivotGrid);
            } 
        }

        public DataState State {
            get {
                DataState currentState = DataState.Default;
                if(pivotGrid.GetFieldsByArea(PivotArea.RowArea).Count == 0)
                    currentState = DataState.SingleRow;
                if(pivotGrid.GetFieldsByArea(PivotArea.ColumnArea).Count == 0)
                    currentState = DataState.SingleColumn;
                if(currentState == DataState.Default && pivotGrid.Cells.MultiSelection.SelectedCells.Count > 1) {
                    Rectangle rect = pivotGrid.Cells.MultiSelection.SelectedCells.Rectangle;
                    if(rect.Width == 1)
                        currentState = DataState.SingleRow;
                    if(rect.Height == 1)
                        currentState = DataState.SingleColumn;
                }
                return currentState;
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            pivotGrid.FieldsCustomization(fieldListContainer);
        }

        void pivotGrid_ShowMenu(object sender, DevExpress.XtraPivotGrid.PopupMenuShowingEventArgs e) {
            if(e.MenuType != PivotGridMenuType.Header && e.MenuType != PivotGridMenuType.HeaderArea)
                return;

            foreach(DXMenuItem item in e.Menu.Items) {
                if(object.Equals(item.Tag, -1001)) {
                    e.Menu.Items.Remove(item);
                    break;
                }
            }
        }

        void pivotGrid_BeginRefresh(object sender, EventArgs e) {
            IsBusy = true;
        }

        void pivotGrid_EndRefresh(object sender, EventArgs e) {
            IsBusy = false;
        }

        void pivotGrid_FieldValueExpanding(object sender, PivotFieldValueCancelEventArgs e) {
            IsBusy = true;
        }

        void pivotGrid_FieldValueCollapsing(object sender, PivotFieldValueCancelEventArgs e) {
            IsBusy = true;
        }

        void pivotGrid_FieldValueExpanded(object sender, PivotFieldValueEventArgs e) {
            IsBusy = false;
        }

        void pivotGrid_FieldValueCollapsed(object sender, PivotFieldValueEventArgs e) {
            IsBusy = false;
        }

        void pivotGrid_FieldValueNotExpanded(object sender, PivotFieldValueEventArgs e) {
            IsBusy = false;
            XtraMessageBox.Show("Cannot show details for this item: it has no child items.", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void pivotGrid_MouseMove(object sender, MouseEventArgs e) {
            PivotGridHitInfo hitInfo = pivotGrid.CalcHitInfo(e.Location);
            if(hitInfo.HitTest == PivotGridHitTest.Value
                    && hitInfo.ValueInfo.Field != null && hitInfo.ValueInfo.Field.IsColumnOrRow) {
                IOLAPMember member = pivotGrid.GetFieldValueOLAPMember(hitInfo.ValueInfo.Field, hitInfo.ValueInfo.MinIndex);
                if(member != null) {
                    Point pt = e.Location;
                    pt.Offset(10, 10);
                    this.memberTooltipController.ShowHint(member, pt);
                    return;
                }
            }
            this.memberTooltipController.HideHint(true);
        }

        protected void OnIsBusyChanged() {
            EventHandler handler = (EventHandler)Events[evtIsBusyChanged];
            if(handler != null)
                handler(this, EventArgs.Empty);
        }

        protected void OnConnectionStringChanged() {
            IsBusy = true;
            try {
                pivotGrid.Fields.Clear();
                pivotGrid.OLAPDataProvider = OLAPDataProvider.Adomd;
                pivotGrid.OLAPConnectionString = ConnectionString;
                RetrieveFields();
            } catch(Exception e) {
                throw e;
            } finally {
                IsBusy = false;
            }
        }

        protected void RetrieveFields() {
            pivotGrid.BeginUpdate();
            pivotGrid.RetrieveFields(PivotArea.FilterArea, false);
            for(int i = 0; i < pivotGrid.Fields.Count; i++) {
                pivotGrid.Fields[i].SortMode = PivotSortMode.None;
            }
            pivotGrid.EndUpdate();
        }

        #region IXRControlCreatable Members
        public new XRControl CreateControl() {
            return XRPivotGridEx.Create(this);
        }
        #endregion
    }
}
