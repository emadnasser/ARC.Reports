Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			SchedulerDemoLogify.Register()

			DevExpress.UserSkins.BonusSkins.Register()
			Application.Run(New frmMain())
		End Sub
	End Class
End Namespace
