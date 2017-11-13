Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.Spreadsheet
Imports System.Collections

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class ClipboardFormats
		Inherits DevExpress.XtraTreeList.Demos.TutorialControl
        Public Overrides ReadOnly Property ExportControl() As TreeList
            Get
                Return treeList
            End Get
        End Property
		Public Sub New()
			InitializeComponent()
			Init()

		End Sub
		Private Sub Init()
			propertyGridControl.SelectedObject = treeList.OptionsClipboard
			propertyGridControl.ExpandAllRows()
			gridViewPropertiesLayoutGroup.Expanded = False
		End Sub

		Friend Sub PasteClipboardData()
			PasteHTMLFormat()
			PasteXLSFormat()
			PasteRTFFormat()
		End Sub
		Private Sub PasteRTFFormat()
			richEditControl.Document.RtfText = String.Empty
			richEditControl.Document.Text = String.Empty
            If treeList.OptionsClipboard.ClipboardMode = Export.ClipboardMode.Formatted Then
                richEditControl.Document.AppendRtfText(Clipboard.GetText(TextDataFormat.Rtf))
            Else
                richEditControl.Document.AppendText(Clipboard.GetText(TextDataFormat.UnicodeText))
			End If
		End Sub

		Private Sub PasteXLSFormat()
			spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange())
            If treeList.OptionsClipboard.ClipboardMode = Export.ClipboardMode.Formatted Then
                spreadsheetControl1.LoadDocument(TryCast(Clipboard.GetDataObject().GetData("Biff8"), Stream), DocumentFormat.Xls)
            Else
                Dim nextRow As Integer = 0
				For Each line In Clipboard.GetText(TextDataFormat.UnicodeText).Split(ControlChars.Lf)
					spreadsheetControl1.ActiveWorksheet.Import(line.Split(ControlChars.Tab), nextRow, 0, False)
					nextRow += 1
				Next line
			End If
			spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width \ treeList.Columns.Count
		End Sub

		Private Sub PasteHTMLFormat()
            If treeList.OptionsClipboard.ClipboardMode = Export.ClipboardMode.Formatted Then
                Dim html As String = Clipboard.GetText(TextDataFormat.Html)
                If String.IsNullOrEmpty(html) Then
                    webBrowser1.DocumentText = String.Empty
                    Return
                End If
                html = html.Remove(0, html.Substring(0, html.IndexOf("<html", StringComparison.OrdinalIgnoreCase)).Length)
                webBrowser1.DocumentText = html
            Else
                webBrowser1.DocumentText = "<html><body><p align=""center"">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>"
			End If
		End Sub

		Private Sub simpleButtonCopyPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			treeList.CopyAndPaste()
		End Sub

		Private Sub layoutControl1_GroupExpandChanged(ByVal sender As Object, ByVal e As XtraLayout.Utils.LayoutGroupEventArgs) Handles layoutControl1.GroupExpandChanged
			If gridViewPropertiesLayoutGroup.Expanded Then
				splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Always
			Else
				splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Never
			End If
		End Sub

		Private Sub ClipboardFormats_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			treeList.DataSource = SalesDataGenerator.CreateData()
			treeList.ExpandAll()
			treeList.ForceInitialize()
			treeList.BestFitColumns()
			treeList.SelectCells(treeList.Nodes(0), colRegion, treeList.Nodes(0).LastNode, colMarketShare)
		End Sub
	End Class
	Public Class ClipboardTreeListControl
		Inherits TreeList

		Private userControlCore As ClipboardFormats
		Friend ReadOnly Property ClipboardFormats() As ClipboardFormats
			Get
				If userControlCore Is Nothing Then
					userControlCore = TryCast(Parent.Parent, ClipboardFormats)
				End If
				Return userControlCore
			End Get
		End Property
		Public Sub CopyAndPaste()
			OnKeyDown(New KeyEventArgs(Keys.Control Or Keys.C))
		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.Control AndAlso e.KeyCode = Keys.C Then
				ClipboardFormats.PasteClipboardData()
			End If
		End Sub
	End Class
End Namespace
