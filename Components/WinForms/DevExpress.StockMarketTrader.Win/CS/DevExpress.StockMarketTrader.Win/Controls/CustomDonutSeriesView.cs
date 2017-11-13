using System;
using System.Drawing;
using System.Runtime.InteropServices;
using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;

namespace DevExpress.StockMarketTrader {
    public class CustomSeriesLabel : DoughnutSeriesLabel {
        protected override void CalculateLayout(XtraCharts.Native.SimpleDiagramSeriesLabelLayoutList labelsLayout, XtraCharts.Native.SeriesPointLayout pointLayout, XtraCharts.Native.TextMeasurer textMeasurer) {
            PieSeriesPointLayout pieLayout = pointLayout as PieSeriesPointLayout;
            if (pieLayout == null)
                return;
            RefinedPointData pointData = pieLayout.PointData;
            SimpleDiagramDrawOptionsBase pieDrawOptions = pointData.DrawOptions as SimpleDiagramDrawOptionsBase;
            ConnectorPainterBase connectorPainter = null;
            ISimpleDiagramDomain domain = labelsLayout.Domain;
            RectangleF labelsBounds = domain.LabelsBounds;
            double lineAngle, crossAngle;
            SeriesLabelViewData labelViewData = pointData.LabelViewData[0];

            GRealPoint2D anchorPoint = CalculateAnchorPointAndAngles(domain, pieLayout, ref labelsBounds, out lineAngle, out crossAngle);
            if ((anchorPoint.X == 0 && anchorPoint.Y == 0) || (!IsInside && Double.IsNaN(lineAngle)))
                return;
            DiagramPoint startConnectorPoint = new DiagramPoint(anchorPoint.X, anchorPoint.Y);
            DiagramPoint finishConnectorPoint = new DiagramPoint(anchorPoint.X + (float)(Math.Cos(lineAngle) * LineLength),
                                                        anchorPoint.Y - (float)(Math.Sin(lineAngle) * LineLength));
            TextPainterBase textPainter;
            TextPainterBase textPainterTemp;
            DiagramPoint connectorFinishPoint = new DiagramPoint();
            if (IsTwoColumnsLabelAlignedToRight(lineAngle)) {
                textPainterTemp = labelViewData.CreateTextPainterAccordingAllowedBoundsForLabels(this, textMeasurer, finishConnectorPoint, 0.0, labelsLayout.Domain.Bounds);
                if (textPainterTemp != null) {
                    ZPlaneRectangle bounds = (ZPlaneRectangle)((TextPainter)textPainterTemp).BoundsWithBorder;
                    double dx = labelsBounds.Right - bounds.Right;
                    connectorFinishPoint = new DiagramPoint(bounds.Left + dx, finishConnectorPoint.Y);
                    textPainterTemp.Offset(dx, 0);
                }
            }
            else {
                textPainterTemp = labelViewData.CreateTextPainterAccordingAllowedBoundsForLabels(this, textMeasurer, finishConnectorPoint, Math.PI, labelsLayout.Domain.Bounds);
                if (textPainterTemp != null) {
                    ZPlaneRectangle bounds = (ZPlaneRectangle)((TextPainter)textPainterTemp).BoundsWithBorder;
                    double dx = labelsBounds.Left - bounds.Left;
                    connectorFinishPoint = new DiagramPoint(bounds.Right + dx, finishConnectorPoint.Y);
                    textPainterTemp.Offset(dx, 0);
                }
            }
            textPainter = new CustomSeriesTextPainter(textPainterTemp.Text, textPainterTemp.Bounds.Size, textPainterTemp.PropertiesProvider, textMeasurer, textPainterTemp.Bounds.Location, 300, 1, false);
            connectorPainter = new BrokenLineConnectorPainter(startConnectorPoint, finishConnectorPoint, connectorFinishPoint, lineAngle);
            PieSeriesLabelLayout layout = new PieSeriesLabelLayout(pointData, pieDrawOptions.Color, textPainter, connectorPainter, ResolveOverlappingMode, -lineAngle);
            labelsLayout.Add(layout);
        }
        internal static bool IsTwoColumnsLabelAlignedToRight(double lineAngle) {
            return Math.Cos(lineAngle) >= 0;
        }
    }

    public class CustomSeriesTextPainter : TextPainter {
        public CustomSeriesTextPainter(string text, SizeF textSize, ITextPropertiesProvider propertiesProvider, TextMeasurer textMeasurer, PointF location, int maxWidth, int maxLineCount, bool wordWrap)
            : base(text, textSize, propertiesProvider, textMeasurer, location, maxWidth, maxLineCount, wordWrap) {
        }
        [DllImport("shlwapi.dll")]
        static extern int ColorHLSToRGB(int H, int L, int S);
        static public System.Drawing.Color HLSToColor(int H, int L, int S) {
            return ColorTranslator.FromWin32(ColorHLSToRGB(H, L, S));
        }
        [DllImport("shlwapi.dll")]
        static extern void ColorRGBToHLS(int RGB, ref int H, ref int L, ref int S);
        static public void ColorToHLS(System.Drawing.Color C, ref int H, ref int L, ref int S) {
            ColorRGBToHLS(ColorTranslator.ToWin32(C), ref H, ref L, ref S);
        }
        protected Color GetTransformedColor(Color baseColor, float percent) {
            int h = 0;
            int l = 0;
            int s = 0;
            ColorToHLS(baseColor, ref h, ref l, ref s);
            l = (int)(l * percent);
            return HLSToColor(h, l, s);
        }
        public override void RenderWithClipping(IRenderer renderer, HitTestController hitTestController, object additionalHitObject, Color color, Rectangle clipBounds, double opacity) {
            Color baseColor = PropertiesProvider.GetTextColor(color);
            Color textColor, borderColor, backgroundColor;
            textColor = GetTransformedColor(baseColor, 1.38f);
            borderColor = GetTransformedColor(baseColor, 0.516f);
            backgroundColor = GetTransformedColor(baseColor, 0.458f);
            renderer.FillRectangle(Bounds, backgroundColor);
            Pen pen = new Pen(borderColor);
            renderer.DrawRectangle(Bounds, pen);
            NativeFont font = new NativeFont(PropertiesProvider.Font);
            renderer.DrawBoundedText(Text, font, textColor, PropertiesProvider, Bounds, PropertiesProvider.Alignment, StringAlignment.Center, 10);
            font.Dispose();
            pen.Dispose();
        }
    }

    public class CustomDoughnutSeriesView : DoughnutSeriesView {
        protected override SeriesLabelBase CreateSeriesLabel() {
            return new CustomSeriesLabel();
        }
    }
}
