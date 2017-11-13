using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for ViewStyles.
    /// </summary>
    public partial class ViewStyles : TutorialControl {
        public ViewStyles() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\ViewStyles.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.ViewStyles.xml";
            gridControl1.ForceInitialize();
            InitVehiclesData();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #region Init

        protected override void InitMDBData(string connectionString) {
            VehiclesData.InitMDBData(connectionString, gridControl1);
            VehiclesData.InitColumnViewEditors(advBandedGridView1);
            VehiclesData.InitColumnViewEditors(bandedGridView1);
            VehiclesData.InitColumnViewEditors(gridView1);
            VehiclesData.InitColumnViewEditors(cardView1);
        }
        #endregion
        #region Change view
        public override BaseView ExportView { get { return gridControl1.MainView; } }
        //<chGrid>
        //<chBanded>
        //<chCard>
        //<chAdvBanded>
        private void ChangeView(string viewType) {
            chGrid.Checked = chCard.Checked = chBanded.Checked = chAdvBanded.Checked = false;
            switch(viewType) {
                case "GridView":
                    chGrid.Checked = true;
                    gridControl1.MainView = gridView1;
                    break;
                case "CardView":
                    chCard.Checked = true;
                    gridControl1.MainView = cardView1;
                    break;
                case "Banded GridView":
                    chBanded.Checked = true;
                    gridControl1.MainView = bandedGridView1;
                    bandedGridView1.ExpandAllGroups();
                    break;
                case "Advanced Banded GridView":
                    chAdvBanded.Checked = true;
                    gridControl1.MainView = advBandedGridView1;
                    break;
            }
            //<skip>
            OnSetCaption(viewType);
            //</skip>
        }
        //</chGrid>
        //</chBanded>
        //</chCard>
        //</chAdvBanded>
        protected override void OnSetCaption(string fCaption) {
            if(fCaption == string.Empty) fCaption = GetCheckedCaption();
            if(Caption != null)
                Caption.Text = string.Format("{0} ({1})", TutorialName, fCaption);
            GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.MainView);
        }
        private string GetCheckedCaption() {
            foreach(Control ctrl in panelControl1.Controls) {
                CheckButton button = ctrl as CheckButton;
                if(button != null && button.Checked)
                    return button.Tag.ToString();
            }
            return string.Empty;
        }
        #endregion
        #region GridView events
        private void gridView1_DragObjectOver(object sender, DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs e) {
            if(e.DragObject is GridColumn) {
                DevExpress.XtraGrid.Dragging.ColumnPositionInfo cpi = e.DropInfo as DevExpress.XtraGrid.Dragging.ColumnPositionInfo;
                if(e.DropInfo.Index == 0 && !cpi.InGroupPanel) e.DropInfo.Valid = false;
            }
        }
        #endregion

        bool updateInfo = false;
        //<chGrid>
        //<chBanded>
        //<chCard>
        //<chAdvBanded>
        private void ch_CheckedChanged(object sender, EventArgs e) {
            if(updateInfo) return;
            OnButtonChecked(sender as CheckButton);
        }

        private void OnButtonChecked(CheckButton button) {
            if(button.Tag == null) return;
            updateInfo = true;
            string caption = button.Tag.ToString();
            ChangeView(caption);
            updateInfo = false;
        }
        //</chGrid>
        //</chBanded>
        //</chCard>
        //</chAdvBanded>
        #region CardView events
        private void cardView1_CustomCardCaptionImage(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionImageEventArgs e) {
            VehiclesData.Model model = cardView1.GetRow(e.RowHandle) as VehiclesData.Model;

            e.Image = model.GetSmallTrademarkImage();

        }

        private void cardView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            if(cardView1.FocusedColumn.FieldName == "Trademark")
                this.BeginInvoke(new MethodInvoker(delegate { cardView1.LayoutChanged(); }));
        }
        #endregion
    }
}
