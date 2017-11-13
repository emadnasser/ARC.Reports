Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Frames
Imports DevExpress.Data.Utils
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace PdfViewerDemo
	Partial Public Class MainForm
		Inherits RibbonForm
		Private Const glyphImagePath As String = "{0}_16x16.png"
		Private Const largeGlyphImagePath As String = "{0}_32x32.png"

		Private Shared Sub StartProcess(ByVal name As String)
			Try
				Dim process As New Process()
				Dim startInfo As ProcessStartInfo = process.StartInfo
				startInfo.FileName = name & "?gldata=" & AssemblyInfo.VersionShort & "_DevExpress.XtraPdfViewer.Demos.Main"
				startInfo.Arguments = String.Empty
				startInfo.Verb = "Open"
				startInfo.WindowStyle = ProcessWindowStyle.Normal
				process.Start()
			Catch
			End Try
		End Sub
		Private Shared Function GetImageFromResources(ByVal imageName As String) As Image
			Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = [assembly].GetManifestResourceStream(imageName)
			If stream Is Nothing Then
				stream = [assembly].GetManifestResourceStream("Images." & imageName)
			End If
			Return ImageTool.ImageFromStream(stream)
		End Function
		Private Shared Function GetDocumentStream() As Stream
			Dim [assembly] As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = [assembly].GetManifestResourceStream("Demo.pdf")
			If stream Is Nothing Then
				Return [assembly].GetManifestResourceStream("Data.Demo.pdf")
			End If
			Return stream
		End Function

		Private ReadOnly popupSkins As New PopupMenu()
		Private ReadOnly checkItemAllowFormSkins As BarCheckItem
		Private ReadOnly mainFormText As String

		Public Sub New()
			InitializeComponent()
			UpdateGlass()
			pdfViewer.DocumentCreator = "PDF Viewer Demo"
			pdfViewer.DocumentProducer = "Developer Express Inc., " & AssemblyInfo.Version
			UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
			pdfViewer.CreateRibbon()
			For Each page As RibbonPage In ribbonControl.Pages
				If page.Text = "PDF Viewer" Then
					popupSkins.BeginUpdate()
					popupSkins.Ribbon = ribbonControl
					checkItemAllowFormSkins = New BarCheckItem(ribbonControl.Manager)
					checkItemAllowFormSkins.Caption = "Allow Form Skins"
					AddHandler checkItemAllowFormSkins.ItemClick, AddressOf OnAllowFormSkinsItemClick
					popupSkins.AddItem(checkItemAllowFormSkins)
					SkinHelper.InitSkinPopupMenu(popupSkins)
					popupSkins.ItemLinks(1).BeginGroup = True
					popupSkins.EndUpdate()
					AddHandler popupSkins.Popup, AddressOf OnPmSkinsPopup
					Dim skinsPage As New RibbonPageGroup(ribbonGallerySkins.Caption)
					SkinHelper.InitSkinGallery(ribbonGallerySkins, True)
					AddHandler skinsPage.CaptionButtonClick, AddressOf OnSkinsPageCaptionButtonClick
					skinsPage.ItemLinks.Add(ribbonGallerySkins)
					Dim devExpressPage As New RibbonPageGroup("DevExpress")
					devExpressPage.ShowCaptionButton = False
					AddBarItem(devExpressPage, "Getting Started", "GetStarted", AddressOf OnGettingStartedItemClicked)
					AddBarItem(devExpressPage, "Get Free Support", "GetSupport", AddressOf OnGetFreeSupportItemClicked)
					AddBarItem(devExpressPage, "Buy Now", "BuyNow", AddressOf OnBuyNowItemClicked)
					AddBarItem(devExpressPage, "About", "Info", AddressOf OnAboutItemClicked)
					page.Groups.AddRange(New RibbonPageGroup() { skinsPage, devExpressPage })
					Exit For
				End If
			Next page
			mainFormText = Text
			AddHandler pdfViewer.DocumentChanged, AddressOf OnPdfViewerDocumentChanged
			AddHandler pdfViewer.UriOpening, AddressOf OnPdfViewerUriOpening
			pdfViewer.LoadDocument(GetDocumentStream())
			DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
		End Sub
		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			If pdfViewer.IsDocumentChanged Then
				e.Cancel = Not pdfViewer.ShowDocumentClosingWarning()
			End If
		End Sub
		Private Sub AddBarItem(ByVal page As RibbonPageGroup, ByVal caption As String, ByVal imageName As String, ByVal handler As ItemClickEventHandler)
			Dim item As New BarButtonItem(ribbonControl.Manager, caption)
			item.Glyph = GetImageFromResources(String.Format(glyphImagePath, imageName))
			item.LargeGlyph = GetImageFromResources(String.Format(largeGlyphImagePath, imageName))
			AddHandler item.ItemClick, handler
			page.ItemLinks.Add(item)
		End Sub
		Private Sub UpdateGlass()
			AllowFormGlass = If(SkinManager.AllowFormSkins, DefaultBoolean.False, DefaultBoolean.True)
		End Sub
		Private Sub OnPdfViewerUriOpening(ByVal sender As Object, ByVal e As PdfUriOpeningEventArgs)
			Dim uri As Uri = e.Uri
			e.Handled = uri.IsAbsoluteUri AndAlso String.Compare(uri.AbsoluteUri, AssemblyInfo.DXLinkGetStarted, True) = 0
		End Sub
		Private Sub OnPdfViewerDocumentChanged(ByVal sender As Object, ByVal e As PdfDocumentChangedEventArgs)
			Dim fileName As String = Path.GetFileName(e.DocumentFilePath)
			If String.IsNullOrEmpty(fileName) Then
				Text = mainFormText
			Else
				Text = fileName & " - " & mainFormText
			End If
		End Sub
		Private Sub OnRibbonControlPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles ribbonControl.Paint
			Dim ribbonViewInfo As RibbonViewInfo = ribbonControl.ViewInfo
			If ribbonViewInfo IsNot Nothing Then
				Dim panelViewInfo As RibbonPanelViewInfo = ribbonViewInfo.Panel
				If panelViewInfo IsNot Nothing Then
					Dim groups As RibbonPageGroupViewInfoCollection = panelViewInfo.Groups
					If groups IsNot Nothing Then
						Dim bounds As Rectangle = panelViewInfo.Bounds
						Dim image As Image = ApplicationCaption8_1.GetImageLogoEx(LookAndFeel)
						Dim imageHeight As Integer = image.Height
						Dim yOffset As Integer = bounds.Height - imageHeight
						If yOffset >= 0 Then
							Dim minX As Integer
							If groups.Count > 0 Then
								minX = groups(groups.Count - 1).Bounds.Right
							Else
								minX = bounds.X
							End If
							Dim imageWidth As Integer = image.Width + 15
							Dim xOffset As Integer = bounds.Width - imageWidth
							If xOffset >= minX Then
								bounds.X = xOffset
								bounds.Y += yOffset \ 2
								bounds.Width = imageWidth
								bounds.Height = imageHeight
								e.Graphics.DrawImage(image, bounds.Location)
							End If
						End If
					End If
				End If
			End If
		End Sub
		Private Sub OnPmSkinsPopup(ByVal sender As Object, ByVal e As EventArgs)
			checkItemAllowFormSkins.Checked = SkinManager.AllowFormSkins
			Dim activeSkinName As String = UserLookAndFeel.Default.ActiveSkinName
			checkItemAllowFormSkins.Enabled = (Not activeSkinName.Contains("Office 2013")) AndAlso Not activeSkinName.Contains("Office 2016")
		End Sub
		Private Sub OnAllowFormSkinsItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			If SkinManager.AllowFormSkins Then
				SkinManager.DisableFormSkins()
			Else
				SkinManager.EnableFormSkins()
			End If
			UpdateGlass()
		End Sub
		Private Sub OnSkinsPageCaptionButtonClick(ByVal sender As Object, ByVal e As RibbonPageGroupEventArgs)
			popupSkins.ShowPopup(MousePosition)
		End Sub
		Private Sub OnGettingStartedItemClicked(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			StartProcess(AssemblyInfo.DXLinkGetStarted)
		End Sub
		Private Sub OnGetFreeSupportItemClicked(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			StartProcess(AssemblyInfo.DXLinkGetSupport)
		End Sub
		Private Sub OnBuyNowItemClicked(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			StartProcess(AssemblyInfo.DXLinkBuyNow)
		End Sub
		Private Sub OnAboutItemClicked(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			PdfViewer.About()
		End Sub
	End Class
End Namespace
