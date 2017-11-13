Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraWizard.Demos
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dim frm As frmStart = New frmStart()
			frm.ShowDialog()
			If (Not frm.AllowSkin4Form) Then
			DevExpress.Skins.SkinManager.DisableFormSkins()
			End If
			Application.Run(New frmMain(frm.AllowAnimation, frm.WizardStyle))
		End Sub
	End Class
End Namespace
