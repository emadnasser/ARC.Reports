Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
    Friend Class Program
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()

            Application.SetCompatibleTextRenderingDefault(False)
            SplashScreenManager.ShowForm(CType(Nothing, Form), GetType(RibbonSimplePadSplashScreen), True, True)
            Application.Run(New frmMain())
        End Sub
    End Class
End Namespace
