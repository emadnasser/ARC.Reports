Imports System.IO

Namespace DevExpress.ApplicationUI.Demos
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private Sub New()
        End Sub
        <STAThread()> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Utils.Taskbar.Core.TaskbarAssistantCore.Initialize()
            Application.Run(New frmMain())
        End Sub
        Private Shared currentAssemblyCore As System.Reflection.Assembly
        Shared ReadOnly Property CurrentAssembly() As System.Reflection.Assembly
            Get
                If currentAssemblyCore Is Nothing Then
                    currentAssemblyCore = System.Reflection.Assembly.GetExecutingAssembly()
                End If
                Return currentAssemblyCore
            End Get
        End Property
        Friend Shared Function CreateResourceStreams() As List(Of Stream)
            Dim fileStreams As New List(Of Stream)()
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ucSolutionExplorer.rtf"))
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ucToolbox.rtf"))
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ucSolutionExplorer.rtf"))
            Return fileStreams
        End Function
        Friend Shared Function GetStream(ByVal fileName As String) As Stream
            Return CurrentAssembly.GetManifestResourceStream(String.Format("{0}", fileName))
        End Function
    End Class
End Namespace
