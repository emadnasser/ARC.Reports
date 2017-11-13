Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos
    Friend Class Program
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            Application.Run(New frmMain())
        End Sub

    End Class
End Namespace
