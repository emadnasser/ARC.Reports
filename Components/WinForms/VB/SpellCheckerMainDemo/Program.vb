Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraSpellChecker.Demos
	Friend Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
			Application.Run(New frmMain())
		End Sub

	End Class
End Namespace