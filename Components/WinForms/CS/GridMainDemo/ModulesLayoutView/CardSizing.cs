using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos {
    public partial class CardSizing : TutorialControl {
        public CardSizing() {
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\ModulesLayoutView\\CardSizing.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.CardSizing.xml";
            InitData();
        }
        protected virtual void InitData() {
            try {
                var homesTable = VideoCatalogDataSet().Tables["Homes"];
                homesTable.Columns.Add("Image", typeof(Image));
                foreach(DataRow row in homesTable.Rows) {
                    var img = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(row["Photo"] as byte[]);
                    row["Image"] = new Bitmap(img, new Size(351, 234)); // resize to max used size
                }
                gridControl1.DataSource = homesTable;
            }
            catch { }
            //<gridControl1>
            /*
            ~Note: the following code is set at design-time and listed here for educational purposes only.
            
            layoutView1.OptionsView.ShowCardBorderIfCaptionHidden = false;
            layoutView1.OptionsView.ShowCardCaption = false;
            layoutView1.OptionsView.ShowCardLines = false;
            layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            layoutView1.OptionsView.ShowHeaderPanel = false;
            layoutViewTemplateCard.GroupBordersVisible = false;
             */
            //</gridControl1>
        }
        DataSet VideoCatalogDataSet() {
            DataSet ds = new DataSet();
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\Homes.xml");
            if(DBFileName != string.Empty) {
                SetWaitDialogCaption(Properties.Resources.LoadingTables);
                ds.ReadXml(DBFileName);
            }
            return ds;
        }
        Size originalCardMinSize = Size.Empty;
        //<zoomTrackBarControl1>
        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e) {
            if(originalCardMinSize == Size.Empty) originalCardMinSize = layoutView1.CardMinSize;
            double koeff = ((int)zoomTrackBarControl1.EditValue) / 100.0 - 0.2;
            Size newSize = new Size(originalCardMinSize.Width + (int)(originalCardMinSize.Width * koeff), originalCardMinSize.Height + (int)(originalCardMinSize.Height * koeff));
            layoutViewField_colPhoto.EditorPreferredWidth = newSize.Width - 10;
            layoutView1.CardMinSize = newSize;
        }
        //</zoomTrackBarControl1>
    }
}
