Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Frames
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos
	Partial Public Class frmMain
		Inherits RibbonMainForm
		Friend Shadows ReadOnly Property ExportToImageExButton() As BarSubItem
			Get
				Return MyBase.ExportToImageExButton
			End Get
		End Property
		Protected Overrides ReadOnly Property DemoName() As String
			Get
				Return "XtraCharts Features Demo"
			End Get
		End Property
		Protected Overrides ReadOnly Property ProductName() As String
			Get
				Return "XtraCharts"
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged
		End Sub

		Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			If RibbonMenuManager IsNot Nothing Then
				CType(RibbonMenuManager, ChartRibbonMenuManager).UpdateMenu()
			End If
		End Sub

		Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
			Return New ChartRibbonMenuManager(Me)
		End Function
		Protected Overrides Sub SetFormParam()
			accordionControl1.Parent.Width = 220
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraCharts.Demos.AppIcon.ico", GetType(frmMain).Assembly)
		End Sub
		Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
			Dim currentModule As TutorialControl = DemosInfo.DoShowModule(name, group, caption, TryCast(RibbonMenuManager, ChartRibbonMenuManager))
			If currentModule IsNot Nothing Then
				CType(RibbonMenuManager, ChartRibbonMenuManager).CurrentModule = currentModule
				CType(RibbonMenuManager, ChartRibbonMenuManager).UpdateMenu()
				Dim chartDemoModule As ChartDemoBase = TryCast(currentModule, ChartDemoBase)
				If chartDemoModule IsNot Nothing AndAlso chartDemoModule.ChartControl IsNot Nothing AndAlso chartDemoModule.AnimateChartControlOnDemoAppear Then
					chartDemoModule.ChartControl.Animate()
				End If
			End If
		End Sub
		Protected Overrides Sub ShowAbout()
			ChartControl.About()
		End Sub
	End Class
End Namespace
