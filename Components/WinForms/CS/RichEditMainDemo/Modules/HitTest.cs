using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.Utils;
using System.Drawing.Drawing2D;

namespace DevExpress.XtraRichEdit.Demos {
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
    public partial class HitTest : DevExpress.XtraRichEdit.Demos.TutorialControl {     
        #region Fields
        HitTestManager hitTest;   
        RichEditHitTestResult result;
        int pageIndex;
        Point oldMousePosition;
        Dictionary<LayoutType, RichEditPen> dicHighlightLayoutElement;
        #endregion

        public HitTest() {
            InitializeComponent();
            OpenXmlLoadHelper.Load("HitTest.docx", richEditControl);            
            new RichEditDemoExceptionsHandler(richEditControl).Install();
           // richEditControl.Options.Comments.Visibility = RichEditCommentVisibility.Visible;
            AddTargetElements();
            SpecifyHighlightOptions();
            SubscribeToHighlightEvents();
        }
        void AddTargetElements() {
            cbScope.Properties.Items.Clear();
            cbScope.Properties.Items.AddEnum<ScopeType>();
            cbScope.SelectedIndex = 0;
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
        void HighlightPotionsChanged(object sender, EventArgs e) {
            SpecifyHighlightOptions();
        }
        void SpecifyHighlightOptions() {
            dicHighlightLayoutElement = new Dictionary<LayoutType, RichEditPen>();
            dicHighlightLayoutElement.Add(LayoutType.Page, (highlightPage.Checked == true) ? new RichEditPen(pageHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.PageArea, (highlightPageArea.Checked == true) ? new RichEditPen(pageAreaHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.Column, (highlightColumn.Checked == true) ? new RichEditPen(columnHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.Row, (highlightRow.Checked == true) ? new RichEditPen(rowHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.PlainTextBox, (highlightBox.Checked == true) ? new RichEditPen(boxHigtlightColor.Color, 3) : null);
            dicHighlightLayoutElement.Add(LayoutType.CharacterBox, (highlightCharacterBox.Checked == true) ? new RichEditPen(characterBoxHigtlightColor.Color, 3) : null);
        }        
        void RichEditControl_MouseMove(object sender, MouseEventArgs e) {
            Point currentMousePosition = e.Location;
            if (oldMousePosition != currentMousePosition) {
                CalculateResult(e);
                richEditControl.Invalidate();
                oldMousePosition = currentMousePosition;
            }            
        }        
        void RichEditControl_MouseEnter(object sender, EventArgs e) {
            richEditControl.MouseMove += RichEditControl_MouseMove;
            richEditControl.BeforePagePaint += RichEditControl_BeforePagePaint;
            richEditControl.MouseClick += RichEditControl_MouseClick;            
        }                
        void RichEditControl_MouseLeave(object sender, EventArgs e) {
            richEditControl.MouseMove -= RichEditControl_MouseMove;
            richEditControl.BeforePagePaint -= RichEditControl_BeforePagePaint;
            richEditControl.MouseClick -= RichEditControl_MouseClick;            
            richEditControl.Invalidate();
        }
        void RichEditControl_MouseClick(object sender, MouseEventArgs e) {
            lbResult.Items.Clear();
            CalculateResult(e);
            string leftSpace = "";
            string specialChar = "  ";
            RichEditHitTestResult reverseResult = RichEditHitTestResult.Reverse(result);
            while (reverseResult != null) {
                if (leftSpace.Length == 2)
                    specialChar = "- ";
                lbResult.Items.Add(leftSpace + specialChar + reverseResult.LayoutElement.Type.ToString());
                leftSpace += "  ";
                reverseResult = reverseResult.Next;
            }
        }
        void CalculateResult(MouseEventArgs e) {
            Point point = e.Location;
            HitTestSearchOption searchOption = HitTestSearchOption.Exact;
            if (rgSearchOptions.SelectedIndex == 1)
                searchOption = HitTestSearchOption.Nearest;
            DevExpress.XtraRichEdit.PageLayoutPosition pageLayoutPosition = richEditControl.ActiveView.GetDocumentLayoutPosition(point);
            if (pageLayoutPosition == null) {
                result = null;
                return;
            }
            pageIndex = pageLayoutPosition.PageIndex;
            point = pageLayoutPosition.Position;
            hitTest = new HitTestManager(richEditControl.DocumentLayout);
            LayoutPage layoutPage = richEditControl.DocumentLayout.GetPage(pageIndex);
            ExecuteHitTest(layoutPage, point, searchOption);           
        }
        void ExecuteHitTest(LayoutPage layoutPage, Point point, HitTestSearchOption searchOption) {
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
        void RichEditControl_BeforePagePaint(object sender, DevExpress.XtraRichEdit.BeforePagePaintEventArgs e) {
            if (e.Page.Index == pageIndex)
                e.Painter = new HitTestPagePainter(RichEditHitTestResult.Reverse(result), dicHighlightLayoutElement, (highlightOther.Checked == true) ? new RichEditPen(otherHigtlightColor.Color, 3) : null);
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
            : this(result, dicHighlightLayoutType, new RichEditPen(Color.Green, 3)) {
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
                        Point[] pointToDraw = ((LayoutFloatingObject)layoutElement).GetCoordinates();
                        this.Canvas.DrawLines(currentHighLightPen, pointToDraw);
                        this.Canvas.DrawLine(currentHighLightPen, pointToDraw[3], pointToDraw[0]);
                    }                    
                    else {
                        LayoutTextBox parentTextBox = layoutElement.GetParentByType<LayoutTextBox>();
                        if (parentTextBox != null) {
                            Matrix matrix = parentTextBox.GetRotationMatrix();
                            Rectangle bounds = layoutElement.Bounds;
                            Point[] points = new Point[] {
                                new Point(bounds.X, bounds.Y),
                                new Point(bounds.X + bounds.Width, bounds.Y),
                                new Point(bounds.X + bounds.Width, bounds.Y + bounds.Height),
                                new Point(bounds.X, bounds.Y+bounds.Height),
                                new Point(bounds.X, bounds.Y) };
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
