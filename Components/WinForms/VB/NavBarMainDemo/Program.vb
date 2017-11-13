Imports DevExpress.Skins
Imports System.Globalization
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraNavBar.Demos
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main(ByVal arguments() As String)
			DevExpress.Utils.LocalizationHelper.SetCurrentCulture(arguments)
			Dim demoCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
			demoCI.NumberFormat.CurrencySymbol = "$"
			demoCI.NumberFormat.CurrencyDecimalDigits = 2
			Application.CurrentCulture = demoCI

            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New frmMain(arguments))
		End Sub
	End Class

	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Overloads Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As RibbonMenuManager)
			Dim item As ModuleInfo = ModulesInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim oldTutorial As Control = Nothing
				If Instance.CurrentModuleBase IsNot Nothing Then
					If Instance.CurrentModuleBase.Name = name Then
						Return
					End If
					oldTutorial = Instance.CurrentModuleBase.TModule
				End If

				Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
				tutorial.Bounds = group.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill
				tutorial.RibbonMenuManager = manager
				tutorial.TutorialName = name
				tutorial.Caption = caption

				tutorial.Visible = True
				item.WasShown = True
				If oldTutorial IsNot Nothing Then
					oldTutorial.Visible = False
				End If
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
		End Sub
	End Class
End Namespace
