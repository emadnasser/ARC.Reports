Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
' <icbHeaderClickMode>
' <icbSearchMode>
Imports DevExpress.XtraEditors.Controls
' </icbSearchMode>
' </icbHeaderClickMode>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class LookUpProperties
		Inherits UserControl

		Public Sub New(ByVal lookUp As LookUpEdit)
			InitializeComponent()
			InitComboBoxes()
			InitLookUp(lookUp)
		End Sub

		Private lookUpProperties As RepositoryItemLookUpEdit
		Private updateValues As Boolean = False

		Public Sub InitLookUp(ByVal lookUp As LookUpEdit)
			Me.lookUpProperties = lookUp.Properties
			updateValues = True
			seColumnIndex.Properties.MaxValue = lookUpProperties.Columns.Count - 1
			seColumnIndex.Enabled = seColumnIndex.Properties.MaxValue > 0
			lbDisplay.Text = lookUpProperties.DisplayMember
			lbValue.Text = lookUpProperties.ValueMember
			seColumnIndex.Value = lookUpProperties.AutoSearchColumnIndex
			icbSearchMode.EditValue = lookUpProperties.SearchMode
			icbHeaderClickMode.EditValue = lookUpProperties.HeaderClickMode
			ceCaseSensitiveSearch.Checked = lookUpProperties.CaseSensitiveSearch
			seItemHeight.Value = lookUpProperties.DropDownItemHeight
			teNullText.Text = lookUpProperties.NullText
			ceHotTrack.Checked = lookUpProperties.HotTrackItems
			ceShowFooter.Checked = lookUpProperties.ShowFooter
			ceShowHeader.Checked = lookUpProperties.ShowHeader
			ceShowLines.Checked = lookUpProperties.ShowLines
			updateValues = False
		End Sub
		Private Sub InitComboBoxes()
			' <icbHeaderClickMode>
			icbHeaderClickMode.Properties.Items.AddEnum(GetType(HeaderClickMode))
			' </icbHeaderClickMode>
			' <icbSearchMode>
			icbSearchMode.Properties.Items.AddEnum(GetType(SearchMode))
			' </icbSearchMode>
		End Sub

		Private Sub LookUpProperties_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		End Sub

		' <seColumnIndex>
		Private Sub seColumnIndex_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seColumnIndex.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.AutoSearchColumnIndex = Convert.ToInt32(seColumnIndex.Value)
		End Sub
		' </seColumnIndex>

		' <icbHeaderClickMode>
		Private Sub icbHeaderClickMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbHeaderClickMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.HeaderClickMode = CType(icbHeaderClickMode.EditValue, HeaderClickMode)
		End Sub
		' </icbHeaderClickMode>

		' <icbSearchMode>
		Private Sub icbSearchMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSearchMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.SearchMode = CType(icbSearchMode.EditValue, SearchMode)
		End Sub
		' </icbSearchMode>

		' <ceCaseSensitiveSearch>
		Private Sub ceCaseSensitiveSearch_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCaseSensitiveSearch.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.CaseSensitiveSearch = ceCaseSensitiveSearch.Checked
		End Sub
		' </ceCaseSensitiveSearch>

		' <seItemHeight>
		Private Sub seItemHeight_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seItemHeight.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value)
		End Sub
		' </seItemHeight>

		' <teNullText>
		Private Sub teNullText_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teNullText.EditValueChanged
			' <skip>
            If updateValues Or lookUpProperties Is Nothing Then
                Return
            End If
			' </skip>
			lookUpProperties.NullText = teNullText.Text
		End Sub
		' </teNullText>

		' <ceHotTrack>
		Private Sub ceHotTrack_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceHotTrack.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.HotTrackItems = ceHotTrack.Checked
		End Sub
		' </ceHotTrack>

		' <ceShowFooter>
		Private Sub ceShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowFooter.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.ShowFooter = ceShowFooter.Checked
		End Sub
		' </ceShowFooter>

		' <ceShowHeader>
		Private Sub ceShowHeader_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowHeader.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.ShowHeader = ceShowHeader.Checked
		End Sub
		' </ceShowHeader>

		' <ceShowLines>
		Private Sub ceShowLines_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowLines.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			lookUpProperties.ShowLines = ceShowLines.Checked
		End Sub
		' </ceShowLines>
	End Class
End Namespace
