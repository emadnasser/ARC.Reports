using Windows.Storage.Streams;
using Windows.UI.Text;
using Windows.UI.Xaml.Media;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI;
using System;
using System.Text.RegularExpressions;

namespace RibbonDemo {
    public class DemoRichEditorBehavior : ServiceBase, IRichEditorContentService, IRichEditorFontService, IRichEditorCommonActionsService, IRichEditorInsertService, IRichEditorParagraphService {
        public void Copy() {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null && AssociatedEditor.Document.CanCopy())
                    AssociatedEditor.Document.Selection.Copy();
            }
        }
        public void Paste() {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null && AssociatedEditor.Document.CanPaste())
                    AssociatedEditor.Document.Selection.Paste(0);
            }
        }
        public void Cut() {
            if (AssociatedEditor != null)
                AssociatedEditor.Document.Selection.Cut();
        }
        public void Undo() {
            if (AssociatedEditor != null)
                if (AssociatedEditor.Document.CanUndo()) {
                    AssociatedEditor.Document.Undo();
                }
        }
        public void Redo() {
            if (AssociatedEditor != null)
                if (AssociatedEditor.Document.CanRedo())
                    AssociatedEditor.Document.Redo();
        }
        public void InsertImage(FileRandomAccessStream imageFileStream) {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                var selection = AssociatedEditor.Document.Selection;
                var alignment = selection.ParagraphFormat.Alignment;
                selection.SetText(TextSetOptions.FormatRtf, "\n");
                selection.StartPosition = selection.EndPosition;
                selection.InsertImage(300, 200, 1, VerticalCharacterAlignment.Top, "image", imageFileStream);
                selection.StartPosition -= 1;
                selection.ParagraphFormat.Alignment = ParagraphAlignment.Center;
                selection.StartPosition = selection.EndPosition;
                selection.SetText(TextSetOptions.FormatRtf, "\n");
                selection.EndPosition += 1;
                selection.StartPosition = selection.EndPosition;
                selection.ParagraphFormat.Alignment = alignment;
            }
        }
        public void OpenFileFromStream(IRandomAccessStream rtfFileStream) {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null) {
                    AssociatedEditor.Document.LoadFromStream(TextSetOptions.FormatRtf, rtfFileStream);
                    string text;
                    AssociatedEditor.Document.GetText(TextGetOptions.FormatRtf, out text);
                    AssociatedEditor.RTFContentIsUpdated = true;
                    AssociatedEditor.RTFText = text;
                }
            }
        }
        public void SaveFileToStream(IRandomAccessStream rtfFileStream) {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null)
                    AssociatedEditor.Document.SaveToStream(TextGetOptions.FormatRtf, rtfFileStream);
            }
        }
        public void SetForeground(SolidColorBrush foreground) {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null) {
                    AssociatedEditor.Document.Selection.CharacterFormat.ForegroundColor = foreground.Color;
                    AssociatedEditor.CurrentForeground = foreground.Color;
                }
            }
        }
        public void SetBackground(SolidColorBrush background) {
            if (AssociatedEditor != null) {
                if (AssociatedEditor.Document.Selection != null) {
                    AssociatedEditor.Document.Selection.CharacterFormat.BackgroundColor = background.Color;
                }
            }
        }

        public void IncreaseFontFize() {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                string currentSelectionText = "";
                AssociatedEditor.Document.Selection.GetText(TextGetOptions.FormatRtf, out currentSelectionText);
                var fontSizeRx = new Regex(@"\\fs([0-9]+)");
                var Matches = fontSizeRx.Matches(currentSelectionText);
                foreach (Match m in Matches) {

                    int size = int.Parse(m.Groups[1].Value) + 2;
                    if (size < 98) {
                        string newFsExpr = "\\fs" + size;
                        currentSelectionText = currentSelectionText.Replace(m.Groups[0].Value, newFsExpr);
                    }
                }
                AssociatedEditor.Document.Selection.SetText(TextSetOptions.FormatRtf, currentSelectionText);
            }
        }

        public void DecreaseFontSize() {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                string currentSelectionText = "";
                AssociatedEditor.Document.Selection.GetText(TextGetOptions.FormatRtf, out currentSelectionText);
                var fontSizeRx = new Regex(@"\\fs([0-9]+)");
                var Matches = fontSizeRx.Matches(currentSelectionText);
                foreach (Match m in Matches) {
                    int size = int.Parse(m.Groups[1].Value) - 2;
                    if (size > 10) {
                        string newFsExpr = "\\fs" + size;
                        currentSelectionText = currentSelectionText.Replace(m.Groups[0].Value, newFsExpr);
                    }
                }
                AssociatedEditor.Document.Selection.SetText(TextSetOptions.FormatRtf, currentSelectionText);
            }
        }

        public void IncreaseParagraphIndent() {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                var pFormat = AssociatedEditor.Document.Selection.ParagraphFormat;
                if (pFormat.LeftIndent >= 0) {
                    pFormat.SetIndents(
                        pFormat.FirstLineIndent,
                        pFormat.LeftIndent + 5.0f,
                        pFormat.RightIndent
                    );
                }
            }
        }

        public void DecreaseParagraphIndent() {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                var pFormat = AssociatedEditor.Document.Selection.ParagraphFormat;
                if (pFormat.LeftIndent > 0) {
                    pFormat.SetIndents(
                        pFormat.FirstLineIndent,
                        pFormat.LeftIndent - 5.0f,
                        pFormat.RightIndent
                    );
                }
            }
        }

        public void SetListType(MarkerType type) {
            if (AssociatedEditor != null && AssociatedEditor.Document.Selection != null) {
                var pFormat = AssociatedEditor.Document.Selection.ParagraphFormat;
                pFormat.ListType = type;
                pFormat.ListStart = 1;
            }
        }

        public bool CanCopy() {
            if (AssociatedEditor != null) {
                return AssociatedEditor.Document.CanCopy();
            }
            return false;
        }

        public bool CanPaste() {
            if (AssociatedEditor != null) {
                return AssociatedEditor.Document.CanPaste();
            }
            return false;
        }

        public bool CanCut() {
            if (AssociatedEditor != null) {
                return AssociatedEditor.Document.CanCopy();
            }
            return false;
        }

        public bool CanUndo() {
            if (AssociatedEditor != null)
                return AssociatedEditor.Document.CanUndo() ? AssociatedEditor.InitialText != AssociatedEditor.RTFText : false;
            return false;
        }

        public bool CanRedo() {
            if (AssociatedEditor != null) {
                return AssociatedEditor.Document.CanRedo();
            }
            return false;
        }

        public void SetRawContent(string content) {
            AssociatedEditor.Do(x => {
                x.RTFContentIsUpdated = true;
                x.RTFText = content;
            });
        }

        public void SetDocumentColorsContainer(ColorPalette colorPalette) {
            AssociatedEditor.Do(x => x.DocumentColors = colorPalette);
        }

        DemoRichEditBoxExtended AssociatedEditor {
            get { return (AssociatedObject as DemoRichEditBoxExtended); }
        }

        public string FileName {
            get {
                if (AssociatedEditor != null)
                    return AssociatedEditor.FileName;
                return string.Empty;
            }
            set {
                AssociatedEditor.Do(x => x.FileName = value);
            }
        }

        public string FilePath {
            get {
                if (AssociatedEditor != null)
                    return AssociatedEditor.FilePath;
                return string.Empty;
            }
            set {
                AssociatedEditor.Do(x => x.FilePath = value);
            }
        }
    }
}
