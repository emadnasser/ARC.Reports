Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Friend Class Program
		Private Sub New()
		End Sub
        <STAThread()> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Application.Run(New frmMain())
        End Sub
	End Class
End Namespace
