Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraRichEdit.Localization
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraRichEdit.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase
		Implements IDXMenuManager

		Private menu As LookAndFeelMenu = Nothing
		Private fMenuManager As IDXMenuManager

		Public Sub New()
		End Sub

        Public Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
		Public Overridable ReadOnly Property PrintingRichEditControl() As RichEditControl
			Get
				Return Nothing
			End Get
		End Property

		Public Property DemoMainMenu() As LookAndFeelMenu
			Get
				Return menu
			End Get
			Set(ByVal value As LookAndFeelMenu)
				If menu Is value Then
					Return
				End If
				Me.menu = value
			End Set
		End Property

        Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos)
        End Sub
        Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
            Return Me
        End Function
        Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
        End Sub

		Public Property MenuManager() As IDXMenuManager
			Get
				Return fMenuManager
			End Get
			Set(ByVal value As IDXMenuManager)
				fMenuManager = value
			End Set
		End Property

		Public Overridable ReadOnly Property ShowOptions() As Boolean 'TODO
			Get
				Return False
			End Get
		End Property

		Private Overloads Sub OnSwitchStyle(ByVal sender As Object, ByVal e As EventArgs)
			OnSwitchStyle()
			'MessageBox.Show("Style Changed: " + AppearanceMenu.NeedPaintAppearance.ToString());
		End Sub
		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim richEdit As DevExpress.XtraRichEdit.RichEditControl = TryCast(ctrl, DevExpress.XtraRichEdit.RichEditControl)
			If richEdit IsNot Nothing Then
				richEdit.MenuManager = manager
			End If
			Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
			If be IsNot Nothing Then
				be.MenuManager = manager
			End If
		End Sub
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, True, ExportFormats.DOC Or ExportFormats.DOCX Or ExportFormats.EPUB Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.ODT Or ExportFormats.PDF Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XML, False)
		End Sub
		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			If PrintingRichEditControl IsNot Nothing Then
				PrintingRichEditControl.LayoutUnit = DocumentLayoutUnit.Pixel
			End If
			MergeRibbon()
		End Sub
		Private Sub MergeRibbon()
			If ParentFormMain Is Nothing Then
				Return
			End If
			Dim parentRibbon As RibbonControl = ParentFormMain.Ribbon
			Dim page As RibbonPage = parentRibbon.MergedPages("File")
			Dim group As RibbonPageGroup = ParentFormMain.ReservGroup1.Page.Groups("rpgAbout")
			If page Is Nothing OrElse group Is Nothing Then
				Return
			End If
			page.Groups.Add(DirectCast(group.Clone(), RibbonPageGroup))
		End Sub
		#Region "Print and Export"
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			If PrintingRichEditControl Is Nothing Then
				Return
			End If
			Dim oldCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If ext = "pdf" Then
				PrintingRichEditControl.ExportToPdf(filename)
			End If
			If ext = "html" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Html)
			End If
			If ext = "mht" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Mht)
			End If
			If ext = "doc" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Doc)
			End If
			If ext = "docx" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.OpenXml)
			End If
			If ext = "rtf" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.Rtf)
			End If
			If ext = "txt" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.PlainText)
			End If
			If ext = "odt" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.OpenDocument)
			End If
			If ext = "epub" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.ePub)
			End If
			If ext = "xml" Then
				PrintingRichEditControl.SaveDocument(filename, DocumentFormat.WordML)
			End If
			Cursor.Current = oldCursor
		End Sub
		Protected Overrides Sub ExportToPDF()
			ExportTo("pdf", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_PDFFiles) & " (*.pdf)|*.pdf")
		End Sub
		Protected Overrides Sub ExportToHTML()
			ExportTo("html", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_HtmlFiles) & " (*.html)|*.html")
		End Sub
		Protected Overrides Sub ExportToMHT()
			ExportTo("mht", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_MhtFiles) & " (*.mht)|*.mht")
		End Sub
		Protected Overrides Sub ExportToDOC()
			ExportTo("doc", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_DocFiles) & " (*.doc)|*.doc")
		End Sub
		Protected Overrides Sub ExportToDOCX()
			ExportTo("docx", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_OpenXmlFiles) & " (*.docx)|*.docx")
		End Sub
		Protected Overrides Sub ExportToRTF()
			ExportTo("rtf", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_RtfFiles) & " (*.rtf)|*.rtf")
		End Sub
		Protected Overrides Sub ExportToText()
			ExportTo("txt", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_TextFiles) & " (*.txt)|*.txt")
		End Sub
		Protected Overrides Sub ExportToODT()
			ExportTo("odt", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_OpenDocumentFiles) & " (*.odt)|*.odt")
		End Sub
		Protected Overrides Sub ExportToEPUB()
			ExportTo("epub", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_ePubFiles) & " (*.epub)|*.epub")
		End Sub
		Protected Overrides Sub ExportToXML()
			ExportTo("xml", XtraRichEditLocalizer.GetString(XtraRichEditStringId.FileFilterDescription_WordMLFiles) & " (*.xml)|*.xml")
		End Sub
		Protected Overrides Sub PrintPreview()
			If PrintingRichEditControl IsNot Nothing Then
				PrintingRichEditControl.ShowPrintPreview()
			End If
		End Sub
		Protected Overrides Sub Print()
			If PrintingRichEditControl IsNot Nothing Then
				PrintingRichEditControl.Print()
			End If
		End Sub
		#End Region
	End Class
End Namespace
