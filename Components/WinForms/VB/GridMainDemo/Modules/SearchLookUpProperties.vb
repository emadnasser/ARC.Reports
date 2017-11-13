Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
	Partial Public Class SearchLookUpProperties
		Inherits UserControl

		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal lookUp As SearchLookUpEdit)
			Me.New(lookUp, True)
		End Sub
		Public Sub New(ByVal lookUp As SearchLookUpEdit, ByVal showAddNewButton As Boolean)
			InitializeComponent()
			InitComboBoxes()
			InitLookUp(lookUp)
			ceShowAddNewButton.Enabled = showAddNewButton
		End Sub

		Private lookUpProperties As RepositoryItemSearchLookUpEdit
		Private updateValues As Boolean = False
		Public Sub InitLookUp(ByVal lookUp As SearchLookUpEdit)
			If lookUp Is Nothing Then
				Return
			End If
			Me.lookUpProperties = lookUp.Properties
			updateValues = True
			lbDisplay.Text = lookUpProperties.DisplayMember
			lbValue.Text = lookUpProperties.ValueMember
			icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle
			icbFilterMode.EditValue = lookUpProperties.PopupFilterMode
			icbFindMode.EditValue = lookUpProperties.PopupFindMode
			cePopupSizeable.Checked = lookUpProperties.PopupSizeable
			ceShowPopupFooter.Checked = lookUpProperties.ShowFooter
			ceShowAddNewButton.Checked = lookUpProperties.ShowAddNewButton
			ceShowClearButton.Checked = lookUpProperties.ShowClearButton
			ceShowAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow
			ceShowColumnHeaders.Checked = View.OptionsView.ShowColumnHeaders
			ceShowIndicator.Checked = View.OptionsView.ShowIndicator
			ceShowHorzLines.Checked = View.OptionsView.ShowHorizontalLines <> DevExpress.Utils.DefaultBoolean.False
			ceShowVerticalLines.Checked = View.OptionsView.ShowVerticalLines <> DevExpress.Utils.DefaultBoolean.False
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
                If style <> TextEditStyles.Standard Then
                    icbTextEditStyle.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of TextEditStyles).GetTitle(style), style, -1))
                End If
			Next style
			For Each mode As PopupFilterMode In System.Enum.GetValues(GetType(PopupFilterMode))
				icbFilterMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of PopupFilterMode).GetTitle(mode), mode, -1))
			Next mode
			For Each mode As FindMode In System.Enum.GetValues(GetType(FindMode))
				icbFindMode.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of FindMode).GetTitle(mode), mode, -1))
			Next mode
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

		'<ceShowAddNewButton>
		Private Sub ceShowAddNewButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowAddNewButton.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.ShowAddNewButton = ceShowAddNewButton.Checked
		End Sub
		'</ceShowAddNewButton>

		'<ceShowClearButton>
		Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowClearButton.CheckedChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.ShowClearButton = ceShowClearButton.Checked
		End Sub
		'</ceShowClearButton>

		'<icbFilterMode>
		Private Sub icbFilterMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFilterMode.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.PopupFilterMode = CType(icbFilterMode.EditValue, PopupFilterMode)
		End Sub
		'</icbFilterMode>

		'<icbFindMode>
		Private Sub icbFindMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbFindMode.SelectedIndexChanged
			If updateValues Then
				Return
			End If
			lookUpProperties.PopupFindMode = CType(icbFindMode.EditValue, FindMode)
		End Sub
		'</icbFindMode>

	End Class
End Namespace
