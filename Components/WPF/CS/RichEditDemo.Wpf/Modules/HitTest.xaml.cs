
using System;
using System.Collections.Generic;
using System.Windows;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.Xpf.Editors;
using DevExpress.XtraRichEdit;
using System.Globalization;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.Xpf.RichEdit;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace RichEditDemo {
    public enum ScopeType {
        [Description("Page")]
        Page,
        [Description("Main Page Area")]
        MainPageArea,
        [Description("Header Page Area")]
        HeaderPageArea,
        [Description("Footer Page Area")]
        FooterPageArea
    }
    public partial class HitTest : RichEditDemoModule {
        #region Fields
        HitTestManager hitTest;
        RichEditHitTestResult result;
        int pageIndex;
        System.Windows.Point oldMousePosition;
        Dictionary<LayoutType, RichEditPen> dicHighlightLayoutElement;
        #endregion
        public HitTest() {
            InitializeComponent();
            OpenXmlLoadHelper.Load(@"HitTest.docx", richEdit);
            richEdit.Options.DocumentCapabilities.Comments = DocumentCapability.Disabled;
            richEdit.Options.Comments.Visibility = RichEditCommentVisibility.Hidden;
            richEdit.LayoutUnit = DocumentLayoutUnit.Pixel;
            SpecifyHighlightOptions();
            SubscribeToHighlightEvents();
        }
        void SubscribeToHighlightEvents() {
            highlightPage.EditValueChanged += HighlightPotionsChanged;
            pageHigtlightColor.ColorChanged += HighlightPotionsChanged;
            highlightPageArea.EditValueChanged += HighlightPotionsChanged;
            pageAreaHigtlightColor.ColorChanged += HighlightPotionsChanged;
            highlightColumn.EditValueChanged += HighlightPotionsChanged;
            columnHigtlightColor.ColorChanged += HighlightPotionsChanged;
            highlightRow.EditValueChanged += HighlightPotionsChanged;
            rowHigtlightColor.ColorChanged += HighlightPotionsChanged;
            highlightBox.EditValueChanged += HighlightPotionsChanged;
            boxHigtlightColor.ColorChanged += HighlightPotionsChanged;
            highlightCharacterBox.EditValueChanged += HighlightPotionsChanged;
            characterBoxHigtlightColor.ColorChanged += HighlightPotionsChanged;
        }
        void HighlightPotionsChanged(object sender, RoutedEventArgs e) {
            SpecifyHighlightOptions();
        }
        void SpecifyHighlightOptions() {
            dicHighlightLayoutElement = new Dictionary<LayoutType, RichEditPen>();
            dicHighlightLayoutElement.Add(LayoutType.Page, (highlightPage.IsChecked == true) ? new RichEditPen(pageHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.PageArea, (highlightPageArea.IsChecked == true) ? new RichEditPen(pageAreaHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.Column, (highlightColumn.IsChecked == true) ? new RichEditPen(columnHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.Row, (highlightRow.IsChecked == true) ? new RichEditPen(rowHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.PlainTextBox, (highlightBox.IsChecked == true) ? new RichEditPen(boxHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.CharacterBox, (highlightCharacterBox.IsChecked == true) ? new RichEditPen(characterBoxHigtlightColor.Color, 3) : null);
        }
        void RichEditControl_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) {
            System.Windows.Point currentMousePosition = e.GetPosition(richEdit);
            if (oldMousePosition != currentMousePosition) {
                CalculateResult(e);
                richEdit.Refresh();
                oldMousePosition = currentMousePosition;
            }
        }
        void RichEditControl_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e) {
            richEdit.PreviewMouseMove += RichEditControl_MouseMove;
            richEdit.BeforePagePaint += RichEditControl_BeforePagePaint;
            richEdit.PreviewMouseLeftButtonDown += RichEditControl_MouseClick;
        }
        void RichEditControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e) {
            richEdit.PreviewMouseMove -= RichEditControl_MouseMove;
            richEdit.BeforePagePaint -= RichEditControl_BeforePagePaint;
            richEdit.PreviewMouseLeftButtonDown -= RichEditControl_MouseClick;
            richEdit.Refresh();
            result = null;
        }
        void RichEditControl_MouseClick(object sender, System.Windows.Input.MouseEventArgs e) {
            lbResult.Items.Clear();
            CalculateResult(e);
            string leftSpace = "";
            string specialChar = "  ";
            RichEditHitTestResult reverseResult = RichEditHitTestResult.Reverse(result);
            while (reverseResult !=null) {
                if (leftSpace.Length == 2)
                    specialChar = "- ";
                lbResult.Items.Add(leftSpace + specialChar + reverseResult.LayoutElement.Type.ToString());
                leftSpace += "  ";
                reverseResult = reverseResult.Next;
            }
        }
        void CalculateResult(System.Windows.Input.MouseEventArgs e) {
            System.Windows.Point winPoint = e.GetPosition(richEdit);
            System.Drawing.Point point = new System.Drawing.Point( (int)winPoint.X, (int)winPoint.Y);
            HitTestSearchOption searchOption = HitTestSearchOption.Exact;
            if (nearestHit.IsChecked == true)
                searchOption = HitTestSearchOption.Nearest;
            DevExpress.XtraRichEdit.PageLayoutPosition pageLayoutPosition = richEdit.ActiveView.GetDocumentLayoutPosition(point);
            if (pageLayoutPosition == null) {
                result = null;
                return;
            }
            pageIndex = pageLayoutPosition.PageIndex;
            point = pageLayoutPosition.Position;
            hitTest = new HitTestManager(richEdit.DocumentLayout);
            LayoutPage layoutPage = richEdit.DocumentLayout.GetPage(pageIndex);
            ExecuteHitTest(layoutPage, point, searchOption);
        }
        void ExecuteHitTest(LayoutPage layoutPage, System.Drawing.Point point, HitTestSearchOption searchOption) {
            switch ((ScopeType)cbScope.EditValue) {
                case ScopeType.Page:
                    result = hitTest.HitTest(layoutPage, point, searchOption);
                    break;
                case ScopeType.MainPageArea:
                    result = hitTest.HitTest(layoutPage.PageAreas[0], point, searchOption);
                    break;
                case ScopeType.HeaderPageArea:
                    if (layoutPage.Header != null)
                        result = hitTest.HitTest(layoutPage.Header, point, searchOption);
                    break;
                case ScopeType.FooterPageArea:
                    if (layoutPage.Footer != null)
                        result = hitTest.HitTest(layoutPage.Footer, point, searchOption);
                    break;
            }
        }
        void RichEditControl_BeforePagePaint(object sender, BeforePagePaintEventArgs e) {
            if (e.Page.Index == pageIndex)
                e.Painter = new HitTestPagePainter(RichEditHitTestResult.Reverse(result), dicHighlightLayoutElement, (highlightOther.IsChecked == true) ? new RichEditPen(otherHigtlightColor.Color, 3) : null);
        }
    }
    public class HitTestPagePainter : PagePainter {
        RichEditHitTestResult result;
        Dictionary<LayoutType, RichEditPen> dicHighlightLayoutType;
        RichEditPen defaultHighlightPen;
        public HitTestPagePainter(RichEditHitTestResult result)
            : this(result, new Dictionary<LayoutType, RichEditPen>()) {
        }
        public HitTestPagePainter(RichEditHitTestResult result, Dictionary<LayoutType, RichEditPen> dicHighlightLayoutType)
            : this(result, dicHighlightLayoutType, new RichEditPen(System.Windows.Media.Colors.Green, 3)){
        }
        public HitTestPagePainter(RichEditHitTestResult result, Dictionary<LayoutType, RichEditPen> dicHighlightLayoutType, RichEditPen defaultHighlightPen) {
            this.result = result;
            this.dicHighlightLayoutType = dicHighlightLayoutType;
            this.defaultHighlightPen = defaultHighlightPen;
        }
        public override void DrawPage(LayoutPage page) {
            base.DrawPage(page);
            RichEditPen currentHighLightPen;
            LayoutElement layoutElement;
            while (result != null) {
                layoutElement = result.LayoutElement;
                if (!dicHighlightLayoutType.TryGetValue(layoutElement.Type, out currentHighLightPen))
                    currentHighLightPen = defaultHighlightPen;
                if (currentHighLightPen != null) {
                    if (layoutElement.Type == LayoutType.FloatingPicture || layoutElement.Type == LayoutType.TextBox) {
                        System.Drawing.Point[] pointToDraw = ((LayoutFloatingObject)layoutElement).GetCoordinates();
                        this.Canvas.DrawLines(currentHighLightPen, pointToDraw);
                        this.Canvas.DrawLine(currentHighLightPen, pointToDraw[3], pointToDraw[0]);
                    }
                    else {
                        LayoutTextBox parentTextBox = layoutElement.GetParentByType<LayoutTextBox>();
                        if (parentTextBox != null) {
                            Matrix matrix = parentTextBox.GetRotationMatrix();
                            Rectangle bounds = layoutElement.Bounds;
                            System.Drawing.Point[] points = new System.Drawing.Point[] {
                                new System.Drawing.Point(bounds.X, bounds.Y),
                                new System.Drawing.Point(bounds.X + bounds.Width, bounds.Y),
                                new System.Drawing.Point(bounds.X + bounds.Width, bounds.Y + bounds.Height),
                                new System.Drawing.Point(bounds.X, bounds.Y+bounds.Height),
                                new System.Drawing.Point(bounds.X, bounds.Y) };
                            matrix.TransformPoints(points);
                            this.Canvas.DrawLines(currentHighLightPen, points);
                            matrix.Dispose();
                        }
                        else
                            this.Canvas.DrawRectangle(currentHighLightPen, layoutElement.Bounds);
                    }
                }
                result = result.Next;
            }
        }
    }
}
