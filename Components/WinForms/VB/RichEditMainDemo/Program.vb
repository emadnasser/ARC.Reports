Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraSpellChecker.Native
Imports DevExpress.XtraRichEdit.SpellChecker

Namespace DevExpress.XtraRichEdit.Demos
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
