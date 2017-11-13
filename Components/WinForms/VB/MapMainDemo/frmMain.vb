Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.Utils.About
Imports System.Windows.Forms
Imports DevExpress.XtraMap.Native

Namespace DevExpress.XtraMap.Demos
	Partial Public Class frmMain
		Inherits DevExpress.DXperience.Demos.RibbonMainForm
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Properties"
		Friend Shadows ReadOnly Property ExportToImageExButton() As BarSubItem
			Get
				Return MyBase.ExportToImageExButton
			End Get
		End Property
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "Map Control Main Demo (C# code)"
			End Get
		End Property
		#End Region

		Protected Overrides Sub WndProc(ByRef msg As Message)
			If OverlapFlickeringSolver.ShouldDoWndProc(msg) Then
				MyBase.WndProc(msg)
			End If
		End Sub
		Protected Overrides Sub ShowAbout()
			MapControl.About()
		End Sub
		Protected Overrides Sub SetFormParam()
			Me.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraMap.Demos.AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "XtraMap"
			End Get
		End Property
		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New MapRibbonMenuManager(Me)
		End Function
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
			DemosInfo.DoShowModule(name, groupControl, caption, TryCast(RibbonMenuManager, MapRibbonMenuManager))
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		End Sub
	End Class
	Public Class MapRibbonMenuManager
		Inherits RibbonMenuManager
		Public Sub New(ByVal form As RibbonMainForm)
			MyBase.New(form)
			'CreatePageSetupMenu(form);
			'CreateReportsMenu(form);
			'EnableReportsMenu();
		End Sub

		'protected internal virtual void CreatePageSetupMenu(RibbonMainForm form) {
		'    bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup", bbiPageSetup_Click);
		'    RibbonControl ribbon = form.Ribbon;
		'    RibbonPageGroup printExportGroup = form.PrintExportGroup;
		'    AddBarItemInRibbon(ribbon, printExportGroup, bbiPageSetup, true);
		'    bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup", bbiLoadPageSetup_Click);
		'    AddBarItemInRibbon(ribbon, printExportGroup, bbiLoadPageSetup);
		'    bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup", bbiSavePageSetup_Click);
		'    AddBarItemInRibbon(ribbon, printExportGroup, bbiSavePageSetup);
		'}
	End Class
End Namespace
