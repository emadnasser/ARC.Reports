Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraGauges.Demos
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
        <STAThread()> _
        Shared Sub Main(ByVal arguments() As String)
            DevExpress.UserSkins.BonusSkins.Register()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Application.Run(New frmMain(arguments))
        End Sub

	End Class
End Namespace
