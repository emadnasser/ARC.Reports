Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors

Namespace PivotGridOlapBrowser
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			DevExpress.Skins.SkinManager.EnableFormSkins()
			Application.SetCompatibleTextRenderingDefault(False)

			If (Not AdomdMetaGetter.IsProviderAvailable) Then
				XtraMessageBox.Show("You should install Adomd Client assemblies and Ole Db Provider for Analysis Services " & "before running this demo", Nothing, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
