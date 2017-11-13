Namespace DevExpress.XtraEditors.Demos
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		<STAThread> _
		Shared Sub Main()
			DevExpress.UserSkins.BonusSkins.Register()
			Application.Run(New frmMain())
		End Sub

	End Class
End Namespace
