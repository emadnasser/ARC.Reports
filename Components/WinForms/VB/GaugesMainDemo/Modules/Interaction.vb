Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Core.Primitive
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Base

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class InteractionFeature
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
        End Sub
        Sub gaugeControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gaugeControl1.MouseMove
            CheckCursor(TryCast(gaugeControl1, IGaugeContainer), e)
            If e.Button = MouseButtons.Left Then
                CalculateMouseValue(TryCast(gaugeControl1, IGaugeContainer), arcScaleComponent1, e)
            End If
        End Sub
        Sub gaugeControl2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gaugeControl2.MouseMove
            CheckCursor(TryCast(gaugeControl2, IGaugeContainer), e)
            If e.Button = MouseButtons.Left Then
                CalculateMouseValue(TryCast(gaugeControl2, IGaugeContainer), linearScaleComponent1, e)
            End If
        End Sub
        Sub gaugeControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gaugeControl1.MouseDown
            CalculateMouseValue(TryCast(gaugeControl1, IGaugeContainer), arcScaleComponent1, e)
        End Sub
        Sub gaugeControl2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gaugeControl2.MouseDown
            CalculateMouseValue(TryCast(gaugeControl2, IGaugeContainer), linearScaleComponent1, e)
        End Sub
        Sub CalculateMouseValue(ByVal container As IGaugeContainer, ByVal scale As IConvertibleScaleEx, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            If hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite Then
                Dim modelPt As PointF = MathHelper.PointToModelPoint(TryCast(scale, IElement(Of IRenderableElement)), New PointF(e.X, e.Y))
                Dim percent As Single = scale.PointToPercent(modelPt)
                scale.Value = scale.PercentToValue(percent)
            End If
        End Sub
        Sub CheckCursor(ByVal container As IGaugeContainer, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            Dim cursor As Cursor
            If (hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite) Then
                cursor = Cursors.Hand
            Else
                cursor = Cursors.Default
            End If
            If DirectCast(container, Control).Cursor <> cursor Then
                DirectCast(container, Control).Cursor = cursor
            End If
        End Sub
    End Class
End Namespace
