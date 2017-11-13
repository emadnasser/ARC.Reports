Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web
Imports System.Drawing

Partial Public Class Docking_ServerSide
	Inherits Page
	Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		If IsPostBack Then
			ApplyPanelPropeties()
		End If
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			PreparePanels()
			PrepareZones()
			InitializePropertiesEditors()
		End If
	End Sub

	Protected Sub cbDockPanels_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
		InitializePropertiesEditors()
	End Sub

	Protected Sub ApplyPanelPropeties()
		Dim dockPanel As ASPxDockPanel = GetCurrentDockPanel()
		If dockPanel Is Nothing Then
			Return
		End If

		dockPanel.Visible = cbPanelVisibility.Checked
		dockPanel.ShowCloseButton = cbShowCloseButton.Checked
		dockPanel.ShowShadow = cbShowShadow.Checked
		dockPanel.ShowHeader = cbShowHeader.Checked
		dockPanel.ShowFooter = cbShowFooter.Checked
		dockPanel.AllowResize = cbAllowResize.Checked
		dockPanel.ShowSizeGrip = CType(System.Enum.Parse(GetType(ShowSizeGrip), ddlShowSizeGrip.Value.ToString()), ShowSizeGrip)
		dockPanel.AllowedDockState = CType(System.Enum.Parse(GetType(AllowedDockState), ddlAllowedDockState.Value.ToString()), AllowedDockState)
	End Sub

	Protected Sub InitializePropertiesEditors()
		Dim dockPanel As ASPxDockPanel = GetCurrentDockPanel()
		If dockPanel Is Nothing Then
			Return
		End If

		cbPanelVisibility.Value = dockPanel.Visible
		seVisibleIndex.Value = dockPanel.VisibleIndex
		cbShowCloseButton.Value = dockPanel.ShowCloseButton
		cbShowShadow.Value = dockPanel.ShowShadow
		cbShowHeader.Value = dockPanel.ShowHeader
		cbShowFooter.Value = dockPanel.ShowFooter
		cbAllowResize.Value = dockPanel.AllowResize
		ddlShowSizeGrip.Value = dockPanel.ShowSizeGrip
		ddlAllowedDockState.Value = dockPanel.AllowedDockState
		If dockPanel.OwnerZone IsNot Nothing Then
			cbZones.SelectedItem = cbZones.Items.FindByValue(dockPanel.OwnerZoneUID)
		Else
			cbZones.SelectedItem = cbZones.Items.FindByValue("none")
		End If
	End Sub

	Protected Sub cbZones_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		If cbZones.SelectedIndex < 0 Then
			Return
		End If

		Dim panel As ASPxDockPanel = GetCurrentDockPanel()
		Dim zone As ASPxDockZone = GetCurrentDockZone()

		panel.OwnerZoneUID = If(zone IsNot Nothing, zone.ZoneUID, Nothing)
	End Sub

	Protected Sub dockManager_AfterDock(ByVal sender As Object, ByVal e As DockManagerEventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Manager")
	End Sub

	Protected Sub dockManager_BeforeDock(ByVal sender As Object, ByVal e As DockManagerCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Manager")
	End Sub

	Protected Sub dockManager_AfterFloat(ByVal sender As Object, ByVal e As DockManagerEventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterFloat for Manager")
		InitializePropertiesEditors()
	End Sub

	Protected Sub dockManager_BeforeFloat(ByVal sender As Object, ByVal e As DockManagerCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeFloat for Manager")
	End Sub

	Protected Sub panel1_AfterDock(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Panels")
	End Sub

	Protected Sub panel1_BeforeDock(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels")
	End Sub

	Protected Sub panel1_AfterFloat(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels")
	End Sub

	Protected Sub panel1_BeforeFloat(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels")
	End Sub

	Protected Sub panel2_AfterDock(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Panels")
	End Sub

	Protected Sub panel2_BeforeDock(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels")
	End Sub

	Protected Sub panel2_AfterFloat(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels")
	End Sub

	Protected Sub panel2_BeforeFloat(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels")
	End Sub

	Protected Sub panel3_AfterDock(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Panels")
	End Sub

	Protected Sub panel3_BeforeDock(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels")
	End Sub

	Protected Sub panel3_AfterFloat(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels")
	End Sub

	Protected Sub panel3_BeforeFloat(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels")
	End Sub

	Protected Sub panel4_AfterDock(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Panels")
	End Sub

	Protected Sub panel4_BeforeDock(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels")
	End Sub

	Protected Sub panel4_AfterFloat(ByVal sender As Object, ByVal e As EventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels")
	End Sub

	Protected Sub panel4_BeforeFloat(ByVal sender As Object, ByVal e As DockPanelCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels")
	End Sub

	Protected Sub dockZone1_AfterDock(ByVal sender As Object, ByVal e As DockZoneEventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Zones")
		InitializePropertiesEditors()
	End Sub

	Protected Sub dockZone1_BeforeDock(ByVal sender As Object, ByVal e As DockZoneCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Zones")
		InitializePropertiesEditors()
	End Sub

	Protected Sub dockZone2_AfterDock(ByVal sender As Object, ByVal e As DockZoneEventArgs)
		EventMonitor.TraceEvent(sender, e, "AfterDock for Zones")
		InitializePropertiesEditors()
	End Sub

	Protected Sub dockZone2_BeforeDock(ByVal sender As Object, ByVal e As DockZoneCancelEventArgs)
		EventMonitor.TraceEvent(sender, e, "BeforeDock for Zones")
		InitializePropertiesEditors()
	End Sub

	Protected Function GetCurrentDockPanel() As ASPxDockPanel
		If cbDockPanels.SelectedIndex < 0 Then
			Return Nothing
		End If

		Return dockManager.FindPanelByUID(cbDockPanels.SelectedItem.Value.ToString())
	End Function

	Protected Function GetCurrentDockZone() As ASPxDockZone
		If cbZones.SelectedIndex < 0 Then
			Return Nothing
		End If

		Return dockManager.FindZoneByUID(cbZones.SelectedItem.Value.ToString())
	End Function

	Protected Sub PreparePanels()
		For Each panel As ASPxDockPanel In dockManager.Panels
			panel.EnableHierarchyRecreation = True
			panel.ShowCloseButton = False
			panel.ShowFooter = True
			panel.Width = 250
			panel.Height = 190
			panel.Styles.Content.Paddings.Padding = 0
			panel.Styles.Content.Paddings.PaddingTop = 5
			panel.Styles.Content.Paddings.PaddingBottom = 5
			panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center
			panel.Styles.Content.BackColor = Color.White
		Next panel
	End Sub

	Protected Sub PrepareZones()
		For Each zone As ASPxDockZone In dockManager.Zones
			zone.PanelSpacing = 11
			zone.Width = 250
			zone.Height = 385
		Next zone
	End Sub

	Protected Sub seVisibleIndex_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
		Dim dockPanel As ASPxDockPanel = GetCurrentDockPanel()
		If dockPanel IsNot Nothing Then
			dockPanel.VisibleIndex = CInt(Fix(seVisibleIndex.Number))
		End If
	End Sub
End Class
