Imports System.Collections
Imports System.ComponentModel
' <icbAlignment>
Imports DevExpress.Utils
' </icbAlignment>
' <hyperLinkEdit2>
Imports DevExpress.XtraEditors
' </hyperLinkEdit2>
' <icbWindowStyle>
' <icbAlignment>
Imports DevExpress.XtraEditors.Controls
' </icbAlignment>
' </icbWindowStyle>

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModuleHyperLinkEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			hyperLinkImage = hyperLinkEditSample.Properties.Image
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModuleHyperLinkEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "hyperlinkedit.xml"
		End Sub

		Private hyperLinkImage As Image = Nothing
		Private updateValues As Boolean = False

		Private Sub ModuleHyperLinkEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DevExpress.Tutorials.ControlUtils.CenterControlInParent(hyperLinkEditSample)
			InitComboBoxes()
			InitValues()
		End Sub

		Private Sub InitComboBoxes()
			' <icbWindowStyle>
			icbWindowStyle.Properties.Items.AddEnum(GetType(ProcessWindowStyle))
			' </icbWindowStyle>
			' <icbAlignment>
			icbAlignment.Properties.Items.AddEnum(GetType(HorzAlignment))
			' </icbAlignment>
		End Sub

		Private Sub InitValues()
			lbStartKey.Text = hyperLinkEditSample.Properties.StartKey.ToString()
			lbAddress.Text = hyperLinkEditSample.Text
			updateValues = True
			icbWindowStyle.EditValue = hyperLinkEditSample.Properties.BrowserWindowStyle
			ceSingleClick.Checked = hyperLinkEditSample.Properties.SingleClick
			teCaption.Text = hyperLinkEditSample.Properties.Caption
			icbAlignment.EditValue = hyperLinkEditSample.Properties.ImageAlignment
			colorEditLinkColor.Color = hyperLinkEditSample.Properties.LinkColor
			updateValues = False
		End Sub

		' <icbWindowStyle>
		Private Sub icbWindowStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbWindowStyle.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			hyperLinkEditSample.Properties.BrowserWindowStyle = CType(icbWindowStyle.EditValue, ProcessWindowStyle)
		End Sub
		' </icbWindowStyle>

		' <ceSingleClick>
		Private Sub ceSingleClick_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceSingleClick.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			hyperLinkEditSample.Properties.SingleClick = ceSingleClick.Checked
		End Sub
		' </ceSingleClick>

		' <teCaption>
		Private Sub teCaption_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teCaption.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			hyperLinkEditSample.Properties.Caption = teCaption.Text
		End Sub
		' </teCaption>

		' <sbImageSet>
		Private Sub sbImageSet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImageSet.Click
			hyperLinkEditSample.Properties.Image = hyperLinkImage
		End Sub
		' </sbImageSet>

		' <sbImageClear>
		Private Sub sbImageClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImageClear.Click
			hyperLinkEditSample.Properties.Image = Nothing
		End Sub
		' </sbImageClear>

		' <icbAlignment>
		Private Sub icbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			hyperLinkEditSample.Properties.ImageAlignment = CType(icbAlignment.EditValue, HorzAlignment)
		End Sub
		' </icbAlignment>

		' <colorEditLinkColor>
		Private Sub colorEditLinkColor_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorEditLinkColor.EditValueChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			hyperLinkEditSample.Properties.LinkColor = colorEditLinkColor.Color
		End Sub
		' </colorEditLinkColor>

		' <hyperLinkEdit2>
		Private Sub hyperLinkEdit2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles hyperLinkEdit2.ButtonClick
			Dim editor As HyperLinkEdit = TryCast(sender, HyperLinkEdit)
			editor.ShowBrowser("https://www.devexpress.com/ClientCenter/Order/?group=.NET")
		End Sub
		' </hyperLinkEdit2>

		' <hyperLinkEdit1>
		Private Sub ShowEvent(ByVal eventString As String, ByVal data As String)
			meFiringEvents.Text = String.Format("{0}: {1}" & vbCrLf, eventString, data) & meFiringEvents.Text
		End Sub

		Private Sub hyperLinkEdit_OpenLink(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles hyperLinkEdit2.OpenLink, hyperLinkEdit1.OpenLink
			ShowEvent("OpenLink", e.EditValue.ToString())
		End Sub
		' </hyperLinkEdit1>
	End Class
End Namespace

