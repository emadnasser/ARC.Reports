Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleDropDownButton
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleDropDownButton.vb"
			TutorialInfo.WhatsThisXMLFile = "dropdownbutton.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModulePictureEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(sampleDropDownButton)
			InitCombo()
			InitValues()
		End Sub

		Private Sub InitCombo()
			'<icbImageLocation>
			icbImageLocation.Properties.Items.AddEnum(GetType(ImageLocation))
			'</icbImageLocation>
			'<icbImage>
			For i As Integer = 0 To imageCollection1.Images.Count - 1
				icbImage.Properties.Items.Add(New ImageComboBoxItem(imageCollection1.Images.Keys(i), i, i))
			Next i
			'</icbImage>
		End Sub


		Private Sub InitValues()
			updateValues = True
			icbImageLocation.EditValue = sampleDropDownButton.ImageLocation
			icbImage.EditValue = sampleDropDownButton.ImageIndex
			icbDropDownStyle.Properties.Items.AddEnum(GetType(DropDownArrowStyle))
			icbDropDownStyle.EditValue = DropDownArrowStyle.Default
			icbDropDownControl.EditValue = 0
			updateValues = False
		End Sub
		'<icbImageLocation>
		Private Sub icbImageLocation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbImageLocation.SelectedIndexChanged
			'<skip>
			If updateValues Then
				Return
			End If
			'</skip>
			sampleDropDownButton.ImageLocation = CType(icbImageLocation.EditValue, ImageLocation)
		End Sub
		'</icbImageLocation>
		'<icbImage>
		Private Sub icbImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbImage.SelectedIndexChanged
			'<skip>
			If updateValues Then
				Return
			End If
			'</skip>
			sampleDropDownButton.ImageIndex = CInt(Fix(icbImage.EditValue))
		End Sub
		'</icbImage>

		'<icbDropDownControl>
		Private Sub icbDropDownControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbDropDownControl.SelectedIndexChanged
			'<skip>
			If updateValues Then
				Return
			End If
			'</skip>
			If icbDropDownControl.EditValue.Equals(0) Then
				sampleDropDownButton.DropDownControl = popupMenu1
			Else
				sampleDropDownButton.DropDownControl = popupControlContainer1
			End If
		End Sub
		'</icbDropDownControl>

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			dateEdit1.DateTime = Date.Now
			timeEdit1.Time = dateEdit1.DateTime
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton2.Click
			dateEdit1.EditValue = Nothing
			timeEdit1.EditValue = Nothing
		End Sub

		'<meFiringEvents>
		Private Sub sampleDropDownButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sampleDropDownButton.Click
			ShowEvent("Click", sender)
		End Sub

		Private Sub sampleDropDownButton_ShowDropDownControl(ByVal sender As Object, ByVal e As ShowDropDownControlEventArgs) Handles sampleDropDownButton.ShowDropDownControl
			ShowEvent("ShowDropDownControl", e.DropDownControl)
		End Sub

		Private Sub ShowEvent(ByVal eventString As String, ByVal obj As Object)
			meFiringEvents.Text = String.Format("{0}: {1}" & vbCrLf, eventString, obj) & meFiringEvents.Text
		End Sub
		'</meFiringEvents>
		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			meFiringEvents.Text = String.Empty
		End Sub
		Private Sub icbDropDownStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbDropDownStyle.SelectedIndexChanged
			sampleDropDownButton.DropDownArrowStyle = CType(icbDropDownStyle.EditValue, DropDownArrowStyle)
		End Sub

	End Class
End Namespace

