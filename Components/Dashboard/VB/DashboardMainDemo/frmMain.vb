Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DashboardWin
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.Utils

Namespace DashboardMainDemo
	Partial Public Class frmMain
		Inherits RibbonMainForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides ReadOnly Property IsAllowAboutModule() As Boolean
			Get
				Return False
			End Get
		End Property
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return String.Format("Dashboard Features Demo ({0} code)", DemoHelper.GetLanguageString(GetType(frmMain).Assembly))
			End Get
		End Property
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
			DemosInfo.Show(name, group, caption, RibbonMenuManager)
		End Sub
		Protected Overrides Sub SetFormParam()
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DashboardMainDemo.AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Sub ShowAbout()
			DashboardDesigner.About()
		End Sub
	End Class
End Namespace
