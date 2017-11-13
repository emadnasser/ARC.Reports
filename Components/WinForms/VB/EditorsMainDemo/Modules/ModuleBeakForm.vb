Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports System.Windows.Forms

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleBeakForm
		Inherits TutorialControl
		Private options As BeakPanelOptions
		Private buttonPanelOptions As FlyoutPanelButtonOptions
		Public Sub New()
			InitializeComponent()
			Me.options = Me.flyoutPanel.OptionsBeakPanel
            Me.buttonPanelOptions = Me.flyoutPanel.OptionsButtonPanel
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleBeakForm.vb"
            TutorialInfo.WhatsThisXMLFile = "beakForm.xml"
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitValues()
		End Sub
		Private Sub InitValues()
			Me.backColorEdit.EditValue = Me.options.BackColor
			Me.borderColorEdit.EditValue = Me.options.BorderColor
			Me.ceCloseOnOuterClick.EditValue = Me.options.CloseOnOuterClick
			Me.borderColorEdit.Properties.AutomaticColor = Color.Empty
			Me.backColorEdit.Properties.AutomaticColor = Me.borderColorEdit.Properties.AutomaticColor
			Me.ceShowButtonPanel.EditValue = Me.flyoutPanel.OptionsButtonPanel.ShowButtonPanel
			Me.cbeButtonPanelLocation.Properties.Items.AddEnum(GetType(FlyoutPanelButtonPanelLocation))
			Me.cbeButtonPanelLocation.EditValue = Me.buttonPanelOptions.ButtonPanelLocation
			Me.cbeButtonPanelAlignment.Properties.Items.AddEnum(GetType(ContentAlignment))
			Me.buttonPanelOptions.ButtonPanelContentAlignment = ContentAlignment.TopRight
			Me.cbeButtonPanelAlignment.EditValue = Me.buttonPanelOptions.ButtonPanelContentAlignment
			Me.cbeBeakLocation.Properties.Items.AddEnum(GetType(BeakPanelBeakLocation))
			Me.cbeBeakLocation.EditValue = Me.options.BeakLocation
			UpdateControls()
		End Sub
		' <previewPanel>
		Private Sub OnPreviewPanelMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles previewPanel.MouseEnter
			EnsureShowBeakForm()
		End Sub
		Private Sub EnsureShowBeakForm()
			If flyoutPanel.FlyoutPanelState.IsActive Then
				Return
			End If
			flyoutPanel.ShowBeakForm(GetHotPoint())
		End Sub
        Private Function GetHotPoint() As Point
            Dim pt As New Point(0, Me.previewPanel.Height \ 2)
            Dim editValue As BeakPanelBeakLocation = CType(Me.cbeBeakLocation.EditValue, BeakPanelBeakLocation)
            If editValue = BeakPanelBeakLocation.Right Then
                Return Me.previewPanel.PointToScreen(pt)
            End If
            If editValue = BeakPanelBeakLocation.Left Then
                pt.X += Me.previewPanel.Width
                Return Me.previewPanel.PointToScreen(pt)
            End If
            pt = New Point(Me.previewPanel.Width \ 2, 0)
            If editValue = BeakPanelBeakLocation.Top Then
                pt.Y += Me.previewPanel.Height
            End If
            Return Me.previewPanel.PointToScreen(pt)
        End Function
		' </previewPanel>
		' <backColorEdit>
        Private Sub OnBackEditColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles backColorEdit.ColorChanged
            Dim colorEdit As ColorPickEdit = CType(sender, ColorPickEdit)
            Me.options.BackColor = colorEdit.Color
        End Sub
		' </backColorEdit>
		' <borderColorEdit>
        Private Sub OnBorderColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles borderColorEdit.ColorChanged
            Dim colorEdit As ColorPickEdit = CType(sender, ColorPickEdit)
            Me.options.BorderColor = colorEdit.Color
        End Sub
		' </borderColorEdit>
		' <ceCloseOnOuterClick>
		Private Sub OnCloseOnOuterClickFlagChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceCloseOnOuterClick.CheckedChanged
			Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
			Me.options.CloseOnOuterClick = checkEdit.Checked
		End Sub
		' </ceCloseOnOuterClick>
		' <ceShowButtonPanel>
		Private Sub OnShowButtonPanelFlagChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowButtonPanel.CheckedChanged
			Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
			Me.flyoutPanel.OptionsButtonPanel.ShowButtonPanel = checkEdit.Checked
			UpdateControls()
		End Sub
		' </ceShowButtonPanel>
		' <flyoutPanel>
		Private Sub OnFlyoutPanelButtonClick(ByVal sender As Object, ByVal e As FlyoutPanelButtonClickEventArgs) Handles flyoutPanel.ButtonClick
			Dim tag As String = TryCast(e.Button.Tag, String)
			If String.Equals(tag, "Exit", StringComparison.OrdinalIgnoreCase) Then
				Me.flyoutPanel.HideBeakForm()
			End If
		End Sub
		' </flyoutPanel>
		' <cbeButtonPanelLocation>
		Private Sub OnButtonPanelLocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeButtonPanelLocation.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Me.flyoutPanel.OptionsButtonPanel.ButtonPanelLocation = CType(comboBox.EditValue, FlyoutPanelButtonPanelLocation)
			UpdateControls()
		End Sub
		' </cbeButtonPanelLocation>
		' <cbeButtonPanelAlignment>
		Private Sub OnButtonPanelAlignmentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeButtonPanelAlignment.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Me.buttonPanelOptions.ButtonPanelContentAlignment = CType(comboBox.EditValue, ContentAlignment)
		End Sub
		' </cbeButtonPanelAlignment>
		' <btnAddButton>
		Private Sub OnAddButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddButton.Click
			Me.buttonPanelOptions.Buttons.Insert(0, CreateButton())
			UpdateControls()
		End Sub
		Private Function CreateButton() As ButtonControl
            Dim img As Image = My.Resources.NewButton_16x16
			Return New PeekFormButton(String.Empty, img, False, True, "Custom Button")
		End Function
		' </btnAddButton>
		' <btnRemoveButton>
		Private Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveButton.Click
			Dim buttons = Me.buttonPanelOptions.Buttons
			If buttons.Count <= 1 Then
				Return
			End If
			buttons.RemoveAt(0)
			UpdateControls()
		End Sub
		' </btnRemoveButton>
		Private Sub UpdateFlyoutHintLabelLocation()
			Dim loc As Point = Me.flyoutPanelHintLabel.Location
            loc.Y = CInt((Me.flyoutPanel.Height - Me.flyoutPanelHintLabel.Height) / 2)
			Me.flyoutPanelHintLabel.Location = loc
		End Sub
		' <cbeBeakLocation>
		Private Sub OnBeakLocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeBeakLocation.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Me.options.BeakLocation = CType(comboBox.EditValue, BeakPanelBeakLocation)
		End Sub
		' </cbeBeakLocation>
		Private Sub UpdateControls()
			Me.btnAddButton.Enabled = Me.buttonPanelOptions.Buttons.Count < 6
			Me.btnRemoveButton.Enabled = Me.buttonPanelOptions.Buttons.Count > 1
			UpdateFlyoutHintLabelLocation()
		End Sub
	End Class
End Namespace
