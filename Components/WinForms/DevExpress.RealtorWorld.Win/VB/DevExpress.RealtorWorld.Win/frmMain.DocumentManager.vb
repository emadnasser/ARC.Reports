Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.About

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class frmMain
		Inherits XtraForm
		Implements IMainForm
		Public Sub New()
			Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
			Me.Location = System.Windows.Forms.Screen.GetBounds(MousePosition).Location
			InitializeComponent()
			InitTitleImages()
			windowsUIView.ContentContainerActions.Add(New SetSkinAction("Metropolis", "White Theme"))
			windowsUIView.ContentContainerActions.Add(New SetSkinAction("MetroBlack", "Black Theme"))
			InitTiles()
			UAlgo.Default.DoEventObject(UAlgo.kDemo, UAlgo.pWinForms, Me) 'DEMO_REMOVE
		End Sub
		Private Sub InitTitleImages()
			ucDraftTile.Elements(0).Image = My.Resources.UserManagment
			ucSettingsTile.Elements(0).Image = My.Resources.System
			ucResearchTile.Elements(0).Image = My.Resources.Research
			ucStatsTile.Elements(0).Image = My.Resources.Statistics
			ucBrowserTile.Elements(0).Image = My.Resources.Home
			ucBanksTile.Elements(0).Image = My.Resources.Rates
			ucLoanCalculatorTile.Elements(0).Image = My.Resources.Calc
			Me.browserPage.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton("Home", My.Resources.SmallHome, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "Home", -1, False, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", My.Resources.Rotate, -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", True, -1, True, Nothing, True, False, True, Nothing, "Refresh", -1, False, False)})
		End Sub
		Private Sub InitTiles()
			DataHelper.InitListingsTile(ucListingTile)
			DataHelper.InitAgentsTile(ucAgentsTile, AppConst.TileSize)
		End Sub
		Private current As Object
		Private Sub ShowHome(ByVal home As Home) Implements IMainForm.ShowHome
			current = home
			Dim [module] As BaseModule = TryCast(ucListingDocument.Control, BaseModule)
			If [module] IsNot Nothing Then
				[module].ShowModule(home)
			End If
			windowsUIView.Controller.Activate(ucListingDocument)
			current = Nothing
		End Sub
		Private Sub ShowAgent(ByVal agent As Agent) Implements IMainForm.ShowAgent
			current = agent
			Dim [module] As BaseModule = TryCast(ucAgentsDocument.Control, BaseModule)
			If [module] IsNot Nothing Then
				[module].ShowModule(agent)
			End If
			windowsUIView.Controller.Activate(ucAgentsDocument)
			current = Nothing
		End Sub
		Private Sub windowsUIView_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs) Handles windowsUIView.QueryControl
			Dim [module] As BaseModule = If(TypeOf e.Document.Tag Is BaseModule, CType(e.Document.Tag, BaseModule), TryCast(Activator.CreateInstance(GetType(frmMain).Assembly.GetType(e.Document.ControlTypeName)), BaseModule))
			[module].InitModule(barManager1, windowsUIView)
			Dim tile As BaseTile = Nothing
			If windowsUIView.Tiles.TryGetValue(e.Document, tile) Then
				Dim frame As TileItemFrame = tile.CurrentFrame
				Dim data As Object = If(current, (If((frame IsNot Nothing), frame.Tag, Nothing)))
				[module].ShowModule(data)
			End If
			e.Document.Tag = [module]
			e.Control = [module]
		End Sub
		Private Sub windowsUIView_TileClick(ByVal sender As Object, ByVal e As TileClickEventArgs) Handles windowsUIView.TileClick
			Dim tile As Tile = TryCast(e.Tile, Tile)
			If tile IsNot Nothing AndAlso tile.Document IsNot Nothing Then
				Dim [module] As BaseModule = TryCast(tile.Document.Control, BaseModule)
				If [module] IsNot Nothing Then
					Dim frame As TileItemFrame = tile.CurrentFrame
					Dim data As Object = If((frame IsNot Nothing), frame.Tag, Nothing)
					[module].ShowModule(data)
				End If
				If tile.ActivationTarget Is page Then
					page.Document = tile.Document
					If tile.Elements.Count > 0 Then
						page.Caption = tile.Elements(0).Text
					End If
				End If
			End If
		End Sub
		Private Sub browserPage_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles browserPage.ButtonClick
			Dim page As Page = TryCast(sender, Page)
			If page IsNot Nothing Then
				Dim [module] As BaseModule = TryCast(page.Document.Control, BaseModule)
				If [module] IsNot Nothing AndAlso TypeOf [module] Is ucBrowser Then
					If String.Equals("Refresh", e.Button.Properties.Tag) Then
						CType([module], ucBrowser).RefreshBrowser()
					End If
					If String.Equals("Home", e.Button.Properties.Tag) Then
						CType([module], ucBrowser).Navigate()
					End If
				End If
			End If
		End Sub
		Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
			MyBase.OnClosing(e)
			Dim restoreTimerState As Boolean = False
			Dim ucSettingsControl As ucSettings = Nothing
			If page.Document IsNot Nothing AndAlso TypeOf page.Document.Control Is ucSettings Then
				ucSettingsControl = TryCast(page.Document.Control, ucSettings)
				restoreTimerState = ucSettingsControl.ActivationTimer.Enabled
			End If
			Dim closeAction As FlyoutAction = CreateCloseAction()
			flyout.Action = closeAction
			If restoreTimerState Then
				ucSettingsControl.ActivationTimer.Enabled = False
			End If
			If windowsUIView.ShowFlyoutDialog(flyout) <> System.Windows.Forms.DialogResult.Yes Then
				e.Cancel = True
				If restoreTimerState Then
					ucSettingsControl.ActivationTimer.Enabled = True
				End If
			End If
		End Sub
		Private Function CreateCloseAction() As FlyoutAction
			Dim closeAction As New FlyoutAction()
			closeAction.Caption = Text
			closeAction.Description = "Do you really want to close the demo?"
			closeAction.Commands.Add(FlyoutCommand.Yes)
			closeAction.Commands.Add(FlyoutCommand.No)
			Return closeAction
		End Function
	End Class
End Namespace
