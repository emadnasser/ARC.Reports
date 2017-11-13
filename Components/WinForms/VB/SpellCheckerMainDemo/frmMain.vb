Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			MyBase.New()
		End Sub

		#Region "Properties"
		Protected Overrides ReadOnly Property DemoName() As String
			Get
                Return "XtraSpellChecker Features Demo (VB code)"
			End Get
		End Property
		#End Region

		Protected Overrides Sub SetFormParam()
			Me.MinimumSize = New System.Drawing.Size(600, 500)
            'Me.accordionControl1.Parent.Width = 176
            Me.Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New SpellCheckerRibbonMenuManager(Me)
		End Function
		Protected Overrides Overloads Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.ShowModule(name, group, caption, TryCast(RibbonMenuManager, SpellCheckerRibbonMenuManager))
		End Sub
		Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText, True, NavBarImage.Small)
		End Sub
		Protected Overrides Sub ShowAbout()
            SpellChecker.About()
        End Sub
	End Class
End Namespace
