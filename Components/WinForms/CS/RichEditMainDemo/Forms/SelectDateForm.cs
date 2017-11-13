using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class SelectDateForm : PopupFormBase {
        bool dateTimeChanged;
        public SelectDateForm() {
            InitializeComponent();
            this.dateNavigator1.DateTime = DateTime.Now;
        }

        protected override void SetEditValue() {
            SetEditValueCore(this.dateNavigator1.DateTime);
        }
        private void dateNavigator1_EditDateModified(object sender, EventArgs e) {
            if (dateTimeChanged)
                OnCommit();
        }
        private void dateNavigator_MouseClick(object sender, MouseEventArgs e) {
            CalendarHitInfo hitInfo = this.dateNavigator1.GetHitInfo(e);
            if (hitInfo.HitTest == CalendarHitInfoType.MonthNumber)
                dateTimeChanged = true;
        }
    }
}
