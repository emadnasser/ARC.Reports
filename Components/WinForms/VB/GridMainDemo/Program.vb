Imports System.Globalization

Namespace DevExpress.XtraGrid.Demos
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		<STAThread> _
		Shared Sub Main(ByVal arguments() As String)
			'DevExpress.Skins.SkinManager.SetDPIAware();
			DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments)
			Dim demoCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
			demoCI.NumberFormat.CurrencySymbol = "$"
			demoCI.NumberFormat.CurrencyDecimalDigits = 2
			Application.CurrentCulture = demoCI

			DevExpress.UserSkins.BonusSkins.Register()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New frmMain(arguments))
		End Sub
	End Class
End Namespace
