Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleTokenEdit
		Inherits TutorialControl
		Private properties As RepositoryItemTokenEdit
		Public Sub New()
            InitializeComponent()
            Me.properties = tokenEdit.Properties
            TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleTokenEdit.vb"
            TutorialInfo.WhatsThisXMLFile = "tokenEdit.xml"
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitValues()
		End Sub
		Private Sub InitValues()
			Me.ceShowDropDown.Checked = Me.properties.ShowDropDown
			Me.seDropDownRowCount.Value = Me.properties.DropDownRowCount
            Me.cbeCheckMode.Properties.Items.AddEnum(GetType(TokenEditCheckMode))
            Me.cbeCheckMode.EditValue = Me.properties.CheckMode
            Me.seMaxExpandLines.Value = Me.properties.MaxExpandLines
            Me.ceShowPopupPanel.Checked = Me.properties.PopupPanelOptions.ShowPopupPanel
            Me.cbePopupPanelLocation.Properties.Items.AddEnum(GetType(TokenEditPopupPanelLocation))
            Me.cbePopupPanelLocation.EditValue = Me.properties.PopupPanelOptions.Location
            Me.cbeDropDownMode.Properties.Items.AddEnum(GetType(TokenEditDropDownShowMode))
            Me.cbeDropDownMode.EditValue = Me.properties.DropDownShowMode
            Me.cbeEditMode.Properties.Items.AddEnum(GetType(TokenEditMode))
            Me.cbeEditMode.EditValue = Me.properties.EditMode
            Me.cbeFontSize.Properties.Items.AddEnum(GetType(TokenEditFontSize))
            Me.cbeFontSize.EditValue = TokenEditFontSize.Default
            Me.ceShowItemRemoveButton.Checked = Me.properties.ShowRemoveTokenButtons
            Me.cePopupSizeable.Checked = Me.properties.PopupSizeable
            Me.cbeGlyphLocation.Properties.Items.AddEnum(GetType(TokenEditGlyphLocation))
            Me.cbeGlyphLocation.EditValue = Me.properties.TokenGlyphLocation
            If Me.cbeEditValueSep.Properties.Items.Count > 0 Then
                Me.cbeEditValueSep.SelectedIndex = 0
            End If
            Me.tokenEdit.EditValue = "January"
        End Sub
        ' <ceShowDropDown>
        Private Sub OnShowDropDownCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowDropDown.CheckedChanged
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            Me.properties.ShowDropDown = checkEdit.Checked
        End Sub
        ' </ceShowDropDown>
        ' <btnClearEventLog>
        Private Sub OnClearEventLogClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearEventLog.Click
            Me.eventsLog.Text = String.Empty
        End Sub
        ' </btnClearEventLog>
        ' <tokenEdit>
        Private Sub OnTokenEditBeforeShowPopupPanel(ByVal sender As Object, ByVal e As TokenEditBeforeShowPopupPanelEventArgs) Handles tokenEdit.Properties.BeforeShowPopupPanel
            AddEventEntry("BeforeShowPopupPanel", e.Description)
            Me.tokenLabelValue.Text = e.Description
        End Sub
        Private Sub OnTokenEditTokenMouseEnter(ByVal sender As Object, ByVal e As TokenEditTokenMouseEnterEventArgs) Handles tokenEdit.Properties.TokenMouseEnter
            AddEventEntry("TokenMouseEnter", e.Description)
        End Sub
        Private Sub OnTokenEditTokenMouseHover(ByVal sender As Object, ByVal e As TokenEditTokenMouseHoverEventArgs) Handles tokenEdit.Properties.TokenMouseHover
            AddEventEntry("TokenMouseHover", e.Description)
        End Sub
        Private Sub OnTokenEditTokenMouseLeave(ByVal sender As Object, ByVal e As TokenEditTokenMouseLeaveEventArgs) Handles tokenEdit.Properties.TokenMouseLeave
            AddEventEntry("TokenMouseLeave", e.Description)
        End Sub
        Private Sub OnTokenEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tokenEdit.EditValueChanged
            If Me.properties Is Nothing Then
                Return
            End If
            Dim tokenEdit As TokenEdit = CType(sender, TokenEdit)
            AddEventEntry("EditValueChanged", tokenEdit.EditValue)
            UpdateEditValue()
        End Sub
        Private Sub OnTokenEditTokenClick(ByVal sender As Object, ByVal e As TokenEditTokenClickEventArgs) Handles tokenEdit.Properties.TokenClick
            Dim tokenEdit As TokenEdit = CType(sender, TokenEdit)
            AddEventEntry("TokenClick", e.Description)
        End Sub
        Private Sub OnTokenEditTokenDoubleClick(ByVal sender As Object, ByVal e As TokenEditTokenClickEventArgs) Handles tokenEdit.Properties.TokenDoubleClick
            Dim tokenEdit As TokenEdit = CType(sender, TokenEdit)
            AddEventEntry("TokenDoubleClick", e.Description)
        End Sub
        Private Sub OnTokenEditCheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tokenEdit.Properties.TokenCheckStateChanged
            Dim tokenEdit As TokenEdit = CType(sender, TokenEdit)
            AddEventEntry("TokenCheckStateChanged", Nothing)
        End Sub
        ' </tokenEdit>
        ' <seDropDownRowCount>
        Private Sub OnDropDownRowCountEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seDropDownRowCount.EditValueChanged
            If Me.properties Is Nothing Then
                Return
            End If
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Me.properties.DropDownRowCount = CInt(Fix(spinEdit.Value))
        End Sub
        ' </seDropDownRowCount>
        ' <cbeCheckMode>
        Private Sub OnCheckModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeCheckMode.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.CheckMode = CType(comboBox.EditValue, TokenEditCheckMode)
        End Sub
        ' </cbeCheckMode>
        ' <seMaxExpandLines>
        Private Sub OnMaxExpandLinesEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seMaxExpandLines.EditValueChanged
            If Me.properties Is Nothing Then
                Return
            End If
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Me.properties.MaxExpandLines = CInt(Fix(spinEdit.Value))
        End Sub
        ' </seMaxExpandLines>
        ' <ceShowPopupPanel>
        Private Sub OnShowPopupPanelCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowPopupPanel.CheckedChanged
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            Me.properties.PopupPanelOptions.ShowPopupPanel = checkEdit.Checked
        End Sub
        ' </ceShowPopupPanel>
        ' <cbePopupPanelLocation>
        Private Sub OnPopupPanelLocationSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbePopupPanelLocation.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.PopupPanelOptions.Location = CType(comboBox.EditValue, TokenEditPopupPanelLocation)
        End Sub
        ' </cbePopupPanelLocation>
        ' <ceShowItemRemoveButton>
        Private Sub OnShowItemRemoveButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowItemRemoveButton.CheckedChanged
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            Me.properties.ShowRemoveTokenButtons = checkEdit.Checked
        End Sub
        ' </ceShowItemRemoveButton>
        ' <cePopupSizeable>
        Private Sub OnPopupSizeableCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cePopupSizeable.CheckedChanged
            Dim checkEdit As CheckEdit = CType(sender, CheckEdit)
            Me.properties.PopupSizeable = checkEdit.Checked
        End Sub
        ' </cePopupSizeable>
        ' <cbeEditValueSep>
        Private Sub OnEditValueSepSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeEditValueSep.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.EditValueSeparatorChar = Char.Parse(comboBox.EditValue.ToString())
        End Sub
        ' </cbeEditValueSep>
        ' <cbeDropDownMode>
        Private Sub OnDropDownModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeDropDownMode.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.DropDownShowMode = CType(comboBox.EditValue, TokenEditDropDownShowMode)
        End Sub
        ' </cbeDropDownMode>
        Private Sub UpdateEditValue()
            Dim value As String = TryCast(tokenEdit.EditValue, String)
            Me.editValueLabel.Text = String.Format("Edit Value: {0}", If(String.IsNullOrEmpty(value), "(empty)", value))
        End Sub
        ' <cbeEditMode>
        Private Sub OnEditModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeEditMode.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.EditMode = CType(comboBox.EditValue, TokenEditMode)
        End Sub
        ' </cbeEditMode>
        ' <cbeFontSize>
        Private Sub OnFontSizeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeFontSize.SelectedIndexChanged
            Dim defaultFont As Font = AppearanceObject.DefaultFont, newFont As Font = Nothing
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Dim fontSize As TokenEditFontSize = CType(comboBox.EditValue, TokenEditFontSize)
            Select Case fontSize
                Case TokenEditFontSize.Default
                    newFont = defaultFont
                Case TokenEditFontSize.Medium
                    newFont = New Font(defaultFont.FontFamily, defaultFont.SizeInPoints + 2.5F)
                Case TokenEditFontSize.Large
                    newFont = New Font(defaultFont.FontFamily, defaultFont.SizeInPoints + 3.75F)
            End Select
            Me.properties.AppearanceDropDown.Font = newFont
            Me.properties.Appearance.Font = Me.properties.AppearanceDropDown.Font
        End Sub
        ' </cbeFontSize>
        ' <cbeGlyphLocation>
        Private Sub OnGlyphAlignmentModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeGlyphLocation.SelectedIndexChanged
            Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Me.properties.TokenGlyphLocation = CType(comboBox.EditValue, TokenEditGlyphLocation)
        End Sub
        ' </cbeGlyphLocation>
        Private Sub AddEventEntry(ByVal entry As String, ByVal obj As Object)
            Dim val As String = String.Empty
            If obj IsNot Nothing Then
                val = If(TypeOf obj Is TokenEdit, GetType(TokenEdit).Name, obj.ToString())
            Else
                val = "(null)"
            End If
            Me.eventsLog.Text = String.Format("{0}: {1}{2}", entry, val, Environment.NewLine) + eventsLog.Text
        End Sub
    End Class

	Friend Enum TokenEditFontSize
		[Default]
		Medium
		Large
	End Enum
End Namespace
