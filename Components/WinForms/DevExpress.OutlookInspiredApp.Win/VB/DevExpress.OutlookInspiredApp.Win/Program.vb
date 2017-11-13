Imports DevExpress.Utils.Taskbar
Imports DevExpress.Internal
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports System.Drawing
Imports System

Namespace DevExpress.DevAV

    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Const AppName As String = "DevExpressWinOutlookInspiredApp"
        <STAThread>
        Shared Sub Main()
            TaskbarAssistant.Default.Initialize()
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve
            DataDirectoryHelper.LocalPrefix = "WinOutlookInspiredApp"
            Dim [exit] As Boolean = Nothing
            Using DataDirectoryHelper.SingleInstanceApplicationGuard(AppName, [exit])
                If [exit] Then
                    Return
                End If
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins()
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Office 2016 Colorful")
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True
                DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", AppHelper.GetDefaultSize())
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch
                DevExpress.XtraEditors.WindowsFormsSettings.CustomizationFormSnapMode = Utils.Controls.SnapMode.OwnerControl
                DevExpress.XtraEditors.WindowsFormsSettings.ColumnFilterPopupMode = XtraEditors.ColumnFilterPopupMode.Excel
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Using TempStartUpProcess As StartUpProcess = New StartUpProcess()
                    Using StartUpProcess.Status.Subscribe(New DemoStartUp())
                        Application.Run(New MainForm())
                    End Using
                End Using
            End Using
        End Sub
        Private Shared Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
            Dim partialName As String = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()
            If partialName = "entityframework" OrElse partialName = "system.data.sqlite" OrElse partialName = "system.data.sqlite.ef6" Then
                Dim path As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(GetType(Program).Assembly.Location), partialName & ".dll")
                Return System.Reflection.Assembly.LoadFrom(path)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
