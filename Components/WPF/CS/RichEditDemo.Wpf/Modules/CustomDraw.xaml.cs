using System;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.RichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Collections.Generic;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Layout;
using System.Drawing;
using Color = System.Windows.Media.Color;

namespace RichEditDemo {
    public partial class CustomDraw : RichEditDemoModule {
        System.Timers.Timer searchTimer;
        List<DocumentRange> searchResultsList;
        int selectedIndex = -1;
        SearchOptions searchOptions;
        const string paragraphMark = "\r\n";
        const char spaceMark = ' ';
        public CustomDraw() {
            InitializeComponent();
            this.searchTimer = new System.Timers.Timer();
            OpenXmlLoadHelper.Load("CustomDraw.docx", richEdit);

        }
        int SelectedIndex {
            get { return selectedIndex; }
            set {
                selectedIndex = value;
                OnSelectedIndexChanged();
            }
        }
        bool IsSelectionInMainDocument { get { return !richEdit.IsSelectionInTextBox && !richEdit.IsSelectionInHeaderOrFooter && !richEdit.IsSelectionInComment; } }

        void richEdit_Loaded(object sender, System.Windows.RoutedEventArgs e) {
            richEdit.BeforePagePaint += richEditControl_OnBeforePagePaint;
            richEdit.ContentChanged += richEditControl_ContentChanged;
            this.searchTimer.Elapsed += searchTimer_Elapsed;
            searchResultsList = new List<DocumentRange>();
            ConfigureSearchPanelControls();
            richEdit.ReplaceService<IRichEditCommandFactoryService>(new CustomsRichEditCommandFactoryService(richEdit, richEdit.GetService<IRichEditCommandFactoryService>(), Activate));
            foreach (Section section in richEdit.Document.Sections) {
                section.LineNumbering.CountBy = 1;
                section.LineNumbering.Start =  0;
                section.LineNumbering.RestartType = LineNumberingRestart.Continuous;
            }
        }
        public void Activate() {
            searchTextBox.Focus();
            string searchText = string.Empty;
            SubDocument doc = richEdit.Document.Selection.BeginUpdateDocument();
            searchText = doc.GetText(richEdit.Document.Selection);
            richEdit.Document.Selection.EndUpdateDocument(doc);
            if (string.IsNullOrEmpty(searchText))
                searchText = searchTextBox.Text;
            else {
                searchText = searchText.Trim();
                searchText = searchText.Replace(paragraphMark, spaceMark.ToString());
                int maxLength = Math.Min(searchTextBox.MaxLength, searchText.Length);
                searchText = searchText.Substring(0, maxLength);
            }
            searchTextBox.Text = searchText;
            StartSearch();
        }
        void richEditControl_OnBeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            if (e.CanvasOwnerType == CanvasOwnerType.Printer) {
                return;
            }
            CustomDrawPagePainter customPagePainter = new CustomDrawPagePainter(richEdit, searchResultsList, selectedIndex);
            customPagePainter.HighlightRow = edtHighlightRow.IsChecked.Value;
            customPagePainter.HighlightLineNumbering = edtHighlightNumberingList.IsChecked.Value;
            customPagePainter.TextHighlightColor = colorEdit.Color;
            customPagePainter.RowHighlightColor = colorEditLine.Color;
            customPagePainter.NumberingHighlightColor = colorEditHighlightNumbering.Color;
            e.Painter = customPagePainter;
        }
        void richEditControl_ContentChanged(object sender, EventArgs e) {
            searchResultsList.Clear();
            ConfigureSearchPanelControls();
            richEdit.Refresh();
        }
        bool CheckSelectedIndex() {
            return SelectedIndex > -1 && SelectedIndex < searchResultsList.Count;
        }
        void OnSelectedIndexChanged() {
            if (CheckSelectedIndex()) {
                DocumentRange documentRange = searchResultsList[SelectedIndex];
                richEdit.Document.ChangeActiveDocument(richEdit.Document);
                richEdit.Document.Selection =  documentRange;
                richEdit.ScrollToCaret();
            }
            ConfigureSearchPanelControls();
            richEdit.Refresh();
        }
        void ButtonInfo_Click(object sender, System.Windows.RoutedEventArgs e) {
            searchTextBox.Text = string.Empty;
            StartSearch();
        }
        void ButtonDownInfo_Click(object sender, System.Windows.RoutedEventArgs e) {
            SelectedIndex = GetNextIndex(false);
        }
        void ButtonUpInfo_Click(object sender, System.Windows.RoutedEventArgs e) {
            SelectedIndex = GetNextIndex(true);
        }
        int GetNextIndex(bool isUp) {
            int resultIndex = -1;
            if (isUp) {
                resultIndex = GetPreviousIndex(richEdit.Document.CaretPosition);
                if (resultIndex < 0) {
                    resultIndex = searchResultsList.Count - 1;
                }
            }
            else {
                resultIndex = GetNextIndex(richEdit.Document.CaretPosition);
                if (resultIndex < 0) {
                    resultIndex = 0;
                }
            }
            return resultIndex;
        }
        int GetNextIndex(DocumentPosition position) {
            int caretPosition = richEdit.Document.CaretPosition.ToInt();
            return searchResultsList.FindIndex(x => x.Start.ToInt() >= position.ToInt());
        }
        int GetPreviousIndex(DocumentPosition position) {
            int caretPosition = richEdit.Document.CaretPosition.ToInt();
            return searchResultsList.FindLastIndex(x => x.End.ToInt() < position.ToInt());
        }
        void searchTextBox_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            searchTimer.Stop();
            searchTimer.Start();
        }
        void searchTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            if (e.Key == System.Windows.Input.Key.Enter)
                StartSearch();
            else if (e.Key == System.Windows.Input.Key.Escape) {
                searchTextBox.Text = string.Empty;
                StartSearch();
                richEdit.Focus();
            }
        }
        void SetSearchTextBoxButtonsVisibility() {
            foreach (ButtonInfo button in searchTextBox.Buttons)
                button.Visibility = !string.IsNullOrEmpty(searchTextBox.Text) ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
        }
        void SetResultLabelText() {
            string str = string.Empty;
            if (string.IsNullOrEmpty(searchTextBox.Text)) {
                str = string.Empty;
            }
            else if (searchResultsList.Count == 0) {
                str = "No matches";
            }
            else {
                str = searchResultsList.Count + " matches";
            }
            if (searchResultsList.Count > 0 && selectedIndex > -1) {
                str = (selectedIndex + 1) + " of " + str;
            }
            labelResultCount.Text = str;
        }
        void ConfigureSearchPanelControls() {
            SetResultLabelText();
            SetSearchTextBoxButtonsVisibility();
            ChangeNavigationButtonEditVisibility();
        }
        void StartSearch() {
            searchTimer.Stop();
            searchResultsList.Clear();
            FillSearchResultsList();
            SelectedIndex = -1;
            ConfigureSearchPanelControls();
            if (IsSelectionInMainDocument)
                SelectedIndex = GetSearchResultIndex(searchResultsList.FindIndex(x => richEdit.Document.Selection.Contains(x.Start) && richEdit.Document.Selection.Contains(richEdit.Document.CreatePosition(x.End.ToInt() - 1))));
        }
        int GetSearchResultIndex(int findIndex) {
            if (findIndex >= 0 || searchResultsList.Count <= 0)
                return findIndex;
            DocumentRange visibleRange = richEdit.ActiveView.GetVisiblePagesRange();
            findIndex = searchResultsList.FindIndex(x => visibleRange.Contains(x.Start) || visibleRange.Contains(x.End));
            if (findIndex >= 0)
                return findIndex;
            if (GetNextIndex(visibleRange.Start) < 0)
                return GetPreviousIndex(visibleRange.Start);
            return GetNextIndex(visibleRange.Start);
        }
        void searchTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            Dispatcher.BeginInvoke(new Action(() => StartSearch()));
        }
        void ChangeNavigationButtonEditVisibility() {
            navigationButtonEdit.Visibility = !string.IsNullOrEmpty(searchTextBox.Text) && searchResultsList.Count > 0 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
        }
        void FillSearchResultsList() {
            if (String.IsNullOrEmpty(searchTextBox.Text)) {
                return;
            }
            DocumentRange[] result = richEdit.Document.FindAll(searchTextBox.Text, searchOptions);
            searchResultsList = new List<DocumentRange>(result);
        }
        void matchCase_ValueChanged(object sender, EditValueChangedEventArgs e) {
            if (edtMatchCase.IsChecked.Value)
                searchOptions |= SearchOptions.CaseSensitive;
            else
                searchOptions ^= SearchOptions.CaseSensitive;
            StartSearch();
        }
        void findWholeWordsOnly_ValueChanged(object sender, EditValueChangedEventArgs e) {
            if (edtFindWholeWordsOnly.IsChecked.Value)
                searchOptions |= SearchOptions.WholeWord;
            else
                searchOptions ^= SearchOptions.WholeWord;
            StartSearch();
        }
        void colorEdit_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            richEdit.Refresh();
        }
        void edtHighlightRow_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            richEdit.Refresh();
        }
        void colorEditLine_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            richEdit.Refresh();
        }
        void edtHighlightNumberingList_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            richEdit.Refresh();
        }
        void colorEditHighlightNumbering_EditValueChanged(object sender, EditValueChangedEventArgs e) {
            richEdit.Refresh();
        }
    }
    #region CustomDrawPagePainter
    public class CustomDrawPagePainter : PagePainter {
        List<FixedRange> searchResulstList;
        List<FixedRange> visibleSearchResultsList;
        RichEditControl richEditControl;
        bool shouldHighlight = true;
        FixedRange selectedRange;
        const int borderWidth = 2;
        int currentResultIndex;
        int previousColumnIndex = -1;
        Font lineNumberFont;

        public CustomDrawPagePainter(RichEditControl richEdit, List<DocumentRange> resultList, int selectedResultIndex)
            : base() {
            richEditControl = richEdit;
            searchResulstList = resultList.ConvertAll(x => new FixedRange(x.Start.ToInt(), x.Length));
            if (selectedResultIndex >= 0 && selectedResultIndex < resultList.Count) {
                selectedRange = searchResulstList[selectedResultIndex];
                DocumentRange documentRange = richEditControl.Document.Paragraphs.Get(resultList[selectedResultIndex].Start).Range;
            }
        }

        public bool HighlightRow { get; set; }
        public bool HighlightLineNumbering { get; set; }
        public Color RowHighlightColor { get; set; }
        public Color TextHighlightColor { get; set; }
        public Color NumberingHighlightColor { get; set; }

        public override void DrawPage(LayoutPage page) {
            visibleSearchResultsList = searchResulstList.FindAll(x => page.MainContentRange.Intersect(x));
            lineNumberFont = new Font("Times New Roman", 11F, FontStyle.Regular);
            base.DrawPage(page);
            lineNumberFont.Dispose();
        }
        public override void DrawComment(LayoutComment comment) {
            shouldHighlight = false;
            base.DrawComment(comment);
            shouldHighlight = true;
        }
        public override void DrawTextBox(LayoutTextBox textBox) {
            shouldHighlight = false;
            base.DrawTextBox(textBox);
            shouldHighlight = true;
        }
        public override void DrawHeader(LayoutHeader header) {
            shouldHighlight = false;
            base.DrawHeader(header);
            shouldHighlight = true;
        }
        public override void DrawFooter(LayoutFooter footer) {
            shouldHighlight = false;
            base.DrawFooter(footer);
            shouldHighlight = true;
        }
        public override void DrawRow(LayoutRow row) {
            if (shouldHighlight) {
                DrawHighlightRow(row);
            }
            base.DrawRow(row);
        }
        public override void DrawPageArea(LayoutPageArea pageArea) {
            base.DrawPageArea(pageArea);
            previousColumnIndex = -1;
        }
        public override void DrawColumn(LayoutColumn column) {
            LayoutPageArea pageArea = column.GetParentByType<LayoutPageArea>();
            if (pageArea != null) {
                int leftBoundary = 0;
                if (previousColumnIndex >= 0) {
                    leftBoundary = pageArea.Columns[previousColumnIndex].Bounds.Right;
                }
                if (column.LineNumbers.Count > 0) {
                    HighlightLineNumberingArea(column, leftBoundary);
                }
                previousColumnIndex++;
            }
            base.DrawColumn(column);
        }
        public override void DrawTable(LayoutTable table) {
            currentResultIndex = 0;
            base.DrawTable(table);
        }
        public override void DrawLineNumberBox(LineNumberBox lineNumberBox) {
            Color foreColor = System.Windows.Media.Colors.Black;
            if (HighlightRow && selectedRange != null && lineNumberBox.Row.Range.Intersect(selectedRange)) {
                foreColor = RowHighlightColor;
            }
            Canvas.DrawString(lineNumberBox.Text, lineNumberFont, new RichEditBrush(foreColor), lineNumberBox.Bounds, this.richEditControl.LayoutUnit);
        }
        public override void DrawTabSpaceBox(PlainTextBox tabSpaceBox) {
            HighlightElement(tabSpaceBox);
            base.DrawTabSpaceBox(tabSpaceBox);
        }
        public override void DrawPlainTextBox(PlainTextBox plainTextBox) {
            HighlightElement(plainTextBox);
            base.DrawPlainTextBox(plainTextBox);
        }
        public override void DrawColumnBreakBox(PlainTextBox columnBreakBox) {
            HighlightElement(columnBreakBox);
            base.DrawColumnBreakBox(columnBreakBox);
        }
        public override void DrawHyphenBox(PlainTextBox hyphen) {
            HighlightElement(hyphen);
            base.DrawHyphenBox(hyphen);
        }
        public override void DrawLineBreakBox(PlainTextBox lineBreakBox) {
            HighlightElement(lineBreakBox);
            base.DrawLineBreakBox(lineBreakBox);
        }
        public override void DrawPageBreakBox(PlainTextBox pageBreakBox) {
            HighlightElement(pageBreakBox);
            base.DrawPageBreakBox(pageBreakBox);
        }
        public override void DrawPageNumberBox(PlainTextBox pageNumberBox) {
            HighlightElement(pageNumberBox);
            base.DrawPageNumberBox(pageNumberBox);
        }
        public override void DrawParagraphMarkBox(PlainTextBox paragraphMarkBox) {
            HighlightElement(paragraphMarkBox);
            base.DrawParagraphMarkBox(paragraphMarkBox);
        }
        public override void DrawSectionBreakBox(PlainTextBox sectionBreakBox) {
            HighlightElement(sectionBreakBox);
            base.DrawSectionBreakBox(sectionBreakBox);
        }
        public override void DrawSpaceBox(PlainTextBox spaceBox) {
            HighlightElement(spaceBox);
            base.DrawSpaceBox(spaceBox);
        }
        public override void DrawSpecialTextBox(PlainTextBox specialTextBox) {
            HighlightElement(specialTextBox);
            base.DrawSpecialTextBox(specialTextBox);
        }
        void HighlightElement(PlainTextBox element) {
            if (!shouldHighlight || visibleSearchResultsList == null || visibleSearchResultsList.Count <= 0) {
                return;
            }
            currentResultIndex = GetNearestSearchReusltIndex(element);
            while (currentResultIndex < visibleSearchResultsList.Count && element.Range.Intersect(visibleSearchResultsList[currentResultIndex])) {
                if (element.Type != LayoutType.PlainTextBox) {
                    HighlightElement(element.Bounds);
                    break;
                }
                FixedRange searchResult = visibleSearchResultsList[currentResultIndex];
                int firstCharacter = System.Math.Max(element.Range.Start, searchResult.Start);
                int lastCharacter = System.Math.Min(GetLastCharacterIndex(element.Range.Start + element.Range.Length), GetLastCharacterIndex(searchResult.Start + searchResult.Length));
                CharacterBoxCollection boxes = richEditControl.DocumentLayout.Split(element);
                Rectangle bounds = boxes[GetCharacterIndex(firstCharacter, element.Range)].Bounds;
                if (lastCharacter > firstCharacter) {
                    Rectangle lastCharacterBounds = boxes[GetCharacterIndex(lastCharacter, element.Range)].Bounds;
                    bounds = Rectangle.Union(bounds, lastCharacterBounds);
                }
                HighlightElement(bounds);
                if (lastCharacter >= GetLastCharacterIndex(searchResult.Start + searchResult.Length)) {
                    currentResultIndex++;
                }
                else {
                    break;
                }
            }
        }
        int GetNearestSearchReusltIndex(PlainTextBox element) {
            int result = currentResultIndex;
            while (result < visibleSearchResultsList.Count && visibleSearchResultsList[result].Start  + visibleSearchResultsList[result].Length < element.Range.Start) {
                result++;
            }
            return result;
        }
        void DrawHighlightRow(LayoutRow row) {
            if (HighlightRow && selectedRange != null && row.Range.Intersect(selectedRange)) {
                Canvas.DrawRectangle(new RichEditPen(RowHighlightColor, Canvas.ConvertToDrawingLayoutUnits(borderWidth, this.richEditControl.LayoutUnit)), GetRowBounds(row));
            }
        }
        void HighlightLineNumberingArea(LayoutColumn column, int leftBoundary) {
            if (HighlightLineNumbering) {
                LayoutPage page =  column.GetParentByType<LayoutPage>();
                Rectangle marginBounds = new Rectangle(new Point(leftBoundary, 0), new Size(column.Bounds.X - leftBoundary, page.Bounds.Height));
                Canvas.FillRectangle(new RichEditBrush(NumberingHighlightColor), marginBounds);
            }
        }
        Rectangle GetRowBounds(LayoutRow row) {
            LayoutColumn column = row.GetParentByType<LayoutColumn>();
            if (column != null) {
                return new Rectangle(new Point(column.Bounds.X, row.Bounds.Y), new Size(column.Bounds.Width, row.Bounds.Height));
            }
            return row.Bounds;
        }
        int GetCharacterIndex(int position, FixedRange range) {
            return position - range.Start;
        }
        void HighlightElement(Rectangle bounds) {
            Canvas.FillRectangle(new RichEditBrush(TextHighlightColor), bounds);
        }
        int GetLastCharacterIndex(int end) {
            return end - 1;
        }
    }
    #endregion
    #region CustomsRichEditCommandFactoryService
    public class CustomsRichEditCommandFactoryService : IRichEditCommandFactoryService {
        readonly IRichEditCommandFactoryService service;
        readonly RichEditControl control;
        readonly Action showFormCallback;

        public CustomsRichEditCommandFactoryService(RichEditControl richEditControl, IRichEditCommandFactoryService richEditCommandFactoryService, Action actionShowFormCallback) {
            DevExpress.Utils.Guard.ArgumentNotNull(richEditControl, "control");
            DevExpress.Utils.Guard.ArgumentNotNull(richEditCommandFactoryService, "service");
            DevExpress.Utils.Guard.ArgumentNotNull(actionShowFormCallback, "actionShowFormCallback");
            control = richEditControl;
            service = richEditCommandFactoryService;
            showFormCallback = actionShowFormCallback;
        }
        RichEditCommand IRichEditCommandFactoryService.CreateCommand(RichEditCommandId id) {
            if (id.Equals(RichEditCommandId.Find)) {
                return new CustomFindDocumentCommand(control, showFormCallback);
            }
            return service.CreateCommand(id);
        }
        public class CustomFindDocumentCommand : FindCommand {
            Action showFormCallback;

            public CustomFindDocumentCommand(IRichEditControl richEdit, Action actionShowFormCallback)
                : base(richEdit) {
                showFormCallback = actionShowFormCallback;
            }
            protected override void ShowForm(string searchString) {
                showFormCallback();
            }
        }
    }
    #endregion
}
