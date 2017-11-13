using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.Spreadsheet;
using System.Collections;
using DevExpress.Export;

namespace DevExpress.XtraTreeList.Demos {
    public partial class ClipboardFormats : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList ExportControl { get { return treeList; } }
        public ClipboardFormats() {
            InitializeComponent();
            Init();
        }
        void Init() {
            propertyGridControl.SelectedObject = treeList.OptionsClipboard;
            propertyGridControl.ExpandAllRows();
            gridViewPropertiesLayoutGroup.Expanded = false;
        }

        internal void PasteClipboardData() {
            PasteHTMLFormat();
            PasteXLSFormat();
            PasteRTFFormat();
        }
        void PasteRTFFormat() {
            richEditControl.Document.RtfText = string.Empty;
            richEditControl.Document.Text = string.Empty;
            try {
                if(treeList.OptionsClipboard.ClipboardMode == Export.ClipboardMode.Formatted) {
                    richEditControl.Document.AppendRtfText(Clipboard.GetText(TextDataFormat.Rtf));
                } else {
                    richEditControl.Document.AppendText(Clipboard.GetText(TextDataFormat.UnicodeText));
                }
            } catch { }
        }

        void PasteXLSFormat() {
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange());
            try {
                if(treeList.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                    spreadsheetControl1.LoadDocument(Clipboard.GetDataObject().GetData("Biff8") as Stream, DocumentFormat.Xls);
                } else {
                    int nextRow = 0;
                    foreach(var line in Clipboard.GetText(TextDataFormat.UnicodeText).Split('\n')) {
                        spreadsheetControl1.ActiveWorksheet.Import(line.Split('\t'), nextRow, 0, false);
                        nextRow++;
                    }
                }
            } catch { }
            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width / treeList.Columns.Count;
        }

        void PasteHTMLFormat() {
            if(treeList.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                string html = "";
                try {
                    html = Clipboard.GetText(TextDataFormat.Html);
                } catch { }
                if(string.IsNullOrEmpty(html)) {
                    webBrowser1.DocumentText = string.Empty;
                    return;
                }
                html = html.Remove(0, html.Substring(0, html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)).Length);
                webBrowser1.DocumentText = html;
            } else {
                webBrowser1.DocumentText = "<html><body><p align=\"center\">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>";
            }
        }

        void simpleButtonCopyPaste_Click(object sender, EventArgs e) {
            treeList.CopyAndPaste();
        }

        void layoutControl1_GroupExpandChanged(object sender, XtraLayout.Utils.LayoutGroupEventArgs e) {
            if(gridViewPropertiesLayoutGroup.Expanded) {
                splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            } else splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }

        void ClipboardFormats_Load(object sender, EventArgs e) {
            treeList.DataSource = SalesDataGenerator.CreateData();
            treeList.ExpandAll();
            treeList.ForceInitialize();
            treeList.BestFitColumns();
            treeList.SelectCells(treeList.Nodes[0], colRegion, treeList.Nodes[0].LastNode, colMarketShare);
        }
    }
    public class ClipboardTreeListControl :TreeList {
        ClipboardFormats userControlCore;
        internal ClipboardFormats ClipboardFormats {
            get {
                if(userControlCore == null)
                    userControlCore = Parent.Parent as ClipboardFormats;
                return userControlCore;
            }
        }
        public void CopyAndPaste() {
            OnKeyDown(new KeyEventArgs(Keys.Control | Keys.C));
        }
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if(e.Control && e.KeyCode == Keys.C) {
                ClipboardFormats.PasteClipboardData();
            }
        }
    }
}
