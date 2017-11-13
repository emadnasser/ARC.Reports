using System;
using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using DevExpress.Core.Native;
using Windows.UI.Xaml.Input;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.Mvvm.UI.Native;
using DevExpress.Mvvm.Native;
using DevExpress.UI.Xaml.Ribbon.Internal;
using Utils;

namespace RibbonDemo {
    public class DemoScrollArea : ContentControl {
        double? zoomFactor = null;
        public double? ZoomFactor {
            get {
                return zoomFactor;
            }
            set {
                if (zoomFactor != value) {
                    zoomFactor = value;
                    OnZoomFactorChanged();
                }
            }
        }

        ScrollViewer scroll;
        bool zoomLocker;

        public DemoScrollArea() {
            DefaultStyleKey = typeof(DemoScrollArea);
            zoomLocker = false;
            if (DeviceFamilyHelper.IsMobile) ZoomFactor = 0.4;
        }

        protected override void OnApplyTemplate() {
            scroll = LayoutHelper.FindElementByName<ScrollViewer>(this, "PART_Scroll");
            scroll.Loaded += Scroll_Loaded;
        }

        void OnZoomFactorChanged() {
            if (!zoomLocker)
                scroll.Do(x => x.ChangeView(0, 0, (float?)ZoomFactor));
        }
        void Scroll_Loaded(object sender, RoutedEventArgs e) {
            OnZoomFactorChanged();
            scroll.ViewChanged += Scroll_ViewChanged;
        }
        void Scroll_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e) {
            zoomLocker = true;
            ZoomFactor = scroll.ZoomFactor;
            zoomLocker = false;
        }
    }

    public class DemoRichEditBox : RichEditBox {
        public static readonly DependencyProperty RTFTextProperty;
        public static readonly DependencyProperty InitialTextProperty;
        public static readonly DependencyProperty FileNameProperty;

        static DemoRichEditBox() {
            RTFTextProperty = DependencyPropertyManager.Register<DemoRichEditBox, string>("RTFText", null, (d, e) => d.OnRtfTextChanged());
            FileNameProperty = DependencyPropertyManager.Register<DemoRichEditBox, string>("FileName", string.Empty);
            InitialTextProperty = DependencyPropertyManager.Register<DemoRichEditBox, string>(nameof(InitialText), null);
        }
        public DemoRichEditBox() {
            FileName = string.Empty;
            FilePath = string.Empty;
            DocumentLoaded = false;
            textLocked = false;
            selectionLocked = false;
        }
        public string RTFText {
            get { return (string)GetValue(RTFTextProperty); }
            set { SetValue(RTFTextProperty, value); }
        }
  public string FileName {
            get { return (string)GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }
        public string InitialText { get; private set; }
        protected bool DocumentLoaded;
        public string FilePath { get; set; }
        public bool RTFContentIsUpdated { get; set; }
        protected override void OnGotFocus(RoutedEventArgs e) { }
        protected override void OnLostFocus(RoutedEventArgs e) { }
        protected override void OnPointerExited(PointerRoutedEventArgs e) { }
        protected override void OnPointerEntered(PointerRoutedEventArgs e) { }
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            SelectionChanged -= OnSelectionChanged;
            SelectionChanged += OnSelectionChanged;
        }

        protected bool selectionLocked, textLocked;

        protected virtual void OnSelectionChanged(object sender, RoutedEventArgs e) {
            if (!selectionLocked) {
                textLocked = true;
                string currentText;
                Document.GetText(TextGetOptions.FormatRtf, out currentText);
                RTFText = currentText;
                if (Document.UndoLimit == 0 ) {
                    InitialText = RTFText;
                    Document.UndoLimit = 32;
                }
                textLocked = false;
            }
        }
        protected virtual void OnRtfTextChanged() {
           if (!textLocked && RTFText != null) {
                selectionLocked = true;
                Document.SetText(TextSetOptions.FormatRtf, RTFText);
                string currentText;
                Document.GetText(TextGetOptions.FormatRtf, out currentText);
                InitialText = currentText;
                Document.UndoLimit = 0;
                Task.Delay(10);
                selectionLocked = false;
            }
        }
        protected int GetDocumentLength() {
            string currentContent;
            Document.GetText(TextGetOptions.None, out currentContent);
            return currentContent.Length;
        }
    }
    public class DemoRichEditBoxExtended : DemoRichEditBox {
        public static readonly DependencyProperty CurrentSelectionFontSizeProperty;
        public static readonly DependencyProperty CurrentSelectionFontFamilyProperty;
        public static readonly DependencyProperty CurrentSelectionAlignmentProperty;
        public static readonly DependencyProperty CurrentSelectionBoldDecorationProperty;
        public static readonly DependencyProperty CurrentSelectionItalicDecorationProperty;
        public static readonly DependencyProperty CurrentSelectionUnderlineDecorationProperty;
        public static readonly DependencyProperty CurrentSelectionBulletsListProperty;
        public static readonly DependencyProperty CurrentSelectionListLevelProperty;
        public static readonly DependencyProperty CurrentSelectionSubscriptProperty;
        public static readonly DependencyProperty CurrentSelectionSuperscriptProperty;
        public static readonly DependencyProperty IsImageSelectedProperty;
        public static readonly DependencyProperty CurrentForegroundProperty;
        public static readonly DependencyProperty DocumentColorsProperty;
        public static readonly DependencyProperty SelectedImageWidthProperty;
        public static readonly DependencyProperty SelectedImageHeightProperty;

        static DemoRichEditBoxExtended() {
            SelectedImageHeightProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, int>("SelectedImageHeight", 0, (d, e) => d.OnSelectedImageHeightChanged());
            SelectedImageWidthProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, int>("SelectedImageWidth", 0, (d, e) => d.OnSelectedImageWidthChanged());
            DocumentColorsProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, ColorPalette>("DocumentColors", null, (d,e) => d.OnDocumentColorsChanged(e));
            CurrentForegroundProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, Color>("CurrentForeground", Colors.Black, (d,e) => d.OnCurrentForegroundChanged());
            CurrentSelectionSuperscriptProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionSuperscript", false, (d, e) => d.OnCurrentSelectionSuperscriptChanged());
            CurrentSelectionSubscriptProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionSubscript", false, (d, e) => d.OnCurrentSelectionSubscriptChanged());
            CurrentSelectionListLevelProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, int>("CurrentSelectionListLevel", 1, (d, e) => d.OnCurrentSelectionListLevelChanged());
            CurrentSelectionBulletsListProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionBulletsList", false, (d, e) => d.OnBulletsListChanged());
            CurrentSelectionUnderlineDecorationProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionUnderlineDecoration", false, (d, e) => d.OnCurrentSelectionUnderlineDecorationChanged());
            CurrentSelectionItalicDecorationProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionItalicDecoration", false, (d, e) => d.OnCurrentSelectionItalicDecorationChanged());
            CurrentSelectionBoldDecorationProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("CurrentSelectionBoldDecoration", false, (d, e) => d.OnCurrentSelectionBoldDecorationChanged());
            CurrentSelectionFontSizeProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, double>("CurrentSelectionFontSize", 12d, (d, e) => d.OnCurrentSelectionFontSizeChanged());
            CurrentSelectionFontFamilyProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, string>("CurrentSelectionFontFamily", null, (d, e) => d.OnCurrentSelectionFontFamilyChanged());
            CurrentSelectionAlignmentProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, ParagraphAlignment>("CurrentSelectionAlignment", ParagraphAlignment.Left, (d, e) => d.OnCurrentSelectionAlignmentChanged());
            IsImageSelectedProperty = DependencyPropertyManager.Register<DemoRichEditBoxExtended, bool>("IsImageSelected", false, (d, e) => d.OnIsImageSelectedChanged(e));
        }

        private void OnIsImageSelectedChanged(IDependencyPropertyChangedEventArgs<bool> e) {
            if (e.NewValue)
                UpdateImageParams();
        }
        public int SelectedImageHeight {
            get { return (int)GetValue(SelectedImageHeightProperty); }
            set { SetValue(SelectedImageHeightProperty, value); }
        }
        public int SelectedImageWidth {
            get { return (int)GetValue(SelectedImageWidthProperty); }
            set { SetValue(SelectedImageWidthProperty, value); }
        }
        public ColorPalette DocumentColors {
            get { return (ColorPalette)GetValue(DocumentColorsProperty); }
            set { SetValue(DocumentColorsProperty, value); }
        }

        public Color CurrentForeground {
            get { return (Color)GetValue(CurrentForegroundProperty); }
            set { SetValue(CurrentForegroundProperty, value); }
        }
  public bool IsImageSelected {
            get { return (bool)GetValue(IsImageSelectedProperty); }
            set { SetValue(IsImageSelectedProperty, value); }
        }
        public bool CurrentSelectionSuperscript {
            get { return (bool)GetValue(CurrentSelectionSuperscriptProperty); }
            set { SetValue(CurrentSelectionSuperscriptProperty, value); }
        }
        public bool CurrentSelectionSubscript {
            get { return (bool)GetValue(CurrentSelectionSubscriptProperty); }
            set { SetValue(CurrentSelectionSubscriptProperty, value); }
        }
        public int CurrentSelectionListLevel {
            get { return (int)GetValue(CurrentSelectionListLevelProperty); }
            set { SetValue(CurrentSelectionListLevelProperty, value); }
        }
        public bool CurrentSelectionBulletsList {
            get { return (bool)GetValue(CurrentSelectionBulletsListProperty); }
            set { SetValue(CurrentSelectionBulletsListProperty, value); }
        }
        public ParagraphAlignment CurrentSelectionAlignment {
            get { return (ParagraphAlignment)GetValue(CurrentSelectionAlignmentProperty); }
            set { SetValue(CurrentSelectionAlignmentProperty, value); }
        }
        public double CurrentSelectionFontSize {
            get { return (double)GetValue(CurrentSelectionFontSizeProperty); }
            set { SetValue(CurrentSelectionFontSizeProperty, value); }
        }
        public string CurrentSelectionFontFamily {
            get { return (string)GetValue(CurrentSelectionFontFamilyProperty); }
            set { SetValue(CurrentSelectionFontFamilyProperty, value); }
        }
        public bool CurrentSelectionBoldDecoration {
            get { return (bool)GetValue(CurrentSelectionBoldDecorationProperty); }
            set { SetValue(CurrentSelectionBoldDecorationProperty, value); }
        }
        public bool CurrentSelectionItalicDecoration {
            get { return (bool)GetValue(CurrentSelectionItalicDecorationProperty); }
            set { SetValue(CurrentSelectionItalicDecorationProperty, value); }
        }
        public bool CurrentSelectionUnderlineDecoration {
            get { return (bool)GetValue(CurrentSelectionUnderlineDecorationProperty); }
            set { SetValue(CurrentSelectionUnderlineDecorationProperty, value); }
        }

        public DemoRichEditBoxExtended() : base() {
            DefaultStyleKey = typeof(DemoRichEditBoxExtended);
            FileName = "Document";
            documentColorsMap = new Dictionary<Color, SolidColorBrush>();
            RTFContentIsUpdated = true;
        }

        ITextSelection currentSelection;
        bool isShiftPressed;
        Dictionary<Color, SolidColorBrush> documentColorsMap;

        void AddDocumentColor(SolidColorBrush brush) {
            if (!documentColorsMap.ContainsKey(brush.Color) && DocumentColors != null) {
                documentColorsMap.Add(brush.Color, brush);
                DocumentColors.Items.Add(brush);
            }
        }

        private void OnDocumentColorsChanged(IDependencyPropertyChangedEventArgs<ColorPalette> e) {
            UpdateDocumentColors(true);
        }

        protected override void OnRtfTextChanged() {
            base.OnRtfTextChanged();
            UpdateDocumentColors(RTFContentIsUpdated);
            if (RTFContentIsUpdated) RTFContentIsUpdated = false;
        }
        protected override void OnLostFocus(RoutedEventArgs e) {
            base.OnLostFocus(e);
            if (DeviceFamilyHelper.IsDesktop && FocusManager.GetFocusedElement() is Control &&
               (FocusManager.GetFocusedElement() as Control).FocusState == FocusState.Pointer &&
               !(FocusManager.GetFocusedElement() is TextBox || FocusManager.GetFocusedElement() is RibbonFlyoutTitleControl))
                FocusRepair();
        }
        async void FocusRepair() {
            await Task.Delay(100);
            Focus(FocusState.Keyboard);
        }
        void UpdateDocumentColors(bool clear) {
            if (DocumentColors != null && RTFText != null) {
                if (clear) {
                    DocumentColors.Items.Clear();
                    documentColorsMap.Clear();
                }
                Regex rgx = new Regex(@"\\red([0-9]{1,3})\\green([0-9]{1,3})\\blue([0-9]{1,3})");
                MatchCollection colorsMatches = rgx.Matches(RTFText);
                foreach (Match match in colorsMatches) {
                    if (match.Groups.Count == 4) {
                        Color color = Color.FromArgb(255, byte.Parse(match.Groups[1].Value), byte.Parse(match.Groups[2].Value), byte.Parse(match.Groups[3].Value));
                        AddDocumentColor(new SolidColorBrush(color));
                    }
                }
            }
        }
        protected override void OnApplyTemplate() {
            base.OnApplyTemplate();
            base.OnRtfTextChanged();
        }

        protected override void OnKeyUp(KeyRoutedEventArgs e) {
            if (e.Key == Windows.System.VirtualKey.Shift)
                isShiftPressed = false;
            base.OnKeyUp(e);
        }
        protected override void OnKeyDown(KeyRoutedEventArgs e) {
            if (e.Key == Windows.System.VirtualKey.Shift) {
                isShiftPressed = true;
            }
            else if (currentSelection != null) {
                bool isArrowPressed = (e.Key == Windows.System.VirtualKey.Left ||
                                       e.Key == Windows.System.VirtualKey.Up ||
                                       e.Key == Windows.System.VirtualKey.Right ||
                                       e.Key == Windows.System.VirtualKey.Down);
                if (!(isShiftPressed && isArrowPressed)) {
                    currentSelection.CharacterFormat.ForegroundColor = CurrentForeground;
                    if (!double.IsNaN(CurrentSelectionFontSize)) {
                        if (currentSelection.CharacterFormat.Size != CurrentSelectionFontSize)
                            currentSelection.CharacterFormat.Size = (float)CurrentSelectionFontSize;
                    }
                    if (CurrentSelectionFontFamily != "" && CurrentSelectionFontFamily != null && currentSelection.CharacterFormat.Name != CurrentSelectionFontFamily)
                        currentSelection.CharacterFormat.Name = CurrentSelectionFontFamily;
                    if (CurrentSelectionBoldDecoration != (currentSelection.CharacterFormat.Bold == FormatEffect.On)) {
                        if (CurrentSelectionBoldDecoration)
                            currentSelection.CharacterFormat.Bold = FormatEffect.On;
                        else
                            currentSelection.CharacterFormat.Bold = FormatEffect.Off;
                    }
                    if (CurrentSelectionItalicDecoration != (currentSelection.CharacterFormat.Italic == FormatEffect.On)) {
                        if (CurrentSelectionItalicDecoration)
                            currentSelection.CharacterFormat.Italic = FormatEffect.On;
                        else
                            currentSelection.CharacterFormat.Italic = FormatEffect.Off;
                    }
                    if (CurrentSelectionUnderlineDecoration != (currentSelection.CharacterFormat.Underline == UnderlineType.Single)) {
                        if (CurrentSelectionUnderlineDecoration)
                            currentSelection.CharacterFormat.Underline = UnderlineType.Single;
                        else
                            currentSelection.CharacterFormat.Underline = UnderlineType.None;
                    }
                    if (CurrentSelectionSubscript != (currentSelection.CharacterFormat.Subscript == FormatEffect.On)) {
                        if (CurrentSelectionSubscript)
                            currentSelection.CharacterFormat.Subscript = FormatEffect.On;
                        else
                            currentSelection.CharacterFormat.Subscript = FormatEffect.Off;
                    }
                    if (CurrentSelectionSuperscript != (currentSelection.CharacterFormat.Superscript == FormatEffect.On)) {
                        if (CurrentSelectionSuperscript)
                            currentSelection.CharacterFormat.Superscript = FormatEffect.On;
                        else
                            currentSelection.CharacterFormat.Superscript = FormatEffect.Off;
                    }
                }
            }
            base.OnKeyDown(e);
        }
        double GetCurrentFontSize(string currentSelectionText) {
            var fontSizeRx = new Regex(@"\\fs([0-9]+)\s?");
            MatchCollection matches = fontSizeRx.Matches(currentSelectionText);
            if (matches.Count > 1 || matches.Count == 0)
                return double.NaN;
            else
                return (double.Parse(matches[0].Groups[1].Value)/2);
        }

        string GetCurrentFontFamily(string currentSelectionText) {
            var fontFamilyRx = new Regex(@"\\f([0-9]+)[\s,\\]");
            MatchCollection matches = fontFamilyRx.Matches(currentSelectionText);
            bool sameFontFamily = false;
            string lastFontFamily = null;
            foreach(Match m in matches) {
                if (lastFontFamily == null) {
                    lastFontFamily = m.Groups[1].Value;
                    sameFontFamily = true;
                } else {
                    if (lastFontFamily != m.Groups[1].Value) {
                        sameFontFamily = false;
                        break;
                    }
                }
            }
            if (sameFontFamily || currentSelection.Length == 0)
                return currentSelection.CharacterFormat.Name;
            return null;
        }

        protected override void OnSelectionChanged(object sender, RoutedEventArgs e) {
            base.OnSelectionChanged(sender, e);
            if (!selectionLocked) {
                if (SelectionTestIsSetByImageSize) {
                    SelectionTestIsSetByImageSize = false;
                    return;
                }
                currentSelection = Document.Selection;
                string currentSelectionText;
                try {
                    currentSelection.GetText(TextGetOptions.FormatRtf, out currentSelectionText);
                } catch {
                    currentSelectionText = "";
                }
                if (currentSelection.Length == 0) {
                    CurrentSelectionFontSize = currentSelection.CharacterFormat.Size;
                } else {
                    CurrentSelectionFontSize = GetCurrentFontSize(currentSelectionText);
                }

                CurrentSelectionFontFamily = GetCurrentFontFamily(currentSelectionText);
                CurrentSelectionBoldDecoration = (currentSelection.CharacterFormat.Bold == FormatEffect.On);
                CurrentSelectionItalicDecoration = (currentSelection.CharacterFormat.Italic == FormatEffect.On);
                CurrentSelectionUnderlineDecoration = (currentSelection.CharacterFormat.Underline == UnderlineType.Single);
                CurrentSelectionSubscript = (currentSelection.CharacterFormat.Subscript == FormatEffect.On);
                CurrentSelectionSuperscript = (currentSelection.CharacterFormat.Superscript == FormatEffect.On);
                CurrentSelectionAlignment = currentSelection.ParagraphFormat.Alignment;
                CurrentSelectionBulletsList = !(currentSelection.ParagraphFormat.ListLevelIndex == 0 || currentSelection.ParagraphFormat.ListType != MarkerType.Bullet);
                bool imageWasSelected = IsImageSelected;
                if (currentSelection.Length == 0) {
                    var tempRange = Document.GetRange(currentSelection.StartPosition - 1, currentSelection.StartPosition);
                    string tempRangeContent = "";
                    try {
                        tempRange.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                    } catch {
                        tempRangeContent = "";
                    }
                    if (tempRangeContent.Contains("\\pict")) {
                        currentSelection.StartPosition -= 1;
                        currentSelection.EndPosition += 1;
                        IsImageSelected = true;
                    } else {
                        tempRange = Document.GetRange(currentSelection.StartPosition, currentSelection.StartPosition + 1);
                        try {
                            tempRange.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                        } catch {
                            tempRangeContent = "";
                        }
                        if (tempRangeContent.Contains("\\pict")) {
                            currentSelection.EndPosition += 2;
                            IsImageSelected = true;
                        } else {
                            IsImageSelected = false;
                        }
                    }
                } else {
                    string tempRangeContent;
                    currentSelection.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                    if (Math.Abs(currentSelection.Length) > 2) IsImageSelected = false;
                    else IsImageSelected = tempRangeContent.Contains("\\pict");
                }
                if (imageWasSelected && !imageLocker.IsLocked)
                    UpdateImageParams();
            }
        }
        bool SelectionTestIsSetByImageSize = false;
        protected async void OnSelectedImageHeightChanged() {
            if (IsImageSelected && !imageLocker.IsLocked) {
                selectionLocked = true;
                imageLocker.Lock();
                string tempRangeContent;
                currentSelection.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                string newHeight = "\\pichgoal" + SelectedImageHeight * 10;
                Regex hRegex = new Regex(@"\\pichgoal[0-9]*");
                string valueToReplace = hRegex.Match(tempRangeContent).Value;
                tempRangeContent = tempRangeContent.Replace(valueToReplace, newHeight);
                SelectionTestIsSetByImageSize = true;
                currentSelection.SetText(TextSetOptions.FormatRtf, tempRangeContent);
                await Task.Delay(100);
                imageLocker.Unlock();
                selectionLocked = false;
            }
        }
        protected async void OnSelectedImageWidthChanged() {
            if (IsImageSelected && !imageLocker.IsLocked) {
                selectionLocked = true;
                imageLocker.Lock();
                string tempRangeContent;
                currentSelection.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                string newHeight = "\\picwgoal" + SelectedImageWidth * 10;
                Regex hRegex = new Regex(@"\\picwgoal[0-9]*");
                string valueToReplace = hRegex.Match(tempRangeContent).Value;
                tempRangeContent = tempRangeContent.Replace(valueToReplace, newHeight);
                SelectionTestIsSetByImageSize = true;
                currentSelection.SetText(TextSetOptions.FormatRtf, tempRangeContent);
                await Task.Delay(100);
                imageLocker.Unlock();
                selectionLocked = false;
            }
        }
        Locker imageLocker = new Locker();
        void UpdateImageParams() {
            if (!imageLocker.IsLocked) {
                selectionLocked = true;
                imageLocker.Lock();
                string tempRangeContent;
                currentSelection.GetText(TextGetOptions.FormatRtf, out tempRangeContent);
                if (!string.IsNullOrEmpty(tempRangeContent)) {
                    var matchesHeigth = new Regex(@"\\pichgoal([0-9]*)").Matches(tempRangeContent);
                    if (matchesHeigth.Count > 0 && matchesHeigth[0].Groups.Count > 1) {
                        int newHeight = int.Parse(matchesHeigth[0].Groups[1].Value) / 10;
                        if (SelectedImageHeight != newHeight)
                            SelectedImageHeight = newHeight;
                    }
                    var mathesWidth = new Regex(@"\\picwgoal([0-9]*)").Matches(tempRangeContent);
                    if (mathesWidth.Count > 0 && mathesWidth[0].Groups.Count > 1) {
                        int newWidth = int.Parse(mathesWidth[0].Groups[1].Value) / 10;
                        if (newWidth != SelectedImageWidth)
                            SelectedImageWidth = newWidth;
                    }
                }
                imageLocker.Unlock();
                selectionLocked = false;
            }
        }

        void OnCurrentForegroundChanged() {
            if (currentSelection != null) {
                currentSelection.CharacterFormat.ForegroundColor = CurrentForeground;
            } else {
                var currentFormat = Document.GetDefaultCharacterFormat();
                currentFormat.ForegroundColor = CurrentForeground;
                Document.SetDefaultCharacterFormat(currentFormat);
            }
        }
        protected virtual void OnCurrentSelectionListLevelChanged() {
            if (CurrentSelectionListLevel < 0)
                CurrentSelectionListLevel = 0;
            if (currentSelection != null) {
                currentSelection.ParagraphFormat.ListLevelIndex = CurrentSelectionListLevel;
            }
        }
        protected virtual void OnBulletsListChanged() {
            if (currentSelection != null) {
                if (CurrentSelectionBulletsList) {
                    string selectedTextRtf;
                    currentSelection.GetText(TextGetOptions.FormatRtf, out selectedTextRtf);
                    currentSelection.ParagraphFormat.ListType = MarkerType.Bullet;
                    currentSelection.ParagraphFormat.ListLevelIndex = CurrentSelectionListLevel;
                }
            }
        }
        protected virtual void OnCurrentSelectionUnderlineDecorationChanged() {
            if (currentSelection != null) {
                if (CurrentSelectionUnderlineDecoration != (currentSelection.CharacterFormat.Underline == UnderlineType.Single))
                    if (CurrentSelectionUnderlineDecoration)
                        currentSelection.CharacterFormat.Underline = UnderlineType.Single;
                    else
                        currentSelection.CharacterFormat.Underline = UnderlineType.None;
            }
        }
        protected virtual void OnCurrentSelectionItalicDecorationChanged() {
            if (currentSelection != null) {
                if (CurrentSelectionItalicDecoration != (currentSelection.CharacterFormat.Italic == FormatEffect.On))
                    if (CurrentSelectionItalicDecoration)
                        currentSelection.CharacterFormat.Italic = FormatEffect.On;
                    else
                        currentSelection.CharacterFormat.Italic = FormatEffect.Off;
            }
        }
        protected virtual void OnCurrentSelectionBoldDecorationChanged() {
            if (currentSelection != null && currentSelection.Length != 0) {
                if (CurrentSelectionBoldDecoration != (currentSelection.CharacterFormat.Bold == FormatEffect.On))
                    if (CurrentSelectionBoldDecoration)
                        currentSelection.CharacterFormat.Bold = FormatEffect.On;
                    else
                        currentSelection.CharacterFormat.Bold = FormatEffect.Off;
            }
        }
        protected virtual void OnCurrentSelectionFontSizeChanged() {
            if (currentSelection != null && currentSelection.Length != 0 && !double.IsNaN(CurrentSelectionFontSize)) {
                if (CurrentSelectionFontSize != currentSelection.CharacterFormat.Size)
                    currentSelection.CharacterFormat.Size = (float)CurrentSelectionFontSize;
            }
        }
        protected virtual void OnCurrentSelectionFontFamilyChanged() {
            if (CurrentSelectionFontFamily != null) {
                if (currentSelection != null) {
                    if (CurrentSelectionFontFamily != currentSelection.CharacterFormat.Name && CurrentSelectionFontFamily != "")
                        currentSelection.CharacterFormat.Name = CurrentSelectionFontFamily;
                }
            }
        }
        protected virtual void OnCurrentSelectionAlignmentChanged() {
            if (currentSelection != null) {
                if (CurrentSelectionAlignment != currentSelection.ParagraphFormat.Alignment)
                    currentSelection.ParagraphFormat.Alignment = CurrentSelectionAlignment;
            }
        }
        protected virtual void OnCurrentSelectionSubscriptChanged() {
            if (CurrentSelectionSubscript)
                CurrentSelectionSuperscript = false;
            if (currentSelection != null && currentSelection.Length != 0) {
                if (CurrentSelectionSubscript != (currentSelection.CharacterFormat.Subscript == FormatEffect.On))
                    if (CurrentSelectionSubscript) {
                        currentSelection.CharacterFormat.Subscript = FormatEffect.On;
                    } else {
                        currentSelection.CharacterFormat.Subscript = FormatEffect.Off;
                    }
            }
        }
        protected virtual void OnCurrentSelectionSuperscriptChanged() {
            if (CurrentSelectionSuperscript)
                CurrentSelectionSubscript = false;
            if (currentSelection != null && currentSelection.Length != 0) {
                if (CurrentSelectionSuperscript != (currentSelection.CharacterFormat.Superscript == FormatEffect.On))
                    if (CurrentSelectionSuperscript) {
                        currentSelection.CharacterFormat.Superscript = FormatEffect.On;
                    } else {
                        currentSelection.CharacterFormat.Superscript = FormatEffect.Off;
                    }
            }
        }
    }
}
