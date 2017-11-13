Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.MailClient.Win
	Partial Public Class LanguageSelectorForm
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private mainForm As frmMain
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Hide()
			SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
			mainForm = New frmMain()
			mainForm.ShowDialog()
			Close()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			Hide()
			System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("ar")
			System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("ar")
			My.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture 'TODO
			SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
			mainForm = New frmMain()
			mainForm.ShowDialog()
			Close()
		End Sub

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			Hide()
			System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("fa")
			System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("fa")
			My.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture 'TODO
			SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
			mainForm = New frmMain()
			mainForm.ShowDialog()
			Close()
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			Hide()
			System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("he")
			System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("he")
			My.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture 'TODO
			SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
			mainForm = New frmMain()
			mainForm.ShowDialog()
			Close()
		End Sub
	End Class
End Namespace
