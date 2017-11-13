Imports System.Collections
Imports System.ComponentModel
' <icbShowDropDown>
' <popupContainerEditSample>
Imports DevExpress.XtraEditors.Controls
' </popupContainerEditSample>
' </icbShowDropDown>
Imports DevExpress.XtraEditors
Imports System.Globalization
Imports DevExpress.Tutorials


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModulePopupContainerEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			Me.splitContainerControl1.Panel1.DockPadding.All = 4
			Me.splitContainerControl1.Panel2.DockPadding.All = 4
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModulePopupContainerEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "popupcontaineredit.xml"
		End Sub

		Private updateValues As Boolean = False

		' <popupContainerEditSample>
		Private Property CurrentFont() As Font
			Get
				Return lbSample.Font
			End Get
			Set(ByVal value As Font)
				lbSample.Font = value
			End Set
		End Property
		' </popupContainerEditSample>

		Private ReadOnly Property CurrentFontCaption() As String
			Get
				Return String.Format("{0}, {1}, {2}", CurrentFont.Name, CurrentFont.Size.ToString(CultureInfo.InvariantCulture), CurrentFont.Style)
			End Get
		End Property

		' <popupContainerEditSample>
		Private ReadOnly Property CurrentFontStyle() As String
			Get
				Return CurrentFont.Style.ToString()
			End Get
		End Property
		' </popupContainerEditSample>

		Private Sub ModulePopupContainerEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(popupContainerEditSample)
			DevExpress.Tutorials.TutorialHelper.InitFont(ilbFont)
			SetFontCaption()
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			' <icbShowDropDown>
			icbShowDropDown.Properties.Items.AddEnum(GetType(ShowDropDown))
			' </icbShowDropDown>
		End Sub


		Private Sub InitValues()
			updateValues = True
			ceCloseOnOuterMouseClick.Checked = popupContainerEditSample.Properties.CloseOnOuterMouseClick
			icbShowDropDown.EditValue = popupContainerEditSample.Properties.ShowDropDown
			cePopupSizeable.Checked = popupContainerEditSample.Properties.PopupSizeable
			ceShowPopupCloseButton.Checked = popupContainerEditSample.Properties.ShowPopupCloseButton
			ceShowPopupShadow.Checked = popupContainerEditSample.Properties.ShowPopupShadow
			updateValues = False
		End Sub

		Private Sub SetFontCaption()
			popupContainerEditSample.EditValue = CurrentFontCaption
		End Sub

		' <popupContainerEditSample>
		Private Sub popupContainerEditSample_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles popupContainerEditSample.QueryPopUp
			ilbFont.SelectedValue = CurrentFont.Name
			seSize.Value = Convert.ToDecimal(CurrentFont.Size)
			For Each item As CheckedListBoxItem In clbStyle.Items
				item.CheckState = If(CurrentFontStyle.IndexOf(item.Value.ToString()) > -1, CheckState.Checked, CheckState.Unchecked)
			Next item
		End Sub
		' </popupContainerEditSample>

		' <popupContainerEditSample>
		Private Function GetFontStyleByValues(ByVal clb As CheckedListBoxControl) As FontStyle
			Dim ret As New FontStyle()
			If clb.GetItemChecked(0) Then
				ret = ret Or FontStyle.Bold
			End If
			If clb.GetItemChecked(1) Then
				ret = ret Or FontStyle.Italic
			End If
			If clb.GetItemChecked(2) Then
				ret = ret Or FontStyle.Strikeout
			End If
			If clb.GetItemChecked(3) Then
				ret = ret Or FontStyle.Underline
			End If
			Return ret
		End Function

		Private Sub popupContainerEditSample_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles popupContainerEditSample.QueryResultValue
			CurrentFont = New Font(ilbFont.SelectedValue.ToString(), Convert.ToSingle(seSize.Value), GetFontStyleByValues(clbStyle))
			e.Value = CurrentFontCaption
		End Sub
		' </popupContainerEditSample>

		Private Sub ClosePopup()
			If popupContainerControlSample.OwnerEdit IsNot Nothing Then
				popupContainerControlSample.OwnerEdit.ClosePopup()
			End If
		End Sub

		Private Sub ilbFont_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ilbFont.DoubleClick
			ClosePopup()
		End Sub

		Private Sub popupFont_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ilbFont.KeyDown, clbStyle.KeyDown, seSize.KeyDown
			If e.KeyCode = Keys.Enter Then
				popupContainerControlSample.FindForm().Validate()
				ClosePopup()
			End If
		End Sub

		' <ceCloseOnOuterMouseClick>
		Private Sub ceCloseOnOuterMouseClick_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCloseOnOuterMouseClick.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			popupContainerEditSample.Properties.CloseOnOuterMouseClick = ceCloseOnOuterMouseClick.Checked
		End Sub
		' </ceCloseOnOuterMouseClick>

		' <icbShowDropDown>
		Private Sub icbShowDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbShowDropDown.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			popupContainerEditSample.Properties.ShowDropDown = CType(icbShowDropDown.EditValue, ShowDropDown)
		End Sub
		' </icbShowDropDown>

		' <cePopupSizeable>
		Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			popupContainerEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
		End Sub
		' </cePopupSizeable>

		' <ceShowPopupCloseButton>
		Private Sub ceShowPopupCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPopupCloseButton.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			popupContainerEditSample.Properties.ShowPopupCloseButton = ceShowPopupCloseButton.Checked
		End Sub
		' </ceShowPopupCloseButton>

		' <ceShowPopupShadow>
		Private Sub ceShowPopupShadow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPopupShadow.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			popupContainerEditSample.Properties.ShowPopupShadow = ceShowPopupShadow.Checked
		End Sub
		' </ceShowPopupShadow>
	End Class
End Namespace

