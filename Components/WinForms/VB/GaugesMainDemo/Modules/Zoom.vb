Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class ZoomFeature
        Inherits TutorialControl
        Public Sub New()
            InitializeComponent()
            zoomTrackBarControl1_EditValueChanged(Nothing, Nothing)
        End Sub
        Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles zoomTrack.EditValueChanged
            Dim oldBounds As Rectangle = circularGauge1.Bounds
            oldBounds.Inflate(2, 2)
            Dim w As Integer = CInt(Fix(1000 * Math.Sin(Math.PI / 180 * 5 * zoomTrack.Value)))
            circularGauge1.Bounds = New Rectangle(New Point(5, 5), New Size(w, w))
            If oldBounds.Width > circularGauge1.Bounds.Width Then
                gaugeControl1.Invalidate(oldBounds)
            End If
        End Sub
    End Class
End Namespace
