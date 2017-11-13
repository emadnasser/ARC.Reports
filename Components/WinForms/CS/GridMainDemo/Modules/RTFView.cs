using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for RTFView.
    /// </summary>
    public partial class RTFView : TutorialControl {
        public RTFView() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\RTFView.cs";
            TutorialInfo.WhatsThisXMLFile = "DevExpress.XtraGrid.Demos.CodeInfo.RTFView.xml";
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public override BaseView ExportView { 
            get { 
                if(xtraTabControl1.SelectedTabPageIndex == 0)
                    return gridView1; 
                else
                    return null; 
            } 
        }
        protected override void DoShow() {
            base.DoShow();
            xtraTabControl1.SelectedTabPageIndex = TutorialName.IndexOf("Preview") != -1 ? 1 : 0;
        }
        private void RTFView_Load(object sender, System.EventArgs e) {
            gridControl1.DataSource = ProductInfoCreator.CreateData();
            gridControl2.DataSource = ProductInfoCreator.CreateData();
            InitGrid();
            //<gridControl1>
            /*
            ~ Note: the following property is set at design time and listed here only for demonstration purposes.   
            ~ Assign a RichTextEdit in-place editor to the Notes column via the ColumnEdit property:
                
             DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1 = new XtraEditors.Repository.RepositoryItemRichTextEdit();
             colNotes.ColumnEdit = repositoryItemRichTextEdit1;
            */
            //</gridControl1>
        }
        void InitGrid() {
            gridView1.FocusedColumn = colNotes;
            seCustomHeight.Value = repositoryItemRichTextEdit1.CustomHeight;
            seHIndent.Value = repositoryItemRichTextEdit1.HorizontalIndent;
            seVIndent.Value = repositoryItemRichTextEdit1.VerticalIndent;
            gridView2.ExpandAllGroups();
            gridView2.OptionsBehavior.AllowGroupExpandAnimation = Utils.DefaultBoolean.False;
            repositoryItemRichTextEdit1.BestFitWidth = 400;
        }
        //<gridControl2>
        private void gridView2_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
            using(RichTextEditViewInfo vi = new RichTextEditViewInfo(repositoryItemRichTextEdit2)) {
                ProductInfo info = gridView2.GetRow(e.RowHandle) as ProductInfo;
                vi.LoadText(info.Notes);
                vi.UpdatePaintAppearance();
                vi.PaintAppearance.FillRectangle(e.Cache, e.Bounds);
                vi.CalcViewInfo(e.Graphics, System.Windows.Forms.MouseButtons.None, new Point(0, 0), e.Bounds);
                DevExpress.XtraEditors.Drawing.RichTextEditPainter.DrawRTF(vi, e.Cache);
            }
            e.Handled = true;
        }
        //</gridControl2>
        private void gridView2_MeasurePreviewHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e) {
            using(RichTextEditViewInfo vi = new RichTextEditViewInfo(repositoryItemRichTextEdit2)) {
                ProductInfo info = gridView2.GetRow(e.RowHandle) as ProductInfo;
                vi.LoadText(info.Notes);
                e.RowHeight = vi.CalcHeight(((GridViewInfo)gridView2.GetViewInfo()).CalcRowPreviewWidth(e.RowHandle) - 1) + 2;
            }
        }
        //<seCustomHeight>
        private void seCustomHeight_EditValueChanged(object sender, EventArgs e) {
            repositoryItemRichTextEdit1.CustomHeight = (int)seCustomHeight.Value;
        }
        //</seCustomHeight>

        //<seHIndent>
        private void seHIndent_EditValueChanged(object sender, EventArgs e) {
            repositoryItemRichTextEdit1.HorizontalIndent = (int)seHIndent.Value;
        }
        //</seHIndent>

        //<seVIndent>
        private void seVIndent_EditValueChanged(object sender, EventArgs e) {
            repositoryItemRichTextEdit1.VerticalIndent = (int)seVIndent.Value;
        }
        //</seVIndent>

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            RibbonMenuManager.AllowExport(ExportView);
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
