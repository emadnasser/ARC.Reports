Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting.Control
Imports DevExpress.XtraPrinting

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class SpreadsheetPreview
		Inherits UserControl
		Private _workbook As IWorkbook
		Private pcCache As Dictionary(Of PrintControl, PrintableComponentLinkBase)
		Private previewZoom_Renamed As SpreadhsheetPreviewZoom = SpreadhsheetPreviewZoom.Default

		Public Sub New()
			InitializeComponent()
			Me.pcCache = New Dictionary(Of PrintControl, PrintableComponentLinkBase)()
			Me.xtraTabControl1.TabPages.Clear()
			UpdatePreview()
		End Sub

		Public Property CanShowBorders() As Boolean
		Public Property Workbook() As IWorkbook
			Get
				Return _workbook
			End Get
			Set(ByVal value As IWorkbook)
				_workbook = value
			End Set
		End Property
		Public Property PreviewZoom() As SpreadhsheetPreviewZoom
			Get
				Return previewZoom_Renamed
			End Get
			Set(ByVal value As SpreadhsheetPreviewZoom)
				If previewZoom_Renamed = value Then
					Return
				End If
				previewZoom_Renamed = value
				UpdatePreview()
			End Set
		End Property

		Public Sub UpdatePreview()
			If Workbook Is Nothing Then
				Return
			End If
			Dim count As Integer = Workbook.Worksheets.Count
			Me.documentViewerSinglePreview.Visible = False
			Me.xtraTabControl1.Visible = False
			If count < 2 Then
				UpdateWorkbookSinglePreview()
			Else
				UpdateMultipleSheetPreview()
			End If
		End Sub
		Private Sub UpdateWorkbookSinglePreview()
			Me.documentViewerSinglePreview.Visible = True
			UpdateDocumentViewerProperties(Me.documentViewerSinglePreview)
			If Me.documentViewerSinglePreview.PrintingSystem Is Nothing Then
				Me.documentViewerSinglePreview.PrintingSystem = New PrintingSystemBase()
			End If
			Dim link As New PrintableComponentLinkBase(Me.documentViewerSinglePreview.PrintingSystem)
			link.Component = Workbook
			link.CreateDocument()
			UpdateDocumentViewerZoom(Me.documentViewerSinglePreview)
		End Sub
		Private Sub UpdateMultipleSheetPreview()
			Me.xtraTabControl1.Visible = True
			Dim count As Integer = Workbook.Worksheets.Count
			Dim usedPrintControls As New List(Of PrintControl)()
			For i As Integer = 0 To count - 1
				Dim sheet As Worksheet = Workbook.Worksheets(i)
				Dim pc As PrintControl = EnsurePrintControl(i, sheet.Name)
				Dim link As PrintableComponentLinkBase = ObtainLinkFrom(pc)
				UpdateSheetPreview(sheet, link)
				usedPrintControls.Add(pc)
			Next i
			ClearPrintControlCache(usedPrintControls)
		End Sub
		Private Sub ClearPrintControlCache(ByVal usedPrintControls As List(Of PrintControl))
			Dim toClear As New List(Of PrintControl)()
			For Each pc As KeyValuePair(Of PrintControl, PrintableComponentLinkBase) In Me.pcCache
				If (Not usedPrintControls.Contains(pc.Key)) Then
					toClear.Add(pc.Key)
				End If
			Next pc
			For Each item As PrintControl In toClear
				Me.pcCache.Remove(item)
			Next item
		End Sub
		Private Sub UpdateSheetPreview(ByVal sheet As Worksheet, ByVal link As PrintableComponentLinkBase)
			Dim printable As IPrintable = TryCast(sheet, IPrintable)
			link.Component = printable
			link.CreateDocument()
		End Sub
		Private Function ObtainLinkFrom(ByVal pc As PrintControl) As PrintableComponentLinkBase
			If Me.pcCache.ContainsKey(pc) Then
				Return Me.pcCache(pc)
			End If
			Dim link As New PrintableComponentLinkBase(pc.PrintingSystem)
			Me.pcCache.Add(pc, link)
			Return link
		End Function
		Private Function EnsurePrintControl(ByVal i As Integer, ByVal caption As String) As PrintControl
			Dim tabPages As XtraTabPageCollection = Me.xtraTabControl1.TabPages
			Dim page As XtraTabPage = If((i < tabPages.Count), tabPages(i), CreateNewTabPage())
			page.Text = caption
			If page.Controls.Count = 1 AndAlso TypeOf page.Controls(0) Is PrintControl Then
				Return TryCast(page.Controls(0), PrintControl)
			End If
			Dim pc As New PrintControl()
			pc.PrintingSystem = New PrintingSystemBase()
			pc.Dock = DockStyle.Fill
			page.Controls.Clear()
			page.Controls.Add(pc)
			UpdatePrintControlProperties(pc)
			Return pc
		End Function
		Private Sub UpdateDocumentViewerProperties(ByVal documentViewer As XtraPrinting.Preview.DocumentViewer)
			If documentViewer Is Nothing OrElse CanShowBorders Then
				Return
			End If
			documentViewer.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None
			documentViewer.ShowPageMargins = False
			If documentViewer.PrintingSystem IsNot Nothing Then
				documentViewer.PrintingSystem.Graph.PageBackColor = Color.Gray
			End If
			documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
		End Sub
		Private Sub UpdateDocumentViewerZoom(ByVal documentViewer As XtraPrinting.Preview.DocumentViewer)
			If documentViewer Is Nothing OrElse PreviewZoom = SpreadhsheetPreviewZoom.Default Then
				Return
			End If
			documentViewer.ShowPageMargins = False
			If PreviewZoom = SpreadhsheetPreviewZoom.WholePage Then
				documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
				documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage)
				documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ScrollPageUp)
			Else
				documentViewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToTwoPages)
			End If
		End Sub
		Private Sub UpdatePrintControlProperties(ByVal pc As PrintControl)
			If pc Is Nothing OrElse CanShowBorders Then
				Return
			End If
			pc.PageBorderVisibility = DevExpress.DocumentView.PageBorderVisibility.None
			pc.ShowPageMargins = False
			pc.PrintingSystem.Graph.PageBackColor = Color.Gray
			pc.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage)
		End Sub
		Private Function CreateNewTabPage() As XtraTabPage
			Dim tabPage As New XtraTabPage()
			Me.xtraTabControl1.TabPages.Add(tabPage)
			Return tabPage
		End Function
	End Class

	Public Enum SpreadhsheetPreviewZoom
		[Default]
		WholePage
		TwoPages
	End Enum
End Namespace
