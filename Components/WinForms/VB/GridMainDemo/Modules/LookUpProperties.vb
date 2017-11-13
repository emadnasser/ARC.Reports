Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class LookUpProperties
		Inherits UserControl

		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal lookUp As GridLookUpEdit)
			InitializeComponent()
			InitComboBoxes()
			InitLookUp(lookUp)
		End Sub

		Private lookUpProperties As RepositoryItemGridLookUpEdit
		Private updateValues As Boolean = False
		Public Sub InitLookUp(ByVal lookUp As GridLookUpEdit)
			If lookUp Is Nothing Then
				Return
			End If
			Me.lookUpProperties = lookUp.Properties
			updateValues = True
			lbDisplay.Text = lookUpProperties.DisplayMember
			lbValue.Text = lookUpProperties.ValueMember
			icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
			ceAutoComplete.Checked = lookUpProperties.AutoComplete
			ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup
			cePopupSizeable.Checked = lookUpProperties.PopupSizeable
			ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
			ceShowAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow
			ceShowColumnHeaders.Checked = View.OptionsView.ShowColumnHeaders
			ceShowIndicator.Checked = View.OptionsView.ShowIndicator
			ceShowHorzLines.Checked = View.OptionsView.ShowHorizontalLines <> DefaultBoolean.False
			ceShowVerticalLines.Checked = View.OptionsView.ShowVerticalLines <> DefaultBoolean.False
			ceEnableAppearanceEvenRow.Checked = View.OptionsView.EnableAppearanceEvenRow
			ceEnableAppearanceOddRow.Checked = View.OptionsView.EnableAppearanceOddRow
			EnableProperties()
			updateValues = False
		End Sub
		Private ReadOnly Property View() As GridView
			Get
				Dim view_Renamed As GridView = TryCast(lookUpProperties.View, GridView)
				Return view_Renamed
			End Get
		End Property
		Private Sub InitComboBoxes()
			For Each style As TextEditStyles In System.Enum.GetValues(GetType(TextEditStyles))
				icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
			Next style
		End Sub
		Private Sub EnableProperties()
			cePopupSizeable.Enabled = lookUpProperties.ShowFooter
		End Sub

		Private Sub LookUpProperties_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		End Sub

		'<icbTextEditStyle>
		Private Sub icbTextEditStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTextEditStyle.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.TextEditStyle = CType(icbTextEditStyle.EditValue, TextEditStyles)
		End Sub
		'</icbTextEditStyle>

		'<ceImmediatePopup>
		Private Sub ceImmediatePopup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceImmediatePopup.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked
		End Sub
		'</ceImmediatePopup>

		'<cePopupSizeable>
		Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.PopupSizeable = cePopupSizeable.Checked
		End Sub
		'</cePopupSizeable>

		'<ceShowPopupFooter>
		Private Sub ceShowPopupFooter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPopupFooter.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.ShowFooter = ceShowPopupFooter.Checked
			EnableProperties()
		End Sub
		'</ceShowPopupFooter>

		'<ceShowAutoFilterRow>
		Private Sub ceShowAutoFilterRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowAutoFilterRow.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked
		End Sub
		'</ceShowAutoFilterRow>

		'<ceShowColumnHeaders>
		Private Sub ceShowColumnHeaders_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowColumnHeaders.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked
		End Sub
		'</ceShowColumnHeaders>

		'<ceShowIndicator>
		Private Sub ceShowIndicator_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowIndicator.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.ShowIndicator = ceShowIndicator.Checked
		End Sub
		'</ceShowIndicator>

		'<ceShowHorzLines>
		Private Sub ceShowHorzLines_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowHorzLines.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.ShowHorizontalLines = If(ceShowHorzLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
		End Sub
		'</ceShowHorzLines>

		'<ceShowVerticalLines>
		Private Sub ceShowVerticalLines_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowVerticalLines.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.ShowVerticalLines = If(ceShowVerticalLines.Checked, DefaultBoolean.True, DefaultBoolean.False)
		End Sub
		'</ceShowVerticalLines>

		'<ceEnableAppearanceEvenRow>
		Private Sub ceEnableAppearanceEvenRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEnableAppearanceEvenRow.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked
		End Sub
		'</ceEnableAppearanceEvenRow>

		'<ceEnableAppearanceOddRow>
		Private Sub ceEnableAppearanceOddRow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEnableAppearanceOddRow.CheckedChanged
			If updateValues Then
				Return
			End If
			View.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked
		End Sub
		'</ceEnableAppearanceOddRow>

		'<ceAutoComplete>
		Private Sub ceAutoComplete_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAutoComplete.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.AutoComplete = ceAutoComplete.Checked
		End Sub
		'</ceAutoComplete>

	End Class
End Namespace
