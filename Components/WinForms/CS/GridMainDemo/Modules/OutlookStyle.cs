using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for OutlookStyle.
	/// </summary>
	public partial class OutlookStyle : TutorialControl {
        Message currentMessage;
        public OutlookStyle() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\OutlookStyle.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.OutlookStyle.xml";
			//<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            gridView1.OptionsView.GroupDrawMode = Views.Grid.GroupDrawMode.Office;
            gridView1.OptionsView.ShowGroupedColumns = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowVerticalLines = Utils.DefaultBoolean.False;
            */
            //</gridControl1>
            
		}
        
        MailTimer mTimer;
		public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        private void OutlookStyle_Load(object sender, System.EventArgs e) {
            gridView1.OptionsView.ShowPreview = true;
            gridView1.OptionsView.ShowHorizontalLines = Utils.DefaultBoolean.False;
            gridControl1.DataSource = DataHelper.Messages;
            gridView1.SetRowExpanded(-1, true);
            gridView1.SetRowExpanded(-2, true);
            mTimer = new MailTimer(DataHelper.Messages, alertControl1, this.FindForm());
            OnStyleChanged();
            SetAlertControlButtonHint();
            CalcPreviewIndent();
        }

        void SetAlertControlButtonHint() {
            alertControl1.Buttons[0].Hint = Properties.Resources.MarkAsRead;
            alertControl1.Buttons[1].Hint = Properties.Resources.OpenAttachment;
            alertControl1.Buttons[2].Hint = Properties.Resources.DeleteItem;
        }
        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			GridGroupRowInfo info = e.Info as GridGroupRowInfo;
			if(info == null) return;
			info.GroupText = info.GroupText.Replace("1 " + Properties.Resources.Items, "1 " + Properties.Resources.Item);
		}

        protected override void DoShow() {
            base.DoShow();
            gridControl1.Focus();
            mTimer.Start();
        }
        protected override void DoHide() {
            mTimer.Stop();
        }

        #region Alerter
        private void alertControl1_ButtonDownChanged(object sender, AlertButtonDownChangedEventArgs e) {
            if(e.ButtonName == "Read") 
                ToggleRead(e.Info.Tag as Message);
        }
        void RaiseReadMessagesChanged(int rowHandle) {
            Message current = gridView1.GetRow(rowHandle) as Message;
            if(current == null) return;
            current.ToggleRead();
            gridView1.LayoutChanged();
            gridView1.MakeRowVisible(gridView1.FocusedRowHandle);
        }
        private void alertControl1_ButtonClick(object sender, AlertButtonClickEventArgs e) {
            Message data = e.Info.Tag as Message;
            e.AlertForm.OwnerForm.Activate();
            if(e.ButtonName == "Attachment") {
                e.AlertForm.Close();
                XtraMessageBox.Show(FindForm(), "Open attachment dialog.", string.Format("Mail From: {0}", data.From));
            }
            if(e.ButtonName == "Delete") 
                DeleteItem(e, data);
        }
        void OpenItem(Message message) {
            int rowIndex = GetMessageRowHandle(message);
            if(rowIndex > -1) {
                gridView1.FocusedRowHandle = rowIndex;
                gridView1.MakeRowVisible(rowIndex, true);
            }
        }
        int GetMessageRowHandle(Message message) {
            for(int i = 0; i < gridView1.RowCount; i++) {
                if(message.Equals(gridView1.GetRow(i))) {
                    return i;
                }
            }
            return -1;
        }
        void DeleteItem(AlertClickEventArgs args, Message message) {
            args.AlertForm.Close();
            try {
                int rowIndex = GetMessageRowHandle(message);
                if(rowIndex > -1) gridView1.DeleteRow(rowIndex);
                gridView1.LayoutChanged();
                UpdateCurrentMessage();
            }
            catch { }
        }
        private void alertControl1_AlertClick(object sender, AlertClickEventArgs e) {
            Message data = e.Info.Tag as Message;
            OpenItem(data);
        }
        #endregion
        #region AlertPopupMenu
        bool updatePopupMenu = false;
        private void popupMenu1_BeforePopup(object sender, CancelEventArgs e) {
            AlertClickEventArgs args = popupMenu1.ItemLinks[0].Item.Tag as AlertClickEventArgs;
            if(args == null) return;
            Message data = args.Info.Tag as Message;
            updatePopupMenu = true;
            if(1.Equals(data.Read)) {
                biRead.Caption = Properties.Resources.UnreadMark;
                biRead.ImageIndex = 2;
            }
            else {
                biRead.Caption = Properties.Resources.ReadMark;
                biRead.ImageIndex = 1;
            }
            if(data.Priority == 0) bcLow.Checked = true;
            if(data.Priority == 1) bcMedium.Checked = true;
            if(data.Priority == 2) bcHigh.Checked = true; 
            updatePopupMenu = false;
        }
        private void biOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AlertClickEventArgs args = e.Item.Tag as AlertClickEventArgs;
            OpenItem(args.Info.Tag as Message);
        }
        private void biRead_ItemClick(object sender, ItemClickEventArgs e) {
            AlertClickEventArgs args = e.Item.Tag as AlertClickEventArgs;
            Message message = args.Info.Tag as Message;
            ToggleRead(message);
            args.AlertForm.Buttons["Read"].Down = message.Read == 1;
        }
        private void biDelete_ItemClick(object sender, ItemClickEventArgs e) {
            AlertClickEventArgs args = e.Item.Tag as AlertClickEventArgs;
            DeleteItem(args, args.Info.Tag as Message);
        }
        private void bc_DownChanged(object sender, ItemClickEventArgs e) {
            if(updatePopupMenu) return;
            AlertClickEventArgs args = e.Item.Tag as AlertClickEventArgs;
            Message data = args.Info.Tag as Message;
            BarCheckItem item = e.Item as BarCheckItem;
            if(!item.Checked) return;
            if(bcLow.Checked) data.Priority = 0;
            if(bcMedium.Checked) data.Priority = 1;
            if(bcHigh.Checked) data.Priority = 2;
            gridView1.LayoutChanged();
        }
        private void barManager1_ItemClick(object sender, ItemClickEventArgs e) {
            AlertClickEventArgs args = e.Item.Tag as AlertClickEventArgs;
            if(args == null) return;
            args.AlertForm.OwnerForm.Activate();
        }
        void ToggleRead(Message message) {
            message.ToggleRead();
            gridView1.LayoutChanged();
        }
        #endregion

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e) {
            GridHitInfo hi = gridView1.CalcHitInfo(new Point(e.X, e.Y));
            if(hi.InRow && gridView1.FocusedRowHandle > -1) {
                mTimer.ShowAlert(gridView1.GetFocusedRow() as Message);
            }
        }

        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            ColorHelper.UpdateColor(ilColumns, gridControl1.LookAndFeel);
        }

        private void gridView1_FocusedRowChanged(object sender, Views.Base.FocusedRowChangedEventArgs e) {
            UpdateCurrentMessage();
        }

        private void gridView1_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateCurrentMessage();
        }
        Message CurrentMessage {
            get { return currentMessage; }
            set {
                if(currentMessage == value) return;
                currentMessage = value;
                ucMailViewer1.ShowMessage(CurrentMessage);
            }
        }
        void UpdateCurrentMessage() {
            if(gridView1.FocusedRowHandle >= 0)
                CurrentMessage = gridView1.GetFocusedRow() as Message;
            else {
                List<Message> rows = new List<Message>();
                ObjectHelper.GetChildDataRowHandles(gridView1, gridView1.FocusedRowHandle, rows);
                ucMailViewer1.ShowMessagesInfo(rows);
                CurrentMessage = null;
            }
        }

        private void gridView1_RowCellClick(object sender, Views.Grid.RowCellClickEventArgs e) {
            if(e.Column == gridColumn7 && e.Button == MouseButtons.Left)
                RaiseReadMessagesChanged(e.RowHandle);
        }
        void CalcPreviewIndent() {
            int indent = 0;
            foreach(GridColumn column in gridView1.VisibleColumns) {
                if("Priority;Read;Attachment".IndexOf(column.FieldName) > -1)
                    indent += column.Width;
                else break;
            }
            gridView1.PreviewIndent = indent;
        }

        private void gridView1_ColumnPositionChanged(object sender, EventArgs e) {
            CalcPreviewIndent();
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
