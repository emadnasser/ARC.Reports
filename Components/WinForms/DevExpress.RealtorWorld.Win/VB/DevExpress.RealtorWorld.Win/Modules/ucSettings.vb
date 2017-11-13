Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraEditors.ButtonPanel
Imports DevExpress.XtraEditors

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucSettings
		Inherits BaseModule
		Private Shared TimerInterval As Integer = 2300
		Public Sub New()
			InitializeComponent()
			Dim stats As New ucStats()
			Dim research As New ucResearch()
			stats.InitModule(barManager1, Nothing)
			research.InitModule(barManager1, Nothing)
			windowsUIView1.AddDocument(stats)
			windowsUIView1.AddDocument(research)
			pageGroup1.Properties.ShowPageHeaders = Utils.DefaultBoolean.False
			AddHandler windowsUIView1.NavigationBarsShowing, AddressOf onShowingNavigationBars
		End Sub
		Private privateActivationTimer As Timer
		Protected Friend Property ActivationTimer() As Timer
			Get
				Return privateActivationTimer
			End Get
			Set(ByVal value As Timer)
				privateActivationTimer = value
			End Set
		End Property
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ActivationTimer IsNot Nothing Then
				RemoveHandler ActivationTimer.Tick, AddressOf timerTick
				ActivationTimer = Nothing
				RemoveHandler View.ContentContainerActivated, AddressOf OnContentContainerActivated
				RemoveHandler View.ContentContainerDeactivated, AddressOf OnContentContainerDeactivated
			End If
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private privateView As WindowsUIView
		Protected Property View() As WindowsUIView
			Get
				Return privateView
			End Get
			Set(ByVal value As WindowsUIView)
				privateView = value
			End Set
		End Property
		Friend Overrides Sub InitModule(ByVal manager As DevExpress.Utils.Menu.IDXMenuManager, ByVal data As Object)
			MyBase.InitModule(manager, data)
			If TypeOf data Is WindowsUIView Then
				View = CType(data, WindowsUIView)
				For Each button As IBaseButton In animationButtonPanel.Buttons
					button.Properties.Checked = button.Properties.Tag.Equals(View.PageGroupProperties.SwitchDocumentAnimationMode)
					windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = View.PageGroupProperties.SwitchDocumentAnimationMode
				Next button
			End If
			AddHandler View.ContentContainerActivated, AddressOf OnContentContainerActivated
			AddHandler View.ContentContainerDeactivated, AddressOf OnContentContainerDeactivated
			ActivationTimer = New Timer()
			AddHandler ActivationTimer.Tick, AddressOf timerTick
			ActivationTimer.Interval = TimerInterval
			ActivationTimer.Start()
		End Sub
		Private Sub OnContentContainerDeactivated(ByVal sender As Object, ByVal e As ContentContainerEventArgs)
			If TypeOf e.ContentContainer Is Page Then
				ActivationTimer.Stop()
			End If
		End Sub
		Private Sub OnContentContainerActivated(ByVal sender As Object, ByVal e As ContentContainerEventArgs)
			If TypeOf e.ContentContainer Is Page Then
				ActivationTimer.Start()
			End If
		End Sub
		Private Sub timerTick(ByVal sender As Object, ByVal e As EventArgs)
			If document1.IsActive Then
				windowsUIView1.Controller.Activate(document2)
			Else
				windowsUIView1.Controller.Activate(document1)
			End If
		End Sub
		Public Overrides ReadOnly Property ModuleCaption() As String
			Get
				Return "Settings"
			End Get
		End Property
		Private Sub animationButtonChecked(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles animationButtonPanel.ButtonChecked
			If View IsNot Nothing Then
				View.PageGroupProperties.SwitchDocumentAnimationMode = CType(e.Button.Properties.Tag, TransitionAnimation)
			End If
			windowsUIView1.PageGroupProperties.SwitchDocumentAnimationMode = CType(e.Button.Properties.Tag, TransitionAnimation)
		End Sub
		Private Sub onShowingNavigationBars(ByVal sender As Object, ByVal e As NavigationBarsCancelEventArgs)
			e.Cancel = True
		End Sub
	End Class
End Namespace
