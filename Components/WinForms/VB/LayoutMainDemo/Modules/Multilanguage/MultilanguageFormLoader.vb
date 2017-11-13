Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace DevExpress.XtraLayout.Demos.Modules
	Public Class MultilanguageFormLoader
		Inherits MarshalByRefObject

		Private form As DevExpress.XtraLayout.Demos.MultilanguageForm
		Private oldCulture As System.Globalization.CultureInfo

		Private Sub SetDpiMode(ByVal selectDpiMode As Integer)
			Dim scale As Single = 0F
			form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Select Case selectDpiMode
				Case 0
					scale = 0.75F
				Case 1
					scale = 1F
				Case 2
					scale = 1.25F
				Case 3
					scale = 1.5F
			End Select
			form.ChangedSize(scale)
		End Sub
		Private Sub SetLayoutMode(ByVal selectLayoutMode As Integer)
			Select Case selectLayoutMode
				Case 0
					form.SetLayout(DevExpress.XtraLayout.Utils.LayoutMode.Flow)
				Case 1
					form.SetLayout(DevExpress.XtraLayout.Utils.LayoutMode.Regular)
			End Select
		End Sub
		Private Function SetLocalization(ByVal selectLocalizationMode As Integer) As String
			Dim localization As String = String.Empty
			Select Case selectLocalizationMode
				Case 0
					localization = "en"
				Case 1
					localization = "de-DE"
			End Select
			Return localization
		End Function
		Private Sub SetSizeMode(ByVal selectSizeMode As Integer)
			Select Case selectSizeMode
				Case 0
					form.ShowAnimation()
				Case 1
					form.Size = form.Landscape
				Case 2
					form.Size = form.Portrait
			End Select
		End Sub

		Protected Sub RestoreCulture()
			System.Threading.Thread.CurrentThread.CurrentUICulture = oldCulture
		End Sub
		Protected Sub SaveCulture()
			oldCulture = System.Threading.Thread.CurrentThread.CurrentUICulture
		End Sub

		Public Sub Load(ByVal selectLocalizationMode As Integer, ByVal selectLayoutMode As Integer, ByVal selectSizeMode As Integer, ByVal selectDpiMode As Integer)
			Dim localization As String = SetLocalization(selectLocalizationMode)
			SaveCulture()
			System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(localization)
			form = New DevExpress.XtraLayout.Demos.MultilanguageForm()
			SetLayoutMode(selectLayoutMode)
			SetDpiMode(selectDpiMode)
			SetSizeMode(selectSizeMode)
			form.ShowDialog()
			RestoreCulture()
		End Sub
	End Class
End Namespace
