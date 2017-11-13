using System;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSpellChecker;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.SpellChecker;
using System.Windows.Controls;
using System.Globalization;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.SpellChecker;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace ProductsDemo.Modules {
    public partial class RichEditModule : UserControl {
        public RichEditModule() {
            InitializeComponent();
            string path = Utils.GetRelativePath("MailMerge.docx");
            if (string.IsNullOrEmpty(path))
                return;
            this.view.FocusedRowHandleChanged += view_FocusedRowHandleChanged;
            this.richEdit.Options.MailMerge.DataSource = this.grid.ItemsSource;
            this.richEdit.Options.MailMerge.ViewMergedData = true;
            this.richEdit.LoadDocument(path, DocumentFormat.OpenXml);
            OnRowHandleChanged();
        }

        void view_FocusedRowHandleChanged(object sender, DevExpress.Xpf.Grid.FocusedRowHandleChangedEventArgs e) {
            OnRowHandleChanged();
        }
        void OnRowHandleChanged() {
            this.richEdit.Options.MailMerge.ActiveRecord = this.grid.GetListIndexByRowHandle(this.view.FocusedRowHandle);
        }

        void richEdit_StartHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            catHeaderFooterTools.IsVisible = true;
            ribbonControl.SelectedPage = pageHeaderFooterToolsInsert;
        }

        void richEdit_FinishHeaderFooterEditing(object sender, HeaderFooterEditingEventArgs e) {
            catHeaderFooterTools.IsVisible = false;
        }

        void richEdit_SelectionChanged(object sender, EventArgs e) {
            bool isSelectionInTable = richEdit.IsSelectionInTable();
            if (catTableTools.IsVisible != isSelectionInTable) {
                catTableTools.IsVisible = isSelectionInTable;
                if (isSelectionInTable)
                    ribbonControl.SelectedPage = pageTableToolsDesign;
            }

            bool isSelectionInFloatingObject = richEdit.IsFloatingObjectSelected;
            if (catPictureTools.IsVisible != isSelectionInFloatingObject) {
                catPictureTools.IsVisible = isSelectionInFloatingObject;
                if (isSelectionInFloatingObject)
                    ribbonControl.SelectedPage = pagePictureToolsFormat;
            }
        }

        void TableView_FocusedRowChanged(object sender, DevExpress.Xpf.Grid.FocusedRowChangedEventArgs e) {
        }

    }
}
