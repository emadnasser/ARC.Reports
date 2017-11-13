using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using System.Drawing.Drawing2D;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class Layout3D : TutorialControl {
        public Layout3D() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesLayoutView\\Layout3D.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.Layout3D.xml";
            InitData();
            gridControl1.ForceInitialize();
            //<gridControl1>
            Timer tmr = new Timer();
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
            //</gridControl1>
        }
        //<gridControl1>
        void tmr_Tick(object sender, EventArgs e) {
            layoutView1.MoveBy(layoutView1.RowCount / 2 - 1);
            ((Timer)sender).Stop();
        }
        //</gridControl1>
        protected virtual void InitData() {
            try {
                gridControl1.DataSource = VideoCatalogDataSet().Tables["Movie"];
            }
            catch { }
        }
        DataSet VideoCatalogDataSet() {
            DataSet ds = new DataSet();
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\VideoRent.xml");
            if(DBFileName != string.Empty) {
                SetWaitDialogCaption(Properties.Resources.LoadingTables);
                ds.ReadXml(DBFileName);
            }
            return ds;
        }

        //<cardsCount>
        private void cardsCount_EditValueChanged(object sender, EventArgs e) {
            if(!IsHandleCreated) return;
            layoutView1.OptionsCarouselMode.CardCount = (int)cardsCount.EditValue;
        }
        //</cardsCount>
        //<flatFactor>
        private void flatFactor_EditValueChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.PitchAngle = (float)(((int)flatFactor.EditValue) / 360.0f * 2 * Math.PI);
        }
        //</flatFactor>
        //<rollAngle>
        private void rollAngle_EditValueChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.RollAngle = (float)(((int)rollAngle.EditValue) / 360.0f * 2 * Math.PI);
        }
        //</rollAngle>
        //<endSizeScale>
        private void endSizeScale_EditValueChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.BottomCardScale = ((int)endSizeScale.EditValue) / 100.0f;
        }
        //</endSizeScale>
        //<endAlpha>
        private void endAlpha_EditValueChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.BottomCardAlphaLevel = ((int)endAlpha.EditValue) / 100.0f;
        }
        //</endAlpha>
        //<bottomCardFading>
        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.BottomCardFading = ((int)bottomCardFading.EditValue) / 100.0f;
        }
        //</bottomCardFading>
        private void Layout3D_Load(object sender, EventArgs e) {
            foreach(InterpolationMode modeName in Enum.GetValues(typeof(InterpolationMode))) {
                if(modeName == InterpolationMode.Invalid) continue;
                comboBoxEdit1.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<InterpolationMode>.GetTitle(modeName), modeName, -1));
            }
            comboBoxEdit1.EditValue = InterpolationMode.Default;
        }
        //<comboBoxEdit1>
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            layoutView1.OptionsCarouselMode.InterpolationMode = (InterpolationMode)comboBoxEdit1.EditValue;
        }
        //</comboBoxEdit1>
    }
}
