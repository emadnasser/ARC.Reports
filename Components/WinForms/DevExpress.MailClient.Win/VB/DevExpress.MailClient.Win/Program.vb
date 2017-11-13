Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Skins
Imports DevExpress.Data.Filtering
Imports DevExpress.MailClient.Win.Forms
Imports System.Drawing
Imports System.Threading
Imports DevExpress.XtraEditors

Namespace DevExpress.MailClient.Win
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main(ByVal arguments() As String)
			DataHelper.ApplicationArguments = arguments
			DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments)
			DevExpress.UserSkins.BonusSkins.Register()
			DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
			SkinManager.EnableFormSkins()
			EnumProcessingHelper.RegisterEnum(Of TaskStatus)()
			UnpackHelper.Unpack()
			'SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);


			'System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-SA");
			'System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-SA");
			'Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;   //TODO
			'WindowsFormsSettings.RightToLeft = Utils.DefaultBoolean.True;
			'WindowsFormsSettings.RightToLeftLayout = Utils.DefaultBoolean.True;

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New LanguageSelectorForm())
		End Sub
	End Class
End Namespace
