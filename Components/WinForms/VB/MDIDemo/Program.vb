Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.MDIDemo
	Friend Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New frmMain())
		End Sub

	End Class
End Namespace
