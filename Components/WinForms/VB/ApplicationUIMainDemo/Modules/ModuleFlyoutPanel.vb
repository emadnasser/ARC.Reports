Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ModuleFlyoutPanel
		Inherits TutorialControl
		Private options_Renamed As FlyoutModuleOptions
		Public Sub New()
			Me.options_Renamed = New FlyoutModuleOptions()
			InitializeComponent()
			TutorialInfo.TutorialName = "FlyoutPanel Tutorial"
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitControls()
			UpdateControls()
		End Sub
		Protected Overrides Sub DoHide()
            MyBase.DoHide()
            HideToolWindowCore()
        End Sub
		Private Sub InitControls()
			For Each anchorType As PopupToolWindowAnchor In System.Enum.GetValues(GetType(PopupToolWindowAnchor))
				cbAnchorTypes.Properties.Items.Add(anchorType)
			Next anchorType
			cbAnchorTypes.EditValue = Options.Anchor
			For Each animationType As PopupToolWindowAnimation In System.Enum.GetValues(GetType(PopupToolWindowAnimation))
				cbAnimationTypes.Properties.Items.Add(animationType)
			Next animationType
			cbAnimationTypes.EditValue = Options.AnimationType
			ceCloseOnOuterClick.Checked = Options.CloseOnOuterClick
			spinEditXCoord.Value = Options.XCoord
			spinEditYCoord.Value = Options.YCoord
		End Sub
		'<cbAnchorTypes>
		Private Sub OnAnchorTypeSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnchorTypes.SelectedValueChanged
			Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Options.Anchor = CType(edit.EditValue, PopupToolWindowAnchor)
			If Options.Anchor = PopupToolWindowAnchor.Center OrElse Options.Anchor = PopupToolWindowAnchor.Manual Then
				cbAnimationTypes.EditValue = PopupToolWindowAnimation.Fade
			End If
			UpdateControls()
		End Sub
		'</cbAnchorTypes>
		'<cbAnimationTypes>
		Private Sub OnAnimationTypesSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAnimationTypes.SelectedValueChanged
			Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Options.AnimationType = CType(edit.EditValue, PopupToolWindowAnimation)
		End Sub
		'</cbAnimationTypes>
		'<ceCloseOnOuterClick>
		Private Sub OnCloseOnOuterClickCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceCloseOnOuterClick.CheckedChanged
			Dim edit As CheckEdit = CType(sender, CheckEdit)
			Options.CloseOnOuterClick = edit.Checked
			If panelCore IsNot Nothing Then
				panelCore.Options.CloseOnOuterClick = Options.CloseOnOuterClick
			End If
		End Sub
		'</ceCloseOnOuterClick>
		'<spinEditXCoord>
		Private Sub OnCoordEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditXCoord.EditValueChanged
			Dim edit As SpinEdit = CType(sender, SpinEdit)
			Options.XCoord = CInt(Fix(edit.Value))
		End Sub
		'</spinEditXCoord>
		'<spinEditYCoord>
		Private Sub OnYCoordEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEditYCoord.EditValueChanged
			Dim edit As SpinEdit = CType(sender, SpinEdit)
			Options.YCoord = CInt(Fix(edit.Value))
		End Sub
		'</spinEditYCoord>
		'<horzFlyoutPanel>
		Private Sub OnFlyoutPanelHidden(ByVal sender As Object, ByVal e As FlyoutPanelEventArgs) Handles horzFlyoutPanel.Hidden, vertFlyoutPanel.Hidden
			Dim panel As FlyoutPanel = CType(sender, FlyoutPanel)
			If panelCore Is Nothing OrElse (Not Object.ReferenceEquals(panel, panelCore)) Then
				Return
			End If
			panelCore = Nothing
			UpdateControls()
		End Sub
		'</horzFlyoutPanel>
		'<btnShowToolWindow>
		Private Sub OnShowToolWindowClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowToolWindow.Click
			ShowToolWindowCore()
		End Sub
		'</btnShowToolWindow>
		'<btnHideToolWindow>
		Private Sub OnHideToolWindowClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHideToolWindow.Click
			HideToolWindowCore()
		End Sub
		'</btnHideToolWindow>
		Private panelCore As FlyoutPanel = Nothing
		Private Sub ShowToolWindowCore()
			Dim panel As FlyoutPanel = SelectPanel()
			panel.Options.AnchorType = options_Renamed.Anchor
			panel.Options.AnimationType = options_Renamed.AnimationType
			panel.Options.CloseOnOuterClick = options_Renamed.CloseOnOuterClick
			panel.Options.Location = Options.ManualPoint
			panel.ShowPopup()
			panelCore = panel
			UpdateControls()
		End Sub
		Private Sub HideToolWindowCore()
			If panelCore Is Nothing Then
				Return
			End If
			panelCore.HidePopup()
			panelCore = Nothing
			UpdateControls()
		End Sub
		Private Function SelectPanel() As FlyoutPanel
			If Options.Anchor = PopupToolWindowAnchor.Left OrElse Options.Anchor = PopupToolWindowAnchor.Right Then
				Return vertFlyoutPanel
			End If
			Return horzFlyoutPanel
		End Function
		Private Sub UpdateControls()
			btnShowToolWindow.Enabled = (panelCore Is Nothing)
			btnHideToolWindow.Enabled = Not btnShowToolWindow.Enabled
			lblYCoord.Enabled = (Options.Anchor = PopupToolWindowAnchor.Manual)
			lblXCoord.Enabled = lblYCoord.Enabled
			spinEditYCoord.Enabled = lblXCoord.Enabled
			spinEditXCoord.Enabled = spinEditYCoord.Enabled
		End Sub
		Public ReadOnly Property Options() As FlyoutModuleOptions
			Get
				Return options_Renamed
			End Get
		End Property
	End Class

	Public Class FlyoutModuleOptions
		Public Sub New()
			Me.Anchor = PopupToolWindowAnchor.Top
			Me.AnimationType = PopupToolWindowAnimation.Slide
			Me.CloseOnOuterClick = False
			Me.YCoord = 0
			Me.XCoord = Me.YCoord
		End Sub
		Private privateAnchor As PopupToolWindowAnchor
		Public Property Anchor() As PopupToolWindowAnchor
			Get
				Return privateAnchor
			End Get
			Set(ByVal value As PopupToolWindowAnchor)
				privateAnchor = value
			End Set
		End Property
		Private privateAnimationType As PopupToolWindowAnimation
		Public Property AnimationType() As PopupToolWindowAnimation
			Get
				Return privateAnimationType
			End Get
			Set(ByVal value As PopupToolWindowAnimation)
				privateAnimationType = value
			End Set
		End Property
		Private privateCloseOnOuterClick As Boolean
		Public Property CloseOnOuterClick() As Boolean
			Get
				Return privateCloseOnOuterClick
			End Get
			Set(ByVal value As Boolean)
				privateCloseOnOuterClick = value
			End Set
		End Property
		Private privateXCoord As Integer
		Public Property XCoord() As Integer
			Get
				Return privateXCoord
			End Get
			Set(ByVal value As Integer)
				privateXCoord = value
			End Set
		End Property
		Private privateYCoord As Integer
		Public Property YCoord() As Integer
			Get
				Return privateYCoord
			End Get
			Set(ByVal value As Integer)
				privateYCoord = value
			End Set
		End Property
		Public ReadOnly Property ManualPoint() As Point
			Get
				Return New Point(XCoord, YCoord)
			End Get
		End Property
	End Class
End Namespace
