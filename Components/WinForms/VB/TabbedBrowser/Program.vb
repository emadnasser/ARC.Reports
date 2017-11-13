Imports DevExpress.Skins

Namespace TabbedBrowser
    Friend Class TabbedBrowserApplicationContext
        Inherits ApplicationContext
        Private Shared formCount As Integer
        Public Sub New()
            formCount = 0
            Dim rootForm As New RootMainForm()
            AddHandler rootForm.Shown, AddressOf rootForm_Shown
            AddHandler rootForm.Disposed, AddressOf rootForm_Disposed
            rootForm.Show()
        End Sub
        Public Shared Sub rootForm_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            formCount -= 1
            If formCount = 0 Then
                Application.Exit()
            End If
        End Sub
        Public Shared Sub rootForm_Shown(ByVal sender As Object, ByVal e As EventArgs)
            formCount += 1
        End Sub
    End Class
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            SkinManager.EnableFormSkins()
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Seven Classic")
            DevExpress.Utils.BrowserEmulationHelper.DisableBrowserEmulation(System.Reflection.Assembly.GetEntryAssembly().GetName().Name)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New TabbedBrowserApplicationContext())
        End Sub
    End Class
End Namespace
