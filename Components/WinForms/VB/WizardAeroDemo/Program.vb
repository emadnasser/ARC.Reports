Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing.Helpers

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
			If (Not NativeVista.IsVista) Then
				DevExpress.Skins.SkinManager.EnableFormSkins()
			End If
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dim frm As frmStart = New frmStart()
			frm.ShowDialog()
			If (Not DevExpress.Skins.SkinManager.AllowFormSkins) AndAlso (Not frm.AllowNativeVista) Then
				DevExpress.Skins.SkinManager.EnableFormSkins()
			End If
			Application.Run(New frmMain())
		End Sub
	End Class
End Namespace
