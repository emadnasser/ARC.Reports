Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports DevExpress.Snap
Imports DevExpress.Utils.About

Namespace SnapDemos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "Snap Features Demo (" & DemoHelper.GetLanguageString(GetType(frmMain).Assembly) & " code)"
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "SnapForWin"
			End Get
		End Property
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.Show(name, group, caption, RibbonMenuManager)
		End Sub
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResourcesEx("SnapDemos.AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Sub ShowAbout()
			SnapControl.About()
		End Sub
		Protected Overrides ReadOnly Property IsAllowAboutModule() As Boolean
			Get
				Return False
			End Get
		End Property
	End Class
End Namespace
