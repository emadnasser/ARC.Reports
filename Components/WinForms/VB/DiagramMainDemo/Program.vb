Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraDiagram.Demos
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        <STAThread>
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            Application.EnableVisualStyles()
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name)
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain())
        End Sub

    End Class
End Namespace
