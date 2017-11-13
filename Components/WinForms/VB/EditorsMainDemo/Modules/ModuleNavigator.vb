Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Tutorials
' <icbTextLocations>
' <ceShowCustomButtons>
Imports DevExpress.XtraEditors
' </ceShowCustomButtons>
Imports DevExpress.XtraEditors.Controls
' </icbTextLocations>


Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleNavigator
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleNavigator.vb"
			TutorialInfo.WhatsThisXMLFile = "navigator.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleNavigator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(dataNavigatorSample)
			InitComboBoxes()
			InitValues()
			InitData()
		End Sub

		Private Sub InitComboBoxes()
			' <icbTextLocations>
			icbTextLocations.Properties.Items.AddEnum(GetType(NavigatorButtonsTextLocation))
			' </icbTextLocations>
		End Sub


		Private Sub InitValues()
			updateValues = True
			icbTextLocations.EditValue = dataNavigatorSample.TextLocation
			ceEnableAutoRepeat.Checked = dataNavigatorSample.Buttons.EnabledAutoRepeat
			ceShowToolTips.Checked = dataNavigatorSample.ShowToolTips
			ceShowCustomButtons.Checked = True
			ceShowEditingButtons.Checked = True
			ceShowAppendRemove.Checked = True
			ceShowPageButtons.Checked = True
			updateValues = False
		End Sub

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
			If DBFileName <> "" Then
				Dim ds As New DataSet()
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName

				Dim dbAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM Products", con)
				dbAdapter.Fill(ds, "Products")

				dataNavigatorSample.DataSource = ds.Tables("Products")
				panelControl1.DataBindings.Add("Text", ds.Tables("Products"), "ProductName")
			End If
		End Sub

		' <icbTextLocations>
		Private Sub icbTextLocations_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbTextLocations.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			dataNavigatorSample.TextLocation = CType(icbTextLocations.EditValue, NavigatorButtonsTextLocation)
			' <skip>
			ShowNavigator()
			' </skip>
		End Sub
		' </icbTextLocations>

		' <ceEnableAutoRepeat>
		Private Sub ceEnableAutoRepeat_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceEnableAutoRepeat.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			dataNavigatorSample.Buttons.EnabledAutoRepeat = ceEnableAutoRepeat.Checked
		End Sub
		' </ceEnableAutoRepeat>

		' <ceShowToolTips>
		Private Sub ceShowToolTips_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowToolTips.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			dataNavigatorSample.ShowToolTips = ceShowToolTips.Checked
		End Sub
		' </ceShowToolTips>

		Private Sub ShowNavigator()
			dataNavigatorSample.Width = 10
			ControlUtils.CenterControlInParent(dataNavigatorSample)
		End Sub

		' <ceShowCustomButtons>
		Private Sub ceShowCustomButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowCustomButtons.CheckedChanged
			For Each button As NavigatorCustomButton In dataNavigatorSample.Buttons.CustomButtons
				button.Visible = ceShowCustomButtons.Checked
			Next button
			ShowNavigator()
		End Sub
		' </ceShowCustomButtons>

		' <ceShowEditingButtons>
		Private Sub ceShowEditingButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowEditingButtons.CheckedChanged
			dataNavigatorSample.Buttons.EndEdit.Visible = ceShowEditingButtons.Checked
			dataNavigatorSample.Buttons.CancelEdit.Visible = dataNavigatorSample.Buttons.EndEdit.Visible
			ShowNavigator()
		End Sub
		' </ceShowEditingButtons>

		' <ceShowAppendRemove>
		Private Sub ceShowAppendRemove_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowAppendRemove.CheckedChanged
			dataNavigatorSample.Buttons.Remove.Visible = ceShowAppendRemove.Checked
			dataNavigatorSample.Buttons.Append.Visible = dataNavigatorSample.Buttons.Remove.Visible
			ShowNavigator()
		End Sub
		' </ceShowAppendRemove>

		' <ceShowPageButtons>
		Private Sub ceShowPageButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceShowPageButtons.CheckedChanged
			dataNavigatorSample.Buttons.NextPage.Visible = ceShowPageButtons.Checked
			dataNavigatorSample.Buttons.PrevPage.Visible = dataNavigatorSample.Buttons.NextPage.Visible
			ShowNavigator()
		End Sub
		' </ceShowPageButtons>

		' <dataNavigatorSample>
		Private Sub dataNavigatorSample_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles dataNavigatorSample.ButtonClick
			ShowEvent("ButtonClick", e.Button)
		End Sub

		Private Sub ShowEvent(ByVal eventString As String, ByVal button As NavigatorButtonBase)
			Dim type As String = button.ButtonType.ToString()
			If type = "Custom" Then
				type &= " - " & button.Tag.ToString()
			End If
			meFiringEvents.Text = String.Format("{0}: {1}" & vbCrLf, eventString, type) & meFiringEvents.Text
		End Sub
		' </dataNavigatorSample>
	End Class
End Namespace

