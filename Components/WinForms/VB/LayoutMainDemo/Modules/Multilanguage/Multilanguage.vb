Imports DevExpress.XtraLayout.Demos.Modules
Imports System

Namespace DevExpress.XtraLayout.Demos
	Partial Public Class Multilanguage
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			AddHandler showFormButton.Click, AddressOf showButton_Click
			sizeModeRadioGroup.SelectedIndex = 1
			dpiModeRadioGroup.SelectedIndex = 1
		End Sub
		Private Sub showButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim ad As AppDomain = AppDomain.CreateDomain("New domain")
            Dim l As MultilanguageFormLoader = DirectCast(ad.CreateInstanceAndUnwrap(GetType(MultilanguageFormLoader).Assembly.FullName, "DevExpress.XtraLayout.Demos.Modules.MultilanguageFormLoader"), MultilanguageFormLoader)
			l.Load(localizationModeRadioGroup.SelectedIndex, layoutModeRadioGroup.SelectedIndex, sizeModeRadioGroup.SelectedIndex, dpiModeRadioGroup.SelectedIndex)
		End Sub
	End Class
End Namespace
