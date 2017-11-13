Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.DockingDemo
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            Dim isBarDemo As Boolean = False
            If args.Length <> 0 Then
                isBarDemo = (args(0) = "-barDemo")
            End If
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
            If isBarDemo Then
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
            Else
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue")
            End If
            Dim splashScreenImage = New Bitmap(CurrentAssembly.GetManifestResourceStream("splashScreen.png"))
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, True, False)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain())
        End Sub
        Private Shared currentAssemblyCore As System.Reflection.Assembly
		Private Shared ReadOnly Property CurrentAssembly() As System.Reflection.Assembly
			Get
				If currentAssemblyCore Is Nothing Then
					currentAssemblyCore = System.Reflection.Assembly.GetExecutingAssembly()
				End If
				Return currentAssemblyCore
			End Get
		End Property
		Friend Shared Function CreateResourceStreams() As List(Of Stream)
			Dim fileStreams As List(Of Stream) = New List(Of Stream)()
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ProgramText.rtf"))
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ProgramText2.rtf"))
            fileStreams.Add(CurrentAssembly.GetManifestResourceStream("ProgramText3.rtf"))
			Return fileStreams
		End Function
		Friend Shared Function GetDocumentStream(ByVal fileName As String) As Stream
            Return CurrentAssembly.GetManifestResourceStream(String.Format("{0}.rtf", fileName))
		End Function
	End Class
End Namespace
