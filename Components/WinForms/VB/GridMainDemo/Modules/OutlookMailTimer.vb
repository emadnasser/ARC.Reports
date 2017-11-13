Imports System.Text
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Namespace DevExpress.XtraGrid.Demos
	Public Class MailTimer
		Private list As List(Of Message)
		Private control As AlertControl
		Private form As Form
		Private delay As Integer = 15000
		Private timer As Timer
		Private images32_Renamed As ImageCollection
		Private rnd As Random
		Public Sub New(ByVal list As List(Of Message), ByVal control As AlertControl, ByVal form As Form)
			Me.list = list
			Me.control = control
			Me.form = form
			timer = New Timer()
			timer.Interval = 5000
			AddHandler timer.Tick, AddressOf timer_Tick
			rnd = New Random()
		End Sub

		Private ReadOnly Property Images32() As ImageCollection
			Get
				If images32_Renamed Is Nothing Then
                    images32_Renamed = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("mail.png", GetType(frmMain).Assembly, New Size(32, 32))
				End If
				Return images32_Renamed
			End Get
		End Property

		Private Function GetMailImage(ByVal data As Integer) As Image
			If 0.Equals(data) Then
				Return Images32.Images(1)
			End If
			Return Images32.Images(0)
		End Function
		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Dim timer As Timer = TryCast(sender, Timer)
			If list.Count > 0 Then
				Dim message As Message = list(rnd.Next(list.Count - 1))
				ShowAlert(message)
			End If
			If timer.Interval < delay Then
				timer.Interval = delay
			End If
		End Sub

		Public Sub ShowAlert(ByVal message As Message)
			InitButtonsStyle(message)
			control.Show(form, message.From, message.Subject, Nothing, GetMailImage(message.Attachment), message)
		End Sub

		Private Sub InitButtonsStyle(ByVal message As Message)
			control.Buttons("Read").Down = 1.Equals(message.Read)
			control.Buttons("Attachment").Visible = 1.Equals(message.Attachment)
		End Sub

		Friend Sub Start()
			timer.Start()
		End Sub

		Friend Sub [Stop]()
			timer.Stop()
		End Sub
	End Class
End Namespace
