Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Namespace FinanceDashboardDemo
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			Application.SetCompatibleTextRenderingDefault(False)
			UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
			Application.Run(New ViewerForm())
		End Sub
	End Class
End Namespace
