Imports DevExpress.Data.Filtering
Imports DevExpress.MailClient.Win
Imports DevExpress.MailDemo.Win
Imports DevExpress.ProductsDemo.Win.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.ProductsDemo.Win
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main(ByVal arguments() As String)
			DataHelper.ApplicationArguments = arguments
			Dim enUs As New System.Globalization.CultureInfo("en-US")
			System.Threading.Thread.CurrentThread.CurrentCulture = enUs
			System.Threading.Thread.CurrentThread.CurrentUICulture = enUs
			DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments)
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
			SkinManager.EnableFormSkins()
			EnumProcessingHelper.RegisterEnum(Of TaskStatus)()

			SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New frmMain())
		End Sub
	End Class
End Namespace
