Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
' <icbAlignment>
' <icbSelectionMode>
' <icbSortOrder>
Imports DevExpress.XtraEditors.Controls
' </icbSortOrder>
' </icbSelectionMode>
Imports DevExpress.Utils
' </icbAlignment>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ListBoxProperties
		Inherits UserControl

		Private ReadOnly Property CheckedListBox() As CheckedListBoxControl
			Get
				Return TryCast(listBox, CheckedListBoxControl)
			End Get
		End Property
		Private ReadOnly Property ImageListBox() As ImageListBoxControl
			Get
                Return TryCast(listBox, ImageListBoxControl)
			End Get
		End Property
        Private ReadOnly Property ListBoxControl() As ListBoxControl
            Get
                Return TryCast(listBox, ListBoxControl)
            End Get
        End Property
		Public Sub New(ByVal listBox As BaseListBoxControl)
			InitializeComponent()
			InitComboBoxes()
			InitListBox(listBox)
			InitSearchControlProperties()
		End Sub

		Private listBox As BaseListBoxControl
		Private updateValues As Boolean = False
        Private ReadOnly searchControlPropertyChangedCore As New Object()
		Public Custom Event SearchControlPropertyChanged As PropertyChangedEventHandler
			AddHandler(ByVal value As PropertyChangedEventHandler)
                Events.AddHandler(searchControlPropertyChangedCore, value)
			End AddHandler
			RemoveHandler(ByVal value As PropertyChangedEventHandler)
                Events.RemoveHandler(searchControlPropertyChangedCore, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs)
			End RaiseEvent
		End Event
		' <ceAllowAutoApply>      
		' <ceShowSearchButton>        
		' <ceShowClearButton>
		' <ceShowMRUButton>
		' <tbFindDelay>
		' <cbFilterCondition>
		' <cbShowDefaultButtonsMode>
		' <searchControlSample>
		Protected Sub RaiseSearchControlPropertyChanged(ByVal propertyName As String, ByVal value As Object)
            Dim handler As PropertyChangedEventHandler = CType(Events(searchControlPropertyChangedCore), PropertyChangedEventHandler)
			If handler IsNot Nothing Then
				handler(Me, New PropertyValueChangedEventArgs(propertyName, value))
			End If
		End Sub
		' </ceAllowAutoApply>      
		' </ceShowSearchButton>        
		' </ceShowClearButton>
		' </ceShowMRUButton>
		' </tbFindDelay>
		' </cbFilterCondition>
		' </cbShowDefaultButtonsMode>
		' </searchControlSample>
		Public Sub InitListBox(ByVal listBox As BaseListBoxControl)
			Me.listBox = listBox
			updateValues = True
			icbSelectionMode.EditValue = listBox.SelectionMode
			icbSortOrder.EditValue = listBox.SortOrder
			icbHighlightedItemStyle.EditValue = listBox.HighlightedItemStyle
			icbHotTrackSelectMode.EditValue = listBox.HotTrackSelectMode
			seColumnWidth.Value = listBox.ColumnWidth
			ceHotTrack.Checked = listBox.HotTrackItems
			ceMultiColumn.Checked = listBox.MultiColumn
			seColumnWidth.Enabled = listBox.MultiColumn
			' <icbSelectionMode>
			icbSelectionMode.Enabled = CheckedListBox Is Nothing
			' </icbSelectionMode>
			If ImageListBox IsNot Nothing Then
				icbAlignment.EditValue = ImageListBox.GlyphAlignment
			End If
			If CheckedListBox IsNot Nothing Then
				ceCheckOnClick.Checked = CheckedListBox.CheckOnClick
			End If
            groupControlSearch.Visible = (ListBoxControl IsNot Nothing AndAlso ceTurnSearch.Checked)
            ceTurnSearch.Enabled = ListBoxControl IsNot Nothing
			groupControlChecked.Visible = CheckedListBox IsNot Nothing
			groupControlImage.Visible = ImageListBox IsNot Nothing
			icbSortOrder.Enabled = listBox.DataSource Is Nothing
			ceHotTrack.Enabled = AllowHotTrack
			ceIncrementalSearch.Checked = listBox.IncrementalSearch
			UpdateHotTrackSelectModeEnabled()
			updateValues = False
		End Sub
		Private Sub InitSearchControlProperties()
			If ListBoxControl IsNot Nothing Then
				ceTurnSearch.Checked = True
				' <ceAllowAutoApply>
				ceAllowAutoApply.Checked = True
				' </ceAllowAutoApply>
				' <ceShowSearchButton>
				ceShowSearchButton.Checked = True
				' </ceShowSearchButton>
				' <ceShowClearButton>
				ceShowClearButton.Checked = True
				' </ceShowClearButton>
				' <ceShowMRUButton>
				ceShowMRUButton.Checked = False
				' </ceShowMRUButton>
				' <cbFilterCondition>
				cbFilterCondition.Properties.Items.AddEnum(GetType(DevExpress.Data.Filtering.FilterCondition))
				cbFilterCondition.SelectedIndex = CInt(Fix(DevExpress.Data.Filtering.FilterCondition.Default))
				' </cbFilterCondition>
				' <tbFindDelay>
				tbFindDelay.Value = 1000
				' </tbFindDelay>
				' <cbShowDefaultButtonsMode>
				cbShowDefaultButtonsMode.Properties.Items.AddEnum(GetType(Repository.ShowDefaultButtonsMode))
				cbShowDefaultButtonsMode.SelectedIndex = CInt(Fix(Repository.ShowDefaultButtonsMode.Default))
				' </cbShowDefaultButtonsMode>
			End If
		End Sub
		Private Sub UpdateHotTrackSelectModeEnabled()
			icbHotTrackSelectMode.Enabled = listBox.HighlightedItemStyle = HighlightStyle.Skinned AndAlso listBox.HotTrackItems
		End Sub
		Private Sub InitComboBoxes()
			' <icbSelectionMode>
			icbSelectionMode.Properties.Items.AddEnum(GetType(SelectionMode))
			' </icbSelectionMode>
			' <icbSortOrder>
			icbSortOrder.Properties.Items.AddEnum(GetType(SortOrder))
			' </icbSortOrder>
			' <icbAlignment>
			icbAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
			' </icbAlignment>
			' <icbHighlightedItemStyle>
			icbHighlightedItemStyle.Properties.Items.AddEnum(GetType(HighlightStyle))
			' </icbHighlightedItemStyle>
			' <icbHotTrackSelectMode>
			icbHotTrackSelectMode.Properties.Items.AddEnum(GetType(HotTrackSelectMode))
			' </icbHotTrackSelectMode>
		End Sub

		' <icbSelectionMode>
		' <ceHotTrack>
		Private ReadOnly Property AllowHotTrack() As Boolean
			Get
				Return listBox.SelectionMode.ToString().IndexOf("Multi") = -1
			End Get
		End Property
		' </ceHotTrack>
		Private Sub icbSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSelectionMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.SelectionMode = CType(icbSelectionMode.EditValue, SelectionMode)
			' <ceHotTrack>
			ceHotTrack.Enabled = AllowHotTrack
			' </ceHotTrack>
		End Sub
		' </icbSelectionMode>

		' <icbSortOrder>
		Private Sub icbSortOrder_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSortOrder.SelectedIndexChanged
			' </skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.SortOrder = CType(icbSortOrder.EditValue, SortOrder)
		End Sub
		' </icbSortOrder>

		' <seColumnWidth>
		Private Sub seColumnWidth_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seColumnWidth.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.ColumnWidth = Convert.ToInt32(seColumnWidth.Value)
		End Sub
		' </seColumnWidth>

		' <ceHotTrack>
		Private Sub ceHotTrack_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceHotTrack.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.HotTrackItems = ceHotTrack.Checked
			' <skip>
			UpdateHotTrackSelectModeEnabled()
			' </skip>
		End Sub
		' </ceHotTrack>

		' <ceMultiColumn>
		Private Sub ceMultiColumn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMultiColumn.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.MultiColumn = ceMultiColumn.Checked
			' <seColumnWidth>
			seColumnWidth.Enabled = listBox.MultiColumn
			' </seColumnWidth>
		End Sub
		' </ceMultiColumn>

		' <icbAlignment>
		Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			If ImageListBox Is Nothing Then
				Return
			End If
			ImageListBox.GlyphAlignment = CType(icbAlignment.EditValue, HorzAlignment)
		End Sub
		' </icbAlignment>

		' <ceCheckOnClick>
		Private Sub ceCheckOnClick_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCheckOnClick.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			If CheckedListBox Is Nothing Then
				Return
			End If
			CheckedListBox.CheckOnClick = ceCheckOnClick.Checked
		End Sub
		' </ceCheckOnClick>

		' <icbHighlightedItemStyle>
		Private Sub icbHighlightedItemStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbHighlightedItemStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.HighlightedItemStyle = CType(icbHighlightedItemStyle.EditValue, HighlightStyle)
			' <skip>
			UpdateHotTrackSelectModeEnabled()
			' </skip>
		End Sub
		' </icbHighlightedItemStyle>

		' <icbHotTrackSelectMode>
		Private Sub icbHotTrackSelectMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbHotTrackSelectMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.HotTrackSelectMode = CType(icbHotTrackSelectMode.EditValue, HotTrackSelectMode)
		End Sub
		' </icbHotTrackSelectMode>
		' <ceIncrementalSearch>
		Private Sub ceIncrementalSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceIncrementalSearch.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			listBox.IncrementalSearch = ceIncrementalSearch.Checked
		End Sub
		' </ceIncrementalSearch>
		' <ceAllowAutoApply>
		Private Sub ceAllowAutoApply_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowAutoApply.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("AllowAutoApply", ceAllowAutoApply.Checked)
		End Sub
		' </ceAllowAutoApply>
		' <ceShowSearchButton>
		Private Sub ceShowSearchButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowSearchButton.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("ShowSearchButton", ceShowSearchButton.Checked)
		End Sub
		' </ceShowSearchButton>
		' <ceShowClearButton>
		Private Sub ceShowClearButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowClearButton.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("ShowClearButton", ceShowClearButton.Checked)
		End Sub
		' </ceShowClearButton>
		' <ceShowMRUButton>
		Private Sub ceShowMRUButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowMRUButton.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("ShowMRUButton", ceShowMRUButton.Checked)
		End Sub
		' </ceShowMRUButton>
		' <tbFindDelay>
		Private Sub tbFindDelay_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbFindDelay.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("FindDelay", tbFindDelay.Value)
		End Sub
		' </tbFindDelay>
		' <cbFilterCondition>
		Private Sub cbFilterCondition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFilterCondition.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("FilterCondition", cbFilterCondition.EditValue)
		End Sub
		' </cbFilterCondition>
		' <searchControlSample>
		Private Sub ceTurnSearch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceTurnSearch.CheckedChanged
			RaiseSearchControlPropertyChanged("TurnSearch", ceTurnSearch.Checked)
			' <skip>
			groupControlSearch.Visible = ceTurnSearch.Checked
			' </skip>
		End Sub
		' </searchControlSample>
		' <cbShowDefaultButtonsMode>
		Private Sub cbShowDefaultButtonsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbShowDefaultButtonsMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			RaiseSearchControlPropertyChanged("ShowDefaultButtonsMode", cbShowDefaultButtonsMode.EditValue)
		End Sub
		' </cbShowDefaultButtonsMode>
	End Class
	Public Class PropertyValueChangedEventArgs
		Inherits PropertyChangedEventArgs
'INSTANT VB NOTE: The variable value was renamed since Visual Basic does not allow class members with the same name:
		Private value_Renamed As Object
		Public Sub New(ByVal propertyName As String, ByVal value As Object)
			MyBase.New(propertyName)
			Me.value_Renamed = value
		End Sub
		Public ReadOnly Property Value() As Object
			Get
				Return value_Renamed
			End Get
		End Property
	End Class
End Namespace
