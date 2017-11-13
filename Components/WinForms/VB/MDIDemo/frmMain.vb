Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTabbedMdi

Namespace DevExpress.XtraBars.Demos.MDIDemo
	''' <summary>
	''' Summary description for frmMain.
	''' </summary>
	Partial Public Class frmMain
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			'
			' Required for Windows Form Designer support
            '
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
			InitializeComponent()
			colorEdit.EditValue = Color.Empty
            Dim piis As ImageComboBoxItem() = New ImageComboBoxItem() {New ImageComboBoxItem("Clip", PictureSizeMode.Clip, -1), New ImageComboBoxItem("Stretch", PictureSizeMode.Stretch, -1), New ImageComboBoxItem("Zoom", PictureSizeMode.Zoom, -1), New ImageComboBoxItem("Squeeze", PictureSizeMode.Squeeze, -1)}
			For Each pii As ImageComboBoxItem In piis
				CType(sizeMode.Edit, DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox).Items.Add(pii)
			Next pii
			InitBars()
			AddHandler barManager1.GetController().Changed, AddressOf ChangedController
			ips_Init()
			InitSkins()
			InitTabbedMDI()
			InitPictures()
			'
			' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

		Private Sub InitPictures()
            CreateMDIPictureForm(Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Audi_TT_Roadster.jpg")), "Audi TT.jpg", False)
            CreateMDIPictureForm(Image.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("BMW_760i_Sedan.jpg")), "BMW 760i.jpg", False)
		End Sub

		Private Const imageFormName As String = "image"
		Private Const textFormName As String = "text"
		Private Const textRTFFormName As String = "rtf"
		Private currentCursor As Cursor
		Private skinMask As String = "Skin: "
		Private oldActive As Integer = -2
		Private lockUpdate As Integer = 0

		#Region "Skins"

		Private Sub InitSkins()
			barManager1.ForceInitialize()
			For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
				Dim item As BarButtonItem = New BarButtonItem(barManager1, skinMask & cnt.SkinName)
				iPaintStyle.AddItem(item)
				AddHandler item.ItemClick, AddressOf OnSkinClick
			Next cnt
		End Sub
		Private Sub OnSkinClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim skinName As String = e.Item.Caption.Replace(skinMask, "")
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
			barManager1.GetController().PaintStyleName = "Skin"
			iPaintStyle.Caption = e.Item.Caption
			iPaintStyle.Hint = iPaintStyle.Caption
			iPaintStyle.ImageIndex = -1
		End Sub
		#End Region

		Private Sub InitBars()
			If (ActiveMDIForm IsNot Nothing) Then
				iDocName.Caption = ActiveMDIForm.Tag.ToString()
			Else
				iDocName.Caption = " "
			End If
			iFont.Enabled = IsActiveTextRTFForm
			InitEdit()
			InitPicture()
			If oldActive = NumActive Then
			Return
			End If
			mEdit.Enabled = ActiveMDIForm IsNot Nothing
			iClose.Enabled = mEdit.Enabled
			sizeMode.Enabled = IsActiveImageForm
			iPictureAlignment.Enabled = sizeMode.Enabled
			iVerticalFlip.Enabled = iPictureAlignment.Enabled
			iHorizontalFlip.Enabled = iVerticalFlip.Enabled
			iRotateBy90.Enabled = iHorizontalFlip.Enabled
			colorEdit.Enabled = IsActiveTextForm
			iSelectAll.Enabled = colorEdit.Enabled

			For i As Integer = mEdit.ItemLinks.Count - 1 To 0 Step -1
				mEdit.RemoveLink(mEdit.ItemLinks(i))
			Next i

			If IsActiveImageForm Then
				iPicture.ImageIndex = 13
				mEdit.AddItem(iHorizontalFlip)
				mEdit.AddItem(iVerticalFlip)
				mEdit.AddItem(iRotateBy90)
				mEdit.Caption = "Image &Edit"
			End If
			If IsActiveTextForm Then
				iPicture.ImageIndex = 14
				mEdit.AddItem(iCut)
				mEdit.AddItem(iCopy)
				mEdit.AddItem(iPaste)
				mEdit.AddItem(iSelectAll).BeginGroup = True
				mEdit.Caption = "Text &Edit"
			End If

			If ActiveMDIForm Is Nothing Then
				iPicture.ImageIndex = -1
				mEdit.Caption = "&Edit"
			End If

			oldActive = NumActive
		End Sub


		Private Sub InitPicture()
			lockUpdate += 1
			If ActivePictureEdit IsNot Nothing Then
				sizeMode.EditValue = ActivePictureEdit.Properties.SizeMode
			Else
				sizeMode.EditValue = PictureSizeMode.Squeeze
			End If
			lockUpdate -= 1
		End Sub
		Private Sub InitEdit()
			Dim rtb As RichTextBox = ActiveRichTextBox
			If rtb IsNot Nothing Then
				iPaste.Enabled = rtb.CanPaste(DataFormats.GetFormat(0))
				iCopy.Enabled = rtb.SelectedText <> ""
				iCut.Enabled = iCopy.Enabled
				lockUpdate += 1
				colorEdit.EditValue = rtb.SelectionColor
				lockUpdate -= 1
			Else
				iPaste.Enabled = False
				iCopy.Enabled = iPaste.Enabled
				iCut.Enabled = iCopy.Enabled
			End If
		End Sub

		Private Sub RefreshForm(ByVal b As Boolean)
			If b Then
				currentCursor = Cursor.Current
				Cursor.Current = Cursors.WaitCursor
				Refresh()
			Else
				Cursor.Current = currentCursor
			End If
		End Sub

		Private ReadOnly Property NumActive() As Integer
			Get
				If IsActiveTextForm Then
				Return 1
				End If
				If IsActiveImageForm Then
				Return 0
				End If
				Return -1
			End Get
		End Property
		Private ReadOnly Property ActiveMDIForm() As Form
			Get
				Return Me.ActiveMdiChild
			End Get
		End Property

		Private Function GetIsImageForm(ByVal form As Form) As Boolean
			Return form IsNot Nothing AndAlso form.AccessibleName = imageFormName
		End Function
		Private ReadOnly Property IsActiveImageForm() As Boolean
			Get
				Return GetIsImageForm(ActiveMDIForm)
			End Get
		End Property

		Private ReadOnly Property IsActiveTextForm() As Boolean
			Get
				Return (ActiveMDIForm IsNot Nothing AndAlso ActiveMDIForm.AccessibleName = textFormName)
			End Get
		End Property

		Private ReadOnly Property IsActiveTextRTFForm() As Boolean
			Get
				Return (IsActiveTextForm AndAlso ActiveMDIForm.AccessibleDescription = textRTFFormName)
			End Get
		End Property

		Private Function GetPictureEdit(ByVal form As Form) As PictureEdit
			If GetIsImageForm(form) Then
				Return CType(form.Controls(0), PictureEdit)
			Else
				Return Nothing
			End If
		End Function
		Private ReadOnly Property ActivePictureEdit() As DevExpress.XtraEditors.PictureEdit
			Get
				Return GetPictureEdit(ActiveMDIForm)
			End Get
		End Property

		Private ReadOnly Property ActiveRichTextBox() As RichTextBox
			Get
				If IsActiveTextForm Then
					Return CType(ActiveMDIForm.Controls(0), RichTextBox)
				End If
				Return Nothing
			End Get
		End Property

		Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOpen.ItemClick
			Dim dlg As OpenFileDialog = New OpenFileDialog()
			dlg.Filter = "All Picture Files |*.bmp;*.gif;*.jpg;*.jpeg;*.ico;*.png|Text Files |*.txt;*.rtf"
			dlg.Title = "Open"
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				RefreshForm(True)
				Select Case dlg.FilterIndex
					Case 2
						CreateMDITextForm(dlg.FileName)
					Case Else
						Dim img As Image = Nothing
						Try
							img = Image.FromFile(dlg.FileName)
						Catch
						End Try
						If img IsNot Nothing Then
							CreateMDIPictureForm(img, dlg.FileName, True)
						Else
							MessageBox.Show("Wrong picture format...", "Error")
						End If
				End Select
				RefreshForm(False)
			End If
		End Sub

		Private Sub UpdateMdiPictureFormPreview(ByVal page As XtraMdiTabPage, ByVal img As Image)
			If page Is Nothing Then
				Return
			End If
			Dim preview As Image = Nothing
			Const previewHeight As Integer = 32
			Const previewWidthMax As Integer = 64
			'int previewHeight = this.imageList3.ImageSize.Height;
			If img IsNot Nothing AndAlso img.Height > 0 AndAlso previewHeight > 0 Then
                Dim previewWidth As Integer = previewHeight * img.Width \ img.Height
				If previewWidth > 0 Then
					If previewWidth > previewWidthMax Then
						previewWidth = previewWidthMax
					End If
					preview = New Bitmap(img, previewWidth, previewHeight)
				End If
			End If
			page.Image = preview
		End Sub

		Private Sub CreateMDIPictureForm(ByVal img As Image, ByVal s As String, ByVal isFile As Boolean)
			Dim frm As Form = New XtraForm()
			If isFile Then
				frm.Text = New System.IO.FileInfo(s).Name
			Else
				frm.Text = s
			End If
			frm.Tag = s
			frm.AccessibleName = imageFormName
			Dim pi As DevExpress.XtraEditors.PictureEdit = New DevExpress.XtraEditors.PictureEdit()
			pi.Dock = DockStyle.Fill
			pi.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			pi.Properties.ShowMenu = False
			pi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			pi.Image = img
			AddHandler pi.MouseUp, AddressOf ImageMouseUp
			If (Not IsTabbedMdi) Then
				frm.ClientSize = New Size(img.Width, img.Height)
			End If

			frm.Controls.Add(pi)
			frm.MdiParent = Me
			frm.Show()
		End Sub

		Private Sub RTBSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
			InitEdit()
		End Sub

		Private Sub RTBMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If IsActiveTextForm AndAlso sender.Equals(ActiveRichTextBox) Then
				If (e.Button And MouseButtons.Right) <> 0 AndAlso ActiveMDIForm.ClientRectangle.Contains(e.X, e.Y) Then
					popupMenu1.ShowPopup(Control.MousePosition)
				End If
			End If
		End Sub

		Private Sub ImageMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If IsActiveImageForm AndAlso sender.Equals(ActivePictureEdit) Then
				If (e.Button And MouseButtons.Right) <> 0 AndAlso ActiveMDIForm.ClientRectangle.Contains(e.X, e.Y) Then
					popupMenu2.ShowPopup(Control.MousePosition)
				End If
			End If
		End Sub

		Private Sub CreateMDITextForm(ByVal s As String)
			Dim frm As Form = New XtraForm()
			frm.Text = New System.IO.FileInfo(s).Name
			frm.Tag = s
			frm.AccessibleName = textFormName
			Dim rtb As RichTextBox = New RichTextBox()
			rtb.Dock = DockStyle.Fill
			rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
			rtb.HideSelection = False
			AddHandler rtb.SelectionChanged, AddressOf RTBSelectionChanged
			AddHandler rtb.MouseUp, AddressOf RTBMouseUp
			Try
				rtb.LoadFile(s)
				frm.AccessibleDescription = textRTFFormName
			Catch
				rtb.LoadFile(s, RichTextBoxStreamType.PlainText)
			End Try

			frm.Controls.Add(rtb)
			frm.MdiParent = Me
			frm.Show()
		End Sub

		Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
			InitBars()
		End Sub

		Private Sub iClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClose.ItemClick
			If ActiveMDIForm IsNot Nothing Then
				ActiveMDIForm.Close()
			End If
		End Sub

		Private Sub FlipRotate(ByVal type As RotateFlipType)
			If IsActiveImageForm Then
				currentCursor = Cursor.Current
				Cursor.Current = Cursors.WaitCursor

				Dim image As Image = TryCast(ActivePictureEdit.Image.Clone(), Image)
				image.RotateFlip(type)
				ActivePictureEdit.Image = image

				UpdateMdiPictureFormPreview(Me.xtraTabbedMdiManager1.SelectedPage, image)

				Cursor.Current = currentCursor
			End If
		End Sub

		Private Sub iHorizontalFlip_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iHorizontalFlip.ItemClick
			FlipRotate(RotateFlipType.RotateNoneFlipX)
		End Sub

		Private Sub iVerticalFlip_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iVerticalFlip.ItemClick
			FlipRotate(RotateFlipType.RotateNoneFlipY)
		End Sub

		Private Sub iRotateBy90_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iRotateBy90.ItemClick
			FlipRotate(RotateFlipType.Rotate90FlipNone)
		End Sub

		Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
			Close()
		End Sub

		Private Sub PictureAlignmentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles alignmentControl1.AlignmentChanged
			If ActivePictureEdit IsNot Nothing Then
				ActivePictureEdit.Properties.PictureAlignment = alignmentControl1.Alignment
			End If
		End Sub

		Private Sub popupControlContainer1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles popupControlContainer1.Popup
			If ActivePictureEdit Is Nothing Then
			Return
			End If
			alignmentControl1.Alignment = ActivePictureEdit.Properties.PictureAlignment
		End Sub

		Private Sub iCascade_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCascade.ItemClick
			Me.LayoutMdi(MdiLayout.Cascade)
		End Sub

		Private Sub iTileHorizontal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iTileHorizontal.ItemClick
			Me.LayoutMdi(MdiLayout.TileHorizontal)
		End Sub

		Private Sub iTileVertical_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iTileVertical.ItemClick
			Me.LayoutMdi(MdiLayout.TileVertical)
		End Sub

		Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iWeb.ItemClick
			Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
			process.StartInfo.FileName = "http://www.devexpress.com"
			process.StartInfo.Verb = "Open"
			process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
			process.Start()
		End Sub

		Private Sub iCut_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCut.ItemClick
			If ActiveRichTextBox IsNot Nothing Then
				ActiveRichTextBox.Cut()
			End If
		End Sub

		Private Sub iCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCopy.ItemClick
			If ActiveRichTextBox IsNot Nothing Then
				ActiveRichTextBox.Copy()
			End If
		End Sub

		Private Sub iPaste_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPaste.ItemClick
			If ActiveRichTextBox IsNot Nothing Then
				ActiveRichTextBox.Paste()
			End If
		End Sub

		Private Sub iSelectAll_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSelectAll.ItemClick
			If ActiveRichTextBox IsNot Nothing Then
				ActiveRichTextBox.SelectAll()
			End If
		End Sub

		Private Sub iFont_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFont.ItemClick
			Dim rtb As RichTextBox = ActiveRichTextBox
			If rtb Is Nothing OrElse (Not IsActiveTextRTFForm) Then
			Return
			End If
			Dim dlg As FontDialog = New FontDialog()
			dlg.Font = CType(rtb.SelectionFont.Clone(), Font)
			dlg.ShowColor = True
			dlg.Color = rtb.SelectionColor
			If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				rtb.SelectionFont = CType(dlg.Font.Clone(), Font)
				rtb.SelectionColor = dlg.Color
				InitEdit()
			End If
		End Sub

		Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
            BarManager.About()
        End Sub

		Private Sub colorEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorEdit.EditValueChanged
			Dim rtb As RichTextBox = ActiveRichTextBox
			If rtb Is Nothing OrElse lockUpdate <> 0 Then
			Return
			End If
			rtb.SelectionColor = CType(colorEdit.EditValue, Color)
		End Sub

		Private Sub sizeMode_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sizeMode.EditValueChanged
			If ActivePictureEdit Is Nothing OrElse lockUpdate <> 0 Then
			Return
			End If
			ActivePictureEdit.Properties.SizeMode = CType(sizeMode.EditValue, PictureSizeMode)
		End Sub

		Private Sub ips_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ipsDefault.ItemClick, ipsWXP.ItemClick, ipsOXP.ItemClick, ipsO2K.ItemClick, ipsO2003.ItemClick
			barManager1.GetController().PaintStyleName = e.Item.Description
			InitPaintStyle(e.Item)
			barManager1.GetController().ResetStyleDefaults()
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetDefaultStyle()
		End Sub

		Private Sub InitPaintStyle(ByVal item As BarItem)
			If item Is Nothing Then
			Return
			End If
			iPaintStyle.ImageIndex = item.ImageIndex
			iPaintStyle.Caption = item.Caption
			iPaintStyle.Hint = item.Description
		End Sub

		Private Sub ips_Init()
			Dim item As BarItem = Nothing
			For i As Integer = 0 To barManager1.Items.Count - 1
				If barManager1.Items(i).Description = barManager1.GetController().PaintStyleName Then
					item = barManager1.Items(i)
				End If
			Next i
			InitPaintStyle(item)
		End Sub

		Private Sub ChangedController(ByVal sender As Object, ByVal e As EventArgs)
			Dim paintStyleName As String = barManager1.GetController().PaintStyleName
			If "Office2000OfficeXPWindowsXP".IndexOf(paintStyleName) >= 0 Then
				barManager1.Images = imageList2
			Else
				barManager1.Images = imageList1
			End If
		End Sub

		Private ReadOnly Property IsTabbedMdi() As Boolean
			Get
				Return biTabbedMDI.Down
			End Get
		End Property

        Private Sub InitTabbedMDI()
            If (IsTabbedMdi) Then
                xtraTabbedMdiManager1.MdiParent = Me
                iCascade.Visibility = BarItemVisibility.Never
                iTileHorizontal.Visibility = BarItemVisibility.Never
                iTileVertical.Visibility = BarItemVisibility.Never
            Else
                xtraTabbedMdiManager1.MdiParent = Nothing
                iCascade.Visibility = BarItemVisibility.Always
                iTileHorizontal.Visibility = BarItemVisibility.Always
                iTileVertical.Visibility = BarItemVisibility.Always
            End If
        End Sub

		Private Sub biTabbedMDI_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles biTabbedMDI.ItemClick
			InitTabbedMDI()
		End Sub

		Private Sub xtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles xtraTabbedMdiManager1.PageAdded
			Dim pictureEdit As PictureEdit = GetPictureEdit(e.Page.MdiChild)
			Dim image As Image
			If (pictureEdit Is Nothing) Then
				image = Nothing
			Else
				image = pictureEdit.Image
			End If
			UpdateMdiPictureFormPreview(e.Page, image)
		End Sub
	End Class
End Namespace
