Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic

Namespace DevExpress.XtraSpreadsheet.Demos
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DemoUtils.SetDatabasePath()
			DevExpress.UserSkins.BonusSkins.Register()
			Application.Run(New frmMain())
		End Sub
	End Class
End Namespace
