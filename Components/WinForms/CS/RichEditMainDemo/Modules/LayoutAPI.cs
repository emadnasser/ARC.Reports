using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class LayoutAPI : DevExpress.XtraRichEdit.Demos.TutorialControl {
        List<LayoutInfoItem> layoutInfos = new List<LayoutInfoItem>();
        DevExpress.XtraEditors.BaseEdit gridViewActiveEditor;
        int pageCount = 1;
        int activePageNumber = 1;

        public LayoutAPI() {
            InitializeComponent();
            IntPtr handle = Handle; //force to initialize handle
            richEditControl.DocumentLayout.DocumentFormatted += OnDocumentFormatted;
            OpenXmlLoadHelper.Load("FloatingObjects.docx", richEditControl);
            new RichEditDemoExceptionsHandler(richEditControl).Install();
            InitializeLayoutInfos();
            this.gridControl1.DataSource = LayoutInfos;
            gridView1.ShownEditor += gridView_ShownEditor;
            gridView1.HiddenEditor += gridView_HiddenEditor;
        }

        public List<LayoutInfoItem> LayoutInfos { get { return layoutInfos; } }
        int PageCount {
            get { return pageCount; }
            set {
                if (pageCount == value)
                    return;
                pageCount = value;
                OnPagesInfoChanged();
            }
        }
        int ActivePageNumber {
            get { return activePageNumber; }
            set {
                if (activePageNumber == value)
                    return;
                activePageNumber = value;
                OnPagesInfoChanged();
            }
        }

        void OnPagesInfoChanged() {
            barStatusInfo.Caption = String.Format("Page: {0} of {1}", ActivePageNumber, PageCount);
        }
        void gridView_ShownEditor(object sender, EventArgs e) {
            gridViewActiveEditor = gridView1.ActiveEditor;
            gridViewActiveEditor.EditValueChanged += ActiveEditor_EditValueChanged;
        }
        void gridView_HiddenEditor(object sender, EventArgs e) {
            gridViewActiveEditor.EditValueChanged -= ActiveEditor_EditValueChanged;
        }
        void ActiveEditor_EditValueChanged(object sender, EventArgs e) {
            gridView1.PostEditor();
            richEditControl.Refresh();
        }
        void OnCustomRowCellEdit(object sender, XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if (e.Column.AbsoluteIndex == 0)
                e.RepositoryItem = new RepositoryItemCheckEdit() { GlyphAlignment = DevExpress.Utils.HorzAlignment.Near, Caption = LayoutInfos[e.RowHandle].Name };
        }
        void InitializeLayoutInfos() {
            LayoutType[] types = (LayoutType[])Enum.GetValues(typeof(LayoutType));
            Random rand = new Random();
            byte[] colorBytes = new byte[3];
            foreach (LayoutType type in types) {
                if (IsDrawingSupported(type)) {
                    rand.NextBytes(colorBytes);
                    LayoutInfos.Add(new LayoutInfoItem(type.ToString(), Color.FromArgb(colorBytes[0], colorBytes[1], colorBytes[2])));
                }
            }
        }
        void OnAfterSelect(object sender, TreeViewEventArgs e) {
            RichEditTreeNode node = (RichEditTreeNode)e.Node;
            Rectangle bounds = node.Info.Element.Bounds;
            labelControl1.Text = String.Format("{0}, {1}, {2}, {3}", bounds.X, bounds.Y, bounds.Width, bounds.Height);
            RangedLayoutElement rangedElement = node.Info.Element as RangedLayoutElement;
            labelControl4.Text = rangedElement != null ? rangedElement.Range.ToString() : String.Empty;

            richEditControl.Document.ChangeActiveDocument(richEditControl.Document);
            if (node.Info.DisplayAction == ContentDisplayAction.ScrollTo) {
                TryScrollToHeader(node.Info.Element);
                TryScrollToFooter(node.Info.Element);
                TryScrollToFloatingObject(node.Info.Element);
                TryScrollToComment(node.Info.Element);
                TryScrollToFrame(node.Info.Element);
            }
            else {
                if (rangedElement == null)
                    return;
                ScrollToPosition(rangedElement.Range.Start);
                richEditControl.Document.Selection = richEditControl.Document.CreateRange(rangedElement.Range.Start, rangedElement.Range.Length);
            }
        }
        void TryScrollToFrame(LayoutElement element) {
            LayoutFrame frame = element as LayoutFrame;
            if (frame == null)
                frame = element.GetParentByType<LayoutFrame>();
            if (frame == null)
                return;
            ScrollToPosition(frame.Range.Start);
        }
        void TryScrollToHeader(LayoutElement element) {
            LayoutHeader header = element as LayoutHeader;
            if (header == null)
                header = element.GetParentByType<LayoutHeader>();
            if (header == null)
                return;
            LayoutPageArea nearestPageArea = ((LayoutPage)header.Parent).PageAreas.First;
            ScrollToPosition(nearestPageArea.Range.Start);
        }
        void TryScrollToFooter(LayoutElement element) {
            LayoutFooter footer = element as LayoutFooter;
            if (footer == null)
                footer = element.GetParentByType<LayoutFooter>();
            if (footer == null)
                return;
            LayoutPageArea nearestPageArea = ((LayoutPage)footer.Parent).PageAreas.Last;
            ScrollToPosition(nearestPageArea.Range.Start + nearestPageArea.Range.Length - 1);
        }
        void TryScrollToComment(LayoutElement element) {
            LayoutComment layoutComment = element as LayoutComment;
            if (layoutComment == null)
                layoutComment = element.GetParentByType<LayoutComment>();
            if (layoutComment != null) {
                Comment comment = layoutComment.GetDocumentComment();
                ScrollToPosition(comment.Range.Start);
            }
        }
        void TryScrollToFloatingObject(LayoutElement element) {
            LayoutFloatingObject layoutFloatingObject = element as LayoutFloatingObject;
            if (layoutFloatingObject == null)
                layoutFloatingObject = element.GetParentByType<LayoutTextBox>();
            if (layoutFloatingObject != null) {
                FloatingObjectAnchorBox anchor = layoutFloatingObject.AnchorBox;
                ScrollToPosition(anchor.Range.Start);
                richEditControl.Document.Selection = richEditControl.Document.CreateRange(anchor.Range.Start, anchor.Range.Length);
            }
        }
        void ScrollToPosition(int position) {
            richEditControl.Document.CaretPosition = richEditControl.Document.CreatePosition(position);
            richEditControl.ScrollToCaret(0.5f);
        }
        void ScrollToPosition(DocumentPosition position) {
            richEditControl.Document.CaretPosition = position;
            richEditControl.ScrollToCaret(0.5f);
        }
        void OnBeforeExpand(object sender, TreeViewCancelEventArgs e) {
            RichEditTreeNode node = (RichEditTreeNode)e.Node;
            if (node.Info.HasChildNodes && node.Nodes.Count > 0) {
                TreeNode loadingNode = node.Nodes["Loading"];
                if (loadingNode != null)
                    node.Nodes.Remove(loadingNode);
            }
            if (node.Nodes.Count > 0)
                return;
            ChildElementsCollector collector = new ChildElementsCollector(node.Info);
            int childCount = collector.Collection.Count;
            for (int i = 0; i < childCount; i++)
                AddTreeViewItem(node.Nodes, collector.Collection[i]);
        }
        void OnDocumentFormatted(object sender, EventArgs e) {
            BeginInvoke(new Action(() => {
                treeView1.Nodes.Clear();
                int pageCount = richEditControl.DocumentLayout.GetFormattedPageCount();
                for (int i = 0; i < pageCount; i++)
                    AddTreeViewItem(treeView1.Nodes, new TreeViewItemInfo(richEditControl.DocumentLayout.GetPage(i), ContentDisplayAction.Select, true));
                PageCount = richEditControl.DocumentLayout.GetPageCount();
            }));
        }
        void AddTreeViewItem(TreeNodeCollection collection, TreeViewItemInfo info) {
            RichEditTreeNode node = new RichEditTreeNode(info);
            node.Text = GetTreeViewItemHeader(info.Element, collection.Count + 1);
            collection.Add(node);
        }
        string GetTreeViewItemHeader(LayoutElement element, int index) {
            string typeName = element.Type.ToString();
            switch (element.Type) {
                case LayoutType.Column:
                    return String.Format("{0} #{1}", typeName, index);
                case LayoutType.Page:
                    return String.Format("{0} #{1}", typeName, index);
                case LayoutType.Row:
                    return String.Format("{0} #{1}", typeName, index);
                case LayoutType.TableRow:
                    return String.Format("{0} #{1}", typeName, index);
            }
            return typeName;
        }
        bool IsDrawingSupported(LayoutType type) {
            switch (type) {
                case LayoutType.BookmarkEndBox:
                    return false;
                case LayoutType.BookmarkStartBox:
                    return false;
                case LayoutType.CommentEndBox:
                    return false;
                case LayoutType.CommentStartBox:
                    return false;
                case LayoutType.CustomRunBox:
                    return false;
                case LayoutType.DataContainerRunBox:
                    return false;
                case LayoutType.RangePermissionEndBox:
                    return false;
                case LayoutType.RangePermissionStartBox:
                    return false;
                case LayoutType.HiddenTextUnderlineBox:
                    return false;
                case LayoutType.CharacterBox:
                    return false;
                case LayoutType.FloatingObjectAnchorBox:
                    return false;
                default:
                    return true;
            }
        }
        void OnBeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            e.Painter = new CustomPagePainter(LayoutInfos);
        }
        void richEditControl_SelectionChanged(object sender, EventArgs e) {
            RangedLayoutElement element = richEditControl.DocumentLayout.GetElement<RangedLayoutElement>(richEditControl.Document.CaretPosition);
            if (element != null)
                ActivePageNumber = richEditControl.DocumentLayout.GetPageIndex(element) + 1;
        }
        void richEditControl_VisiblePagesChanged(object sender, EventArgs e) {
            ActivePageNumber = richEditControl.ActiveView.GetVisiblePageLayoutInfos()[0].PageIndex + 1;
        }
    }

    public enum ContentDisplayAction { Select, ScrollTo }
    public struct TreeViewItemInfo {
        LayoutElement element;
        ContentDisplayAction displayAction;
        bool hasChildNodes;

        public TreeViewItemInfo(LayoutElement element, ContentDisplayAction displayAction, bool hasChildNodes) {
            this.element = element;
            this.displayAction = displayAction;
            this.hasChildNodes = hasChildNodes;
        }

        public LayoutElement Element { get { return element; } }
        public ContentDisplayAction DisplayAction { get { return displayAction; } }
        public bool HasChildNodes { get { return hasChildNodes; } }
    }
    public class RichEditTreeNode : TreeNode {
        TreeViewItemInfo info;

        public RichEditTreeNode(TreeViewItemInfo info) {
            this.info = info;
            if (info.HasChildNodes)
                Nodes.Add("Loading", "Loading...");
        }

        public TreeViewItemInfo Info { get { return info; } }
    }
    #region ChildElementsCollector
    class ChildElementsCollector : LayoutVisitor {
        List<TreeViewItemInfo> collection;
        TreeViewItemInfo parentElement;

        public ChildElementsCollector(TreeViewItemInfo parentElement) {
            this.collection = new List<TreeViewItemInfo>();
            this.parentElement = parentElement;
            Visit(ParentElement.Element);
        }

        public List<TreeViewItemInfo> Collection { get { return collection; } }
        public TreeViewItemInfo ParentElement { get { return parentElement; } }

        protected override void VisitPage(LayoutPage page) {
            TryAddElementToCollection(page, ContentDisplayAction.Select, true);
            base.VisitPage(page);
        }
        protected override void VisitHeader(LayoutHeader header) {
            TryAddElementToCollection(header, ContentDisplayAction.ScrollTo, true);
            base.VisitHeader(header);
        }
        protected override void VisitFrame(LayoutFrame frame) {
            TryAddElementToCollection(frame, ContentDisplayAction.ScrollTo, true);
            base.VisitFrame(frame);
        }
        protected override void VisitParagraphFrameBox(ParagraphFrameBox paragraphFrameBox) {
            TryAddElementToCollection(paragraphFrameBox, ContentDisplayAction.Select, false);
            base.VisitParagraphFrameBox(paragraphFrameBox);
        }
        protected override void VisitFooter(LayoutFooter footer) {
            TryAddElementToCollection(footer, ContentDisplayAction.ScrollTo, true);
            base.VisitFooter(footer);
        }
        protected override void VisitPageArea(LayoutPageArea pageArea) {
            TryAddElementToCollection(pageArea, ContentDisplayAction.Select, true);
            base.VisitPageArea(pageArea);
        }
        protected override void VisitCommentsArea(LayoutCommentsArea commentsArea) {
            TryAddElementToCollection(commentsArea, ContentDisplayAction.ScrollTo, true);
            base.VisitCommentsArea(commentsArea);
        }
        protected override void VisitBookmarkEndBox(BookmarkBox bookmarkEndBox) {
            TryAddElementToCollection(bookmarkEndBox, ContentDisplayAction.Select, false);
            base.VisitBookmarkEndBox(bookmarkEndBox);
        }
        protected override void VisitBookmarkStartBox(BookmarkBox bookmarkStartBox) {
            TryAddElementToCollection(bookmarkStartBox, ContentDisplayAction.Select, false);
            base.VisitBookmarkStartBox(bookmarkStartBox);
        }
        protected override void VisitColumn(LayoutColumn column) {
            TryAddElementToCollection(column, ContentDisplayAction.Select, true);
            base.VisitColumn(column);
        }
        protected override void VisitColumnBreakBox(PlainTextBox columnBreakBox) {
            TryAddElementToCollection(columnBreakBox, ContentDisplayAction.Select, false);
            base.VisitColumnBreakBox(columnBreakBox);
        }
        protected override void VisitComment(LayoutComment comment) {
            TryAddElementToCollection(comment, ContentDisplayAction.ScrollTo, true);
            base.VisitComment(comment);
        }
        protected override void VisitCommentEndBox(CommentBox commentEndBox) {
            TryAddElementToCollection(commentEndBox, ContentDisplayAction.Select, false);
            base.VisitCommentEndBox(commentEndBox);
        }
        protected override void VisitCommentHighlightAreaBox(CommentHighlightAreaBox commentHighlightAreaBox) {
            TryAddElementToCollection(commentHighlightAreaBox, ContentDisplayAction.Select, false);
            base.VisitCommentHighlightAreaBox(commentHighlightAreaBox);
        }
        protected override void VisitCommentStartBox(CommentBox commentStartBox) {
            TryAddElementToCollection(commentStartBox, ContentDisplayAction.Select, false);
            base.VisitCommentStartBox(commentStartBox);
        }
        protected override void VisitFieldHighlightAreaBox(FieldHighlightAreaBox fieldHighlightAreaBox) {
            TryAddElementToCollection(fieldHighlightAreaBox, ContentDisplayAction.Select, false);
            base.VisitFieldHighlightAreaBox(fieldHighlightAreaBox);
        }
        protected override void VisitFloatingObjectAnchorBox(FloatingObjectAnchorBox floatingObjectAnchorBox) {
            TryAddElementToCollection(floatingObjectAnchorBox, ContentDisplayAction.Select, false);
            base.VisitFloatingObjectAnchorBox(floatingObjectAnchorBox);
        }
        protected override void VisitFloatingPicture(LayoutFloatingPicture floatingPicture) {
            TryAddElementToCollection(floatingPicture, ContentDisplayAction.ScrollTo, false);
            base.VisitFloatingPicture(floatingPicture);
        }
        protected override void VisitHiddenTextUnderlineBox(HiddenTextUnderlineBox hiddenTextUnderlineBox) {
            TryAddElementToCollection(hiddenTextUnderlineBox, ContentDisplayAction.Select, false);
            base.VisitHiddenTextUnderlineBox(hiddenTextUnderlineBox);
        }
        protected override void VisitHighlightAreaBox(HighlightAreaBox highlightAreaBox) {
            TryAddElementToCollection(highlightAreaBox, ContentDisplayAction.Select, false);
            base.VisitHighlightAreaBox(highlightAreaBox);
        }
        protected override void VisitHyphenBox(PlainTextBox hyphen) {
            TryAddElementToCollection(hyphen, ContentDisplayAction.Select, false);
            base.VisitHyphenBox(hyphen);
        }
        protected override void VisitInlinePictureBox(InlinePictureBox inlinePictureBox) {
            TryAddElementToCollection(inlinePictureBox, ContentDisplayAction.Select, false);
            base.VisitInlinePictureBox(inlinePictureBox);
        }
        protected override void VisitLineBreakBox(PlainTextBox lineBreakBox) {
            TryAddElementToCollection(lineBreakBox, ContentDisplayAction.Select, false);
            base.VisitLineBreakBox(lineBreakBox);
        }
        protected override void VisitLineNumberBox(LineNumberBox lineNumberBox) {
            TryAddElementToCollection(lineNumberBox, ContentDisplayAction.Select, false);
            base.VisitLineNumberBox(lineNumberBox);
        }
        protected override void VisitNumberingListMarkBox(NumberingListMarkBox numberingListMarkBox) {
            TryAddElementToCollection(numberingListMarkBox, ContentDisplayAction.Select, false);
            base.VisitNumberingListMarkBox(numberingListMarkBox);
        }
        protected override void VisitNumberingListWithSeparatorBox(NumberingListWithSeparatorBox numberingListWithSeparatorBox) {
            TryAddElementToCollection(numberingListWithSeparatorBox, ContentDisplayAction.Select, true);
            base.VisitNumberingListWithSeparatorBox(numberingListWithSeparatorBox);
        }
        protected override void VisitPageBreakBox(PlainTextBox pageBreakBox) {
            TryAddElementToCollection(pageBreakBox, ContentDisplayAction.Select, false);
            base.VisitPageBreakBox(pageBreakBox);
        }
        protected override void VisitPageNumberBox(PlainTextBox pageNumberBox) {
            TryAddElementToCollection(pageNumberBox, ContentDisplayAction.Select, false);
            base.VisitPageNumberBox(pageNumberBox);
        }
        protected override void VisitParagraphMarkBox(PlainTextBox paragraphMarkBox) {
            TryAddElementToCollection(paragraphMarkBox, ContentDisplayAction.Select, false);
            base.VisitParagraphMarkBox(paragraphMarkBox);
        }
        protected override void VisitPlainTextBox(PlainTextBox plainTextBox) {
            TryAddElementToCollection(plainTextBox, ContentDisplayAction.Select, false);
            base.VisitPlainTextBox(plainTextBox);
        }
        protected override void VisitRangePermissionEndBox(RangePermissionBox rangePermissionEndBox) {
            TryAddElementToCollection(rangePermissionEndBox, ContentDisplayAction.Select, false);
            base.VisitRangePermissionEndBox(rangePermissionEndBox);
        }
        protected override void VisitRangePermissionHighlightAreaBox(RangePermissionHighlightAreaBox rangePermissionHighlightAreaBox) {
            TryAddElementToCollection(rangePermissionHighlightAreaBox, ContentDisplayAction.Select, false);
            base.VisitRangePermissionHighlightAreaBox(rangePermissionHighlightAreaBox);
        }
        protected override void VisitRangePermissionStartBox(RangePermissionBox rangePermissionStartBox) {
            TryAddElementToCollection(rangePermissionStartBox, ContentDisplayAction.Select, false);
            base.VisitRangePermissionStartBox(rangePermissionStartBox);
        }
        protected override void VisitRow(LayoutRow row) {
            TryAddElementToCollection(row, ContentDisplayAction.Select, true);
            base.VisitRow(row);
        }
        protected override void VisitSectionBreakBox(PlainTextBox sectionBreakBox) {
            TryAddElementToCollection(sectionBreakBox, ContentDisplayAction.Select, false);
            base.VisitSectionBreakBox(sectionBreakBox);
        }
        protected override void VisitSpaceBox(PlainTextBox spaceBox) {
            TryAddElementToCollection(spaceBox, ContentDisplayAction.Select, false);
            base.VisitSpaceBox(spaceBox);
        }
        protected override void VisitSpecialTextBox(PlainTextBox specialTextBox) {
            TryAddElementToCollection(specialTextBox, ContentDisplayAction.Select, false);
            base.VisitSpecialTextBox(specialTextBox);
        }
        protected override void VisitStrikeoutBox(StrikeoutBox strikeoutBox) {
            TryAddElementToCollection(strikeoutBox, ContentDisplayAction.Select, false);
            base.VisitStrikeoutBox(strikeoutBox);
        }
        protected override void VisitTable(LayoutTable table) {
            TryAddElementToCollection(table, ContentDisplayAction.Select, true);
            base.VisitTable(table);
        }
        protected override void VisitTableCell(LayoutTableCell tableCell) {
            TryAddElementToCollection(tableCell, ContentDisplayAction.Select, true);
            base.VisitTableCell(tableCell);
        }
        protected override void VisitTableRow(LayoutTableRow tableRow) {
            TryAddElementToCollection(tableRow, ContentDisplayAction.Select, true);
            base.VisitTableRow(tableRow);
        }
        protected override void VisitTabSpaceBox(PlainTextBox tabSpaceBox) {
            TryAddElementToCollection(tabSpaceBox, ContentDisplayAction.Select, false);
            base.VisitTabSpaceBox(tabSpaceBox);
        }
        protected override void VisitTextBox(LayoutTextBox textBox) {
            TryAddElementToCollection(textBox, ContentDisplayAction.ScrollTo, true);
            base.VisitTextBox(textBox);
        }
        protected override void VisitUnderlineBox(UnderlineBox underlineBox) {
            TryAddElementToCollection(underlineBox, ContentDisplayAction.Select, false);
            base.VisitUnderlineBox(underlineBox);
        }
        void TryAddElementToCollection(LayoutElement element, ContentDisplayAction showingType, bool hasChildNodes) {
            if (Object.ReferenceEquals(element.Parent, ParentElement.Element)) {
                ContentDisplayAction type = ParentElement.DisplayAction == ContentDisplayAction.ScrollTo ? ParentElement.DisplayAction : showingType;
                Collection.Add(new TreeViewItemInfo(element, type, hasChildNodes));
            }
        }
    }
    #endregion
    public class LayoutInfoItem {
        string name;
        bool isChecked;
        Color color;

        public LayoutInfoItem(string name, Color color) {
            this.name = name;
            this.color = color;
            this.isChecked = false;
        }

        public string Name { get { return name; } }
        public bool IsChecked { get { return isChecked; } set { isChecked = value; } }
        public Color Color { get { return color; } set { color = value; } }
    }
    #region CustomPagePainter
    public class CustomPagePainter : PagePainter {
        List<LayoutInfoItem> layoutInfos;

        public CustomPagePainter(List<LayoutInfoItem> layoutInfos) {
            this.layoutInfos = layoutInfos;
        }

        List<LayoutInfoItem> LayoutInfos { get { return layoutInfos; } }

        public override void DrawCommentsArea(LayoutCommentsArea commentsArea) {
            base.DrawCommentsArea(commentsArea);
            HighlightElement(commentsArea);
        }
        public override void DrawRow(LayoutRow row) {
            base.DrawRow(row);
            HighlightElement(row);
        }
        public override void DrawPlainTextBox(PlainTextBox plainTextBox) {
            base.DrawPlainTextBox(plainTextBox);
            HighlightElement(plainTextBox);
        }
        public override void DrawPage(LayoutPage page) {
            base.DrawPage(page);
            HighlightElement(page);
        }
        public override void DrawFrame(LayoutFrame frame) {
            base.DrawFrame(frame);
            HighlightElement(frame);
        }
        public override void DrawParagraphFrame(ParagraphFrameBox paragraphFrame) {
            base.DrawParagraphFrame(paragraphFrame);
            HighlightElement(paragraphFrame);
        }
        public override void DrawColumn(LayoutColumn column) {
            base.DrawColumn(column);
            HighlightElement(column);
        }
        public override void DrawColumnBreakBox(PlainTextBox columnBreakBox) {
            base.DrawColumnBreakBox(columnBreakBox);
            HighlightElement(columnBreakBox);
        }
        public override void DrawComment(LayoutComment comment) {
            base.DrawComment(comment);
            HighlightElement(comment);
        }
        public override void DrawCommentHighlightAreaBox(CommentHighlightAreaBox commentHighlightAreaBox) {
            base.DrawCommentHighlightAreaBox(commentHighlightAreaBox);
            HighlightElement(commentHighlightAreaBox);
        }
        public override void DrawFieldHighlightAreaBox(FieldHighlightAreaBox fieldHighlightAreaBox) {
            base.DrawFieldHighlightAreaBox(fieldHighlightAreaBox);
            HighlightElement(fieldHighlightAreaBox);
        }
        public override void DrawFloatingPicture(LayoutFloatingPicture floatingPicture) {
            base.DrawFloatingPicture(floatingPicture);
            HighlightElement(floatingPicture);
        }
        public override void DrawFooter(LayoutFooter footer) {
            base.DrawFooter(footer);
            HighlightElement(footer);
        }
        public override void DrawHeader(LayoutHeader header) {
            base.DrawHeader(header);
            HighlightElement(header);
        }
        public override void DrawHighlightAreaBox(HighlightAreaBox highlightAreaBox) {
            base.DrawHighlightAreaBox(highlightAreaBox);
            HighlightElement(highlightAreaBox);
        }
        public override void DrawHyphenBox(PlainTextBox hyphen) {
            base.DrawHyphenBox(hyphen);
            HighlightElement(hyphen);
        }
        public override void DrawInlinePictureBox(InlinePictureBox inlinePictureBox) {
            base.DrawInlinePictureBox(inlinePictureBox);
            HighlightElement(inlinePictureBox);
        }
        public override void DrawLineBreakBox(PlainTextBox lineBreakBox) {
            base.DrawLineBreakBox(lineBreakBox);
            HighlightElement(lineBreakBox);
        }
        public override void DrawLineNumberBox(LineNumberBox lineNumberBox) {
            base.DrawLineNumberBox(lineNumberBox);
            HighlightElement(lineNumberBox);
        }
        public override void DrawNumberingListMarkBox(NumberingListMarkBox numberingListMarkBox) {
            base.DrawNumberingListMarkBox(numberingListMarkBox);
            HighlightElement(numberingListMarkBox);
        }
        public override void DrawNumberingListWithSeparatorBox(NumberingListWithSeparatorBox numberingListWithSeparatorBox) {
            base.DrawNumberingListWithSeparatorBox(numberingListWithSeparatorBox);
            HighlightElement(numberingListWithSeparatorBox);
        }
        public override void DrawPageArea(LayoutPageArea pageArea) {
            base.DrawPageArea(pageArea);
            HighlightElement(pageArea);
        }
        public override void DrawPageBreakBox(PlainTextBox pageBreakBox) {
            base.DrawPageBreakBox(pageBreakBox);
            HighlightElement(pageBreakBox);
        }
        public override void DrawPageNumberBox(PlainTextBox pageNumberBox) {
            base.DrawPageNumberBox(pageNumberBox);
            HighlightElement(pageNumberBox);
        }
        public override void DrawParagraphMarkBox(PlainTextBox paragraphMarkBox) {
            base.DrawParagraphMarkBox(paragraphMarkBox);
            HighlightElement(paragraphMarkBox);
        }
        public override void DrawRangePermissionHighlightAreaBox(RangePermissionHighlightAreaBox rangePermissionHighlightAreaBox) {
            base.DrawRangePermissionHighlightAreaBox(rangePermissionHighlightAreaBox);
            HighlightElement(rangePermissionHighlightAreaBox);
        }
        public override void DrawSectionBreakBox(PlainTextBox sectionBreakBox) {
            base.DrawSectionBreakBox(sectionBreakBox);
            HighlightElement(sectionBreakBox);
        }
        public override void DrawSpaceBox(PlainTextBox spaceBox) {
            base.DrawSpaceBox(spaceBox);
            HighlightElement(spaceBox);
        }
        public override void DrawSpecialTextBox(PlainTextBox specialTextBox) {
            base.DrawSpecialTextBox(specialTextBox);
            HighlightElement(specialTextBox);
        }
        public override void DrawStrikeoutBox(StrikeoutBox strikeoutBox) {
            base.DrawStrikeoutBox(strikeoutBox);
            HighlightElement(strikeoutBox);
        }
        public override void DrawTable(LayoutTable table) {
            base.DrawTable(table);
            HighlightElement(table);
        }
        public override void DrawTableCell(LayoutTableCell tableCell) {
            base.DrawTableCell(tableCell);
            HighlightElement(tableCell);
        }
        public override void DrawTableRow(LayoutTableRow tableRow) {
            base.DrawTableRow(tableRow);
            HighlightElement(tableRow);
        }
        public override void DrawTabSpaceBox(PlainTextBox tabSpaceBox) {
            base.DrawTabSpaceBox(tabSpaceBox);
            HighlightElement(tabSpaceBox);
        }
        public override void DrawTextBox(LayoutTextBox textBox) {
            base.DrawTextBox(textBox);
            HighlightElement(textBox);
        }
        public override void DrawUnderlineBox(UnderlineBox underlineBox) {
            base.DrawUnderlineBox(underlineBox);
            HighlightElement(underlineBox);
        }
        void HighlightElement(LayoutElement element) {
            HighlightElement(element, element.Bounds);
        }
        void HighlightElement(LayoutElement element, Rectangle bounds) {
            LayoutInfoItem item = GetItem(element.Type);
            if (item != null && item.IsChecked)
                Canvas.DrawRectangle(new RichEditPen(item.Color), bounds);
        }
        LayoutInfoItem GetItem(LayoutType type) {
            int count = LayoutInfos.Count;
            for (int i = 0; i < count; i++) {
                if (LayoutInfos[i].Name.Equals(type.ToString()))
                    return LayoutInfos[i];
            }
            return null;
        }
    }
    #endregion
}
