Imports System.Collections
Imports System.ComponentModel
' <comboBoxSizeMode>
Imports DevExpress.XtraEditors.Controls
' </comboBoxSizeMode>
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils

Namespace DevExpress.XtraEditors.Demos
	Partial Public Class ModulePictureEdit
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\EditorsMainDemo\Modules\ModulePictureEdit.vb"
			TutorialInfo.WhatsThisXMLFile = "pictureEdit.xml"
		End Sub

		Private updateValues As Boolean = False

		' <checkEditAllowMenu>
		Private Sub checkEditAllowMenu_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEditAllowMenu.CheckedChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			pictureEditSample.Properties.ShowMenu = checkEditAllowMenu.Checked
		End Sub
		' </checkEditAllowMenu>

		' <comboBoxSizeMode>
		Private Sub comboBoxSizeMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxSizeMode.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim modes() As PictureSizeMode = { PictureSizeMode.Clip, PictureSizeMode.Stretch, PictureSizeMode.Zoom, PictureSizeMode.StretchHorizontal, PictureSizeMode.StretchVertical, PictureSizeMode.Squeeze}
			Dim selectedIndex As Integer = comboBoxSizeMode.SelectedIndex
			pictureEditSample.Properties.SizeMode = modes(selectedIndex)
		End Sub
		' </comboBoxSizeMode>

		' <comboBoxPictureAlignment>
		Private aligns() As ContentAlignment = { ContentAlignment.TopLeft, ContentAlignment.TopCenter, ContentAlignment.TopRight, ContentAlignment.MiddleLeft, ContentAlignment.MiddleCenter, ContentAlignment.MiddleRight, ContentAlignment.BottomLeft, ContentAlignment.BottomCenter, ContentAlignment.BottomRight }
		Private Sub comboBoxPictureAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxPictureAlignment.SelectedIndexChanged
			' <skip>
			If updateValues Then
				Return
			End If
			' </skip>
			Dim selectedIndex As Integer = comboBoxPictureAlignment.SelectedIndex
			pictureEditSample.Properties.PictureAlignment = aligns(selectedIndex)
		End Sub
		' </comboBoxPictureAlignment>


		' <btnClearImage> <btnRestoreImage>
		Private savedImage As Image = Nothing

        Private Sub btnClearImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            savedImage = pictureEditSample.Image
            pictureEditSample.Image = Nothing
        End Sub
		' </btnClearImage>

        Private Sub btnRestoreImage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            If pictureEditSample.Image Is Nothing Then
                pictureEditSample.Image = savedImage
            End If
        End Sub
		' </btnRestoreImage>

        Private Sub ModulePictureEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(pictureEditSample)
            For Each mode As InterpolationMode In System.Enum.GetValues(GetType(InterpolationMode))
                If mode <> InterpolationMode.Invalid Then
                    icbInterpolationMode.Properties.Items.Add(New ImageComboBoxItem(mode.ToString(), mode, -1))
                End If
            Next mode
            icbShowZoomSubMenu.Properties.Items.AddEnum(GetType(DefaultBoolean))
            InitValues()
        End Sub


        Private Sub InitValues()
            updateValues = True
            checkEditAllowMenu.Checked = pictureEditSample.Properties.ShowMenu
            comboBoxSizeMode.EditValue = pictureEditSample.Properties.SizeMode.ToString()
            comboBoxPictureAlignment.EditValue = pictureEditSample.Properties.PictureAlignment.ToString()
            ceShowScrollBars.Checked = peScrollable.Properties.ShowScrollBars
            ceAllowFocused.Checked = peScrollable.Properties.AllowFocused
            cbAlignment.EditValue = peScrollable.Properties.PictureAlignment.ToString()
            seZoomPercent.Value = New Decimal(peScrollable.Properties.ZoomPercent)
            ceAllowScroll.Checked = peScrollable.Properties.AllowScrollViaMouseDrag
            icbInterpolationMode.EditValue = peScrollable.Properties.PictureInterpolationMode
            icbShowZoomSubMenu.EditValue = peScrollable.Properties.ShowZoomSubMenu
            ceShowCameraItem.Checked = peScrollable.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Always
            updateValues = False
            UpdateAllowScrollViaMouseDrag()
            seZoomPercent.Value = 100
            peScrollable.UpdateScrollBars()
        End Sub

        '<ceShowScrollBars>
        Private Sub ceShowScrollBars_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceShowScrollBars.CheckedChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            peScrollable.Properties.ShowScrollBars = ceShowScrollBars.Checked
            UpdateAllowScrollViaMouseDrag()
        End Sub
        '</ceShowScrollBars>
        Private Sub UpdateAllowScrollViaMouseDrag()
            ceAllowScroll.Enabled = peScrollable.Properties.ShowScrollBars
        End Sub

        '<ceAllowFocused>
        Private Sub ceAllowFocused_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowFocused.CheckedChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.AllowFocused = ceAllowFocused.Checked
        End Sub
        '</ceAllowFocused>
        '<cbAlignment>
        Private Sub cbAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbAlignment.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            Dim selectedIndex As Integer = cbAlignment.SelectedIndex
            peScrollable.Properties.PictureAlignment = aligns(selectedIndex)
        End Sub
        '</cbAlignment>
        Private Sub seZoomPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seZoomPercent.EditValueChanged
            ztbZoomPercent.Value = CInt(Fix(seZoomPercent.Value))
        End Sub

        Private Sub ztbZoomPercent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ztbZoomPercent.EditValueChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            seZoomPercent.Value = ztbZoomPercent.Value
            peScrollable.Properties.ZoomPercent = ztbZoomPercent.Value
        End Sub
        '<ceAllowScroll>
        Private Sub ceAllowScroll_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceAllowScroll.CheckedChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.SizeMode = PictureSizeMode.Clip
            peScrollable.Properties.AllowScrollViaMouseDrag = ceAllowScroll.Checked
        End Sub
        '</ceAllowScroll>
        '<icbInterpolationMode>
        Private Sub icbInterpolationMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbInterpolationMode.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.PictureInterpolationMode = CType(icbInterpolationMode.EditValue, InterpolationMode)
        End Sub

        Private Sub peScrollable_ZoomPercentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles peScrollable.ZoomPercentChanged
            updateValues = True
            Try
                seZoomPercent.Value = New Decimal(peScrollable.Properties.ZoomPercent)
                ztbZoomPercent.Value = CType(peScrollable.Properties.ZoomPercent, Integer)
            Finally
                updateValues = False
            End Try
        End Sub

        Private Sub icbShowZoomSubMenu_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbShowZoomSubMenu.SelectedIndexChanged
            If updateValues Then
                Return
            End If
            peScrollable.Properties.ShowZoomSubMenu = CType(icbShowZoomSubMenu.EditValue, DefaultBoolean)
        End Sub

        Private Sub pictureEditSample_Properties_ContextButtonClick(sender As Object, e As ContextItemClickEventArgs) Handles pictureEditSample.Properties.ContextButtonClick
            ContextButtonClick(e)
        End Sub

        Private Sub peScrollable_Properties_ContextButtonClick(sender As Object, e As ContextItemClickEventArgs) Handles peScrollable.Properties.ContextButtonClick
            ContextButtonClick(e)
        End Sub
        Private Sub ContextButtonClick(ByVal e As ContextItemClickEventArgs)
            If e.Item.Name = "itemDownload" Then
                MessageBox.Show("'Download' item clicked")
            ElseIf e.Item.Name = "itemRemove" Then
                MessageBox.Show("'Remove' item clicked")
            ElseIf e.Item.Name = "itemInfo" Then
                MessageBox.Show("'Info' item clicked")
            End If
        End Sub

        Private Sub pictureEditSample_Properties_ContextButtonValueChanged(sender As Object, e As ContextButtonValueEventArgs) Handles pictureEditSample.Properties.ContextButtonValueChanged
            If e.Item.Name = "TrackBarContextButon" Then
                pictureEditSample.Properties.ZoomPercent = CType(e.Value, Double)
            End If
        End Sub

        Private Sub pictureEditSample_ZoomPercentChanged(sender As Object, e As EventArgs) Handles pictureEditSample.ZoomPercentChanged
            Dim trackBar As TrackBarContextButton = CType(pictureEditSample.Properties.ContextButtons("TrackBarContextButton"), TrackBarContextButton)
            trackBar.Value = CType(pictureEditSample.Properties.ZoomPercent, Integer)
        End Sub

        Private Sub ceShowCameraItem_CheckedChanged(sender As Object, e As EventArgs) Handles ceShowCameraItem.CheckedChanged
            If updateValues Then
                Return
            End If
            If ceShowCameraItem.Checked Then
                peScrollable.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Always
            Else
                peScrollable.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Never
            End If
        End Sub

        Private Sub OnMaskTypeChanged(sender As Object, e As EventArgs) Handles comboBoxEdit1.SelectedValueChanged
            Select comboBoxEdit1.SelectedText
                Case "Circle"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Circle
                Case "RoundedRect"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.RoundedRect
                Case "Custom"
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.Custom
                Case Else
                    peMasked.Properties.OptionsMask.MaskType = PictureEditMaskType.None
            End Select
            OnMaskTypeChanged(peMasked.Properties.OptionsMask.MaskType)
        End Sub

        Protected Sub OnMaskTypeChanged(type As PictureEditMaskType)
            textEdit3.Enabled = Not (type = PictureEditMaskType.None)
            comboBoxEdit2.Enabled = Not (type = PictureEditMaskType.None)
            textEdit2.Enabled = Not (type = PictureEditMaskType.None)
            textEdit1.Enabled = Not (type = PictureEditMaskType.None)
            seRadius.Enabled = (type = PictureEditMaskType.RoundedRect)
            buttonEdit1.Enabled = (type = PictureEditMaskType.Custom)
        End Sub
        Protected Function GetIntMassiveFromEditValue(editValue As Object) As Integer()
            If editValue Is Nothing Then
                Return Nothing
            End If
            Dim vals() As String = editValue.ToString().Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)
            Dim res(vals.Length) As Integer
            For i = 0 To vals.Length - 1
                ReDim Preserve res(i)
                res(i) = Integer.Parse(vals(i))
            Next i
            Return res
        End Function
        Private Sub OnMaskOffsetChanged(sender As Object, e As EventArgs) Handles textEdit2.EditValueChanged
            Dim val() As Integer = GetIntMassiveFromEditValue(textEdit2.EditValue)
            If val Is Nothing Or Not val.Length = 2 Then
                Return
            End If
            Me.peMasked.Properties.OptionsMask.Offset = New Point(val(0), val(1))
        End Sub
        Private Sub OnMaskSizeChanged(sender As Object, e As EventArgs) Handles textEdit1.EditValueChanged
            Dim val() As Integer = GetIntMassiveFromEditValue(textEdit1.EditValue)
            If val Is Nothing Or Not val.Length = 2 Then
                Return
            End If
            Dim res As Size = If((val(0) <= 0 Or val(1) <= 0), Size.Empty, New Size(val(0), val(1)))
            Me.peMasked.Properties.OptionsMask.Size = res
        End Sub
        Private Sub OnMaskMarginChanged(sender As Object, e As EventArgs) Handles textEdit3.EditValueChanged
            Dim val() As Integer = GetIntMassiveFromEditValue(textEdit3.EditValue)
            If val Is Nothing Or Not val.Length = 4 Then
                Return
            End If
            Me.peMasked.Properties.OptionsMask.Margin = New System.Windows.Forms.Padding(val(0), val(1), val(2), val(3))
        End Sub
        Private Sub OnMaskRadiusChanged(sender As Object, e As EventArgs) Handles seRadius.EditValueChanged
            Me.peMasked.Properties.OptionsMask.RectCornerRadius = Decimal.ToInt32(seRadius.Value)
        End Sub
        Private Sub OnMaskLayoutChanged(sender As Object, e As EventArgs) Handles comboBoxEdit2.SelectedValueChanged
            Me.peMasked.Properties.OptionsMask.MaskLayoutMode = GetMaskLayoutType(Me.comboBoxEdit2.SelectedIndex)
        End Sub
        Protected Function GetMaskLayoutType(index As Integer) As PictureEditMaskLayoutMode
            Select Case index
                Case 1
                    Return PictureEditMaskLayoutMode.ZoomInside
                Case 2
                    Return PictureEditMaskLayoutMode.Stretch
                Case 3
                    Return PictureEditMaskLayoutMode.BottomCenter
                Case 4
                    Return PictureEditMaskLayoutMode.BottomLeft
                Case 5
                    Return PictureEditMaskLayoutMode.BottomRight
                Case 6
                    Return PictureEditMaskLayoutMode.MiddleCenter
                Case 7
                    Return PictureEditMaskLayoutMode.MiddleLeft
                Case 8
                    Return PictureEditMaskLayoutMode.MiddleRight
                Case 9
                    Return PictureEditMaskLayoutMode.TopCenter
                Case 10
                    Return PictureEditMaskLayoutMode.TopLeft
                Case 11
                    Return PictureEditMaskLayoutMode.TopRight
                Case Else
                    Return PictureEditMaskLayoutMode.Default
            End Select
        End Function
        Private Sub buttonEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            dlg.Filter = "BMP (*.bmp)|*.bmp|PNG (*.png)|*.png"
            dlg.Title = "Open"
            If dlg.ShowDialog(Me) = DialogResult.OK And dlg.FileName IsNot Nothing And Not dlg.FileName = String.Empty Then
                Try
                    Me.peMasked.Properties.OptionsMask.CustomMask = Image.FromFile(dlg.FileName)
                    Me.buttonEdit1.Text = dlg.FileName
                Catch
                End Try
            End If
        End Sub
    End Class
End Namespace

