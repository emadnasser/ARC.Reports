Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos
    Partial Public Class NewPresets
        Inherits TutorialControl

        Private random As Random
        Private loadingCount As Integer = 0

        Public Sub New()
            random = New Random()
            InitializeComponent()
            InitLevelIndicatorPage()
            InitProgressPage()
            InitRatingPage()
            InitEqualizerPage()
            equalizerTimer.Interval = 200
            loadingTimer.Start()
            equalizerTimer.Start()
        End Sub
        Sub InitLevelIndicatorPage()
            equalizerLevel.Value = CInt(Fix((CType(levelIndicator.Gauges(0), ILinearGauge)).Scales(0).Value))
        End Sub
        Sub InitProgressPage()
            ratingValue.SelectedIndex = 2
        End Sub
        Sub InitRatingPage()
            progressValue.Value = CInt(Fix((CType(progress1.Gauges(0), ILinearGauge)).Scales(0).Value))
        End Sub
        Sub InitEqualizerPage()
            For Each scale As IScale In (CType(equalizer.Gauges(0), ILinearGauge)).Scales
                scale.Value = 0
            Next scale
        End Sub
        Sub OnLevelIndicatorValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles equalizerLevel.EditValueChanged
            CType(levelIndicator.Gauges(0), ILinearGauge).Scales(0).Value = equalizerLevel.Value
        End Sub
        Sub OnProgressValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles progressValue.EditValueChanged
            CType(progress1.Gauges(0), ILinearGauge).Scales(0).Value = progressValue.Value
            CType(progress2.Gauges(0), ILinearGauge).Scales(0).Value = progressValue.Value
        End Sub
        Sub OnRatingChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ratingValue.SelectedIndexChanged
            CType(rating.Gauges(0), ILinearGauge).Scales(0).Value = CInt(Fix(ratingValue.EditValue))
        End Sub
        Sub OnLoadingTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles loadingTimer.Tick
            loadingCount += 1
            CType(rating1.Gauges(0), ILinearGauge).Scales(0).Value = CSng(loadingCount Mod 10) * 10.0F + CSng(DateTime.Now.Millisecond) * 0.01F
        End Sub
        Sub OnEqualizerTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles equalizerTimer.Tick
            Dim freqCount As Integer = (CType(equalizer.Gauges(0), ILinearGauge)).Scales.Count
            For i As Integer = 0 To freqCount - 1
                Dim timeFactor As Double = (CDbl(DateTime.Now.Millisecond) + CDbl(i) * 50.0R) * 0.0002R
                Dim noiseFactor As Single = CSng(random.NextDouble()) * 0.4F
                Dim f As Single = CSng(Math.Sin(Math.PI * timeFactor)) + noiseFactor
                CType(equalizer.Gauges(0), ILinearGauge).Scales(i).Value = 20.0F + 60.0F * f

            Next i
        End Sub
    End Class
End Namespace
