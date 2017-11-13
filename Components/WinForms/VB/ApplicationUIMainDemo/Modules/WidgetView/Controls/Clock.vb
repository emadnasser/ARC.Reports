Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class Clock
		Inherits UserControl
		Private timer As Timer = New Timer()
		Public Sub New()
			InitializeComponent()
			timer.Interval = 1000
			AddHandler timer.Tick, AddressOf OnTick
			timer.Start()
			OnTick(Nothing, Nothing)
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
                DisableTimer()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub DisableTimer()
            timer.Stop()
            timer = Nothing
        End Sub
        Private Sub OnTick(ByVal sender As Object, ByVal e As EventArgs)
            If Disposing Then
                DisableTimer()
                Return
            End If
            Dim currentDate As System.DateTime = System.DateTime.Now
            labelControl1.Text = "<b>" & String.Format("{0:T}", currentDate) & "</b><br><size=10>" & currentDate.ToString("D")
        End Sub
	End Class
End Namespace
