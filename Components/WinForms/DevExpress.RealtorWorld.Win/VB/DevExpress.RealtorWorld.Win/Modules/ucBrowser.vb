Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucBrowser
		Inherits BaseModule
		Private url_string As String = "http://www.zillow.com/"
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property ModuleCaption() As String
			Get
				Return "zillow.com"
			End Get
		End Property
		Public Overrides ReadOnly Property AllowWaitDialog() As Boolean
			Get
				Return False
			End Get
		End Property
		Friend Overrides Sub ShowModule(ByVal item As Object)
			If webBrowser1.Url Is Nothing OrElse webBrowser1.Url.AbsoluteUri <> url_string Then
				SplashScreenManager.ShowDefaultWaitForm(FindForm(), False, True, False, 0)
				Navigate()
			End If
			MyBase.ShowModule(item)
		End Sub
		Friend Sub Navigate()
			webBrowser1.Navigate(url_string)
		End Sub
		Friend Sub RefreshBrowser()
			webBrowser1.Refresh()
		End Sub
		Private Sub webBrowser1_Navigated(ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs) Handles webBrowser1.Navigated
			SplashScreenManager.CloseForm(False)
		End Sub
	End Class
End Namespace
