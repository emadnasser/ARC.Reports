Imports System.Collections
Imports System.ComponentModel
' <icbSizeMode>
Imports DevExpress.XtraEditors.Controls
' </icbSizeMode>
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleImageEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleImageEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "imageedit.xml"
		End Sub

		Private updateValues As Boolean = False

		Private Sub ModuleImageEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			ControlUtils.CenterControlInParent(imageEditSample)
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			' <icbSizeMode>
			icbSizeMode.Properties.Items.AddEnum(GetType(PictureSizeMode))
			' </icbSizeMode>
		End Sub


		Private Sub InitValues()
			updateValues = True
			icbSizeMode.EditValue = imageEditSample.Properties.SizeMode
			ceIcon.Checked = imageEditSample.Properties.ShowIcon
			ceMenu.Checked = imageEditSample.Properties.ShowMenu
			cePopupSizeable.Checked = imageEditSample.Properties.PopupSizeable
			ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon
			updateValues = False
		End Sub

		' <icbSizeMode>
		Private Sub icbSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbSizeMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageEditSample.Properties.SizeMode = CType(icbSizeMode.EditValue, PictureSizeMode)
		End Sub
		' </icbSizeMode>

		' <ceIcon>
		Private Sub ceIcon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceIcon.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageEditSample.Properties.ShowIcon = ceIcon.Checked
			' <ceCustomIcons>
			ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon
			' </ceCustomIcons>
		End Sub
		' </ceIcon>

		' <ceMenu>
		Private Sub ceMenu_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMenu.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageEditSample.Properties.ShowMenu = ceMenu.Checked
		End Sub
		' </ceMenu>

		' <cePopupSizeable>
		Private Sub cePopupSizeable_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cePopupSizeable.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			imageEditSample.Properties.PopupSizeable = cePopupSizeable.Checked
		End Sub
		' </cePopupSizeable>

		' <ceCustomIcons>
		Private Sub ceCustomIcons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustomIcons.CheckedChanged
			imageEditSample.Properties.Images = If(ceCustomIcons.Checked, imageCollection1, Nothing)
		End Sub
		' </ceCustomIcons>
	End Class
End Namespace

