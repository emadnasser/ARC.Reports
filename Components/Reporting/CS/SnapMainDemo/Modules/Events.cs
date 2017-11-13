using System;
using System.IO;
using System.Collections.Generic;
using DevExpress.Snap.Core.API;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.UI;
using DevExpress.Snap.Extensions.UI;
using DevExpress.XtraRichEdit.API.Native;

namespace SnapDemos.Modules {
    public partial class Events : SnapTutorialControlBase {
        public Events() {
            InitializeComponent();
            new SnapDemoExceptionsHandler(snapControl1).Install();
            using (WaitDialogForm dlg = new WaitDialogForm("Please wait", "Loading...")) {
                LoadDocument();
                SetDataSource();
                SubscribeEvents();
            }
        }

        protected override RibbonControl RibbonControl { get { return ribbonControl1; } }
        protected override GalleryChangeTableStyleItem GalleryChangeTableStyleItem { get { return galleryChangeTableStyleItem1; } }
        protected override GalleryChangeTableCellStyleItem GalleryChangeTableCellStyleItem { get { return galleryChangeTableCellStyleItem1; } }

        void LoadDocument() {
            string path = FindFilePathByName("Events");
            if (File.Exists(path))
                this.snapControl1.Document.LoadDocument(path, SnapDocumentFormat.Snap);
        }
        void SetDataSource() {
            object dataSource = new EventsDataProvider().GetDataSource();
            snapControl1.DataSource = dataSource;
        }
        void SubscribeEvents() {
            snapControl1.Document.PrepareSnList += OnPrepareSnList;
            snapControl1.Document.PrepareSnListColumns += OnPrepareSnListColumns;
            snapControl1.Document.PrepareSnListDetail += OnPrepareSnListDetail;
        }

        void OnBeforeInsertSnList(object sender, BeforeInsertSnListEventArgs e) {
            e.DataFields = ShowColumnChooserDialog(e.DataFields);
        }

        void OnBeforeInsertSnListColumns(object sender, BeforeInsertSnListColumnsEventArgs e) {
            e.DataFields = ShowColumnChooserDialog(e.DataFields);
        }

        void OnBeforeInsertSnListDetail(object sender, BeforeInsertSnListDetailEventArgs e) {
            e.DataFields = ShowColumnChooserDialog(e.DataFields);
        }

        List<DataFieldInfo> ShowColumnChooserDialog(List<DataFieldInfo> dataFields) {
            ColumnChooserDialog dlg = new ColumnChooserDialog();
            dlg.SetFieldList(dataFields);
            dlg.ShowDialog();
            return dlg.Result;
        }

        void OnPrepareSnList(object sender, PrepareSnListEventArgs e) {
            e.Template.InsertHtmlText(e.Template.Range.Start, "<h1>Auto-generated header</h1>");
        }

        void OnPrepareSnListColumns(object sender, PrepareSnListColumnsEventArgs e) {
            e.Header.InsertHtmlText(e.Header.Range.Start, "<u>Auto-generated header for column</u>\r\n");
        }

        void OnPrepareSnListDetail(object sender, PrepareSnListDetailEventArgs e) {
            e.Template.InsertHtmlText(e.Template.Range.Start, "<h2>Auto-generated header for detail level</h2>");
        }

        void ResetCellStyle(TableCell cell, int rowIndex, int cellIndex) {
            cell.Style = snapControl1.Document.TableCellStyles[0];
        }

        void SetCellStyle(TableCell cell, int rowIndex, int cellIndex) {
            if (rowIndex % 2 == cellIndex % 2)
                cell.Style = snapControl1.Document.TableCellStyles[3];
        }

        void PaintTable() {
            SnapDocument document = snapControl1.Document;
            TableCollection tables = document.Tables;
            if (tables.Count == 0)
                return;
            document.BeginUpdate();
            for (int k = 0; k < tables.Count; k++) {
                Table table = tables[k];
                TableCellProcessorDelegate reset = ResetCellStyle;
                table.ForEachCell(reset);
                TableCellProcessorDelegate setStyle = SetCellStyle;
                table.ForEachCell(setStyle);
            }
            document.EndUpdate();
        }

        void OnAfterInsertSnList(object sender, AfterInsertSnListEventArgs e) {
            PaintTable();
            snapControl1.Document.Selection = e.Range;
        }

        void OnAfterInsertSnListColumns(object sender, AfterInsertSnListColumnsEventArgs e) {
            PaintTable();
            snapControl1.Document.Selection = e.SnList.Field.Range;
        }
        void OnAfterInsertSnListDetail(object sender, AfterInsertSnListDetailEventArgs e) {
            PaintTable();
            snapControl1.Document.Selection = e.Master.Field.Range;
        }

        void OnBeforeListCheckedChanged(object sender, EventArgs e) {
            if (chkBeforeList.Checked)
                snapControl1.Document.BeforeInsertSnList += OnBeforeInsertSnList;
            else
                snapControl1.Document.BeforeInsertSnList -= OnBeforeInsertSnList;
        }

        void OnBeforeColumnsCheckedChanged(object sender, EventArgs e) {
            if (chkBeforeColumns.Checked)
                snapControl1.Document.BeforeInsertSnListColumns += OnBeforeInsertSnListColumns;
            else
                snapControl1.Document.BeforeInsertSnListColumns -= OnBeforeInsertSnListColumns;
        }

        void OnBeforeDetailCheckedChanged(object sender, EventArgs e) {
            if (chkBeforeDetail.Checked)
                snapControl1.Document.BeforeInsertSnListDetail += OnBeforeInsertSnListDetail;
            else
                snapControl1.Document.BeforeInsertSnListDetail -= OnBeforeInsertSnListDetail;
        }

        void OnPrepareListCheckedChanged(object sender, EventArgs e) {
            if (chkPrepareList.Checked)
                snapControl1.Document.PrepareSnList += OnPrepareSnList;
            else
                snapControl1.Document.PrepareSnList -= OnPrepareSnList;
        }

        void OnPrepareColumnsCheckedChanged(object sender, EventArgs e) {
            if (chkPrepareColumns.Checked)
                snapControl1.Document.PrepareSnListColumns += OnPrepareSnListColumns;
            else
                snapControl1.Document.PrepareSnListColumns -= OnPrepareSnListColumns;
        }

        void OnPrepareDetailCheckedChanged(object sender, EventArgs e) {
            if (chkPrepareDetail.Checked)
                snapControl1.Document.PrepareSnListDetail += OnPrepareSnListDetail;
            else
                snapControl1.Document.PrepareSnListDetail -= OnPrepareSnListDetail;
        }

        void OnAfterListCheckedChanged(object sender, EventArgs e) {
            if (chkAfterList.Checked)
                snapControl1.Document.AfterInsertSnList += OnAfterInsertSnList;
            else
                snapControl1.Document.AfterInsertSnList -= OnAfterInsertSnList;
        }

        void OnAfterColumnsCheckedChanged(object sender, EventArgs e) {
            if (chkAfterColumns.Checked)
                snapControl1.Document.AfterInsertSnListColumns += OnAfterInsertSnListColumns;
            else
                snapControl1.Document.AfterInsertSnListColumns -= OnAfterInsertSnListColumns;
        }

        void OnAfterDetailCheckedChanged(object sender, EventArgs e) {
            if (chkAfterDetail.Checked)
                snapControl1.Document.AfterInsertSnListDetail += OnAfterInsertSnListDetail;
            else
                snapControl1.Document.AfterInsertSnListDetail -= OnAfterInsertSnListDetail;
        }
    }
}
