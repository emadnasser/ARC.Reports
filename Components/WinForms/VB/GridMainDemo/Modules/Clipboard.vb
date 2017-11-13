Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Menu
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ClipboardTutorial
        Inherits TutorialControl

        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return gridView1
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Private Sub Init()
            gridControl1.DataSource = SaleOverviewDataGenerator.GenerateSales()
            propertyGridControl.SelectedObject = gridView1.OptionsClipboard
            propertyGridControl.ExpandAllRows()
            gridViewPropertiesLayoutGroup.Expanded = False
            gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(60, 0, 0, 240)
            gridView1.OptionsSelection.EnableAppearanceHideSelection = False
        End Sub

        Friend Sub PasteClipboardData()
            PasteHTMLFormat()
            PasteXLSFormat()
            PasteRTFFormat()
        End Sub
        Private Sub PasteRTFFormat()
            richEditControl.Document.RtfText = String.Empty
            richEditControl.Document.Text = String.Empty
            If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                richEditControl.Document.AppendRtfText(Clipboard.GetText(TextDataFormat.Rtf))
            Else
                richEditControl.Document.AppendText(Clipboard.GetText(TextDataFormat.UnicodeText))
            End If
        End Sub

        Private Sub PasteXLSFormat()
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange())
            If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
                spreadsheetControl1.LoadDocument(TryCast(Clipboard.GetDataObject().GetData("Biff8"), Stream), DocumentFormat.Xls)
            Else
                Dim nextRow As Integer = 0
                For Each line In Clipboard.GetText(TextDataFormat.UnicodeText).Split(ControlChars.Lf)
                    spreadsheetControl1.ActiveWorksheet.Import(line.Split(ControlChars.Tab), nextRow, 0, False)
                    nextRow += 1
                Next line
            End If
            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width \ gridView1.Columns.Count
        End Sub

        Private Sub PasteHTMLFormat()
            If gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Formatted Then
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

        Private Sub ClipboardTutorial_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            gridView1.BestFitColumns()
            gridView1.SelectCellAnchorRange(2, colState, 20, colMarketShare)
        End Sub
        Private Sub simpleButtonCopyPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonCopyPaste.Click
            gridControl1.CopyAndPaste()
        End Sub

        Private Sub layoutControl1_GroupExpandChanged(ByVal sender As Object, ByVal e As XtraLayout.Utils.LayoutGroupEventArgs) Handles layoutControl1.GroupExpandChanged
            If gridViewPropertiesLayoutGroup.Expanded Then
                splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Else
                splitterItemProperties.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            End If
        End Sub

        Private Sub propertyGridControl_Click(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

    End Class
    Public Class ClipboardGridControl
        Inherits GridControl

        Private userControlCore As ClipboardTutorial
        Friend ReadOnly Property ClipboardTutorial() As ClipboardTutorial
            Get
                If userControlCore Is Nothing Then
                    userControlCore = TryCast(Parent.Parent, ClipboardTutorial)
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
                ClipboardTutorial.PasteClipboardData()
            End If
        End Sub
    End Class

End Namespace
