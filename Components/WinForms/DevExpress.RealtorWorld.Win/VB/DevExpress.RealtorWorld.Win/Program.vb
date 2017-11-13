Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.Skins
Imports DevExpress.Skins.Info
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.RealtorWorld.Win
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			DataDirectoryHelper.SetWebBrowserMode()
			DevExpress.XtraEditors.WindowsFormsSettings.ApplyDemoSettings()
			SkinManager.EnableFormSkins()
			UserSkins.BonusSkins.Register()
			AppearanceObject.DefaultFont = New Font("Segoe UI", 8.25f)
			Dim skinCreator As New SkinBlobXmlCreator("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly, Nothing)
			SkinManager.Default.RegisterSkin(skinCreator)
			AsyncAdornerBootStrapper.RegisterLookAndFeel("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly)
			LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Metropolis")
			Dim demoCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
			demoCI.NumberFormat.CurrencySymbol = "$"
			SplashScreenManager.RegisterUserSkin(skinCreator)
			Application.CurrentCulture = demoCI
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			DataHelper.CreateWmiService()
			Application.Run(New frmMain())
		End Sub
	End Class
	Friend Interface IMainForm
		Sub ShowHome(ByVal home As Home)
		Sub ShowAgent(ByVal agent As Agent)
	End Interface
End Namespace
