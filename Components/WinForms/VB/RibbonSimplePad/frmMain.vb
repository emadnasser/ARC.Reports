Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Tutorials.Controls
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Taskbar
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Skins
Imports DevExpress.Utils.Colors
Imports DevExpress.XtraEditors.ColorWheel
Imports DevExpress.XtraEditors.Popup
Imports System.Collections.Generic
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraPrinting
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Microsoft.VisualBasic

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad
	Partial Public Class frmMain
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm

		Public Shared FileNames As String = "RibbonMRUFiles.ini"
		Public Shared FolderNames As String = "RibbonMRUFolders.ini"
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            CreateColorPopup(popupControlContainer1)
            InitSkinGallery()
            InitFontGallery()
            InitColorGallery()
            InitEditors()
            InitSchemeCombo()
            InitPrint()
            AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf OnLookAndFeelStyleChanged
            UserLookAndFeel.Default.SetSkinStyle("Office 2013")
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			SplashScreenManager.CloseForm(False)
		End Sub
		Protected Overrides Sub OnShown(ByVal e As EventArgs)
			MyBase.OnShown(e)
		End Sub
		Private Sub OnLookAndFeelStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateSchemeCombo()
		End Sub
		Private Sub InitSchemeCombo()
			For Each obj As Object In System.Enum.GetValues(GetType(RibbonControlColorScheme))
				repositoryItemComboBox1.Items.Add(obj)
			Next obj
			beScheme.EditValue = RibbonControlColorScheme.Yellow
		End Sub

		Private documentIndex As Integer = 0
		Private pc As PopupColor
		Private dlgFind As frmFind = Nothing
		Private dlgReplace As frmReplace = Nothing
		Private fCurrentFontItem, fCurrentColorItem As GalleryItem
		Private ReadOnly Property DocumentName() As String
			Get
				Return String.Format("New Document {0}", documentIndex)
			End Get
		End Property

		Private Sub CreateNewDocument()
			CreateNewDocument(Nothing)
		End Sub
		Private Sub InitEditors()
			riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
			riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
			riicStyle.Items.Add(New ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1))
			riicStyle.Items.Add(New ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1))
			riicStyle.Items.Add(New ImageComboBoxItem("TabletOffice", RibbonControlStyle.TabletOffice, -1))
			riicStyle.Items.Add(New ImageComboBoxItem("OfficeUniversal", RibbonControlStyle.OfficeUniversal, -1))
			biStyle.EditValue = ribbonControl1.RibbonStyle
		End Sub
		Public Sub ShowHideFormatCategory()
			Dim selectionCategory As RibbonPageCategory = TryCast(Ribbon.PageCategories(0), RibbonPageCategory)
			If selectionCategory Is Nothing Then
				Return
			End If
			If CurrentRichTextBox Is Nothing Then
				selectionCategory.Visible = False
			Else
				selectionCategory.Visible = CurrentRichTextBox.SelectionLength <> 0
			End If
			If selectionCategory.Visible Then
				Ribbon.SelectedPage = selectionCategory.Pages(0)
			End If
		End Sub
		Private Sub CreateNewDocument(ByVal fileName As String)
			documentIndex += 1
			Dim pad As New frmPad()
			If fileName IsNot Nothing Then
				pad.LoadDocument(fileName)
			Else
				pad.DocName = DocumentName
			End If
			pad.MdiParent = Me
			AddHandler pad.Closed, AddressOf Pad_Closed
			AddHandler pad.ShowPopupMenu, AddressOf Pad_ShowPopupMenu
			AddHandler pad.ShowMiniToolbar, AddressOf pad_ShowMiniToolbar
			pad.Show()
			InitNewDocument(pad.RTBMain)
		End Sub

		Private Sub pad_ShowMiniToolbar(ByVal sender As Object, ByVal e As EventArgs)
			If String.IsNullOrEmpty(DirectCast(sender, RichTextBox).SelectedText) Then
				Return
			End If
			ShowSelectionMiniToolbar()
		End Sub

		Private Sub Pad_Closed(ByVal sender As Object, ByVal e As EventArgs)
			CloseFind()
		End Sub
		Private Sub Pad_ShowPopupMenu(ByVal sender As Object, ByVal e As EventArgs)
			pmMain.RibbonToolbar = selectionMiniToolbar
			pmMain.ShowPopup(Control.MousePosition)
		End Sub
		Private Sub CloseFind()
			If dlgFind IsNot Nothing AndAlso dlgFind.RichText IsNot CurrentRichTextBox Then
				dlgFind.Close()
				dlgFind = Nothing
			End If
			If dlgReplace IsNot Nothing AndAlso dlgReplace.RichText IsNot CurrentRichTextBox Then
				dlgReplace.Close()
				dlgReplace = Nothing
			End If
		End Sub

		Private Sub CreateColorPopup(ByVal container As PopupControlContainer)
			pc = New PopupColor(container, Me)
		End Sub
		#Region "Init"
		Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
			InitPaste()
		End Sub
		Public Sub UpdateText()
			ribbonControl1.ApplicationCaption = "Ribbon Simple Pad"
			ribbonControl1.ApplicationDocumentCaption = CurrentDocName & (If(CurrentModified, "*", ""))
			'Text = string.Format("Ribbon Simple Pad ({0})", CurrentDocName);
			siDocName.Caption = String.Format("  {0}", CurrentDocName)
		End Sub
		Private Sub ChangeActiveForm()
			UpdateText()
			InitCurrentDocument(CurrentRichTextBox)
			rtPad_SelectionChanged(CurrentRichTextBox, EventArgs.Empty)
			CloseFind()
		End Sub
		Private Sub xtraTabbedMdiManager1_FloatMDIChildActivated(ByVal sender As Object, ByVal e As EventArgs) Handles xtraTabbedMdiManager1.FloatMDIChildActivated
			ChangeActiveForm()
		End Sub
		Private Sub xtraTabbedMdiManager1_FloatMDIChildDeactivated(ByVal sender As Object, ByVal e As EventArgs) Handles xtraTabbedMdiManager1.FloatMDIChildDeactivated
			BeginInvoke(New MethodInvoker(AddressOf ChangeActiveForm))
		End Sub
		Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
			ChangeActiveForm()
		End Sub
		Private Sub rtPad_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			ShowHideFormatCategory()
			Dim rtPad As RichTextBox = TryCast(sender, RichTextBox)
			InitFormat()
			Dim line As Integer = 0, col As Integer = 0

			If rtPad IsNot Nothing Then
				InitEdit(rtPad.SelectionLength > 0)
				line = rtPad.GetLineFromCharIndex(rtPad.SelectionStart) + 1
				col = rtPad.SelectionStart + 1
			Else
				InitEdit(False)
			End If
			siPosition.Caption = String.Format("   Line: {0}  Position: {1}   ", line, col)
			CurrentFontChanged()
		End Sub

		Protected Overridable Sub ShowSelectionMiniToolbar()
			Dim pt As Point = Control.MousePosition
			pt.Offset(0, -11)
			selectionMiniToolbar.Alignment = ContentAlignment.TopRight
			selectionMiniToolbar.PopupMenu = Nothing
			selectionMiniToolbar.Show(pt)
		End Sub
		Private Sub rtPad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			If CurrentForm Is Nothing Then
				Return
			End If
			CurrentForm.Modified = True
			InitCurrentDocument(CurrentRichTextBox)
		End Sub

		Protected Sub InitFormat()
			iBold.Enabled = SelectFont IsNot Nothing
			iItalic.Enabled = SelectFont IsNot Nothing
			iUnderline.Enabled = SelectFont IsNot Nothing
			iFont.Enabled = SelectFont IsNot Nothing
			iFontColor.Enabled = SelectFont IsNot Nothing
			If SelectFont IsNot Nothing Then
				iBold.Down = SelectFont.Bold
				iItalic.Down = SelectFont.Italic
				iUnderline.Down = SelectFont.Underline
			End If
			Dim enabled As Boolean = CurrentRichTextBox IsNot Nothing
			iProtected.Enabled = enabled
			iBullets.Enabled = enabled
			iAlignLeft.Enabled = enabled
			iAlignRight.Enabled = enabled
			iCenter.Enabled = enabled
			rgbiFont.Enabled = enabled
			rgbiFontColor.Enabled = enabled
			ribbonPageGroup9.ShowCaptionButton = enabled
			rpgFont.ShowCaptionButton = enabled
			rpgFontColor.ShowCaptionButton = enabled
			If Not enabled Then
				ClearFormats()
			End If
			If CurrentRichTextBox IsNot Nothing Then
				iProtected.Down = CurrentRichTextBox.SelectionProtected
				iBullets.Down = CurrentRichTextBox.SelectionBullet
				Select Case CurrentRichTextBox.SelectionAlignment
					Case HorizontalAlignment.Left
						iAlignLeft.Down = True
					Case HorizontalAlignment.Center
						iCenter.Down = True
					Case HorizontalAlignment.Right
						iAlignRight.Down = True
				End Select
			End If
		End Sub

		Private Sub ClearFormats()
			iBold.Down = False
			iItalic.Down = False
			iUnderline.Down = False
			iProtected.Down = False
			iBullets.Down = False
			iAlignLeft.Down = False
			iAlignRight.Down = False
			iCenter.Down = False
		End Sub

		Protected Sub InitPaste()
			Dim enabledPase As Boolean = CurrentRichTextBox IsNot Nothing AndAlso CurrentRichTextBox.CanPaste(DataFormats.GetFormat(0))
			iPaste.Enabled = enabledPase
			sbiPaste.Enabled = enabledPase
		End Sub

		Private Sub InitUndo()
			iUndo.Enabled = If(CurrentRichTextBox IsNot Nothing, CurrentRichTextBox.CanUndo, False)
			iLargeUndo.Enabled = iUndo.Enabled
		End Sub
		Protected Sub InitEdit(ByVal enabled As Boolean)
			iCut.Enabled = enabled
			iCopy.Enabled = enabled
			iClear.Enabled = enabled
			iSelectAll.Enabled = If(CurrentRichTextBox IsNot Nothing, CurrentRichTextBox.CanSelect, False)
			InitUndo()
		End Sub

		Private Sub InitNewDocument(ByVal rtbControl As RichTextBox)
			AddHandler rtbControl.SelectionChanged, AddressOf rtPad_SelectionChanged
			AddHandler rtbControl.TextChanged, AddressOf rtPad_TextChanged
		End Sub

		Private Sub InitCurrentDocument(ByVal rtbControl As RichTextBox)
			Dim enabled As Boolean = rtbControl IsNot Nothing
			iSaveAs.Enabled = enabled
			iClose.Enabled = enabled
			iPrint.Enabled = enabled
			sbiSave.Enabled = enabled
			sbiFind.Enabled = enabled
			iFind.Enabled = enabled
			iReplace.Enabled = enabled
			iSave.Enabled = CurrentModified
			SetModifiedCaption()
			InitPaste()
			InitFormat()
		End Sub

		Private Sub SetModifiedCaption()
			If CurrentForm Is Nothing Then
				siModified.Caption = ""
				Return
			End If
			siModified.Caption = If(CurrentModified, "   Modified   ", "")
		End Sub
		#End Region
		#Region "Properties"
		Private ReadOnly Property CurrentForm() As frmPad
			Get
				If Me.ActiveMdiChild Is Nothing Then
					Return Nothing
				End If
				If xtraTabbedMdiManager1.ActiveFloatForm IsNot Nothing Then
					Return TryCast(xtraTabbedMdiManager1.ActiveFloatForm, frmPad)
				End If
				Return TryCast(Me.ActiveMdiChild, frmPad)
			End Get
		End Property

		Public ReadOnly Property CurrentRichTextBox() As RichTextBox
			Get
				If CurrentForm Is Nothing Then
					Return Nothing
				End If
				Return CurrentForm.RTBMain
			End Get
		End Property

		Private ReadOnly Property CurrentDocName() As String
			Get
				If CurrentForm Is Nothing Then
					Return ""
				End If
				Return CurrentForm.DocName
			End Get
		End Property

		Private ReadOnly Property CurrentModified() As Boolean
			Get
				If CurrentForm Is Nothing Then
					Return False
				End If
				Return CurrentForm.Modified
			End Get
		End Property
		#End Region
		#Region "File"
		Private Sub idNew_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles idNew.ItemClick, iNew.ItemClick
			CreateNewDocument()
		End Sub

		Private Sub iClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClose.ItemClick
			If CurrentForm IsNot Nothing Then
				CurrentForm.Close()
			End If
		End Sub

		Private Sub OpenFile()
			OpenFileFolder(String.Empty)
		End Sub

		Public Sub OpenFile(ByVal name As String)
			CreateNewDocument(name)
			AddToMostRecentFiles(name, arMRUList)
			AddToMostRecentFiles(name, Nothing)
			AddToMostRecentFolders(name, Nothing)
		End Sub
		Private Sub AddToMostRecentFiles(ByVal name As String, ByVal arMRUList As MRUArrayList)
			If arMRUList IsNot Nothing Then
				arMRUList.InsertElement(name)
			End If
			Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
			If CheckForOverlap(pinItem, recentTabItem1.TabPanel.Items) Then
				Return
			End If
			recentTabItem1.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem1.TabPanel), pinItem)
		End Sub

		Private Function CheckForOverlap(ByVal pinItem As RecentPinItem, ByVal recentItemCollection As RecentItemCollection) As Boolean
			For Each item As RecentItemBase In recentItemCollection
				Dim pItem As RecentPinItem = TryCast(item, RecentPinItem)
				If pItem IsNot Nothing AndAlso pinItem.Caption = pItem.Caption AndAlso pinItem.Description = pItem.Description Then
					Return True
				End If
			Next item
			Return False
		End Function
		Private Sub AddToMostRecentFolders(ByVal name As String, ByVal arMRUList As MRUArrayList)
			If arMRUList IsNot Nothing Then
				name = Path.GetFullPath(name)
				arMRUList.InsertElement(Path.GetDirectoryName(name))
			End If
			name = Path.GetDirectoryName(Path.GetFullPath(name))
			Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
			If CheckForOverlap(pinItem, recentTabItem2.TabPanel.Items) Then
				Return
			End If
			Dim pinItem_ As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = False}
			recentTabItem2.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem2.TabPanel), pinItem)
			recentTabItem3.TabPanel.Items.Insert(FindFirstUnCheckedIntemIndex(recentTabItem3.TabPanel), pinItem_)
		End Sub

		Private Sub iOpen_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iOpen.ItemClick
			OpenFile()
		End Sub

		Private Sub iPrint_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPrint.ItemClick
			XtraMessageBox.Show(Me, "Note that you can use the XtraPrinting Library to print the contents of the standard RichTextBox control." & ControlChars.CrLf & "For more information, see the main XtraPrinting demo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Sub

		Private Sub iSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSave.ItemClick
			Save()
		End Sub
		Private Sub iSaveAs_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSaveAs.ItemClick
			SaveAs()
		End Sub
		Private Sub Save()
			If CurrentForm Is Nothing Then
				Return
			End If
			If CurrentForm.NewDocument Then
				SaveAs()
			Else
				CurrentRichTextBox.SaveFile(CurrentDocName, RichTextBoxStreamType.RichText)
				CurrentForm.Modified = False
			End If
			SetModifiedCaption()
		End Sub
		Private Sub SaveAs()
			SaveAs(String.Empty)
		End Sub
		Private Sub SaveAs(ByVal path As String)
			If CurrentForm IsNot Nothing Then
				Dim s As String = CurrentForm.SaveAs(path)
				If s <> String.Empty Then
					AddToMostRecentFiles(s, arMRUList)
					AddToMostRecentFiles(s, Nothing)
					AddToMostRecentFolders(s, Nothing)
				End If
				UpdateText()
			End If
		End Sub
		Private Sub iExit_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
			Close()
		End Sub
		Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		End Sub
		Private Sub ribbonPageGroup1_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup1.CaptionButtonClick
			OpenFile()
		End Sub

		Private Sub ribbonPageGroup9_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup9.CaptionButtonClick
			SaveAs()
		End Sub
		#End Region
		#Region "Format"
		Private Function rtPadFontStyle() As FontStyle
			Dim fs As New FontStyle()
			If iBold.Down Then
				fs = fs Or FontStyle.Bold
			End If
			If iItalic.Down Then
				fs = fs Or FontStyle.Italic
			End If
			If iUnderline.Down Then
				fs = fs Or FontStyle.Underline
			End If
			Return fs
		End Function

		Private Sub iBullets_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBullets.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionBullet = iBullets.Down
			InitUndo()
		End Sub

		Private Sub iFontStyle_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iBold.ItemClick, iItalic.ItemClick, iUnderline.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionFont = New Font(SelectFont, rtPadFontStyle())
		End Sub

		Private Sub iProtected_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iProtected.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionProtected = iProtected.Down
		End Sub

		Private Sub iAlign_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCenter.ItemClick, iAlignLeft.ItemClick, iAlignRight.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			If iAlignLeft.Down Then
				CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Left
			End If
			If iCenter.Down Then
				CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Center
			End If
			If iAlignRight.Down Then
				CurrentRichTextBox.SelectionAlignment = HorizontalAlignment.Right
			End If
			InitUndo()
		End Sub


		Protected ReadOnly Property SelectFont() As Font
			Get
				If CurrentRichTextBox IsNot Nothing Then
					Return CurrentRichTextBox.SelectionFont
				End If
				Return Nothing
			End Get
		End Property
		Private Sub ShowFontDialog()
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			Dim dialogFont As Font = Nothing
			If SelectFont IsNot Nothing Then
				dialogFont = DirectCast(SelectFont.Clone(), Font)
			Else
				dialogFont = CurrentRichTextBox.Font
			End If
			Dim dlg As New XtraFontDialog(dialogFont)
			If dlg.ShowDialog() = DialogResult.OK Then
				CurrentRichTextBox.SelectionFont = dlg.ResultFont
				beiFontSize.EditValue = dlg.ResultFont.Size
			End If
		End Sub
		Private Sub iFont_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFont.ItemClick
			ShowFontDialog()
		End Sub
		Private Sub iFontColor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFontColor.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionColor = DirectCast(pc, IPopupColorPickEdit).Color
		End Sub
		#End Region
		#Region "Edit"
		Private Sub iUndo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iUndo.ItemClick, iLargeUndo.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.Undo()
			CurrentForm.Modified = CurrentRichTextBox.CanUndo
			SetModifiedCaption()
			InitUndo()
			InitFormat()
		End Sub

		Private Sub iCut_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCut.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.Cut()
			InitPaste()
		End Sub

		Private Sub iCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iCopy.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.Copy()
			InitPaste()
		End Sub

		Private Sub iPaste_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iPaste.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.Paste()
		End Sub

		Private Sub iClear_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iClear.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectedRtf = ""
		End Sub

		Private Sub iSelectAll_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iSelectAll.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectAll()
		End Sub
		Private Sub ribbonPageGroup2_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles ribbonPageGroup2.CaptionButtonClick
			pmMain.ShowPopup(ribbonControl1.Manager, MousePosition)
		End Sub
		#End Region
		#Region "SkinGallery"
		Private Sub InitSkinGallery()
			DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, True)
		End Sub
		#End Region
		#Region "FontGallery"
		Private Function GetFontImage(ByVal width As Integer, ByVal height As Integer, ByVal fontName As String, ByVal fontSize As Integer) As Image
			Dim rect As New Rectangle(0, 0, width, height)
			Dim fontImage As Image = New Bitmap(width, height)
			Try
				Using fontSample As New Font(fontName, fontSize)
					Dim g As Graphics = Graphics.FromImage(fontImage)
					g.FillRectangle(Brushes.White, rect)
					Using fs As New StringFormat()
						fs.Alignment = StringAlignment.Center
						fs.LineAlignment = StringAlignment.Center
						'g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
						g.DrawString("Aa", fontSample, Brushes.Black, rect, fs)
						g.Dispose()
					End Using
				End Using
			Catch
			End Try
			Return fontImage
		End Function
		Private Sub InitFont(ByVal groupDropDown As GalleryItemGroup, ByVal galleryGroup As GalleryItemGroup)
			Dim fonts() As FontFamily = FontFamily.Families
			For i As Integer = 0 To fonts.Length - 1
				If Not FontFamily.Families(i).IsStyleAvailable(FontStyle.Regular) Then
					Continue For
				End If
				Dim fontName As String = fonts(i).Name
				Dim item As New GalleryItem()
				item.Caption = fontName
				item.Image = GetFontImage(40, 40, fontName, 16)
				item.HoverImage = item.Image
				item.Description = fontName
				item.Hint = fontName
				Try
					item.Tag = New Font(fontName, 9)
					If DevExpress.Utils.ControlUtils.IsSymbolFont(CType(item.Tag, Font)) Then
						item.Tag = New Font(DevExpress.Utils.AppearanceObject.DefaultFont.FontFamily, 9)
						item.Description &= " (Symbol Font)"
					End If
				Catch
					Continue For
				End Try
				groupDropDown.Items.Add(item)
				galleryGroup.Items.Add(item)
			Next i
		End Sub
		Private Sub InitFontGallery()
			gddFont.Gallery.BeginUpdate()
			rgbiFont.Gallery.BeginUpdate()
			Try
				InitFont(gddFont.Gallery.Groups(0), rgbiFont.Gallery.Groups(0))
			Finally
				gddFont.Gallery.EndUpdate()
				rgbiFont.Gallery.EndUpdate()
			End Try
			beiFontSize.EditValue = 8
		End Sub
		Private Sub SetFont(ByVal fontName As String, ByVal item As GalleryItem)
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionFont = New Font(fontName, Convert.ToInt32(beiFontSize.EditValue), rtPadFontStyle())
			If item IsNot Nothing Then
				CurrentFontItem = item
			End If
		End Sub
		Private Sub gddFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles gddFont.GalleryItemClick
			SetFont(e.Item.Caption, e.Item)
		End Sub
		Private Sub rpgFont_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgFont.CaptionButtonClick
			ShowFontDialog()
		End Sub
		Private Sub rgbiFont_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiFont.Gallery.ItemClick
			SetFont(e.Item.Caption, e.Item)
		End Sub
		Private Sub gddFont_Gallery_CustomDrawItemText(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs) Handles gddFont.GalleryCustomDrawItemText
			Dim itemInfo As DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo = TryCast(e.ItemInfo, DevExpress.XtraBars.Ribbon.ViewInfo.GalleryItemViewInfo)
			itemInfo.PaintAppearance.ItemDescriptionAppearance.Normal.DrawString(e.Cache, e.Item.Description, itemInfo.DescriptionBounds)
			Dim app As AppearanceObject = TryCast(itemInfo.PaintAppearance.ItemCaptionAppearance.Normal.Clone(), AppearanceObject)
			app.Font = CType(e.Item.Tag, Font)
			Try
				e.Cache.Graphics.DrawString(e.Item.Caption, app.Font, app.GetForeBrush(e.Cache), itemInfo.CaptionBounds)
			Catch
			End Try
			e.Handled = True
		End Sub
		#End Region
		#Region "ColorGallery"
		Private Sub InitColorGallery()
			gddFontColor.BeginUpdate()
			For Each color As Color In DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.WebColors
                If color = color.Transparent Then
                    Continue For
                End If
				Dim item As New GalleryItem()
				item.Caption = color.Name
				item.Tag = color
				item.Hint = color.Name
				gddFontColor.Gallery.Groups(0).Items.Add(item)
				rgbiFontColor.Gallery.Groups(0).Items.Add(item)
			Next color
			For Each color As Color In DevExpress.XtraEditors.Popup.ColorListBoxViewInfo.SystemColors
				Dim item As New GalleryItem()
				item.Caption = color.Name
				item.Tag = color
				gddFontColor.Gallery.Groups(1).Items.Add(item)
			Next color
			gddFontColor.EndUpdate()
		End Sub
		Private Sub gddFontColor_Gallery_CustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs) Handles gddFontColor.GalleryCustomDrawItemImage, rgbiFontColor.Gallery.CustomDrawItemImage
			Dim clr As Color = CType(e.Item.Tag, Color)
			Using brush As Brush = New SolidBrush(clr)
				e.Cache.FillRectangle(brush, e.Bounds)
				e.Handled = True
			End Using
		End Sub
		Private Sub SetResultColor(ByVal color As Color, ByVal item As GalleryItem)
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			CurrentRichTextBox.SelectionColor = color
			If item IsNot Nothing Then
				CurrentColorItem = item
			End If
		End Sub
		Private Sub gddFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles gddFontColor.GalleryItemClick
			SetResultColor(CType(e.Item.Tag, Color), e.Item)
		End Sub
		Private Sub rpgFontColor_CaptionButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs) Handles rpgFontColor.CaptionButtonClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			If pc Is Nothing Then
				CreateColorPopup(popupControlContainer1)
			End If
			popupControlContainer1.ShowPopup(ribbonControl1.Manager, MousePosition)
		End Sub

		Private Sub rgbiFontColor_Gallery_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles rgbiFontColor.Gallery.ItemClick
			SetResultColor(CType(e.Item.Tag, Color), e.Item)
		End Sub
		#End Region

		Private Sub iFind_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iFind.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			If dlgReplace IsNot Nothing Then
				dlgReplace.Close()
			End If
			If dlgFind IsNot Nothing Then
				dlgFind.Close()
			End If
			dlgFind = New frmFind(CurrentRichTextBox, Bounds)
			AddOwnedForm(dlgFind)
			dlgFind.Show()
		End Sub

		Private Sub iReplace_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iReplace.ItemClick
			If CurrentRichTextBox Is Nothing Then
				Return
			End If
			If dlgReplace IsNot Nothing Then
				dlgReplace.Close()
			End If
			If dlgFind IsNot Nothing Then
				dlgFind.Close()
			End If
			dlgReplace = New frmReplace(CurrentRichTextBox, Bounds)
			AddOwnedForm(dlgReplace)
			dlgReplace.Show()
		End Sub

        Private Sub iWeb_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iWeb.ItemClick
            Try
                Dim process As New Process()
                process.StartInfo.FileName = "http://www.devexpress.com"
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                process.Start()
            Catch
            End Try
        End Sub

		Private Sub iAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles iAbout.ItemClick
			BarManager.About()
		End Sub

		Private Function TextByCaption(ByVal caption As String) As String
			Return caption.Replace("&", "")
		End Function

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitMostRecentFiles()
			arMRUList = New MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images(0), imageCollection3.Images(1))
			AddHandler arMRUList.LabelClicked, AddressOf OnMRUFileLabelClicked
			InitMostRecentFiles(arMRUList)
			ribbonControl1.ForceInitialize()
			Dim skins As New GalleryDropDown()
			skins.Ribbon = ribbonControl1
			DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins)
			iPaintStyle.DropDownControl = skins
			CreateNewDocument()
            'barEditItem1.EditValue = CType(DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraBars.Demos.RibbonSimplePad.online.gif", GetType(frmMain).Assembly), Bitmap)
		End Sub

		Private Sub InitMostRecentFiles(ByVal arMRUList As MRUArrayList)
			Dim fileName As String = Application.StartupPath & "\" & MRUArrayList.MRUFileName
			arMRUList.Init(fileName, "Document1.rtf")

		End Sub
		#Region "GalleryItemsChecked"

		Private Function GetColorItemByColor(ByVal color As Color, ByVal gallery As BaseGallery) As GalleryItem
			For Each galleryGroup As GalleryItemGroup In gallery.Groups
				For Each item As GalleryItem In galleryGroup.Items
					If item.Caption = color.Name Then
						Return item
					End If
				Next item
			Next galleryGroup
			Return Nothing
		End Function
		Private Function GetFontItemByFont(ByVal fontName As String, ByVal gallery As BaseGallery) As GalleryItem
			For Each galleryGroup As GalleryItemGroup In gallery.Groups
				For Each item As GalleryItem In galleryGroup.Items
					If item.Caption = fontName Then
						Return item
					End If
				Next item
			Next galleryGroup
			Return Nothing
		End Function
		Private Property CurrentFontItem() As GalleryItem
			Get
				Return fCurrentFontItem
			End Get
			Set(ByVal value As GalleryItem)
				If fCurrentFontItem Is value Then
					Return
				End If
				If fCurrentFontItem IsNot Nothing Then
					fCurrentFontItem.Checked = False
				End If
				fCurrentFontItem = value
				If fCurrentFontItem IsNot Nothing Then
					fCurrentFontItem.Checked = True
					MakeFontVisible(fCurrentFontItem)
				End If
			End Set
		End Property
		Private Sub MakeFontVisible(ByVal item As GalleryItem)
			gddFont.Gallery.MakeVisible(fCurrentFontItem)
			rgbiFont.Gallery.MakeVisible(fCurrentFontItem)
		End Sub
		Private Property CurrentColorItem() As GalleryItem
			Get
				Return fCurrentColorItem
			End Get
			Set(ByVal value As GalleryItem)
				If fCurrentColorItem Is value Then
					Return
				End If
				If fCurrentColorItem IsNot Nothing Then
					fCurrentColorItem.Checked = False
				End If
				fCurrentColorItem = value
				If fCurrentColorItem IsNot Nothing Then
					fCurrentColorItem.Checked = True
					MakeColorVisible(fCurrentColorItem)
				End If
			End Set
		End Property
		Private Sub MakeColorVisible(ByVal item As GalleryItem)
			gddFontColor.Gallery.MakeVisible(fCurrentColorItem)
			rgbiFontColor.Gallery.MakeVisible(fCurrentColorItem)
		End Sub
		Private Sub CurrentFontChanged()
			If CurrentRichTextBox Is Nothing OrElse CurrentRichTextBox.SelectionFont Is Nothing Then
				Return
			End If
			CurrentFontItem = GetFontItemByFont(CurrentRichTextBox.SelectionFont.Name, rgbiFont.Gallery)
			CurrentColorItem = GetColorItemByColor(CurrentRichTextBox.SelectionColor, rgbiFontColor.Gallery)
		End Sub
		Private Sub gddFont_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles gddFont.Popup
			MakeFontVisible(CurrentFontItem)
            If CurrentRichTextBox Is Nothing Or CurrentRichTextBox.SelectionFont Is Nothing Then
                Return
            End If
			beiFontSize.EditValue = CurrentRichTextBox.SelectionFont.Size
		End Sub

		Private Sub gddFontColor_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles gddFontColor.Popup
			MakeColorVisible(CurrentColorItem)
		End Sub
		#End Region
		#Region "MostRecentFiles"
		Private arMRUList As MRUArrayList = Nothing

		Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			SaveMostRecentFiles(recentTabItem1.TabPanel.Items, Application.StartupPath & "\" & FileNames)
			SaveMostRecentFiles(recentTabItem2.TabPanel.Items, Application.StartupPath & "\" & FolderNames)
		End Sub
		Private Sub InitMostRecentFiles()
			Dim fileName As String = Application.StartupPath & "\" & MRUArrayList.MRUFileName
			Dim folderName As String = Application.StartupPath & "\" & MRUArrayList.MRUFolderName
			InitFiles(fileName, "Document1.rtf", True)
			InitFiles(folderName, Application.StartupPath, False)
		End Sub

		Public Sub InitFiles(ByVal fileName As String, ByVal defaultItem As String, ByVal isFile As Boolean)
			If Not System.IO.File.Exists(fileName) Then
				StartInitFiles(isFile)
				EndInitFiles(isFile)
				'InsertElement(defaultItem, isFile);
				Return
			End If
			Dim sr As System.IO.StreamReader = System.IO.File.OpenText(fileName)
			Dim list As New List(Of String)()
			Dim s As String = sr.ReadLine()
			Do While s IsNot Nothing
				list.Add(s)
				s = sr.ReadLine()
			Loop
			For i As Integer = 0 To list.Count - 1
				InsertElement(list(i), isFile)
			Next i
			sr.Close()
			If Not isFile Then
				CreateButtonBrowse()
			End If
		End Sub

		Private Function FindFirstUnCheckedIntemIndex(ByVal recentPanelBase As RecentPanelBase) As Integer
			For i As Integer = 0 To recentPanelBase.Items.Count - 1
				Dim pinItem As RecentPinItem = TryCast(recentPanelBase.Items(i), RecentPinItem)
				If pinItem Is Nothing Then
					Continue For
				End If
				If Not pinItem.PinButtonChecked Then
					Return i
				End If
			Next i
			Return 0
		End Function
		Private Sub InsertElement(ByVal obj As Object, ByVal isFile As Boolean)
			Dim names() As String = obj.ToString().Split(","c)
			Dim name As String = names(0)
			Dim checkedLabel As Boolean = False
			If names.Length > 1 Then
				checkedLabel = names(1).ToLower().Equals("true")
			End If
			If isFile Then
				Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
				recentTabItem1.TabPanel.Items.Add(pinItem)
			Else
				Dim pinItem As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
				Dim pinItem_ As New RecentPinItem() With {.Caption = GetFileName(name), .Description = name, .PinButtonChecked = checkedLabel}
				recentTabItem2.TabPanel.Items.Add(pinItem)
				recentTabItem3.TabPanel.Items.Add(pinItem_)
			End If
		End Sub
		Private Sub CreateButtonBrowse()
			Dim hyperlinkBrowse As New RecentHyperlinkItem() With {.Caption = "Browse..."} ', Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			recentTabItem2.TabPanel.Items.Add(hyperlinkBrowse)
			AddHandler hyperlinkBrowse.ItemClick, AddressOf hyperlinkBrowse_ItemClick
			Dim hyperlinkBrowse1 As New RecentHyperlinkItem() With {.Caption = "Browse..."} ', Link = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			recentTabItem3.TabPanel.Items.Add(hyperlinkBrowse1)
			AddHandler hyperlinkBrowse1.ItemClick, AddressOf hyperlinkBrowse_ItemClick
		End Sub

		Private Sub hyperlinkBrowse_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs)
			SaveAs()
		End Sub
		Private Sub EndInitFiles(ByVal isFile As Boolean)
			If isFile Then
				InitDefaultFiles()
			Else
				InitDefaultFolders()
			End If
			If Not isFile Then
				CreateButtonBrowse()
			End If
		End Sub
		Private Sub StartInitFiles(ByVal isFile As Boolean)
			If Not isFile Then
				InitStartDefaultFolders()
			End If
		End Sub
		Private Sub InitStartDefaultFolders()
			Dim desktop As New RecentPinItem() With {.Caption = "Desktop", .Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), .PinButtonChecked = True, .ShowDescription = False}
			Dim desktop_ As New RecentPinItem() With {.Caption = "Desktop", .Description = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString(), .PinButtonChecked = True, .ShowDescription = False}
			recentTabItem2.TabPanel.Items.Add(desktop)
			recentTabItem3.TabPanel.Items.Add(desktop_)
			Dim separator As New RecentSeparatorItem()
			Dim separator_ As New RecentSeparatorItem()
			recentTabItem2.TabPanel.Items.Add(separator)
			recentTabItem3.TabPanel.Items.Add(separator_)
		End Sub
		Private Sub InitDefaultFolders()
			Dim item1 As New RecentPinItem() With {.Caption = "MyDocuments", .Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString()}
			Dim item1_ As New RecentPinItem() With {.Caption = "MyDocuments", .Description = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString()}
			recentTabItem2.TabPanel.Items.Add(item1)
			recentTabItem3.TabPanel.Items.Add(item1_)

			Dim item7 As New RecentPinItem() With {.Caption = "Saved HTML Articles", .Description = "D:\Personal\Saved HTML Articles"}
			Dim item7_ As New RecentPinItem() With {.Caption = "Saved HTML Articles", .Description = "D:\Personal\Saved HTML Articles"}
			recentTabItem2.TabPanel.Items.Add(item7)
			recentTabItem3.TabPanel.Items.Add(item7_)

			Dim item3 As New RecentPinItem() With {.Caption = "Tutorials", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
			Dim item3_ As New RecentPinItem() With {.Caption = "Tutorials", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
			recentTabItem2.TabPanel.Items.Add(item3)
			recentTabItem3.TabPanel.Items.Add(item3_)

			Dim item2 As New RecentPinItem() With {.Caption = "Products", .Description = "C:\DevExpress\Products"}
			Dim item2_ As New RecentPinItem() With {.Caption = "Products", .Description = "C:\DevExpress\Products"}
			recentTabItem2.TabPanel.Items.Add(item2)
			recentTabItem3.TabPanel.Items.Add(item2_)

			Dim item8 As New RecentPinItem() With {.Caption = "Win Forms", .Description = "C:\DevExpress\Products\Win Forms"}
			Dim item8_ As New RecentPinItem() With {.Caption = "Win Forms", .Description = "C:\DevExpress\Products\Win Forms"}
			recentTabItem2.TabPanel.Items.Add(item8)
			recentTabItem3.TabPanel.Items.Add(item8_)

			Dim item9 As New RecentPinItem() With {.Caption = "Controls", .Description = "C:\DevExpress\Products\Win Forms\Controls"}
			Dim item9_ As New RecentPinItem() With {.Caption = "Controls", .Description = "C:\DevExpress\Products\Win Forms\Controls"}
			recentTabItem2.TabPanel.Items.Add(item9)
			recentTabItem3.TabPanel.Items.Add(item9_)
		End Sub
		Private Sub InitDefaultFiles()
			Dim item1 As New RecentPinItem() With {.Caption = "Windows 10 GuideLines.doc", .Description = "D:\Personal\Saved HTML Articles"}
			recentTabItem1.TabPanel.Items.Add(item1)
			Dim item2 As New RecentPinItem() With {.Caption = "Web Site Usability.doc", .Description = "C:\Users\Default\Documents"}
			recentTabItem1.TabPanel.Items.Add(item2)
			Dim item3 As New RecentPinItem() With {.Caption = "Getting Started.pdf", .Description = "C:\Program Files x86\DevExpress 15.2\Tutorials"}
			recentTabItem1.TabPanel.Items.Add(item3)
			Dim item4 As New RecentPinItem() With {.Caption = "Office 2013 features.docx", .Description = "C:\DevExpress\Products\Win Forms"}
			recentTabItem1.TabPanel.Items.Add(item4)
			Dim item5 As New RecentPinItem() With {.Caption = "WinForms Webinar.pdf", .Description = "C:\DevExpress\Webinars"}
			recentTabItem1.TabPanel.Items.Add(item5)
		End Sub
		Private Function GetFileName(ByVal obj As Object) As String
			Dim fi As New FileInfo(obj.ToString())
			Return fi.Name
		End Function
		Private Sub recentControlOpen_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs) Handles recentOpen.ItemClick
			Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
			If recentItem IsNot Nothing Then
				ribbonControl1.HideApplicationButtonContentControl()
			End If
			If recentTabItem1.TabPanel.Items.Contains(e.Item) AndAlso recentItem IsNot Nothing Then
				OpenFileCore(recentItem.Description)
			ElseIf recentTabItem2.TabPanel.Items.Contains(e.Item) Then
				If recentItem IsNot Nothing Then
					OpenFileFolder(recentItem.Description)
				End If
			End If
		End Sub
		Private Sub OpenFileFolder(ByVal p As String)
			Dim dlg As New OpenFileDialog()
			If p<> String.Empty Then
				dlg.InitialDirectory = p
			End If
			dlg.Filter = "Rich Text Files (*.rtf)|*.rtf"
			dlg.Title = "Open"
			If dlg.ShowDialog(Me) = DialogResult.OK Then
				OpenFile(dlg.FileName)
			End If
		End Sub
		Private Sub recentControlSave_ItemClick(ByVal sender As Object, ByVal e As RecentItemEventArgs) Handles recentSaveAs.ItemClick
			ribbonControl1.HideApplicationButtonContentControl()
			Dim recentItem As RecentPinItem = TryCast(e.Item, RecentPinItem)
			If recentTabItem3.TabPanel.Items.Contains(e.Item) Then
				If recentItem IsNot Nothing Then
					SaveAs(recentItem.Description)
				End If
			End If
		End Sub
		Private Sub recentControlExport_ItemClick(ByVal sender As Object, ByVal e As Ribbon.RecentItemEventArgs) Handles recentControlExport.ItemClick
			Dim saveFileDialog As New SaveFileDialog()
			saveFileDialog.Title = "Export"
			If Not(TypeOf e.Item Is RecentPinItem) Then
				Return
			End If
			Dim caption As String = (TryCast(e.Item, RecentPinItem)).Caption
			If caption.Contains("PDF") Then
				saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
			ElseIf caption.Contains("HTML") Then
				saveFileDialog.Filter = "HTML files (*.html)|*.html"
			ElseIf caption.Contains("MHT") Then
				saveFileDialog.Filter = "MHT files (*.mht)|*.mht"
			ElseIf caption.Contains("RTF") Then
				saveFileDialog.Filter = "RTF files (*.rtf)|*.rtf"
			ElseIf caption.Contains("XLS") Then
				saveFileDialog.Filter = "XLS files (*.xls)|*.xls"
			ElseIf caption.Contains("XLSX") Then
				saveFileDialog.Filter = "XLSX files (*.xls)|*.xls"
			ElseIf caption.Contains("CSV") Then
				saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
			ElseIf caption.Contains("Text File") Then
				saveFileDialog.Filter = "Text files (*.txt)|*.txt"
			ElseIf caption.Contains("Image") Then
				saveFileDialog.Filter = "BMP files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|Jpeg files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|Tiff files (*.tiff)|*.tiff|EMF files (*.emf)|.emf|WMF files (*.wmf)|*.wmf"
			End If
			saveFileDialog.Filter &= "|All files (*.*)|*.*"
			saveFileDialog.FilterIndex = 0
			If saveFileDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If
			Dim ps As New PrintingSystem()
			Dim link As New Link(ps)
			link.RtfReportHeader = CurrentRichTextBox.Rtf 'RtfText;
			link.CreateDocument()
			If caption.Contains("PDF") Then
				ps.ExportToPdf(saveFileDialog.FileName)
			ElseIf caption.Contains("HTML") Then
				ps.ExportToHtml(saveFileDialog.FileName)
			ElseIf caption.Contains("MHT") Then
				ps.ExportToMht(saveFileDialog.FileName)
			ElseIf caption.Contains("RTF") Then
				ps.ExportToRtf(saveFileDialog.FileName)
			ElseIf caption.Contains("XLS") Then
				ps.ExportToXls(saveFileDialog.FileName)
			ElseIf caption.Contains("XLSX") Then
				ps.ExportToXlsx(saveFileDialog.FileName)
			ElseIf caption.Contains("CSV") Then
				ps.ExportToCsv(saveFileDialog.FileName)
			ElseIf caption.Contains("Text File") Then
				ps.ExportToText(saveFileDialog.FileName)
			ElseIf caption.Contains("Image") Then
				Dim fmt As ImageFormat = ImageFormat.Bmp
				Select Case saveFileDialog.FilterIndex
					Case 0
						fmt = ImageFormat.Bmp
					Case 1
						fmt = ImageFormat.Gif
					Case 2
						fmt = ImageFormat.Jpeg
					Case 3
						fmt = ImageFormat.Png
					Case 4
						fmt = ImageFormat.Tiff
					Case 5
						fmt = ImageFormat.Emf
					Case 6
						fmt = ImageFormat.Wmf
				End Select
				ps.ExportToImage(saveFileDialog.FileName, fmt)
			End If
		End Sub
		Private Sub OpenFileCore(ByVal path As String)
			ribbonControl1.DeactivateKeyboardNavigation()
			pmAppMain.HidePopup()
			Me.Refresh()
			If System.IO.File.Exists(path) Then
				OpenFile(path)
				backstageViewControl1.Ribbon.HideApplicationButtonContentControl()
			Else
                MessageBox.Show(String.Format("ItemClick {0}", path.ToString()))
            End If
		End Sub
		Private Sub SaveMostRecentFiles(ByVal files As RecentItemCollection, ByVal fileName As String)
			Try
				Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(fileName)
				For i As Integer = 0 To files.Count - 1
					Dim pinItem As RecentPinItem = TryCast(files(i), RecentPinItem)
					If pinItem Is Nothing Then
						Continue For
					End If
					sw.WriteLine(String.Format("{0},{1}",If(pinItem.Description <> String.Empty, pinItem.Description, pinItem.Caption), pinItem.PinButtonChecked.ToString()))
				Next i
				sw.Close()
			Catch
			End Try
		End Sub
		Private Sub OnMRUFileLabelClicked(ByVal sender As Object, ByVal e As EventArgs)
			ribbonControl1.DeactivateKeyboardNavigation()
			pmAppMain.HidePopup()
			Me.Refresh()
			OpenFile(sender.ToString())
		End Sub

		#End Region

		Private Sub ribbonControl1_ApplicationButtonDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.ApplicationButtonDoubleClick
			If ribbonControl1.RibbonStyle = RibbonControlStyle.Office2007 Then
				Me.Close()
			End If
		End Sub

		Private Sub barEditItem1_ItemPress(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barEditItem1.ItemPress
			System.Diagnostics.Process.Start("http://www.devexpress.com")
		End Sub

		Private Sub biStyle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles biStyle.EditValueChanged
			Dim style As RibbonControlStyle = CType(biStyle.EditValue, RibbonControlStyle)
			ribbonControl1.RibbonStyle = style
            If style = RibbonControlStyle.Office2010 OrElse style = RibbonControlStyle.MacOffice OrElse style = RibbonControlStyle.Office2013 OrElse style = RibbonControlStyle.TabletOffice OrElse style = RibbonControlStyle.OfficeUniversal Then
                ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
            Else
                ribbonControl1.ApplicationButtonDropDownControl = pmAppMain
            End If
            If style = RibbonControlStyle.TabletOffice OrElse style = RibbonControlStyle.OfficeUniversal Then
                Me.barToggleSwitchItem1.Visibility = BarItemVisibility.Always
            Else
                Me.barToggleSwitchItem1.Visibility = BarItemVisibility.Never
            End If
			UpdateSchemeCombo()
			UpdateLookAndFeel()
		End Sub
		Private Sub UpdateLookAndFeel()
			Dim skinName As String
			Dim style As RibbonControlStyle = ribbonControl1.RibbonStyle
			Select Case style
				Case RibbonControlStyle.Default, RibbonControlStyle.Office2007
					skinName = "Office 2007 Blue"
				Case RibbonControlStyle.Office2013, RibbonControlStyle.TabletOffice, RibbonControlStyle.OfficeUniversal
					skinName = "Office 2013"
				Case Else
					skinName = "Office 2010 Blue"
			End Select
			UserLookAndFeel.Default.SetSkinStyle(skinName)
		End Sub
		Private Sub UpdateSchemeCombo()
			If ribbonControl1.RibbonStyle = RibbonControlStyle.MacOffice OrElse ribbonControl1.RibbonStyle = RibbonControlStyle.Office2010 OrElse ribbonControl1.RibbonStyle = RibbonControlStyle.Office2013 Then
				beScheme.Visibility = If(UserLookAndFeel.Default.ActiveSkinName.Contains("Office 2010"), BarItemVisibility.Always, BarItemVisibility.Never)
			Else
				beScheme.Visibility = BarItemVisibility.Never
			End If
		End Sub
		Private Sub sbExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbExit.Click
			Me.Close()
		End Sub

        Private Sub beiFontSize_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles beiFontSize.EditValueChanged
            If CurrentRichTextBox Is Nothing Then
                Return
            End If
            Dim font As Font = CurrentRichTextBox.SelectionFont
            If font Is Nothing Then
                font = AppearanceObject.DefaultFont
            End If
            CurrentRichTextBox.SelectionFont = New Font(font.FontFamily, Convert.ToSingle(beiFontSize.EditValue), font.Style)
        End Sub

		Private Sub bvTabPrint_SelectedChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvTabPrint.SelectedChanged
			If e.Item Is bvTabPrint Then
				InitPrintingSystem()
				'this.printControl2.RTF = CurrentRichTextBox != null ? CurrentRichTextBox.Rtf : "";
			End If
		End Sub

		Private Sub ribbonControl1_BeforeApplicationButtonContentControlShow(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.BeforeApplicationButtonContentControlShow
			InitPrintingSystem()
			'this.printControl2.RtfText = CurrentRichTextBox == null ? "" : CurrentRichTextBox.Rtf;
			'this.exportControl1.RtfText = CurrentRichTextBox == null ? "" : CurrentRichTextBox.Rtf;
		End Sub

		Private Sub bvItemSave_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvItemSave.ItemClick
			Save()
		End Sub

		Private Sub bvItemSaveAs_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
			SaveAs()
		End Sub

		Private Sub bvItemOpen_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs)
			OpenFile()
		End Sub

		Private Sub bvItemClose_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvItemClose.ItemClick
			If xtraTabbedMdiManager1.SelectedPage IsNot Nothing Then
				xtraTabbedMdiManager1.SelectedPage.MdiChild.Close()
			End If
		End Sub

		Private Sub bvItemExit_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvItemExit.ItemClick
			Close()
		End Sub
		Private Sub beScheme_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles beScheme.EditValueChanged
			ribbonControl1.ColorScheme = (CType(beScheme.EditValue, RibbonControlColorScheme))
		End Sub
		Private Sub ribbonControl1_ResetLayout(ByVal sender As Object, ByVal e As ResetLayoutEventArgs) Handles ribbonControl1.ResetLayout
			ShowHideFormatCategory()
		End Sub
		Private Sub OnNewDocThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs) Handles thumbButtonNewDoc.Click
			CreateNewDocument()
		End Sub
		Private Sub OnPrevThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs) Handles thumbButtonPrev.Click
			Dim mdiChild As Form = GetPrevMdiChild()
			If mdiChild IsNot Nothing Then
				ActivateMdiChild(mdiChild)
			End If
		End Sub
		Private Sub OnNextDocThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs) Handles thumbButtonNext.Click
			Dim mdiChild As Form = GetNextMdiChild()
			If mdiChild IsNot Nothing Then
				ActivateMdiChild(mdiChild)
			End If
		End Sub
		Private Sub OnExitThumbButtonClick(ByVal sender As Object, ByVal e As ThumbButtonClickEventArgs) Handles thumbButtonExit.Click
			Close()
		End Sub
		Private Function GetNextMdiChild() As Form
			If ActiveMdiChild Is Nothing OrElse MdiChildren.Length < 2 Then
				Return Nothing
			End If
			Dim pos As Integer = Array.IndexOf(MdiChildren, ActiveMdiChild)
			Return If(pos = MdiChildren.Length - 1, MdiChildren(0), MdiChildren(pos + 1))
		End Function
		Private Function GetPrevMdiChild() As Form
			If ActiveMdiChild Is Nothing OrElse MdiChildren.Length < 2 Then
				Return Nothing
			End If
			Dim pos As Integer = Array.IndexOf(MdiChildren, ActiveMdiChild)
			Return If(pos = 0, MdiChildren(MdiChildren.Length - 1), MdiChildren(pos - 1))
		End Function
		Private Sub OnTabbedMdiManagerPageCollectionChanged(ByVal sender As Object, ByVal e As XtraTabbedMdi.MdiTabPageEventArgs) Handles xtraTabbedMdiManager1.PageAdded, xtraTabbedMdiManager1.PageRemoved
			UpdateThumbnailButtons()
		End Sub
		Private Sub UpdateThumbnailButtons()
			thumbButtonPrev.Enabled = MdiChildren.Length > 1
			thumbButtonNext.Enabled = thumbButtonPrev.Enabled
		End Sub

		Private Sub bbColorMix_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbColorMix.ItemClick
			Dim form As New ColorWheelForm()
			form.StartPosition = FormStartPosition.CenterParent
			form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
			form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
			form.ShowDialog(Me)
		End Sub

		#Region "Print processing"
		Private Sub InitPrintingSystem()
			Dim frm As RibbonForm = TryCast(FindForm(), RibbonForm)
			Dim manager As BarManager = ribbonControl1.Manager
			CType(Me.ddbOrientation.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbMargins.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbPaperSize.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbCollate.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbPrinter.DropDownControl, GalleryDropDown).Manager = manager
			CType(Me.ddbDuplex.DropDownControl, GalleryDropDown).Manager = manager
			Dim ps As New PrintingSystem()
			Me.printControl2.PrintingSystem = ps
			AddHandler ps.StartPrint, AddressOf OnStartPrint
			Dim link As New Link(ps)
			If CurrentRichTextBox IsNot Nothing Then
				link.RtfReportHeader = CurrentRichTextBox.Rtf
			End If
			link.CreateDocument()
			Me.printButton.Enabled = ps.Pages.Count > 0
			Me.pageButtonEdit.Enabled = ps.Pages.Count > 0
			Me.pageButtonEdit.Properties.DisplayFormat.FormatString = "Page {0} of " & ps.Pages.Count
			Me.pageButtonEdit.EditValue = 1
			UpdatePrintPageSettings()
		End Sub
		Private Sub printButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printButton.Click
			CType(Me.printControl2.PrintingSystem, PrintingSystem).Print(Me.ddbPrinter.Text)
		End Sub
		Private Sub OnStartPrint(ByVal sender As Object, ByVal e As PrintDocumentEventArgs)
			e.PrintDocument.PrinterSettings.Copies = CShort(Math.Truncate(Me.copySpinEdit.Value))
			Dim p As Padding = CType(Me.ddbMargins.Tag, Padding)
			Me.printControl2.PrintingSystem.PageSettings.TopMargin = CInt(Math.Truncate(p.Top * 3.9))
			Me.printControl2.PrintingSystem.PageSettings.BottomMargin = CInt(Math.Truncate(p.Bottom * 3.9))
			Me.printControl2.PrintingSystem.PageSettings.LeftMargin = CInt(Math.Truncate(p.Left * 3.9))
			Me.printControl2.PrintingSystem.PageSettings.RightMargin = CInt(Math.Truncate(p.Right * 3.9))
			e.PrintDocument.PrinterSettings.Collate = CBool(Me.ddbCollate.Tag)
			e.PrintDocument.PrinterSettings.Duplex = If(CBool(Me.ddbDuplex.Tag), Duplex.Horizontal, Duplex.Simplex)
		End Sub
		Private Sub InitPrint()
			Me.ddbOrientation.DropDownControl = CreateOrientationGallery()
			Me.ddbMargins.DropDownControl = CreateMarginsGallery()
			Me.ddbPaperSize.DropDownControl = CreatePageSizeGallery()
			Me.ddbCollate.DropDownControl = CreateCollateGallery()
			Me.ddbPrinter.DropDownControl = CreatePrintersGallery()
			Me.ddbDuplex.DropDownControl = CreateDuplexGallery()
		End Sub
		Private Function CreateListBoxGallery() As GalleryDropDown
			Dim res As New GalleryDropDown()
			res.Gallery.FixedImageSize = False
			res.Gallery.ShowItemText = True
			res.Gallery.ColumnCount = 1
			res.Gallery.CheckDrawMode = CheckDrawMode.OnlyImage
			res.Gallery.ShowGroupCaption = False
			res.Gallery.AutoSize = GallerySizeMode.Vertical
			res.Gallery.SizeMode = GallerySizeMode.None
			res.Gallery.ShowScrollBar = ShowScrollBar.Hide
			res.Gallery.ItemCheckMode = ItemCheckMode.SingleRadio
			res.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			res.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
			res.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center

			res.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
			res.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
			res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
			res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			res.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
			res.Gallery.Groups.Add(New GalleryItemGroup())
			res.Gallery.StretchItems = True

			Return res
		End Function
		Private Function CreateOrientationGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim portraitItem As New GalleryItem()
            portraitItem.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationPortrait
			portraitItem.Caption = "Portrait Orientation"
			Dim landscapeItem As New GalleryItem()
            landscapeItem.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageOrientationLandscape
			landscapeItem.Caption = "Landscape Orientation"
			res.Gallery.Groups(0).Items.Add(portraitItem)
			res.Gallery.Groups(0).Items.Add(landscapeItem)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnOrientationGalleryItemCheckedChanged
			portraitItem.Checked = True
			Return res
		End Function
        Private Function CreateMarginsGallery() As GalleryDropDown
            Dim res As GalleryDropDown = CreateListBoxGallery()
            Dim normal As New GalleryItem()
            normal.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsNormal
            normal.Caption = "Normal"
            normal.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "25 mm"
            normal.Tag = New Padding(25, 25, 25, 25)
            Dim narrow As New GalleryItem()
            narrow.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsNarrow
            narrow.Caption = "Narrow"
            narrow.Description = "Top:" & Constants.vbTab & "12 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "12 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "12 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "12 mm"
            narrow.Tag = New Padding(12, 12, 12, 12)
            Dim moderate As New GalleryItem()
            moderate.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsModerate
            moderate.Caption = "Moderate"
            moderate.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "19 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "19 mm"
            moderate.Tag = New Padding(19, 25, 19, 25)
            Dim wide As New GalleryItem()
            wide.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PageMarginsWide
            wide.Caption = "Wide"
            wide.Description = "Top:" & Constants.vbTab & "25 mm" & Constants.vbTab & "Bottom:" & Constants.vbTab & "25 mm" & Constants.vbLf & "Left:" & Constants.vbTab & "50 mm" & Constants.vbTab & "Right:" & Constants.vbTab & "50 mm"
            wide.Tag = New Padding(50, 25, 50, 25)
            res.Gallery.Groups(0).Items.Add(normal)
            res.Gallery.Groups(0).Items.Add(narrow)
            res.Gallery.Groups(0).Items.Add(moderate)
            res.Gallery.Groups(0).Items.Add(wide)
            AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnMarginsGalleryItemCheckedChanged
            normal.Checked = True
            Return res
        End Function
		Private Function CreatePageSizeGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim letter As New GalleryItem()
            letter.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Letter
			letter.Caption = "Letter"
			letter.Description = "215 mm x 279 mm"
			letter.Tag = PaperKind.Letter
			Dim tabloid As New GalleryItem()
            tabloid.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Tabloid
			tabloid.Caption = "Tabloid"
			tabloid.Description = "279 mm x 431 mm"
			tabloid.Tag = PaperKind.Tabloid
			Dim legal As New GalleryItem()
            legal.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Legal
			legal.Caption = "Legal"
			legal.Description = "215 mm x 355 mm"
			legal.Tag = PaperKind.Legal
			Dim executive As New GalleryItem()
            executive.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_Executive
			executive.Caption = "Executive"
			executive.Description = "184 mm x 266 mm"
			executive.Tag = PaperKind.Executive
			Dim a3 As New GalleryItem()
            a3.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A3
			a3.Caption = "A3"
			a3.Description = "296 mm x 420 mm"
			a3.Tag = PaperKind.A3
			Dim a4 As New GalleryItem()
            a4.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A4
			a4.Caption = "A4"
			a4.Description = "210 mm x 296 mm"
			a4.Tag = PaperKind.A4
			Dim a5 As New GalleryItem()
            a5.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A5
			a5.Caption = "A5"
			a5.Description = "148 mm x 210 mm"
			a5.Tag = PaperKind.A5
			Dim a6 As New GalleryItem()
            a6.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PaperKind_A6
			a6.Caption = "A6"
			a6.Description = "105 mm x 148 mm"
			a6.Tag = PaperKind.A6
			res.Gallery.Groups(0).Items.Add(letter)
			res.Gallery.Groups(0).Items.Add(tabloid)
			res.Gallery.Groups(0).Items.Add(legal)
			res.Gallery.Groups(0).Items.Add(executive)
			res.Gallery.Groups(0).Items.Add(a3)
			res.Gallery.Groups(0).Items.Add(a4)
			res.Gallery.Groups(0).Items.Add(a5)
			res.Gallery.Groups(0).Items.Add(a6)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPaperSizeGalleryItemCheckedChanged
			a4.Checked = True
			Return res
		End Function
		Private Function CreateCollateGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim collated As New GalleryItem()
            collated.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			collated.Caption = "Collated"
			collated.Description = "1,2,3   1,2,3  1,2,3"
			collated.Tag = True
			Dim uncollated As New GalleryItem()
            uncollated.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			uncollated.Caption = "Uncollated"
			uncollated.Description = "1,1,1  2,2,2  3,3,3"
			uncollated.Tag = False
			res.Gallery.Groups(0).Items.Add(collated)
			res.Gallery.Groups(0).Items.Add(uncollated)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnCollateGalleryItemCheckedChanged
			collated.Checked = True
			Return res
		End Function
		Private Function CreateDuplexGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim oneSided As New GalleryItem()
            oneSided.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			oneSided.Caption = "Print One Sided"
			oneSided.Description = "Only print on one side of the page"
			oneSided.Tag = False
			Dim twoSided As New GalleryItem()
            twoSided.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.MultiplePagesLarge
			twoSided.Caption = "Manually Print on Both Sides"
			twoSided.Description = "Reload paper when prompted to print the second side"
			twoSided.Tag = False
			res.Gallery.Groups(0).Items.Add(oneSided)
			res.Gallery.Groups(0).Items.Add(twoSided)
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnDuplexGalleryItemCheckedChanged
			oneSided.Checked = True
			Return res
		End Function
		Private Sub OnDuplexGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPageDuplex(e.Item)
		End Sub
		Private Function CreatePrintersGallery() As GalleryDropDown
			Dim res As GalleryDropDown = CreateListBoxGallery()
			Dim ps As New PrinterSettings()
			Dim defaultPrinter As GalleryItem = Nothing
			Try
				For Each str As String In PrinterSettings.InstalledPrinters
					Dim item As New GalleryItem()
                    item.Image = DevExpress.XtraBars.Demos.RibbonSimplePad.Properties.Resources.PrintDirectLarge
					item.Caption = str
					res.Gallery.Groups(0).Items.Add(item)
					ps.PrinterName = str
					If ps.IsDefaultPrinter Then
						defaultPrinter = item
					End If
				Next str
			Catch
			End Try
			AddHandler res.Gallery.ItemCheckedChanged, AddressOf OnPrinterGalleryItemCheckedChanged
			If defaultPrinter IsNot Nothing Then
				defaultPrinter.Checked = True
			End If
			Return res
		End Function
		Private Sub OnMarginsGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPageMargins(e.Item)
		End Sub
		Private Sub OnPrinterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPagePrinters(e.Item)
		End Sub
		Private Sub OnCollateGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPageCollate(e.Item)
		End Sub
		Private Sub OnPaperSizeGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPageSize(e.Item)
		End Sub
		Private Sub OnOrientationGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
			UpdatePrintPageOrientation(e.Item)
		End Sub
		Public Sub UpdatePrintPageSettings()
			If ddbOrientation.DropDownControl IsNot Nothing Then
				UpdatePrintPageOrientation(CType(ddbOrientation.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
			If ddbMargins.DropDownControl IsNot Nothing Then
				UpdatePrintPageMargins(CType(ddbMargins.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
			If ddbPaperSize.DropDownControl IsNot Nothing Then
				UpdatePrintPageSize(CType(ddbPaperSize.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
			If ddbCollate.DropDownControl IsNot Nothing Then
				UpdatePrintPageCollate(CType(ddbCollate.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
			If ddbPrinter.DropDownControl IsNot Nothing Then
				UpdatePrintPagePrinters(CType(ddbPrinter.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
			If ddbDuplex.DropDownControl IsNot Nothing Then
				UpdatePrintPageDuplex(CType(ddbDuplex.DropDownControl, GalleryDropDown).Gallery.GetCheckedItem())
			End If
		End Sub
		Private Sub UpdatePrintPageOrientation(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			ddbOrientation.Text = item.Caption
			ddbOrientation.Image = item.Image
			If ddbOrientation.DropDownControl IsNot Nothing Then
				Me.printControl2.PrintingSystem.PageSettings.Landscape = CType(ddbOrientation.DropDownControl, GalleryDropDown).Gallery.Groups(0).Items(1).Checked
			End If
		End Sub
		Private Sub UpdatePrintPageMargins(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			Me.ddbMargins.Image = item.Image
			Me.ddbMargins.Text = item.Caption
			Me.ddbMargins.Tag = item.Tag
			Dim p As Padding = CType(item.Tag, Padding)
			If Me.printControl2.PrintingSystem IsNot Nothing Then
				Me.printControl2.PrintingSystem.PageSettings.TopMargin = CInt(Math.Truncate(p.Top * 3.9))
				Me.printControl2.PrintingSystem.PageSettings.BottomMargin = CInt(Math.Truncate(p.Bottom * 3.9))
				Me.printControl2.PrintingSystem.PageSettings.LeftMargin = CInt(Math.Truncate(p.Left * 3.9))
				Me.printControl2.PrintingSystem.PageSettings.RightMargin = CInt(Math.Truncate(p.Right * 3.9))
			End If
		End Sub
		Private Sub UpdatePrintPageSize(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			Me.ddbPaperSize.Image = item.Image
			Me.ddbPaperSize.Text = item.Caption
			If Me.printControl2.PrintingSystem IsNot Nothing Then
				Me.printControl2.PrintingSystem.PageSettings.PaperKind = CType(item.Tag, PaperKind)
			End If
		End Sub
		Private Sub UpdatePrintPageCollate(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			Me.ddbCollate.Image = item.Image
			Me.ddbCollate.Text = item.Caption
			Me.ddbCollate.Tag = item.Tag
		End Sub
		Private Sub UpdatePrintPagePrinters(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			Me.ddbPrinter.Text = item.Caption
			Me.ddbPrinter.Image = item.Image
		End Sub

		Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl1.EditValueChanged
			If updatedZoom Then
				Return
			End If
			updatedZoom = True
			Try
				zoomTextEdit.EditValue = GetZoomValue()
			Finally
				updatedZoom = False
			End Try
		End Sub
		Private Function GetZoomValue() As Integer
			If zoomTrackBarControl1.Value <= 40 Then
                Return 10 + 90 * (zoomTrackBarControl1.Value - 0) \ 40
			Else
                Return 100 + 400 * (zoomTrackBarControl1.Value - 40) \ 40
			End If
		End Function
		Private updatedZoom As Boolean = False

		Private Sub zoomTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTextEdit.EditValueChanged
			Try
				Dim zoomValue As Integer = Int32.Parse(CStr(zoomTextEdit.EditValue.ToString()))
				Me.zoomTrackBarControl1.Value = ZoomValueToValue(zoomValue)
				Me.printControl2.Zoom = 0.01F * CInt(zoomValue)
			Catch e1 As Exception
			End Try
		End Sub
		Private Function ZoomValueToValue(ByVal zoomValue As Integer) As Integer
			If zoomValue < 100 Then
				Return Math.Min(80, Math.Max(0, (zoomValue - 10) * 40 \ 90))
			End If
			Return Math.Min(80, Math.Max(0, (zoomValue - 100) * 40 \ 400 + 40))
		End Function

		Private Sub pageButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles pageButtonEdit.ButtonClick
            Dim pageIndex As Integer = CInt(Me.pageButtonEdit.EditValue)
			If e.Button.Kind = ButtonPredefines.Left Then
				If pageIndex > 1 Then
					pageIndex -= 1
				End If
			ElseIf e.Button.Kind = ButtonPredefines.Right Then
				If pageIndex < Me.printControl2.PrintingSystem.Pages.Count Then
					pageIndex += 1
				End If
			End If
			Me.pageButtonEdit.EditValue = pageIndex
		End Sub

		Private Sub pageButtonEdit_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles pageButtonEdit.EditValueChanging
			Try
				Dim pageIndex As Integer = Int32.Parse(e.NewValue.ToString())
				If pageIndex < 1 Then
					pageIndex = 1
				ElseIf pageIndex > Me.printControl2.PrintingSystem.Pages.Count Then
					pageIndex = Me.printControl2.PrintingSystem.Pages.Count
				End If
				e.NewValue = pageIndex
			Catch e1 As Exception
				e.NewValue = 1
			End Try
		End Sub

		Private Sub UpdatePageButtonsEnabledState(ByVal pageIndex As Integer)
            If Me.pageButtonEdit.Properties.Buttons.Count = 0 Then
                Return
            End If
            Me.pageButtonEdit.Properties.Buttons(0).Enabled = pageIndex <> 1
			Me.pageButtonEdit.Properties.Buttons(1).Enabled = pageIndex <> Me.printControl2.PrintingSystem.Pages.Count
		End Sub

		Private Sub pageButtonEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pageButtonEdit.EditValueChanged
            Dim pageIndex As Integer = CInt(Fix(Me.pageButtonEdit.EditValue))
            Me.printControl2.SelectedPageIndex = pageIndex - 1
            UpdatePageButtonsEnabledState(pageIndex)
		End Sub

		Private Sub printControl2_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles printControl2.SelectedPageChanged
			Me.pageButtonEdit.EditValue = Me.printControl2.SelectedPageIndex + 1
		End Sub

		Private Sub UpdatePrintPageDuplex(ByVal item As GalleryItem)
			If item Is Nothing Then
				Return
			End If
			Me.ddbDuplex.Text = item.Caption
			Me.ddbDuplex.Image = item.Image
			Me.ddbDuplex.Tag = item.Tag
		End Sub
		#End Region
	End Class

	Public Class RibbonSimplePadSplashScreen
		Inherits DemoSplashScreen

		Public Sub New()
			DemoText = "RibbonSimplePad"
			ProductText = "The XtraBars Suite"
		End Sub
	End Class
End Namespace
