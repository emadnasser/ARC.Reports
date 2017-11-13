Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraGauges.Demos
    Partial Public Class DigitalClock
        Inherits TutorialControl

        Private lockTimerCounter As Integer = 0

        Public Sub New()
            InitializeComponent()
            timer.Start()
            OnTimerTick(Nothing, Nothing)
        End Sub
        Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
            If lockTimerCounter = 0 Then
                lockTimerCounter += 1
                UpdateTime()
                lockTimerCounter -= 1
            End If
        End Sub
        Sub UpdateTime()
            Dim time As String = DateTime.Now.ToLongTimeString()
            If GetStringLength(time) > digitalGauge2.DigitCount Then
                digitalGauge2.DigitCount = GetStringLength(time)
            End If
            digitalGauge2.Text = time
        End Sub
        Function GetStringLength(ByVal str As String) As Integer
            Dim counter As Integer = 0
            Dim pos As Integer = 0
            Do While pos < str.Length
                If str.Chars(pos) <> ":"c Then
                    counter += 1
                End If
                pos += 1
            Loop
            Return counter
        End Function
    End Class
End Namespace
