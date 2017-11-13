Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Private showOutdated As Boolean = False
		Public Sub New(ByVal arguments() As String)
			MyBase.New(arguments)
			ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
		End Sub
		Protected Overrides ReadOnly Property DemoName() As String
			Get
                Return "The XtraNavBar Suite Demo (VB code)"
			End Get
		End Property
        Protected Overrides Sub ShowAbout()
            NavBarControl.About()
        End Sub
		Protected Overrides Sub SetFormParam()
			Me.MinimumSize = New Size(800, 600)
            Me.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Overloads Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
			DemosInfo.ShowModule(name, group, caption, RibbonMenuManager)
		End Sub
		Protected Overrides Sub FillNavBar()
            ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated)
		End Sub
	End Class
End Namespace
