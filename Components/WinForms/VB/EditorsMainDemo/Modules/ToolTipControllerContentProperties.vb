Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls

Namespace EditorsTutorials.Modules
	Partial Public Class ToolTipControllerContentProperties
		Inherits UserControl

		Public Sub New()
			InitializeComponent()
		End Sub

		Private controller As ToolTipController = Nothing
		Private control As Control = Nothing
		Private isManual As Boolean = False

		Public Sub Init(ByVal controller As ToolTipController, ByVal control As Control, ByVal toolTipText As String, ByVal titleText As String, ByVal isManual As Boolean)
			Me.isManual = isManual
			Me.controller = controller
			Me.control = control
			InitComboBoxes()
			meToolTipText.Text = toolTipText
			teTitleText.Text = titleText
			If isManual Then
				icbIconSize.EditValue = ToolTipIconSize.Large
			Else
				icbIconSize.EditValue = controller.IconSize
			End If
			controller.ImageList = imcSmall
		End Sub

		Private Sub InitComboBoxes()
			icbIconType.Properties.Items.AddEnum(GetType(ToolTipIconType))
			icbIconType.SelectedIndex = If(isManual, icbIconType.Properties.Items.Count - 1, 3)
			icbIconSize.Properties.Items.AddEnum(GetType(ToolTipIconSize))
		End Sub

		Private Sub meToolTipText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles meToolTipText.TextChanged
            If isManual Or controller Is Nothing Then
                Return
            End If
			controller.SetToolTip(control, meToolTipText.Text)
		End Sub

		Private Sub teTitleText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teTitleText.TextChanged
            If isManual Or controller Is Nothing Then
                Return
            End If
			controller.SetTitle(control, teTitleText.Text)
		End Sub

		Private Sub icbIconType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbIconType.SelectedIndexChanged
			If isManual Then
				Return
			End If
			controller.SetToolTipIconType(control, CType(icbIconType.EditValue, ToolTipIconType))
		End Sub

		Private Sub icbIconSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbIconSize.SelectedIndexChanged
			If isManual Then
				Return
			End If
			controller.IconSize = CType(icbIconSize.EditValue, ToolTipIconSize)
		End Sub

		Private Sub icbCustomImage_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbCustomImage.SelectedIndexChanged
			If isManual Then
				Return
			End If
			controller.ImageIndex = icbCustomImage.SelectedIndex - 1
		End Sub

		Public Function CreateShowArgs() As ToolTipControllerShowEventArgs
			Dim args As ToolTipControllerShowEventArgs = controller.CreateShowArgs()
			args.ToolTip = meToolTipText.Text
			args.Title = teTitleText.Text
			args.IconType = CType(icbIconType.EditValue, ToolTipIconType)
			args.IconSize = CType(icbIconSize.EditValue, ToolTipIconSize)
			args.ImageIndex = icbCustomImage.SelectedIndex - 1
			Return args
		End Function
	End Class
End Namespace
