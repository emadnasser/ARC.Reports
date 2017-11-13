using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Helpers;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    public partial class GridFilterPopupDate : TutorialControl {
        private DevExpress.Utils.Frames.NotePanel8_1 pnlHint;
        public GridFilterPopupDate() {
            InitializeComponent();
            UpdateHint();
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if(info == null) return;
            info.GroupText = info.GroupText.Replace("1 items", "1 item");
        }

        private void Form1_Load(object sender, EventArgs e) {
            gridControl1.DataSource = OutlookData.CreateDataTable();
            gridView1.ActiveFilterString = "IsOutlookIntervalLastWeek([Received]) Or IsOutlookIntervalYesterday([Received]) Or IsOutlookIntervalToday([Received])";
        }
        //<cbeFilterPopupMode>
        private void cbeFilterPopupMode_SelectedIndexChanged(object sender, EventArgs e) {
            switch(cbeFilterPopupMode.SelectedIndex) {
                case 0: colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Date;
                    break;
                case 1: colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart;
                    break;
                case 2: colReceived.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
                    break;
            }
            //<skip>
            UpdateHint();
            //</skip>
        }
        private void gridView1_ShowFilterPopupDate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupDateEventArgs e) {
            if(cbeFilterPopupMode.SelectedIndex != 3) return;
            if(e.Column == colReceived) {
                e.List.Clear();
                CriteriaOperator crit = new OperandProperty(e.Column.FieldName);
                
                for(int i = 1; i < 8; i++)
                    e.List.Add(new FilterDateElement(
                        GetDayName(i), string.Empty, 
                        (crit >= DateTime.Today.AddDays(-i)) & (crit < DateTime.Today.AddDays(-i + 1))));
            }
        }
        string GetDayName(int i) {
            if(i == 1) return "Yesterday";
            if(i == 2) return "The day before yesterday";
            return string.Format("Last {0:dddd}", DateTime.Today.AddDays(-i));
        }
        //</cbeFilterPopupMode>
        void UpdateHint() {
            CreatePanelHint();
            string[] hints = new string[] {
                "Date: the filter dropdown includes all the available check boxes to select date ranges: Today, Yesterday, Earlier this Week, etc.", 
                "DateSmart: the filter dropdown includes the Today, Yesterday, Earlier this Week and other check boxes. However, if there is no underlying data that would fall into a specific date range, the corresponding check box is hidden.", 
                "DateAlt: this mode is equivalent to DateSmart, but with a different set of filters: Today, This week, This month, Next month, etc.",
                "Custom: the filter dropdown is populated manually via the ShowFilterPopupDate event."
            };
            pnlHint.Text = hints[cbeFilterPopupMode.SelectedIndex];
        }

        void CreatePanelHint() {
            if(pnlHint != null) return;
            this.pnlHint = new DevExpress.Utils.Frames.NotePanel8_1();
            this.pnlHint.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.pnlHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHint.MaxRows = 10;
            this.pnlHint.Parent = panelControl1;
            this.pnlHint.BringToFront();
        }
    }
}
