Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames

Namespace DevExpress.XtraTreeMap.Demos
	Public Class frmMain
		Inherits RibbonMainForm
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "XtraTreeMap Features Demo (C# code)"
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "XtraTreeMap"
			End Get
		End Property

		Protected Overrides Sub ShowAbout()
			TreeMapControl.About()
		End Sub
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraTreeMap.Demos.AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
			DemosInfo.DoShowModule(name, group, caption, RibbonMenuManager)
		End Sub
	End Class
End Namespace
